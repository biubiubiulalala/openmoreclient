using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weixinduokai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private string softInstallPath = "";
        private bool installed = false;//是否已安装了
        private int num = 1;//要启动客户端数量
        private void Init()
        {
            installed = GetSoftWare("微信", out softInstallPath);
            if (!installed)
                MessageBox.Show("未检测到微信安装信息，请检查是否已安装\n或手动指定安装路径");
            //else
            //    MessageBox.Show(softInstallPath);

            clientTextBox.Text = "1";
            selectPath.Text = $"自动获取成功：{softInstallPath}";
        }

        private void WeChatButton_Click(object sender, EventArgs e)
        {
            try
            {
                num = int.Parse(clientTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"请检测数量书否输入合法！！！\n{ex.Message}");
                return;
            }

            if (string.IsNullOrEmpty(softInstallPath))
                MessageBox.Show("未检测到微信安装信息，请检查是否已安装\n或手动指定安装路径");
            else
            {
                string applicationPath = $"{softInstallPath}/WeChat.exe";
                for (int i = 0; i < num; i++)
                {
                    try
                    {
                        // 启动应用程序
                        Process.Start(applicationPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("卧槽启动失败：" + ex.Message);
                        return;
                    }
                }


            }
        }






        /// <summary>
        /// 软件是否安转
        /// </summary>
        /// <param name="SoftWareName"> 软件名称</param>
        /// <param name="SoftWarePath "> 安装路径</param>
        /// <returns> true or false </returns>
        public static bool GetSoftWare(string SoftWareName, out string SoftWarePath)
        {
            SoftWarePath = null;
            List<RegistryKey> RegistryKeys = new List<RegistryKey>();
            RegistryKeys.Add(Registry.ClassesRoot);
            RegistryKeys.Add(Registry.CurrentConfig);
            RegistryKeys.Add(Registry.CurrentUser);
            RegistryKeys.Add(Registry.LocalMachine);
            RegistryKeys.Add(Registry.PerformanceData);
            RegistryKeys.Add(Registry.Users);
            Dictionary<string, string> Softwares = new Dictionary<string, string>();
            string SubKeyName = @"Software\Microsoft\Windows\CurrentVersion\Uninstall";
            foreach (RegistryKey Registrykey in RegistryKeys)
            {
                using (RegistryKey RegistryKey1 = Registrykey.OpenSubKey(SubKeyName, false))
                {
                    if (RegistryKey1 == null) // 判断对象不存在
                        continue;
                    if (RegistryKey1.GetSubKeyNames() == null)
                        continue;
                    string[] KeyNames = RegistryKey1.GetSubKeyNames();
                    foreach (string KeyName in KeyNames)// 遍历子项名称的字符串数组
                    {
                        using (RegistryKey RegistryKey2 = RegistryKey1.OpenSubKey(KeyName, false)) // 遍历子项节点
                        {
                            if (RegistryKey2 == null)
                                continue;
                            string SoftwareName = RegistryKey2.GetValue("DisplayName", "").ToString(); // 获取软件名
                            string InstallLocation = RegistryKey2.GetValue("InstallLocation", "").ToString(); // 获取安装路径
                            if (!string.IsNullOrEmpty(InstallLocation)
                             && !string.IsNullOrEmpty(SoftwareName))
                            {
                                if (!Softwares.ContainsKey(SoftwareName))
                                    Softwares.Add(SoftwareName, InstallLocation);
                            }
                        }
                    }
                }
            }
            if (Softwares.Count <= 0)
                return false;
            foreach (string SoftwareName in Softwares.Keys)
            {
                if (SoftwareName.Contains(SoftWareName))
                {
                    SoftWarePath = Softwares[SoftwareName];
                    return true;
                }
            }
            return false;
        }

        private void clientTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 如果输入的不是数字键，且不是控制键（例如Backspace），则取消该次按键输入
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // 取消该次按键输入
            }

            // 额外的逻辑，如果需要可以取消注释
            // 如果是在文本的开头输入0，也取消（避免输入如"01"这样的非法数字）
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == '0' && textBox.SelectionStart == 0)
            {
                e.Handled = true;
            }
        }

        private void selectPath_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog folder = new System.Windows.Forms.FolderBrowserDialog();

            folder.Description = "提示：找到并选中 WeChat 文件夹然后点击确定即可";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                softInstallPath = folder.SelectedPath;
                selectPath.Text = $"你选择的路径为：{softInstallPath}";

            }

        }
    }
}
