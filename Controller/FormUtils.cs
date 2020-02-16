using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controller
{
    public class FormUtils
    {
        public static void CleanAllTextBox(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (IsTextBox(control))
                {
                    var textBox = (TextBox)control;
                    textBox.Clear();
                }
            }
        }

        private static bool IsTextBox(Control control)
        {
            return control.GetType() == typeof(TextBox);
        }

        public static bool IsRequiredFieldsValid(Form form)
        {
            return form.Controls.OfType<TextBox>().Any(x => x.Tag.ToString() == "Required"
                                                            && string.IsNullOrEmpty(x.Text));
        }

        public static string DateToString(DateTime dateTime)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0} / {1} / {2}", 
                dateTime.Day.ToString(), 
                dateTime.Month.ToString(),
                dateTime.Year.ToString()
            );
                
            return sb.ToString();
        }
    }
}