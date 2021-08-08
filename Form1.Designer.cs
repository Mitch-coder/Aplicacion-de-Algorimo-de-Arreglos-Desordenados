
namespace applicacionDeAlgoritmoUno
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
            this.lbQuantity = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textId = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvRegister = new System.Windows.Forms.DataGridView();
            this.showId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegister)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbQuantity
            // 
            this.lbQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbQuantity.ForeColor = System.Drawing.Color.Black;
            this.lbQuantity.Location = new System.Drawing.Point(59, 6);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(165, 40);
            this.lbQuantity.TabIndex = 0;
            this.lbQuantity.Text = "Cantidad de elementos";
            // 
            // textQuantity
            // 
            this.textQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textQuantity.Location = new System.Drawing.Point(286, 3);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(333, 27);
            this.textQuantity.TabIndex = 1;
            // 
            // btnSet
            // 
            this.btnSet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSet.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSet.Location = new System.Drawing.Point(697, 11);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(162, 29);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Establecer";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lbId
            // 
            this.lbId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbId.ForeColor = System.Drawing.Color.Black;
            this.lbId.Location = new System.Drawing.Point(124, 68);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(35, 20);
            this.lbId.TabIndex = 3;
            this.lbId.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(514, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // lbAge
            // 
            this.lbAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAge.ForeColor = System.Drawing.Color.Black;
            this.lbAge.Location = new System.Drawing.Point(747, 68);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(61, 20);
            this.lbAge.TabIndex = 5;
            this.lbAge.Text = "Edad";
            // 
            // btnRead
            // 
            this.btnRead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRead.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRead.Location = new System.Drawing.Point(268, 12);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(115, 29);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Buscar";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(739, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 29);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(44, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(134, 29);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Insertar";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(473, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 29);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.31267F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.354F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.textId, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textAge, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbQuantity, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSet, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbId, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbAge, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textName, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textQuantity, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(35, 78);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(934, 157);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // textId
            // 
            this.textId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textId.Location = new System.Drawing.Point(3, 107);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(277, 27);
            this.textId.TabIndex = 16;
            // 
            // textAge
            // 
            this.textAge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAge.Location = new System.Drawing.Point(625, 107);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(306, 27);
            this.textAge.TabIndex = 15;
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(409, 68);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(87, 20);
            this.lbName.TabIndex = 13;
            this.lbName.Text = "Nombre";
            // 
            // textName
            // 
            this.textName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textName.Location = new System.Drawing.Point(286, 107);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(333, 27);
            this.textName.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.78947F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.21053F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel3.Controls.Add(this.btnCreate, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRead, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnUpdate, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDelete, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(35, 241);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(934, 54);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvRegister);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 524);
            this.panel1.TabIndex = 19;
            // 
            // dtgvRegister
            // 
            this.dtgvRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtgvRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRegister.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgvRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.showId,
            this.showName,
            this.showAge});
            this.dtgvRegister.Location = new System.Drawing.Point(0, 367);
            this.dtgvRegister.Name = "dtgvRegister";
            this.dtgvRegister.RowHeadersWidth = 51;
            this.dtgvRegister.RowTemplate.Height = 29;
            this.dtgvRegister.Size = new System.Drawing.Size(995, 157);
            this.dtgvRegister.TabIndex = 20;
            // 
            // showId
            // 
            this.showId.HeaderText = "Id";
            this.showId.MinimumWidth = 6;
            this.showId.Name = "showId";
            // 
            // showName
            // 
            this.showName.HeaderText = "Nombre";
            this.showName.MinimumWidth = 6;
            this.showName.Name = "showName";
            // 
            // showAge
            // 
            this.showAge.HeaderText = "Edad";
            this.showAge.MinimumWidth = 6;
            this.showAge.Name = "showAge";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.btnShow);
            this.panel3.Location = new System.Drawing.Point(35, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 32);
            this.panel3.TabIndex = 19;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShow.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShow.Location = new System.Drawing.Point(391, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(152, 29);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Mostrar";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.lbTitle);
            this.panel2.Location = new System.Drawing.Point(35, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 41);
            this.panel2.TabIndex = 18;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(221, 10);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(438, 20);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Ejemplos de Arreglos Desordenados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(995, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.MinimumSize = new System.Drawing.Size(1013, 571);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegister)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dtgvRegister;
        private System.Windows.Forms.DataGridViewTextBoxColumn showId;
        private System.Windows.Forms.DataGridViewTextBoxColumn showName;
        private System.Windows.Forms.DataGridViewTextBoxColumn showAge;
    }
}

