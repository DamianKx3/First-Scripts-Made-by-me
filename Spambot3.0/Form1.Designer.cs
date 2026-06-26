
namespace spambot_3._0
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inputtester = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.displaynum = new System.Windows.Forms.Label();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.Debug = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.itemname = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputtester
            // 
            this.inputtester.Enabled = true;
            this.inputtester.Interval = 20;
            this.inputtester.Tick += new System.EventHandler(this.inputtest);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "przytrzymaj Escape aby przestać spamować";
            this.label1.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "rozpocznij";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.test1);
            // 
            // displaynum
            // 
            this.displaynum.AutoSize = true;
            this.displaynum.ForeColor = System.Drawing.Color.Lime;
            this.displaynum.Location = new System.Drawing.Point(14, 38);
            this.displaynum.Name = "displaynum";
            this.displaynum.Size = new System.Drawing.Size(0, 13);
            this.displaynum.TabIndex = 2;
            this.displaynum.UseWaitCursor = true;
            // 
            // inputbox
            // 
            this.inputbox.BackColor = System.Drawing.Color.Black;
            this.inputbox.ForeColor = System.Drawing.Color.Lime;
            this.inputbox.Location = new System.Drawing.Point(260, 9);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(125, 20);
            this.inputbox.TabIndex = 3;
            this.inputbox.UseWaitCursor = true;
            // 
            // Debug
            // 
            this.Debug.AutoSize = true;
            this.Debug.BackColor = System.Drawing.Color.Transparent;
            this.Debug.ForeColor = System.Drawing.Color.Red;
            this.Debug.Location = new System.Drawing.Point(14, 123);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(270, 13);
            this.Debug.TabIndex = 4;
            this.Debug.Text = "if \'%\' on list that means ctrl + v works when only % on list";
            this.Debug.UseWaitCursor = true;
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.Black;
            this.list.ForeColor = System.Drawing.Color.Lime;
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(455, 12);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(356, 134);
            this.list.TabIndex = 5;
            this.list.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(455, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 21);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.Addtolist);
            // 
            // itemname
            // 
            this.itemname.BackColor = System.Drawing.Color.Black;
            this.itemname.ForeColor = System.Drawing.Color.Lime;
            this.itemname.Location = new System.Drawing.Point(565, 152);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(226, 20);
            this.itemname.TabIndex = 7;
            this.itemname.UseWaitCursor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(500, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 21);
            this.button3.TabIndex = 8;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(797, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(22, 21);
            this.button4.TabIndex = 9;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.UseWaitCursor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(102, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = " opóźnienie ( milisec):";
            this.label2.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(823, 187);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.list);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.displaynum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Spambot 3.0";
            this.UseWaitCursor = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.escapepressed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer inputtester;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label displaynum;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.Label Debug;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox itemname;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
    }
}

