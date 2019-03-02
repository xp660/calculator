namespace TextCalculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.comboBoxOp = new System.Windows.Forms.ComboBox();
            this.textBoxNumber2 = new System.Windows.Forms.TextBox();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNumber1
            // 
            this.textBoxNumber1.Location = new System.Drawing.Point(68, 139);
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(100, 25);
            this.textBoxNumber1.TabIndex = 0;
            this.textBoxNumber1.Text = "0";
            // 
            // comboBoxOp
            // 
            this.comboBoxOp.FormattingEnabled = true;
            this.comboBoxOp.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxOp.Location = new System.Drawing.Point(209, 140);
            this.comboBoxOp.Name = "comboBoxOp";
            this.comboBoxOp.Size = new System.Drawing.Size(121, 23);
            this.comboBoxOp.TabIndex = 1;
            this.comboBoxOp.Text = "+";
            // 
            // textBoxNumber2
            // 
            this.textBoxNumber2.Location = new System.Drawing.Point(383, 140);
            this.textBoxNumber2.Name = "textBoxNumber2";
            this.textBoxNumber2.Size = new System.Drawing.Size(100, 25);
            this.textBoxNumber2.TabIndex = 2;
            this.textBoxNumber2.Text = "0";
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(535, 141);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(75, 23);
            this.buttonEqual.TabIndex = 3;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(664, 138);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 25);
            this.textBoxResult.TabIndex = 4;
            this.textBoxResult.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 253);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.textBoxNumber2);
            this.Controls.Add(this.comboBoxOp);
            this.Controls.Add(this.textBoxNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumber1;
        private System.Windows.Forms.ComboBox comboBoxOp;
        private System.Windows.Forms.TextBox textBoxNumber2;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

