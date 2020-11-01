using System;
using System.Collections.Generic;
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
            }
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
