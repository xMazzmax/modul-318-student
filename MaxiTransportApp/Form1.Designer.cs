namespace MaxiTransportApp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.verbindungssucheTabPage = new System.Windows.Forms.TabPage();
            this.connectionListView = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.searchConnectionButton = new System.Windows.Forms.Button();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.abfahrtstafelTabPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.suchenAbfahrtstafelButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.departureColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.arrivalColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destinationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startPlatformColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destinationPlatformColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connectionPointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connectionPointBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.voidColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabControl1.SuspendLayout();
            this.verbindungssucheTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.abfahrtstafelTabPage.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionPointBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionPointBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.AccessibleName = "";
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.verbindungssucheTabPage);
            this.TabControl1.Controls.Add(this.abfahrtstafelTabPage);
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(842, 379);
            this.TabControl1.TabIndex = 6;
            // 
            // verbindungssucheTabPage
            // 
            this.verbindungssucheTabPage.Controls.Add(this.connectionListView);
            this.verbindungssucheTabPage.Controls.Add(this.panel1);
            this.verbindungssucheTabPage.Location = new System.Drawing.Point(4, 25);
            this.verbindungssucheTabPage.Name = "verbindungssucheTabPage";
            this.verbindungssucheTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.verbindungssucheTabPage.Size = new System.Drawing.Size(834, 350);
            this.verbindungssucheTabPage.TabIndex = 0;
            this.verbindungssucheTabPage.Text = "Verbindungssuche";
            this.verbindungssucheTabPage.UseVisualStyleBackColor = true;
            // 
            // connectionListView
            // 
            this.connectionListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.voidColumnHeader,
            this.departureColumnHeader,
            this.startColumnHeader,
            this.startPlatformColumnHeader,
            this.arrivalColumnHeader,
            this.destinationColumnHeader,
            this.destinationPlatformColumnHeader});
            this.connectionListView.HideSelection = false;
            this.connectionListView.Location = new System.Drawing.Point(6, 108);
            this.connectionListView.Name = "connectionListView";
            this.connectionListView.Size = new System.Drawing.Size(822, 236);
            this.connectionListView.TabIndex = 5;
            this.connectionListView.UseCompatibleStateImageBehavior = false;
            this.connectionListView.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.searchConnectionButton);
            this.panel1.Controls.Add(this.fromTextBox);
            this.panel1.Controls.Add(this.toTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 96);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(421, 50);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(244, 22);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // searchConnectionButton
            // 
            this.searchConnectionButton.Location = new System.Drawing.Point(671, 10);
            this.searchConnectionButton.Name = "searchConnectionButton";
            this.searchConnectionButton.Size = new System.Drawing.Size(100, 62);
            this.searchConnectionButton.TabIndex = 4;
            this.searchConnectionButton.Text = "Suchen";
            this.searchConnectionButton.UseVisualStyleBackColor = true;
            this.searchConnectionButton.Click += new System.EventHandler(this.searchConnectionButton_Click);
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(58, 10);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(244, 22);
            this.fromTextBox.TabIndex = 0;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(421, 10);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(244, 22);
            this.toTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Zeit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nach:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Datum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Von:";
            // 
            // abfahrtstafelTabPage
            // 
            this.abfahrtstafelTabPage.Controls.Add(this.panel2);
            this.abfahrtstafelTabPage.Location = new System.Drawing.Point(4, 25);
            this.abfahrtstafelTabPage.Name = "abfahrtstafelTabPage";
            this.abfahrtstafelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.abfahrtstafelTabPage.Size = new System.Drawing.Size(834, 350);
            this.abfahrtstafelTabPage.TabIndex = 1;
            this.abfahrtstafelTabPage.Text = "Abfahrtstafel";
            this.abfahrtstafelTabPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.suchenAbfahrtstafelButton);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 70);
            this.panel2.TabIndex = 1;
            // 
            // suchenAbfahrtstafelButton
            // 
            this.suchenAbfahrtstafelButton.Location = new System.Drawing.Point(853, 10);
            this.suchenAbfahrtstafelButton.Name = "suchenAbfahrtstafelButton";
            this.suchenAbfahrtstafelButton.Size = new System.Drawing.Size(75, 23);
            this.suchenAbfahrtstafelButton.TabIndex = 1;
            this.suchenAbfahrtstafelButton.Text = "Suchen";
            this.suchenAbfahrtstafelButton.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(58, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(301, 22);
            this.textBox3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Von:";
            // 
            // departureColumnHeader
            // 
            this.departureColumnHeader.Text = "Abfahrt";
            this.departureColumnHeader.Width = 58;
            // 
            // startColumnHeader
            // 
            this.startColumnHeader.Text = "Start";
            this.startColumnHeader.Width = 164;
            // 
            // arrivalColumnHeader
            // 
            this.arrivalColumnHeader.Text = "Ankunft";
            // 
            // destinationColumnHeader
            // 
            this.destinationColumnHeader.Text = "Ziel";
            this.destinationColumnHeader.Width = 182;
            // 
            // startPlatformColumnHeader
            // 
            this.startPlatformColumnHeader.Text = "Gleis";
            // 
            // destinationPlatformColumnHeader
            // 
            this.destinationPlatformColumnHeader.Text = "Gleis";
            // 
            // stopBindingSource
            // 
            this.stopBindingSource.DataSource = typeof(SwissTransport.Models.Stop);
            // 
            // connectionPointBindingSource
            // 
            this.connectionPointBindingSource.DataSource = typeof(SwissTransport.Models.ConnectionPoint);
            // 
            // connectionPointBindingSource1
            // 
            this.connectionPointBindingSource1.DataSource = typeof(SwissTransport.Models.ConnectionPoint);
            // 
            // voidColumnHeader
            // 
            this.voidColumnHeader.Width = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 391);
            this.Controls.Add(this.TabControl1);
            this.Name = "Form1";
            this.Text = "MaxiTransportApp";
            this.TabControl1.ResumeLayout(false);
            this.verbindungssucheTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.abfahrtstafelTabPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionPointBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionPointBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage verbindungssucheTabPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage abfahrtstafelTabPage;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Button searchConnectionButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button suchenAbfahrtstafelButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource connectionPointBindingSource;
        private System.Windows.Forms.BindingSource stopBindingSource;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.BindingSource connectionPointBindingSource1;
        private System.Windows.Forms.ListView connectionListView;
        private System.Windows.Forms.ColumnHeader departureColumnHeader;
        private System.Windows.Forms.ColumnHeader startColumnHeader;
        private System.Windows.Forms.ColumnHeader startPlatformColumnHeader;
        private System.Windows.Forms.ColumnHeader arrivalColumnHeader;
        private System.Windows.Forms.ColumnHeader destinationColumnHeader;
        private System.Windows.Forms.ColumnHeader destinationPlatformColumnHeader;
        private System.Windows.Forms.ColumnHeader voidColumnHeader;
    }
}

