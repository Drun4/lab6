using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ///wayButton
        private void WayButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            wayTextBox.Text = openFileDialog.FileName;
        }

        ///int
        private void intToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryWriter writer = new BinaryWriter(File.Open(wayTextBox.Text, FileMode.Create));
            string[] inputs = textBox.Text.Split(' ');
            foreach(var input in inputs)
            {
                writer.Write(int.Parse(input));
            }
            writer.Close();
            textBox.Text = "";
        }
        private void intToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            BinaryReader reader = new BinaryReader(File.Open(wayTextBox.Text, FileMode.Open));
            do
            {
                textBox.Text += reader.ReadInt32() + " ";
            } while (reader.PeekChar() > -1);
            reader.Close();
        }

        ///double
        private void doubleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryWriter writer = new BinaryWriter(File.Open(wayTextBox.Text, FileMode.Create));
            string[] inputs = textBox.Text.Split(' ');
            foreach (var input in inputs)
            {
                writer.Write(double.Parse(input));
            }
            writer.Close();
            textBox.Text = "";
        }
        private void doubleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            BinaryReader reader = new BinaryReader(File.Open(wayTextBox.Text, FileMode.Open));
            do
            {
                textBox.Text += reader.ReadDouble() + " ";
            } while (reader.PeekChar() > -1);
            reader.Close();
        }

        ///int, double, string
        private void intDoubleStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryWriter writer = new BinaryWriter(File.Open(wayTextBox.Text, FileMode.Create));
            string[] inputs = textBox.Text.Split(' ');
            writer.Write(int.Parse(inputs[0]));
            writer.Write(double.Parse(inputs[1]));
            writer.Write(inputs[2]);
            writer.Close();
            textBox.Text = "";
        }
        private void intDoubleStringToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            BinaryReader reader = new BinaryReader(File.Open(wayTextBox.Text, FileMode.Open));
            textBox.Text = reader.ReadInt32() + " " + reader.ReadDouble() + " " + reader.ReadString();
            reader.Close();
        }

        ///person
        private void personToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BinaryWriter writer = new BinaryWriter(File.Open(wayTextBox.Text, FileMode.Create));
            string[] inputs = textBox.Text.Split(' ');
            writer.Write(inputs[0]);
            writer.Write(inputs[1]);
            writer.Write(int.Parse(inputs[2]));
            writer.Write(double.Parse(inputs[3]));
            writer.Write(double.Parse(inputs[4]));
            writer.Close();
            textBox.Text = "";
        }
        private void personToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            BinaryReader reader = new BinaryReader(File.Open(wayTextBox.Text, FileMode.Open));
            textBox.Text = reader.ReadString() + " " + reader.ReadString() + " " + reader.ReadInt32() + " "
                + reader.ReadDouble() + " " + reader.ReadDouble();
            reader.Close();
        }

        ///int list, double list
        private void personToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryWriter writer = new BinaryWriter(File.Open(wayTextBox.Text, FileMode.Create));
            string[] inputs = textBox.Text.Split('/');
            string[] inputs_int = inputs[0].Split(' ');
            string[] inputs_double = inputs[1].Split(' ');
            int variable_int = inputs_int.Length;
            writer.Write(variable_int);
            foreach (var input_int in inputs_int)
            {
                writer.Write(int.Parse(input_int));
            }
            foreach (var input_double in inputs_double)
            {
                writer.Write(double.Parse(input_double));
            }
            writer.Close();
            textBox.Text = "";
        }
        private void intListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            BinaryReader reader = new BinaryReader(File.Open(wayTextBox.Text, FileMode.Open));
            int variable_int = reader.ReadInt32();
            for(int i = 0; i < variable_int; i++)
            {
                textBox.Text += reader.ReadInt32() + " ";
            }
            do
            {
                textBox.Text += reader.ReadDouble() + " "; 
            } while (reader.PeekChar() > -1);
            reader.Close();
        }

        ///person list
        private void personListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryWriter writer = new BinaryWriter(File.Open(wayTextBox.Text, FileMode.Create));
            string[] persons = textBox.Text.Split('/');
            string[][] person = new string[persons.Length][];
            for (int i = 0; i < person.Length; i++)
            {
                person[i] = persons[i].Split(' ');
            }
            foreach(var per in person)
            {
                writer.Write(per[0]);
                writer.Write(per[1]);
                writer.Write(int.Parse(per[2].ToString()));
                writer.Write(double.Parse(per[3].ToString()));
                writer.Write(double.Parse(per[4].ToString()));
            }
            writer.Close();
            textBox.Text = "";
        }
        private void personListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            BinaryReader reader = new BinaryReader(File.Open(wayTextBox.Text, FileMode.Open));
            do
            {
                textBox.Text += reader.ReadString() + " " + reader.ReadString() + " " +
                    reader.ReadInt32() + " " + reader.ReadDouble() + " " + reader.ReadDouble() + " ";
            } while (reader.PeekChar() > -1);
            reader.Close();
        }

        ///clear button
        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

    }
}
