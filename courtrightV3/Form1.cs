using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace courtCount
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        private int count = 0;

        public void GetAverages()
        {
            FileStream getAverage = new FileStream(@"output.txt", FileMode.Open, FileAccess.Read);
            StreamReader readOutput = new StreamReader(getAverage);

            var listForAverage = new List<int>();

            while (readOutput.EndOfStream != true)
            {
                int placeholder;

                if (int.TryParse(readOutput.ReadLine(), out placeholder))
                    listForAverage.Add(placeholder);
            }

            if (count > 0)
                listForAverage.Add(count);

            if (listForAverage.Count > 0)
            {
                double uAverage = listForAverage.Average();
                string average = uAverage.ToString("#.##");

                displayAverage.Text = average;
            }

            else
            {
                displayAverage.Text = "0";
            }

            for (int i = 0; i < listForAverage.Count; i++)
            {
                chart1.Series["Smacks"].Points.AddXY(i + 1, listForAverage[i]);
            }

            highscore.Text = Convert.ToString(listForAverage.Max());

            readOutput.Close();
        }

        private void smack_Click(object sender, EventArgs e)
        {
            ++count;
            currentCount.Text = count.ToString();
            GetAverages();
            
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (count > 0)
            {
                FileStream writer = new FileStream(@"output.txt", FileMode.Append, FileAccess.Write);
                StreamWriter writeOutput = new StreamWriter(writer);

                writeOutput.WriteLine(count);
                writeOutput.Close();
            }
        }
        
        private void mainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"output.txt") == false)
            { 
                var createOutput = File.Create(@"output.txt");
                createOutput.Close();
            }

            currentCount.Text = count.ToString();
            GetAverages();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = comboBox1.SelectedItem.ToString();
            chart1.Series["Smacks"].Color = Color.FromName(color);
        }
    }
}