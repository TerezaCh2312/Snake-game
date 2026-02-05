namespace snake_game
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            nápovědaToolStripMenuItem = new ToolStripMenuItem();
            rychlostHadaToolStripMenuItem = new ToolStripMenuItem();
            začátečníkToolStripMenuItem = new ToolStripMenuItem();
            pokročilýToolStripMenuItem = new ToolStripMenuItem();
            expertToolStripMenuItem = new ToolStripMenuItem();
            verzeHryToolStripMenuItem = new ToolStripMenuItem();
            staráVerzeToolStripMenuItem = new ToolStripMenuItem();
            nováVerzeToolStripMenuItem = new ToolStripMenuItem();
            barvaPozadíToolStripMenuItem = new ToolStripMenuItem();
            zelenáToolStripMenuItem1 = new ToolStripMenuItem();
            bíláToolStripMenuItem = new ToolStripMenuItem();
            černáToolStripMenuItem1 = new ToolStripMenuItem();
            modráToolStripMenuItem1 = new ToolStripMenuItem();
            červenáToolStripMenuItem1 = new ToolStripMenuItem();
            barvaHadaToolStripMenuItem = new ToolStripMenuItem();
            červenáToolStripMenuItem = new ToolStripMenuItem();
            modráToolStripMenuItem = new ToolStripMenuItem();
            zelenáToolStripMenuItem = new ToolStripMenuItem();
            fialováToolStripMenuItem = new ToolStripMenuItem();
            žlutáToolStripMenuItem = new ToolStripMenuItem();
            černáToolStripMenuItem = new ToolStripMenuItem();
            možnostiHryToolStripMenuItem = new ToolStripMenuItem();
            ukončitToolStripMenuItem = new ToolStripMenuItem();
            resetovatToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nápovědaToolStripMenuItem, rychlostHadaToolStripMenuItem, verzeHryToolStripMenuItem, barvaPozadíToolStripMenuItem, barvaHadaToolStripMenuItem, možnostiHryToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.Stretch = false;
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nápovědaToolStripMenuItem
            // 
            nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            nápovědaToolStripMenuItem.Size = new Size(92, 26);
            nápovědaToolStripMenuItem.Text = "Nápověda";
            nápovědaToolStripMenuItem.Click += nápovědaToolStripMenuItem_Click;
            // 
            // rychlostHadaToolStripMenuItem
            // 
            rychlostHadaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { začátečníkToolStripMenuItem, pokročilýToolStripMenuItem, expertToolStripMenuItem });
            rychlostHadaToolStripMenuItem.Name = "rychlostHadaToolStripMenuItem";
            rychlostHadaToolStripMenuItem.Size = new Size(115, 26);
            rychlostHadaToolStripMenuItem.Text = "Rychlost hada";
            // 
            // začátečníkToolStripMenuItem
            // 
            začátečníkToolStripMenuItem.Name = "začátečníkToolStripMenuItem";
            začátečníkToolStripMenuItem.Size = new Size(224, 26);
            začátečníkToolStripMenuItem.Text = "Začátečník";
            začátečníkToolStripMenuItem.Click += začátečníkToolStripMenuItem_Click;
            // 
            // pokročilýToolStripMenuItem
            // 
            pokročilýToolStripMenuItem.Name = "pokročilýToolStripMenuItem";
            pokročilýToolStripMenuItem.Size = new Size(224, 26);
            pokročilýToolStripMenuItem.Text = "Pokročilý";
            pokročilýToolStripMenuItem.Click += pokročilýToolStripMenuItem_Click;
            // 
            // expertToolStripMenuItem
            // 
            expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            expertToolStripMenuItem.Size = new Size(224, 26);
            expertToolStripMenuItem.Text = "Expert";
            expertToolStripMenuItem.Click += expertToolStripMenuItem_Click;
            // 
            // verzeHryToolStripMenuItem
            // 
            verzeHryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { staráVerzeToolStripMenuItem, nováVerzeToolStripMenuItem });
            verzeHryToolStripMenuItem.Name = "verzeHryToolStripMenuItem";
            verzeHryToolStripMenuItem.Size = new Size(83, 26);
            verzeHryToolStripMenuItem.Text = "Verze hry";
            // 
            // staráVerzeToolStripMenuItem
            // 
            staráVerzeToolStripMenuItem.Name = "staráVerzeToolStripMenuItem";
            staráVerzeToolStripMenuItem.Size = new Size(299, 26);
            staráVerzeToolStripMenuItem.Text = "Stará verze (okraj = konec)";
            staráVerzeToolStripMenuItem.Click += staráVerzeToolStripMenuItem_Click;
            // 
            // nováVerzeToolStripMenuItem
            // 
            nováVerzeToolStripMenuItem.Name = "nováVerzeToolStripMenuItem";
            nováVerzeToolStripMenuItem.Size = new Size(299, 26);
            nováVerzeToolStripMenuItem.Text = "Nová verze (okraj = projde zdí)";
            nováVerzeToolStripMenuItem.Click += nováVerzeToolStripMenuItem_Click;
            // 
            // barvaPozadíToolStripMenuItem
            // 
            barvaPozadíToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zelenáToolStripMenuItem1, bíláToolStripMenuItem, černáToolStripMenuItem1, modráToolStripMenuItem1, červenáToolStripMenuItem1 });
            barvaPozadíToolStripMenuItem.Name = "barvaPozadíToolStripMenuItem";
            barvaPozadíToolStripMenuItem.Size = new Size(110, 26);
            barvaPozadíToolStripMenuItem.Text = "Barva pozadí";
            // 
            // zelenáToolStripMenuItem1
            // 
            zelenáToolStripMenuItem1.Name = "zelenáToolStripMenuItem1";
            zelenáToolStripMenuItem1.Size = new Size(224, 26);
            zelenáToolStripMenuItem1.Text = "zelená";
            zelenáToolStripMenuItem1.Click += zelenáToolStripMenuItem1_Click;
            // 
            // bíláToolStripMenuItem
            // 
            bíláToolStripMenuItem.Name = "bíláToolStripMenuItem";
            bíláToolStripMenuItem.Size = new Size(224, 26);
            bíláToolStripMenuItem.Text = "bílá";
            bíláToolStripMenuItem.Click += bíláToolStripMenuItem_Click;
            // 
            // černáToolStripMenuItem1
            // 
            černáToolStripMenuItem1.Name = "černáToolStripMenuItem1";
            černáToolStripMenuItem1.Size = new Size(224, 26);
            černáToolStripMenuItem1.Text = "černá";
            černáToolStripMenuItem1.Click += černáToolStripMenuItem1_Click;
            // 
            // modráToolStripMenuItem1
            // 
            modráToolStripMenuItem1.Name = "modráToolStripMenuItem1";
            modráToolStripMenuItem1.Size = new Size(224, 26);
            modráToolStripMenuItem1.Text = "modrá";
            modráToolStripMenuItem1.Click += modráToolStripMenuItem1_Click;
            // 
            // červenáToolStripMenuItem1
            // 
            červenáToolStripMenuItem1.Name = "červenáToolStripMenuItem1";
            červenáToolStripMenuItem1.Size = new Size(224, 26);
            červenáToolStripMenuItem1.Text = "červená";
            červenáToolStripMenuItem1.Click += červenáToolStripMenuItem1_Click;
            // 
            // barvaHadaToolStripMenuItem
            // 
            barvaHadaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { červenáToolStripMenuItem, modráToolStripMenuItem, zelenáToolStripMenuItem, fialováToolStripMenuItem, žlutáToolStripMenuItem, černáToolStripMenuItem });
            barvaHadaToolStripMenuItem.Name = "barvaHadaToolStripMenuItem";
            barvaHadaToolStripMenuItem.Size = new Size(97, 26);
            barvaHadaToolStripMenuItem.Text = "Barva hada";
            // 
            // červenáToolStripMenuItem
            // 
            červenáToolStripMenuItem.Name = "červenáToolStripMenuItem";
            červenáToolStripMenuItem.Size = new Size(224, 26);
            červenáToolStripMenuItem.Text = "červená";
            červenáToolStripMenuItem.Click += červenáToolStripMenuItem_Click;
            // 
            // modráToolStripMenuItem
            // 
            modráToolStripMenuItem.Name = "modráToolStripMenuItem";
            modráToolStripMenuItem.Size = new Size(224, 26);
            modráToolStripMenuItem.Text = "modrá";
            modráToolStripMenuItem.Click += modráToolStripMenuItem_Click;
            // 
            // zelenáToolStripMenuItem
            // 
            zelenáToolStripMenuItem.Name = "zelenáToolStripMenuItem";
            zelenáToolStripMenuItem.Size = new Size(224, 26);
            zelenáToolStripMenuItem.Text = "zelená";
            zelenáToolStripMenuItem.Click += zelenáToolStripMenuItem_Click;
            // 
            // fialováToolStripMenuItem
            // 
            fialováToolStripMenuItem.Name = "fialováToolStripMenuItem";
            fialováToolStripMenuItem.Size = new Size(224, 26);
            fialováToolStripMenuItem.Text = "fialová";
            fialováToolStripMenuItem.Click += fialováToolStripMenuItem_Click;
            // 
            // žlutáToolStripMenuItem
            // 
            žlutáToolStripMenuItem.Name = "žlutáToolStripMenuItem";
            žlutáToolStripMenuItem.Size = new Size(224, 26);
            žlutáToolStripMenuItem.Text = "žlutá";
            žlutáToolStripMenuItem.Click += žlutáToolStripMenuItem_Click;
            // 
            // černáToolStripMenuItem
            // 
            černáToolStripMenuItem.Name = "černáToolStripMenuItem";
            černáToolStripMenuItem.Size = new Size(224, 26);
            černáToolStripMenuItem.Text = "černá";
            černáToolStripMenuItem.Click += černáToolStripMenuItem_Click;
            // 
            // možnostiHryToolStripMenuItem
            // 
            možnostiHryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ukončitToolStripMenuItem, resetovatToolStripMenuItem });
            možnostiHryToolStripMenuItem.Name = "možnostiHryToolStripMenuItem";
            možnostiHryToolStripMenuItem.Size = new Size(108, 26);
            možnostiHryToolStripMenuItem.Text = "Možnosti hry";
            // 
            // ukončitToolStripMenuItem
            // 
            ukončitToolStripMenuItem.Name = "ukončitToolStripMenuItem";
            ukončitToolStripMenuItem.Size = new Size(224, 26);
            ukončitToolStripMenuItem.Text = "Ukončit";
            ukončitToolStripMenuItem.Click += ukončitToolStripMenuItem_Click;
            // 
            // resetovatToolStripMenuItem
            // 
            resetovatToolStripMenuItem.Name = "resetovatToolStripMenuItem";
            resetovatToolStripMenuItem.Size = new Size(224, 26);
            resetovatToolStripMenuItem.Text = "Resetovat";
            resetovatToolStripMenuItem.Click += resetovatToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(12, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 411);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Had (snake)";
            KeyDown += Form1_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nápovědaToolStripMenuItem;
        private ToolStripMenuItem rychlostHadaToolStripMenuItem;
        private ToolStripMenuItem začátečníkToolStripMenuItem;
        private ToolStripMenuItem pokročilýToolStripMenuItem;
        private ToolStripMenuItem expertToolStripMenuItem;
        private ToolStripMenuItem verzeHryToolStripMenuItem;
        private ToolStripMenuItem staráVerzeToolStripMenuItem;
        private ToolStripMenuItem nováVerzeToolStripMenuItem;
        private ToolStripMenuItem barvaPozadíToolStripMenuItem;
        private ToolStripMenuItem barvaHadaToolStripMenuItem;
        private ToolStripMenuItem možnostiHryToolStripMenuItem;
        private ToolStripMenuItem ukončitToolStripMenuItem;
        private ToolStripMenuItem resetovatToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem zelenáToolStripMenuItem1;
        private ToolStripMenuItem bíláToolStripMenuItem;
        private ToolStripMenuItem černáToolStripMenuItem1;
        private ToolStripMenuItem modráToolStripMenuItem1;
        private ToolStripMenuItem červenáToolStripMenuItem1;
        private ToolStripMenuItem červenáToolStripMenuItem;
        private ToolStripMenuItem modráToolStripMenuItem;
        private ToolStripMenuItem zelenáToolStripMenuItem;
        private ToolStripMenuItem fialováToolStripMenuItem;
        private ToolStripMenuItem žlutáToolStripMenuItem;
        private ToolStripMenuItem černáToolStripMenuItem;
    }
}
