using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizaa_APP
{
    public partial class Form1 : Form
    {

        // rd prefix represent radion button 
        // lbl prefix represent lable button 
        //chb  prefix represent chick box button
        public Form1()
        {
            InitializeComponent();

        }



        //updateing the price for checkbox 
        private int Update_price_for_Checkbox(CheckBox chb)
        {
            int a;
            if (chb.Checked)
            {
                a = Convert.ToInt32(chb.Tag);
                int b = Convert.ToInt32(lblprice.Text);
                a += b;
                lblprice.Text = a.ToString();

            }
            else
            {
                a = Convert.ToInt32(chb.Tag);
                int b = Convert.ToInt32(lblprice.Text);
                a = b - a;
                lblprice.Text = a.ToString();

            }
            return a;
        }


        //updating the price label ofthe raddion button 
        private int Update_the_price_for_raddionb(CheckBox chb)
        {
            if (chb.Checked)
            {
                return 5;
            }
            
                else { return 0; } 
        }
        private void calculate_total_price()
        {
            int size_p = 0;
            int crust_p = 0;
            int Topping_p = 0;
            //caclulate size price
            if (rdsmall.Checked)
            {
                size_p += 10;
            }
            else
            {
                if (rdmediam.Checked)
                {
                    size_p += 20;
                }
                else
                {
                    size_p += 30;
                }
            }

            //calculate crust price
            if (rdthink.Checked) { crust_p += 10; }

            //calculate topping price 

            Topping_p += Update_the_price_for_raddionb(chbexratchees) +
                Update_the_price_for_raddionb(chbmushrooms) +
                Update_the_price_for_raddionb(chbtomatoes) +
                Update_the_price_for_raddionb(chbolives) +
                Update_the_price_for_raddionb(chbonion) +
                Update_the_price_for_raddionb(chbGreenpapper);



            //update total price label
            int total_price=size_p+crust_p+Topping_p;
            lblprice.Text =Convert.ToString(total_price) ;
        }

        // for size label
        private void rdsmall_Click(object sender, EventArgs e)
        {
            lblsize.Text = rdsmall.Text;
            calculate_total_price();

        }

        private void rdmediam_Click(object sender, EventArgs e)
        {
            lblsize.Text = rdmediam.Text;
            calculate_total_price();
        }

        private void rdlarg_Click(object sender, EventArgs e)
        {
            lblsize.Text = rdlarg.Text;
            calculate_total_price();
        }



        //for crust lable
        private void rdthin_Click(object sender, EventArgs e)
        {
            lblcrusttype.Text = rdthin.Text;
            calculate_total_price();

        }
        private void rdthink_Click(object sender, EventArgs e)
        {
            lblcrusttype.Text = rdthink.Text;
            calculate_total_price();
        }





        //for where to eat 
        private void rdeatin_Click(object sender, EventArgs e)
        {
            lblwheretoeat.Text = rdeatin.Text;
           
        }

        private void rdTakeaway_Click(object sender, EventArgs e)
        {
            lblwheretoeat.Text = rdTakeaway.Text;
           
        }



       


        // this function for updating the Topping lable text it used on click of any Topping group box click 
        private void Updating_Topping_label(object sender, EventArgs e)
        {
            string[] lablelist = { "", "", "", "", "", "" };

            lblTopping.Text = "";
            if (chbexratchees.Checked)
            {
                lablelist[0] = " Extra chess , ";

            }


            if (chbmushrooms.Checked)
            {
                lablelist[1] = " Mushrooms , ";
            }


            if (chbtomatoes.Checked)
            {
                lablelist[2] = "Tomato , ";
            }

            if (chbonion.Checked)
            {
                lablelist[3] = "Onion , ";

            }



            if (chbolives.Checked)
            {
                lablelist[4] = "Olives , ";
            }


            if (chbGreenpapper.Checked)
            {
                lablelist[5] = "Green papper. ";
            }

            for (int i = 0; i < lablelist.Length; i++)
            {
                lblTopping.Text += lablelist[i];
            }

            if (lblTopping.Text == "")
            {
                lblTopping.Text = "     No Topping";
            }

        }

        private void chbexratchees_Click(object sender, EventArgs e)
        {
            Updating_Topping_label(sender, e);
            calculate_total_price();
        }

        private void chbmushrooms_Click(object sender, EventArgs e)
        {
            Updating_Topping_label(sender, e);
            calculate_total_price();
        }

        private void chbtomatoes_Click(object sender, EventArgs e)
        {
            Updating_Topping_label(sender, e);
            calculate_total_price();
        }

        private void chbGreenpapper_Click(object sender, EventArgs e)
        {
            Updating_Topping_label(sender, e);
            calculate_total_price();
        }

        private void chbonion_Click(object sender, EventArgs e)
        {
            Updating_Topping_label(sender, e);
            calculate_total_price();
        }

        private void chbolives_Click(object sender, EventArgs e)
        {
            Updating_Topping_label(sender, e);

            calculate_total_price();




        }


            //reset to default  functions
            private void reset_size()
        {
            rdsmall.Checked = false;
            rdmediam.Checked = true;
            rdlarg.Checked = false;
        }
        private void reset_crusttype()
        {
            rdthin.Checked = true;
            rdthink.Checked = false;

        }
        private void reset_Topping(object sender, EventArgs e)
        {
            chbexratchees.Checked = false;
            chbmushrooms.Checked = false;
            chbtomatoes.Checked = false;
            chbolives.Checked = false;
            chbonion.Checked = false;
            chbGreenpapper.Checked = false;


        }
        private void reset_whetetoeat()
        {
            rdeatin.Checked = true;
            rdTakeaway.Checked = false;
        }
        private void Reset_order_summary(object sender, EventArgs e)
        {


            reset_Topping(sender, e);
            chbexratchees_Click(sender, e);
            chbmushrooms_Click(sender, e);
            chbtomatoes_Click(sender, e);
            chbolives_Click(sender, e);
            chbonion_Click(sender, e);
            chbGreenpapper_Click(sender, e);
            Updating_Topping_label(sender, e);
            rdmediam_Click(sender, e);
            rdthin_Click(sender, e);
            rdeatin_Click(sender, e);
        }
        private void bReset_Click(object sender, EventArgs e)
        {
            Reset_order_summary(sender, e);
            reset_size();
            reset_crusttype();
            reset_whetetoeat();

        }
        //lock the from controls after confirm order
        private void bconfirm_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show(" Confirm your Order ", "Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.OK)
            {
                gbsize.Enabled = false;
                gbcrust.Enabled = false;
                gbtopping.Enabled = false;
                gbwheretoeat.Enabled = false;
                bconfirm.Enabled = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
    }
}
