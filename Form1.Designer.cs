namespace BitcoinCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyselector = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bitcoinamountinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultlable = new System.Windows.Forms.TextBox();
            this.tulemuslable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyselector
            // 
            this.currencyselector.FormattingEnabled = true;
            this.currencyselector.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "EEK",
            "GBP"});
            this.currencyselector.Location = new System.Drawing.Point(32, 119);
            this.currencyselector.Name = "currencyselector";
            this.currencyselector.Size = new System.Drawing.Size(121, 21);
            this.currencyselector.TabIndex = 0;
            this.currencyselector.Text = "Vali valuuta";
            this.currencyselector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Arvuta kurss";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bitcoinamountinput
            // 
            this.bitcoinamountinput.Location = new System.Drawing.Point(32, 83);
            this.bitcoinamountinput.Name = "bitcoinamountinput";
            this.bitcoinamountinput.Size = new System.Drawing.Size(121, 20);
            this.bitcoinamountinput.TabIndex = 2;
            this.bitcoinamountinput.TextChanged += new System.EventHandler(this.bitcoinamountinput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sisesta Bitcoini arv";
            // 
            // resultlable
            // 
            this.resultlable.BackColor = System.Drawing.Color.White;
            this.resultlable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.resultlable.ForeColor = System.Drawing.Color.Lime;
            this.resultlable.Location = new System.Drawing.Point(35, 372);
            this.resultlable.Name = "resultlable";
            this.resultlable.Size = new System.Drawing.Size(651, 49);
            this.resultlable.TabIndex = 4;
            // 
            // tulemuslable
            // 
            this.tulemuslable.AutoSize = true;
            this.tulemuslable.BackColor = System.Drawing.Color.Transparent;
            this.tulemuslable.ForeColor = System.Drawing.Color.Lime;
            this.tulemuslable.Location = new System.Drawing.Point(32, 356);
            this.tulemuslable.Name = "tulemuslable";
            this.tulemuslable.Size = new System.Drawing.Size(50, 13);
            this.tulemuslable.TabIndex = 5;
            this.tulemuslable.Text = "Tulemus:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tulemuslable);
            this.Controls.Add(this.resultlable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitcoinamountinput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currencyselector);
            this.Name = "Form1";
            this.Text = "Bitcoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyselector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bitcoinamountinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultlable;
        private System.Windows.Forms.Label tulemuslable;
    }
}

