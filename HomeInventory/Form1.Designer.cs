
namespace HomeInventory
{
    partial class frmInventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPurchaseCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.chkEngraved = new System.Windows.Forms.CheckBox();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.lblPhotoFile = new System.Windows.Forms.Label();
            this.btnLoadPhoto = new System.Windows.Forms.Button();
            this.dtpDatePurchased = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.Color.White;
            this.txtItem.Location = new System.Drawing.Point(110, 12);
            this.txtItem.MaxLength = 50;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(369, 23);
            this.txtItem.TabIndex = 1;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.White;
            this.txtLocation.Location = new System.Drawing.Point(110, 41);
            this.txtLocation.MaxLength = 50;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(369, 23);
            this.txtLocation.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Store:";
            // 
            // txtStore
            // 
            this.txtStore.BackColor = System.Drawing.Color.White;
            this.txtStore.Location = new System.Drawing.Point(110, 70);
            this.txtStore.MaxLength = 50;
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(369, 23);
            this.txtStore.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date Purchased:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Purchase Cost:";
            // 
            // txtPurchaseCost
            // 
            this.txtPurchaseCost.BackColor = System.Drawing.Color.White;
            this.txtPurchaseCost.Location = new System.Drawing.Point(379, 99);
            this.txtPurchaseCost.MaxLength = 50;
            this.txtPurchaseCost.Name = "txtPurchaseCost";
            this.txtPurchaseCost.Size = new System.Drawing.Size(100, 23);
            this.txtPurchaseCost.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Serial Number:";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.BackColor = System.Drawing.Color.White;
            this.txtSerialNumber.Location = new System.Drawing.Point(110, 128);
            this.txtSerialNumber.MaxLength = 50;
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(369, 23);
            this.txtSerialNumber.TabIndex = 11;
            // 
            // chkEngraved
            // 
            this.chkEngraved.AutoSize = true;
            this.chkEngraved.Location = new System.Drawing.Point(12, 157);
            this.chkEngraved.Name = "chkEngraved";
            this.chkEngraved.Size = new System.Drawing.Size(75, 19);
            this.chkEngraved.TabIndex = 12;
            this.chkEngraved.Text = "Engraved";
            this.chkEngraved.UseVisualStyleBackColor = true;
            this.chkEngraved.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // picItem
            // 
            this.picItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItem.Location = new System.Drawing.Point(258, 157);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(221, 126);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItem.TabIndex = 13;
            this.picItem.TabStop = false;
            // 
            // lblPhotoFile
            // 
            this.lblPhotoFile.BackColor = System.Drawing.Color.LightYellow;
            this.lblPhotoFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhotoFile.Location = new System.Drawing.Point(257, 286);
            this.lblPhotoFile.Name = "lblPhotoFile";
            this.lblPhotoFile.Size = new System.Drawing.Size(222, 44);
            this.lblPhotoFile.TabIndex = 14;
            this.lblPhotoFile.Text = "[Blank]";
            // 
            // btnLoadPhoto
            // 
            this.btnLoadPhoto.AutoSize = true;
            this.btnLoadPhoto.Location = new System.Drawing.Point(335, 333);
            this.btnLoadPhoto.Name = "btnLoadPhoto";
            this.btnLoadPhoto.Size = new System.Drawing.Size(78, 25);
            this.btnLoadPhoto.TabIndex = 15;
            this.btnLoadPhoto.Text = "Load Photo";
            this.btnLoadPhoto.UseVisualStyleBackColor = true;
            // 
            // dtpDatePurchased
            // 
            this.dtpDatePurchased.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePurchased.Location = new System.Drawing.Point(110, 99);
            this.dtpDatePurchased.Name = "dtpDatePurchased";
            this.dtpDatePurchased.Size = new System.Drawing.Size(149, 23);
            this.dtpDatePurchased.TabIndex = 7;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 368);
            this.Controls.Add(this.dtpDatePurchased);
            this.Controls.Add(this.btnLoadPhoto);
            this.Controls.Add(this.lblPhotoFile);
            this.Controls.Add(this.picItem);
            this.Controls.Add(this.chkEngraved);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPurchaseCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInventory_FormClosing);
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPurchaseCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.CheckBox chkEngraved;
        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.Label lblPhotoFile;
        private System.Windows.Forms.Button btnLoadPhoto;
        private System.Windows.Forms.DateTimePicker dtpDatePurchased;
    }
}

