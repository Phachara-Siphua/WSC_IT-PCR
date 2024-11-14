using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCD
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }
        public void setall(Control ctrl)
        {
            foreach(Control c in ctrl.Controls)
            {
                if(c is Button bt)
                {
                    if (bt.Text == "Cancel")
                    {
                        bt.BackColor = Color.Red;
                        bt.ForeColor = Color.White;
                    }
                    else
                    {
                        bt.BackColor = Color.Green;
                        bt.ForeColor = Color.White;
                    }
                }
                if(c is DataGridView d)
                {
                    d.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
                    d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    d.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    d.AllowUserToResizeColumns = false;
                    d.RowHeadersVisible = false;
                    d.MultiSelect = false;
                }
                if(c is ComboBox cc)
                {
                    cc.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                if(c is DateTimePicker dd)
                {
                    dd.Format = DateTimePickerFormat.Custom;
                    dd.CustomFormat = ("/ /");
                    dd.MaxDate = DateTime.Now;
                }
                if (c.HasChildren)
                {
                    setall(c);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.SaddleBrown;
            panel1.ForeColor = Color.White;
            setall(panel1);
        }
    }
}
