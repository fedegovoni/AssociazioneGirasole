using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class MultiformContext : ApplicationContext
    {
        private int openForms;

        public MultiformContext(params Form[] forms)
        {
            int openForms = forms.Length;
            foreach(Form form in forms)
            {
                form.FormClosed += (s, args) =>
                {
                    if (Interlocked.Decrement(ref openForms) == 0)
                        ExitThread();
                };
                form.Show();
            }
        }
    }
}
