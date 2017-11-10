namespace WindowsFormsApplication1
{
    partial class นนิกร
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.Label();
            this.nontikorn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sssss = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "กรุณาใส่ชื่อนามสกุล";
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(131, 157);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(99, 40);
            this.btn_enter.TabIndex = 3;
            this.btn_enter.Text = "ยืนยัน";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Location = new System.Drawing.Point(155, 227);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(40, 13);
            this.lb_result.TabIndex = 4;
            this.lb_result.Text = "ผลลัพธ์";
            // 
            // nontikorn
            // 
            this.nontikorn.Location = new System.Drawing.Point(158, 61);
            this.nontikorn.Name = "nontikorn";
            this.nontikorn.Size = new System.Drawing.Size(122, 20);
            this.nontikorn.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "กรุณาใส่รหัสนักศึกษา";
            // 
            // sssss
            // 
            this.sssss.Location = new System.Drawing.Point(158, 101);
            this.sssss.Name = "sssss";
            this.sssss.Size = new System.Drawing.Size(122, 20);
            this.sssss.TabIndex = 7;
            // 
            // นนิกร
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 308);
            this.Controls.Add(this.sssss);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nontikorn);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.label1);
            this.Name = "นนิกร";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.TextBox nontikorn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sssss;
    }
}

