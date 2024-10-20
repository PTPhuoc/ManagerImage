using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerImage.View
{
    internal class Style
    {
        PrivateFontCollection privateFonts = new PrivateFontCollection();
        public void ButtonDefault( Button b  ) {
            privateFonts.AddFontFile("F:/my_project/c_chap_app/ManagerImage/ManagerImage/MadimiOne-Regular.ttf");
            b.FlatStyle = FlatStyle.Flat;
            b.BackColor = ColorTranslator.FromHtml("#728CC0");
            b.ForeColor = Color.White;
            b.FlatAppearance.BorderSize = 0;
            b.Font = new Font(privateFonts.Families[0], 15, FontStyle.Regular);
            b.MouseEnter += B_MouseEnter;
            b.MouseLeave += B_MouseLeave;
        }
        private void B_MouseEnter(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = Color.White;
            b.ForeColor = ColorTranslator.FromHtml("#728CC0");
        }

        private void B_MouseLeave(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = ColorTranslator.FromHtml("#728CC0");
            b.ForeColor = Color.White;
        }

        public void Lable_Default(Label l)
        {
            privateFonts.AddFontFile("F:/my_project/c_chap_app/ManagerImage/ManagerImage/MadimiOne-Regular.ttf");
            l.Font = new Font(privateFonts.Families[0], 15, FontStyle.Regular);
            l.BackColor = ColorTranslator.FromHtml("#C3E2FF");
            l.ForeColor = ColorTranslator.FromHtml("#004BBC");
        }
    }
}
