namespace CDICollegeATMMachine {
    partial class Supervisor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ClientDataGroupBox = new System.Windows.Forms.GroupBox();
            this.BankBalanceLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KeyPadGB = new System.Windows.Forms.GroupBox();
            this.KeyPadTxt = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.supervisorKeyPad = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.PrintAccountBtn = new System.Windows.Forms.Button();
            this.OutOfServiceBtn = new System.Windows.Forms.Button();
            this.RefillAtmBtn = new System.Windows.Forms.Button();
            this.PayIntrestBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ClientDataGroupBox.SuspendLayout();
            this.KeyPadGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientDataGroupBox
            // 
            this.ClientDataGroupBox.Controls.Add(this.button1);
            this.ClientDataGroupBox.Controls.Add(this.BankBalanceLbl);
            this.ClientDataGroupBox.Controls.Add(this.label1);
            this.ClientDataGroupBox.Controls.Add(this.KeyPadGB);
            this.ClientDataGroupBox.Controls.Add(this.PrintAccountBtn);
            this.ClientDataGroupBox.Controls.Add(this.OutOfServiceBtn);
            this.ClientDataGroupBox.Controls.Add(this.RefillAtmBtn);
            this.ClientDataGroupBox.Controls.Add(this.PayIntrestBtn);
            this.ClientDataGroupBox.Location = new System.Drawing.Point(26, 22);
            this.ClientDataGroupBox.Name = "ClientDataGroupBox";
            this.ClientDataGroupBox.Size = new System.Drawing.Size(707, 390);
            this.ClientDataGroupBox.TabIndex = 4;
            this.ClientDataGroupBox.TabStop = false;
            this.ClientDataGroupBox.Text = "Supervisor Menu";
            // 
            // BankBalanceLbl
            // 
            this.BankBalanceLbl.AutoSize = true;
            this.BankBalanceLbl.Location = new System.Drawing.Point(169, 262);
            this.BankBalanceLbl.Name = "BankBalanceLbl";
            this.BankBalanceLbl.Size = new System.Drawing.Size(0, 13);
            this.BankBalanceLbl.TabIndex = 6;
            this.BankBalanceLbl.Click += new System.EventHandler(this.BankBalanceLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bank ATM Balance: ";
            // 
            // KeyPadGB
            // 
            this.KeyPadGB.Controls.Add(this.KeyPadTxt);
            this.KeyPadGB.Controls.Add(this.button11);
            this.KeyPadGB.Controls.Add(this.button10);
            this.KeyPadGB.Controls.Add(this.button9);
            this.KeyPadGB.Controls.Add(this.button8);
            this.KeyPadGB.Controls.Add(this.button7);
            this.KeyPadGB.Controls.Add(this.button6);
            this.KeyPadGB.Controls.Add(this.supervisorKeyPad);
            this.KeyPadGB.Controls.Add(this.button4);
            this.KeyPadGB.Controls.Add(this.button12);
            this.KeyPadGB.Controls.Add(this.button13);
            this.KeyPadGB.Controls.Add(this.button14);
            this.KeyPadGB.Location = new System.Drawing.Point(373, 19);
            this.KeyPadGB.Name = "KeyPadGB";
            this.KeyPadGB.Size = new System.Drawing.Size(279, 294);
            this.KeyPadGB.TabIndex = 4;
            this.KeyPadGB.TabStop = false;
            this.KeyPadGB.Text = "Key Pad";
            // 
            // KeyPadTxt
            // 
            this.KeyPadTxt.Location = new System.Drawing.Point(49, 217);
            this.KeyPadTxt.Name = "KeyPadTxt";
            this.KeyPadTxt.Size = new System.Drawing.Size(163, 20);
            this.KeyPadTxt.TabIndex = 1;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(190, 164);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(65, 30);
            this.button11.TabIndex = 24;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(101, 164);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(65, 30);
            this.button10.TabIndex = 23;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(190, 71);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 30);
            this.button9.TabIndex = 22;
            this.button9.Text = "6";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(190, 119);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 30);
            this.button8.TabIndex = 21;
            this.button8.Text = "9";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(101, 119);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 30);
            this.button7.TabIndex = 20;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(101, 71);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 30);
            this.button6.TabIndex = 19;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // supervisorKeyPad
            // 
            this.supervisorKeyPad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisorKeyPad.Location = new System.Drawing.Point(190, 28);
            this.supervisorKeyPad.Name = "supervisorKeyPad";
            this.supervisorKeyPad.Size = new System.Drawing.Size(65, 30);
            this.supervisorKeyPad.TabIndex = 18;
            this.supervisorKeyPad.Text = "3";
            this.supervisorKeyPad.UseVisualStyleBackColor = true;
            this.supervisorKeyPad.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(6, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 30);
            this.button4.TabIndex = 17;
            this.button4.Text = "7";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(101, 28);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(65, 30);
            this.button12.TabIndex = 16;
            this.button12.Text = "2";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(6, 71);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(65, 30);
            this.button13.TabIndex = 15;
            this.button13.Text = "4";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(6, 28);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(65, 30);
            this.button14.TabIndex = 14;
            this.button14.Text = "1";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // PrintAccountBtn
            // 
            this.PrintAccountBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintAccountBtn.Location = new System.Drawing.Point(15, 150);
            this.PrintAccountBtn.Name = "PrintAccountBtn";
            this.PrintAccountBtn.Size = new System.Drawing.Size(186, 23);
            this.PrintAccountBtn.TabIndex = 3;
            this.PrintAccountBtn.Text = "Print the Accounts Report";
            this.PrintAccountBtn.UseVisualStyleBackColor = true;
            // 
            // OutOfServiceBtn
            // 
            this.OutOfServiceBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutOfServiceBtn.Location = new System.Drawing.Point(15, 112);
            this.OutOfServiceBtn.Name = "OutOfServiceBtn";
            this.OutOfServiceBtn.Size = new System.Drawing.Size(186, 23);
            this.OutOfServiceBtn.TabIndex = 2;
            this.OutOfServiceBtn.Text = "Take the ATM out of service";
            this.OutOfServiceBtn.UseVisualStyleBackColor = true;
            this.OutOfServiceBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // RefillAtmBtn
            // 
            this.RefillAtmBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefillAtmBtn.Location = new System.Drawing.Point(15, 74);
            this.RefillAtmBtn.Name = "RefillAtmBtn";
            this.RefillAtmBtn.Size = new System.Drawing.Size(186, 23);
            this.RefillAtmBtn.TabIndex = 1;
            this.RefillAtmBtn.Text = "Refill the ATM with Money";
            this.RefillAtmBtn.UseVisualStyleBackColor = true;
            this.RefillAtmBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // PayIntrestBtn
            // 
            this.PayIntrestBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayIntrestBtn.Location = new System.Drawing.Point(15, 35);
            this.PayIntrestBtn.Name = "PayIntrestBtn";
            this.PayIntrestBtn.Size = new System.Drawing.Size(186, 23);
            this.PayIntrestBtn.TabIndex = 0;
            this.PayIntrestBtn.Text = "Pay Intrest";
            this.PayIntrestBtn.UseVisualStyleBackColor = true;
            this.PayIntrestBtn.Click += new System.EventHandler(this.PayIntrestBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Supervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 508);
            this.Controls.Add(this.ClientDataGroupBox);
            this.Name = "Supervisor";
            this.Text = "Supervisor";
            this.ClientDataGroupBox.ResumeLayout(false);
            this.ClientDataGroupBox.PerformLayout();
            this.KeyPadGB.ResumeLayout(false);
            this.KeyPadGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ClientDataGroupBox;
        private System.Windows.Forms.Button PrintAccountBtn;
        private System.Windows.Forms.Button OutOfServiceBtn;
        private System.Windows.Forms.Button RefillAtmBtn;
        private System.Windows.Forms.Button PayIntrestBtn;
        private System.Windows.Forms.GroupBox KeyPadGB;
        private System.Windows.Forms.TextBox KeyPadTxt;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button supervisorKeyPad;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label BankBalanceLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}