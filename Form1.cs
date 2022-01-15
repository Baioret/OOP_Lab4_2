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

        private void numericA_ValueChanged(object sender, EventArgs e)
        {
            model.setValue(Decimal.ToInt32(numericA.Value));
        }

        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setValue(Int32.Parse(textBoxA.Text));
        }

        private void UpdateFromModel(object  sender, EventArgs e)
        {
            textBoxA.Text = model.getValue().ToString();
            numericA.Value = model.getValue();
            trackBarA.Value = model.getValue();
        }

        private void trackBarA_ValueChanged(object sender, EventArgs e)
        {
            model.setValue(Decimal.ToInt32(trackBarA.Value));
        }
    }

    public class Model
    {
        private int value;

        public System.EventHandler observers;

        public void setValue(int value)
        {
            if (value % 2 == 1)
                this.value = value + 1;
            else
                this.value = value;

            observers.Invoke(this, null);
        }

        public int getValue()
        {
            return value;
        }
    }
}
