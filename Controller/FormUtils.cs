using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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

        public static bool IsRequiredFieldsValidInGroupBox(Form form)
        {
            bool resultOfFirstLevel = form.Controls.OfType<GroupBox>().Any(x => x.Controls
                .OfType<TextBox>()
                .Any(y =>
                {
                    return y.Tag.ToString() == "Required"
                                  && string.IsNullOrEmpty(y.Text);
                }));

            bool resultOfSecondLevel = form.Controls.OfType<GroupBox>().Any(x =>
            {
                return x.Controls.OfType<GroupBox>()
                    .Any( y =>
                {
                    return y.Controls.OfType<TextBox>()
                        .Any(z => z.Tag.ToString() == "Required" 
                                  && string.IsNullOrEmpty(z.Text));
                });
            });

            if (resultOfFirstLevel == false && resultOfSecondLevel == false)
            {
                return true;
            }

            return false;
        }

        public static string DateToString(DateTime dateTime)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}/{1}/{2}", 
                dateTime.Day.ToString(), 
                dateTime.Month.ToString(),
                dateTime.Year.ToString()
            );
                
            return sb.ToString();
        }

        public static DateTime StringToDateTime(string date)
        {
            var dateSplit = date.Split(new []{ '/' }, StringSplitOptions.None);
            int year = int.Parse(dateSplit[2]);
            int month = int.Parse(dateSplit[1]);
            int day = int.Parse(dateSplit[0]);

            DateTime dateTime = new DateTime(year, month, day);
            return dateTime;
        }
    }
}