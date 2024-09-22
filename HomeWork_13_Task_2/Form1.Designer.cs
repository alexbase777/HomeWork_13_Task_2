namespace HomeWork_13_Task_2
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
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.btnConnectBD = new System.Windows.Forms.Button();
            this.openFileDialog_Connect = new System.Windows.Forms.OpenFileDialog();
            this.lblTables = new System.Windows.Forms.Label();
            this.lblDB = new System.Windows.Forms.Label();
            this.tBNameDB = new System.Windows.Forms.TextBox();
            this.lstBoxTables = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTablesInfo = new System.Windows.Forms.Label();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(28, 30);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(519, 396);
            this.dgvTable.TabIndex = 0;
            // 
            // btnConnectBD
            // 
            this.btnConnectBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnectBD.Location = new System.Drawing.Point(569, 30);
            this.btnConnectBD.Name = "btnConnectBD";
            this.btnConnectBD.Size = new System.Drawing.Size(253, 48);
            this.btnConnectBD.TabIndex = 1;
            this.btnConnectBD.Text = "Подключиться к базе данных";
            this.btnConnectBD.UseVisualStyleBackColor = true;
            this.btnConnectBD.Click += new System.EventHandler(this.btnConnectBD_Click);
            // 
            // openFileDialog_Connect
            // 
            this.openFileDialog_Connect.FileName = "openFileDialog1";
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTables.Location = new System.Drawing.Point(565, 157);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(213, 20);
            this.lblTables.TabIndex = 3;
            this.lblTables.Text = "Таблицы в базе данных:";
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDB.Location = new System.Drawing.Point(565, 93);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(215, 20);
            this.lblDB.TabIndex = 4;
            this.lblDB.Text = "Загружена база данных:";
            // 
            // tBNameDB
            // 
            this.tBNameDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBNameDB.Location = new System.Drawing.Point(569, 116);
            this.tBNameDB.Name = "tBNameDB";
            this.tBNameDB.Size = new System.Drawing.Size(253, 26);
            this.tBNameDB.TabIndex = 5;
            // 
            // lstBoxTables
            // 
            this.lstBoxTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstBoxTables.FormattingEnabled = true;
            this.lstBoxTables.ItemHeight = 20;
            this.lstBoxTables.Location = new System.Drawing.Point(569, 216);
            this.lstBoxTables.Name = "lstBoxTables";
            this.lstBoxTables.Size = new System.Drawing.Size(253, 44);
            this.lstBoxTables.TabIndex = 6;
            this.lstBoxTables.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstBoxTables_MouseClick);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(569, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(253, 48);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить изменённые данные";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTablesInfo
            // 
            this.lblTablesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTablesInfo.Location = new System.Drawing.Point(567, 177);
            this.lblTablesInfo.Name = "lblTablesInfo";
            this.lblTablesInfo.Size = new System.Drawing.Size(234, 36);
            this.lblTablesInfo.TabIndex = 8;
            this.lblTablesInfo.Text = "Кликните по названию таблицы в списке";
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteRow.Location = new System.Drawing.Point(570, 283);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(253, 70);
            this.btnDeleteRow.TabIndex = 9;
            this.btnDeleteRow.Text = "Удалить выбранную(-ые) строку(-и)";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.lblTablesInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstBoxTables);
            this.Controls.Add(this.tBNameDB);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.lblTables);
            this.Controls.Add(this.btnConnectBD);
            this.Controls.Add(this.dgvTable);
            this.Name = "Form1";
            this.Text = "Работа с базой данных";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button btnConnectBD;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Connect;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.TextBox tBNameDB;
        private System.Windows.Forms.ListBox lstBoxTables;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTablesInfo;
        private System.Windows.Forms.Button btnDeleteRow;
    }
}

