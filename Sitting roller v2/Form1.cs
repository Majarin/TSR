using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Sitting_roller_v2
{
    public partial class frmroller : Form
    {
        public string[] Peoples = { };
        List<string> People = new List<string>();
        List<int> l = new List<int>();
        public string[] removeSave = { };
        public string filePath = @"C:\Users\TomRuneWakaValen\source\repos\Sitting roller v2\Save_List.txt";
        public int remove = 0;
        public int old = -1;
        public frmroller()
        {
            InitializeComponent();
        }

        //Shortcuts
        private void OnKeyDownHandeler(object sender, KeyEventArgs kea)
        {
            //temp
            if (kea.KeyCode.Equals(Keys.Up))
            {
                if (old + 1 < People.Count)
                {
                    old++;
                    txtAR.Text = People[old];
                    Console.Write("?");
                }
            }
            if (kea.KeyCode.Equals(Keys.Down))
            {
                if (old - 1 >= 0)
                {
                    old--;
                    txtAR.Text = People[old];
                }
                else
                {
                    txtAR.Text = "";
                    old = -1;
                }
            }

            //temp
            if (kea.KeyCode.Equals(Keys.Return))
            {
                lblList.Text = "";
                People.Add(txtAR.Text);
                foreach (string line in People)
                {
                    lblList.Text = lblList.Text + line + "\n";
                }
                Console.WriteLine(People.Count);
                txtAR.Text = "";
                txtAR.Focus();
            }
            if (kea.KeyCode.Equals(Keys.Delete))
            {
                lblList.Text = "";
                People.Remove(txtAR.Text);
                }
                foreach (string line1 in People)
                {
                    lblList.Text = lblList.Text + line1 + "\n";
                }
        }
        //Add
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtAR.Text != "") 
            { 
                lblList.Text = "";
                People.Add(txtAR.Text);
                foreach (string name in People)
                {
                    lblList.Text = lblList.Text + name + "\n";
                }
                Console.WriteLine(People.Count);
                txtAR.Text = "";
                txtAR.Focus();
            }
        }
        //Remove
        private void btnRemove_Click(object sender, EventArgs e)
        {
            lblList.Text = "";
            People.Remove(txtAR.Text);
            foreach (string line1 in People)
            {
                lblList.Text = lblList.Text + line1 + "\n";
            }
            Array.Resize(ref removeSave, 0);
        }
        //Roll
        private void btnRoll_Click(object sender, EventArgs e)
        {
            lblList.Text = "";
            //People = People.OrderBy(x => Guid.NewGuid()).ToArray();
            foreach (string line in People)
            {
                lblList.Text = lblList.Text + line + "\n";
            }
        }
        //Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in People)
                {
                    writer.WriteLine(line);
                }
            }
        }
        //Open
        private void btnOpen_Click(object sender, EventArgs e)
        {
            lblList.Text = "";
            foreach (string line in File.ReadLines(filePath))
            {
                People.Add(line);
                lblList.Text = lblList.Text + line + "\n";
            }
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            lblList.Text = "";
        }
    }
}
