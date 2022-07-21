namespace NameList
{
    partial class Form1
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
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxNames = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnToevoegen.Location = new System.Drawing.Point(40, 243);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(498, 32);
            this.btnToevoegen.TabIndex = 2;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstname.Location = new System.Drawing.Point(46, 53);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(498, 31);
            this.txtFirstname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voornaam";
            // 
            // lbxNames
            // 
            this.lbxNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxNames.FormattingEnabled = true;
            this.lbxNames.ItemHeight = 25;
            this.lbxNames.Location = new System.Drawing.Point(48, 335);
            this.lbxNames.Name = "lbxNames";
            this.lbxNames.Size = new System.Drawing.Size(492, 329);
            this.lbxNames.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Utrecht",
            "Amsterdam",
            "Maastricht",
            "Antwerpen",
            "Ridderkerk",
            "Bilzen"});
            this.comboBox1.Location = new System.Drawing.Point(46, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(492, 38);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stad";
            // 
            // lblCounter
            // 
            this.lblCounter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCounter.Location = new System.Drawing.Point(48, 293);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(71, 30);
            this.lblCounter.TabIndex = 6;
            this.lblCounter.Text = "label3";
            this.lblCounter.Click += new System.EventHandler(this.lblCounter_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerwijder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerwijder.Location = new System.Drawing.Point(40, 686);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(498, 32);
            this.btnVerwijder.TabIndex = 3;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 745);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbxNames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.btnToevoegen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnToevoegen;
        private TextBox txtFirstname;
        private Label label1;
        private ListBox lbxNames;
        private ComboBox comboBox1;
        private Label label2;
        private Label lblCounter;
        private Button btnVerwijder;
    }
}