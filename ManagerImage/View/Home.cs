using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerImage.View
{
    public partial class Home : UserControl
    {
        Style style = new Style();
        public Home()
        {
            InitializeComponent();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 367));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tableLayoutPanel2.RowStyles.Clear();
            tableLayoutPanel2.Width = 367;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            tableLayoutPanel2.BackColor = ColorTranslator.FromHtml("#233F6A");
            style.ButtonDefault(button1);
            style.ButtonDefault(button2);
            style.ButtonDefault(button3);
            style.ButtonDefault(button4);
            style.ButtonDefault(button5);
            style.ButtonDefault(button6);
            style.Lable_Default(label1);
            ImageUser IU = new ImageUser();
            panel1.Controls.Clear();
            panel1.Controls.Add(IU);
            IU.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageUser IU = new ImageUser();
            panel1.Controls.Clear();
            panel1.Controls.Add(IU);
            IU.Dock = DockStyle.Fill;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Album album = new Album();
            panel1.Controls.Clear();
            panel1.Controls.Add(album);
            album.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlbumShare AS = new AlbumShare();
            panel1.Controls.Clear();
            panel1.Controls.Add(AS);
            AS.Dock = DockStyle.Fill;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tag T = new Tag();
            panel1.Controls.Clear();
            panel1.Controls.Add(T);
            T.Dock = DockStyle.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Account A = new Account();
            panel1.Controls.Clear();
            panel1.Controls.Add(A);
            A.Dock = DockStyle.Fill;
        }
    }
}
