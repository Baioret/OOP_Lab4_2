using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_2
{
    public partial class Form1 : Form
    {
        Model model;

        public Form1()
        {
            InitializeComponent();

            model = new Model();
            model.observers += new System.EventHandler(this.UpdateFromModel);
        }

        private void UpdateFromModel(object  sender, EventArgs e)
        {
            textBoxA.Text = model.getValueA().ToString();
            numericA.Value = model.getValueA();
            trackBarA.Value = model.getValueA();

            textBoxB.Text = model.getValueB().ToString();
            numericB.Value = model.getValueB();
            trackBarB.Value = model.getValueB();

            textBoxC.Text = model.getValueC().ToString();
            numericC.Value = model.getValueC();
            trackBarC.Value = model.getValueC();
        }

        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setValueA(Int32.Parse(textBoxA.Text));
        }

        private void numericA_ValueChanged(object sender, EventArgs e)
        {
            model.setValueA(Decimal.ToInt32(numericA.Value));
        }

        private void trackBarA_MouseUp(object sender, MouseEventArgs e)
        {
            model.setValueA(Decimal.ToInt32(trackBarA.Value));
        }


        private void textBoxB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setValueB(Int32.Parse(textBoxB.Text));
        }

        private void numericB_ValueChanged(object sender, EventArgs e)
        {
            model.setValueB(Decimal.ToInt32(numericB.Value));
        }

        private void trackBarB_MouseUp(object sender, MouseEventArgs e)
        {
            model.setValueB(Decimal.ToInt32(trackBarB.Value));
        }


        private void textBoxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setValueC(Int32.Parse(textBoxC.Text));
        }

        private void numericC_ValueChanged(object sender, EventArgs e)
        {
            model.setValueC(Decimal.ToInt32(numericC.Value));
        }

        private void trackBarC_MouseUp(object sender, MouseEventArgs e)
        {
            model.setValueC(Decimal.ToInt32(trackBarC.Value));
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            model.setValueA(App.Default.ValueA);
            model.setValueC(App.Default.ValueC);
            model.setValueB(App.Default.ValueB);
        }


        private void trackBarA_ValueChanged(object sender, EventArgs e)
        {
            labelA.Text = trackBarA.Value.ToString();
        }

        private void trackBarB_ValueChanged(object sender, EventArgs e)
        {
            labelB.Text = trackBarB.Value.ToString();
        }

        private void trackBarC_ValueChanged(object sender, EventArgs e)
        {
            labelC.Text = trackBarC.Value.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            App.Default.ValueA = model.getValueA();
            App.Default.ValueB = model.getValueB();
            App.Default.ValueC = model.getValueC();

            App.Default.Save();
        }
    }

    public class Model
    {
        private int A;
        private int B;
        private int C;

        public EventHandler observers;

        public void setValueA(int value)
        {
            if (value < 0 || value > 100)
            {
                observers.Invoke(this, null);
                return;
            }

            if (value % 2 == 1)
                A = value + 1;
            else
                A = value;

            if (A > C)
                C = A;

            if (A > B)
                B = A;

            observers.Invoke(this, null);
        }

        public void setValueB(int value)
        {
            if (value < A || value > C || value < 0 || value > 100)
            {
                observers.Invoke(this, null);
                return;
            }

            if (value % 2 == 1)
                B = value + 1;
            else
                B = value;

            observers.Invoke(this, null);
        }

        public void setValueC(int value)
        {
            if (value < 0 || value > 100)
            {
                observers.Invoke(this, null);
                return;
            }

            if (value % 2 == 1)
                C = value + 1;
            else
                C = value;

            if (C < B)
                B = C;

            if (C < A)
                A = C;

            observers.Invoke(this, null);
        }

        public int getValueA()
        {
            return A;
        }

        public int getValueB()
        {
            return B;
        }

        public int getValueC()
        {
            return C;
        }
    }
}
