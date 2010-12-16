using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Milkshake.Integration.Google.Translate;

namespace wg_translator
{
    public partial class Translator : Form
    {
        public Translator()
        {
            InitializeComponent();
        }

        private void btTraduzir_Click(object sender, EventArgs e)
        {
            TranslateApi translator = new TranslateApi();
            tbTextoTraduzido.Text = translator.TranslateText(tbTextoATraduzir.Text, "en", "pt", "AIzaSyCvCKdt5pxdOq2lto54dt24ulDK6Wm_p-I");
        }

    }
}
