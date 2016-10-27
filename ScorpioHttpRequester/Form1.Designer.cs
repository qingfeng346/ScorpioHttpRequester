namespace ScorpioHttpRequester {
    partial class Form1 {
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
            this.urlText = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlText
            // 
            this.urlText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.urlText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.urlText.FormattingEnabled = true;
            this.urlText.Location = new System.Drawing.Point(41, 12);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(411, 20);
            this.urlText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(41, 39);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(75, 23);
            this.buttonGet.TabIndex = 2;
            this.buttonGet.Text = "GET";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(122, 38);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(444, 532);
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
            this.tabPage1.Size = new System.Drawing.Size(436, 506);
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
            this.contentText.Size = new System.Drawing.Size(430, 461);
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
            this.buttonUrlDecode.Location = new System.Drawing.Point(543, 573);
            this.buttonUrlDecode.Name = "buttonUrlDecode";
            this.buttonUrlDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonUrlDecode.TabIndex = 9;
            this.buttonUrlDecode.Text = "UrlDecode";
            this.buttonUrlDecode.UseVisualStyleBackColor = true;
            this.buttonUrlDecode.Click += new System.EventHandler(this.buttonUrlDecode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 612);
            this.Controls.Add(this.buttonUrlDecode);
            this.Controls.Add(this.buttonUrlEncode);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlText);
            this.Name = "Form1";
            this.Text = "HttpRequester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox urlText;
        private System.Windows.Forms.Label label1;
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
    }
}

