namespace Avalo {
    partial class MainForm {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.originPathLabel = new System.Windows.Forms.Label();
            this.originPath = new System.Windows.Forms.TextBox();
            this.originPathButton = new System.Windows.Forms.Button();
            this.folderNameRuleLabel = new System.Windows.Forms.Label();
            this.folderNameRule = new System.Windows.Forms.TextBox();
            this.folderNameRuleExplainLabel = new System.Windows.Forms.Label();
            this.fileNameRuleLabel = new System.Windows.Forms.Label();
            this.fileNameRule = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.materialLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderExampleLabel = new System.Windows.Forms.Label();
            this.folderExample = new System.Windows.Forms.Label();
            this.fileExample = new System.Windows.Forms.Label();
            this.fileExampleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // originPathLabel
            // 
            this.originPathLabel.AutoSize = true;
            this.originPathLabel.Font = new System.Drawing.Font("BIZ UDPゴシック", 11F);
            this.originPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.originPathLabel.Location = new System.Drawing.Point(26, 28);
            this.originPathLabel.Name = "originPathLabel";
            this.originPathLabel.Size = new System.Drawing.Size(66, 15);
            this.originPathLabel.TabIndex = 1;
            this.originPathLabel.Text = "保存パス";
            // 
            // originPath
            // 
            this.originPath.Enabled = false;
            this.originPath.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.originPath.Location = new System.Drawing.Point(161, 56);
            this.originPath.Name = "originPath";
            this.originPath.Size = new System.Drawing.Size(448, 19);
            this.originPath.TabIndex = 5;
            this.originPath.TabStop = false;
            this.originPath.TextChanged += new System.EventHandler(this.originPath_TextChanged);
            // 
            // originPathButton
            // 
            this.originPathButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.originPathButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.originPathButton.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.originPathButton.Location = new System.Drawing.Point(53, 55);
            this.originPathButton.Name = "originPathButton";
            this.originPathButton.Size = new System.Drawing.Size(102, 24);
            this.originPathButton.TabIndex = 6;
            this.originPathButton.Text = "フォルダを参照する";
            this.originPathButton.UseVisualStyleBackColor = false;
            this.originPathButton.Click += new System.EventHandler(this.originPathButton_Click);
            // 
            // folderNameRuleLabel
            // 
            this.folderNameRuleLabel.AutoSize = true;
            this.folderNameRuleLabel.Font = new System.Drawing.Font("BIZ UDPゴシック", 11F);
            this.folderNameRuleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.folderNameRuleLabel.Location = new System.Drawing.Point(26, 116);
            this.folderNameRuleLabel.Name = "folderNameRuleLabel";
            this.folderNameRuleLabel.Size = new System.Drawing.Size(108, 15);
            this.folderNameRuleLabel.TabIndex = 7;
            this.folderNameRuleLabel.Text = "フォルダ名規則";
            // 
            // folderNameRule
            // 
            this.folderNameRule.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.folderNameRule.Location = new System.Drawing.Point(53, 161);
            this.folderNameRule.Name = "folderNameRule";
            this.folderNameRule.Size = new System.Drawing.Size(556, 19);
            this.folderNameRule.TabIndex = 8;
            this.folderNameRule.TabStop = false;
            this.folderNameRule.TextChanged += new System.EventHandler(this.folderNameRule_TextChanged);
            // 
            // folderNameRuleExplainLabel
            // 
            this.folderNameRuleExplainLabel.AutoSize = true;
            this.folderNameRuleExplainLabel.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F);
            this.folderNameRuleExplainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.folderNameRuleExplainLabel.Location = new System.Drawing.Point(51, 146);
            this.folderNameRuleExplainLabel.Name = "folderNameRuleExplainLabel";
            this.folderNameRuleExplainLabel.Size = new System.Drawing.Size(562, 12);
            this.folderNameRuleExplainLabel.TabIndex = 9;
            this.folderNameRuleExplainLabel.Text = "※<>の中に規則を入れることで変換されます(例: host: コンピュータのホスト名。yyyyMMdd: 年月日)";
            // 
            // fileNameRuleLabel
            // 
            this.fileNameRuleLabel.AutoSize = true;
            this.fileNameRuleLabel.Font = new System.Drawing.Font("BIZ UDPゴシック", 11F);
            this.fileNameRuleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fileNameRuleLabel.Location = new System.Drawing.Point(29, 209);
            this.fileNameRuleLabel.Name = "fileNameRuleLabel";
            this.fileNameRuleLabel.Size = new System.Drawing.Size(105, 15);
            this.fileNameRuleLabel.TabIndex = 10;
            this.fileNameRuleLabel.Text = "ファイル名規則";
            // 
            // fileNameRule
            // 
            this.fileNameRule.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fileNameRule.Location = new System.Drawing.Point(53, 252);
            this.fileNameRule.Name = "fileNameRule";
            this.fileNameRule.Size = new System.Drawing.Size(556, 19);
            this.fileNameRule.TabIndex = 11;
            this.fileNameRule.TabStop = false;
            this.fileNameRule.TextChanged += new System.EventHandler(this.fileNameRule_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(51, 237);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(449, 12);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "※<>の中に規則を入れることで変換されます(例: sn: 連番。yyyyMMdd: 年月日)";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(98, 30);
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(257, 12);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "空文字の場合はカレントフォルダに保存されます";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(140, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "空文字の場合は保存パス直下に保存されます";
            // 
            // folderExampleLabel
            // 
            this.folderExampleLabel.AutoSize = true;
            this.folderExampleLabel.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F);
            this.folderExampleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.folderExampleLabel.Location = new System.Drawing.Point(51, 183);
            this.folderExampleLabel.Name = "folderExampleLabel";
            this.folderExampleLabel.Size = new System.Drawing.Size(0, 12);
            this.folderExampleLabel.TabIndex = 15;
            // 
            // folderExample
            // 
            this.folderExample.AutoSize = true;
            this.folderExample.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F);
            this.folderExample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.folderExample.Location = new System.Drawing.Point(130, 183);
            this.folderExample.Name = "folderExample";
            this.folderExample.Size = new System.Drawing.Size(0, 12);
            this.folderExample.TabIndex = 16;
            // 
            // fileExample
            // 
            this.fileExample.AutoSize = true;
            this.fileExample.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F);
            this.fileExample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fileExample.Location = new System.Drawing.Point(120, 296);
            this.fileExample.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.fileExample.Name = "fileExample";
            this.fileExample.Size = new System.Drawing.Size(74, 12);
            this.fileExample.TabIndex = 18;
            this.fileExample.Text = "フォルダ名例";
            // 
            // fileExampleLabel
            // 
            this.fileExampleLabel.AutoSize = true;
            this.fileExampleLabel.Font = new System.Drawing.Font("BIZ UDPゴシック", 11F);
            this.fileExampleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fileExampleLabel.Location = new System.Drawing.Point(26, 295);
            this.fileExampleLabel.Name = "fileExampleLabel";
            this.fileExampleLabel.Size = new System.Drawing.Size(98, 15);
            this.fileExampleLabel.TabIndex = 17;
            this.fileExampleLabel.Text = "ファイル名例：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(707, 340);
            this.Controls.Add(this.fileExample);
            this.Controls.Add(this.fileExampleLabel);
            this.Controls.Add(this.folderExample);
            this.Controls.Add(this.folderExampleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.fileNameRule);
            this.Controls.Add(this.fileNameRuleLabel);
            this.Controls.Add(this.folderNameRuleExplainLabel);
            this.Controls.Add(this.folderNameRule);
            this.Controls.Add(this.folderNameRuleLabel);
            this.Controls.Add(this.originPathButton);
            this.Controls.Add(this.originPath);
            this.Controls.Add(this.originPathLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Setting | Avalo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originPathLabel;
        private System.Windows.Forms.TextBox originPath;
        private System.Windows.Forms.Button originPathButton;
        private System.Windows.Forms.Label folderNameRuleLabel;
        private System.Windows.Forms.TextBox folderNameRule;
        private System.Windows.Forms.Label folderNameRuleExplainLabel;
        private System.Windows.Forms.Label fileNameRuleLabel;
        private System.Windows.Forms.TextBox fileNameRule;
        private System.Windows.Forms.Label materialLabel1;
        private System.Windows.Forms.Label materialLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label folderExampleLabel;
        private System.Windows.Forms.Label folderExample;
        private System.Windows.Forms.Label fileExample;
        private System.Windows.Forms.Label fileExampleLabel;
    }
}

