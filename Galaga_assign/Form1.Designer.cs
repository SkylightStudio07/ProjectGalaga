namespace Galaga_assign
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Missile = new System.Windows.Forms.PictureBox();
            this.EnemyAircraft2 = new System.Windows.Forms.PictureBox();
            this.EnemyAircraft3 = new System.Windows.Forms.PictureBox();
            this.EnemyAircraft1 = new System.Windows.Forms.PictureBox();
            this.BF101 = new System.Windows.Forms.PictureBox();
            this.GameTICK = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Missile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyAircraft2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyAircraft3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyAircraft1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BF101)).BeginInit();
            this.SuspendLayout();
            // 
            // Missile
            // 
            this.Missile.BackColor = System.Drawing.Color.Transparent;
            this.Missile.Image = global::Galaga_assign.Properties.Resources.missile2;
            this.Missile.Location = new System.Drawing.Point(402, 182);
            this.Missile.Name = "Missile";
            this.Missile.Size = new System.Drawing.Size(8, 16);
            this.Missile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Missile.TabIndex = 4;
            this.Missile.TabStop = false;
            // 
            // EnemyAircraft2
            // 
            this.EnemyAircraft2.BackColor = System.Drawing.Color.Transparent;
            this.EnemyAircraft2.Image = global::Galaga_assign.Properties.Resources.Enemy;
            this.EnemyAircraft2.Location = new System.Drawing.Point(44, 54);
            this.EnemyAircraft2.Name = "EnemyAircraft2";
            this.EnemyAircraft2.Size = new System.Drawing.Size(50, 50);
            this.EnemyAircraft2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyAircraft2.TabIndex = 3;
            this.EnemyAircraft2.TabStop = false;
            // 
            // EnemyAircraft3
            // 
            this.EnemyAircraft3.BackColor = System.Drawing.Color.Transparent;
            this.EnemyAircraft3.Image = global::Galaga_assign.Properties.Resources.Enemy;
            this.EnemyAircraft3.Location = new System.Drawing.Point(293, 54);
            this.EnemyAircraft3.Name = "EnemyAircraft3";
            this.EnemyAircraft3.Size = new System.Drawing.Size(50, 50);
            this.EnemyAircraft3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyAircraft3.TabIndex = 2;
            this.EnemyAircraft3.TabStop = false;
            // 
            // EnemyAircraft1
            // 
            this.EnemyAircraft1.BackColor = System.Drawing.Color.Transparent;
            this.EnemyAircraft1.Image = global::Galaga_assign.Properties.Resources.Enemy;
            this.EnemyAircraft1.Location = new System.Drawing.Point(165, 54);
            this.EnemyAircraft1.Name = "EnemyAircraft1";
            this.EnemyAircraft1.Size = new System.Drawing.Size(50, 50);
            this.EnemyAircraft1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyAircraft1.TabIndex = 1;
            this.EnemyAircraft1.TabStop = false;
            // 
            // BF101
            // 
            this.BF101.BackColor = System.Drawing.Color.Transparent;
            this.BF101.Image = global::Galaga_assign.Properties.Resources.BF_117;
            this.BF101.Location = new System.Drawing.Point(165, 441);
            this.BF101.Name = "BF101";
            this.BF101.Size = new System.Drawing.Size(50, 50);
            this.BF101.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BF101.TabIndex = 0;
            this.BF101.TabStop = false;
            // 
            // GameTICK
            // 
            this.GameTICK.Enabled = true;
            this.GameTICK.Interval = 10;
            this.GameTICK.Tick += new System.EventHandler(this.GameTICK_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.Missile);
            this.Controls.Add(this.EnemyAircraft2);
            this.Controls.Add(this.EnemyAircraft3);
            this.Controls.Add(this.EnemyAircraft1);
            this.Controls.Add(this.BF101);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Missile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyAircraft2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyAircraft3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyAircraft1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BF101)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BF101;
        private System.Windows.Forms.PictureBox EnemyAircraft1;
        private System.Windows.Forms.PictureBox EnemyAircraft3;
        private System.Windows.Forms.PictureBox EnemyAircraft2;
        private System.Windows.Forms.PictureBox Missile;
        private System.Windows.Forms.Timer GameTICK;
    }
}

