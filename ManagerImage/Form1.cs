using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerImage.View;

namespace ManagerImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Home home = new Home();
            InitializeComponent();
            panel1.Controls.Clear();
            panel1.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }
    }
}
