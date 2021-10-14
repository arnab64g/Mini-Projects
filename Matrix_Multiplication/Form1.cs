using System;
using System.Windows.Forms;
using System.Drawing;
namespace Matrix_Multiplication
{
    public partial class Form1 : Form
    {
        TextBox[,] txtA = new TextBox[5, 5];
        TextBox[,] txtB = new TextBox[5, 5];
        Label[,] lab = new Label[5, 5];
        Button calculate = new Button();
        Button contin = new Button();
        public Form1()
        {
            
            InitializeComponent();
            Console.WriteLine("Initializing");
            button1.Click += input_Filed;
            calculate.Click += calculateMatrix;
            contin.Click += continue_multi;
            button2.Click += clearfield;
            button3.Click += closeWin;
            
        }
        private void input_Filed(object o, EventArgs e)
        {
            
            Console.WriteLine("Button 1");
            int n = (int)numericUpDown1.Value;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    Controls.Remove(txtA[i, j]);
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    Controls.Remove(txtB[i, j]);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    txtA[i, j] = new TextBox();
                
                    txtA[i, j].Location = new Point(j * 50 + 20, i * 35 + 75);
                    txtA[i, j].Size = new Size(40, 25);
                    txtA[i, j].TextAlign = HorizontalAlignment.Center;
                    Controls.Add(txtA[i, j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    txtB[i, j] = new TextBox();
                
                    txtB[i, j].Location = new Point(j * 50 + 320, i * 35 + 75);
                    txtB[i, j].Size = new Size(40, 25);
                    txtB[i, j].TextAlign = HorizontalAlignment.Center;
                    Controls.Add(txtB[i, j]);
                }
            }
            calculate.Location = new Point(150, 250);
            calculate.Size = new Size(50, 25);
            calculate.Text = "Calculate";
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            Controls.Add(button2);
            Controls.Add(calculate);
            Controls.Add(cb);
        }
        private void calculateMatrix(object sender, EventArgs e)
        {
            Console.WriteLine("Button Calculate");
            double[,] matA = new double[5, 5];
            double[,] matB = new double[5, 5];
            double[,] matR = new double[5, 5];
            int sz = (int)numericUpDown1.Value;
            for (int i = 0; i < sz; i++)
                for (int j = 0; j < sz; j++)
                    Controls.Remove(lab[i, j]);
            for (int i = 0; i < sz; i++)
                for (int j = 0; j < sz; j++)
                {
                    if (txtA[i, j].Text == "")
                        txtA[i, j].Text = "0";
                    matA[i, j] = double.Parse(txtA[i, j].Text.ToString());
                }
            for (int i = 0; i < sz; i++)
                for (int j = 0; j < sz; j++)
                {
                    if (txtB[i, j].Text == "")
                        txtB[i, j].Text = "0";
                    matB[i, j] = double.Parse(txtB[i, j].Text.ToString());
                }
            string st = "";
            if(cb.SelectedIndex != -1) {
                st = cb.SelectedItem.ToString();
                label3.Text = st;
            }
                if(st == "Addition")
                Matrix_Multiply.addition(matA, matB, matR, sz);
            else if(st == "Substraction")
                Matrix_Multiply.substraction(matA, matB, matR, sz);
            else if(st == "Multiplication")
                Matrix_Multiply.multiply(matA, matB, matR, sz);
            else {
                MessageBox.Show("No Operation Selected", "Error");
                return;
            }
            for (int i = 0; i < sz; i++)
               for (int j = 0; j < sz; j++)
               {
                     lab[i, j] = new Label();
                     lab[i, j].Location = new Point(j * 75 + 50, i * 35 + 300);
                     lab[i, j].Size = new Size(75, 30);
                     lab[i, j].Text = String.Format("{0:0.00}", matR[i, j]);
                     Controls.Add(lab[i, j]);
               }
            contin.Location = new Point(250, 250);
            contin.Text = "Continue";
            Controls.Add(contin);
        }
        private void continue_multi(object sender, EventArgs e)
        {
            Console.WriteLine("Button Continue");
            int sz = (int)numericUpDown1.Value;
            for (int i = 0; i < sz; i++)
                for (int j = 0; j < sz; j++)
                    txtA[i, j].Text = lab[i, j].Text;
            for (int i = 0; i < sz; i++)
                for (int j = 0; j < sz; j++)
                    txtB[i, j].Text = "";
            for (int i = 0; i < sz; i++)
                for (int j = 0; j < sz; j++)
                    Controls.Remove(lab[i, j]);
        }
        private void clearfield(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
                for(int j = 0; j < 5; j++)
                    Controls.Remove(txtA[i, j]);
            for(int i = 0; i < 5; i++)
                for(int j = 0; j < 5; j++)
                    Controls.Remove(txtB[i, j]);
			for(int i = 0; i < 5; i++) {
				for(int j = 0; j < 5; j++) {
                    Controls.Remove(lab[i, j]);
				}
			}
        }
        private void closeWin(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
