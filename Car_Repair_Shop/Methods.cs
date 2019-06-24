using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Repair_Shop
{
    internal class Methods
    {
        internal object Count_Length(Label label, TextBox textbox)
        {
            return label.Text = textbox.Text.Length + "/" + textbox.MaxLength;
        }

        internal bool Check_Length(string text)
        {
            return text.Length > 0;
        }

        internal bool DigitLetterWithSpace(char ch) //returns value bool to e.Handled [32 space, 8 backspace]
        {
            return (!char.IsLetterOrDigit(ch) && ch != 8 && ch != 32);
        }

        internal bool DigitLetterForVIN(char ch) //returns value bool to e.Handled [ 8 backspace]
        {
            if (ExcludeLetter(ch) == true)
            {
                return true;
            }
            return (!char.IsLetterOrDigit(ch) && ch != 8);
        }

        internal bool ExcludeLetter(char ch) //without I,O,Q. Use for VIN
        {
            if (ch == 79 || ch == 111 || ch == 73 || ch == 105 || ch == 81 || ch == 113)
            {
                return true;
            }
            return false;
        }

        internal bool JustDigit(char ch) //returns value bool to e.Handled [8 backspace]
        {
            return (!char.IsDigit(ch) && ch != 8);
        }

        internal string Check_Cost(string cost) //if empty return 0
        {
            return (cost != "") ? cost : "0";
        }

        internal void Back(Form form)
        {
            Form Main = new Main();
            form.Hide();
            Main.ShowDialog();
        }

        internal void ExitProgram(string title)
        {
            DialogResult Komunikat = MessageBox.Show("Are you sure to exit?", title, MessageBoxButtons.YesNo);
            if (Komunikat == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.ExitThread();
            }
            else if (Komunikat == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
