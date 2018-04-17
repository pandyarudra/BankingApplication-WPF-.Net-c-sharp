namespace accounts
{
    partial class Form2
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
            this.accountSelect = new System.Windows.Forms.Button();
            this.accountsDisplay = new System.Windows.Forms.Button();
            this.allAccountsLst = new System.Windows.Forms.ListBox();
            this.monthlyReport = new System.Windows.Forms.Button();
            this.accountDetail = new System.Windows.Forms.ListBox();
            this.detailDisplay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sinBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iniHolder = new System.Windows.Forms.TextBox();
            this.iniBalance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.accountAddConfirm = new System.Windows.Forms.Button();
            this.accountAddClear = new System.Windows.Forms.Button();
            this.rBtnSA = new System.Windows.Forms.RadioButton();
            this.rBtnCK = new System.Windows.Forms.RadioButton();
            this.rBtnVS = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.transWD = new System.Windows.Forms.RadioButton();
            this.transDP = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.transAmount = new System.Windows.Forms.TextBox();
            this.transConfirm = new System.Windows.Forms.Button();
            this.stAcc = new System.Windows.Forms.Label();
            this.stTime = new System.Windows.Forms.Label();
            this.stName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountSelect
            // 
            this.accountSelect.Location = new System.Drawing.Point(160, 118);
            this.accountSelect.Name = "accountSelect";
            this.accountSelect.Size = new System.Drawing.Size(75, 23);
            this.accountSelect.TabIndex = 13;
            this.accountSelect.Text = "Select";
            this.accountSelect.UseVisualStyleBackColor = true;
            this.accountSelect.Click += new System.EventHandler(this.accountSelect_Click_1);
            // 
            // accountsDisplay
            // 
            this.accountsDisplay.Location = new System.Drawing.Point(71, 118);
            this.accountsDisplay.Name = "accountsDisplay";
            this.accountsDisplay.Size = new System.Drawing.Size(75, 23);
            this.accountsDisplay.TabIndex = 12;
            this.accountsDisplay.Text = "Accounts";
            this.accountsDisplay.UseVisualStyleBackColor = true;
            this.accountsDisplay.Click += new System.EventHandler(this.accountsDisplay_Click_1);
            // 
            // allAccountsLst
            // 
            this.allAccountsLst.AccessibleName = "";
            this.allAccountsLst.FormattingEnabled = true;
            this.allAccountsLst.ItemHeight = 12;
            this.allAccountsLst.Location = new System.Drawing.Point(45, 36);
            this.allAccountsLst.Name = "allAccountsLst";
            this.allAccountsLst.Size = new System.Drawing.Size(214, 76);
            this.allAccountsLst.TabIndex = 11;
            // 
            // monthlyReport
            // 
            this.monthlyReport.Location = new System.Drawing.Point(158, 411);
            this.monthlyReport.Name = "monthlyReport";
            this.monthlyReport.Size = new System.Drawing.Size(164, 23);
            this.monthlyReport.TabIndex = 29;
            this.monthlyReport.Text = "Run Monthly Report";
            this.monthlyReport.UseVisualStyleBackColor = true;
            this.monthlyReport.Click += new System.EventHandler(this.monthlyReport_Click);
            // 
            // accountDetail
            // 
            this.accountDetail.FormattingEnabled = true;
            this.accountDetail.ItemHeight = 12;
            this.accountDetail.Location = new System.Drawing.Point(45, 318);
            this.accountDetail.Name = "accountDetail";
            this.accountDetail.Size = new System.Drawing.Size(349, 88);
            this.accountDetail.TabIndex = 27;
            // 
            // detailDisplay
            // 
            this.detailDisplay.Location = new System.Drawing.Point(45, 412);
            this.detailDisplay.Name = "detailDisplay";
            this.detailDisplay.Size = new System.Drawing.Size(75, 23);
            this.detailDisplay.TabIndex = 28;
            this.detailDisplay.Text = "Details";
            this.detailDisplay.UseVisualStyleBackColor = true;
            this.detailDisplay.Click += new System.EventHandler(this.detailDisplay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sinBox);
            this.groupBox1.Controls.Add(this.rBtnCK);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.rBtnVS);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.rBtnSA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.accountAddClear);
            this.groupBox1.Controls.Add(this.iniHolder);
            this.groupBox1.Controls.Add(this.accountAddConfirm);
            this.groupBox1.Controls.Add(this.iniBalance);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(455, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 347);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add User and Account";
            // 
            // sinBox
            // 
            this.sinBox.Location = new System.Drawing.Point(66, 269);
            this.sinBox.Name = "sinBox";
            this.sinBox.Size = new System.Drawing.Size(100, 21);
            this.sinBox.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 51;
            this.label5.Text = "SIN";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(91, 316);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 50;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(66, 237);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 21);
            this.nameBox.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 47;
            this.label3.Text = "User";
            // 
            // iniHolder
            // 
            this.iniHolder.Location = new System.Drawing.Point(229, 101);
            this.iniHolder.Name = "iniHolder";
            this.iniHolder.Size = new System.Drawing.Size(100, 21);
            this.iniHolder.TabIndex = 46;
            // 
            // iniBalance
            // 
            this.iniBalance.Location = new System.Drawing.Point(58, 104);
            this.iniBalance.Name = "iniBalance";
            this.iniBalance.Size = new System.Drawing.Size(100, 21);
            this.iniBalance.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 45;
            this.label8.Text = "User";
            // 
            // accountAddConfirm
            // 
            this.accountAddConfirm.Location = new System.Drawing.Point(91, 149);
            this.accountAddConfirm.Name = "accountAddConfirm";
            this.accountAddConfirm.Size = new System.Drawing.Size(75, 23);
            this.accountAddConfirm.TabIndex = 44;
            this.accountAddConfirm.Text = "confirm";
            this.accountAddConfirm.UseVisualStyleBackColor = true;
            this.accountAddConfirm.Click += new System.EventHandler(this.accountAddConfirm_Click_1);
            // 
            // accountAddClear
            // 
            this.accountAddClear.Location = new System.Drawing.Point(9, 149);
            this.accountAddClear.Name = "accountAddClear";
            this.accountAddClear.Size = new System.Drawing.Size(75, 23);
            this.accountAddClear.TabIndex = 43;
            this.accountAddClear.Text = "clear";
            this.accountAddClear.UseVisualStyleBackColor = true;
            this.accountAddClear.Click += new System.EventHandler(this.accountAddClear_Click);
            // 
            // rBtnSA
            // 
            this.rBtnSA.AutoSize = true;
            this.rBtnSA.Location = new System.Drawing.Point(229, 52);
            this.rBtnSA.Name = "rBtnSA";
            this.rBtnSA.Size = new System.Drawing.Size(59, 16);
            this.rBtnSA.TabIndex = 42;
            this.rBtnSA.TabStop = true;
            this.rBtnSA.Text = "Saving";
            this.rBtnSA.UseVisualStyleBackColor = true;
            // 
            // rBtnCK
            // 
            this.rBtnCK.AutoSize = true;
            this.rBtnCK.Location = new System.Drawing.Point(152, 50);
            this.rBtnCK.Name = "rBtnCK";
            this.rBtnCK.Size = new System.Drawing.Size(71, 16);
            this.rBtnCK.TabIndex = 41;
            this.rBtnCK.TabStop = true;
            this.rBtnCK.Text = "Chequing";
            this.rBtnCK.UseVisualStyleBackColor = true;
            // 
            // rBtnVS
            // 
            this.rBtnVS.AutoSize = true;
            this.rBtnVS.Location = new System.Drawing.Point(88, 50);
            this.rBtnVS.Name = "rBtnVS";
            this.rBtnVS.Size = new System.Drawing.Size(47, 16);
            this.rBtnVS.TabIndex = 40;
            this.rBtnVS.TabStop = true;
            this.rBtnVS.Text = "Visa";
            this.rBtnVS.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 39;
            this.label7.Text = "Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 37;
            this.label6.Text = "Account Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.transWD);
            this.groupBox2.Controls.Add(this.transDP);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.transAmount);
            this.groupBox2.Controls.Add(this.transConfirm);
            this.groupBox2.Location = new System.Drawing.Point(45, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 136);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transactions";
            // 
            // transWD
            // 
            this.transWD.AutoSize = true;
            this.transWD.Location = new System.Drawing.Point(24, 30);
            this.transWD.Name = "transWD";
            this.transWD.Size = new System.Drawing.Size(71, 16);
            this.transWD.TabIndex = 14;
            this.transWD.TabStop = true;
            this.transWD.Text = "withdraw";
            this.transWD.UseVisualStyleBackColor = true;
            // 
            // transDP
            // 
            this.transDP.AutoSize = true;
            this.transDP.Location = new System.Drawing.Point(170, 30);
            this.transDP.Name = "transDP";
            this.transDP.Size = new System.Drawing.Size(71, 16);
            this.transDP.TabIndex = 15;
            this.transDP.TabStop = true;
            this.transDP.Text = "deposite";
            this.transDP.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "Amount";
            // 
            // transAmount
            // 
            this.transAmount.Location = new System.Drawing.Point(72, 64);
            this.transAmount.Name = "transAmount";
            this.transAmount.Size = new System.Drawing.Size(100, 21);
            this.transAmount.TabIndex = 17;
            // 
            // transConfirm
            // 
            this.transConfirm.Location = new System.Drawing.Point(26, 94);
            this.transConfirm.Name = "transConfirm";
            this.transConfirm.Size = new System.Drawing.Size(75, 23);
            this.transConfirm.TabIndex = 18;
            this.transConfirm.Text = "Confirm";
            this.transConfirm.UseVisualStyleBackColor = true;
            this.transConfirm.Click += new System.EventHandler(this.transConfirm_Click_1);
            // 
            // stAcc
            // 
            this.stAcc.Location = new System.Drawing.Point(453, 40);
            this.stAcc.Name = "stAcc";
            this.stAcc.Size = new System.Drawing.Size(100, 23);
            this.stAcc.TabIndex = 35;
            this.stAcc.Text = " ";
            // 
            // stTime
            // 
            this.stTime.Location = new System.Drawing.Point(665, 17);
            this.stTime.Name = "stTime";
            this.stTime.Size = new System.Drawing.Size(100, 23);
            this.stTime.TabIndex = 34;
            this.stTime.Text = "  ";
            // 
            // stName
            // 
            this.stName.Location = new System.Drawing.Point(453, 17);
            this.stName.Name = "stName";
            this.stName.Size = new System.Drawing.Size(225, 23);
            this.stName.TabIndex = 32;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 453);
            this.Controls.Add(this.stAcc);
            this.Controls.Add(this.stTime);
            this.Controls.Add(this.stName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthlyReport);
            this.Controls.Add(this.accountDetail);
            this.Controls.Add(this.detailDisplay);
            this.Controls.Add(this.accountSelect);
            this.Controls.Add(this.accountsDisplay);
            this.Controls.Add(this.allAccountsLst);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button accountSelect;
        private System.Windows.Forms.Button accountsDisplay;
        private System.Windows.Forms.ListBox allAccountsLst;
        private System.Windows.Forms.Button monthlyReport;
        private System.Windows.Forms.ListBox accountDetail;
        private System.Windows.Forms.Button detailDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox sinBox;
        private System.Windows.Forms.RadioButton rBtnCK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rBtnVS;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.RadioButton rBtnSA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button accountAddClear;
        private System.Windows.Forms.TextBox iniHolder;
        private System.Windows.Forms.Button accountAddConfirm;
        private System.Windows.Forms.TextBox iniBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton transWD;
        private System.Windows.Forms.RadioButton transDP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox transAmount;
        private System.Windows.Forms.Button transConfirm;
        private System.Windows.Forms.Label stAcc;
        private System.Windows.Forms.Label stTime;
        private System.Windows.Forms.Label stName;
    }
}