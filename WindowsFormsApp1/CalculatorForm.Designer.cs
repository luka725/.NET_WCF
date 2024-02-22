namespace WindowsFormsApp1
{
    partial class CalculatorForm
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
            this.addResult = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.n2add = new System.Windows.Forms.TextBox();
            this.n1add = new System.Windows.Forms.TextBox();
            this.subResult = new System.Windows.Forms.Label();
            this.subBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.n2sub = new System.Windows.Forms.TextBox();
            this.n1sub = new System.Windows.Forms.TextBox();
            this.divResult = new System.Windows.Forms.Label();
            this.divBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.n2div = new System.Windows.Forms.TextBox();
            this.n1div = new System.Windows.Forms.TextBox();
            this.multResult = new System.Windows.Forms.Label();
            this.multBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.n2mult = new System.Windows.Forms.TextBox();
            this.n1mult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addResult
            // 
            this.addResult.AutoSize = true;
            this.addResult.Location = new System.Drawing.Point(148, 63);
            this.addResult.Name = "addResult";
            this.addResult.Size = new System.Drawing.Size(0, 13);
            this.addResult.TabIndex = 12;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(36, 86);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Calculate";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "=";
            // 
            // n2add
            // 
            this.n2add.Location = new System.Drawing.Point(84, 60);
            this.n2add.Name = "n2add";
            this.n2add.Size = new System.Drawing.Size(39, 20);
            this.n2add.TabIndex = 8;
            // 
            // n1add
            // 
            this.n1add.Location = new System.Drawing.Point(20, 60);
            this.n1add.Name = "n1add";
            this.n1add.Size = new System.Drawing.Size(39, 20);
            this.n1add.TabIndex = 7;
            // 
            // subResult
            // 
            this.subResult.AutoSize = true;
            this.subResult.Location = new System.Drawing.Point(148, 144);
            this.subResult.Name = "subResult";
            this.subResult.Size = new System.Drawing.Size(0, 13);
            this.subResult.TabIndex = 18;
            // 
            // subBtn
            // 
            this.subBtn.Location = new System.Drawing.Point(36, 167);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(75, 23);
            this.subBtn.TabIndex = 17;
            this.subBtn.Text = "Calculate";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "=";
            // 
            // n2sub
            // 
            this.n2sub.Location = new System.Drawing.Point(84, 141);
            this.n2sub.Name = "n2sub";
            this.n2sub.Size = new System.Drawing.Size(39, 20);
            this.n2sub.TabIndex = 14;
            // 
            // n1sub
            // 
            this.n1sub.Location = new System.Drawing.Point(20, 141);
            this.n1sub.Name = "n1sub";
            this.n1sub.Size = new System.Drawing.Size(39, 20);
            this.n1sub.TabIndex = 13;
            // 
            // divResult
            // 
            this.divResult.AutoSize = true;
            this.divResult.Location = new System.Drawing.Point(148, 218);
            this.divResult.Name = "divResult";
            this.divResult.Size = new System.Drawing.Size(0, 13);
            this.divResult.TabIndex = 24;
            // 
            // divBtn
            // 
            this.divBtn.Location = new System.Drawing.Point(36, 241);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(75, 23);
            this.divBtn.TabIndex = 23;
            this.divBtn.Text = "Calculate";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "=";
            // 
            // n2div
            // 
            this.n2div.Location = new System.Drawing.Point(84, 215);
            this.n2div.Name = "n2div";
            this.n2div.Size = new System.Drawing.Size(39, 20);
            this.n2div.TabIndex = 20;
            // 
            // n1div
            // 
            this.n1div.Location = new System.Drawing.Point(20, 215);
            this.n1div.Name = "n1div";
            this.n1div.Size = new System.Drawing.Size(39, 20);
            this.n1div.TabIndex = 19;
            // 
            // multResult
            // 
            this.multResult.AutoSize = true;
            this.multResult.Location = new System.Drawing.Point(148, 292);
            this.multResult.Name = "multResult";
            this.multResult.Size = new System.Drawing.Size(0, 13);
            this.multResult.TabIndex = 30;
            // 
            // multBtn
            // 
            this.multBtn.Location = new System.Drawing.Point(36, 315);
            this.multBtn.Name = "multBtn";
            this.multBtn.Size = new System.Drawing.Size(75, 23);
            this.multBtn.TabIndex = 29;
            this.multBtn.Text = "Calculate";
            this.multBtn.UseVisualStyleBackColor = true;
            this.multBtn.Click += new System.EventHandler(this.multBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "=";
            // 
            // n2mult
            // 
            this.n2mult.Location = new System.Drawing.Point(84, 289);
            this.n2mult.Name = "n2mult";
            this.n2mult.Size = new System.Drawing.Size(39, 20);
            this.n2mult.TabIndex = 26;
            // 
            // n1mult
            // 
            this.n1mult.Location = new System.Drawing.Point(20, 289);
            this.n1mult.Name = "n1mult";
            this.n1mult.Size = new System.Drawing.Size(39, 20);
            this.n1mult.TabIndex = 25;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.multResult);
            this.Controls.Add(this.multBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.n2mult);
            this.Controls.Add(this.n1mult);
            this.Controls.Add(this.divResult);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.n2div);
            this.Controls.Add(this.n1div);
            this.Controls.Add(this.subResult);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.n2sub);
            this.Controls.Add(this.n1sub);
            this.Controls.Add(this.addResult);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n2add);
            this.Controls.Add(this.n1add);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addResult;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n2add;
        private System.Windows.Forms.TextBox n1add;
        private System.Windows.Forms.Label subResult;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox n2sub;
        private System.Windows.Forms.TextBox n1sub;
        private System.Windows.Forms.Label divResult;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox n2div;
        private System.Windows.Forms.TextBox n1div;
        private System.Windows.Forms.Label multResult;
        private System.Windows.Forms.Button multBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox n2mult;
        private System.Windows.Forms.TextBox n1mult;
    }
}

