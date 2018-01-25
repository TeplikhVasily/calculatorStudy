using System;
using System.Windows.Forms;
using ConsoleCalculator;
using CalculatorDB.Repositoris;
using CalculatorDB.Models;

namespace DesktopCalc
{
    public partial class Form1 : Form
    {
        private Calculate Calculate { get; set; }

        public Form1()
        {
            InitializeComponent();
            Calculate = new Calculate();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            itOperations.Items.Clear();
            itOperations.Items.AddRange(Calculate.GetOperationNames());

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (itOperations.SelectedItem.ToString() == null)
                return;

            var oper = itOperations.SelectedItem.ToString();

            var result = Calculate.Exec(oper, textBox1.Text.Split(' '));

            label1.Text = result.ToString();

            #region Save


            var or = new OperationResult()
            {
                OperationId = itOperations.SelectedIndex,
                Result = result,
                ExecutionTime = new Random().Next(100, 4000),
                Error = "",
                Args = textBox1.Text.Trim()

            };




        var openResultRepositiries = new OperResultRepositories();

        openResultRepositiries.Save(or);



            #endregion
        }
}
}
