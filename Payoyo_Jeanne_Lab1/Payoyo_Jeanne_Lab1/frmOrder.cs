using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payoyo_Jeanne_Lab1
{
    /*
     * Title: Payoyo Jeanne Lab 1
     * Class: CPRG 200
     * Date Created: June 25, 2021
     * Due Date: June 30, 2021
     * Author: Jeanne Payoyo
     * Description: Lunch Order Form for Tahlia's family friendly retro-themed diner
     */
    public partial class frmOrder : Form
    {
        // Initializes the form
        public frmOrder()
        {
            InitializeComponent();
        }

        // On load, the form has hamburger checked and the rest is empty
        private void frmOrder_Load(object sender, EventArgs e)
        {
            radHamburger.Checked = true;
            MyReset();
        }

        // Unchecks all add-ons and resets the Sub Total, Tax and Total
        private void MyReset()
        {
            chkAddOn1.Checked = false;
            chkAddOn2.Checked = false;
            chkAddOn3.Checked = false;
            txtSubTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
        }

        // When hamburger is selected, the add-ons are unchecked, the add-on text is changed, and the totals are removed
        private void radHamburger_CheckedChanged(object sender, EventArgs e)
        {
            MyReset();
            lblAddOnDesc.Text = "Fill your burger with these add-ons for only $0.75 each.";
            chkAddOn1.Text = "Lettuce, Tomato, Onion";
            chkAddOn2.Text = "Ketchup, Mustard, Mayo";
            chkAddOn3.Text = "French Fries";
        }

        // When pizza is selected, the add-ons are unchecked, the add-on text is changed, and the totals are removed
        private void radPizza_CheckedChanged(object sender, EventArgs e)
        {
            MyReset();
            lblAddOnDesc.Text = "Fill your pizza with these add-ons for only $0.50 each.";
            chkAddOn1.Text = "Pepperoni";
            chkAddOn2.Text = "Sausage";
            chkAddOn3.Text = "Olives";
        }

        // When salad is selected, the add-ons are unchecked, the add-on text is changed, and the totals are removed
        private void radSalad_CheckedChanged(object sender, EventArgs e)
        {
            MyReset();
            lblAddOnDesc.Text = "Fill your salad with these add-ons for only $0.25 each.";
            chkAddOn1.Text = "Croutons";
            chkAddOn2.Text = "Bacon Bits";
            chkAddOn3.Text = "Bread Sticks";
        }

        // Resets the form by clicking Reset or Alt + R
        private void btnReset_Click(object sender, EventArgs e)
        {
            radHamburger.Checked = true;
            MyReset();
        }

        // Exits the form by clicking Exit, Alt + E or ESC
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // CLASS-LEVEL
        // Defines constants for main courses
        const decimal HAMBURGER = 6.95m;     // Base cost for Hamburger
        const decimal PIZZA = 5.95m;         // Base cost for Pizza
        const decimal SALAD = 4.95m;         // Base cost for Salad
        // Defines constants for add-ons
        const decimal ADD_HAM = 0.75m;       // (Lettuce, Tomato, Onion), (Ketchup, Mustard, Mayo), (French Fries) 
        const decimal ADD_PIZ = 0.50m;       // Pepperoni, Sausage, Olives
        const decimal ADD_SAL = 0.25m;       // Croutons, Bacon Bits, Bread Sticks
        // Define tax
        const decimal TAX_RATE = 0.05m;      // Government sales tax

        // Calculates and displays the Sub Total, Tax and Total by clicking Calculate, Alt + C or ENTER
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Initiates variables
            decimal subtotal;                // Base price of main course + add-on(s)
            decimal tax = 0;                 // 5% tax on sub total, set as 0 for initial value
            decimal total = 0;               // subtotal plus tax, set as 0 for initial value

            // Calculates the sub total based on main course
            if (radHamburger.Checked)        // Hamburger is main course
            {
                subtotal = HAMBURGER;
                if (chkAddOn1.Checked)
                    subtotal += ADD_HAM;
                if (chkAddOn2.Checked)
                    subtotal += ADD_HAM;
                if (chkAddOn3.Checked)
                    subtotal += ADD_HAM;
            }
            else if (radPizza.Checked)       // Pizza is main course
            {
                subtotal = PIZZA;
                if (chkAddOn1.Checked)
                    subtotal += ADD_PIZ;
                if (chkAddOn2.Checked)
                    subtotal += ADD_PIZ;
                if (chkAddOn3.Checked)
                    subtotal += ADD_PIZ;
            }
            else                            // Salad must be main course
            {
                subtotal = SALAD;
                if (chkAddOn1.Checked)
                    subtotal += ADD_SAL;
                if (chkAddOn2.Checked)
                    subtotal += ADD_SAL;
                if (chkAddOn3.Checked)
                    subtotal += ADD_SAL;
            }

            // Calculate tax and total
            decimal[] result = calculateValues(subtotal);
            tax = result[0];
            total = result[1];

            // Display the subtotal, tax and total
            txtSubTotal.Text = subtotal.ToString("c");
            txtTax.Text = tax.ToString("c");
            txtTotal.Text = total.ToString("c");

        } // end of btn click function

        /// <summary>
        /// Calculates tax and total using subtotal
        /// </summary>
        private decimal[] calculateValues(decimal subtotal)
        {
            // initialize 1D array
            decimal[] result = { 0, 0 };
            // calculate tax and total
            decimal tax = subtotal * TAX_RATE;
            decimal total = subtotal + tax;
            // store tax and total
            result[0] = tax;
            result[1] = total;
            // returns the result array
            return result;
        }

    } // end of class
} // end of namespace
