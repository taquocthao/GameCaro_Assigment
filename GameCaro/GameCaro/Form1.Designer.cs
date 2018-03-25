namespace GameCaro
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
            this.pnlBanCo = new System.Windows.Forms.Panel();
            this.lblThoat = new System.Windows.Forms.Label();
            this.lblPlayerVsComputer = new System.Windows.Forms.Label();
            this.lblPlayerVsPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chơiVớiNgườiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đánhVớiMáyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBanCo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBanCo
            // 
            this.pnlBanCo.Controls.Add(this.lblThoat);
            this.pnlBanCo.Controls.Add(this.lblPlayerVsComputer);
            this.pnlBanCo.Controls.Add(this.lblPlayerVsPlayer);
            this.pnlBanCo.Controls.Add(this.label1);
            this.pnlBanCo.Location = new System.Drawing.Point(12, 27);
            this.pnlBanCo.Name = "pnlBanCo";
            this.pnlBanCo.Size = new System.Drawing.Size(501, 501);
            this.pnlBanCo.TabIndex = 0;
            this.pnlBanCo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBanCo_Paint);
            this.pnlBanCo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBanCo_MouseClick);
            // 
            // lblThoat
            // 
            this.lblThoat.AutoSize = true;
            this.lblThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoat.ForeColor = System.Drawing.Color.Red;
            this.lblThoat.Location = new System.Drawing.Point(208, 351);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(84, 31);
            this.lblThoat.TabIndex = 7;
            this.lblThoat.Text = "Thoát";
            this.lblThoat.Click += new System.EventHandler(this.lblThoat_Click);
            this.lblThoat.MouseLeave += new System.EventHandler(this.lblThoat_MouseLeave);
            this.lblThoat.MouseHover += new System.EventHandler(this.lblThoat_MouseHover);
            // 
            // lblPlayerVsComputer
            // 
            this.lblPlayerVsComputer.AutoSize = true;
            this.lblPlayerVsComputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPlayerVsComputer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlayerVsComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerVsComputer.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerVsComputer.Location = new System.Drawing.Point(175, 277);
            this.lblPlayerVsComputer.Name = "lblPlayerVsComputer";
            this.lblPlayerVsComputer.Size = new System.Drawing.Size(156, 29);
            this.lblPlayerVsComputer.TabIndex = 6;
            this.lblPlayerVsComputer.Text = "Đánh với máy";
            this.lblPlayerVsComputer.Click += new System.EventHandler(this.lblPlayerVsComputer_Click);
            this.lblPlayerVsComputer.MouseLeave += new System.EventHandler(this.lblPlayerVsComputer_MouseLeave_1);
            this.lblPlayerVsComputer.MouseHover += new System.EventHandler(this.lblPlayerVsComputer_MouseHover_1);
            // 
            // lblPlayerVsPlayer
            // 
            this.lblPlayerVsPlayer.AutoSize = true;
            this.lblPlayerVsPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPlayerVsPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlayerVsPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerVsPlayer.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerVsPlayer.Location = new System.Drawing.Point(167, 215);
            this.lblPlayerVsPlayer.Name = "lblPlayerVsPlayer";
            this.lblPlayerVsPlayer.Size = new System.Drawing.Size(172, 29);
            this.lblPlayerVsPlayer.TabIndex = 5;
            this.lblPlayerVsPlayer.Text = "Đánh với người";
            this.lblPlayerVsPlayer.Click += new System.EventHandler(this.lblPlayerVsPlayer_Click);
            this.lblPlayerVsPlayer.MouseLeave += new System.EventHandler(this.lblPlayerVsPlayer_MouseLeave_1);
            this.lblPlayerVsPlayer.MouseHover += new System.EventHandler(this.lblPlayerVsPlayer_MouseHover_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(134, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "New game!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chơiVớiNgườiToolStripMenuItem,
            this.đánhVớiMáyToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            // 
            // chơiVớiNgườiToolStripMenuItem
            // 
            this.chơiVớiNgườiToolStripMenuItem.Name = "chơiVớiNgườiToolStripMenuItem";
            this.chơiVớiNgườiToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.chơiVớiNgườiToolStripMenuItem.Text = "Đánh với người";
            this.chơiVớiNgườiToolStripMenuItem.Click += new System.EventHandler(this.chơiVớiNgườiToolStripMenuItem_Click);
            // 
            // đánhVớiMáyToolStripMenuItem
            // 
            this.đánhVớiMáyToolStripMenuItem.Name = "đánhVớiMáyToolStripMenuItem";
            this.đánhVớiMáyToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.đánhVớiMáyToolStripMenuItem.Text = "Đánh với máy";
            this.đánhVớiMáyToolStripMenuItem.Click += new System.EventHandler(this.đánhVớiMáyToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 539);
            this.Controls.Add(this.pnlBanCo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Game caro";
            this.pnlBanCo.ResumeLayout(false);
            this.pnlBanCo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanCo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chơiVớiNgườiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đánhVớiMáyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label lblThoat;
        private System.Windows.Forms.Label lblPlayerVsComputer;
        private System.Windows.Forms.Label lblPlayerVsPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

