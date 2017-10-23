namespace ScorpioHttpRequester {
    partial class FormMain {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.urlText = new System.Windows.Forms.ComboBox();
            this.buttonGet = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.contentTypeText = new System.Windows.Forms.ComboBox();
            this.contentText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.RichTextBox();
            this.buttonUrlEncode = new System.Windows.Forms.Button();
            this.buttonUrlDecode = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboEncodeResult = new System.Windows.Forms.ComboBox();
            this.comboEncodeRequest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlText
            // 
            this.urlText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.urlText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.urlText.FormattingEnabled = true;
            this.urlText.Location = new System.Drawing.Point(12, 20);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(411, 20);
            this.urlText.TabIndex = 0;
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(19, 87);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(75, 23);
            this.buttonGet.TabIndex = 2;
            this.buttonGet.Text = "GET";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(100, 87);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 3;
            this.buttonPost.Text = "POST";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(460, 15);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(53, 12);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status :";
            // 
            // resultText
            // 
            this.resultText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultText.Location = new System.Drawing.Point(462, 275);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(488, 287);
            this.resultText.TabIndex = 5;
            this.resultText.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 126);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 474);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.contentTypeText);
            this.tabPage1.Controls.Add(this.contentText);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(432, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // contentTypeText
            // 
            this.contentTypeText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.contentTypeText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.contentTypeText.FormattingEnabled = true;
            this.contentTypeText.Location = new System.Drawing.Point(101, 10);
            this.contentTypeText.Name = "contentTypeText";
            this.contentTypeText.Size = new System.Drawing.Size(329, 20);
            this.contentTypeText.TabIndex = 2;
            // 
            // contentText
            // 
            this.contentText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentText.Location = new System.Drawing.Point(3, 39);
            this.contentText.Name = "contentText";
            this.contentText.Size = new System.Drawing.Size(423, 403);
            this.contentText.TabIndex = 1;
            this.contentText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Content Type :";
            // 
            // statusText
            // 
            this.statusText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusText.Location = new System.Drawing.Point(462, 38);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(488, 231);
            this.statusText.TabIndex = 7;
            this.statusText.Text = "";
            // 
            // buttonUrlEncode
            // 
            this.buttonUrlEncode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUrlEncode.Location = new System.Drawing.Point(462, 573);
            this.buttonUrlEncode.Name = "buttonUrlEncode";
            this.buttonUrlEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonUrlEncode.TabIndex = 8;
            this.buttonUrlEncode.Text = "UrlEncode";
            this.buttonUrlEncode.UseVisualStyleBackColor = true;
            this.buttonUrlEncode.Click += new System.EventHandler(this.buttonUrlEncode_Click);
            // 
            // buttonUrlDecode
            // 
            this.buttonUrlDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUrlDecode.Location = new System.Drawing.Point(543, 573);
            this.buttonUrlDecode.Name = "buttonUrlDecode";
            this.buttonUrlDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonUrlDecode.TabIndex = 9;
            this.buttonUrlDecode.Text = "UrlDecode";
            this.buttonUrlDecode.UseVisualStyleBackColor = true;
            this.buttonUrlDecode.Click += new System.EventHandler(this.buttonUrlDecode_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(44, 21);
            this.MenuAbout.Text = "关于";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.urlText);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 53);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "URL";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(719, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "返回数据编码";
            // 
            // comboEncodeResult
            // 
            this.comboEncodeResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboEncodeResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEncodeResult.FormattingEnabled = true;
            this.comboEncodeResult.Location = new System.Drawing.Point(800, 575);
            this.comboEncodeResult.Name = "comboEncodeResult";
            this.comboEncodeResult.Size = new System.Drawing.Size(150, 20);
            this.comboEncodeResult.TabIndex = 14;
            this.comboEncodeResult.SelectedIndexChanged += new System.EventHandler(this.comboEncodeResult_SelectedIndexChanged);
            // 
            // comboEncodeRequest
            // 
            this.comboEncodeRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEncodeRequest.FormattingEnabled = true;
            this.comboEncodeRequest.Location = new System.Drawing.Point(302, 89);
            this.comboEncodeRequest.Name = "comboEncodeRequest";
            this.comboEncodeRequest.Size = new System.Drawing.Size(150, 20);
            this.comboEncodeRequest.TabIndex = 16;
            this.comboEncodeRequest.SelectedIndexChanged += new System.EventHandler(this.comboEncodeRequest_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "POST数据编码";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 612);
            this.Controls.Add(this.comboEncodeRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboEncodeResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonUrlDecode);
            this.Controls.Add(this.buttonUrlEncode);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "HttpRequester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox urlText;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.RichTextBox resultText;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox contentTypeText;
        private System.Windows.Forms.RichTextBox contentText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox statusText;
        private System.Windows.Forms.Button buttonUrlEncode;
        private System.Windows.Forms.Button buttonUrlDecode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEncodeResult;
        private System.Windows.Forms.ComboBox comboEncodeRequest;
        private System.Windows.Forms.Label label2;
    }
}

