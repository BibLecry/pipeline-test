﻿using SharpChess.UI;

namespace SharpChess
{
    partial class SharpChess
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
            this.boardPanel = new DoubleBuffer();
            this.label1 = new System.Windows.Forms.Label();
            this.currentPiece_lbl = new System.Windows.Forms.Label();
            this.newGame_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boardPanel
            // 
            this.boardPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.boardPanel.Location = new System.Drawing.Point(12, 12);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(720, 720);
            this.boardPanel.TabIndex = 0;
            this.boardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.boardPanel_Paint);
            this.boardPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.boardPanel_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(748, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tile Coordinate:";
            // 
            // currentPiece_lbl
            // 
            this.currentPiece_lbl.AutoSize = true;
            this.currentPiece_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPiece_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.currentPiece_lbl.Location = new System.Drawing.Point(748, 42);
            this.currentPiece_lbl.Name = "currentPiece_lbl";
            this.currentPiece_lbl.Size = new System.Drawing.Size(49, 21);
            this.currentPiece_lbl.TabIndex = 2;
            this.currentPiece_lbl.Text = "Piece:";
            // 
            // newGame_btn
            // 
            this.newGame_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.newGame_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGame_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.newGame_btn.Location = new System.Drawing.Point(12, 744);
            this.newGame_btn.Name = "newGame_btn";
            this.newGame_btn.Size = new System.Drawing.Size(150, 55);
            this.newGame_btn.TabIndex = 3;
            this.newGame_btn.Text = "New Game";
            this.newGame_btn.UseVisualStyleBackColor = false;
            this.newGame_btn.Click += new System.EventHandler(this.newGame_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(822, 744);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SharpChess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(984, 811);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newGame_btn);
            this.Controls.Add(this.currentPiece_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boardPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "SharpChess";
            this.Text = "SharpChess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DoubleBuffer boardPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentPiece_lbl;
        private System.Windows.Forms.Button newGame_btn;
        private System.Windows.Forms.Button button1;
    }
}

