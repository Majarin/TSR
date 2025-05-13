namespace Sitting_roller_v2
{
    partial class frmroller
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
            this.txtAR = new System.Windows.Forms.TextBox();
            this.lblList = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnWipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAR
            // 
            this.txtAR.Location = new System.Drawing.Point(369, 82);
            this.txtAR.Name = "txtAR";
            this.txtAR.Size = new System.Drawing.Size(197, 20);
            this.txtAR.TabIndex = 0;
            this.txtAR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandeler);
            // 
            // lblList
            // 
            this.lblList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblList.Location = new System.Drawing.Point(22, 18);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(256, 398);
            this.lblList.TabIndex = 1;
            // 
            // btnRoll
            // 
            this.btnRoll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRoll.Location = new System.Drawing.Point(313, 114);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(114, 31);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(313, 82);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(36, 26);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(313, 49);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(61, 27);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(359, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(471, 406);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(82, 29);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnWipe
            // 
            this.btnWipe.Location = new System.Drawing.Point(457, 114);
            this.btnWipe.Name = "btnWipe";
            this.btnWipe.Size = new System.Drawing.Size(109, 31);
            this.btnWipe.TabIndex = 7;
            this.btnWipe.Text = "Wipe";
            this.btnWipe.UseVisualStyleBackColor = true;
            this.btnWipe.Click += new System.EventHandler(this.btnWipe_Click);
            // 
            // frmroller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.btnWipe);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.txtAR);
            this.Name = "frmroller";
            this.Text = "Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAR;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnWipe;
    }
}

