using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0828_listBox
{
    public partial class AddItemText : Form
    {
        public AddItemText()
        {
            InitializeComponent();
        }

        private void NewItemButton_Click(object sender, EventArgs e)
        {
            area.Items.Add("員林鎮");
            itemCountValue.Text = area.Items.Count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            itemCountValue.Text = area.Items.Count.ToString();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            area.Items.RemoveAt(area.Items.Count - 1);
            itemCountValue.Text = area.Items.Count.ToString();
        }

        private void RemoveAreaButton_Click(object sender, EventArgs e)
        {
            int i = area.SelectedIndex;
            if (i > 0)
            {
                area.Items.RemoveAt(i);
                itemCountValue.Text = area.Items.Count.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            area.Items[0] += "坪瀨琉璃光之橋";
            itemCountValue.Text = area.Items.Count.ToString();
        }

        private void NewItemButtonArea_Click(object sender, EventArgs e)
        {
            string text = NewItemArea.Text;
            area.Items.Add(text);
            itemCountValue.Text = area.Items.Count.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeShow.Text = DateTime.Now.ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
