using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Kalkulator : Form
    {
        double wynik = 0;
        int sizein = 0;
        double input;
        bool first;
        string eq = "";
        bool last = false;
        double memory = 0;
        string prevsys = "dec";
        int cvr = 0;
        string result;

        private void Kalkulator_Load(object sender, EventArgs e)
        {
            nohex();
            rDec.Checked = true;
        }

        void display(string i)
        {
            if (last == false)
            {
                if (tbDisplay.Text == "0")
                {
                    tbDisplay.Clear();
                    tbDisplay4.Clear();
                }
                if (first == true)
                {
                    tbDisplay.Clear();
                }
                tbDisplay.Text += i;
                tbDisplay4.Text += i;
                tbDisplay2.Text += i;
                sizein += 1;
                tbDisplay5.Text = sizein.ToString();
            }
        }

        public Kalkulator()
        {
            InitializeComponent();
        }

        private void btNr1_Click(object sender, EventArgs e)
        {
            display("1");
            first = false;
        }

        private void btNr7_Click(object sender, EventArgs e)
        {
            display("7");
            first = false;
        }

        private void btNr8_Click(object sender, EventArgs e)
        {
            display("8");
            first = false;
        }

        private void btNr9_Click(object sender, EventArgs e)
        {
            display("9");
            first = false;
        }

        private void btNr4_Click(object sender, EventArgs e)
        {
            display("4");
            first = false;
        }

        private void btNr5_Click(object sender, EventArgs e)
        {
            display("5");
            first = false;
        }

        private void btNr6_Click(object sender, EventArgs e)
        {
            display("6");
            first = false;
        }

        private void btNr2_Click(object sender, EventArgs e)
        {
            display("2");
            first = false;
        }

        private void btNr3_Click(object sender, EventArgs e)
        {
            display("3");
            first = false;
        }

        private void bN0_Click(object sender, EventArgs e)
        {
            display("0");
            first = false;
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            if (first != true)
            {
                calculate(eq);
                tbDisplay2.Text += " + ";
                try
                {
                    input = double.Parse(tbDisplay4.Text);
                    switch (prevsys)
                    {
                        case "hex":
                            input = int.Parse(tbDisplay4.Text, System.Globalization.NumberStyles.HexNumber);
                            break;
                        case "bin":
                            input = Convert.ToInt32(tbDisplay4.Text, 2);
                            break;
                        case "oct":
                            input = Convert.ToInt32(tbDisplay4.Text, 8);
                            break;
                        case "dec":
                            input = double.Parse(tbDisplay4.Text);
                            break;
                    }
                    tbDisplay4.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                first = true;
                eq = "+";
                tbDisplay7.Text = "+";
            }
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            if (first != true)
            {
                calculate(eq);
                tbDisplay2.Text += " - ";
                try
                {
                    input = double.Parse(tbDisplay4.Text);
                    switch (prevsys)
                    {
                        case "hex":
                            input = int.Parse(tbDisplay4.Text, System.Globalization.NumberStyles.HexNumber);
                            break;
                        case "bin":
                            input = Convert.ToInt32(tbDisplay4.Text, 2);
                            break;
                        case "oct":
                            input = Convert.ToInt32(tbDisplay4.Text, 8);
                            break;
                        case "dec":
                            input = double.Parse(tbDisplay4.Text);
                            break;
                    }
                    tbDisplay4.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                first = true;
                eq = "-";
                tbDisplay7.Text = "-";
            }
        }

        private void bMnozenie_Click(object sender, EventArgs e)
        {
            if (first != true)
            {
                calculate(eq);
                tbDisplay2.Text += " * ";
                try
                {
                    input = double.Parse(tbDisplay4.Text);
                    switch (prevsys)
                    {
                        case "hex":
                            input = int.Parse(tbDisplay4.Text, System.Globalization.NumberStyles.HexNumber);
                            break;
                        case "bin":
                            input = Convert.ToInt32(tbDisplay4.Text, 2);
                            break;
                        case "oct":
                            input = Convert.ToInt32(tbDisplay4.Text, 8);
                            break;
                        case "dec":
                            input = double.Parse(tbDisplay4.Text);
                            break;
                    }
                    tbDisplay4.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                first = true;
                eq = "*";
                tbDisplay7.Text = "*";
            }
        }

        private void bDzielenie_Click(object sender, EventArgs e)
        {
            if (first != true)
            {
                calculate(eq);
                tbDisplay2.Text += " / ";
                try
                {
                    input = double.Parse(tbDisplay4.Text);
                    switch (prevsys)
                    {
                        case "hex":
                            input = int.Parse(tbDisplay4.Text, System.Globalization.NumberStyles.HexNumber);
                            break;
                        case "bin":
                            input = Convert.ToInt32(tbDisplay4.Text, 2);
                            break;
                        case "oct":
                            input = Convert.ToInt32(tbDisplay4.Text, 8);
                            break;
                        case "dec":
                            input = double.Parse(tbDisplay4.Text);
                            break;
                    }
                    tbDisplay4.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                first = true;
                eq = "/";
                tbDisplay7.Text = "/";
            }
        }

        public void calculate(string eq)
        {
            if (tbDisplay3.Text == "" || tbDisplay3.Text == null)
            {
                input = double.Parse(tbDisplay4.Text);
                convertin();
                tbDisplay3.Text = input.ToString();
            }
            switch (prevsys)
            {
                case "hex":
                    input = int.Parse(tbDisplay4.Text, System.Globalization.NumberStyles.HexNumber);
                    break;
                case "bin":
                    input = Convert.ToInt32(tbDisplay4.Text, 2);
                    break;
                case "oct":
                    input = Convert.ToInt32(tbDisplay4.Text, 8);
                    break;
                case "dec":
                    input = double.Parse(tbDisplay4.Text);
                    break;
            }
            tbDisplay4.Clear();
            switch (eq)
            {
                case "+":
                    wynik += input;
                    break;
                case "-":
                    wynik -= input;
                    break;
                case "*":
                    wynik *= input;
                    break;
                case "=":
                    break;
                case "/":
                    if (input != 0)
                    {
                        wynik /= input;
                    }
                    else
                    {
                        tbDisplay.Text = "Nie można dzielić przez 0";
                    }
                    break;
                default:
                    wynik = input;
                    break;
            }
            backtosys();
            tbDisplay.Text = result;
            tbDisplay3.Text = result;
            sizein = 0;
            last = false;
        }

        public void convertin()
        {
            if (tbDisplay4.Text.Length > 0)
            {
                switch (prevsys)
                {
                    case "hex":
                        input = int.Parse(tbDisplay4.Text, System.Globalization.NumberStyles.HexNumber);
                        break;
                    case "bin":
                        input = Convert.ToInt32(tbDisplay4.Text, 2);
                        break;
                    case "oct":
                        input = Convert.ToInt32(tbDisplay4.Text, 8);
                        break;
                    case "dec":
                        input = double.Parse(tbDisplay4.Text);
                        break;
                }
            }
        }

        public void backtosys()
        {
            switch (prevsys)
            {
                case "hex":
                    result = ((int)(wynik)).ToString("X");
                    break;
                case "oct":
                    result = Convert.ToString((int)wynik, 8);
                    break;
                case "bin":
                    result = Convert.ToString((int)wynik, 2);
                    break;
                case "dec":
                    result = ((int)(wynik)).ToString();
                    break;
            }
        }

        private void bC_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void bWynik_Click(object sender, EventArgs e)
        {
            try
            {
                if (first != true)
                {
                    tbDisplay2.Clear();
                    calculate(eq);
                    tbDisplay.Text = wynik.ToString();
                    tbDisplay2.Text = wynik.ToString();
                    tbDisplay3.Text = wynik.ToString();
                    last = true;
                    eq = "=";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            int sizetb;
            sizetb = tbDisplay2.Text.ToString().Length;
            tbDisplay5.Text = sizein.ToString();
            string inputstring = tbDisplay2.Text.ToString();
            tbDisplay6.Text = sizetb.ToString();
            if (first != true && inputstring.Length > 0)
            {
                tbDisplay2.Text = tbDisplay2.Text.Substring(0, sizetb - sizein);
                tbDisplay.Clear();
                tbDisplay4.Clear();
                sizein = 0;
                tbDisplay5.Text = sizein.ToString();
            }


        }

        private void btDot_Click(object sender, EventArgs e)
        {
            if (first == false && !tbDisplay4.Text.Contains(","))
            {
                tbDisplay.Text += ",";
                tbDisplay2.Text += ",";
                tbDisplay4.Text += ",";
                sizein = tbDisplay4.Text.Length;
                tbDisplay5.Text = sizein.ToString();
            }
        }

        private void bBackspace_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text.Length > 0 && first == false && tbDisplay4.Text.Length > 0 && tbDisplay2.Text.Length > 0)
            {
                tbDisplay2.Text = tbDisplay2.Text.Substring(0, tbDisplay2.Text.Length - 1);
                tbDisplay.Text = tbDisplay.Text.Substring(0, tbDisplay.Text.Length - 1);
                tbDisplay4.Text = tbDisplay4.Text.Substring(0, tbDisplay4.Text.Length - 1);
                sizein -= 1;
                tbDisplay5.Text = sizein.ToString();
            }
        }

        private void bUlamek_Click(object sender, EventArgs e)
        {
            if (tbDisplay4.Text.Length > 0)
            {
                input = 1 / double.Parse(tbDisplay4.Text);
                aftereq();
            }
        }

        private void bProcent_Click(object sender, EventArgs e)
        {
            if (tbDisplay4.Text.Length > 0)
            {
                input = double.Parse(tbDisplay4.Text) / 2;
                aftereq();
            }
        }

        private void bPierwiastek_Click(object sender, EventArgs e)
        {
            if (tbDisplay4.Text.Length > 0)
            {
                input = Math.Sqrt(double.Parse(tbDisplay4.Text));
                aftereq();
            }
        }

        private void bPotegowanie_Click(object sender, EventArgs e)
        {
            if (tbDisplay4.Text.Length > 0)
            {
                input = Math.Pow(double.Parse(tbDisplay4.Text), 2);
                aftereq();
            }
        }

        public void clear()
        {
            wynik = 0;
            input = 0;
            tbDisplay.Clear();
            tbDisplay2.Clear();
            tbDisplay3.Clear();
            tbDisplay4.Clear();
            sizein = 0;
            tbDisplay5.Text = sizein.ToString();
            eq = "";
            last = false;
        }

        public void aftereq()
        {
            tbDisplay4.Text = input.ToString();
            int sizetb;
            sizetb = tbDisplay2.Text.ToString().Length;
            tbDisplay6.Text = sizetb.ToString();
            if (tbDisplay2.Text.Length > sizein)
            {
                tbDisplay2.Text = tbDisplay2.Text.Substring(0, sizetb - sizein);
                tbDisplay2.Text += input.ToString();
            }
            if (tbDisplay2.Text.Length == sizein)
            {
                tbDisplay2.Text = input.ToString();
            }
            sizein = tbDisplay4.Text.Length;
            tbDisplay5.Text = sizein.ToString();
            tbDisplay.Text = input.ToString();
            first = false;
        }

        private void bMC_Click(object sender, EventArgs e)
        {
            memory = 0;
            tbDisplay8.Text = memory.ToString();
        }

        private void bMR_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = memory.ToString();
            tbDisplay4.Text = memory.ToString();
            tbDisplay2.Text += memory.ToString();
            last = true;
            first = false;
            int sizetb = tbDisplay2.Text.ToString().Length;
            tbDisplay6.Text = sizetb.ToString();
            int sizein = tbDisplay.Text.Length;
            tbDisplay5.Text = sizein.ToString();
        }

        private void bMS_Click(object sender, EventArgs e)
        {
            memory = double.Parse(tbDisplay.Text);
            tbDisplay8.Text = memory.ToString();
        }

        private void bMplus_Click(object sender, EventArgs e)
        {
            memory += double.Parse(tbDisplay.Text);
            tbDisplay8.Text = memory.ToString();
        }

        private void bMminus_Click(object sender, EventArgs e)
        {
            memory -= double.Parse(tbDisplay.Text);
            tbDisplay8.Text = memory.ToString();
        }

        private void programistyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
            blockbutton();
            memory = 0;
            tbDisplay8.Text = memory.ToString();
            ActiveForm.Width = 470;
            ActiveForm.Height = 457;

        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
            blockbutton();
            memory = 0;
            tbDisplay8.Text = memory.ToString();
            ActiveForm.Width = 470;
            ActiveForm.Height = 621;

        }

        private void standardowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
            memory = 0;
            tbDisplay8.Text = memory.ToString();
            tbDisplay2.Visible = true;
            bPierwiastek.Enabled = true;
            bUlamek.Enabled = true;
            bPotegowanie.Enabled = true;
            btDot.Enabled = true;
            btChange.Enabled = true;
            ActiveForm.Width = 316;
            ActiveForm.Height = 457;
            prevsys = "dec";
            nobin();
            nohex();
            nooct();
        }

        public void blockbutton()
        {
            tbDisplay2.Visible = false;
            bPierwiastek.Enabled = false;
            bUlamek.Enabled = false;
            bPotegowanie.Enabled = false;
            btDot.Enabled = false;
            btChange.Enabled = false;
        }


        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(tbDisplay.Text);
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string schowek = System.Windows.Forms.Clipboard.GetText();
            double n;
            bool isNumeric = double.TryParse(schowek.ToString(), out n);

            if (isNumeric == true)
            {
                tbDisplay.Text = schowek.ToString();
                tbDisplay4.Text = schowek.ToString();
                tbDisplay2.Text += memory.ToString();
                int sizetb = tbDisplay2.Text.ToString().Length;
                tbDisplay6.Text = sizetb.ToString();
                int sizein = tbDisplay.Text.Length;
                tbDisplay5.Text = sizein.ToString();
                last = true;
                first = false;
            }
        }

        private void btA_Click(object sender, EventArgs e)
        {
            display("A");
            first = false;
        }

        private void btB_Click(object sender, EventArgs e)
        {
            display("B");
            first = false;
        }

        private void btC_Click(object sender, EventArgs e)
        {
            display("C");
            first = false;
        }

        private void btD_Click(object sender, EventArgs e)
        {
            display("D");
            first = false;
        }

        private void btE_Click(object sender, EventArgs e)
        {
            display("E");
            first = false;
        }

        private void btF_Click(object sender, EventArgs e)
        {
            display("F");
            first = false;
        }

        private void rHex_CheckedChanged(object sender, EventArgs e)
        {
            convert();
            memory = 0;
            tbDisplay8.Text = memory.ToString();
            tbDisplay.Text = cvr.ToString("X");
            tbDisplay3.Text = tbDisplay.Text;
            hex();
            prevsys = "hex";
            tbDisplay9.Text = prevsys;
        }

        private void rDec_CheckedChanged(object sender, EventArgs e)
        {
            convert();
            memory = 0;
            tbDisplay8.Text = memory.ToString();
            tbDisplay.Text = cvr.ToString();
            tbDisplay3.Text = tbDisplay.Text;
            prevsys = "dec";
            tbDisplay9.Text = prevsys;

        }

        private void rOct_CheckedChanged(object sender, EventArgs e)
        {
            convert();
            memory = 0;
            tbDisplay8.Text = memory.ToString();
            tbDisplay.Text = Convert.ToString(cvr, 8);
            tbDisplay3.Text = tbDisplay.Text;
            oct();
            prevsys = "oct";
            tbDisplay9.Text = prevsys;
        }

        private void rBin_CheckedChanged(object sender, EventArgs e)
        {
            convert();
            memory = 0;
            tbDisplay8.Text = memory.ToString();
            tbDisplay.Text = Convert.ToString(cvr, 2);
            tbDisplay3.Text = tbDisplay.Text;
            bin();
            prevsys = "bin";
            tbDisplay9.Text = prevsys;
        }

        public void convert()
        {
            if (tbDisplay3.Text.Length > 0)
            {
                switch (prevsys)
                {
                    case "dec":
                        cvr = int.Parse(tbDisplay3.Text);
                        break;
                    case "hex":
                        nohex();
                        cvr = int.Parse(tbDisplay3.Text, System.Globalization.NumberStyles.HexNumber);
                        break;
                    case "oct":
                        nooct();
                        cvr = Convert.ToInt32(tbDisplay3.Text, 8);
                        break;
                    case "bin":
                        nobin();
                        cvr = Convert.ToInt32(tbDisplay3.Text, 2);
                        break;
                }
            }
        }

        public void bin()
        {
            btNr2.Enabled = false;
            btNr3.Enabled = false;
            btNr4.Enabled = false;
            btNr5.Enabled = false;
            btNr6.Enabled = false;
            btNr7.Enabled = false;
            btNr8.Enabled = false;
            btNr9.Enabled = false;
        }

        public void nobin()
        {
            btNr2.Enabled = true;
            btNr3.Enabled = true;
            btNr4.Enabled = true;
            btNr5.Enabled = true;
            btNr6.Enabled = true;
            btNr7.Enabled = true;
            btNr8.Enabled = true;
            btNr9.Enabled = true;
        }

        public void oct()
        {
            btNr9.Enabled = false;
            btNr8.Enabled = false;
        }

        public void nooct()
        {
            btNr9.Enabled = true;
            btNr8.Enabled = true;
        }

        public void hex()
        {
            btA.Enabled = true;
            btB.Enabled = true;
            btC.Enabled = true;
            btD.Enabled = true;
            btE.Enabled = true;
            btF.Enabled = true;
        }

        public void nohex()
        {
            btA.Enabled = false;
            btB.Enabled = false;
            btC.Enabled = false;
            btD.Enabled = false;
            btE.Enabled = false;
            btF.Enabled = false;
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text.Length > 0 && tbDisplay.Text.Contains("-"))
            {
                tbDisplay.Text = tbDisplay.Text.Remove(0, 1);
                tbDisplay4.Text = tbDisplay4.Text.Remove(0, 1);
            }
            else
            {
                tbDisplay.Text = "-" + tbDisplay.Text;
                tbDisplay4.Text = "-" + tbDisplay4.Text;
            }
        }

        private void pomocyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Kalkulator utworzony przez Tomasza Pazera, 3ib", "Informacje o autorze");
        }
    }
}
