using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManyAlphabeticallySubstitution
{
    public partial class Form1 : Form
    {
        private static int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncryptText_Click(object sender, EventArgs e)
        {
            ManyAlphabetically obj = new ManyAlphabetically();
            int len, val;

            if (isEmpty(txtOrigText.Text))
                MessageBox.Show("Въведете съобщение.", "Невалиден вход");
            else if (!obj.check_message(txtOrigText.Text))
                MessageBox.Show("Открити са неразрешени символи.", "Невалиден вход");
            else
            {
                len = txtOrigText.TextLength;
                val = count / 10;
                if (val<0 || val>4)
                {
                    MessageBox.Show("Проблем с криптографския ключ.", "Невалиден вход.");
                    val = 0;
                }
                else
                {
                    lblCounter.Text = val.ToString();

                    obj.set_values_e(txtOrigText.Text, val);
                    obj.make_cryptogram(len);

                    lblEncryptedTextRes.Visible = true;
                    txtEncryptedTextRes.Visible = true;
                    txtEncryptedTextRes.Text = obj.get_cryptogram();
                    lblCounter.Visible = true;

                    count++;
                }
            }
        }
        private void btnDecryptText_Click(object sender, EventArgs e)
        {
            if (count % 10 == 0)
                count--;
            ManyAlphabetically obj = new ManyAlphabetically();

            int len, val;

            if (isEmpty(txtEncryptedText.Text))
                MessageBox.Show("Въведете криптограма.", "Невалиден вход");
            else if (!obj.check_message(txtEncryptedText.Text))
                MessageBox.Show("Открити са неразрешени символи.", "Невалиден вход");
            else
            {
                len = txtEncryptedText.TextLength;
                val = count / 10;
                if (val < 0 || val >4)
                {
                    MessageBox.Show("Проблем с криптографския ключ.", "Невалиден вход");
                    val = 0;
                }
                else
                {
                    lblCounter.Text = val.ToString();
                    obj.set_values_d(txtEncryptedText.Text, val);
                    obj.make_text(len);

                    lblOrigTextRes.Visible = true;
                    txtOrigTextRes.Visible = true;
                    txtOrigTextRes.Text = obj.get_text();
                    lblCounter.Visible = true;

                    count--;
                }
            }
        }

       

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrigText.Text = "";
            txtEncryptedText.Text = "";
            txtEncryptedTextRes.Text = "";
            txtOrigTextRes.Text = "";
            txtEncryptedTextRes.Visible = false;
            lblEncryptedTextRes.Visible = false;
            txtOrigTextRes.Visible = false;
            lblOrigTextRes.Visible = false;
            lblCounter.Visible = false;

            count = 0;

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isEmpty(string s)
        {
            return s.Equals(string.Empty);
        }
    }
}
