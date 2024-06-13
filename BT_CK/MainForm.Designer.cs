namespace BT_CK
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_hp = new System.Windows.Forms.ComboBox();
            this.cbb_sort = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.bnt_sort = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học phần";
            // 
            // cbb_hp
            // 
            this.cbb_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_hp.FormattingEnabled = true;
            this.cbb_hp.Location = new System.Drawing.Point(179, 27);
            this.cbb_hp.Name = "cbb_hp";
            this.cbb_hp.Size = new System.Drawing.Size(265, 28);
            this.cbb_hp.TabIndex = 1;
            // 
            // cbb_sort
            // 
            this.cbb_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_sort.FormattingEnabled = true;
            this.cbb_sort.Location = new System.Drawing.Point(775, 395);
            this.cbb_sort.Name = "cbb_sort";
            this.cbb_sort.Size = new System.Drawing.Size(210, 28);
            this.cbb_sort.TabIndex = 2;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_search.Location = new System.Drawing.Point(733, 27);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(170, 26);
            this.txt_search.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_search.Location = new System.Drawing.Point(959, 23);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(90, 30);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_up
            // 
            this.btn_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_up.Location = new System.Drawing.Point(255, 393);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(90, 30);
            this.btn_up.TabIndex = 5;
            this.btn_up.Text = "Update";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_add.Location = new System.Drawing.Point(95, 393);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 30);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_del.Location = new System.Drawing.Point(411, 393);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(90, 30);
            this.btn_del.TabIndex = 6;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // bnt_sort
            // 
            this.bnt_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bnt_sort.Location = new System.Drawing.Point(580, 393);
            this.bnt_sort.Name = "bnt_sort";
            this.bnt_sort.Size = new System.Drawing.Size(90, 30);
            this.bnt_sort.TabIndex = 7;
            this.bnt_sort.Text = "Sort";
            this.bnt_sort.UseVisualStyleBackColor = true;
            this.bnt_sort.Click += new System.EventHandler(this.bnt_sort_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1179, 270);
            this.dataGridView1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bnt_sort);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.cbb_sort);
            this.Controls.Add(this.cbb_hp);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_hp;
        private System.Windows.Forms.ComboBox cbb_sort;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button bnt_sort;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

