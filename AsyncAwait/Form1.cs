using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int  CountCharacters()
        {
            int count = 0;
            using (StreamReader reader =new StreamReader(@"C:\content-web\Orion 2.0\Ipreo.Orion.RestApi.Test\App.config") )
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }

            return count;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    label1.Text = "Processing File. Please wait...";
        //    var count = CountCharacters();
        //    label1.Text = count.ToString() + " characters in file";
        //}

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();

            //Task tsk=new Task(CountCharacters);
            //tsk.Start();

            label1.Text = "Processing File. Please wait...";
            //var count = await tsk;
            label1.Text = count.ToString() + " characters in file";
        }
    }
}
