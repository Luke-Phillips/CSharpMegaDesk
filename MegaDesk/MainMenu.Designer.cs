
namespace MegaDesk
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.picDesk = new System.Windows.Forms.PictureBox();
            this.btnAddQuote = new System.Windows.Forms.Button();
            this.btnViewQuotes = new System.Windows.Forms.Button();
            this.btnSearchQuotes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDesk)).BeginInit();
            this.SuspendLayout();
            // 
            // picDesk
            // 
            this.picDesk.Image = ((System.Drawing.Image)(resources.GetObject("picDesk.Image")));
            this.picDesk.Location = new System.Drawing.Point(0, 0);
            this.picDesk.Name = "picDesk";
            this.picDesk.Size = new System.Drawing.Size(600, 412);
            this.picDesk.TabIndex = 0;
            this.picDesk.TabStop = false;
            // 
            // btnAddQuote
            // 
            this.btnAddQuote.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddQuote.FlatAppearance.BorderSize = 0;
            this.btnAddQuote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnAddQuote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnAddQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuote.Location = new System.Drawing.Point(348, 25);
            this.btnAddQuote.Name = "btnAddQuote";
            this.btnAddQuote.Size = new System.Drawing.Size(223, 60);
            this.btnAddQuote.TabIndex = 1;
            this.btnAddQuote.Text = "Add New Quote";
            this.btnAddQuote.UseVisualStyleBackColor = false;
            this.btnAddQuote.Click += new System.EventHandler(this.btnAddNewQuote_Click);
            // 
            // btnViewQuotes
            // 
            this.btnViewQuotes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnViewQuotes.FlatAppearance.BorderSize = 0;
            this.btnViewQuotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnViewQuotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnViewQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewQuotes.Location = new System.Drawing.Point(348, 115);
            this.btnViewQuotes.Name = "btnViewQuotes";
            this.btnViewQuotes.Size = new System.Drawing.Size(223, 60);
            this.btnViewQuotes.TabIndex = 2;
            this.btnViewQuotes.Text = "View Quotes";
            this.btnViewQuotes.UseVisualStyleBackColor = false;
            this.btnViewQuotes.Click += new System.EventHandler(this.btnViewQuotes_Click);
            // 
            // btnSearchQuotes
            // 
            this.btnSearchQuotes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearchQuotes.FlatAppearance.BorderSize = 0;
            this.btnSearchQuotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnSearchQuotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnSearchQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchQuotes.Location = new System.Drawing.Point(348, 205);
            this.btnSearchQuotes.Name = "btnSearchQuotes";
            this.btnSearchQuotes.Size = new System.Drawing.Size(223, 60);
            this.btnSearchQuotes.TabIndex = 3;
            this.btnSearchQuotes.Text = "Search Quotes";
            this.btnSearchQuotes.UseVisualStyleBackColor = false;
            this.btnSearchQuotes.Click += new System.EventHandler(this.btnSearchQuotes_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(348, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(223, 60);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 411);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearchQuotes);
            this.Controls.Add(this.btnViewQuotes);
            this.Controls.Add(this.btnAddQuote);
            this.Controls.Add(this.picDesk);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(616, 450);
            this.MinimumSize = new System.Drawing.Size(616, 450);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picDesk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDesk;
        private System.Windows.Forms.Button btnAddQuote;
        private System.Windows.Forms.Button btnViewQuotes;
        private System.Windows.Forms.Button btnSearchQuotes;
        private System.Windows.Forms.Button btnExit;
    }
}

