namespace PokedexForms
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HP = new System.Windows.Forms.Label();
            this.Attack = new System.Windows.Forms.Label();
            this.Defense = new System.Windows.Forms.Label();
            this.SpecialA = new System.Windows.Forms.Label();
            this.SpecialD = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.Peso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(69, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(324, 340);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 36);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(258, 340);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 36);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(464, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HP
            // 
            this.HP.AutoSize = true;
            this.HP.BackColor = System.Drawing.Color.Transparent;
            this.HP.Location = new System.Drawing.Point(469, 94);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(23, 15);
            this.HP.TabIndex = 13;
            this.HP.Text = "HP";
            // 
            // Attack
            // 
            this.Attack.AutoSize = true;
            this.Attack.BackColor = System.Drawing.Color.Transparent;
            this.Attack.Location = new System.Drawing.Point(469, 121);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(41, 15);
            this.Attack.TabIndex = 14;
            this.Attack.Text = "Attack";
            // 
            // Defense
            // 
            this.Defense.AutoSize = true;
            this.Defense.BackColor = System.Drawing.Color.Transparent;
            this.Defense.Location = new System.Drawing.Point(469, 150);
            this.Defense.Name = "Defense";
            this.Defense.Size = new System.Drawing.Size(49, 15);
            this.Defense.TabIndex = 15;
            this.Defense.Text = "Defense";
            // 
            // SpecialA
            // 
            this.SpecialA.AutoSize = true;
            this.SpecialA.BackColor = System.Drawing.Color.Transparent;
            this.SpecialA.Location = new System.Drawing.Point(557, 94);
            this.SpecialA.Name = "SpecialA";
            this.SpecialA.Size = new System.Drawing.Size(49, 15);
            this.SpecialA.TabIndex = 16;
            this.SpecialA.Text = "SpeciaA";
            // 
            // SpecialD
            // 
            this.SpecialD.AutoSize = true;
            this.SpecialD.BackColor = System.Drawing.Color.Transparent;
            this.SpecialD.Location = new System.Drawing.Point(557, 121);
            this.SpecialD.Name = "SpecialD";
            this.SpecialD.Size = new System.Drawing.Size(52, 15);
            this.SpecialD.TabIndex = 17;
            this.SpecialD.Text = "SpecialD";
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.BackColor = System.Drawing.Color.Transparent;
            this.Speed.Location = new System.Drawing.Point(558, 150);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(39, 15);
            this.Speed.TabIndex = 18;
            this.Speed.Text = "Speed";
            // 
            // Peso
            // 
            this.Peso.AutoSize = true;
            this.Peso.BackColor = System.Drawing.Color.Transparent;
            this.Peso.Location = new System.Drawing.Point(662, 150);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(32, 15);
            this.Peso.TabIndex = 19;
            this.Peso.Text = "Peso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokedexForms.Properties.Resources.plantilla;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.SpecialD);
            this.Controls.Add(this.SpecialA);
            this.Controls.Add(this.Defense);
            this.Controls.Add(this.Attack);
            this.Controls.Add(this.HP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label HP;
        private Label Attack;
        private Label Defense;
        private Label SpecialA;
        private Label SpecialD;
        private Label Speed;
        private Label Peso;
    }
}