using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class DataM : Form
    {
        public DataM()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Contains("http"))
            {
               // textBox2.Text = "http://" + textBox2.Text;
                using (WebClient client = new WebClient())
                {
                    // specify encoding
                    client.Encoding = System.Text.UTF8Encoding.UTF8;

                    // output
                    //webdata = client.DownloadString(Url);

                    richTextBox1.Text = client.DownloadString("http://" + textBox2.Text).ToLower();

                }
            }
               
            else {
                //string Url = "https://covidsl.com/";
                //string webdata;

                // DownloadString (no encoding specified)
                using (WebClient client = new WebClient())
                {
                    // specify encoding
                    client.Encoding = System.Text.UTF8Encoding.UTF8;

                    // output
                    //webdata = client.DownloadString(Url);

                    richTextBox1.Text = client.DownloadString(textBox2.Text).ToLower();

                }
            }
        }

        public static class Check
        {
            public static int CheckOccurrences(string str1, string pattern)
            {
                int count = 0;
                int a = 0;

                while ((a = str1.IndexOf(pattern, a)) != -1)
                {
                    a += pattern.Length;
                    count++;
                }
                return count;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            int start = 0;



            //string rich = richTextBox1.Text;
            //string txtbox1 = textBox1.Text;
            int end = richTextBox1.Text.LastIndexOf(textBox1.Text);
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;
            while (start < end)
            {
                richTextBox1.Find(textBox1.Text, start, richTextBox1.TextLength, RichTextBoxFinds.MatchCase);
                richTextBox1.SelectionBackColor = Color.Yellow;

                start = richTextBox1.Text.IndexOf(textBox1.Text, start) + 1;
            }

            string str = richTextBox1.Text;
            string txt = textBox1.Text;
            var ggg = Check.CheckOccurrences(str.ToLower(), txt.ToLower());
            label1.Text = ggg.ToString();
            //Console.WriteLine("Occurrence:" + Check.CheckOccurrences(str, "HTML"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = 0;
            int start = 0;



            //string rich = richTextBox1.Text;
            //string txtbox1 = textBox1.Text;
            int end = richTextBox1.Text.LastIndexOf(textBox3.Text);
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;
            while (start < end)
            {
                richTextBox1.Find(textBox3.Text, start, richTextBox1.TextLength, RichTextBoxFinds.MatchCase);
                richTextBox1.SelectionBackColor = Color.Red;

                start = richTextBox1.Text.IndexOf(textBox3.Text, start) + 1;
            }

            string str = richTextBox1.Text;
            string txt = textBox3.Text;
            var ggg = Check.CheckOccurrences(str.ToLower(), txt.ToLower());
            label7.Text = ggg.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = 0;
            int start = 0;



            //string rich = richTextBox1.Text;
            //string txtbox1 = textBox1.Text;
            int end = richTextBox1.Text.LastIndexOf(textBox4.Text);
            richTextBox1.SelectAll();
            //richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.SelectionBackColor = Color.White;
            while (start < end)
            {
                richTextBox1.Find(textBox4.Text, start, richTextBox1.TextLength, RichTextBoxFinds.MatchCase);
                richTextBox1.SelectionBackColor = Color.Blue;

                start = richTextBox1.Text.IndexOf(textBox4.Text, start) + 1;
            }

            string str = richTextBox1.Text;
            string txt = textBox4.Text;
            var ggg = Check.CheckOccurrences(str.ToLower(), txt.ToLower());
            label8.Text = ggg.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = 0;
            int start = 0;



            //string rich = richTextBox1.Text;
            //string txtbox1 = textBox1.Text;
            int end = richTextBox1.Text.LastIndexOf(textBox5.Text);
            richTextBox1.SelectAll();
            //richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.SelectionBackColor = Color.White;
            while (start < end)
            {
                richTextBox1.Find(textBox5.Text, start, richTextBox1.TextLength, RichTextBoxFinds.MatchCase);
                richTextBox1.SelectionBackColor = Color.Green;

                start = richTextBox1.Text.IndexOf(textBox5.Text, start) + 1;
            }

            string str = richTextBox1.Text;
            string txt = textBox5.Text;
            var ggg = Check.CheckOccurrences(str.ToLower(), txt.ToLower());
            label9.Text = ggg.ToString();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Selection mm = new Selection();
            mm.Show();
        }
    }
}
