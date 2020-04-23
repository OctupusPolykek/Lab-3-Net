using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetThirdlab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveV_Click(object sender, EventArgs e)
        {
            try
            {
                AX.Enabled = false;
                AY.Enabled = false;
                AZ.Enabled = false;

                BX.Enabled = false;
                BY.Enabled = false;
                BZ.Enabled = false;

                Point p1 = new Point(Int32.Parse(AX.Text), Int32.Parse(AY.Text), Int32.Parse(AZ.Text));
                Point p2 = new Point(Int32.Parse(BX.Text), Int32.Parse(BY.Text), Int32.Parse(BZ.Text));

                Vectors vectros = new Vectors(p1, p2);

                Calculate.AppendText(vectros.Calculate());
                Scalar.AppendText(p1.ScalarV(p2) + ";");
                Collinearity.AppendText(vectros.IsCollinearity());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

                AX.Clear();
                AY.Clear();
                AZ.Clear();

                BX.Clear();
                BY.Clear();
                BZ.Clear();
            }
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            AX.Clear();
            AY.Clear();
            AZ.Clear();

            BX.Clear();
            BY.Clear();
            BZ.Clear();

            Calculate.Clear();
            Scalar.Clear();
            Collinearity.Clear();

            AX.Enabled = true;
            AY.Enabled = true;
            AZ.Enabled = true;

            BX.Enabled = true;
            BY.Enabled = true;
            BZ.Enabled = true;
        }


    }
}
