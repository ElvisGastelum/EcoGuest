using System.Linq;
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
    }
}