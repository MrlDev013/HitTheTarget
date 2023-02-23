namespace prj_AcerteOAlvo
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.grb_Controllers = new System.Windows.Forms.GroupBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.btn_Left = new System.Windows.Forms.Button();
            this.btn_Down = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.pct_Player = new System.Windows.Forms.PictureBox();
            this.pnl_BlueBox = new System.Windows.Forms.Panel();
            this.grb_Controllers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_Controllers
            // 
            this.grb_Controllers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grb_Controllers.Controls.Add(this.btn_Submit);
            this.grb_Controllers.Controls.Add(this.btn_Right);
            this.grb_Controllers.Controls.Add(this.btn_Left);
            this.grb_Controllers.Controls.Add(this.btn_Down);
            this.grb_Controllers.Controls.Add(this.btn_Up);
            this.grb_Controllers.Location = new System.Drawing.Point(520, 340);
            this.grb_Controllers.Name = "grb_Controllers";
            this.grb_Controllers.Size = new System.Drawing.Size(250, 118);
            this.grb_Controllers.TabIndex = 0;
            this.grb_Controllers.TabStop = false;
            this.grb_Controllers.Text = "Controllers";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Location = new System.Drawing.Point(88, 89);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Visible = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Right
            // 
            this.btn_Right.Location = new System.Drawing.Point(169, 60);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(75, 23);
            this.btn_Right.TabIndex = 3;
            this.btn_Right.Text = "Right";
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
            // 
            // btn_Left
            // 
            this.btn_Left.Location = new System.Drawing.Point(7, 60);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(75, 23);
            this.btn_Left.TabIndex = 2;
            this.btn_Left.Text = "Left";
            this.btn_Left.UseVisualStyleBackColor = true;
            this.btn_Left.Click += new System.EventHandler(this.btn_Left_Click);
            // 
            // btn_Down
            // 
            this.btn_Down.Location = new System.Drawing.Point(88, 60);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(75, 23);
            this.btn_Down.TabIndex = 1;
            this.btn_Down.Text = "Down";
            this.btn_Down.UseVisualStyleBackColor = true;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // btn_Up
            // 
            this.btn_Up.Location = new System.Drawing.Point(88, 31);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(75, 23);
            this.btn_Up.TabIndex = 0;
            this.btn_Up.Text = "Up";
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // pct_Player
            // 
            this.pct_Player.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pct_Player.BackColor = System.Drawing.Color.Transparent;
            this.pct_Player.Image = ((System.Drawing.Image)(resources.GetObject("pct_Player.Image")));
            this.pct_Player.Location = new System.Drawing.Point(12, 361);
            this.pct_Player.Name = "pct_Player";
            this.pct_Player.Size = new System.Drawing.Size(151, 106);
            this.pct_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_Player.TabIndex = 2;
            this.pct_Player.TabStop = false;
            // 
            // pnl_BlueBox
            // 
            this.pnl_BlueBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_BlueBox.BackColor = System.Drawing.Color.Blue;
            this.pnl_BlueBox.Location = new System.Drawing.Point(570, 10);
            this.pnl_BlueBox.Name = "pnl_BlueBox";
            this.pnl_BlueBox.Size = new System.Drawing.Size(200, 150);
            this.pnl_BlueBox.TabIndex = 3;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 479);
            this.Controls.Add(this.pct_Player);
            this.Controls.Add(this.pnl_BlueBox);
            this.Controls.Add(this.grb_Controllers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.grb_Controllers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grb_Controllers;
        private Button btn_Right;
        private Button btn_Left;
        private Button btn_Down;
        private Button btn_Up;
        private PictureBox pct_Player;
        private Button btn_Submit;
        private Panel pnl_BlueBox;
    }
}