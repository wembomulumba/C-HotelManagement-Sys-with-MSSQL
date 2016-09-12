namespace HotelManagementSystem
{
    partial class ScheduleGuest
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleGuest));
            System.Windows.Forms.Label roomNumerLabel;
            System.Windows.Forms.Label roomTypeLabel;
            System.Windows.Forms.Label inDateLabel;
            System.Windows.Forms.Label outDateLabel;
            System.Windows.Forms.Label unitLabel;
            this.metroShell1 = new DevComponents.DotNetBar.Metro.MetroShell();
            this.metroTabPanel2 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.metroTabPanel1 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.metroToolbar1 = new DevComponents.DotNetBar.Metro.MetroToolbar();
            this.metroTabPanel3 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.metroAppButton1 = new DevComponents.DotNetBar.Metro.MetroAppButton();
            this.metroTabItem1 = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.metroTabItem2 = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.Guests = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.ratingItem1 = new DevComponents.DotNetBar.RatingItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.calendarView1 = new DevComponents.DotNetBar.Schedule.CalendarView();
            this.dateNavigator1 = new DevComponents.DotNetBar.Schedule.DateNavigator();
            this.hotelguestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagementDataSet = new HotelManagementSystem.HotelManagementDataSet();
            this.hotelguestTableAdapter = new HotelManagementSystem.HotelManagementDataSetTableAdapters.HotelguestTableAdapter();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new HotelManagementSystem.HotelManagementDataSetTableAdapters.RoomsTableAdapter();
            this.tableAdapterManager = new HotelManagementSystem.HotelManagementDataSetTableAdapters.TableAdapterManager();
            this.roomsMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelguestTableAdapter1 = new HotelManagementSystem.HotelManagementDataSetTableAdapters.HotelguestTableAdapter();
            this.roomsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.roomsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.roomNumerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.roomTypeComboBox = new System.Windows.Forms.ComboBox();
            this.inDateMetroDateTime = new MetroFramework.Controls.MetroDateTime();
            this.outDateMetroDateTime = new MetroFramework.Controls.MetroDateTime();
            this.unitListBox = new System.Windows.Forms.ListBox();
            roomNumerLabel = new System.Windows.Forms.Label();
            roomTypeLabel = new System.Windows.Forms.Label();
            inDateLabel = new System.Windows.Forms.Label();
            outDateLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            this.metroShell1.SuspendLayout();
            this.metroTabPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelguestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingNavigator)).BeginInit();
            this.roomsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomNumerNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // metroShell1
            // 
            // 
            // 
            // 
            this.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroShell1.CaptionVisible = true;
            this.metroShell1.Controls.Add(this.metroTabPanel2);
            this.metroShell1.Controls.Add(this.metroTabPanel1);
            this.metroShell1.Controls.Add(this.metroTabPanel3);
            this.metroShell1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroShell1.HelpButtonText = null;
            this.metroShell1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroAppButton1,
            this.metroTabItem1,
            this.metroTabItem2,
            this.Guests,
            this.ratingItem1});
            this.metroShell1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.metroShell1.Location = new System.Drawing.Point(5, 1);
            this.metroShell1.Name = "metroShell1";
            this.metroShell1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.qatCustomizeItem1});
            this.metroShell1.Size = new System.Drawing.Size(945, 60);
            this.metroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.metroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.metroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.metroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.metroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.metroShell1.SystemText.QatDialogAddButton = "&Add >>";
            this.metroShell1.SystemText.QatDialogCancelButton = "Cancel";
            this.metroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.metroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.metroShell1.SystemText.QatDialogOkButton = "OK";
            this.metroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatDialogRemoveButton = "&Remove";
            this.metroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.metroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.metroShell1.TabIndex = 0;
            this.metroShell1.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroShell1.Text = "metroShell1";
            // 
            // metroTabPanel2
            // 
            this.metroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel2.Location = new System.Drawing.Point(-32000, 32000);
            this.metroTabPanel2.Name = "metroTabPanel2";
            this.metroTabPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel2.Size = new System.Drawing.Size(907, 72);
            // 
            // 
            // 
            this.metroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel2.TabIndex = 2;
            // 
            // metroTabPanel1
            // 
            this.metroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel1.Controls.Add(this.metroToolbar1);
            this.metroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel1.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel1.Name = "metroTabPanel1";
            this.metroTabPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel1.Size = new System.Drawing.Size(907, 72);
            // 
            // 
            // 
            this.metroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel1.TabIndex = 1;
            this.metroTabPanel1.Visible = false;
            // 
            // metroToolbar1
            // 
            this.metroToolbar1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroToolbar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroToolbar1.ContainerControlProcessDialogKey = true;
            this.metroToolbar1.DragDropSupport = true;
            this.metroToolbar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroToolbar1.ForeColor = System.Drawing.Color.Black;
            this.metroToolbar1.Location = new System.Drawing.Point(6, 38);
            this.metroToolbar1.Name = "metroToolbar1";
            this.metroToolbar1.Size = new System.Drawing.Size(75, 28);
            this.metroToolbar1.TabIndex = 0;
            this.metroToolbar1.Text = "metroToolbar1";
            // 
            // metroTabPanel3
            // 
            this.metroTabPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel3.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel3.Name = "metroTabPanel3";
            this.metroTabPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel3.Size = new System.Drawing.Size(907, 72);
            // 
            // 
            // 
            this.metroTabPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel3.TabIndex = 3;
            this.metroTabPanel3.Visible = false;
            // 
            // metroAppButton1
            // 
            this.metroAppButton1.AutoExpandOnClick = true;
            this.metroAppButton1.CanCustomize = false;
            this.metroAppButton1.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.metroAppButton1.ImagePaddingHorizontal = 0;
            this.metroAppButton1.ImagePaddingVertical = 0;
            this.metroAppButton1.Name = "metroAppButton1";
            this.metroAppButton1.ShowSubItems = false;
            this.metroAppButton1.Text = "&File";
            // 
            // metroTabItem1
            // 
            this.metroTabItem1.Name = "metroTabItem1";
            this.metroTabItem1.Panel = this.metroTabPanel1;
            this.metroTabItem1.Text = "&HOME";
            // 
            // metroTabItem2
            // 
            this.metroTabItem2.Checked = true;
            this.metroTabItem2.Name = "metroTabItem2";
            this.metroTabItem2.Panel = this.metroTabPanel2;
            this.metroTabItem2.Text = "&VIEW";
            // 
            // Guests
            // 
            this.Guests.Name = "Guests";
            this.Guests.Panel = this.metroTabPanel3;
            this.Guests.Text = "Group Guest";
            // 
            // ratingItem1
            // 
            // 
            // 
            // 
            this.ratingItem1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ratingItem1.Name = "ratingItem1";
            this.ratingItem1.RatingChanged += new System.EventHandler(this.ratingItem1_RatingChanged);
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "Hotel Management";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.BeginGroup = true;
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // calendarView1
            // 
            this.calendarView1.AutoScrollMinSize = new System.Drawing.Size(252, 980);
            this.calendarView1.BackColor = System.Drawing.Color.White;
            this.calendarView1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            // 
            // 
            // 
            this.calendarView1.BackgroundStyle.BackColor = System.Drawing.SystemColors.Info;
            this.calendarView1.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(165)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.calendarView1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calendarView1.ContainerControlProcessDialogKey = true;
            this.calendarView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.hotelguestBindingSource, "CheckIN", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.calendarView1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelguestBindingSource, "Unit", true));
            this.calendarView1.ForeColor = System.Drawing.Color.Black;
            this.calendarView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.calendarView1.Location = new System.Drawing.Point(17, 166);
            this.calendarView1.MultiUserTabHeight = 19;
            this.calendarView1.Name = "calendarView1";
            this.calendarView1.Size = new System.Drawing.Size(899, 325);
            this.calendarView1.TabIndex = 1;
            this.calendarView1.Text = "calendarView1";
            this.calendarView1.TimeIndicator.BorderColor = System.Drawing.Color.Empty;
            this.calendarView1.TimeIndicator.Tag = null;
            this.calendarView1.TimeSlotDuration = 30;
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.CanvasColor = System.Drawing.SystemColors.Control;
            this.dateNavigator1.DisabledBackColor = System.Drawing.Color.Empty;
            this.dateNavigator1.Location = new System.Drawing.Point(396, 130);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.Size = new System.Drawing.Size(223, 30);
            this.dateNavigator1.Style.BackColor1.Color = System.Drawing.Color.White;
            this.dateNavigator1.TabIndex = 3;
            this.dateNavigator1.Text = "dateNavigator1";
            // 
            // hotelguestBindingSource
            // 
            this.hotelguestBindingSource.DataMember = "Hotelguest";
            this.hotelguestBindingSource.DataSource = this.hotelManagementDataSet;
            // 
            // hotelManagementDataSet
            // 
            this.hotelManagementDataSet.DataSetName = "HotelManagementDataSet";
            this.hotelManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelguestTableAdapter
            // 
            this.hotelguestTableAdapter.ClearBeforeFill = true;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.hotelManagementDataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillingTableAdapter = null;
            this.tableAdapterManager.HotelguestTableAdapter = this.hotelguestTableAdapter;
            this.tableAdapterManager.RateinfoTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = this.roomsTableAdapter;
            this.tableAdapterManager.UpdateOrder = HotelManagementSystem.HotelManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // roomsMetroGrid
            // 
            this.roomsMetroGrid.AllowUserToResizeRows = false;
            this.roomsMetroGrid.AutoGenerateColumns = false;
            this.roomsMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roomsMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomsMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.roomsMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomsMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.roomsMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.roomsMetroGrid.DataSource = this.roomsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomsMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.roomsMetroGrid.EnableHeadersVisualStyles = false;
            this.roomsMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.roomsMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roomsMetroGrid.Location = new System.Drawing.Point(26, 513);
            this.roomsMetroGrid.Name = "roomsMetroGrid";
            this.roomsMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomsMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.roomsMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.roomsMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomsMetroGrid.Size = new System.Drawing.Size(535, 220);
            this.roomsMetroGrid.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RoomNumer";
            this.dataGridViewTextBoxColumn1.HeaderText = "RoomNumer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RoomType";
            this.dataGridViewTextBoxColumn2.HeaderText = "RoomType";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "InDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "InDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OutDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "OutDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Unit";
            this.dataGridViewTextBoxColumn5.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // hotelguestTableAdapter1
            // 
            this.hotelguestTableAdapter1.ClearBeforeFill = true;
            // 
            // roomsBindingNavigator
            // 
            this.roomsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.roomsBindingNavigator.BindingSource = this.roomsBindingSource;
            this.roomsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.roomsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.roomsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.roomsBindingNavigatorSaveItem});
            this.roomsBindingNavigator.Location = new System.Drawing.Point(5, 61);
            this.roomsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.roomsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.roomsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.roomsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.roomsBindingNavigator.Name = "roomsBindingNavigator";
            this.roomsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.roomsBindingNavigator.Size = new System.Drawing.Size(945, 25);
            this.roomsBindingNavigator.TabIndex = 17;
            this.roomsBindingNavigator.Text = "bindingNavigator1";
            this.roomsBindingNavigator.RefreshItems += new System.EventHandler(this.roomsBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // roomsBindingNavigatorSaveItem
            // 
            this.roomsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.roomsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("roomsBindingNavigatorSaveItem.Image")));
            this.roomsBindingNavigatorSaveItem.Name = "roomsBindingNavigatorSaveItem";
            this.roomsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.roomsBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // roomNumerLabel
            // 
            roomNumerLabel.AutoSize = true;
            roomNumerLabel.Location = new System.Drawing.Point(608, 513);
            roomNumerLabel.Name = "roomNumerLabel";
            roomNumerLabel.Size = new System.Drawing.Size(72, 13);
            roomNumerLabel.TabIndex = 17;
            roomNumerLabel.Text = "Room Numer:";
            // 
            // roomNumerNumericUpDown
            // 
            this.roomNumerNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.roomsBindingSource, "RoomNumer", true));
            this.roomNumerNumericUpDown.Location = new System.Drawing.Point(686, 513);
            this.roomNumerNumericUpDown.Name = "roomNumerNumericUpDown";
            this.roomNumerNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.roomNumerNumericUpDown.TabIndex = 18;
            // 
            // roomTypeLabel
            // 
            roomTypeLabel.AutoSize = true;
            roomTypeLabel.Location = new System.Drawing.Point(608, 542);
            roomTypeLabel.Name = "roomTypeLabel";
            roomTypeLabel.Size = new System.Drawing.Size(65, 13);
            roomTypeLabel.TabIndex = 19;
            roomTypeLabel.Text = "Room Type:";
            // 
            // roomTypeComboBox
            // 
            this.roomTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "RoomType", true));
            this.roomTypeComboBox.FormattingEnabled = true;
            this.roomTypeComboBox.Items.AddRange(new object[] {
            "Single",
            "Double",
            "VIP",
            "LUXE",
            "Entreprise"});
            this.roomTypeComboBox.Location = new System.Drawing.Point(686, 539);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.Size = new System.Drawing.Size(200, 21);
            this.roomTypeComboBox.TabIndex = 20;
            // 
            // inDateLabel
            // 
            inDateLabel.AutoSize = true;
            inDateLabel.Location = new System.Drawing.Point(608, 570);
            inDateLabel.Name = "inDateLabel";
            inDateLabel.Size = new System.Drawing.Size(45, 13);
            inDateLabel.TabIndex = 21;
            inDateLabel.Text = "In Date:";
            // 
            // inDateMetroDateTime
            // 
            this.inDateMetroDateTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.roomsBindingSource, "InDate", true));
            this.inDateMetroDateTime.Location = new System.Drawing.Point(686, 566);
            this.inDateMetroDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.inDateMetroDateTime.Name = "inDateMetroDateTime";
            this.inDateMetroDateTime.Size = new System.Drawing.Size(200, 29);
            this.inDateMetroDateTime.TabIndex = 22;
            // 
            // outDateLabel
            // 
            outDateLabel.AutoSize = true;
            outDateLabel.Location = new System.Drawing.Point(608, 596);
            outDateLabel.Name = "outDateLabel";
            outDateLabel.Size = new System.Drawing.Size(53, 13);
            outDateLabel.TabIndex = 23;
            outDateLabel.Text = "Out Date:";
            // 
            // outDateMetroDateTime
            // 
            this.outDateMetroDateTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.roomsBindingSource, "OutDate", true));
            this.outDateMetroDateTime.Location = new System.Drawing.Point(686, 592);
            this.outDateMetroDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.outDateMetroDateTime.Name = "outDateMetroDateTime";
            this.outDateMetroDateTime.Size = new System.Drawing.Size(200, 29);
            this.outDateMetroDateTime.TabIndex = 24;
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(608, 618);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(29, 13);
            unitLabel.TabIndex = 25;
            unitLabel.Text = "Unit:";
            // 
            // unitListBox
            // 
            this.unitListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.roomsBindingSource, "Unit", true));
            this.unitListBox.FormattingEnabled = true;
            this.unitListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.unitListBox.Location = new System.Drawing.Point(686, 618);
            this.unitListBox.Name = "unitListBox";
            this.unitListBox.Size = new System.Drawing.Size(200, 95);
            this.unitListBox.TabIndex = 26;
            // 
            // ScheduleGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(955, 736);
            this.Controls.Add(roomNumerLabel);
            this.Controls.Add(this.roomNumerNumericUpDown);
            this.Controls.Add(roomTypeLabel);
            this.Controls.Add(this.roomTypeComboBox);
            this.Controls.Add(inDateLabel);
            this.Controls.Add(this.inDateMetroDateTime);
            this.Controls.Add(outDateLabel);
            this.Controls.Add(this.outDateMetroDateTime);
            this.Controls.Add(unitLabel);
            this.Controls.Add(this.unitListBox);
            this.Controls.Add(this.roomsBindingNavigator);
            this.Controls.Add(this.roomsMetroGrid);
            this.Controls.Add(this.dateNavigator1);
            this.Controls.Add(this.calendarView1);
            this.Controls.Add(this.metroShell1);
            this.Name = "ScheduleGuest";
            this.Text = "Schedule Guest";
            this.Load += new System.EventHandler(this.ScheduleGuest_Load);
            this.metroShell1.ResumeLayout(false);
            this.metroShell1.PerformLayout();
            this.metroTabPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotelguestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingNavigator)).EndInit();
            this.roomsBindingNavigator.ResumeLayout(false);
            this.roomsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomNumerNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroShell metroShell1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel2;
        private DevComponents.DotNetBar.Metro.MetroAppButton metroAppButton1;
        private DevComponents.DotNetBar.Metro.MetroTabItem metroTabItem1;
        private DevComponents.DotNetBar.Metro.MetroTabItem metroTabItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Schedule.CalendarView calendarView1;
        private DevComponents.DotNetBar.Schedule.DateNavigator dateNavigator1;
        private DevComponents.DotNetBar.Metro.MetroToolbar metroToolbar1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel3;
        private DevComponents.DotNetBar.Metro.MetroTabItem Guests;
        private DevComponents.DotNetBar.RatingItem ratingItem1;
        private HotelManagementDataSet hotelManagementDataSet;
        private System.Windows.Forms.BindingSource hotelguestBindingSource;
        private HotelManagementDataSetTableAdapters.HotelguestTableAdapter hotelguestTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private HotelManagementDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private HotelManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroGrid roomsMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private HotelManagementDataSetTableAdapters.HotelguestTableAdapter hotelguestTableAdapter1;
        private System.Windows.Forms.BindingNavigator roomsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton roomsBindingNavigatorSaveItem;
        private System.Windows.Forms.NumericUpDown roomNumerNumericUpDown;
        private System.Windows.Forms.ComboBox roomTypeComboBox;
        private MetroFramework.Controls.MetroDateTime inDateMetroDateTime;
        private MetroFramework.Controls.MetroDateTime outDateMetroDateTime;
        private System.Windows.Forms.ListBox unitListBox;
    }
}