
namespace MegaDesk
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.numDeskWidth = new System.Windows.Forms.NumericUpDown();
            this.numDeskDepth = new System.Windows.Forms.NumericUpDown();
            this.numNumberOfDrawers = new System.Windows.Forms.NumericUpDown();
            this.listRushOrderOption = new System.Windows.Forms.ComboBox();
            this.listDesktopMaterial = new System.Windows.Forms.ComboBox();
            this.grpDeskDetails = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCustomerName = new System.Windows.Forms.TextBox();
            this.grpOrderDetails = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDeskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeskDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfDrawers)).BeginInit();
            this.grpDeskDetails.SuspendLayout();
            this.grpOrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // numDeskWidth
            // 
            this.numDeskWidth.Location = new System.Drawing.Point(139, 28);
            this.numDeskWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numDeskWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numDeskWidth.Name = "numDeskWidth";
            this.numDeskWidth.Size = new System.Drawing.Size(120, 20);
            this.numDeskWidth.TabIndex = 3;
            this.numDeskWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // numDeskDepth
            // 
            this.numDeskDepth.Location = new System.Drawing.Point(139, 58);
            this.numDeskDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numDeskDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numDeskDepth.Name = "numDeskDepth";
            this.numDeskDepth.Size = new System.Drawing.Size(120, 20);
            this.numDeskDepth.TabIndex = 4;
            this.numDeskDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numNumberOfDrawers
            // 
            this.numNumberOfDrawers.Location = new System.Drawing.Point(139, 88);
            this.numNumberOfDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numNumberOfDrawers.Name = "numNumberOfDrawers";
            this.numNumberOfDrawers.Size = new System.Drawing.Size(120, 20);
            this.numNumberOfDrawers.TabIndex = 5;
            // 
            // listRushOrderOption
            // 
            this.listRushOrderOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listRushOrderOption.FormattingEnabled = true;
            this.listRushOrderOption.Items.AddRange(new object[] {
            "14 day",
            "7 day",
            "5 day",
            "3 day"});
            this.listRushOrderOption.Location = new System.Drawing.Point(36, 98);
            this.listRushOrderOption.Name = "listRushOrderOption";
            this.listRushOrderOption.Size = new System.Drawing.Size(121, 21);
            this.listRushOrderOption.TabIndex = 2;
            // 
            // listDesktopMaterial
            // 
            this.listDesktopMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listDesktopMaterial.FormattingEnabled = true;
            this.listDesktopMaterial.Location = new System.Drawing.Point(138, 118);
            this.listDesktopMaterial.Name = "listDesktopMaterial";
            this.listDesktopMaterial.Size = new System.Drawing.Size(121, 21);
            this.listDesktopMaterial.TabIndex = 6;
            // 
            // grpDeskDetails
            // 
            this.grpDeskDetails.Controls.Add(this.label4);
            this.grpDeskDetails.Controls.Add(this.label3);
            this.grpDeskDetails.Controls.Add(this.label2);
            this.grpDeskDetails.Controls.Add(this.label1);
            this.grpDeskDetails.Controls.Add(this.numDeskWidth);
            this.grpDeskDetails.Controls.Add(this.listDesktopMaterial);
            this.grpDeskDetails.Controls.Add(this.numDeskDepth);
            this.grpDeskDetails.Controls.Add(this.numNumberOfDrawers);
            this.grpDeskDetails.Location = new System.Drawing.Point(318, 76);
            this.grpDeskDetails.Name = "grpDeskDetails";
            this.grpDeskDetails.Size = new System.Drawing.Size(270, 156);
            this.grpDeskDetails.TabIndex = 5;
            this.grpDeskDetails.TabStop = false;
            this.grpDeskDetails.Text = "Desk Details";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Desktop Material:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of Drawers:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Depth:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(36, 45);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Size = new System.Drawing.Size(217, 20);
            this.textCustomerName.TabIndex = 1;
            // 
            // grpOrderDetails
            // 
            this.grpOrderDetails.Controls.Add(this.label6);
            this.grpOrderDetails.Controls.Add(this.label5);
            this.grpOrderDetails.Controls.Add(this.textCustomerName);
            this.grpOrderDetails.Controls.Add(this.listRushOrderOption);
            this.grpOrderDetails.Location = new System.Drawing.Point(20, 76);
            this.grpOrderDetails.Name = "grpOrderDetails";
            this.grpOrderDetails.Size = new System.Drawing.Size(270, 156);
            this.grpOrderDetails.TabIndex = 0;
            this.grpOrderDetails.TabStop = false;
            this.grpOrderDetails.Text = "Order Details";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rush Order Option";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Customer Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "New Quote";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(318, 292);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 30);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetQuote.Location = new System.Drawing.Point(150, 292);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(140, 30);
            this.btnGetQuote.TabIndex = 7;
            this.btnGetQuote.Text = "Add Quote";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            this.btnGetQuote.Click += new System.EventHandler(this.btnAddQuote_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(251, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Price:";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(295, 253);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(131, 23);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "$0.00";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 411);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGetQuote);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpOrderDetails);
            this.Controls.Add(this.grpDeskDetails);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(616, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(616, 450);
            this.Name = "AddQuote";
            this.Text = "Mega Desk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDeskWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeskDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfDrawers)).EndInit();
            this.grpDeskDetails.ResumeLayout(false);
            this.grpOrderDetails.ResumeLayout(false);
            this.grpOrderDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numDeskWidth;
        private System.Windows.Forms.NumericUpDown numDeskDepth;
        private System.Windows.Forms.NumericUpDown numNumberOfDrawers;
        private System.Windows.Forms.ComboBox listRushOrderOption;
        private System.Windows.Forms.ComboBox listDesktopMaterial;
        private System.Windows.Forms.GroupBox grpDeskDetails;
        private System.Windows.Forms.TextBox textCustomerName;
        private System.Windows.Forms.GroupBox grpOrderDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPrice;
    }
}