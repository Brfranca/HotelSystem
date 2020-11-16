using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public static class FormHelper
    {
        // MÉTODO RESPONSÁVEL POR REALIZAR A LIMPEZA DOS CAMPOS DO FORMULÁRIO
        public static void ClearForm(this Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i].HasChildren)
                {
                    ClearForm(control.Controls[i]);
                }
                // LIMPA TextBox
                if (control.Controls[i] is TextBox)
                {
                    ((TextBox)control.Controls[i]).Clear();

                    if (control.Controls[i].Name.ToString() == "txtTotalValue")
                    {
                        ((TextBox)control.Controls[i]).Text = "0";
                    }
                    else if (control.Controls[i].Name.ToString() == "txtProdQuantity")
                    {
                        ((TextBox)control.Controls[i]).Text = "0";
                    }
                    else if (control.Controls[i].Name.ToString() == "txtProdPrice")
                    {
                        ((TextBox)control.Controls[i]).Text = "0";
                    }
                    else if (control.Controls[i].Name.ToString() == "txtProductProfit")
                    {
                        ((TextBox)control.Controls[i]).Text = "0";
                    }
                }

                // LIMPA ComboBox
                else if (control.Controls[i] is ComboBox)
                {
                    ((ComboBox)control.Controls[i]).SelectedIndex = -1;
                }
                // LIMPA MaskedTextBox
                else if (control.Controls[i] is MaskedTextBox)
                {
                    ((MaskedTextBox)control.Controls[i]).Clear();
                }
                // LIMPA RichTextBox
                else if (control.Controls[i] is RichTextBox)
                {
                    ((RichTextBox)control.Controls[i]).Clear();
                }
                // LIMPA A LABEL DE ID
                else if (control.Controls[i] is Label)
                {
                    if (control.Controls[i].Name.ToString() == "lblID")
                    {
                        ((Label)control.Controls[i]).Text = "";
                    }
                    else if (control.Controls[i].Name.ToString() == "lblSupIdGet")
                    {
                        ((Label)control.Controls[i]).Text = "";
                    }
                }
                else if (control.Controls[i] is DataGridView)
                {
                    if (control.Controls[i].Name.ToString() == "dgvSearch")
                    {
                        ((DataGridView)control.Controls[i]).Rows.Clear();
                    }
                    else if (control.Controls[i].Name.ToString() == "dgvIncomeItems")
                    {
                        ((DataGridView)control.Controls[i]).Rows.Clear();
                    }
                    else if (control.Controls[i].Name.ToString() == "dgvSearchSupplier")
                    {
                        ((DataGridView)control.Controls[i]).Rows.Clear();
                    }
                }
            }
        }


        public static void MouseHoverEvent(this Label label)
        {
            label.Font = new Font(label.Font, FontStyle.Bold);
            label.ForeColor = Color.FromArgb(246, 142, 31);
        }

        public static void MouseHoverEvent(this Button button)
        {
            button.Font = new Font(button.Font, FontStyle.Bold);
           button.ForeColor = Color.FromArgb(246, 142, 31);
        }

        public static void MouseLeaveEvent(this Label label)
        {
            label.Font = new Font(label.Font, FontStyle.Regular);
            label.ForeColor = Color.FromArgb(255, 255, 255);
        }

        public static void MouseLeaveEvent(this Button button)
        {
            button.Font = new Font(button.Font, FontStyle.Regular);
            button.ForeColor = Color.FromArgb(255, 255, 255);
        }

        public static void EnterEvent(this Panel panel)
        {
           panel.BackColor = Color.FromArgb(37, 206, 15);
        }

        public static void LeaveEvent(this Panel panel)
        {
            panel.BackColor = Color.Black;
        }

       
        // MÉTODO RESPONSÁVEL POR GERAR O MD5 DAS SENHAS DOS FUNCIONÁRIOS
        public static string GerarHashMd5(string input)
        {
            MD5 md5Hash = MD5.Create();
            // CONVERTE A STRING PARA ARRAY DE BYTES
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // CRIA UM StringBuilder PARA RECOMPOR A STRING
            StringBuilder sBuilder = new StringBuilder();
            // LOOP PARA FORMATAR CADA BYTE COMO UMA STRING EM HEXADECIMAL
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
