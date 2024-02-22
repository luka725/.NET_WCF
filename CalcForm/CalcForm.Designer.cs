namespace CalcForm
{
    partial class CalcForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.n2add = new System.Windows.Forms.TextBox();
            this.n1add = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.addResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // n2add
            // 
            this.n2add.Location = new System.Drawing.Point(76, 59);
            this.n2add.Name = "n2add";
            this.n2add.Size = new System.Drawing.Size(39, 20);
            this.n2add.TabIndex = 0;
            // 
            // n1add
            // 
            this.n1add.Location = new System.Drawing.Point(12, 59);
            this.n1add.Name = "n1add";
            this.n1add.Size = new System.Drawing.Size(39, 20);
            this.n1add.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "+";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(28, 85);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Operate";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // addResult
            // 
            this.addResult.AutoSize = true;
            this.addResult.Location = new System.Drawing.Point(140, 62);
            this.addResult.Name = "addResult";
            this.addResult.Size = new System.Drawing.Size(0, 13);
            this.addResult.TabIndex = 6;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addResult);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n1add);
            this.Controls.Add(this.n2add);
            this.Name = "CalcForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalcForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox n2add;
        private System.Windows.Forms.TextBox n1add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label addResult;
    }
}

