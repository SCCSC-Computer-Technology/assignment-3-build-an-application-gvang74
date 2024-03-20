
namespace gvang_CPT_206_StateApp2
{
    partial class View
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label stateNameLabel;
            System.Windows.Forms.Label stateCapitalLabel;
            System.Windows.Forms.Label statePopulationLabel;
            System.Windows.Forms.Label stateLargestCityLabel;
            System.Windows.Forms.Label stateBirdLabel;
            System.Windows.Forms.Label stateFlowerLabel;
            System.Windows.Forms.Label stateColorsLabel;
            System.Windows.Forms.Label stateFlagInfoLabel;
            System.Windows.Forms.Label stateMedianIncomeLabel;
            System.Windows.Forms.Label overalWorkforceLabel;
            System.Windows.Forms.Label jobPosting_Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReturn = new System.Windows.Forms.Label();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesDBDataSet = new gvang_CPT_206_StateApp2.statesDBDataSet();
            this.stateNameTextBox = new System.Windows.Forms.TextBox();
            this.stateCapitalTextBox = new System.Windows.Forms.TextBox();
            this.statePopulationTextBox = new System.Windows.Forms.TextBox();
            this.stateLargestCityTextBox = new System.Windows.Forms.TextBox();
            this.stateBirdTextBox = new System.Windows.Forms.TextBox();
            this.stateFlowerTextBox = new System.Windows.Forms.TextBox();
            this.stateColorsTextBox = new System.Windows.Forms.TextBox();
            this.stateFlagInfoTextBox = new System.Windows.Forms.TextBox();
            this.stateMedianIncomeTextBox = new System.Windows.Forms.TextBox();
            this.overalWorkforceTextBox = new System.Windows.Forms.TextBox();
            this.jobPosting_TextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statesTableAdapter = new gvang_CPT_206_StateApp2.statesDBDataSetTableAdapters.StatesTableAdapter();
            this.tableAdapterManager = new gvang_CPT_206_StateApp2.statesDBDataSetTableAdapters.TableAdapterManager();
            this.statesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.statesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            iDLabel = new System.Windows.Forms.Label();
            stateNameLabel = new System.Windows.Forms.Label();
            stateCapitalLabel = new System.Windows.Forms.Label();
            statePopulationLabel = new System.Windows.Forms.Label();
            stateLargestCityLabel = new System.Windows.Forms.Label();
            stateBirdLabel = new System.Windows.Forms.Label();
            stateFlowerLabel = new System.Windows.Forms.Label();
            stateColorsLabel = new System.Windows.Forms.Label();
            stateFlagInfoLabel = new System.Windows.Forms.Label();
            stateMedianIncomeLabel = new System.Windows.Forms.Label();
            overalWorkforceLabel = new System.Windows.Forms.Label();
            jobPosting_Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesDBDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).BeginInit();
            this.statesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(42, 25);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(32, 24);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // stateNameLabel
            // 
            stateNameLabel.AutoSize = true;
            stateNameLabel.Location = new System.Drawing.Point(42, 83);
            stateNameLabel.Name = "stateNameLabel";
            stateNameLabel.Size = new System.Drawing.Size(112, 24);
            stateNameLabel.TabIndex = 2;
            stateNameLabel.Text = "State Name:";
            // 
            // stateCapitalLabel
            // 
            stateCapitalLabel.AutoSize = true;
            stateCapitalLabel.Location = new System.Drawing.Point(42, 117);
            stateCapitalLabel.Name = "stateCapitalLabel";
            stateCapitalLabel.Size = new System.Drawing.Size(117, 24);
            stateCapitalLabel.TabIndex = 4;
            stateCapitalLabel.Text = "State Capital:";
            // 
            // statePopulationLabel
            // 
            statePopulationLabel.AutoSize = true;
            statePopulationLabel.Location = new System.Drawing.Point(42, 151);
            statePopulationLabel.Name = "statePopulationLabel";
            statePopulationLabel.Size = new System.Drawing.Size(150, 24);
            statePopulationLabel.TabIndex = 6;
            statePopulationLabel.Text = "State Population:";
            // 
            // stateLargestCityLabel
            // 
            stateLargestCityLabel.AutoSize = true;
            stateLargestCityLabel.Location = new System.Drawing.Point(42, 185);
            stateLargestCityLabel.Name = "stateLargestCityLabel";
            stateLargestCityLabel.Size = new System.Drawing.Size(157, 24);
            stateLargestCityLabel.TabIndex = 8;
            stateLargestCityLabel.Text = "State Largest City:";
            // 
            // stateBirdLabel
            // 
            stateBirdLabel.AutoSize = true;
            stateBirdLabel.Location = new System.Drawing.Point(42, 219);
            stateBirdLabel.Name = "stateBirdLabel";
            stateBirdLabel.Size = new System.Drawing.Size(94, 24);
            stateBirdLabel.TabIndex = 10;
            stateBirdLabel.Text = "State Bird:";
            // 
            // stateFlowerLabel
            // 
            stateFlowerLabel.AutoSize = true;
            stateFlowerLabel.Location = new System.Drawing.Point(42, 253);
            stateFlowerLabel.Name = "stateFlowerLabel";
            stateFlowerLabel.Size = new System.Drawing.Size(119, 24);
            stateFlowerLabel.TabIndex = 12;
            stateFlowerLabel.Text = "State Flower:";
            // 
            // stateColorsLabel
            // 
            stateColorsLabel.AutoSize = true;
            stateColorsLabel.Location = new System.Drawing.Point(42, 287);
            stateColorsLabel.Name = "stateColorsLabel";
            stateColorsLabel.Size = new System.Drawing.Size(115, 24);
            stateColorsLabel.TabIndex = 14;
            stateColorsLabel.Text = "State Colors:";
            // 
            // stateFlagInfoLabel
            // 
            stateFlagInfoLabel.AutoSize = true;
            stateFlagInfoLabel.Location = new System.Drawing.Point(42, 321);
            stateFlagInfoLabel.Name = "stateFlagInfoLabel";
            stateFlagInfoLabel.Size = new System.Drawing.Size(133, 24);
            stateFlagInfoLabel.TabIndex = 16;
            stateFlagInfoLabel.Text = "State Flag Info:";
            // 
            // stateMedianIncomeLabel
            // 
            stateMedianIncomeLabel.AutoSize = true;
            stateMedianIncomeLabel.Location = new System.Drawing.Point(42, 362);
            stateMedianIncomeLabel.Name = "stateMedianIncomeLabel";
            stateMedianIncomeLabel.Size = new System.Drawing.Size(192, 24);
            stateMedianIncomeLabel.TabIndex = 18;
            stateMedianIncomeLabel.Text = "State Median Income:";
            // 
            // overalWorkforceLabel
            // 
            overalWorkforceLabel.AutoSize = true;
            overalWorkforceLabel.Location = new System.Drawing.Point(42, 396);
            overalWorkforceLabel.Name = "overalWorkforceLabel";
            overalWorkforceLabel.Size = new System.Drawing.Size(161, 24);
            overalWorkforceLabel.TabIndex = 20;
            overalWorkforceLabel.Text = "Overal Workforce:";
            // 
            // jobPosting_Label
            // 
            jobPosting_Label.AutoSize = true;
            jobPosting_Label.Location = new System.Drawing.Point(42, 430);
            jobPosting_Label.Name = "jobPosting_Label";
            jobPosting_Label.Size = new System.Drawing.Size(118, 24);
            jobPosting_Label.TabIndex = 22;
            jobPosting_Label.Text = "Job Posting :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblReturn);
            this.panel1.Controls.Add(iDLabel);
            this.panel1.Controls.Add(this.iDTextBox);
            this.panel1.Controls.Add(stateNameLabel);
            this.panel1.Controls.Add(this.stateNameTextBox);
            this.panel1.Controls.Add(stateCapitalLabel);
            this.panel1.Controls.Add(this.stateCapitalTextBox);
            this.panel1.Controls.Add(statePopulationLabel);
            this.panel1.Controls.Add(this.statePopulationTextBox);
            this.panel1.Controls.Add(stateLargestCityLabel);
            this.panel1.Controls.Add(this.stateLargestCityTextBox);
            this.panel1.Controls.Add(stateBirdLabel);
            this.panel1.Controls.Add(this.stateBirdTextBox);
            this.panel1.Controls.Add(stateFlowerLabel);
            this.panel1.Controls.Add(this.stateFlowerTextBox);
            this.panel1.Controls.Add(stateColorsLabel);
            this.panel1.Controls.Add(this.stateColorsTextBox);
            this.panel1.Controls.Add(stateFlagInfoLabel);
            this.panel1.Controls.Add(this.stateFlagInfoTextBox);
            this.panel1.Controls.Add(stateMedianIncomeLabel);
            this.panel1.Controls.Add(this.stateMedianIncomeTextBox);
            this.panel1.Controls.Add(overalWorkforceLabel);
            this.panel1.Controls.Add(this.overalWorkforceTextBox);
            this.panel1.Controls.Add(jobPosting_Label);
            this.panel1.Controls.Add(this.jobPosting_TextBox);
            this.panel1.Location = new System.Drawing.Point(230, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 533);
            this.panel1.TabIndex = 0;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(860, 0);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(24, 24);
            this.lblReturn.TabIndex = 24;
            this.lblReturn.Text = "X";
            this.toolTip1.SetToolTip(this.lblReturn, "Click X to return back to Main");
            this.lblReturn.Click += new System.EventHandler(this.lblReturn_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(240, 22);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(73, 28);
            this.iDTextBox.TabIndex = 1;
            
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.statesDBDataSet;
            // 
            // statesDBDataSet
            // 
            this.statesDBDataSet.DataSetName = "statesDBDataSet";
            this.statesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stateNameTextBox
            // 
            this.stateNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "StateName", true));
            this.stateNameTextBox.Location = new System.Drawing.Point(240, 80);
            this.stateNameTextBox.Name = "stateNameTextBox";
            this.stateNameTextBox.Size = new System.Drawing.Size(304, 28);
            this.stateNameTextBox.TabIndex = 3;
            // 
            // stateCapitalTextBox
            // 
            this.stateCapitalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "StateCapital", true));
            this.stateCapitalTextBox.Location = new System.Drawing.Point(240, 114);
            this.stateCapitalTextBox.Name = "stateCapitalTextBox";
            this.stateCapitalTextBox.Size = new System.Drawing.Size(304, 28);
            this.stateCapitalTextBox.TabIndex = 5;
            // 
            // statePopulationTextBox
            // 
            this.statePopulationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "StatePopulation", true));
            this.statePopulationTextBox.Location = new System.Drawing.Point(240, 148);
            this.statePopulationTextBox.Name = "statePopulationTextBox";
            this.statePopulationTextBox.Size = new System.Drawing.Size(304, 28);
            this.statePopulationTextBox.TabIndex = 7;
            // 
            // stateLargestCityTextBox
            // 
            this.stateLargestCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "StateLargestCity", true));
            this.stateLargestCityTextBox.Location = new System.Drawing.Point(240, 182);
            this.stateLargestCityTextBox.Name = "stateLargestCityTextBox";
            this.stateLargestCityTextBox.Size = new System.Drawing.Size(624, 28);
            this.stateLargestCityTextBox.TabIndex = 9;
            // 
            // stateBirdTextBox
            // 
            this.stateBirdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "StateBird", true));
            this.stateBirdTextBox.Location = new System.Drawing.Point(240, 216);
            this.stateBirdTextBox.Name = "stateBirdTextBox";
            this.stateBirdTextBox.Size = new System.Drawing.Size(304, 28);
            this.stateBirdTextBox.TabIndex = 11;
            // 
            // stateFlowerTextBox
            // 
            this.stateFlowerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "StateFlower", true));
            this.stateFlowerTextBox.Location = new System.Drawing.Point(240, 250);
            this.stateFlowerTextBox.Name = "stateFlowerTextBox";
            this.stateFlowerTextBox.Size = new System.Drawing.Size(304, 28);
            this.stateFlowerTextBox.TabIndex = 13;
            // 
            // stateColorsTextBox
            // 
            this.stateColorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "StateColors", true));
            this.stateColorsTextBox.Location = new System.Drawing.Point(240, 284);
            this.stateColorsTextBox.Name = "stateColorsTextBox";
            this.stateColorsTextBox.Size = new System.Drawing.Size(624, 28);
            this.stateColorsTextBox.TabIndex = 15;
            // 
            // stateFlagInfoTextBox
            // 
            this.stateFlagInfoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "StateFlagInfo", true));
            this.stateFlagInfoTextBox.Location = new System.Drawing.Point(240, 323);
            this.stateFlagInfoTextBox.Name = "stateFlagInfoTextBox";
            this.stateFlagInfoTextBox.Size = new System.Drawing.Size(624, 28);
            this.stateFlagInfoTextBox.TabIndex = 17;
            // 
            // stateMedianIncomeTextBox
            // 
            this.stateMedianIncomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "StateMedianIncome", true));
            this.stateMedianIncomeTextBox.Location = new System.Drawing.Point(240, 359);
            this.stateMedianIncomeTextBox.Name = "stateMedianIncomeTextBox";
            this.stateMedianIncomeTextBox.Size = new System.Drawing.Size(304, 28);
            this.stateMedianIncomeTextBox.TabIndex = 19;
            // 
            // overalWorkforceTextBox
            // 
            this.overalWorkforceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "OveralWorkforce", true));
            this.overalWorkforceTextBox.Location = new System.Drawing.Point(240, 393);
            this.overalWorkforceTextBox.Name = "overalWorkforceTextBox";
            this.overalWorkforceTextBox.Size = new System.Drawing.Size(304, 28);
            this.overalWorkforceTextBox.TabIndex = 21;
            // 
            // jobPosting_TextBox
            // 
            this.jobPosting_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "JobPosting ", true));
            this.jobPosting_TextBox.Location = new System.Drawing.Point(240, 427);
            this.jobPosting_TextBox.Name = "jobPosting_TextBox";
            this.jobPosting_TextBox.Size = new System.Drawing.Size(304, 28);
            this.jobPosting_TextBox.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(25, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 493);
            this.panel2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.statesBindingSource;
            this.listBox1.DisplayMember = "StateName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(8, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(162, 466);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select State:";
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StatesTableAdapter = this.statesTableAdapter;
            this.tableAdapterManager.UpdateOrder = gvang_CPT_206_StateApp2.statesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // statesBindingNavigator
            // 
            this.statesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.statesBindingNavigator.BindingSource = this.statesBindingSource;
            this.statesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.statesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.statesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.statesBindingNavigatorSaveItem});
            this.statesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.statesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.statesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.statesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.statesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.statesBindingNavigator.Name = "statesBindingNavigator";
            this.statesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.statesBindingNavigator.Size = new System.Drawing.Size(1140, 27);
            this.statesBindingNavigator.TabIndex = 3;
            this.statesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // statesBindingNavigatorSaveItem
            // 
            this.statesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.statesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("statesBindingNavigatorSaveItem.Image")));
            this.statesBindingNavigatorSaveItem.Name = "statesBindingNavigatorSaveItem";
            this.statesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.statesBindingNavigatorSaveItem.Text = "Save Data";
            this.statesBindingNavigatorSaveItem.Click += new System.EventHandler(this.statesBindingNavigatorSaveItem_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1140, 590);
            this.Controls.Add(this.statesBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StateView";
            this.Load += new System.EventHandler(this.View_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesDBDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).EndInit();
            this.statesBindingNavigator.ResumeLayout(false);
            this.statesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private statesDBDataSet statesDBDataSet;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private statesDBDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private statesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator statesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton statesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox stateNameTextBox;
        private System.Windows.Forms.TextBox stateCapitalTextBox;
        private System.Windows.Forms.TextBox statePopulationTextBox;
        private System.Windows.Forms.TextBox stateLargestCityTextBox;
        private System.Windows.Forms.TextBox stateBirdTextBox;
        private System.Windows.Forms.TextBox stateFlowerTextBox;
        private System.Windows.Forms.TextBox stateColorsTextBox;
        private System.Windows.Forms.TextBox stateFlagInfoTextBox;
        private System.Windows.Forms.TextBox stateMedianIncomeTextBox;
        private System.Windows.Forms.TextBox overalWorkforceTextBox;
        private System.Windows.Forms.TextBox jobPosting_TextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}