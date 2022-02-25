using RCM.Business.Concrete;
using RCM.DataAccess.Concrete.EntityFramework.Context;
using RCM.DataAccess.Concrete.EntityFramework.Repositories;
using RCM.Model.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RCMContext ctx = new RCMContext();
            AdressOfCustomer af = new AdressOfCustomer();
            af.CId = 1;
            af.AdressName = "okul";
            af.Adress = "sağlık lisesi";

            ctx.AdressOfCustomers.Add(af);
            ctx.SaveChanges();
            MessageBox.Show("oley");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdressOfCustomerBs bs = new AdressOfCustomerBs(new EfAdressOfCustomerRepo());
            List<AdressOfCustomer> cs =bs.GetAll().ToList();
        }
    }
}
