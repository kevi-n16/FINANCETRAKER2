using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FINANCETRAKER2
{
    public partial class Form1 : Form
    {
       decimal  RunningBalance = 0;
     
        List<Transaction> transactions = new List<Transaction>();
        

        public Form1()
        {
            InitializeComponent();
        }

      

       
        private void RefreshGrid()
        {
            foreach(var trans in transactions)
            {
                decimal incomeAmo = decimal.Parse(txtIncomeAmount.Text);
                decimal expensesAmo = decimal.Parse(txtExpensesAmo.Text);

                decimal balance = incomeAmo - expensesAmo;

                dataGridView1.Rows.Add(
                    trans.Date.ToShortDateString(),
                    trans.IncomeName,
                    trans.incomeAmount.ToString("0.00"),
                    trans.ExpensesName,
                    trans.expensesCat,
                    trans.expenseAmount.ToString("0.00"),
                    trans.runningBalance.ToString("0.00")
                    );
            }
        }

        private void butBalance_Click(object sender, EventArgs e)
        {
            CalculateBalance();
        }

       

        private void butrefreshData_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            txtIncomeName.Focus();
            txtIncomeName.Text = " ";
            txtIncomeAmount.Text = " ";
            txtExpensesname.Text = " ";
            txtExpensesCat.Text = " ";
            txtExpensesAmo.Text = " ";  
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void butAddincome_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtIncomeAmount.Text, out decimal amount))
            {
                MessageBox.Show("Please Enter a valid Amount");
            }
            if (decimal.Parse(txtIncomeAmount.Text) < 0)
            {
                MessageBox.Show("Please Enter an Amount Above 0");
            }

            Income inc = new Income();
            Transaction trans = new Transaction();
            trans.Date = DateTime.Now;
           
            inc.IncomeAmount = decimal.Parse(txtIncomeAmount.Text);
            inc.IncomeSource = txtIncomeName.Text;
            
            RunningBalance += inc.IncomeAmount;

            trans.Date = DateTime.Now;
            trans.IncomeName = txtIncomeName.Text;
            trans.incomeAmount = decimal.Parse(txtIncomeAmount.Text);
            trans.ExpensesName = " - ";
            trans.expensesCat = " - ";
            trans.expenseAmount = 0;
            trans.runningBalance = RunningBalance;

            transactions.Add(trans);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = transactions;
        }

        private void butAddexp_Click(object sender, EventArgs e)
        {
           if(!decimal.TryParse(txtExpensesAmo.Text, out decimal amount))
            {
                MessageBox.Show("Please Enter a valid Amount");
            }
            if (decimal.Parse(txtExpensesAmo.Text) < 0)
            {
                MessageBox.Show("Please Enter an Amount Above 0");
            }
            Transaction trans = new Transaction();
            Income inc = new Income();
            Expenses exp = new Expenses();

            decimal expAmo = decimal.Parse(txtExpensesAmo.Text);

            trans.Date = DateTime.Now;
            exp.ExpensesName= txtExpensesAmo.Text;
            exp.ExpensesAmout = expAmo;
            exp.ExpensesCatergory = txtExpensesCat.Text;

            RunningBalance -= exp.ExpensesAmout;

            trans.Date = DateTime.Now;
            trans.IncomeName = " - ";
            trans.incomeAmount = 0;
            trans.ExpensesName = txtExpensesname.Text;
            trans.expensesCat = txtExpensesCat.Text;
            trans.expenseAmount = decimal.Parse(txtExpensesAmo.Text);
            trans.runningBalance = RunningBalance;

            transactions.Add(trans);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = transactions;

        }

        private void CalculateBalance()
        {
            if ( !decimal.TryParse(txtExpensesAmo.Text, out decimal expAmount))
            {
                MessageBox.Show("Enter a Valid Amount");
                return;
            }

            if (decimal.Parse(txtExpensesAmo.Text)<0)
            {
                MessageBox.Show("Enter a value above 0");
                return;
            }

            Transaction trans = new Transaction();

            decimal incAmo = decimal.Parse(txtIncomeAmount.Text);
            decimal expAmo = decimal.Parse(txtExpensesAmo.Text);

            trans.incomeAmount = decimal.Parse(txtIncomeAmount.Text);
            trans.expenseAmount = decimal.Parse(txtExpensesAmo.Text);

            decimal balance = trans.incomeAmount - trans.expenseAmount;
            RunningBalance = balance;

            trans.Date = DateTime.Now;
            trans.IncomeName = txtIncomeName.Text;
            trans.incomeAmount = incAmo;
            trans.ExpensesName = txtExpensesname.Text;
            trans.expensesCat = txtExpensesCat.Text;
            trans.expenseAmount= expAmo;
            trans.runningBalance = RunningBalance;

            transactions.Add(trans);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = transactions;

            
          

            
    
        }

        private void butSavedata_Click(object sender, EventArgs e)
        {
            string filePath = "D:\\VS2026\\FINANCETRACKER2\\FINANCETRAKER2\\GridData.txt";

            List<string> LinestoSave = transactions.Select(t => $"{t.Date}||{t.IncomeName}||{t.incomeAmount}||{t.ExpensesName}||{t.expensesCat}||{t.expenseAmount}||{t.runningBalance}").ToList();
            

            File.AppendAllLines(filePath, LinestoSave);

            MessageBox.Show(
                "Data Saved!"
                );
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void butLoadData_Click(object sender, EventArgs e)
        {   
           
            string filePath = "D:\\VS2026\\FINANCETRACKER2\\FINANCETRAKER2\\GridData.txt";

            if (!File.Exists(filePath)){
                MessageBox.Show(
                    "File does not exist"
                );
                return;
            }

            string[] lines = File.ReadAllLines(filePath);   

            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { "||" }, StringSplitOptions.None);

                if (parts.Length == 7)
                {
                    Transaction t = new Transaction();
                    t.Date = DateTime.Parse(parts[0]);
                    t.IncomeName = parts[1];
                    t.incomeAmount = decimal.Parse(parts[2]);
                    t.ExpensesName = parts[3];
                    t.expensesCat = parts[4];
                    t.expenseAmount = decimal.Parse(parts[5]);
                    t.runningBalance = decimal.Parse(parts[6]);

                    transactions.Add(t);
                    
                }
            }
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = transactions;
            dataGridView1.ClearSelection();
            
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row first.");
                return;
            }

            int selectedIndex = dataGridView1.SelectedRows[0].Index;

            if (selectedIndex < 0 || selectedIndex >= transactions.Count)
            {
                MessageBox.Show("Invalid selection.");
                return;
            }

            transactions.RemoveAt(selectedIndex);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = transactions;
        }
    }
}
