using System;
using System.Linq;
using System.Windows.Forms;

namespace Tictactoe
{
    public partial class Form1 : Form
    {
        private bool game = false;
        private bool Mean = true;
        private int Winone = 0, Wintwo = 0, Nobody = 0;
        public Form1()
        {
            InitializeComponent();
            Clean();
        }
        private void Clean()
        {
            for (int i = 0; i < 10; i++)
                foreach (Button button in Controls.OfType<Button>())
                {
                    for (i = 1; i <= 9; i++)
                    {
                        this.Controls["button" + i.ToString()].Text = "";
                        this.Controls["button" + i.ToString()].Enabled = false;
                        label1.Text = "Начните игру";
                    }
                }
            button10.Enabled = true;
        }
        private void Win(bool mean)
        {
            if (mean == false)
            {
                MessageBox.Show("Выиграл первый игорок");
                Winone++;
            }
            else
            {
                MessageBox.Show("Выиграл второй игорок");
                Wintwo++;
            }
        }
        private bool Check()
        {
            if (!string.IsNullOrEmpty(button1.Text) && !string.IsNullOrEmpty(button2.Text) && !string.IsNullOrEmpty(button3.Text)) 
            {
                if (button1.Text == button2.Text & button1.Text== button3.Text)
                {
                    return true;
                }
            }
            if (!string.IsNullOrEmpty(button4.Text) && !string.IsNullOrEmpty(button5.Text) && !string.IsNullOrEmpty(button6.Text))
            {
                if (button4.Text == button5.Text && button5.Text == button6.Text)
                {
                    return true;
                }
            }
            if (!string.IsNullOrEmpty(button7.Text) && !string.IsNullOrEmpty(button8.Text) && !string.IsNullOrEmpty(button9.Text))
            {
                if (button7.Text == button8.Text && button7.Text == button9.Text)
                {
                    return true;
                }
            }
            if (!string.IsNullOrEmpty(button1.Text) && !string.IsNullOrEmpty(button4.Text) && !string.IsNullOrEmpty(button7.Text))
            {
                if (button1.Text == button4.Text && button4.Text == button7.Text)
                {
                    return true;
                }
            }
            if (!string.IsNullOrEmpty(button2.Text) && !string.IsNullOrEmpty(button5.Text) && !string.IsNullOrEmpty(button8.Text))
            {
                if (button2.Text == button5.Text && button5.Text == button8.Text)
                {
                    return true;
                }
            }
            if (!string.IsNullOrEmpty(button3.Text) && !string.IsNullOrEmpty(button6.Text) && !string.IsNullOrEmpty(button9.Text))
            {
                if (button3.Text == button6.Text & button6.Text == button9.Text)
                {
                    return true;
                }
            }
            if (!string.IsNullOrEmpty(button1.Text) && !string.IsNullOrEmpty(button5.Text) && !string.IsNullOrEmpty(button9.Text))
            {
                if (button1.Text == button5.Text & button5.Text == button9.Text)
                {
                    return true;
                }
            }
            if (!string.IsNullOrEmpty(button3.Text) && !string.IsNullOrEmpty(button5.Text) && !string.IsNullOrEmpty(button7.Text))
            {
                if (button3.Text == button5.Text && button5.Text == button7.Text)
                {
                    return true;
                }
            }
            if (!string.IsNullOrEmpty(button1.Text) && !string.IsNullOrEmpty(button2.Text) && !string.IsNullOrEmpty(button3.Text) && !string.IsNullOrEmpty(button4.Text) && !string.IsNullOrEmpty(button5.Text) && !string.IsNullOrEmpty(button6.Text) && !string.IsNullOrEmpty(button7.Text) && !string.IsNullOrEmpty(button8.Text) && !string.IsNullOrEmpty(button9.Text))
            {
                MessageBox.Show("Ничья");
                Clean();
                Nobody ++;
                return false;
            }
            return false;          
        }              
        private void buttonenter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                if (Mean)
                {
                    button.Text = "X";
                }
                else button.Text = "O";
            }          
        }
        private void buttonleave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
               button.Text = "";            
            }
        }
        private void buttonclick(object sender, EventArgs e)
        {
            Button button = (Button)sender;           
                if (Mean == true)
                {
                    button.Text = "X";
                    Mean = false;
                    label1.Text = "Ход игрока: 2";
                }
                else
                {
                    button.Text = "O";
                    Mean = true;
                    label1.Text = "Ход игрока: 1";
                }
            button.Enabled = false;
            if (Check()) { Win(Mean); ; Clean(); };
        }        
        private void button10_Click(object sender, EventArgs e)
        {
            
            //DialogResult result=MessageBox.Show("Одиночная игра?", "Начать", MessageBoxButtons.YesNo);
            //if (result== DialogResult.Yes)
            //{
               // game = true;
            //}
            foreach (Button button in Controls.OfType<Button>()) 
            {
                for (int i = 1; i <= 9; i++) 
                {
                    this.Controls["button" + i.ToString()].Text = string.Empty;
                    this.Controls["button" + i.ToString()].Enabled = true;
                }
            }
            Mean = true;
            button10.Enabled = false;
        }    
        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show($" Первый игрок выиграл:{Winone}.\n Второй игрок выиграл:{Wintwo}.\n Ничья:{Nobody}.");
        }    
    }
}
