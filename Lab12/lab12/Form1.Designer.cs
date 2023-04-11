
namespace lab12
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
            this.tt = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.round = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
            this.SuspendLayout();
            // 
            // tt
            // 
            this.tt.AllowUserToAddRows = false;
            this.tt.AllowUserToDeleteRows = false;
            this.tt.AllowUserToOrderColumns = true;
            this.tt.AllowUserToResizeRows = false;
            this.tt.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.tt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name,
            this.PLD,
            this.W,
            this.D,
            this.L,
            this.GS,
            this.PTS});
            this.tt.Location = new System.Drawing.Point(1, 1);
            this.tt.Name = "tt";
            this.tt.RowHeadersWidth = 51;
            this.tt.RowTemplate.Height = 24;
            this.tt.Size = new System.Drawing.Size(1296, 266);
            this.tt.TabIndex = 3;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.number.HeaderText = "№";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 51;
            // 
            // name
            // 
            this.name.HeaderText = "Team";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // PLD
            // 
            this.PLD.HeaderText = "PLD";
            this.PLD.MinimumWidth = 6;
            this.PLD.Name = "PLD";
            this.PLD.ReadOnly = true;
            this.PLD.Width = 125;
            // 
            // W
            // 
            this.W.HeaderText = "WINS";
            this.W.MinimumWidth = 6;
            this.W.Name = "W";
            this.W.ReadOnly = true;
            this.W.Width = 125;
            // 
            // D
            // 
            this.D.HeaderText = "DRAWS";
            this.D.MinimumWidth = 6;
            this.D.Name = "D";
            this.D.ReadOnly = true;
            this.D.Width = 125;
            // 
            // L
            // 
            this.L.HeaderText = "LOSES";
            this.L.MinimumWidth = 6;
            this.L.Name = "L";
            this.L.ReadOnly = true;
            this.L.Width = 125;
            // 
            // GS
            // 
            this.GS.HeaderText = "GS";
            this.GS.MinimumWidth = 6;
            this.GS.Name = "GS";
            this.GS.ReadOnly = true;
            this.GS.Width = 125;
            // 
            // PTS
            // 
            this.PTS.HeaderText = "PTS";
            this.PTS.MinimumWidth = 6;
            this.PTS.Name = "PTS";
            this.PTS.ReadOnly = true;
            this.PTS.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(448, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 84);
            this.button1.TabIndex = 4;
            this.button1.Text = "Начать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // round
            // 
            this.round.AutoSize = true;
            this.round.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.round.Location = new System.Drawing.Point(60, 333);
            this.round.Name = "round";
            this.round.Size = new System.Drawing.Size(56, 25);
            this.round.TabIndex = 5;
            this.round.Text = "Круг";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(983, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(983, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(983, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 431);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.round);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLD;
        private System.Windows.Forms.DataGridViewTextBoxColumn W;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn L;
        private System.Windows.Forms.DataGridViewTextBoxColumn GS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label round;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

