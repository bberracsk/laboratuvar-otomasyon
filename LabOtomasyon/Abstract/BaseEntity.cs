using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabOtomasyon.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public virtual void BilgiYaz()
        {
            MessageBox.Show("Base Entity");
        }
    }
}
