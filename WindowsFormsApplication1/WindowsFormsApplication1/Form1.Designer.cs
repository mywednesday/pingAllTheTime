namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.timeoutTextBox = new System.Windows.Forms.TextBox();
            this.ipStartTextBox = new System.Windows.Forms.TextBox();
            this.ipEndTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pingButton
            // 
            this.pingButton.Location = new System.Drawing.Point(456, 10);
            this.pingButton.Name = "pingButton";
            this.pingButton.Size = new System.Drawing.Size(75, 23);
            this.pingButton.TabIndex = 3;
            this.pingButton.Text = "Ping";
            this.pingButton.UseVisualStyleBackColor = true;
            this.pingButton.Click += new System.EventHandler(this.pingButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "End:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(14, 39);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(517, 323);
            this.outputTextBox.TabIndex = 4;
            this.outputTextBox.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(14, 367);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(517, 3);
            this.progressBar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Timeout(s):";
            // 
            // timeoutTextBox
            // 
            this.timeoutTextBox.Location = new System.Drawing.Point(405, 12);
            this.timeoutTextBox.Name = "timeoutTextBox";
            this.timeoutTextBox.Size = new System.Drawing.Size(35, 21);
            this.timeoutTextBox.TabIndex = 2;
            this.timeoutTextBox.Text = "5";
            this.timeoutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeoutTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeoutTextBox_KeyPress);
            // 
            // ipStartTextBox
            // 
            this.ipStartTextBox.Location = new System.Drawing.Point(53, 12);
            this.ipStartTextBox.Name = "ipStartTextBox";
            this.ipStartTextBox.Size = new System.Drawing.Size(98, 21);
            this.ipStartTextBox.TabIndex = 0;
            // 
            // ipEndTextBox
            // 
            this.ipEndTextBox.Location = new System.Drawing.Point(205, 12);
            this.ipEndTextBox.Name = "ipEndTextBox";
            this.ipEndTextBox.Size = new System.Drawing.Size(98, 21);
            this.ipEndTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 380);
            this.Controls.Add(this.ipEndTextBox);
            this.Controls.Add(this.ipStartTextBox);
            this.Controls.Add(this.timeoutTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pingButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IP探测工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pingButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeoutTextBox;
        private System.Windows.Forms.TextBox ipStartTextBox;
        private System.Windows.Forms.TextBox ipEndTextBox;
    }
}

