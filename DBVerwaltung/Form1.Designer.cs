namespace DBVerwaltung
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
            this.BtnAlleSehen = new System.Windows.Forms.Button();
            this.BtnEinfuegen = new System.Windows.Forms.Button();
            this.Btnaendern = new System.Windows.Forms.Button();
            this.BtnLoeschen = new System.Windows.Forms.Button();
            this.BtnNameSuchen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtVorname = new System.Windows.Forms.TextBox();
            this.TxtPersonalnummer = new System.Windows.Forms.TextBox();
            this.TxtGehalt = new System.Windows.Forms.TextBox();
            this.TxtGeburtstag = new System.Windows.Forms.TextBox();
            this.LstDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnAlleSehen
            // 
            this.BtnAlleSehen.Location = new System.Drawing.Point(12, 12);
            this.BtnAlleSehen.Name = "BtnAlleSehen";
            this.BtnAlleSehen.Size = new System.Drawing.Size(188, 58);
            this.BtnAlleSehen.TabIndex = 0;
            this.BtnAlleSehen.Text = "Alle sehen";
            this.BtnAlleSehen.UseVisualStyleBackColor = true;
            this.BtnAlleSehen.Click += new System.EventHandler(this.BtnAlleSehen_Click);
            // 
            // BtnEinfuegen
            // 
            this.BtnEinfuegen.Location = new System.Drawing.Point(12, 76);
            this.BtnEinfuegen.Name = "BtnEinfuegen";
            this.BtnEinfuegen.Size = new System.Drawing.Size(188, 58);
            this.BtnEinfuegen.TabIndex = 0;
            this.BtnEinfuegen.Text = "Einfügen";
            this.BtnEinfuegen.UseVisualStyleBackColor = true;
            this.BtnEinfuegen.Click += new System.EventHandler(this.BtnEinfuegen_Click);
            // 
            // Btnaendern
            // 
            this.Btnaendern.Location = new System.Drawing.Point(12, 140);
            this.Btnaendern.Name = "Btnaendern";
            this.Btnaendern.Size = new System.Drawing.Size(188, 58);
            this.Btnaendern.TabIndex = 0;
            this.Btnaendern.Text = "Ändern";
            this.Btnaendern.UseVisualStyleBackColor = true;
            this.Btnaendern.Click += new System.EventHandler(this.Btnaendern_Click);
            // 
            // BtnLoeschen
            // 
            this.BtnLoeschen.Location = new System.Drawing.Point(12, 204);
            this.BtnLoeschen.Name = "BtnLoeschen";
            this.BtnLoeschen.Size = new System.Drawing.Size(188, 58);
            this.BtnLoeschen.TabIndex = 0;
            this.BtnLoeschen.Text = "Löschen";
            this.BtnLoeschen.UseVisualStyleBackColor = true;
            this.BtnLoeschen.Click += new System.EventHandler(this.BtnLoeschen_Click);
            // 
            // BtnNameSuchen
            // 
            this.BtnNameSuchen.Location = new System.Drawing.Point(630, 15);
            this.BtnNameSuchen.Name = "BtnNameSuchen";
            this.BtnNameSuchen.Size = new System.Drawing.Size(250, 58);
            this.BtnNameSuchen.TabIndex = 0;
            this.BtnNameSuchen.Text = "Name suchen";
            this.BtnNameSuchen.UseVisualStyleBackColor = true;
            this.BtnNameSuchen.Click += new System.EventHandler(this.BtnNameSuchen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vorname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "Personalnummer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gehalt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 41);
            this.label5.TabIndex = 1;
            this.label5.Text = "Geburtstag:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(630, 79);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(250, 47);
            this.TxtName.TabIndex = 2;
            // 
            // TxtVorname
            // 
            this.TxtVorname.Location = new System.Drawing.Point(630, 137);
            this.TxtVorname.Name = "TxtVorname";
            this.TxtVorname.Size = new System.Drawing.Size(250, 47);
            this.TxtVorname.TabIndex = 2;
            // 
            // TxtPersonalnummer
            // 
            this.TxtPersonalnummer.Location = new System.Drawing.Point(630, 195);
            this.TxtPersonalnummer.Name = "TxtPersonalnummer";
            this.TxtPersonalnummer.Size = new System.Drawing.Size(250, 47);
            this.TxtPersonalnummer.TabIndex = 2;
            // 
            // TxtGehalt
            // 
            this.TxtGehalt.Location = new System.Drawing.Point(630, 255);
            this.TxtGehalt.Name = "TxtGehalt";
            this.TxtGehalt.Size = new System.Drawing.Size(250, 47);
            this.TxtGehalt.TabIndex = 2;
            // 
            // TxtGeburtstag
            // 
            this.TxtGeburtstag.Location = new System.Drawing.Point(630, 317);
            this.TxtGeburtstag.Name = "TxtGeburtstag";
            this.TxtGeburtstag.Size = new System.Drawing.Size(250, 47);
            this.TxtGeburtstag.TabIndex = 2;
            // 
            // LstDisplay
            // 
            this.LstDisplay.FormattingEnabled = true;
            this.LstDisplay.ItemHeight = 41;
            this.LstDisplay.Location = new System.Drawing.Point(12, 410);
            this.LstDisplay.Name = "LstDisplay";
            this.LstDisplay.Size = new System.Drawing.Size(868, 209);
            this.LstDisplay.TabIndex = 4;
            this.LstDisplay.SelectedIndexChanged += new System.EventHandler(this.LstDisplay_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 634);
            this.Controls.Add(this.LstDisplay);
            this.Controls.Add(this.TxtGeburtstag);
            this.Controls.Add(this.TxtGehalt);
            this.Controls.Add(this.TxtPersonalnummer);
            this.Controls.Add(this.TxtVorname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNameSuchen);
            this.Controls.Add(this.BtnLoeschen);
            this.Controls.Add(this.Btnaendern);
            this.Controls.Add(this.BtnEinfuegen);
            this.Controls.Add(this.BtnAlleSehen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnAlleSehen;
        private Button BtnEinfuegen;
        private Button Btnaendern;
        private Button BtnLoeschen;
        private Button BtnNameSuchen;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtName;
        private TextBox TxtVorname;
        private TextBox TxtPersonalnummer;
        private TextBox TxtGehalt;
        private TextBox TxtGeburtstag;
        private ListBox LstDisplay;
    }
}