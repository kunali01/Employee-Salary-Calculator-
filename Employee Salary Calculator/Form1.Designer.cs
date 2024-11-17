namespace Employee_Salary_Calculator
{
    partial class Form1
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
            this.lblEmpId = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblBasicSalary = new System.Windows.Forms.Label();
            this.lblHRA = new System.Windows.Forms.Label();
            this.lblDA = new System.Windows.Forms.Label();
            this.lblTA = new System.Windows.Forms.Label();
            this.lblPF = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.txtHRA = new System.Windows.Forms.TextBox();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.txtTA = new System.Windows.Forms.TextBox();
            this.txtPF = new System.Windows.Forms.TextBox();
            this.lblPT = new System.Windows.Forms.Label();
            this.lblGrossSalary = new System.Windows.Forms.Label();
            this.txtPT = new System.Windows.Forms.TextBox();
            this.txtGrossSalary = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Location = new System.Drawing.Point(65, 21);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(65, 13);
            this.lblEmpId.TabIndex = 0;
            this.lblEmpId.Text = "Employee Id";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(68, 61);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(38, 13);
            this.lblEmpName.TabIndex = 1;
            this.lblEmpName.Text = "Name:";
            // 
            // lblBasicSalary
            // 
            this.lblBasicSalary.AutoSize = true;
            this.lblBasicSalary.Location = new System.Drawing.Point(68, 102);
            this.lblBasicSalary.Name = "lblBasicSalary";
            this.lblBasicSalary.Size = new System.Drawing.Size(68, 13);
            this.lblBasicSalary.TabIndex = 2;
            this.lblBasicSalary.Text = "Basic Salary:";
            // 
            // lblHRA
            // 
            this.lblHRA.AutoSize = true;
            this.lblHRA.Location = new System.Drawing.Point(68, 150);
            this.lblHRA.Name = "lblHRA";
            this.lblHRA.Size = new System.Drawing.Size(62, 13);
            this.lblHRA.TabIndex = 3;
            this.lblHRA.Text = "HRA (40%):";
            // 
            // lblDA
            // 
            this.lblDA.AutoSize = true;
            this.lblDA.Location = new System.Drawing.Point(68, 195);
            this.lblDA.Name = "lblDA";
            this.lblDA.Size = new System.Drawing.Size(54, 13);
            this.lblDA.TabIndex = 4;
            this.lblDA.Text = "DA (30%):";
            // 
            // lblTA
            // 
            this.lblTA.AutoSize = true;
            this.lblTA.Location = new System.Drawing.Point(68, 239);
            this.lblTA.Name = "lblTA";
            this.lblTA.Size = new System.Drawing.Size(53, 13);
            this.lblTA.TabIndex = 5;
            this.lblTA.Text = "TA (20%):";
            // 
            // lblPF
            // 
            this.lblPF.AutoSize = true;
            this.lblPF.Location = new System.Drawing.Point(71, 279);
            this.lblPF.Name = "lblPF";
            this.lblPF.Size = new System.Drawing.Size(52, 13);
            this.lblPF.TabIndex = 6;
            this.lblPF.Text = "PF (12%):";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(195, 21);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(100, 20);
            this.txtEmpId.TabIndex = 7;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(195, 61);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 20);
            this.txtEmpName.TabIndex = 8;
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Location = new System.Drawing.Point(195, 102);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(100, 20);
            this.txtBasicSalary.TabIndex = 9;
            this.txtBasicSalary.TextChanged += new System.EventHandler(this.txtBasicSalary_TextChanged);
            // 
            // txtHRA
            // 
            this.txtHRA.Location = new System.Drawing.Point(195, 150);
            this.txtHRA.Name = "txtHRA";
            this.txtHRA.Size = new System.Drawing.Size(100, 20);
            this.txtHRA.TabIndex = 10;
            // 
            // txtDA
            // 
            this.txtDA.Location = new System.Drawing.Point(195, 195);
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(100, 20);
            this.txtDA.TabIndex = 11;
            // 
            // txtTA
            // 
            this.txtTA.Location = new System.Drawing.Point(195, 239);
            this.txtTA.Name = "txtTA";
            this.txtTA.Size = new System.Drawing.Size(100, 20);
            this.txtTA.TabIndex = 12;
            // 
            // txtPF
            // 
            this.txtPF.Location = new System.Drawing.Point(195, 279);
            this.txtPF.Name = "txtPF";
            this.txtPF.Size = new System.Drawing.Size(100, 20);
            this.txtPF.TabIndex = 13;
            // 
            // lblPT
            // 
            this.lblPT.AutoSize = true;
            this.lblPT.Location = new System.Drawing.Point(74, 321);
            this.lblPT.Name = "lblPT";
            this.lblPT.Size = new System.Drawing.Size(79, 13);
            this.lblPT.TabIndex = 14;
            this.lblPT.Text = "PT (Fixed 200):";
            // 
            // lblGrossSalary
            // 
            this.lblGrossSalary.AutoSize = true;
            this.lblGrossSalary.Location = new System.Drawing.Point(77, 362);
            this.lblGrossSalary.Name = "lblGrossSalary";
            this.lblGrossSalary.Size = new System.Drawing.Size(69, 13);
            this.lblGrossSalary.TabIndex = 15;
            this.lblGrossSalary.Text = "Gross Salary:";
            // 
            // txtPT
            // 
            this.txtPT.Location = new System.Drawing.Point(195, 321);
            this.txtPT.Name = "txtPT";
            this.txtPT.Size = new System.Drawing.Size(100, 20);
            this.txtPT.TabIndex = 16;
            // 
            // txtGrossSalary
            // 
            this.txtGrossSalary.Location = new System.Drawing.Point(195, 354);
            this.txtGrossSalary.Name = "txtGrossSalary";
            this.txtGrossSalary.Size = new System.Drawing.Size(100, 20);
            this.txtGrossSalary.TabIndex = 17;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(457, 156);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(162, 52);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtGrossSalary);
            this.Controls.Add(this.txtPT);
            this.Controls.Add(this.lblGrossSalary);
            this.Controls.Add(this.lblPT);
            this.Controls.Add(this.txtPF);
            this.Controls.Add(this.txtTA);
            this.Controls.Add(this.txtDA);
            this.Controls.Add(this.txtHRA);
            this.Controls.Add(this.txtBasicSalary);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.lblPF);
            this.Controls.Add(this.lblTA);
            this.Controls.Add(this.lblDA);
            this.Controls.Add(this.lblHRA);
            this.Controls.Add(this.lblBasicSalary);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lblEmpId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblBasicSalary;
        private System.Windows.Forms.Label lblHRA;
        private System.Windows.Forms.Label lblDA;
        private System.Windows.Forms.Label lblTA;
        private System.Windows.Forms.Label lblPF;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.TextBox txtHRA;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.TextBox txtTA;
        private System.Windows.Forms.TextBox txtPF;
        private System.Windows.Forms.Label lblPT;
        private System.Windows.Forms.Label lblGrossSalary;
        private System.Windows.Forms.TextBox txtPT;
        private System.Windows.Forms.TextBox txtGrossSalary;
        private System.Windows.Forms.Button btnCalculate;
    }
}

