
namespace X_O_Game
{
    partial class Home
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
            this.pnl_Holder = new System.Windows.Forms.Panel();
            this.pnl_Home = new System.Windows.Forms.Panel();
            this.btn_Start = new X_O_Game.RoundedButton();
            this.btn_Options = new X_O_Game.RoundedButton();
            this.btn_Quit = new X_O_Game.RoundedButton();
            this.pnl_Holder.SuspendLayout();
            this.pnl_Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Holder
            // 
            this.pnl_Holder.Controls.Add(this.pnl_Home);
            this.pnl_Holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Holder.Location = new System.Drawing.Point(0, 0);
            this.pnl_Holder.Name = "pnl_Holder";
            this.pnl_Holder.Size = new System.Drawing.Size(1024, 686);
            this.pnl_Holder.TabIndex = 0;
            // 
            // pnl_Home
            // 
            this.pnl_Home.Controls.Add(this.btn_Quit);
            this.pnl_Home.Controls.Add(this.btn_Options);
            this.pnl_Home.Controls.Add(this.btn_Start);
            this.pnl_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Home.Location = new System.Drawing.Point(0, 0);
            this.pnl_Home.Name = "pnl_Home";
            this.pnl_Home.Size = new System.Drawing.Size(1024, 686);
            this.pnl_Home.TabIndex = 0;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Start.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Start.BColor = System.Drawing.Color.DarkRed;
            this.btn_Start.BRedius = 70;
            this.btn_Start.BSize = 0;
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Kristen ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(164)))));
            this.btn_Start.Location = new System.Drawing.Point(371, 149);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(282, 76);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(164)))));
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Options
            // 
            this.btn_Options.BackColor = System.Drawing.Color.Transparent;
            this.btn_Options.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Options.BColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Options.BRedius = 70;
            this.btn_Options.BSize = 2;
            this.btn_Options.FlatAppearance.BorderSize = 0;
            this.btn_Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Options.Font = new System.Drawing.Font("Kristen ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Options.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Options.Location = new System.Drawing.Point(371, 258);
            this.btn_Options.Name = "btn_Options";
            this.btn_Options.Size = new System.Drawing.Size(282, 76);
            this.btn_Options.TabIndex = 0;
            this.btn_Options.Text = "Options";
            this.btn_Options.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Options.UseVisualStyleBackColor = false;
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Quit.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Quit.BColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Quit.BRedius = 70;
            this.btn_Quit.BSize = 2;
            this.btn_Quit.FlatAppearance.BorderSize = 0;
            this.btn_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quit.Font = new System.Drawing.Font("Kristen ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Quit.Location = new System.Drawing.Point(371, 366);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(282, 76);
            this.btn_Quit.TabIndex = 0;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Quit.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1024, 686);
            this.Controls.Add(this.pnl_Holder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnl_Holder.ResumeLayout(false);
            this.pnl_Home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Holder;
        private System.Windows.Forms.Panel pnl_Home;
        private RoundedButton btn_Start;
        private RoundedButton btn_Quit;
        private RoundedButton btn_Options;
    }
}

