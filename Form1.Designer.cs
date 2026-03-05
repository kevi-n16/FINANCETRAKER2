namespace FINANCETRAKER2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIncomeName = new System.Windows.Forms.TextBox();
            this.txtExpensesAmo = new System.Windows.Forms.TextBox();
            this.txtExpensesname = new System.Windows.Forms.TextBox();
            this.txtIncomeAmount = new System.Windows.Forms.TextBox();
            this.txtExpensesCat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.butBalance = new System.Windows.Forms.Button();
            this.butSavedata = new System.Windows.Forms.Button();
            this.butLoadData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butrefreshData = new System.Windows.Forms.Button();
            this.butAddexp = new System.Windows.Forms.Button();
            this.butAddincome = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Income Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expenses Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expenses Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Expenses Amount";
            // 
            // txtIncomeName
            // 
            this.txtIncomeName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIncomeName.Location = new System.Drawing.Point(231, 24);
            this.txtIncomeName.Name = "txtIncomeName";
            this.txtIncomeName.Size = new System.Drawing.Size(311, 26);
            this.txtIncomeName.TabIndex = 5;
            // 
            // txtExpensesAmo
            // 
            this.txtExpensesAmo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtExpensesAmo.Location = new System.Drawing.Point(231, 203);
            this.txtExpensesAmo.Name = "txtExpensesAmo";
            this.txtExpensesAmo.Size = new System.Drawing.Size(311, 26);
            this.txtExpensesAmo.TabIndex = 6;
            // 
            // txtExpensesname
            // 
            this.txtExpensesname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtExpensesname.Location = new System.Drawing.Point(231, 113);
            this.txtExpensesname.Name = "txtExpensesname";
            this.txtExpensesname.Size = new System.Drawing.Size(311, 26);
            this.txtExpensesname.TabIndex = 8;
            // 
            // txtIncomeAmount
            // 
            this.txtIncomeAmount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIncomeAmount.Location = new System.Drawing.Point(231, 67);
            this.txtIncomeAmount.Name = "txtIncomeAmount";
            this.txtIncomeAmount.Size = new System.Drawing.Size(311, 26);
            this.txtIncomeAmount.TabIndex = 9;
            // 
            // txtExpensesCat
            // 
            this.txtExpensesCat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtExpensesCat.FormattingEnabled = true;
            this.txtExpensesCat.Items.AddRange(new object[] {
            "Food",
            "Bills",
            "Transport"});
            this.txtExpensesCat.Location = new System.Drawing.Point(231, 160);
            this.txtExpensesCat.Name = "txtExpensesCat";
            this.txtExpensesCat.Size = new System.Drawing.Size(311, 28);
            this.txtExpensesCat.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(728, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(429, 273);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butBalance
            // 
            this.butBalance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butBalance.Location = new System.Drawing.Point(766, 39);
            this.butBalance.Name = "butBalance";
            this.butBalance.Size = new System.Drawing.Size(158, 44);
            this.butBalance.TabIndex = 14;
            this.butBalance.Text = "BALANCE";
            this.butBalance.UseVisualStyleBackColor = false;
            this.butBalance.Click += new System.EventHandler(this.butBalance_Click);
            // 
            // butSavedata
            // 
            this.butSavedata.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butSavedata.Location = new System.Drawing.Point(972, 38);
            this.butSavedata.Name = "butSavedata";
            this.butSavedata.Size = new System.Drawing.Size(158, 47);
            this.butSavedata.TabIndex = 15;
            this.butSavedata.Text = "SAVE DATA";
            this.butSavedata.UseVisualStyleBackColor = false;
            this.butSavedata.Click += new System.EventHandler(this.butSavedata_Click);
            // 
            // butLoadData
            // 
            this.butLoadData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butLoadData.Location = new System.Drawing.Point(972, 91);
            this.butLoadData.Name = "butLoadData";
            this.butLoadData.Size = new System.Drawing.Size(158, 42);
            this.butLoadData.TabIndex = 16;
            this.butLoadData.Text = "LOAD DATA ";
            this.butLoadData.UseVisualStyleBackColor = false;
            this.butLoadData.Click += new System.EventHandler(this.butLoadData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 431);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1140, 233);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // butrefreshData
            // 
            this.butrefreshData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butrefreshData.Location = new System.Drawing.Point(972, 146);
            this.butrefreshData.Name = "butrefreshData";
            this.butrefreshData.Size = new System.Drawing.Size(158, 42);
            this.butrefreshData.TabIndex = 19;
            this.butrefreshData.Text = "REFRESH DATA";
            this.butrefreshData.UseVisualStyleBackColor = false;
            this.butrefreshData.Click += new System.EventHandler(this.butrefreshData_Click);
            // 
            // butAddexp
            // 
            this.butAddexp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butAddexp.Location = new System.Drawing.Point(767, 145);
            this.butAddexp.Name = "butAddexp";
            this.butAddexp.Size = new System.Drawing.Size(159, 45);
            this.butAddexp.TabIndex = 20;
            this.butAddexp.Text = "ADD EXPENSES";
            this.butAddexp.UseVisualStyleBackColor = false;
            this.butAddexp.Click += new System.EventHandler(this.butAddexp_Click);
            // 
            // butAddincome
            // 
            this.butAddincome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butAddincome.Location = new System.Drawing.Point(766, 89);
            this.butAddincome.Name = "butAddincome";
            this.butAddincome.Size = new System.Drawing.Size(158, 50);
            this.butAddincome.TabIndex = 21;
            this.butAddincome.Text = "ADD INCOME";
            this.butAddincome.UseVisualStyleBackColor = false;
            this.butAddincome.Click += new System.EventHandler(this.butAddincome_Click);
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butDelete.Location = new System.Drawing.Point(870, 219);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(157, 40);
            this.butDelete.TabIndex = 22;
            this.butDelete.Text = "DELETE";
            this.butDelete.UseVisualStyleBackColor = false;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1209, 745);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butAddincome);
            this.Controls.Add(this.butAddexp);
            this.Controls.Add(this.butrefreshData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butLoadData);
            this.Controls.Add(this.butSavedata);
            this.Controls.Add(this.butBalance);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtExpensesCat);
            this.Controls.Add(this.txtIncomeAmount);
            this.Controls.Add(this.txtExpensesname);
            this.Controls.Add(this.txtExpensesAmo);
            this.Controls.Add(this.txtIncomeName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ETECH FINANCE TRACKER";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIncomeName;
        private System.Windows.Forms.TextBox txtExpensesAmo;
        private System.Windows.Forms.TextBox txtExpensesname;
        private System.Windows.Forms.TextBox txtIncomeAmount;
        private System.Windows.Forms.ComboBox txtExpensesCat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butBalance;
        private System.Windows.Forms.Button butSavedata;
        private System.Windows.Forms.Button butLoadData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butrefreshData;
        private System.Windows.Forms.Button butAddexp;
        private System.Windows.Forms.Button butAddexpenses;
        private System.Windows.Forms.Button butAddincome;
        private System.Windows.Forms.Button butDelete;
    }
}

