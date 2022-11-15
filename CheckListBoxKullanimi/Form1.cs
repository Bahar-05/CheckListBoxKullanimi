using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tümünüsec_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void secilenikaldir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void elemanekle_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Insert(3, "Hakkari");
        }

        private void listboxekle_Click(object sender, EventArgs e)
        {
            foreach (string item in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Toplam Eleman Sayısı: " + checkedListBox1.Items.Count.ToString();
            //CheckListBox'ta aranan eleman olup olmadığını kontrol eder.
            bool aranilan = checkedListBox1.Items.Contains("Rize");
            if (aranilan == true)
            {
                label3.Text = "Aranılan eleman bulundu";
            }
            else
            {
                label3.Text = "Aranılan eleman bulunamadı";
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "";
            label2.Text = "Seçilen eleman sayısı: " + checkedListBox1.CheckedItems.Count;
        }
    }
}
        
    
    
