using System;
using System.Windows.Forms;

namespace Avalo {
    static class Program {
        private static Form form;
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main() {
            try {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                CaptureManager.start();
                addNotificationIcon();

                Application.Run();
            } catch (Exception e) {
                MessageBox.Show(e.Message);
            }

        }

        static void addNotificationIcon() {
            NotifyIcon icon = new NotifyIcon();

            var menu = new ContextMenuStrip();

            //MenuItemの作成
            var setting = new ToolStripMenuItem();
            setting.Text = "&Setting";
            setting.Click += (s, e) => {
                form = new MainForm();
                form.Show();
            };

            var exit = new ToolStripMenuItem();
            exit.Text = "&Exit";
            exit.Click += (s, e) => {
                icon.Visible = false;
                icon.Dispose();
                Application.Exit();
            };

            menu.Items.Add(setting);
            menu.Items.Add(exit);
            menu.DefaultDropDownDirection = ToolStripDropDownDirection.BelowRight;

            icon.ContextMenuStrip = menu;

            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            icon.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            icon.Visible = true;
            icon.Text = "Avalo";
        }
    }
}

