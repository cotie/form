namespace form
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
            vytvor = new Button();
            vypis = new Button();
            tb1 = new TextBox();
            tb2 = new TextBox();
            tb3 = new TextBox();
            tb4 = new TextBox();
            tb5 = new TextBox();
            tb6 = new TextBox();
            tb7 = new TextBox();
            tb8 = new TextBox();
            cb1 = new ComboBox();
            SuspendLayout();
            // 
            // vytvor
            // 
            vytvor.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            vytvor.Location = new Point(34, 245);
            vytvor.Margin = new Padding(3, 4, 3, 4);
            vytvor.Name = "vytvor";
            vytvor.Size = new Size(286, 200);
            vytvor.TabIndex = 0;
            vytvor.Text = "Vytvoř";
            vytvor.UseVisualStyleBackColor = true;
            vytvor.Click += button1_Click;
            // 
            // vypis
            // 
            vypis.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            vypis.Location = new Point(615, 245);
            vypis.Margin = new Padding(3, 4, 3, 4);
            vypis.Name = "vypis";
            vypis.Size = new Size(286, 200);
            vypis.TabIndex = 1;
            vypis.Text = "Vypiš";
            vypis.UseVisualStyleBackColor = true;
            vypis.Click += vypis_Click;
            // 
            // tb1
            // 
            tb1.Location = new Point(34, 65);
            tb1.Margin = new Padding(3, 4, 3, 4);
            tb1.Name = "tb1";
            tb1.Size = new Size(285, 27);
            tb1.TabIndex = 2;
            // 
            // tb2
            // 
            tb2.Location = new Point(34, 104);
            tb2.Margin = new Padding(3, 4, 3, 4);
            tb2.Name = "tb2";
            tb2.Size = new Size(285, 27);
            tb2.TabIndex = 3;
            // 
            // tb3
            // 
            tb3.Location = new Point(34, 143);
            tb3.Margin = new Padding(3, 4, 3, 4);
            tb3.Name = "tb3";
            tb3.Size = new Size(285, 27);
            tb3.TabIndex = 4;
            // 
            // tb4
            // 
            tb4.Location = new Point(34, 181);
            tb4.Margin = new Padding(3, 4, 3, 4);
            tb4.Name = "tb4";
            tb4.Size = new Size(285, 27);
            tb4.TabIndex = 5;
            // 
            // tb5
            // 
            tb5.Location = new Point(615, 65);
            tb5.Margin = new Padding(3, 4, 3, 4);
            tb5.Name = "tb5";
            tb5.Size = new Size(285, 27);
            tb5.TabIndex = 6;
            // 
            // tb6
            // 
            tb6.Location = new Point(615, 104);
            tb6.Margin = new Padding(3, 4, 3, 4);
            tb6.Name = "tb6";
            tb6.Size = new Size(285, 27);
            tb6.TabIndex = 7;
            // 
            // tb7
            // 
            tb7.Location = new Point(615, 143);
            tb7.Margin = new Padding(3, 4, 3, 4);
            tb7.Name = "tb7";
            tb7.Size = new Size(285, 27);
            tb7.TabIndex = 8;
            // 
            // tb8
            // 
            tb8.Location = new Point(615, 181);
            tb8.Margin = new Padding(3, 4, 3, 4);
            tb8.Name = "tb8";
            tb8.Size = new Size(285, 27);
            tb8.TabIndex = 9;
            // 
            // cb1
            // 
            cb1.FormattingEnabled = true;
            cb1.Location = new Point(369, 65);
            cb1.Margin = new Padding(3, 4, 3, 4);
            cb1.Name = "cb1";
            cb1.Size = new Size(197, 28);
            cb1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 491);
            Controls.Add(cb1);
            Controls.Add(tb8);
            Controls.Add(tb7);
            Controls.Add(tb6);
            Controls.Add(tb5);
            Controls.Add(tb4);
            Controls.Add(tb3);
            Controls.Add(tb2);
            Controls.Add(tb1);
            Controls.Add(vypis);
            Controls.Add(vytvor);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button vytvor;
        private Button vypis;
        private TextBox tb1;
        private TextBox tb2;
        private TextBox tb3;
        private TextBox tb4;
        private TextBox tb5;
        private TextBox tb6;
        private TextBox tb7;
        private TextBox tb8;
        private ComboBox cb1;
    }
}