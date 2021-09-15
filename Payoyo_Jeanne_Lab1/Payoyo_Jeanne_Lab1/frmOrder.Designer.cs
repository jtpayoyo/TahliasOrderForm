
namespace Payoyo_Jeanne_Lab1
{
    partial class frmOrder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.lblSaladPrice = new System.Windows.Forms.Label();
            this.lblPizzaPrice = new System.Windows.Forms.Label();
            this.lblHamburgerPrice = new System.Windows.Forms.Label();
            this.radSalad = new System.Windows.Forms.RadioButton();
            this.radPizza = new System.Windows.Forms.RadioButton();
            this.radHamburger = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpAddOn = new System.Windows.Forms.GroupBox();
            this.lblAddOnDesc = new System.Windows.Forms.Label();
            this.chkAddOn3 = new System.Windows.Forms.CheckBox();
            this.chkAddOn2 = new System.Windows.Forms.CheckBox();
            this.chkAddOn1 = new System.Windows.Forms.CheckBox();
            this.grpTahliaDesc = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTahliaDesc = new System.Windows.Forms.Label();
            this.grpTotal = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpMain.SuspendLayout();
            this.grpAddOn.SuspendLayout();
            this.grpTahliaDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(426, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tahlia\'s";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpMain
            // 
            this.grpMain.BackColor = System.Drawing.Color.White;
            this.grpMain.Controls.Add(this.lblSaladPrice);
            this.grpMain.Controls.Add(this.lblPizzaPrice);
            this.grpMain.Controls.Add(this.lblHamburgerPrice);
            this.grpMain.Controls.Add(this.radSalad);
            this.grpMain.Controls.Add(this.radPizza);
            this.grpMain.Controls.Add(this.radHamburger);
            this.grpMain.Controls.Add(this.label2);
            this.grpMain.Controls.Add(this.label3);
            this.grpMain.Controls.Add(this.label4);
            this.grpMain.Font = new System.Drawing.Font("Harlow Solid Italic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.grpMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpMain.Location = new System.Drawing.Point(669, 113);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(346, 214);
            this.grpMain.TabIndex = 1;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Main Course";
            // 
            // lblSaladPrice
            // 
            this.lblSaladPrice.AutoSize = true;
            this.lblSaladPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaladPrice.Location = new System.Drawing.Point(248, 150);
            this.lblSaladPrice.Name = "lblSaladPrice";
            this.lblSaladPrice.Size = new System.Drawing.Size(64, 23);
            this.lblSaladPrice.TabIndex = 5;
            this.lblSaladPrice.Text = "$4.95";
            // 
            // lblPizzaPrice
            // 
            this.lblPizzaPrice.AutoSize = true;
            this.lblPizzaPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPizzaPrice.Location = new System.Drawing.Point(248, 99);
            this.lblPizzaPrice.Name = "lblPizzaPrice";
            this.lblPizzaPrice.Size = new System.Drawing.Size(64, 23);
            this.lblPizzaPrice.TabIndex = 4;
            this.lblPizzaPrice.Text = "$5.95";
            // 
            // lblHamburgerPrice
            // 
            this.lblHamburgerPrice.AutoSize = true;
            this.lblHamburgerPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHamburgerPrice.Location = new System.Drawing.Point(248, 52);
            this.lblHamburgerPrice.Name = "lblHamburgerPrice";
            this.lblHamburgerPrice.Size = new System.Drawing.Size(64, 23);
            this.lblHamburgerPrice.TabIndex = 3;
            this.lblHamburgerPrice.Text = "$6.95";
            // 
            // radSalad
            // 
            this.radSalad.AutoSize = true;
            this.radSalad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radSalad.Location = new System.Drawing.Point(38, 148);
            this.radSalad.Name = "radSalad";
            this.radSalad.Size = new System.Drawing.Size(86, 27);
            this.radSalad.TabIndex = 2;
            this.radSalad.TabStop = true;
            this.radSalad.Text = "Salad";
            this.radSalad.UseVisualStyleBackColor = true;
            this.radSalad.CheckedChanged += new System.EventHandler(this.radSalad_CheckedChanged);
            // 
            // radPizza
            // 
            this.radPizza.AutoSize = true;
            this.radPizza.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radPizza.Location = new System.Drawing.Point(38, 97);
            this.radPizza.Name = "radPizza";
            this.radPizza.Size = new System.Drawing.Size(81, 27);
            this.radPizza.TabIndex = 1;
            this.radPizza.TabStop = true;
            this.radPizza.Text = "Pizza";
            this.radPizza.UseVisualStyleBackColor = true;
            this.radPizza.CheckedChanged += new System.EventHandler(this.radPizza_CheckedChanged);
            // 
            // radHamburger
            // 
            this.radHamburger.AutoSize = true;
            this.radHamburger.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radHamburger.Location = new System.Drawing.Point(38, 50);
            this.radHamburger.Name = "radHamburger";
            this.radHamburger.Size = new System.Drawing.Size(144, 27);
            this.radHamburger.TabIndex = 0;
            this.radHamburger.TabStop = true;
            this.radHamburger.Text = "Hamburger";
            this.radHamburger.UseVisualStyleBackColor = true;
            this.radHamburger.CheckedChanged += new System.EventHandler(this.radHamburger_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(136, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = ". . . . . . . . . . . . .";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(87, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = ". . . . . . . . . . . . . . . . . . ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(98, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = ". . . . . . . . . . . . . . . . . . ";
            // 
            // grpAddOn
            // 
            this.grpAddOn.BackColor = System.Drawing.Color.White;
            this.grpAddOn.Controls.Add(this.lblAddOnDesc);
            this.grpAddOn.Controls.Add(this.chkAddOn3);
            this.grpAddOn.Controls.Add(this.chkAddOn2);
            this.grpAddOn.Controls.Add(this.chkAddOn1);
            this.grpAddOn.Font = new System.Drawing.Font("Harlow Solid Italic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.grpAddOn.Location = new System.Drawing.Point(51, 343);
            this.grpAddOn.Name = "grpAddOn";
            this.grpAddOn.Size = new System.Drawing.Size(426, 257);
            this.grpAddOn.TabIndex = 2;
            this.grpAddOn.TabStop = false;
            this.grpAddOn.Text = "Add-on Items";
            // 
            // lblAddOnDesc
            // 
            this.lblAddOnDesc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddOnDesc.Location = new System.Drawing.Point(36, 49);
            this.lblAddOnDesc.Name = "lblAddOnDesc";
            this.lblAddOnDesc.Size = new System.Drawing.Size(336, 59);
            this.lblAddOnDesc.TabIndex = 3;
            this.lblAddOnDesc.Text = "Fill your burger with these add-ons for only $0.75 each.";
            // 
            // chkAddOn3
            // 
            this.chkAddOn3.AutoSize = true;
            this.chkAddOn3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkAddOn3.Location = new System.Drawing.Point(62, 197);
            this.chkAddOn3.Name = "chkAddOn3";
            this.chkAddOn3.Size = new System.Drawing.Size(155, 27);
            this.chkAddOn3.TabIndex = 2;
            this.chkAddOn3.Text = "French Fries";
            this.chkAddOn3.UseVisualStyleBackColor = true;
            // 
            // chkAddOn2
            // 
            this.chkAddOn2.AutoSize = true;
            this.chkAddOn2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkAddOn2.Location = new System.Drawing.Point(62, 159);
            this.chkAddOn2.Name = "chkAddOn2";
            this.chkAddOn2.Size = new System.Drawing.Size(270, 27);
            this.chkAddOn2.TabIndex = 1;
            this.chkAddOn2.Text = "Ketchup, Mustard, Mayo";
            this.chkAddOn2.UseVisualStyleBackColor = true;
            // 
            // chkAddOn1
            // 
            this.chkAddOn1.AutoSize = true;
            this.chkAddOn1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkAddOn1.Location = new System.Drawing.Point(62, 121);
            this.chkAddOn1.Name = "chkAddOn1";
            this.chkAddOn1.Size = new System.Drawing.Size(259, 27);
            this.chkAddOn1.TabIndex = 0;
            this.chkAddOn1.Text = "Lettuce, Tomato, Onion";
            this.chkAddOn1.UseVisualStyleBackColor = true;
            // 
            // grpTahliaDesc
            // 
            this.grpTahliaDesc.BackColor = System.Drawing.Color.White;
            this.grpTahliaDesc.Controls.Add(this.pictureBox1);
            this.grpTahliaDesc.Controls.Add(this.lblTahliaDesc);
            this.grpTahliaDesc.Font = new System.Drawing.Font("Harlow Solid Italic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.grpTahliaDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpTahliaDesc.Location = new System.Drawing.Point(51, 113);
            this.grpTahliaDesc.Name = "grpTahliaDesc";
            this.grpTahliaDesc.Size = new System.Drawing.Size(586, 214);
            this.grpTahliaDesc.TabIndex = 8;
            this.grpTahliaDesc.TabStop = false;
            this.grpTahliaDesc.Text = "Welcome to Tahlia\'s";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 60);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTahliaDesc
            // 
            this.lblTahliaDesc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTahliaDesc.Location = new System.Drawing.Point(48, 34);
            this.lblTahliaDesc.Name = "lblTahliaDesc";
            this.lblTahliaDesc.Size = new System.Drawing.Size(504, 88);
            this.lblTahliaDesc.TabIndex = 0;
            this.lblTahliaDesc.Text = "Thank you for choosing Tahlia\'s diner! Choose one main course, some add-ons, and " +
    "place your order!";
            this.lblTahliaDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTotal
            // 
            this.grpTotal.BackColor = System.Drawing.Color.White;
            this.grpTotal.Controls.Add(this.txtTotal);
            this.grpTotal.Controls.Add(this.lblTotal);
            this.grpTotal.Controls.Add(this.txtTax);
            this.grpTotal.Controls.Add(this.lblTax);
            this.grpTotal.Controls.Add(this.txtSubTotal);
            this.grpTotal.Controls.Add(this.lblSubTotal);
            this.grpTotal.Font = new System.Drawing.Font("Harlow Solid Italic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.grpTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpTotal.Location = new System.Drawing.Point(510, 343);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Size = new System.Drawing.Size(266, 257);
            this.grpTotal.TabIndex = 8;
            this.grpTotal.TabStop = false;
            this.grpTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(134, 159);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(116, 31);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(25, 162);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 23);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // txtTax
            // 
            this.txtTax.Enabled = false;
            this.txtTax.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTax.Location = new System.Drawing.Point(134, 106);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(116, 31);
            this.txtTax.TabIndex = 3;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTax.Location = new System.Drawing.Point(25, 109);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(93, 23);
            this.lblTax.TabIndex = 2;
            this.lblTax.Text = "Tax (5%)";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubTotal.Location = new System.Drawing.Point(134, 56);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(116, 31);
            this.txtSubTotal.TabIndex = 1;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotal.Location = new System.Drawing.Point(25, 59);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(102, 23);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlaceOrder.Location = new System.Drawing.Point(821, 378);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(160, 52);
            this.btnPlaceOrder.TabIndex = 9;
            this.btnPlaceOrder.Text = "&Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(821, 449);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(160, 52);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(821, 526);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 52);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmOrder
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(1067, 631);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.grpTotal);
            this.Controls.Add(this.grpTahliaDesc);
            this.Controls.Add(this.grpAddOn);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tahlia\'s Lunch Order";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.grpAddOn.ResumeLayout(false);
            this.grpAddOn.PerformLayout();
            this.grpTahliaDesc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpTotal.ResumeLayout(false);
            this.grpTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Label lblSaladPrice;
        private System.Windows.Forms.Label lblPizzaPrice;
        private System.Windows.Forms.Label lblHamburgerPrice;
        private System.Windows.Forms.RadioButton radSalad;
        private System.Windows.Forms.RadioButton radPizza;
        private System.Windows.Forms.RadioButton radHamburger;
        private System.Windows.Forms.GroupBox grpAddOn;
        private System.Windows.Forms.CheckBox chkAddOn3;
        private System.Windows.Forms.CheckBox chkAddOn2;
        private System.Windows.Forms.CheckBox chkAddOn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAddOnDesc;
        private System.Windows.Forms.GroupBox grpTahliaDesc;
        private System.Windows.Forms.Label lblTahliaDesc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpTotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Button btnExit;
    }
}

