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
            this.voidColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchConnectionButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.abfahrtstafelTabPage = new System.Windows.Forms.TabPage();
            this.stationBoardListView = new System.Windows.Forms.ListView();
            this.voidColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.stationComboBox = new System.Windows.Forms.ComboBox();
            this.searchStationBoardButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.stopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connectionPointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connectionPointBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.TabControl1.Size = new System.Drawing.Size(846, 419);
            this.TabControl1.TabIndex = 6;
            // 
            // verbindungssucheTabPage
            // 
            this.verbindungssucheTabPage.Controls.Add(this.connectionListView);
            this.verbindungssucheTabPage.Controls.Add(this.panel1);
            this.verbindungssucheTabPage.Location = new System.Drawing.Point(4, 25);
            this.verbindungssucheTabPage.Name = "verbindungssucheTabPage";
            this.verbindungssucheTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.verbindungssucheTabPage.Size = new System.Drawing.Size(838, 390);
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
            this.voidColumnHeader1,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.connectionListView.HideSelection = false;
            this.connectionListView.Location = new System.Drawing.Point(6, 93);
            this.connectionListView.Name = "connectionListView";
            this.connectionListView.Size = new System.Drawing.Size(826, 291);
            this.connectionListView.TabIndex = 5;
            this.connectionListView.UseCompatibleStateImageBehavior = false;
            this.connectionListView.View = System.Windows.Forms.View.Details;
            // 
            // voidColumnHeader1
            // 
            this.voidColumnHeader1.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Abfahrt";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Start";
            this.columnHeader2.Width = 185;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gleis";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ankunft";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ziel";
            this.columnHeader5.Width = 185;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Gleis";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.toComboBox);
            this.panel1.Controls.Add(this.fromComboBox);
            this.panel1.Controls.Add(this.timeDateTimePicker);
            this.panel1.Controls.Add(this.dateDateTimePicker);
            this.panel1.Controls.Add(this.searchConnectionButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 81);
            this.panel1.TabIndex = 0;
            // 
            // toComboBox
            // 
            this.toComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Location = new System.Drawing.Point(420, 10);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(244, 24);
            this.toComboBox.TabIndex = 2;
            this.toComboBox.TextChanged += new System.EventHandler(this.AutoSuggest);
            // 
            // fromComboBox
            // 
            this.fromComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fromComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Location = new System.Drawing.Point(58, 10);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(244, 24);
            this.fromComboBox.TabIndex = 1;
            this.fromComboBox.TextChanged += new System.EventHandler(this.AutoSuggest);
            // 
            // timeDateTimePicker
            // 
            this.timeDateTimePicker.CustomFormat = "HH:mm";
            this.timeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeDateTimePicker.Location = new System.Drawing.Point(421, 50);
            this.timeDateTimePicker.Name = "timeDateTimePicker";
            this.timeDateTimePicker.ShowUpDown = true;
            this.timeDateTimePicker.Size = new System.Drawing.Size(73, 22);
            this.timeDateTimePicker.TabIndex = 4;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.CustomFormat = "dd.MM.yyyy";
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDateTimePicker.Location = new System.Drawing.Point(58, 50);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(244, 22);
            this.dateDateTimePicker.TabIndex = 3;
            // 
            // searchConnectionButton
            // 
            this.searchConnectionButton.Location = new System.Drawing.Point(671, 10);
            this.searchConnectionButton.Name = "searchConnectionButton";
            this.searchConnectionButton.Size = new System.Drawing.Size(148, 62);
            this.searchConnectionButton.TabIndex = 5;
            this.searchConnectionButton.Text = "Suchen";
            this.searchConnectionButton.UseVisualStyleBackColor = true;
            this.searchConnectionButton.Click += new System.EventHandler(this.SearchConnectionButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Zeit:";
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
            this.abfahrtstafelTabPage.Controls.Add(this.stationBoardListView);
            this.abfahrtstafelTabPage.Controls.Add(this.panel2);
            this.abfahrtstafelTabPage.Location = new System.Drawing.Point(4, 25);
            this.abfahrtstafelTabPage.Name = "abfahrtstafelTabPage";
            this.abfahrtstafelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.abfahrtstafelTabPage.Size = new System.Drawing.Size(838, 390);
            this.abfahrtstafelTabPage.TabIndex = 1;
            this.abfahrtstafelTabPage.Text = "Abfahrtstafel";
            this.abfahrtstafelTabPage.UseVisualStyleBackColor = true;
            // 
            // stationBoardListView
            // 
            this.stationBoardListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stationBoardListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.voidColumnHeader2,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.stationBoardListView.HideSelection = false;
            this.stationBoardListView.Location = new System.Drawing.Point(6, 93);
            this.stationBoardListView.Name = "stationBoardListView";
            this.stationBoardListView.Size = new System.Drawing.Size(826, 291);
            this.stationBoardListView.TabIndex = 8;
            this.stationBoardListView.UseCompatibleStateImageBehavior = false;
            this.stationBoardListView.View = System.Windows.Forms.View.Details;
            // 
            // voidColumnHeader2
            // 
            this.voidColumnHeader2.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Abfahrt";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Linie";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Richtung";
            this.columnHeader9.Width = 200;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.stationComboBox);
            this.panel2.Controls.Add(this.searchStationBoardButton);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 81);
            this.panel2.TabIndex = 7;
            // 
            // stationComboBox
            // 
            this.stationComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.stationComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.stationComboBox.FormattingEnabled = true;
            this.stationComboBox.Location = new System.Drawing.Point(58, 10);
            this.stationComboBox.Name = "stationComboBox";
            this.stationComboBox.Size = new System.Drawing.Size(244, 24);
            this.stationComboBox.TabIndex = 1;
            this.stationComboBox.TextChanged += new System.EventHandler(this.AutoSuggest);
            // 
            // searchStationBoardButton
            // 
            this.searchStationBoardButton.Location = new System.Drawing.Point(671, 10);
            this.searchStationBoardButton.Name = "searchStationBoardButton";
            this.searchStationBoardButton.Size = new System.Drawing.Size(148, 62);
            this.searchStationBoardButton.TabIndex = 5;
            this.searchStationBoardButton.Text = "Suchen";
            this.searchStationBoardButton.UseVisualStyleBackColor = true;
            this.searchStationBoardButton.Click += new System.EventHandler(this.SearchStationBoardButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Station:";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 431);
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
        private System.Windows.Forms.Button searchConnectionButton;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker timeDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource connectionPointBindingSource;
        private System.Windows.Forms.BindingSource stopBindingSource;
        private System.Windows.Forms.BindingSource connectionPointBindingSource1;
        private System.Windows.Forms.ListView connectionListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader voidColumnHeader1;
        private System.Windows.Forms.ComboBox toComboBox;
        private System.Windows.Forms.ComboBox fromComboBox;
        private System.Windows.Forms.ListView stationBoardListView;
        private System.Windows.Forms.ColumnHeader voidColumnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox stationComboBox;
        private System.Windows.Forms.Button searchStationBoardButton;
        private System.Windows.Forms.Label label8;
    }
}

