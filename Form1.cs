using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarrenLee.Translator;
namespace language_translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IDictionary<string, string> dict = new Dictionary<string, string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //string txt=Translator.Translate("Here is your message", "en",  "fa");
            //MessageBox.Show(txt);
            dict.Add("English", "en");
            dict.Add("Urdu", "ur");
            dict.Add("Chinese", "zh");
            dict.Add("Hebrew", "he");
            dict.Add("Hindi", "hi");
            dict.Add("Japanese", "ja");
            foreach (KeyValuePair<string, string> item in dict)
            {
                comboBox1.Items.Add(item.Key);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dict[comboBox1.Text]);
            string txt=Translator.Translate(textBox1.Text, "en", dict[comboBox1.Text]);
            label2.Text = txt;

        }
    }
}
//https://www.youtube.com/watch?v=I0l0vbOOSso learned from this video