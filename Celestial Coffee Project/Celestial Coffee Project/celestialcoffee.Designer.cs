namespace Celestial_Coffee_Project
{
    partial class celestialcoffee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grpcoffee = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radDecafQuarter = new System.Windows.Forms.RadioButton();
            this.radDecafHalf = new System.Windows.Forms.RadioButton();
            this.radDecafPound = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRegQuarter = new System.Windows.Forms.RadioButton();
            this.radRegHalf = new System.Windows.Forms.RadioButton();
            this.radRegPound = new System.Windows.Forms.RadioButton();
            this.txtInfoName = new System.Windows.Forms.TextBox();
            this.txtInfoAddress = new System.Windows.Forms.TextBox();
            this.txtInfoCityStateZip = new System.Windows.Forms.TextBox();
            this.lblInfoName = new System.Windows.Forms.Label();
            this.lblInfoAddress = new System.Windows.Forms.Label();
            this.lblCityStateZip = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.grpcoffee.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celestial Coffee Shop Orders";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpcoffee
            // 
            this.grpcoffee.BackColor = System.Drawing.Color.Plum;
            this.grpcoffee.Controls.Add(this.radDecafPound);
            this.grpcoffee.Controls.Add(this.radDecafHalf);
            this.grpcoffee.Controls.Add(this.radDecafQuarter);
            this.grpcoffee.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpcoffee.Location = new System.Drawing.Point(26, 149);
            this.grpcoffee.Name = "grpcoffee";
            this.grpcoffee.Size = new System.Drawing.Size(480, 183);
            this.grpcoffee.TabIndex = 1;
            this.grpcoffee.TabStop = false;
            this.grpcoffee.Text = "Decaf Coffee";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Plum;
            this.groupBox2.Controls.Add(this.radRegPound);
            this.groupBox2.Controls.Add(this.radRegHalf);
            this.groupBox2.Controls.Add(this.radRegQuarter);
            this.groupBox2.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 203);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Regular Coffee";
            // 
            // radDecafQuarter
            // 
            this.radDecafQuarter.AutoSize = true;
            this.radDecafQuarter.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDecafQuarter.Location = new System.Drawing.Point(6, 49);
            this.radDecafQuarter.Name = "radDecafQuarter";
            this.radDecafQuarter.Size = new System.Drawing.Size(272, 37);
            this.radDecafQuarter.TabIndex = 0;
            this.radDecafQuarter.TabStop = true;
            this.radDecafQuarter.Text = "1/4 pound $3.25";
            this.radDecafQuarter.UseVisualStyleBackColor = true;
            // 
            // radDecafHalf
            // 
            this.radDecafHalf.AutoSize = true;
            this.radDecafHalf.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDecafHalf.Location = new System.Drawing.Point(6, 92);
            this.radDecafHalf.Name = "radDecafHalf";
            this.radDecafHalf.Size = new System.Drawing.Size(272, 37);
            this.radDecafHalf.TabIndex = 1;
            this.radDecafHalf.TabStop = true;
            this.radDecafHalf.Text = "1/2 pound $7.02";
            this.radDecafHalf.UseVisualStyleBackColor = true;
            // 
            // radDecafPound
            // 
            this.radDecafPound.AutoSize = true;
            this.radDecafPound.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDecafPound.Location = new System.Drawing.Point(6, 138);
            this.radDecafPound.Name = "radDecafPound";
            this.radDecafPound.Size = new System.Drawing.Size(257, 37);
            this.radDecafPound.TabIndex = 2;
            this.radDecafPound.TabStop = true;
            this.radDecafPound.Text = "1 pound $13.52";
            this.radDecafPound.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Plum;
            this.groupBox1.Controls.Add(this.lblCityStateZip);
            this.groupBox1.Controls.Add(this.lblInfoAddress);
            this.groupBox1.Controls.Add(this.lblInfoName);
            this.groupBox1.Controls.Add(this.txtInfoCityStateZip);
            this.groupBox1.Controls.Add(this.txtInfoAddress);
            this.groupBox1.Controls.Add(this.txtInfoName);
            this.groupBox1.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(548, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 376);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // radRegQuarter
            // 
            this.radRegQuarter.AutoSize = true;
            this.radRegQuarter.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRegQuarter.Location = new System.Drawing.Point(6, 42);
            this.radRegQuarter.Name = "radRegQuarter";
            this.radRegQuarter.Size = new System.Drawing.Size(272, 37);
            this.radRegQuarter.TabIndex = 1;
            this.radRegQuarter.TabStop = true;
            this.radRegQuarter.Text = "1/4 pound $3.25";
            this.radRegQuarter.UseVisualStyleBackColor = true;
            // 
            // radRegHalf
            // 
            this.radRegHalf.AutoSize = true;
            this.radRegHalf.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRegHalf.Location = new System.Drawing.Point(6, 88);
            this.radRegHalf.Name = "radRegHalf";
            this.radRegHalf.Size = new System.Drawing.Size(272, 37);
            this.radRegHalf.TabIndex = 2;
            this.radRegHalf.TabStop = true;
            this.radRegHalf.Text = "1/2 pound $7.02";
            this.radRegHalf.UseVisualStyleBackColor = true;
            // 
            // radRegPound
            // 
            this.radRegPound.AutoSize = true;
            this.radRegPound.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRegPound.Location = new System.Drawing.Point(6, 137);
            this.radRegPound.Name = "radRegPound";
            this.radRegPound.Size = new System.Drawing.Size(256, 37);
            this.radRegPound.TabIndex = 3;
            this.radRegPound.TabStop = true;
            this.radRegPound.Text = "1 Pound $13.52";
            this.radRegPound.UseVisualStyleBackColor = true;
            // 
            // txtInfoName
            // 
            this.txtInfoName.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoName.Location = new System.Drawing.Point(12, 92);
            this.txtInfoName.MaxLength = 32;
            this.txtInfoName.Name = "txtInfoName";
            this.txtInfoName.Size = new System.Drawing.Size(416, 39);
            this.txtInfoName.TabIndex = 0;
            // 
            // txtInfoAddress
            // 
            this.txtInfoAddress.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoAddress.Location = new System.Drawing.Point(18, 191);
            this.txtInfoAddress.Name = "txtInfoAddress";
            this.txtInfoAddress.Size = new System.Drawing.Size(410, 39);
            this.txtInfoAddress.TabIndex = 1;
            // 
            // txtInfoCityStateZip
            // 
            this.txtInfoCityStateZip.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoCityStateZip.Location = new System.Drawing.Point(18, 299);
            this.txtInfoCityStateZip.Name = "txtInfoCityStateZip";
            this.txtInfoCityStateZip.Size = new System.Drawing.Size(410, 39);
            this.txtInfoCityStateZip.TabIndex = 2;
            // 
            // lblInfoName
            // 
            this.lblInfoName.AutoSize = true;
            this.lblInfoName.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoName.Location = new System.Drawing.Point(6, 61);
            this.lblInfoName.Name = "lblInfoName";
            this.lblInfoName.Size = new System.Drawing.Size(214, 28);
            this.lblInfoName.TabIndex = 4;
            this.lblInfoName.Text = "Name (Last, First)";
            // 
            // lblInfoAddress
            // 
            this.lblInfoAddress.AutoSize = true;
            this.lblInfoAddress.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoAddress.Location = new System.Drawing.Point(5, 155);
            this.lblInfoAddress.Name = "lblInfoAddress";
            this.lblInfoAddress.Size = new System.Drawing.Size(128, 33);
            this.lblInfoAddress.TabIndex = 5;
            this.lblInfoAddress.Text = "Address";
            // 
            // lblCityStateZip
            // 
            this.lblCityStateZip.AutoSize = true;
            this.lblCityStateZip.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityStateZip.Location = new System.Drawing.Point(6, 263);
            this.lblCityStateZip.Name = "lblCityStateZip";
            this.lblCityStateZip.Size = new System.Drawing.Size(298, 33);
            this.lblCityStateZip.TabIndex = 6;
            this.lblCityStateZip.Text = "City, State, Zip Code";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.Salmon;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(1187, 287);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(227, 124);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Text = "Place Order Here!";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            // 
            // celestialcoffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 605);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpcoffee);
            this.Controls.Add(this.label1);
            this.Name = "celestialcoffee";
            this.Text = "Form1";
            this.grpcoffee.ResumeLayout(false);
            this.grpcoffee.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpcoffee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radDecafPound;
        private System.Windows.Forms.RadioButton radDecafHalf;
        private System.Windows.Forms.RadioButton radDecafQuarter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radRegPound;
        private System.Windows.Forms.RadioButton radRegHalf;
        private System.Windows.Forms.RadioButton radRegQuarter;
        private System.Windows.Forms.Label lblCityStateZip;
        private System.Windows.Forms.Label lblInfoAddress;
        private System.Windows.Forms.Label lblInfoName;
        private System.Windows.Forms.TextBox txtInfoCityStateZip;
        private System.Windows.Forms.TextBox txtInfoAddress;
        private System.Windows.Forms.TextBox txtInfoName;
        private System.Windows.Forms.Button btnPlaceOrder;
    }
}

