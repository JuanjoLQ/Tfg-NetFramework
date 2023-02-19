﻿using System.Windows.Forms;

namespace Tfg_NetFramework
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.containerModulos = new System.Windows.Forms.Panel();
            this.pGestDietas = new System.Windows.Forms.Panel();
            this.btnGestDietas = new System.Windows.Forms.Button();
            this.pSoliDietas = new System.Windows.Forms.Panel();
            this.btnSolDietas = new System.Windows.Forms.Button();
            this.pGestionUsers = new System.Windows.Forms.Panel();
            this.btnGestUsers = new System.Windows.Forms.Button();
            this.pCrm = new System.Windows.Forms.Panel();
            this.btnCRM = new System.Windows.Forms.Button();
            this.pAux = new System.Windows.Forms.Panel();
            this.btnModuleAux = new System.Windows.Forms.Button();
            this.btnSubMenu = new System.Windows.Forms.Button();
            this.pSettings = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pMenu = new System.Windows.Forms.Panel();
            this.lbMenu = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.timerSubMenu = new System.Windows.Forms.Timer(this.components);
            this.pHeader = new System.Windows.Forms.Panel();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSalirHome = new System.Windows.Forms.Button();
            this.pSolicitudDieta = new System.Windows.Forms.Panel();
            this.lbReqAllowancesOptions = new System.Windows.Forms.Label();
            this.cbSolicitudDietas = new System.Windows.Forms.ComboBox();
            this.lbTitleSolDieta = new System.Windows.Forms.Label();
            this.pSolKilometraje = new System.Windows.Forms.Panel();
            this.btnSolDietasSolKilometraje = new System.Windows.Forms.Button();
            this.lbMileageTitle = new System.Windows.Forms.Label();
            this.dtpReqDietasMileageDate = new System.Windows.Forms.DateTimePicker();
            this.cbReqMileageSubCategory = new System.Windows.Forms.ComboBox();
            this.lbTitleMileage = new System.Windows.Forms.Label();
            this.lbReqMileageDate = new System.Windows.Forms.Label();
            this.lbReqMileageSubcategory = new System.Windows.Forms.Label();
            this.lbReqMileageOrigin = new System.Windows.Forms.Label();
            this.lbReqMileageDestination = new System.Windows.Forms.Label();
            this.lbReqMileageTotal = new System.Windows.Forms.Label();
            this.lbReqMileagePricePerKilometer = new System.Windows.Forms.Label();
            this.lbReqMileage = new System.Windows.Forms.Label();
            this.pSolSolicitudDietas = new System.Windows.Forms.Panel();
            this.labelURL = new System.Windows.Forms.Label();
            this.lbReqAllowancesEndHour = new System.Windows.Forms.Label();
            this.lbReqAllowancesStartHour = new System.Windows.Forms.Label();
            this.mtbReqAllowancesEndHour = new System.Windows.Forms.MaskedTextBox();
            this.mtbReqAllowancesStartHour = new System.Windows.Forms.MaskedTextBox();
            this.lbReqAllowancesTitleAllowances = new System.Windows.Forms.Label();
            this.lbReqAllowancesTitle = new System.Windows.Forms.Label();
            this.lbReqAllowancesObservations = new System.Windows.Forms.Label();
            this.thumbNailInvoice = new System.Windows.Forms.PictureBox();
            this.btnRequestAllowances = new System.Windows.Forms.Button();
            this.btnReqAllowancesUploadFile = new System.Windows.Forms.Button();
            this.dtpReqAllowancesStartTime = new System.Windows.Forms.DateTimePicker();
            this.lbReqAllowancesDate = new System.Windows.Forms.Label();
            this.pGestionDietas = new System.Windows.Forms.Panel();
            this.lbManAllowancesOptions = new System.Windows.Forms.Label();
            this.cbGestDietas = new System.Windows.Forms.ComboBox();
            this.lbManAllowances = new System.Windows.Forms.Label();
            this.pGestDietasKilometraje = new System.Windows.Forms.Panel();
            this.btnManMileageRemoveMileage = new System.Windows.Forms.Button();
            this.lbManMileageIdMileage = new System.Windows.Forms.Label();
            this.btnManMileageRefreshDgvMileage = new System.Windows.Forms.Button();
            this.btnManMileageUpdateStateMileage = new System.Windows.Forms.Button();
            this.lbManMileageNewState = new System.Windows.Forms.Label();
            this.cbManMileageNewState = new System.Windows.Forms.ComboBox();
            this.lbManMileageKilometers = new System.Windows.Forms.Label();
            this.lbManMileageState = new System.Windows.Forms.Label();
            this.lbManMileagePricePerKilometer = new System.Windows.Forms.Label();
            this.lbManMileageFinal = new System.Windows.Forms.Label();
            this.lbManMileageDate = new System.Windows.Forms.Label();
            this.lbManMileageSubcategory = new System.Windows.Forms.Label();
            this.lbManMileageOrigin = new System.Windows.Forms.Label();
            this.lbManMileageDestination = new System.Windows.Forms.Label();
            this.lbManMileageTitle = new System.Windows.Forms.Label();
            this.lbManMileageEmail = new System.Windows.Forms.Label();
            this.lbTitleManMileage = new System.Windows.Forms.Label();
            this.dgvMileage = new System.Windows.Forms.DataGridView();
            this.idMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerKilometer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pGestDietasDietas = new System.Windows.Forms.Panel();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.btnManAllowancesAllowanceRemove = new System.Windows.Forms.Button();
            this.lbManAllowancesIdAllowance = new System.Windows.Forms.Label();
            this.btnManAllowancesUpdateData = new System.Windows.Forms.Button();
            this.lbManAllowancesNewState = new System.Windows.Forms.Label();
            this.cbStateDietas = new System.Windows.Forms.ComboBox();
            this.btnManAllowancesDietasRefresh = new System.Windows.Forms.Button();
            this.lbManAllowancesObservations = new System.Windows.Forms.Label();
            this.lbManAllowancesDate = new System.Windows.Forms.Label();
            this.lbManAllowancesStartHour = new System.Windows.Forms.Label();
            this.lbManAllowancesEndHour = new System.Windows.Forms.Label();
            this.lbManAllowancesState = new System.Windows.Forms.Label();
            this.lbManAllowancesTitle = new System.Windows.Forms.Label();
            this.lbManAllowancesEmail = new System.Windows.Forms.Label();
            this.dgvAllowances = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice = new System.Windows.Forms.DataGridViewButtonColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTitleManAllowance = new System.Windows.Forms.Label();
            this.pUsuarios = new System.Windows.Forms.Panel();
            this.btnEliminarUser = new System.Windows.Forms.Button();
            this.btnUpdateDtgUsers = new System.Windows.Forms.Button();
            this.lbJob = new System.Windows.Forms.Label();
            this.lbIdUser = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbGestUsers = new System.Windows.Forms.Label();
            this.pRegister = new System.Windows.Forms.Panel();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnRRegistrar = new System.Windows.Forms.Button();
            this.lbRegisterUser = new System.Windows.Forms.Label();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.opfSeleccionarArchivo = new System.Windows.Forms.OpenFileDialog();
            this.pCRMGest = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pipeline = new System.Windows.Forms.TabPage();
            this.btnUpdateFlps = new System.Windows.Forms.Button();
            this.btnPipelineAddLead = new System.Windows.Forms.Button();
            this.flpWon = new System.Windows.Forms.FlowLayoutPanel();
            this.lbWon = new System.Windows.Forms.Label();
            this.lbProposition = new System.Windows.Forms.Label();
            this.lbQualified = new System.Windows.Forms.Label();
            this.lbNew = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flpProposition = new System.Windows.Forms.FlowLayoutPanel();
            this.flpQualified = new System.Windows.Forms.FlowLayoutPanel();
            this.flpNew = new System.Windows.Forms.FlowLayoutPanel();
            this.Customers = new System.Windows.Forms.TabPage();
            this.lbDateEnd = new System.Windows.Forms.Label();
            this.lbDateStart = new System.Windows.Forms.Label();
            this.dgvCustomer_Lead = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbLeadName = new System.Windows.Forms.Label();
            this.btnMoreInfoCustomer = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdateDgvCustomer = new System.Windows.Forms.Button();
            this.btnCustomersRemoveCustomers = new System.Windows.Forms.Button();
            this.btnCustomersAddCustomers = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teams = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.teamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.teamLeads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamOpenLeads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamLostTeams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamLostLeads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamWonLeads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.pSettingsModule = new System.Windows.Forms.Panel();
            this.btnRestoreBackup = new System.Windows.Forms.Button();
            this.btnSettingsSaveBackup = new System.Windows.Forms.Button();
            this.lbSettings = new System.Windows.Forms.Label();
            this.tbReqMileagePricePerKilometer = new Tfg_NetFramework.tbPlaceHolder();
            this.tbReqMileageTotal = new Tfg_NetFramework.tbPlaceHolder();
            this.tbReqMileageDestination = new Tfg_NetFramework.tbPlaceHolder();
            this.tbReqMileageOrigin = new Tfg_NetFramework.tbPlaceHolder();
            this.tbReqMileageTitle = new Tfg_NetFramework.tbPlaceHolder();
            this.tbReqMileageMileage = new Tfg_NetFramework.tbPlaceHolder();
            this.tbReqAllowancesObservations = new Tfg_NetFramework.tbPlaceHolder();
            this.tbReqAllowancesTitle = new Tfg_NetFramework.tbPlaceHolder();
            this.tbEmail = new Tfg_NetFramework.tbPlaceHolder();
            this.tbIdUser = new Tfg_NetFramework.tbPlaceHolder();
            this.tbOcupacion = new Tfg_NetFramework.tbPlaceHolder();
            this.tbDepartment = new Tfg_NetFramework.tbPlaceHolder();
            this.tbPassword = new Tfg_NetFramework.tbPlaceHolder();
            this.tbRPassword = new Tfg_NetFramework.tbPlaceHolder();
            this.tbREmail = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManAllowancesEmail = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManAllowancesTitle = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManAllowancesObservations = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManAllowancesDate = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManAllowancesStartHour = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManAllowancesEndHour = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManAllowancesState = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManAllowancesIdAllowance = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManMileageEmail = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManMileageTitle = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManMileageDate = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManMileageSubcategory = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManMileageIdMileage = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManMileageOrigin = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManMileageDestination = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManMileageKilometers = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManMileagePricePerKilometer = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManMileageFinal = new Tfg_NetFramework.tbPlaceHolder();
            this.tbManMileageState = new Tfg_NetFramework.tbPlaceHolder();
            this.sidebar.SuspendLayout();
            this.pHome.SuspendLayout();
            this.containerModulos.SuspendLayout();
            this.pGestDietas.SuspendLayout();
            this.pSoliDietas.SuspendLayout();
            this.pGestionUsers.SuspendLayout();
            this.pCrm.SuspendLayout();
            this.pAux.SuspendLayout();
            this.pSettings.SuspendLayout();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.pHeader.SuspendLayout();
            this.pSolicitudDieta.SuspendLayout();
            this.pSolKilometraje.SuspendLayout();
            this.pSolSolicitudDietas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbNailInvoice)).BeginInit();
            this.pGestionDietas.SuspendLayout();
            this.pGestDietasKilometraje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMileage)).BeginInit();
            this.pGestDietasDietas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllowances)).BeginInit();
            this.pUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.pRegister.SuspendLayout();
            this.pCRMGest.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pipeline.SuspendLayout();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer_Lead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.teams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.pSettingsModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.sidebar.Controls.Add(this.pHome);
            this.sidebar.Controls.Add(this.containerModulos);
            this.sidebar.Controls.Add(this.pSettings);
            this.sidebar.Controls.Add(this.btnSalir);
            this.sidebar.Location = new System.Drawing.Point(0, 59);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sidebar.MaximumSize = new System.Drawing.Size(257, 733);
            this.sidebar.MinimumSize = new System.Drawing.Size(73, 729);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(165, 729);
            this.sidebar.TabIndex = 0;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pHome
            // 
            this.pHome.BackColor = System.Drawing.Color.Transparent;
            this.pHome.Controls.Add(this.btnHome);
            this.pHome.Location = new System.Drawing.Point(3, 1);
            this.pHome.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(206, 53);
            this.pHome.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-3, -12);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(211, 80);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // containerModulos
            // 
            this.containerModulos.BackColor = System.Drawing.Color.Transparent;
            this.containerModulos.Controls.Add(this.pGestDietas);
            this.containerModulos.Controls.Add(this.pSoliDietas);
            this.containerModulos.Controls.Add(this.pGestionUsers);
            this.containerModulos.Controls.Add(this.pCrm);
            this.containerModulos.Controls.Add(this.pAux);
            this.containerModulos.Controls.Add(this.btnSubMenu);
            this.containerModulos.Location = new System.Drawing.Point(3, 56);
            this.containerModulos.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.containerModulos.MaximumSize = new System.Drawing.Size(206, 380);
            this.containerModulos.MinimumSize = new System.Drawing.Size(206, 67);
            this.containerModulos.Name = "containerModulos";
            this.containerModulos.Size = new System.Drawing.Size(206, 373);
            this.containerModulos.TabIndex = 2;
            // 
            // pGestDietas
            // 
            this.pGestDietas.Controls.Add(this.btnGestDietas);
            this.pGestDietas.Location = new System.Drawing.Point(1, 183);
            this.pGestDietas.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pGestDietas.Name = "pGestDietas";
            this.pGestDietas.Size = new System.Drawing.Size(205, 60);
            this.pGestDietas.TabIndex = 12;
            this.pGestDietas.Visible = false;
            // 
            // btnGestDietas
            // 
            this.btnGestDietas.BackColor = System.Drawing.Color.Transparent;
            this.btnGestDietas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestDietas.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnGestDietas.ForeColor = System.Drawing.Color.White;
            this.btnGestDietas.Image = ((System.Drawing.Image)(resources.GetObject("btnGestDietas.Image")));
            this.btnGestDietas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestDietas.Location = new System.Drawing.Point(-5, -17);
            this.btnGestDietas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGestDietas.Name = "btnGestDietas";
            this.btnGestDietas.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnGestDietas.Size = new System.Drawing.Size(219, 80);
            this.btnGestDietas.TabIndex = 11;
            this.btnGestDietas.Text = "           Gest. \r\n           Dietas";
            this.btnGestDietas.UseVisualStyleBackColor = false;
            this.btnGestDietas.Click += new System.EventHandler(this.btnGestDietas_Click);
            // 
            // pSoliDietas
            // 
            this.pSoliDietas.Controls.Add(this.btnSolDietas);
            this.pSoliDietas.Location = new System.Drawing.Point(1, 124);
            this.pSoliDietas.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pSoliDietas.Name = "pSoliDietas";
            this.pSoliDietas.Size = new System.Drawing.Size(205, 60);
            this.pSoliDietas.TabIndex = 8;
            this.pSoliDietas.Visible = false;
            // 
            // btnSolDietas
            // 
            this.btnSolDietas.BackColor = System.Drawing.Color.Transparent;
            this.btnSolDietas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolDietas.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnSolDietas.ForeColor = System.Drawing.Color.White;
            this.btnSolDietas.Image = ((System.Drawing.Image)(resources.GetObject("btnSolDietas.Image")));
            this.btnSolDietas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolDietas.Location = new System.Drawing.Point(-5, -16);
            this.btnSolDietas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSolDietas.Name = "btnSolDietas";
            this.btnSolDietas.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnSolDietas.Size = new System.Drawing.Size(219, 80);
            this.btnSolDietas.TabIndex = 11;
            this.btnSolDietas.Text = "            Sol. \r\n            Dietas";
            this.btnSolDietas.UseVisualStyleBackColor = false;
            this.btnSolDietas.Click += new System.EventHandler(this.btnSolDietas_Click);
            // 
            // pGestionUsers
            // 
            this.pGestionUsers.Controls.Add(this.btnGestUsers);
            this.pGestionUsers.Location = new System.Drawing.Point(0, 65);
            this.pGestionUsers.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pGestionUsers.Name = "pGestionUsers";
            this.pGestionUsers.Size = new System.Drawing.Size(206, 60);
            this.pGestionUsers.TabIndex = 9;
            this.pGestionUsers.Visible = false;
            // 
            // btnGestUsers
            // 
            this.btnGestUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnGestUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestUsers.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnGestUsers.ForeColor = System.Drawing.Color.White;
            this.btnGestUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnGestUsers.Image")));
            this.btnGestUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestUsers.Location = new System.Drawing.Point(-3, -12);
            this.btnGestUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGestUsers.Name = "btnGestUsers";
            this.btnGestUsers.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnGestUsers.Size = new System.Drawing.Size(219, 80);
            this.btnGestUsers.TabIndex = 6;
            this.btnGestUsers.Text = "             Gest. Users";
            this.btnGestUsers.UseVisualStyleBackColor = false;
            this.btnGestUsers.Click += new System.EventHandler(this.btnGestUser_Click);
            // 
            // pCrm
            // 
            this.pCrm.BackColor = System.Drawing.SystemColors.Highlight;
            this.pCrm.Controls.Add(this.btnCRM);
            this.pCrm.Location = new System.Drawing.Point(2, 243);
            this.pCrm.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pCrm.Name = "pCrm";
            this.pCrm.Size = new System.Drawing.Size(255, 63);
            this.pCrm.TabIndex = 31;
            // 
            // btnCRM
            // 
            this.btnCRM.BackColor = System.Drawing.Color.Transparent;
            this.btnCRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCRM.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnCRM.ForeColor = System.Drawing.Color.White;
            this.btnCRM.Image = ((System.Drawing.Image)(resources.GetObject("btnCRM.Image")));
            this.btnCRM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCRM.Location = new System.Drawing.Point(-7, -12);
            this.btnCRM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCRM.Name = "btnCRM";
            this.btnCRM.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnCRM.Size = new System.Drawing.Size(219, 80);
            this.btnCRM.TabIndex = 12;
            this.btnCRM.Text = "           CRM";
            this.btnCRM.UseVisualStyleBackColor = false;
            this.btnCRM.Click += new System.EventHandler(this.btnCRM_Click);
            // 
            // pAux
            // 
            this.pAux.BackColor = System.Drawing.Color.IndianRed;
            this.pAux.Controls.Add(this.btnModuleAux);
            this.pAux.Location = new System.Drawing.Point(2, 306);
            this.pAux.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pAux.Name = "pAux";
            this.pAux.Size = new System.Drawing.Size(256, 65);
            this.pAux.TabIndex = 12;
            // 
            // btnModuleAux
            // 
            this.btnModuleAux.BackColor = System.Drawing.Color.IndianRed;
            this.btnModuleAux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModuleAux.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnModuleAux.ForeColor = System.Drawing.Color.White;
            this.btnModuleAux.Image = ((System.Drawing.Image)(resources.GetObject("btnModuleAux.Image")));
            this.btnModuleAux.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModuleAux.Location = new System.Drawing.Point(-7, -6);
            this.btnModuleAux.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModuleAux.Name = "btnModuleAux";
            this.btnModuleAux.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnModuleAux.Size = new System.Drawing.Size(219, 80);
            this.btnModuleAux.TabIndex = 11;
            this.btnModuleAux.Text = "            Module \r\n            Aux";
            this.btnModuleAux.UseVisualStyleBackColor = false;
            // 
            // btnSubMenu
            // 
            this.btnSubMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenu.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnSubMenu.ForeColor = System.Drawing.Color.White;
            this.btnSubMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnSubMenu.Image")));
            this.btnSubMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenu.Location = new System.Drawing.Point(-10, -7);
            this.btnSubMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubMenu.Name = "btnSubMenu";
            this.btnSubMenu.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnSubMenu.Size = new System.Drawing.Size(225, 80);
            this.btnSubMenu.TabIndex = 8;
            this.btnSubMenu.Text = "     Módulos";
            this.btnSubMenu.UseVisualStyleBackColor = false;
            this.btnSubMenu.Click += new System.EventHandler(this.btnSubMenu_Click);
            // 
            // pSettings
            // 
            this.pSettings.BackColor = System.Drawing.Color.Transparent;
            this.pSettings.Controls.Add(this.btnSettings);
            this.pSettings.Location = new System.Drawing.Point(3, 431);
            this.pSettings.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pSettings.Name = "pSettings";
            this.pSettings.Size = new System.Drawing.Size(206, 53);
            this.pSettings.TabIndex = 3;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(-3, -12);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(211, 80);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(3, 487);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(62, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.lbMenu);
            this.pMenu.Controls.Add(this.btnMenu);
            this.pMenu.Location = new System.Drawing.Point(15, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(194, 77);
            this.pMenu.TabIndex = 0;
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.lbMenu.Location = new System.Drawing.Point(77, 28);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(61, 24);
            this.lbMenu.TabIndex = 1;
            this.lbMenu.Text = "Menu";
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.InitialImage")));
            this.btnMenu.Location = new System.Drawing.Point(10, 13);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(48, 56);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // timerSubMenu
            // 
            this.timerSubMenu.Interval = 20;
            this.timerSubMenu.Tick += new System.EventHandler(this.timerSubMenu_Tick);
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(205)))));
            this.pHeader.Controls.Add(this.lbUser);
            this.pHeader.Controls.Add(this.lbRole);
            this.pHeader.Controls.Add(this.lbTitle);
            this.pHeader.Controls.Add(this.btnSalirHome);
            this.pHeader.Controls.Add(this.pMenu);
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1232, 58);
            this.pHeader.TabIndex = 1;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(1267, 57);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(55, 15);
            this.lbUser.TabIndex = 3;
            this.lbUser.Text = "labelUser";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Location = new System.Drawing.Point(1267, 27);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(51, 13);
            this.lbRole.TabIndex = 2;
            this.lbRole.Text = "labelRole";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(114)))));
            this.lbTitle.Location = new System.Drawing.Point(698, 28);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(146, 31);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Home Page";
            // 
            // btnSalirHome
            // 
            this.btnSalirHome.Location = new System.Drawing.Point(242, 13);
            this.btnSalirHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalirHome.Name = "btnSalirHome";
            this.btnSalirHome.Size = new System.Drawing.Size(165, 47);
            this.btnSalirHome.TabIndex = 4;
            this.btnSalirHome.Text = "Salir";
            this.btnSalirHome.UseVisualStyleBackColor = true;
            this.btnSalirHome.Click += new System.EventHandler(this.btnSalirHome_Click);
            // 
            // pSolicitudDieta
            // 
            this.pSolicitudDieta.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pSolicitudDieta.Controls.Add(this.lbReqAllowancesOptions);
            this.pSolicitudDieta.Controls.Add(this.cbSolicitudDietas);
            this.pSolicitudDieta.Controls.Add(this.lbTitleSolDieta);
            this.pSolicitudDieta.Controls.Add(this.pSolKilometraje);
            this.pSolicitudDieta.Controls.Add(this.pSolSolicitudDietas);
            this.pSolicitudDieta.Location = new System.Drawing.Point(166, 61);
            this.pSolicitudDieta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pSolicitudDieta.Name = "pSolicitudDieta";
            this.pSolicitudDieta.Size = new System.Drawing.Size(1066, 582);
            this.pSolicitudDieta.TabIndex = 4;
            this.pSolicitudDieta.Visible = false;
            // 
            // lbReqAllowancesOptions
            // 
            this.lbReqAllowancesOptions.AutoSize = true;
            this.lbReqAllowancesOptions.Location = new System.Drawing.Point(138, 22);
            this.lbReqAllowancesOptions.Name = "lbReqAllowancesOptions";
            this.lbReqAllowancesOptions.Size = new System.Drawing.Size(85, 13);
            this.lbReqAllowancesOptions.TabIndex = 13;
            this.lbReqAllowancesOptions.Text = "Elija una opción:";
            // 
            // cbSolicitudDietas
            // 
            this.cbSolicitudDietas.FormattingEnabled = true;
            this.cbSolicitudDietas.Items.AddRange(new object[] {
            "Dietas",
            "Kilometraje"});
            this.cbSolicitudDietas.Location = new System.Drawing.Point(251, 19);
            this.cbSolicitudDietas.Name = "cbSolicitudDietas";
            this.cbSolicitudDietas.Size = new System.Drawing.Size(115, 21);
            this.cbSolicitudDietas.TabIndex = 1;
            this.cbSolicitudDietas.SelectionChangeCommitted += new System.EventHandler(this.cbSolicitudDietas_SelectionChangeCommitted);
            // 
            // lbTitleSolDieta
            // 
            this.lbTitleSolDieta.AutoSize = true;
            this.lbTitleSolDieta.Location = new System.Drawing.Point(21, 12);
            this.lbTitleSolDieta.Name = "lbTitleSolDieta";
            this.lbTitleSolDieta.Size = new System.Drawing.Size(93, 13);
            this.lbTitleSolDieta.TabIndex = 0;
            this.lbTitleSolDieta.Text = "Solicitud de dietas";
            // 
            // pSolKilometraje
            // 
            this.pSolKilometraje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pSolKilometraje.Controls.Add(this.tbReqMileagePricePerKilometer);
            this.pSolKilometraje.Controls.Add(this.tbReqMileageTotal);
            this.pSolKilometraje.Controls.Add(this.tbReqMileageDestination);
            this.pSolKilometraje.Controls.Add(this.tbReqMileageOrigin);
            this.pSolKilometraje.Controls.Add(this.tbReqMileageTitle);
            this.pSolKilometraje.Controls.Add(this.tbReqMileageMileage);
            this.pSolKilometraje.Controls.Add(this.btnSolDietasSolKilometraje);
            this.pSolKilometraje.Controls.Add(this.lbMileageTitle);
            this.pSolKilometraje.Controls.Add(this.dtpReqDietasMileageDate);
            this.pSolKilometraje.Controls.Add(this.cbReqMileageSubCategory);
            this.pSolKilometraje.Controls.Add(this.lbTitleMileage);
            this.pSolKilometraje.Controls.Add(this.lbReqMileageDate);
            this.pSolKilometraje.Controls.Add(this.lbReqMileageSubcategory);
            this.pSolKilometraje.Controls.Add(this.lbReqMileageOrigin);
            this.pSolKilometraje.Controls.Add(this.lbReqMileageDestination);
            this.pSolKilometraje.Controls.Add(this.lbReqMileageTotal);
            this.pSolKilometraje.Controls.Add(this.lbReqMileagePricePerKilometer);
            this.pSolKilometraje.Controls.Add(this.lbReqMileage);
            this.pSolKilometraje.Location = new System.Drawing.Point(21, 45);
            this.pSolKilometraje.Name = "pSolKilometraje";
            this.pSolKilometraje.Size = new System.Drawing.Size(459, 388);
            this.pSolKilometraje.TabIndex = 7;
            // 
            // btnSolDietasSolKilometraje
            // 
            this.btnSolDietasSolKilometraje.Location = new System.Drawing.Point(39, 293);
            this.btnSolDietasSolKilometraje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSolDietasSolKilometraje.Name = "btnSolDietasSolKilometraje";
            this.btnSolDietasSolKilometraje.Size = new System.Drawing.Size(127, 34);
            this.btnSolDietasSolKilometraje.TabIndex = 10;
            this.btnSolDietasSolKilometraje.Text = "Solicitar kilometraje";
            this.btnSolDietasSolKilometraje.UseVisualStyleBackColor = true;
            this.btnSolDietasSolKilometraje.Click += new System.EventHandler(this.btnSolDietasSolKilometraje_Click);
            // 
            // lbMileageTitle
            // 
            this.lbMileageTitle.AutoSize = true;
            this.lbMileageTitle.Location = new System.Drawing.Point(46, 7);
            this.lbMileageTitle.Name = "lbMileageTitle";
            this.lbMileageTitle.Size = new System.Drawing.Size(58, 13);
            this.lbMileageTitle.TabIndex = 29;
            this.lbMileageTitle.Text = "Kilometraje";
            // 
            // dtpReqDietasMileageDate
            // 
            this.dtpReqDietasMileageDate.CustomFormat = "dd/MM/yyyy";
            this.dtpReqDietasMileageDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReqDietasMileageDate.Location = new System.Drawing.Point(102, 105);
            this.dtpReqDietasMileageDate.Name = "dtpReqDietasMileageDate";
            this.dtpReqDietasMileageDate.Size = new System.Drawing.Size(93, 20);
            this.dtpReqDietasMileageDate.TabIndex = 4;
            this.dtpReqDietasMileageDate.Value = new System.DateTime(2022, 12, 18, 0, 0, 0, 0);
            // 
            // cbReqMileageSubCategory
            // 
            this.cbReqMileageSubCategory.FormattingEnabled = true;
            this.cbReqMileageSubCategory.Items.AddRange(new object[] {
            "Vehículo propio",
            "Vehículo empresa"});
            this.cbReqMileageSubCategory.Location = new System.Drawing.Point(102, 140);
            this.cbReqMileageSubCategory.Name = "cbReqMileageSubCategory";
            this.cbReqMileageSubCategory.Size = new System.Drawing.Size(94, 21);
            this.cbReqMileageSubCategory.TabIndex = 5;
            this.cbReqMileageSubCategory.SelectionChangeCommitted += new System.EventHandler(this.cbMileageSubCategory_SelectionChangeCommitted);
            // 
            // lbTitleMileage
            // 
            this.lbTitleMileage.AutoSize = true;
            this.lbTitleMileage.Location = new System.Drawing.Point(1, 75);
            this.lbTitleMileage.Name = "lbTitleMileage";
            this.lbTitleMileage.Size = new System.Drawing.Size(35, 13);
            this.lbTitleMileage.TabIndex = 14;
            this.lbTitleMileage.Text = "Título";
            // 
            // lbReqMileageDate
            // 
            this.lbReqMileageDate.AutoSize = true;
            this.lbReqMileageDate.Location = new System.Drawing.Point(6, 111);
            this.lbReqMileageDate.Name = "lbReqMileageDate";
            this.lbReqMileageDate.Size = new System.Drawing.Size(37, 13);
            this.lbReqMileageDate.TabIndex = 15;
            this.lbReqMileageDate.Text = "Fecha";
            // 
            // lbReqMileageSubcategory
            // 
            this.lbReqMileageSubcategory.AutoSize = true;
            this.lbReqMileageSubcategory.Location = new System.Drawing.Point(1, 144);
            this.lbReqMileageSubcategory.Name = "lbReqMileageSubcategory";
            this.lbReqMileageSubcategory.Size = new System.Drawing.Size(67, 13);
            this.lbReqMileageSubcategory.TabIndex = 16;
            this.lbReqMileageSubcategory.Text = "Subcategory";
            // 
            // lbReqMileageOrigin
            // 
            this.lbReqMileageOrigin.AutoSize = true;
            this.lbReqMileageOrigin.Location = new System.Drawing.Point(6, 180);
            this.lbReqMileageOrigin.Name = "lbReqMileageOrigin";
            this.lbReqMileageOrigin.Size = new System.Drawing.Size(38, 13);
            this.lbReqMileageOrigin.TabIndex = 17;
            this.lbReqMileageOrigin.Text = "Origen";
            // 
            // lbReqMileageDestination
            // 
            this.lbReqMileageDestination.AutoSize = true;
            this.lbReqMileageDestination.Location = new System.Drawing.Point(6, 205);
            this.lbReqMileageDestination.Name = "lbReqMileageDestination";
            this.lbReqMileageDestination.Size = new System.Drawing.Size(43, 13);
            this.lbReqMileageDestination.TabIndex = 18;
            this.lbReqMileageDestination.Text = "Destino";
            // 
            // lbReqMileageTotal
            // 
            this.lbReqMileageTotal.AutoSize = true;
            this.lbReqMileageTotal.Location = new System.Drawing.Point(6, 233);
            this.lbReqMileageTotal.Name = "lbReqMileageTotal";
            this.lbReqMileageTotal.Size = new System.Drawing.Size(31, 13);
            this.lbReqMileageTotal.TabIndex = 19;
            this.lbReqMileageTotal.Text = "Total";
            // 
            // lbReqMileagePricePerKilometer
            // 
            this.lbReqMileagePricePerKilometer.AutoSize = true;
            this.lbReqMileagePricePerKilometer.Location = new System.Drawing.Point(6, 259);
            this.lbReqMileagePricePerKilometer.Name = "lbReqMileagePricePerKilometer";
            this.lbReqMileagePricePerKilometer.Size = new System.Drawing.Size(100, 13);
            this.lbReqMileagePricePerKilometer.TabIndex = 20;
            this.lbReqMileagePricePerKilometer.Text = "Precio por kilómetro";
            // 
            // lbReqMileage
            // 
            this.lbReqMileage.AutoSize = true;
            this.lbReqMileage.Location = new System.Drawing.Point(1, 36);
            this.lbReqMileage.Name = "lbReqMileage";
            this.lbReqMileage.Size = new System.Drawing.Size(58, 13);
            this.lbReqMileage.TabIndex = 14;
            this.lbReqMileage.Text = "Kilometraje";
            // 
            // pSolSolicitudDietas
            // 
            this.pSolSolicitudDietas.Controls.Add(this.tbReqAllowancesObservations);
            this.pSolSolicitudDietas.Controls.Add(this.tbReqAllowancesTitle);
            this.pSolSolicitudDietas.Controls.Add(this.labelURL);
            this.pSolSolicitudDietas.Controls.Add(this.lbReqAllowancesEndHour);
            this.pSolSolicitudDietas.Controls.Add(this.lbReqAllowancesStartHour);
            this.pSolSolicitudDietas.Controls.Add(this.mtbReqAllowancesEndHour);
            this.pSolSolicitudDietas.Controls.Add(this.mtbReqAllowancesStartHour);
            this.pSolSolicitudDietas.Controls.Add(this.lbReqAllowancesTitleAllowances);
            this.pSolSolicitudDietas.Controls.Add(this.lbReqAllowancesTitle);
            this.pSolSolicitudDietas.Controls.Add(this.lbReqAllowancesObservations);
            this.pSolSolicitudDietas.Controls.Add(this.thumbNailInvoice);
            this.pSolSolicitudDietas.Controls.Add(this.btnRequestAllowances);
            this.pSolSolicitudDietas.Controls.Add(this.btnReqAllowancesUploadFile);
            this.pSolSolicitudDietas.Controls.Add(this.dtpReqAllowancesStartTime);
            this.pSolSolicitudDietas.Controls.Add(this.lbReqAllowancesDate);
            this.pSolSolicitudDietas.Location = new System.Drawing.Point(21, 45);
            this.pSolSolicitudDietas.Name = "pSolSolicitudDietas";
            this.pSolSolicitudDietas.Size = new System.Drawing.Size(459, 388);
            this.pSolSolicitudDietas.TabIndex = 14;
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(196, 185);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(29, 13);
            this.labelURL.TabIndex = 18;
            this.labelURL.Text = "URL";
            // 
            // lbReqAllowancesEndHour
            // 
            this.lbReqAllowancesEndHour.AutoSize = true;
            this.lbReqAllowancesEndHour.Location = new System.Drawing.Point(190, 44);
            this.lbReqAllowancesEndHour.Name = "lbReqAllowancesEndHour";
            this.lbReqAllowancesEndHour.Size = new System.Drawing.Size(52, 13);
            this.lbReqAllowancesEndHour.TabIndex = 17;
            this.lbReqAllowancesEndHour.Text = "End Hour";
            // 
            // lbReqAllowancesStartHour
            // 
            this.lbReqAllowancesStartHour.AutoSize = true;
            this.lbReqAllowancesStartHour.Location = new System.Drawing.Point(190, 18);
            this.lbReqAllowancesStartHour.Name = "lbReqAllowancesStartHour";
            this.lbReqAllowancesStartHour.Size = new System.Drawing.Size(55, 13);
            this.lbReqAllowancesStartHour.TabIndex = 16;
            this.lbReqAllowancesStartHour.Text = "Start Hour";
            // 
            // mtbReqAllowancesEndHour
            // 
            this.mtbReqAllowancesEndHour.Location = new System.Drawing.Point(250, 42);
            this.mtbReqAllowancesEndHour.Mask = "00:00";
            this.mtbReqAllowancesEndHour.Name = "mtbReqAllowancesEndHour";
            this.mtbReqAllowancesEndHour.Size = new System.Drawing.Size(36, 20);
            this.mtbReqAllowancesEndHour.TabIndex = 5;
            this.mtbReqAllowancesEndHour.ValidatingType = typeof(System.DateTime);
            this.mtbReqAllowancesEndHour.Click += new System.EventHandler(this.mtbReqAllowancesEndHour_Click);
            this.mtbReqAllowancesEndHour.Leave += new System.EventHandler(this.mtbEndTime_Leave);
            // 
            // mtbReqAllowancesStartHour
            // 
            this.mtbReqAllowancesStartHour.Location = new System.Drawing.Point(250, 14);
            this.mtbReqAllowancesStartHour.Mask = "00:00";
            this.mtbReqAllowancesStartHour.Name = "mtbReqAllowancesStartHour";
            this.mtbReqAllowancesStartHour.Size = new System.Drawing.Size(36, 20);
            this.mtbReqAllowancesStartHour.TabIndex = 4;
            this.mtbReqAllowancesStartHour.ValidatingType = typeof(System.DateTime);
            this.mtbReqAllowancesStartHour.Click += new System.EventHandler(this.mtbStartTime_Click);
            this.mtbReqAllowancesStartHour.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbStartTime_KeyDown);
            this.mtbReqAllowancesStartHour.Leave += new System.EventHandler(this.mtbStartTime_Leave);
            // 
            // lbReqAllowancesTitleAllowances
            // 
            this.lbReqAllowancesTitleAllowances.AutoSize = true;
            this.lbReqAllowancesTitleAllowances.Location = new System.Drawing.Point(14, 10);
            this.lbReqAllowancesTitleAllowances.Name = "lbReqAllowancesTitleAllowances";
            this.lbReqAllowancesTitleAllowances.Size = new System.Drawing.Size(37, 13);
            this.lbReqAllowancesTitleAllowances.TabIndex = 13;
            this.lbReqAllowancesTitleAllowances.Text = "Dietas";
            // 
            // lbReqAllowancesTitle
            // 
            this.lbReqAllowancesTitle.AutoSize = true;
            this.lbReqAllowancesTitle.Location = new System.Drawing.Point(3, 46);
            this.lbReqAllowancesTitle.Name = "lbReqAllowancesTitle";
            this.lbReqAllowancesTitle.Size = new System.Drawing.Size(35, 13);
            this.lbReqAllowancesTitle.TabIndex = 9;
            this.lbReqAllowancesTitle.Text = "Título";
            // 
            // lbReqAllowancesObservations
            // 
            this.lbReqAllowancesObservations.AutoSize = true;
            this.lbReqAllowancesObservations.Location = new System.Drawing.Point(3, 75);
            this.lbReqAllowancesObservations.Name = "lbReqAllowancesObservations";
            this.lbReqAllowancesObservations.Size = new System.Drawing.Size(69, 13);
            this.lbReqAllowancesObservations.TabIndex = 4;
            this.lbReqAllowancesObservations.Text = "Observations";
            // 
            // thumbNailInvoice
            // 
            this.thumbNailInvoice.Location = new System.Drawing.Point(28, 180);
            this.thumbNailInvoice.Name = "thumbNailInvoice";
            this.thumbNailInvoice.Size = new System.Drawing.Size(135, 103);
            this.thumbNailInvoice.TabIndex = 12;
            this.thumbNailInvoice.TabStop = false;
            // 
            // btnRequestAllowances
            // 
            this.btnRequestAllowances.Location = new System.Drawing.Point(179, 318);
            this.btnRequestAllowances.Name = "btnRequestAllowances";
            this.btnRequestAllowances.Size = new System.Drawing.Size(135, 40);
            this.btnRequestAllowances.TabIndex = 8;
            this.btnRequestAllowances.Text = "Solicitar Dieta";
            this.btnRequestAllowances.UseVisualStyleBackColor = true;
            this.btnRequestAllowances.Click += new System.EventHandler(this.btnSolDieta_Click);
            // 
            // btnReqAllowancesUploadFile
            // 
            this.btnReqAllowancesUploadFile.Location = new System.Drawing.Point(179, 221);
            this.btnReqAllowancesUploadFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReqAllowancesUploadFile.Name = "btnReqAllowancesUploadFile";
            this.btnReqAllowancesUploadFile.Size = new System.Drawing.Size(121, 25);
            this.btnReqAllowancesUploadFile.TabIndex = 7;
            this.btnReqAllowancesUploadFile.Text = "Upload File";
            this.btnReqAllowancesUploadFile.UseVisualStyleBackColor = true;
            this.btnReqAllowancesUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // dtpReqAllowancesStartTime
            // 
            this.dtpReqAllowancesStartTime.CustomFormat = "dd/MM/yyyy";
            this.dtpReqAllowancesStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReqAllowancesStartTime.Location = new System.Drawing.Point(351, 18);
            this.dtpReqAllowancesStartTime.Name = "dtpReqAllowancesStartTime";
            this.dtpReqAllowancesStartTime.Size = new System.Drawing.Size(93, 20);
            this.dtpReqAllowancesStartTime.TabIndex = 6;
            this.dtpReqAllowancesStartTime.Value = new System.DateTime(2022, 12, 18, 0, 0, 0, 0);
            // 
            // lbReqAllowancesDate
            // 
            this.lbReqAllowancesDate.AutoSize = true;
            this.lbReqAllowancesDate.Location = new System.Drawing.Point(291, 22);
            this.lbReqAllowancesDate.Name = "lbReqAllowancesDate";
            this.lbReqAllowancesDate.Size = new System.Drawing.Size(55, 13);
            this.lbReqAllowancesDate.TabIndex = 3;
            this.lbReqAllowancesDate.Text = "Start Time";
            // 
            // pGestionDietas
            // 
            this.pGestionDietas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pGestionDietas.Controls.Add(this.lbManAllowancesOptions);
            this.pGestionDietas.Controls.Add(this.cbGestDietas);
            this.pGestionDietas.Controls.Add(this.lbManAllowances);
            this.pGestionDietas.Controls.Add(this.pGestDietasKilometraje);
            this.pGestionDietas.Controls.Add(this.pGestDietasDietas);
            this.pGestionDietas.Location = new System.Drawing.Point(166, 61);
            this.pGestionDietas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pGestionDietas.Name = "pGestionDietas";
            this.pGestionDietas.Size = new System.Drawing.Size(1066, 710);
            this.pGestionDietas.TabIndex = 3;
            this.pGestionDietas.Visible = false;
            // 
            // lbManAllowancesOptions
            // 
            this.lbManAllowancesOptions.AutoSize = true;
            this.lbManAllowancesOptions.Location = new System.Drawing.Point(157, 19);
            this.lbManAllowancesOptions.Name = "lbManAllowancesOptions";
            this.lbManAllowancesOptions.Size = new System.Drawing.Size(88, 13);
            this.lbManAllowancesOptions.TabIndex = 10;
            this.lbManAllowancesOptions.Text = "Elija una opción: ";
            // 
            // cbGestDietas
            // 
            this.cbGestDietas.FormattingEnabled = true;
            this.cbGestDietas.Items.AddRange(new object[] {
            "Dietas",
            "Kilometraje"});
            this.cbGestDietas.Location = new System.Drawing.Point(293, 18);
            this.cbGestDietas.Name = "cbGestDietas";
            this.cbGestDietas.Size = new System.Drawing.Size(104, 21);
            this.cbGestDietas.TabIndex = 1;
            this.cbGestDietas.SelectionChangeCommitted += new System.EventHandler(this.cbGestDietas_SelectionChangeCommitted);
            // 
            // lbManAllowances
            // 
            this.lbManAllowances.AutoSize = true;
            this.lbManAllowances.Location = new System.Drawing.Point(27, 20);
            this.lbManAllowances.Name = "lbManAllowances";
            this.lbManAllowances.Size = new System.Drawing.Size(89, 13);
            this.lbManAllowances.TabIndex = 2;
            this.lbManAllowances.Text = "Gestión de dietas";
            // 
            // pGestDietasKilometraje
            // 
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageState);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageFinal);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileagePricePerKilometer);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageKilometers);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageDestination);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageOrigin);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageIdMileage);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageSubcategory);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageDate);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageTitle);
            this.pGestDietasKilometraje.Controls.Add(this.tbManMileageEmail);
            this.pGestDietasKilometraje.Controls.Add(this.btnManMileageRemoveMileage);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageIdMileage);
            this.pGestDietasKilometraje.Controls.Add(this.btnManMileageRefreshDgvMileage);
            this.pGestDietasKilometraje.Controls.Add(this.btnManMileageUpdateStateMileage);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageNewState);
            this.pGestDietasKilometraje.Controls.Add(this.cbManMileageNewState);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageKilometers);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageState);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileagePricePerKilometer);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageFinal);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageDate);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageSubcategory);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageOrigin);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageDestination);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageTitle);
            this.pGestDietasKilometraje.Controls.Add(this.lbManMileageEmail);
            this.pGestDietasKilometraje.Controls.Add(this.lbTitleManMileage);
            this.pGestDietasKilometraje.Controls.Add(this.dgvMileage);
            this.pGestDietasKilometraje.Location = new System.Drawing.Point(14, 56);
            this.pGestDietasKilometraje.Name = "pGestDietasKilometraje";
            this.pGestDietasKilometraje.Size = new System.Drawing.Size(1556, 842);
            this.pGestDietasKilometraje.TabIndex = 9;
            // 
            // btnManMileageRemoveMileage
            // 
            this.btnManMileageRemoveMileage.Location = new System.Drawing.Point(576, 269);
            this.btnManMileageRemoveMileage.Name = "btnManMileageRemoveMileage";
            this.btnManMileageRemoveMileage.Size = new System.Drawing.Size(99, 47);
            this.btnManMileageRemoveMileage.TabIndex = 52;
            this.btnManMileageRemoveMileage.Text = "Eliminar kilometraje";
            this.btnManMileageRemoveMileage.UseVisualStyleBackColor = true;
            this.btnManMileageRemoveMileage.Click += new System.EventHandler(this.btnKilometrajeEliminar_Click);
            // 
            // lbManMileageIdMileage
            // 
            this.lbManMileageIdMileage.AutoSize = true;
            this.lbManMileageIdMileage.Location = new System.Drawing.Point(17, 325);
            this.lbManMileageIdMileage.Name = "lbManMileageIdMileage";
            this.lbManMileageIdMileage.Size = new System.Drawing.Size(69, 13);
            this.lbManMileageIdMileage.TabIndex = 51;
            this.lbManMileageIdMileage.Text = "Id kilometraje";
            // 
            // btnManMileageRefreshDgvMileage
            // 
            this.btnManMileageRefreshDgvMileage.Location = new System.Drawing.Point(433, 322);
            this.btnManMileageRefreshDgvMileage.Name = "btnManMileageRefreshDgvMileage";
            this.btnManMileageRefreshDgvMileage.Size = new System.Drawing.Size(112, 32);
            this.btnManMileageRefreshDgvMileage.TabIndex = 49;
            this.btnManMileageRefreshDgvMileage.Text = "Refrescar tabla";
            this.btnManMileageRefreshDgvMileage.UseVisualStyleBackColor = true;
            this.btnManMileageRefreshDgvMileage.Click += new System.EventHandler(this.btnRefreshDgvMileage_Click);
            // 
            // btnManMileageUpdateStateMileage
            // 
            this.btnManMileageUpdateStateMileage.Location = new System.Drawing.Point(433, 269);
            this.btnManMileageUpdateStateMileage.Name = "btnManMileageUpdateStateMileage";
            this.btnManMileageUpdateStateMileage.Size = new System.Drawing.Size(112, 30);
            this.btnManMileageUpdateStateMileage.TabIndex = 48;
            this.btnManMileageUpdateStateMileage.Text = "Actualizar Kilometraje";
            this.btnManMileageUpdateStateMileage.UseVisualStyleBackColor = true;
            this.btnManMileageUpdateStateMileage.Click += new System.EventHandler(this.btnUpdateStateMileage_Click);
            // 
            // lbManMileageNewState
            // 
            this.lbManMileageNewState.AutoSize = true;
            this.lbManMileageNewState.Location = new System.Drawing.Point(417, 236);
            this.lbManMileageNewState.Name = "lbManMileageNewState";
            this.lbManMileageNewState.Size = new System.Drawing.Size(130, 13);
            this.lbManMileageNewState.TabIndex = 47;
            this.lbManMileageNewState.Text = "Nuevo estado kilometraje:";
            // 
            // cbManMileageNewState
            // 
            this.cbManMileageNewState.FormattingEnabled = true;
            this.cbManMileageNewState.Items.AddRange(new object[] {
            "Solicitado",
            "En trámite",
            "Pagado"});
            this.cbManMileageNewState.Location = new System.Drawing.Point(558, 233);
            this.cbManMileageNewState.Name = "cbManMileageNewState";
            this.cbManMileageNewState.Size = new System.Drawing.Size(106, 21);
            this.cbManMileageNewState.TabIndex = 13;
            this.cbManMileageNewState.SelectionChangeCommitted += new System.EventHandler(this.cbMileageState_SelectionChangeCommitted);
            // 
            // lbManMileageKilometers
            // 
            this.lbManMileageKilometers.AutoSize = true;
            this.lbManMileageKilometers.Location = new System.Drawing.Point(210, 257);
            this.lbManMileageKilometers.Name = "lbManMileageKilometers";
            this.lbManMileageKilometers.Size = new System.Drawing.Size(55, 13);
            this.lbManMileageKilometers.TabIndex = 45;
            this.lbManMileageKilometers.Text = "Kilometers";
            // 
            // lbManMileageState
            // 
            this.lbManMileageState.AutoSize = true;
            this.lbManMileageState.Location = new System.Drawing.Point(414, 188);
            this.lbManMileageState.Name = "lbManMileageState";
            this.lbManMileageState.Size = new System.Drawing.Size(32, 13);
            this.lbManMileageState.TabIndex = 43;
            this.lbManMileageState.Text = "State";
            // 
            // lbManMileagePricePerKilometer
            // 
            this.lbManMileagePricePerKilometer.AutoSize = true;
            this.lbManMileagePricePerKilometer.Location = new System.Drawing.Point(207, 291);
            this.lbManMileagePricePerKilometer.Name = "lbManMileagePricePerKilometer";
            this.lbManMileagePricePerKilometer.Size = new System.Drawing.Size(96, 13);
            this.lbManMileagePricePerKilometer.TabIndex = 41;
            this.lbManMileagePricePerKilometer.Text = "Price Per Kilometer";
            // 
            // lbManMileageFinal
            // 
            this.lbManMileageFinal.AutoSize = true;
            this.lbManMileageFinal.Location = new System.Drawing.Point(210, 325);
            this.lbManMileageFinal.Name = "lbManMileageFinal";
            this.lbManMileageFinal.Size = new System.Drawing.Size(29, 13);
            this.lbManMileageFinal.TabIndex = 39;
            this.lbManMileageFinal.Text = "Final";
            // 
            // lbManMileageDate
            // 
            this.lbManMileageDate.AutoSize = true;
            this.lbManMileageDate.Location = new System.Drawing.Point(21, 252);
            this.lbManMileageDate.Name = "lbManMileageDate";
            this.lbManMileageDate.Size = new System.Drawing.Size(30, 13);
            this.lbManMileageDate.TabIndex = 35;
            this.lbManMileageDate.Text = "Date";
            // 
            // lbManMileageSubcategory
            // 
            this.lbManMileageSubcategory.AutoSize = true;
            this.lbManMileageSubcategory.Location = new System.Drawing.Point(20, 287);
            this.lbManMileageSubcategory.Name = "lbManMileageSubcategory";
            this.lbManMileageSubcategory.Size = new System.Drawing.Size(67, 13);
            this.lbManMileageSubcategory.TabIndex = 33;
            this.lbManMileageSubcategory.Text = "Subcategory";
            // 
            // lbManMileageOrigin
            // 
            this.lbManMileageOrigin.AutoSize = true;
            this.lbManMileageOrigin.Location = new System.Drawing.Point(210, 188);
            this.lbManMileageOrigin.Name = "lbManMileageOrigin";
            this.lbManMileageOrigin.Size = new System.Drawing.Size(38, 13);
            this.lbManMileageOrigin.TabIndex = 31;
            this.lbManMileageOrigin.Text = "Origen";
            // 
            // lbManMileageDestination
            // 
            this.lbManMileageDestination.AutoSize = true;
            this.lbManMileageDestination.Location = new System.Drawing.Point(210, 226);
            this.lbManMileageDestination.Name = "lbManMileageDestination";
            this.lbManMileageDestination.Size = new System.Drawing.Size(43, 13);
            this.lbManMileageDestination.TabIndex = 29;
            this.lbManMileageDestination.Text = "Destino";
            // 
            // lbManMileageTitle
            // 
            this.lbManMileageTitle.AutoSize = true;
            this.lbManMileageTitle.Location = new System.Drawing.Point(20, 217);
            this.lbManMileageTitle.Name = "lbManMileageTitle";
            this.lbManMileageTitle.Size = new System.Drawing.Size(35, 13);
            this.lbManMileageTitle.TabIndex = 27;
            this.lbManMileageTitle.Text = "Título";
            // 
            // lbManMileageEmail
            // 
            this.lbManMileageEmail.AutoSize = true;
            this.lbManMileageEmail.Location = new System.Drawing.Point(21, 188);
            this.lbManMileageEmail.Name = "lbManMileageEmail";
            this.lbManMileageEmail.Size = new System.Drawing.Size(32, 13);
            this.lbManMileageEmail.TabIndex = 25;
            this.lbManMileageEmail.Text = "Email";
            // 
            // lbTitleManMileage
            // 
            this.lbTitleManMileage.AutoSize = true;
            this.lbTitleManMileage.Location = new System.Drawing.Point(3, 7);
            this.lbTitleManMileage.Name = "lbTitleManMileage";
            this.lbTitleManMileage.Size = new System.Drawing.Size(58, 13);
            this.lbTitleManMileage.TabIndex = 5;
            this.lbTitleManMileage.Text = "Kilometraje";
            // 
            // dgvMileage
            // 
            this.dgvMileage.AllowUserToAddRows = false;
            this.dgvMileage.AllowUserToDeleteRows = false;
            this.dgvMileage.AllowUserToOrderColumns = true;
            this.dgvMileage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMileage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMileage,
            this.dataGridViewTextBoxColumn1,
            this.title,
            this.date,
            this.subcategory,
            this.origen,
            this.destino,
            this.kilometers,
            this.pricePerKilometer,
            this.Final,
            this.dataGridViewComboBoxColumn1});
            this.dgvMileage.Location = new System.Drawing.Point(3, 27);
            this.dgvMileage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMileage.Name = "dgvMileage";
            this.dgvMileage.RowHeadersWidth = 51;
            this.dgvMileage.RowTemplate.Height = 29;
            this.dgvMileage.Size = new System.Drawing.Size(985, 149);
            this.dgvMileage.TabIndex = 6;
            this.dgvMileage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKilometraje_CellClick);
            this.dgvMileage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKilometraje_CellContentClick);
            // 
            // idMileage
            // 
            this.idMileage.HeaderText = "idMileage";
            this.idMileage.MinimumWidth = 6;
            this.idMileage.Name = "idMileage";
            this.idMileage.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Email";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 75;
            // 
            // subcategory
            // 
            this.subcategory.HeaderText = "Subcategory";
            this.subcategory.MinimumWidth = 6;
            this.subcategory.Name = "subcategory";
            this.subcategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.subcategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.subcategory.Width = 125;
            // 
            // origen
            // 
            this.origen.HeaderText = "Origen";
            this.origen.MinimumWidth = 6;
            this.origen.Name = "origen";
            this.origen.Width = 125;
            // 
            // destino
            // 
            this.destino.HeaderText = "Destino";
            this.destino.MinimumWidth = 6;
            this.destino.Name = "destino";
            this.destino.Width = 125;
            // 
            // kilometers
            // 
            this.kilometers.HeaderText = "Kilometers";
            this.kilometers.MinimumWidth = 6;
            this.kilometers.Name = "kilometers";
            this.kilometers.Width = 125;
            // 
            // pricePerKilometer
            // 
            this.pricePerKilometer.HeaderText = "Price Per Kilometer";
            this.pricePerKilometer.MinimumWidth = 6;
            this.pricePerKilometer.Name = "pricePerKilometer";
            this.pricePerKilometer.Width = 125;
            // 
            // Final
            // 
            this.Final.HeaderText = "Final";
            this.Final.MinimumWidth = 6;
            this.Final.Name = "Final";
            this.Final.ReadOnly = true;
            this.Final.Width = 75;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "State";
            this.dataGridViewComboBoxColumn1.MinimumWidth = 6;
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewComboBoxColumn1.Width = 125;
            // 
            // pGestDietasDietas
            // 
            this.pGestDietasDietas.AutoScroll = true;
            this.pGestDietasDietas.Controls.Add(this.tbManAllowancesIdAllowance);
            this.pGestDietasDietas.Controls.Add(this.tbManAllowancesState);
            this.pGestDietasDietas.Controls.Add(this.tbManAllowancesEndHour);
            this.pGestDietasDietas.Controls.Add(this.tbManAllowancesStartHour);
            this.pGestDietasDietas.Controls.Add(this.tbManAllowancesDate);
            this.pGestDietasDietas.Controls.Add(this.tbManAllowancesObservations);
            this.pGestDietasDietas.Controls.Add(this.tbManAllowancesTitle);
            this.pGestDietasDietas.Controls.Add(this.tbManAllowancesEmail);
            this.pGestDietasDietas.Controls.Add(this.axAcroPDF1);
            this.pGestDietasDietas.Controls.Add(this.btnManAllowancesAllowanceRemove);
            this.pGestDietasDietas.Controls.Add(this.lbManAllowancesIdAllowance);
            this.pGestDietasDietas.Controls.Add(this.btnManAllowancesUpdateData);
            this.pGestDietasDietas.Controls.Add(this.lbManAllowancesNewState);
            this.pGestDietasDietas.Controls.Add(this.cbStateDietas);
            this.pGestDietasDietas.Controls.Add(this.btnManAllowancesDietasRefresh);
            this.pGestDietasDietas.Controls.Add(this.lbManAllowancesObservations);
            this.pGestDietasDietas.Controls.Add(this.lbManAllowancesDate);
            this.pGestDietasDietas.Controls.Add(this.lbManAllowancesStartHour);
            this.pGestDietasDietas.Controls.Add(this.lbManAllowancesEndHour);
            this.pGestDietasDietas.Controls.Add(this.lbManAllowancesState);
            this.pGestDietasDietas.Controls.Add(this.lbManAllowancesTitle);
            this.pGestDietasDietas.Controls.Add(this.lbManAllowancesEmail);
            this.pGestDietasDietas.Controls.Add(this.dgvAllowances);
            this.pGestDietasDietas.Controls.Add(this.lbTitleManAllowance);
            this.pGestDietasDietas.Location = new System.Drawing.Point(14, 56);
            this.pGestDietasDietas.Name = "pGestDietasDietas";
            this.pGestDietasDietas.Size = new System.Drawing.Size(1556, 1500);
            this.pGestDietasDietas.TabIndex = 8;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 352);
            this.axAcroPDF1.Margin = new System.Windows.Forms.Padding(2);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(1216, 468);
            this.axAcroPDF1.TabIndex = 30;
            // 
            // btnManAllowancesAllowanceRemove
            // 
            this.btnManAllowancesAllowanceRemove.Location = new System.Drawing.Point(600, 251);
            this.btnManAllowancesAllowanceRemove.Name = "btnManAllowancesAllowanceRemove";
            this.btnManAllowancesAllowanceRemove.Size = new System.Drawing.Size(145, 31);
            this.btnManAllowancesAllowanceRemove.TabIndex = 13;
            this.btnManAllowancesAllowanceRemove.Text = "Eliminar dieta";
            this.btnManAllowancesAllowanceRemove.UseVisualStyleBackColor = true;
            this.btnManAllowancesAllowanceRemove.Click += new System.EventHandler(this.btnAllowanceRemove_Click);
            // 
            // lbManAllowancesIdAllowance
            // 
            this.lbManAllowancesIdAllowance.AutoSize = true;
            this.lbManAllowancesIdAllowance.Location = new System.Drawing.Point(1283, 950);
            this.lbManAllowancesIdAllowance.Name = "lbManAllowancesIdAllowance";
            this.lbManAllowancesIdAllowance.Size = new System.Drawing.Size(65, 13);
            this.lbManAllowancesIdAllowance.TabIndex = 29;
            this.lbManAllowancesIdAllowance.Text = "IdAllowance";
            // 
            // btnManAllowancesUpdateData
            // 
            this.btnManAllowancesUpdateData.Location = new System.Drawing.Point(450, 243);
            this.btnManAllowancesUpdateData.Name = "btnManAllowancesUpdateData";
            this.btnManAllowancesUpdateData.Size = new System.Drawing.Size(121, 40);
            this.btnManAllowancesUpdateData.TabIndex = 11;
            this.btnManAllowancesUpdateData.Text = "Actualizar datos";
            this.btnManAllowancesUpdateData.UseVisualStyleBackColor = true;
            this.btnManAllowancesUpdateData.Click += new System.EventHandler(this.btnGestDietasUpdate_Click);
            // 
            // lbManAllowancesNewState
            // 
            this.lbManAllowancesNewState.AutoSize = true;
            this.lbManAllowancesNewState.Location = new System.Drawing.Point(1302, 618);
            this.lbManAllowancesNewState.Name = "lbManAllowancesNewState";
            this.lbManAllowancesNewState.Size = new System.Drawing.Size(43, 13);
            this.lbManAllowancesNewState.TabIndex = 26;
            this.lbManAllowancesNewState.Text = "Estado:";
            // 
            // cbStateDietas
            // 
            this.cbStateDietas.FormattingEnabled = true;
            this.cbStateDietas.Items.AddRange(new object[] {
            "Solicitado",
            "En trámite",
            "Aceptado"});
            this.cbStateDietas.Location = new System.Drawing.Point(472, 199);
            this.cbStateDietas.Name = "cbStateDietas";
            this.cbStateDietas.Size = new System.Drawing.Size(115, 21);
            this.cbStateDietas.TabIndex = 9;
            this.cbStateDietas.SelectionChangeCommitted += new System.EventHandler(this.cbStateDietas_SelectionChangeCommitted);
            // 
            // btnManAllowancesDietasRefresh
            // 
            this.btnManAllowancesDietasRefresh.Location = new System.Drawing.Point(602, 193);
            this.btnManAllowancesDietasRefresh.Name = "btnManAllowancesDietasRefresh";
            this.btnManAllowancesDietasRefresh.Size = new System.Drawing.Size(145, 35);
            this.btnManAllowancesDietasRefresh.TabIndex = 12;
            this.btnManAllowancesDietasRefresh.Text = "Refrescar tabla";
            this.btnManAllowancesDietasRefresh.UseVisualStyleBackColor = true;
            this.btnManAllowancesDietasRefresh.Click += new System.EventHandler(this.btnGestDietasDietasRefresh_Click);
            // 
            // lbManAllowancesObservations
            // 
            this.lbManAllowancesObservations.AutoSize = true;
            this.lbManAllowancesObservations.Location = new System.Drawing.Point(-1, 823);
            this.lbManAllowancesObservations.Name = "lbManAllowancesObservations";
            this.lbManAllowancesObservations.Size = new System.Drawing.Size(78, 13);
            this.lbManAllowancesObservations.TabIndex = 23;
            this.lbManAllowancesObservations.Text = "Observaciones";
            // 
            // lbManAllowancesDate
            // 
            this.lbManAllowancesDate.AutoSize = true;
            this.lbManAllowancesDate.Location = new System.Drawing.Point(638, 610);
            this.lbManAllowancesDate.Name = "lbManAllowancesDate";
            this.lbManAllowancesDate.Size = new System.Drawing.Size(30, 13);
            this.lbManAllowancesDate.TabIndex = 21;
            this.lbManAllowancesDate.Text = "Date";
            // 
            // lbManAllowancesStartHour
            // 
            this.lbManAllowancesStartHour.AutoSize = true;
            this.lbManAllowancesStartHour.Location = new System.Drawing.Point(667, 712);
            this.lbManAllowancesStartHour.Name = "lbManAllowancesStartHour";
            this.lbManAllowancesStartHour.Size = new System.Drawing.Size(55, 13);
            this.lbManAllowancesStartHour.TabIndex = 19;
            this.lbManAllowancesStartHour.Text = "Start Hour";
            // 
            // lbManAllowancesEndHour
            // 
            this.lbManAllowancesEndHour.AutoSize = true;
            this.lbManAllowancesEndHour.Location = new System.Drawing.Point(671, 849);
            this.lbManAllowancesEndHour.Name = "lbManAllowancesEndHour";
            this.lbManAllowancesEndHour.Size = new System.Drawing.Size(52, 13);
            this.lbManAllowancesEndHour.TabIndex = 17;
            this.lbManAllowancesEndHour.Text = "End Hour";
            // 
            // lbManAllowancesState
            // 
            this.lbManAllowancesState.AutoSize = true;
            this.lbManAllowancesState.Location = new System.Drawing.Point(671, 965);
            this.lbManAllowancesState.Name = "lbManAllowancesState";
            this.lbManAllowancesState.Size = new System.Drawing.Size(32, 13);
            this.lbManAllowancesState.TabIndex = 15;
            this.lbManAllowancesState.Text = "State";
            // 
            // lbManAllowancesTitle
            // 
            this.lbManAllowancesTitle.AutoSize = true;
            this.lbManAllowancesTitle.Location = new System.Drawing.Point(8, 712);
            this.lbManAllowancesTitle.Name = "lbManAllowancesTitle";
            this.lbManAllowancesTitle.Size = new System.Drawing.Size(35, 13);
            this.lbManAllowancesTitle.TabIndex = 13;
            this.lbManAllowancesTitle.Text = "Título";
            // 
            // lbManAllowancesEmail
            // 
            this.lbManAllowancesEmail.AutoSize = true;
            this.lbManAllowancesEmail.Location = new System.Drawing.Point(10, 626);
            this.lbManAllowancesEmail.Name = "lbManAllowancesEmail";
            this.lbManAllowancesEmail.Size = new System.Drawing.Size(32, 13);
            this.lbManAllowancesEmail.TabIndex = 11;
            this.lbManAllowancesEmail.Text = "Email";
            // 
            // dgvAllowances
            // 
            this.dgvAllowances.AllowUserToAddRows = false;
            this.dgvAllowances.AllowUserToDeleteRows = false;
            this.dgvAllowances.AllowUserToOrderColumns = true;
            this.dgvAllowances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllowances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.observations,
            this.cDate,
            this.startHour,
            this.endHour,
            this.invoice,
            this.state});
            this.dgvAllowances.Location = new System.Drawing.Point(0, 26);
            this.dgvAllowances.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAllowances.Name = "dgvAllowances";
            this.dgvAllowances.RowHeadersWidth = 51;
            this.dgvAllowances.RowTemplate.Height = 29;
            this.dgvAllowances.Size = new System.Drawing.Size(1186, 157);
            this.dgvAllowances.TabIndex = 14;
            this.dgvAllowances.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDietas_CellClick);
            this.dgvAllowances.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllowances_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "idAllowance";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Email";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Title";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // observations
            // 
            this.observations.HeaderText = "Observations";
            this.observations.MinimumWidth = 6;
            this.observations.Name = "observations";
            this.observations.Width = 125;
            // 
            // cDate
            // 
            this.cDate.HeaderText = "Date";
            this.cDate.MinimumWidth = 6;
            this.cDate.Name = "cDate";
            this.cDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cDate.Width = 125;
            // 
            // startHour
            // 
            this.startHour.HeaderText = "Start Hour";
            this.startHour.MinimumWidth = 6;
            this.startHour.Name = "startHour";
            this.startHour.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.startHour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.startHour.Width = 125;
            // 
            // endHour
            // 
            this.endHour.HeaderText = "End Hour";
            this.endHour.MinimumWidth = 6;
            this.endHour.Name = "endHour";
            this.endHour.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.endHour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.endHour.Width = 125;
            // 
            // invoice
            // 
            this.invoice.HeaderText = "Invoice";
            this.invoice.MinimumWidth = 6;
            this.invoice.Name = "invoice";
            this.invoice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.invoice.Text = "Abrir";
            this.invoice.UseColumnTextForButtonValue = true;
            this.invoice.Width = 125;
            // 
            // state
            // 
            this.state.HeaderText = "State";
            this.state.MinimumWidth = 6;
            this.state.Name = "state";
            this.state.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.state.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.state.Width = 125;
            // 
            // lbTitleManAllowance
            // 
            this.lbTitleManAllowance.AutoSize = true;
            this.lbTitleManAllowance.Location = new System.Drawing.Point(10, 24);
            this.lbTitleManAllowance.Name = "lbTitleManAllowance";
            this.lbTitleManAllowance.Size = new System.Drawing.Size(37, 13);
            this.lbTitleManAllowance.TabIndex = 4;
            this.lbTitleManAllowance.Text = "Dietas";
            // 
            // pUsuarios
            // 
            this.pUsuarios.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pUsuarios.Controls.Add(this.tbEmail);
            this.pUsuarios.Controls.Add(this.tbIdUser);
            this.pUsuarios.Controls.Add(this.tbOcupacion);
            this.pUsuarios.Controls.Add(this.tbDepartment);
            this.pUsuarios.Controls.Add(this.tbPassword);
            this.pUsuarios.Controls.Add(this.btnEliminarUser);
            this.pUsuarios.Controls.Add(this.btnUpdateDtgUsers);
            this.pUsuarios.Controls.Add(this.lbJob);
            this.pUsuarios.Controls.Add(this.lbIdUser);
            this.pUsuarios.Controls.Add(this.lbPassword);
            this.pUsuarios.Controls.Add(this.lbEmail);
            this.pUsuarios.Controls.Add(this.lbDepartment);
            this.pUsuarios.Controls.Add(this.dgvUser);
            this.pUsuarios.Controls.Add(this.lbGestUsers);
            this.pUsuarios.Controls.Add(this.pRegister);
            this.pUsuarios.Location = new System.Drawing.Point(166, 61);
            this.pUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pUsuarios.Name = "pUsuarios";
            this.pUsuarios.Size = new System.Drawing.Size(1066, 582);
            this.pUsuarios.TabIndex = 2;
            this.pUsuarios.Visible = false;
            // 
            // btnEliminarUser
            // 
            this.btnEliminarUser.Location = new System.Drawing.Point(167, 216);
            this.btnEliminarUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarUser.Name = "btnEliminarUser";
            this.btnEliminarUser.Size = new System.Drawing.Size(103, 35);
            this.btnEliminarUser.TabIndex = 7;
            this.btnEliminarUser.Text = "Eliminar";
            this.btnEliminarUser.UseVisualStyleBackColor = true;
            this.btnEliminarUser.Click += new System.EventHandler(this.btnEliminarUser_Click);
            // 
            // btnUpdateDtgUsers
            // 
            this.btnUpdateDtgUsers.Location = new System.Drawing.Point(21, 216);
            this.btnUpdateDtgUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateDtgUsers.Name = "btnUpdateDtgUsers";
            this.btnUpdateDtgUsers.Size = new System.Drawing.Size(103, 35);
            this.btnUpdateDtgUsers.TabIndex = 6;
            this.btnUpdateDtgUsers.Text = "Actualizar";
            this.btnUpdateDtgUsers.UseVisualStyleBackColor = true;
            this.btnUpdateDtgUsers.Click += new System.EventHandler(this.btnUpdateDtgUsers_Click);
            // 
            // lbJob
            // 
            this.lbJob.AutoSize = true;
            this.lbJob.Location = new System.Drawing.Point(20, 408);
            this.lbJob.Name = "lbJob";
            this.lbJob.Size = new System.Drawing.Size(59, 13);
            this.lbJob.TabIndex = 22;
            this.lbJob.Text = "Ocupación";
            // 
            // lbIdUser
            // 
            this.lbIdUser.AutoSize = true;
            this.lbIdUser.Location = new System.Drawing.Point(27, 268);
            this.lbIdUser.Name = "lbIdUser";
            this.lbIdUser.Size = new System.Drawing.Size(41, 13);
            this.lbIdUser.TabIndex = 21;
            this.lbIdUser.Text = "Id User";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(33, 328);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 10;
            this.lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(38, 294);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 9;
            this.lbEmail.Text = "Email";
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Location = new System.Drawing.Point(5, 355);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(74, 13);
            this.lbDepartment.TabIndex = 7;
            this.lbDepartment.Text = "Departamento";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToOrderColumns = true;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUser,
            this.email,
            this.password,
            this.dept,
            this.role});
            this.dgvUser.Location = new System.Drawing.Point(293, 19);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 25;
            this.dgvUser.Size = new System.Drawing.Size(612, 222);
            this.dgvUser.TabIndex = 6;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            // 
            // idUser
            // 
            this.idUser.HeaderText = "Id User";
            this.idUser.MinimumWidth = 6;
            this.idUser.Name = "idUser";
            this.idUser.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.Width = 125;
            // 
            // dept
            // 
            this.dept.HeaderText = "Departamento";
            this.dept.MinimumWidth = 6;
            this.dept.Name = "dept";
            this.dept.Width = 125;
            // 
            // role
            // 
            this.role.HeaderText = "Ocupación";
            this.role.MinimumWidth = 6;
            this.role.Name = "role";
            this.role.Width = 125;
            // 
            // lbGestUsers
            // 
            this.lbGestUsers.AutoSize = true;
            this.lbGestUsers.Location = new System.Drawing.Point(38, 10);
            this.lbGestUsers.Name = "lbGestUsers";
            this.lbGestUsers.Size = new System.Drawing.Size(100, 13);
            this.lbGestUsers.TabIndex = 1;
            this.lbGestUsers.Text = "Gestión de usuarios";
            // 
            // pRegister
            // 
            this.pRegister.BackColor = System.Drawing.Color.LightGray;
            this.pRegister.Controls.Add(this.cbRole);
            this.pRegister.Controls.Add(this.btnRRegistrar);
            this.pRegister.Controls.Add(this.lbRegisterUser);
            this.pRegister.Controls.Add(this.tbRPassword);
            this.pRegister.Controls.Add(this.cbDepartamento);
            this.pRegister.Controls.Add(this.tbREmail);
            this.pRegister.Location = new System.Drawing.Point(21, 42);
            this.pRegister.Name = "pRegister";
            this.pRegister.Size = new System.Drawing.Size(249, 167);
            this.pRegister.TabIndex = 5;
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(128, 47);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(104, 21);
            this.cbRole.TabIndex = 3;
            // 
            // btnRRegistrar
            // 
            this.btnRRegistrar.Location = new System.Drawing.Point(15, 128);
            this.btnRRegistrar.Name = "btnRRegistrar";
            this.btnRRegistrar.Size = new System.Drawing.Size(79, 23);
            this.btnRRegistrar.TabIndex = 5;
            this.btnRRegistrar.Text = "Registrar";
            this.btnRRegistrar.UseVisualStyleBackColor = true;
            this.btnRRegistrar.Click += new System.EventHandler(this.btnRRegistrar_Click);
            // 
            // lbRegisterUser
            // 
            this.lbRegisterUser.AutoSize = true;
            this.lbRegisterUser.Location = new System.Drawing.Point(15, 12);
            this.lbRegisterUser.Name = "lbRegisterUser";
            this.lbRegisterUser.Size = new System.Drawing.Size(46, 13);
            this.lbRegisterUser.TabIndex = 7;
            this.lbRegisterUser.Text = "Register";
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(128, 92);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(104, 21);
            this.cbDepartamento.TabIndex = 4;
            // 
            // opfSeleccionarArchivo
            // 
            this.opfSeleccionarArchivo.FileName = "openFileDialog1";
            // 
            // pCRMGest
            // 
            this.pCRMGest.BackColor = System.Drawing.Color.SandyBrown;
            this.pCRMGest.Controls.Add(this.tabControl1);
            this.pCRMGest.Location = new System.Drawing.Point(166, 61);
            this.pCRMGest.Margin = new System.Windows.Forms.Padding(2);
            this.pCRMGest.Name = "pCRMGest";
            this.pCRMGest.Size = new System.Drawing.Size(1010, 504);
            this.pCRMGest.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pipeline);
            this.tabControl1.Controls.Add(this.Customers);
            this.tabControl1.Controls.Add(this.teams);
            this.tabControl1.Location = new System.Drawing.Point(14, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1216, 592);
            this.tabControl1.TabIndex = 0;
            // 
            // pipeline
            // 
            this.pipeline.Controls.Add(this.btnUpdateFlps);
            this.pipeline.Controls.Add(this.btnPipelineAddLead);
            this.pipeline.Controls.Add(this.flpWon);
            this.pipeline.Controls.Add(this.lbWon);
            this.pipeline.Controls.Add(this.lbProposition);
            this.pipeline.Controls.Add(this.lbQualified);
            this.pipeline.Controls.Add(this.lbNew);
            this.pipeline.Controls.Add(this.button1);
            this.pipeline.Controls.Add(this.flpProposition);
            this.pipeline.Controls.Add(this.flpQualified);
            this.pipeline.Controls.Add(this.flpNew);
            this.pipeline.Location = new System.Drawing.Point(4, 22);
            this.pipeline.Margin = new System.Windows.Forms.Padding(2);
            this.pipeline.Name = "pipeline";
            this.pipeline.Padding = new System.Windows.Forms.Padding(2);
            this.pipeline.Size = new System.Drawing.Size(1208, 566);
            this.pipeline.TabIndex = 0;
            this.pipeline.Text = "Pipeline";
            this.pipeline.UseVisualStyleBackColor = true;
            // 
            // btnUpdateFlps
            // 
            this.btnUpdateFlps.Location = new System.Drawing.Point(395, 7);
            this.btnUpdateFlps.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateFlps.Name = "btnUpdateFlps";
            this.btnUpdateFlps.Size = new System.Drawing.Size(105, 44);
            this.btnUpdateFlps.TabIndex = 13;
            this.btnUpdateFlps.Text = "Update Flps";
            this.btnUpdateFlps.UseVisualStyleBackColor = true;
            this.btnUpdateFlps.Click += new System.EventHandler(this.btnUpdateFlps_Click);
            // 
            // btnPipelineAddLead
            // 
            this.btnPipelineAddLead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
            this.btnPipelineAddLead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPipelineAddLead.BackgroundImage")));
            this.btnPipelineAddLead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPipelineAddLead.Location = new System.Drawing.Point(41, 13);
            this.btnPipelineAddLead.Name = "btnPipelineAddLead";
            this.btnPipelineAddLead.Size = new System.Drawing.Size(30, 30);
            this.btnPipelineAddLead.TabIndex = 11;
            this.btnPipelineAddLead.UseVisualStyleBackColor = false;
            this.btnPipelineAddLead.Click += new System.EventHandler(this.btnPipelineAddLead_Click);
            // 
            // flpWon
            // 
            this.flpWon.AllowDrop = true;
            this.flpWon.BackColor = System.Drawing.Color.Gray;
            this.flpWon.Location = new System.Drawing.Point(666, 86);
            this.flpWon.Margin = new System.Windows.Forms.Padding(2);
            this.flpWon.Name = "flpWon";
            this.flpWon.Size = new System.Drawing.Size(183, 438);
            this.flpWon.TabIndex = 9;
            this.flpWon.DragDrop += new System.Windows.Forms.DragEventHandler(this.flp_DragDrop);
            this.flpWon.DragEnter += new System.Windows.Forms.DragEventHandler(this.flp_DragEnter);
            // 
            // lbWon
            // 
            this.lbWon.AutoSize = true;
            this.lbWon.Location = new System.Drawing.Point(664, 69);
            this.lbWon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWon.Name = "lbWon";
            this.lbWon.Size = new System.Drawing.Size(30, 13);
            this.lbWon.TabIndex = 8;
            this.lbWon.Text = "Won";
            // 
            // lbProposition
            // 
            this.lbProposition.AutoSize = true;
            this.lbProposition.Location = new System.Drawing.Point(444, 69);
            this.lbProposition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProposition.Name = "lbProposition";
            this.lbProposition.Size = new System.Drawing.Size(59, 13);
            this.lbProposition.TabIndex = 7;
            this.lbProposition.Text = "Proposition";
            // 
            // lbQualified
            // 
            this.lbQualified.AutoSize = true;
            this.lbQualified.Location = new System.Drawing.Point(251, 69);
            this.lbQualified.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQualified.Name = "lbQualified";
            this.lbQualified.Size = new System.Drawing.Size(48, 13);
            this.lbQualified.TabIndex = 6;
            this.lbQualified.Text = "Qualified";
            // 
            // lbNew
            // 
            this.lbNew.AutoSize = true;
            this.lbNew.Location = new System.Drawing.Point(46, 70);
            this.lbNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNew.Name = "lbNew";
            this.lbNew.Size = new System.Drawing.Size(29, 13);
            this.lbNew.TabIndex = 5;
            this.lbNew.Text = "New";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // flpProposition
            // 
            this.flpProposition.AllowDrop = true;
            this.flpProposition.BackColor = System.Drawing.Color.Gray;
            this.flpProposition.Location = new System.Drawing.Point(446, 86);
            this.flpProposition.Margin = new System.Windows.Forms.Padding(2);
            this.flpProposition.Name = "flpProposition";
            this.flpProposition.Size = new System.Drawing.Size(159, 439);
            this.flpProposition.TabIndex = 2;
            this.flpProposition.DragDrop += new System.Windows.Forms.DragEventHandler(this.flp_DragDrop);
            this.flpProposition.DragEnter += new System.Windows.Forms.DragEventHandler(this.flp_DragEnter);
            // 
            // flpQualified
            // 
            this.flpQualified.AllowDrop = true;
            this.flpQualified.BackColor = System.Drawing.Color.Gray;
            this.flpQualified.Location = new System.Drawing.Point(249, 86);
            this.flpQualified.Margin = new System.Windows.Forms.Padding(2);
            this.flpQualified.Name = "flpQualified";
            this.flpQualified.Size = new System.Drawing.Size(158, 439);
            this.flpQualified.TabIndex = 1;
            this.flpQualified.DragDrop += new System.Windows.Forms.DragEventHandler(this.flp_DragDrop);
            this.flpQualified.DragEnter += new System.Windows.Forms.DragEventHandler(this.flp_DragEnter);
            // 
            // flpNew
            // 
            this.flpNew.AllowDrop = true;
            this.flpNew.BackColor = System.Drawing.Color.Gray;
            this.flpNew.Location = new System.Drawing.Point(45, 86);
            this.flpNew.Margin = new System.Windows.Forms.Padding(2);
            this.flpNew.Name = "flpNew";
            this.flpNew.Size = new System.Drawing.Size(176, 438);
            this.flpNew.TabIndex = 0;
            this.flpNew.DragDrop += new System.Windows.Forms.DragEventHandler(this.flp_DragDrop);
            this.flpNew.DragEnter += new System.Windows.Forms.DragEventHandler(this.flp_DragEnter);
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.lbDateEnd);
            this.Customers.Controls.Add(this.lbDateStart);
            this.Customers.Controls.Add(this.dgvCustomer_Lead);
            this.Customers.Controls.Add(this.lbLeadName);
            this.Customers.Controls.Add(this.btnMoreInfoCustomer);
            this.Customers.Controls.Add(this.dgvCustomer);
            this.Customers.Controls.Add(this.btnUpdateDgvCustomer);
            this.Customers.Controls.Add(this.btnCustomersRemoveCustomers);
            this.Customers.Controls.Add(this.btnCustomersAddCustomers);
            this.Customers.Controls.Add(this.label5);
            this.Customers.Controls.Add(this.dtpFechaFin);
            this.Customers.Controls.Add(this.dtpFechaInicio);
            this.Customers.Controls.Add(this.label2);
            this.Customers.Controls.Add(this.label1);
            this.Customers.Location = new System.Drawing.Point(4, 22);
            this.Customers.Margin = new System.Windows.Forms.Padding(2);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(2);
            this.Customers.Size = new System.Drawing.Size(1208, 566);
            this.Customers.TabIndex = 1;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // lbDateEnd
            // 
            this.lbDateEnd.AutoSize = true;
            this.lbDateEnd.Location = new System.Drawing.Point(455, 294);
            this.lbDateEnd.Name = "lbDateEnd";
            this.lbDateEnd.Size = new System.Drawing.Size(55, 13);
            this.lbDateEnd.TabIndex = 29;
            this.lbDateEnd.Text = "End Date:";
            // 
            // lbDateStart
            // 
            this.lbDateStart.AutoSize = true;
            this.lbDateStart.Location = new System.Drawing.Point(159, 294);
            this.lbDateStart.Name = "lbDateStart";
            this.lbDateStart.Size = new System.Drawing.Size(61, 13);
            this.lbDateStart.TabIndex = 28;
            this.lbDateStart.Text = "Start Date: ";
            // 
            // dgvCustomer_Lead
            // 
            this.dgvCustomer_Lead.AllowUserToAddRows = false;
            this.dgvCustomer_Lead.AllowUserToDeleteRows = false;
            this.dgvCustomer_Lead.AllowUserToOrderColumns = true;
            this.dgvCustomer_Lead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer_Lead.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22});
            this.dgvCustomer_Lead.Location = new System.Drawing.Point(9, 366);
            this.dgvCustomer_Lead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCustomer_Lead.Name = "dgvCustomer_Lead";
            this.dgvCustomer_Lead.RowHeadersWidth = 51;
            this.dgvCustomer_Lead.RowTemplate.Height = 29;
            this.dgvCustomer_Lead.Size = new System.Drawing.Size(941, 157);
            this.dgvCustomer_Lead.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "idLead";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Name";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Date";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Stage";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn20.Width = 125;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "Assigned To";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn21.Width = 125;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "Created At";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 125;
            // 
            // lbLeadName
            // 
            this.lbLeadName.AutoSize = true;
            this.lbLeadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeadName.Location = new System.Drawing.Point(125, 334);
            this.lbLeadName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLeadName.Name = "lbLeadName";
            this.lbLeadName.Size = new System.Drawing.Size(44, 20);
            this.lbLeadName.TabIndex = 26;
            this.lbLeadName.Text = "Date";
            // 
            // btnMoreInfoCustomer
            // 
            this.btnMoreInfoCustomer.BackColor = System.Drawing.Color.White;
            this.btnMoreInfoCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoreInfoCustomer.BackgroundImage")));
            this.btnMoreInfoCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoreInfoCustomer.FlatAppearance.BorderSize = 0;
            this.btnMoreInfoCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreInfoCustomer.Location = new System.Drawing.Point(6, 252);
            this.btnMoreInfoCustomer.Name = "btnMoreInfoCustomer";
            this.btnMoreInfoCustomer.Size = new System.Drawing.Size(30, 30);
            this.btnMoreInfoCustomer.TabIndex = 16;
            this.btnMoreInfoCustomer.UseVisualStyleBackColor = false;
            this.btnMoreInfoCustomer.Click += new System.EventHandler(this.btnMoreInfoCustomer_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToOrderColumns = true;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.country,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewButtonColumn1});
            this.dgvCustomer.Location = new System.Drawing.Point(8, 83);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 29;
            this.dgvCustomer.Size = new System.Drawing.Size(1182, 157);
            this.dgvCustomer.TabIndex = 15;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "idCustomer";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Name";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Email";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Department";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "City";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // country
            // 
            this.country.HeaderText = "Country";
            this.country.MinimumWidth = 6;
            this.country.Name = "country";
            this.country.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Type";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Leads";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewButtonColumn1.Width = 125;
            // 
            // btnUpdateDgvCustomer
            // 
            this.btnUpdateDgvCustomer.Location = new System.Drawing.Point(238, 18);
            this.btnUpdateDgvCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateDgvCustomer.Name = "btnUpdateDgvCustomer";
            this.btnUpdateDgvCustomer.Size = new System.Drawing.Size(154, 33);
            this.btnUpdateDgvCustomer.TabIndex = 15;
            this.btnUpdateDgvCustomer.Text = "Update table";
            this.btnUpdateDgvCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateDgvCustomer.Click += new System.EventHandler(this.btnUpdateDgvCustomer_Click);
            // 
            // btnCustomersRemoveCustomers
            // 
            this.btnCustomersRemoveCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.btnCustomersRemoveCustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomersRemoveCustomers.BackgroundImage")));
            this.btnCustomersRemoveCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomersRemoveCustomers.Location = new System.Drawing.Point(175, 26);
            this.btnCustomersRemoveCustomers.Name = "btnCustomersRemoveCustomers";
            this.btnCustomersRemoveCustomers.Size = new System.Drawing.Size(30, 30);
            this.btnCustomersRemoveCustomers.TabIndex = 14;
            this.btnCustomersRemoveCustomers.UseVisualStyleBackColor = false;
            this.btnCustomersRemoveCustomers.Click += new System.EventHandler(this.btnCustomersRemoveCustomers_Click);
            // 
            // btnCustomersAddCustomers
            // 
            this.btnCustomersAddCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
            this.btnCustomersAddCustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomersAddCustomers.BackgroundImage")));
            this.btnCustomersAddCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomersAddCustomers.Location = new System.Drawing.Point(132, 26);
            this.btnCustomersAddCustomers.Name = "btnCustomersAddCustomers";
            this.btnCustomersAddCustomers.Size = new System.Drawing.Size(30, 30);
            this.btnCustomersAddCustomers.TabIndex = 13;
            this.btnCustomersAddCustomers.UseVisualStyleBackColor = false;
            this.btnCustomersAddCustomers.Click += new System.EventHandler(this.btnCustomersAddCustomers_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(834, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "el rango que ponga el usuario entre los dos dtp\r\n hara filtro para mostrar leads";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(516, 291);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 11;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(238, 291);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 10;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 335);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leads Names";
            // 
            // teams
            // 
            this.teams.Controls.Add(this.dataGridView3);
            this.teams.Controls.Add(this.label3);
            this.teams.Location = new System.Drawing.Point(4, 22);
            this.teams.Margin = new System.Windows.Forms.Padding(2);
            this.teams.Name = "teams";
            this.teams.Size = new System.Drawing.Size(1208, 566);
            this.teams.TabIndex = 2;
            this.teams.Text = "Teams";
            this.teams.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamName,
            this.teamGender,
            this.teamEmail,
            this.teamTitle,
            this.teamDepartment,
            this.teamRole,
            this.teamActive,
            this.teamLeads,
            this.teamOpenLeads,
            this.teamLostTeams,
            this.teamLostLeads,
            this.teamWonLeads});
            this.dataGridView3.Location = new System.Drawing.Point(22, 73);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(843, 332);
            this.dataGridView3.TabIndex = 1;
            // 
            // teamName
            // 
            this.teamName.HeaderText = "Name";
            this.teamName.MinimumWidth = 6;
            this.teamName.Name = "teamName";
            this.teamName.Width = 125;
            // 
            // teamGender
            // 
            this.teamGender.HeaderText = "Gender";
            this.teamGender.MinimumWidth = 6;
            this.teamGender.Name = "teamGender";
            this.teamGender.Width = 125;
            // 
            // teamEmail
            // 
            this.teamEmail.HeaderText = "Email";
            this.teamEmail.MinimumWidth = 6;
            this.teamEmail.Name = "teamEmail";
            this.teamEmail.Width = 125;
            // 
            // teamTitle
            // 
            this.teamTitle.HeaderText = "Title";
            this.teamTitle.MinimumWidth = 6;
            this.teamTitle.Name = "teamTitle";
            this.teamTitle.Width = 125;
            // 
            // teamDepartment
            // 
            this.teamDepartment.HeaderText = "Department";
            this.teamDepartment.MinimumWidth = 6;
            this.teamDepartment.Name = "teamDepartment";
            this.teamDepartment.Width = 125;
            // 
            // teamRole
            // 
            this.teamRole.HeaderText = "Role";
            this.teamRole.MinimumWidth = 6;
            this.teamRole.Name = "teamRole";
            this.teamRole.Width = 125;
            // 
            // teamActive
            // 
            this.teamActive.HeaderText = "Active";
            this.teamActive.MinimumWidth = 6;
            this.teamActive.Name = "teamActive";
            this.teamActive.Width = 125;
            // 
            // teamLeads
            // 
            this.teamLeads.HeaderText = "Leads";
            this.teamLeads.MinimumWidth = 6;
            this.teamLeads.Name = "teamLeads";
            this.teamLeads.Width = 125;
            // 
            // teamOpenLeads
            // 
            this.teamOpenLeads.HeaderText = "Open Leads";
            this.teamOpenLeads.MinimumWidth = 6;
            this.teamOpenLeads.Name = "teamOpenLeads";
            this.teamOpenLeads.Width = 125;
            // 
            // teamLostTeams
            // 
            this.teamLostTeams.HeaderText = "Lost Teams";
            this.teamLostTeams.MinimumWidth = 6;
            this.teamLostTeams.Name = "teamLostTeams";
            this.teamLostTeams.Width = 125;
            // 
            // teamLostLeads
            // 
            this.teamLostLeads.HeaderText = "LostLeads";
            this.teamLostLeads.MinimumWidth = 6;
            this.teamLostLeads.Name = "teamLostLeads";
            this.teamLostLeads.Width = 125;
            // 
            // teamWonLeads
            // 
            this.teamWonLeads.HeaderText = "WonLeads";
            this.teamWonLeads.MinimumWidth = 6;
            this.teamWonLeads.Name = "teamWonLeads";
            this.teamWonLeads.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // pSettingsModule
            // 
            this.pSettingsModule.Controls.Add(this.btnRestoreBackup);
            this.pSettingsModule.Controls.Add(this.btnSettingsSaveBackup);
            this.pSettingsModule.Controls.Add(this.lbSettings);
            this.pSettingsModule.Location = new System.Drawing.Point(166, 60);
            this.pSettingsModule.Name = "pSettingsModule";
            this.pSettingsModule.Size = new System.Drawing.Size(959, 448);
            this.pSettingsModule.TabIndex = 14;
            this.pSettingsModule.Visible = false;
            // 
            // btnRestoreBackup
            // 
            this.btnRestoreBackup.Location = new System.Drawing.Point(232, 98);
            this.btnRestoreBackup.Name = "btnRestoreBackup";
            this.btnRestoreBackup.Size = new System.Drawing.Size(103, 47);
            this.btnRestoreBackup.TabIndex = 2;
            this.btnRestoreBackup.Text = "Restaurar Copia de seguridad";
            this.btnRestoreBackup.UseVisualStyleBackColor = true;
            this.btnRestoreBackup.Click += new System.EventHandler(this.btnRestoreBackup_Click);
            // 
            // btnSettingsSaveBackup
            // 
            this.btnSettingsSaveBackup.Location = new System.Drawing.Point(73, 98);
            this.btnSettingsSaveBackup.Name = "btnSettingsSaveBackup";
            this.btnSettingsSaveBackup.Size = new System.Drawing.Size(99, 47);
            this.btnSettingsSaveBackup.TabIndex = 1;
            this.btnSettingsSaveBackup.Text = "Crear Copia de Seguridad";
            this.btnSettingsSaveBackup.UseVisualStyleBackColor = true;
            this.btnSettingsSaveBackup.Click += new System.EventHandler(this.btnSettingsSaveBackup_Click);
            // 
            // lbSettings
            // 
            this.lbSettings.AutoSize = true;
            this.lbSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSettings.Location = new System.Drawing.Point(154, 27);
            this.lbSettings.Name = "lbSettings";
            this.lbSettings.Size = new System.Drawing.Size(90, 25);
            this.lbSettings.TabIndex = 0;
            this.lbSettings.Text = "Settings";
            // 
            // tbReqMileagePricePerKilometer
            // 
            this.tbReqMileagePricePerKilometer.Location = new System.Drawing.Point(102, 260);
            this.tbReqMileagePricePerKilometer.Name = "tbReqMileagePricePerKilometer";
            this.tbReqMileagePricePerKilometer.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbReqMileagePricePerKilometer.PlaceholderText = "";
            this.tbReqMileagePricePerKilometer.Size = new System.Drawing.Size(100, 20);
            this.tbReqMileagePricePerKilometer.TabIndex = 35;
            // 
            // tbReqMileageTotal
            // 
            this.tbReqMileageTotal.Location = new System.Drawing.Point(102, 235);
            this.tbReqMileageTotal.Name = "tbReqMileageTotal";
            this.tbReqMileageTotal.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbReqMileageTotal.PlaceholderText = "";
            this.tbReqMileageTotal.Size = new System.Drawing.Size(100, 20);
            this.tbReqMileageTotal.TabIndex = 34;
            // 
            // tbReqMileageDestination
            // 
            this.tbReqMileageDestination.Location = new System.Drawing.Point(102, 206);
            this.tbReqMileageDestination.Name = "tbReqMileageDestination";
            this.tbReqMileageDestination.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbReqMileageDestination.PlaceholderText = "";
            this.tbReqMileageDestination.Size = new System.Drawing.Size(100, 20);
            this.tbReqMileageDestination.TabIndex = 33;
            // 
            // tbReqMileageOrigin
            // 
            this.tbReqMileageOrigin.Location = new System.Drawing.Point(102, 175);
            this.tbReqMileageOrigin.Name = "tbReqMileageOrigin";
            this.tbReqMileageOrigin.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbReqMileageOrigin.PlaceholderText = "";
            this.tbReqMileageOrigin.Size = new System.Drawing.Size(100, 20);
            this.tbReqMileageOrigin.TabIndex = 32;
            // 
            // tbReqMileageTitle
            // 
            this.tbReqMileageTitle.Location = new System.Drawing.Point(102, 74);
            this.tbReqMileageTitle.Name = "tbReqMileageTitle";
            this.tbReqMileageTitle.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbReqMileageTitle.PlaceholderText = "";
            this.tbReqMileageTitle.Size = new System.Drawing.Size(100, 20);
            this.tbReqMileageTitle.TabIndex = 31;
            // 
            // tbReqMileageMileage
            // 
            this.tbReqMileageMileage.Location = new System.Drawing.Point(102, 34);
            this.tbReqMileageMileage.Name = "tbReqMileageMileage";
            this.tbReqMileageMileage.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbReqMileageMileage.PlaceholderText = "";
            this.tbReqMileageMileage.Size = new System.Drawing.Size(100, 20);
            this.tbReqMileageMileage.TabIndex = 30;
            // 
            // tbReqAllowancesObservations
            // 
            this.tbReqAllowancesObservations.Location = new System.Drawing.Point(69, 74);
            this.tbReqAllowancesObservations.Multiline = true;
            this.tbReqAllowancesObservations.Name = "tbReqAllowancesObservations";
            this.tbReqAllowancesObservations.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbReqAllowancesObservations.PlaceholderText = "";
            this.tbReqAllowancesObservations.Size = new System.Drawing.Size(197, 83);
            this.tbReqAllowancesObservations.TabIndex = 20;
            // 
            // tbReqAllowancesTitle
            // 
            this.tbReqAllowancesTitle.Location = new System.Drawing.Point(65, 41);
            this.tbReqAllowancesTitle.Name = "tbReqAllowancesTitle";
            this.tbReqAllowancesTitle.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbReqAllowancesTitle.PlaceholderText = "";
            this.tbReqAllowancesTitle.Size = new System.Drawing.Size(100, 20);
            this.tbReqAllowancesTitle.TabIndex = 19;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(113, 292);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbEmail.PlaceholderText = "";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 29;
            // 
            // tbIdUser
            // 
            this.tbIdUser.Location = new System.Drawing.Point(113, 263);
            this.tbIdUser.Name = "tbIdUser";
            this.tbIdUser.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbIdUser.PlaceholderText = "";
            this.tbIdUser.ReadOnly = true;
            this.tbIdUser.Size = new System.Drawing.Size(100, 20);
            this.tbIdUser.TabIndex = 28;
            // 
            // tbOcupacion
            // 
            this.tbOcupacion.Location = new System.Drawing.Point(113, 397);
            this.tbOcupacion.Name = "tbOcupacion";
            this.tbOcupacion.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbOcupacion.PlaceholderText = "";
            this.tbOcupacion.ReadOnly = true;
            this.tbOcupacion.Size = new System.Drawing.Size(100, 20);
            this.tbOcupacion.TabIndex = 27;
            // 
            // tbDepartment
            // 
            this.tbDepartment.Location = new System.Drawing.Point(113, 360);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbDepartment.PlaceholderText = "";
            this.tbDepartment.ReadOnly = true;
            this.tbDepartment.Size = new System.Drawing.Size(100, 20);
            this.tbDepartment.TabIndex = 26;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(113, 328);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbPassword.PlaceholderText = "";
            this.tbPassword.ReadOnly = true;
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 25;
            // 
            // tbRPassword
            // 
            this.tbRPassword.Location = new System.Drawing.Point(9, 92);
            this.tbRPassword.Name = "tbRPassword";
            this.tbRPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbRPassword.PlaceholderText = "";
            this.tbRPassword.Size = new System.Drawing.Size(100, 20);
            this.tbRPassword.TabIndex = 24;
            // 
            // tbREmail
            // 
            this.tbREmail.Location = new System.Drawing.Point(9, 47);
            this.tbREmail.Name = "tbREmail";
            this.tbREmail.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbREmail.PlaceholderText = "";
            this.tbREmail.Size = new System.Drawing.Size(100, 20);
            this.tbREmail.TabIndex = 23;
            // 
            // tbManAllowancesEmail
            // 
            this.tbManAllowancesEmail.Location = new System.Drawing.Point(42, 201);
            this.tbManAllowancesEmail.Name = "tbManAllowancesEmail";
            this.tbManAllowancesEmail.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManAllowancesEmail.PlaceholderText = "";
            this.tbManAllowancesEmail.Size = new System.Drawing.Size(100, 20);
            this.tbManAllowancesEmail.TabIndex = 31;
            // 
            // tbManAllowancesTitle
            // 
            this.tbManAllowancesTitle.Location = new System.Drawing.Point(42, 235);
            this.tbManAllowancesTitle.Name = "tbManAllowancesTitle";
            this.tbManAllowancesTitle.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManAllowancesTitle.PlaceholderText = "";
            this.tbManAllowancesTitle.Size = new System.Drawing.Size(100, 20);
            this.tbManAllowancesTitle.TabIndex = 32;
            // 
            // tbManAllowancesObservations
            // 
            this.tbManAllowancesObservations.Location = new System.Drawing.Point(42, 269);
            this.tbManAllowancesObservations.Multiline = true;
            this.tbManAllowancesObservations.Name = "tbManAllowancesObservations";
            this.tbManAllowancesObservations.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManAllowancesObservations.PlaceholderText = "";
            this.tbManAllowancesObservations.Size = new System.Drawing.Size(121, 69);
            this.tbManAllowancesObservations.TabIndex = 33;
            // 
            // tbManAllowancesDate
            // 
            this.tbManAllowancesDate.Location = new System.Drawing.Point(276, 198);
            this.tbManAllowancesDate.Name = "tbManAllowancesDate";
            this.tbManAllowancesDate.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManAllowancesDate.PlaceholderText = "";
            this.tbManAllowancesDate.Size = new System.Drawing.Size(100, 20);
            this.tbManAllowancesDate.TabIndex = 34;
            // 
            // tbManAllowancesStartHour
            // 
            this.tbManAllowancesStartHour.Location = new System.Drawing.Point(276, 233);
            this.tbManAllowancesStartHour.Name = "tbManAllowancesStartHour";
            this.tbManAllowancesStartHour.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManAllowancesStartHour.PlaceholderText = "";
            this.tbManAllowancesStartHour.Size = new System.Drawing.Size(100, 20);
            this.tbManAllowancesStartHour.TabIndex = 35;
            // 
            // tbManAllowancesEndHour
            // 
            this.tbManAllowancesEndHour.Location = new System.Drawing.Point(276, 269);
            this.tbManAllowancesEndHour.Name = "tbManAllowancesEndHour";
            this.tbManAllowancesEndHour.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManAllowancesEndHour.PlaceholderText = "";
            this.tbManAllowancesEndHour.Size = new System.Drawing.Size(100, 20);
            this.tbManAllowancesEndHour.TabIndex = 36;
            // 
            // tbManAllowancesState
            // 
            this.tbManAllowancesState.Location = new System.Drawing.Point(276, 305);
            this.tbManAllowancesState.Name = "tbManAllowancesState";
            this.tbManAllowancesState.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManAllowancesState.PlaceholderText = "";
            this.tbManAllowancesState.Size = new System.Drawing.Size(100, 20);
            this.tbManAllowancesState.TabIndex = 37;
            // 
            // tbManAllowancesIdAllowance
            // 
            this.tbManAllowancesIdAllowance.Location = new System.Drawing.Point(450, 304);
            this.tbManAllowancesIdAllowance.Name = "tbManAllowancesIdAllowance";
            this.tbManAllowancesIdAllowance.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManAllowancesIdAllowance.PlaceholderText = "";
            this.tbManAllowancesIdAllowance.Size = new System.Drawing.Size(100, 20);
            this.tbManAllowancesIdAllowance.TabIndex = 38;
            // 
            // tbManMileageEmail
            // 
            this.tbManMileageEmail.Location = new System.Drawing.Point(63, 185);
            this.tbManMileageEmail.Name = "tbManMileageEmail";
            this.tbManMileageEmail.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManMileageEmail.PlaceholderText = "";
            this.tbManMileageEmail.Size = new System.Drawing.Size(100, 20);
            this.tbManMileageEmail.TabIndex = 53;
            // 
            // tbManMileageTitle
            // 
            this.tbManMileageTitle.Location = new System.Drawing.Point(63, 213);
            this.tbManMileageTitle.Name = "tbManMileageTitle";
            this.tbManMileageTitle.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManMileageTitle.PlaceholderText = "";
            this.tbManMileageTitle.Size = new System.Drawing.Size(100, 20);
            this.tbManMileageTitle.TabIndex = 54;
            // 
            // tbManMileageDate
            // 
            this.tbManMileageDate.Location = new System.Drawing.Point(63, 250);
            this.tbManMileageDate.Name = "tbManMileageDate";
            this.tbManMileageDate.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManMileageDate.PlaceholderText = "";
            this.tbManMileageDate.Size = new System.Drawing.Size(100, 20);
            this.tbManMileageDate.TabIndex = 55;
            // 
            // tbManMileageSubcategory
            // 
            this.tbManMileageSubcategory.Location = new System.Drawing.Point(89, 284);
            this.tbManMileageSubcategory.Name = "tbManMileageSubcategory";
            this.tbManMileageSubcategory.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManMileageSubcategory.PlaceholderText = "";
            this.tbManMileageSubcategory.Size = new System.Drawing.Size(100, 20);
            this.tbManMileageSubcategory.TabIndex = 56;
            // 
            // tbManMileageIdMileage
            // 
            this.tbManMileageIdMileage.Location = new System.Drawing.Point(89, 322);
            this.tbManMileageIdMileage.Name = "tbManMileageIdMileage";
            this.tbManMileageIdMileage.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManMileageIdMileage.PlaceholderText = "";
            this.tbManMileageIdMileage.Size = new System.Drawing.Size(100, 20);
            this.tbManMileageIdMileage.TabIndex = 57;
            // 
            // tbManMileageOrigin
            // 
            this.tbManMileageOrigin.Location = new System.Drawing.Point(262, 185);
            this.tbManMileageOrigin.Name = "tbManMileageOrigin";
            this.tbManMileageOrigin.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManMileageOrigin.PlaceholderText = "";
            this.tbManMileageOrigin.Size = new System.Drawing.Size(100, 20);
            this.tbManMileageOrigin.TabIndex = 58;
            // 
            // tbManMileageDestination
            // 
            this.tbManMileageDestination.Location = new System.Drawing.Point(262, 224);
            this.tbManMileageDestination.Name = "tbManMileageDestination";
            this.tbManMileageDestination.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManMileageDestination.PlaceholderText = "";
            this.tbManMileageDestination.Size = new System.Drawing.Size(100, 20);
            this.tbManMileageDestination.TabIndex = 59;
            // 
            // tbManMileageKilometers
            // 
            this.tbManMileageKilometers.Location = new System.Drawing.Point(262, 254);
            this.tbManMileageKilometers.Name = "tbManMileageKilometers";
            this.tbManMileageKilometers.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManMileageKilometers.PlaceholderText = "";
            this.tbManMileageKilometers.Size = new System.Drawing.Size(100, 20);
            this.tbManMileageKilometers.TabIndex = 60;
            // 
            // tbManMileagePricePerKilometer
            // 
            this.tbManMileagePricePerKilometer.Location = new System.Drawing.Point(309, 288);
            this.tbManMileagePricePerKilometer.Name = "tbManMileagePricePerKilometer";
            this.tbManMileagePricePerKilometer.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManMileagePricePerKilometer.PlaceholderText = "";
            this.tbManMileagePricePerKilometer.Size = new System.Drawing.Size(100, 20);
            this.tbManMileagePricePerKilometer.TabIndex = 61;
            // 
            // tbManMileageFinal
            // 
            this.tbManMileageFinal.Location = new System.Drawing.Point(262, 322);
            this.tbManMileageFinal.Name = "tbManMileageFinal";
            this.tbManMileageFinal.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManMileageFinal.PlaceholderText = "";
            this.tbManMileageFinal.Size = new System.Drawing.Size(100, 20);
            this.tbManMileageFinal.TabIndex = 62;
            // 
            // tbManMileageState
            // 
            this.tbManMileageState.Location = new System.Drawing.Point(452, 185);
            this.tbManMileageState.Name = "tbManMileageState";
            this.tbManMileageState.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbManMileageState.PlaceholderText = "";
            this.tbManMileageState.Size = new System.Drawing.Size(100, 20);
            this.tbManMileageState.TabIndex = 65;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1440, 700);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.pGestionDietas);
            this.Controls.Add(this.pSolicitudDieta);
            this.Controls.Add(this.pUsuarios);
            this.Controls.Add(this.pSettingsModule);
            this.Controls.Add(this.pCRMGest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.sidebar.ResumeLayout(false);
            this.pHome.ResumeLayout(false);
            this.containerModulos.ResumeLayout(false);
            this.pGestDietas.ResumeLayout(false);
            this.pSoliDietas.ResumeLayout(false);
            this.pGestionUsers.ResumeLayout(false);
            this.pCrm.ResumeLayout(false);
            this.pAux.ResumeLayout(false);
            this.pSettings.ResumeLayout(false);
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.pSolicitudDieta.ResumeLayout(false);
            this.pSolicitudDieta.PerformLayout();
            this.pSolKilometraje.ResumeLayout(false);
            this.pSolKilometraje.PerformLayout();
            this.pSolSolicitudDietas.ResumeLayout(false);
            this.pSolSolicitudDietas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbNailInvoice)).EndInit();
            this.pGestionDietas.ResumeLayout(false);
            this.pGestionDietas.PerformLayout();
            this.pGestDietasKilometraje.ResumeLayout(false);
            this.pGestDietasKilometraje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMileage)).EndInit();
            this.pGestDietasDietas.ResumeLayout(false);
            this.pGestDietasDietas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllowances)).EndInit();
            this.pUsuarios.ResumeLayout(false);
            this.pUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.pRegister.ResumeLayout(false);
            this.pRegister.PerformLayout();
            this.pCRMGest.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.pipeline.ResumeLayout(false);
            this.pipeline.PerformLayout();
            this.Customers.ResumeLayout(false);
            this.Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer_Lead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.teams.ResumeLayout(false);
            this.teams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.pSettingsModule.ResumeLayout(false);
            this.pSettingsModule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel pMenu;
        private Panel containerModulos;
        private Panel pSettings;
        private Label lbMenu;
        private PictureBox btnMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private Button btnSubMenu;
        private Button btnGestUsers;
        private Button btnSettings;
        private Panel pGestionUsers;
        private System.Windows.Forms.Timer timerSubMenu;
        private Panel pHeader;
        private Label lbTitle;
        private Panel pSolicitudDieta;
        private Panel pGestionDietas;
        private Panel pUsuarios;
        private Label lbUser;
        private Label lbRole;
        private Panel pSoliDietas;
        private Button btnSolDietas;
        private Panel pGestDietas;
        private Button btnGestDietas;
        private Label lbTitleSolDieta;
        private Label lbManAllowances;
        private Label lbGestUsers;
        private Button btnSalir;
        private Panel pRegister;
        private Button btnRRegistrar;
        private Label lbRegisterUser;
        private Button btnRequestAllowances;
        private DateTimePicker dtpReqAllowancesStartTime;
        private Label lbReqAllowancesObservations;
        private Label lbReqAllowancesDate;
        private ComboBox cbRole;
        private DataGridView dgvUser;
        private Label lbPassword;
        private Label lbEmail;
        private Label lbDepartment;
        private Button btnReqAllowancesUploadFile;
        private DataGridView dgvAllowances;
        private DataGridView dgvMileage;
        private Label lbTitleManMileage;
        private Label lbTitleManAllowance;
        private ComboBox cbSolicitudDietas;
        private Label lbReqAllowancesTitle;
        private Label lbReqAllowancesOptions;
        private PictureBox thumbNailInvoice;
        private Panel pSolKilometraje;
        private Label lbMileageTitle;
        private DateTimePicker dtpReqDietasMileageDate;
        private ComboBox cbReqMileageSubCategory;
        private Label lbTitleMileage;
        private Label lbReqMileageDate;
        private Label lbReqMileageSubcategory;
        private Label lbReqMileageOrigin;
        private Label lbReqMileageDestination;
        private Label lbReqMileageTotal;
        private Label lbReqMileagePricePerKilometer;
        private Label lbReqMileage;
        private ComboBox cbGestDietas;
        private Panel pGestDietasKilometraje;
        private Panel pGestDietasDietas;
        private Panel pHome;
        private Button btnHome;
        private Label lbManAllowancesObservations;
        private Label lbManAllowancesDate;
        private Label lbManAllowancesStartHour;
        private Label lbManAllowancesEndHour;
        private Label lbManAllowancesState;
        private Label lbManAllowancesTitle;
        private Label lbManAllowancesEmail;
        private Label lbManMileageState;
        private Label lbManMileagePricePerKilometer;
        private Label lbManMileageFinal;
        private Label lbManMileageDate;
        private Label lbManMileageSubcategory;
        private Label lbManMileageOrigin;
        private Label lbManMileageDestination;
        private Label lbManMileageTitle;
        private Label lbManMileageEmail;
        private Label lbManMileageKilometers;
        private Panel pSolSolicitudDietas;
        private Label lbReqAllowancesTitleAllowances;
        private MaskedTextBox mtbReqAllowancesStartHour;
        private MaskedTextBox mtbReqAllowancesEndHour;
        private ComboBox cbDepartamento;
        private Label lbJob;
        private Label lbIdUser;
        private Button btnUpdateDtgUsers;
        private Button btnEliminarUser;
        private Label lbReqAllowancesEndHour;
        private Label lbReqAllowancesStartHour;
        private OpenFileDialog opfSeleccionarArchivo;
        private Label labelURL;
        private Button btnManAllowancesDietasRefresh;
        private Button btnSalirHome;
        private Label lbManAllowancesNewState;
        private ComboBox cbStateDietas;
        private Button btnManAllowancesUpdateData;
        private DataGridViewTextBoxColumn idUser;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn dept;
        private DataGridViewTextBoxColumn role;
        private Label lbManAllowancesIdAllowance;
        private Label lbManMileageNewState;
        private ComboBox cbManMileageNewState;
        private Button btnManMileageRefreshDgvMileage;
        private Button btnManMileageUpdateStateMileage;
        private DataGridViewTextBoxColumn idMileage;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn subcategory;
        private DataGridViewTextBoxColumn origen;
        private DataGridViewTextBoxColumn destino;
        private DataGridViewTextBoxColumn kilometers;
        private DataGridViewTextBoxColumn pricePerKilometer;
        private DataGridViewTextBoxColumn Final;
        private DataGridViewTextBoxColumn dataGridViewComboBoxColumn1;
        private Label lbManMileageIdMileage;
        private Button btnManMileageRemoveMileage;
        private Button btnManAllowancesAllowanceRemove;
        private Button btnSolDietasSolKilometraje;
        private Label lbManAllowancesOptions;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn observations;
        private DataGridViewTextBoxColumn cDate;
        private DataGridViewTextBoxColumn startHour;
        private DataGridViewTextBoxColumn endHour;
        private DataGridViewButtonColumn invoice;
        private DataGridViewTextBoxColumn state;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private Panel pCrm;
        private Button btnCRM;
        private Panel pAux;
        private Button btnModuleAux;
        private Panel pCRMGest;
        private TabControl tabControl1;
        private TabPage pipeline;
        private FlowLayoutPanel flpProposition;
        private FlowLayoutPanel flpQualified;
        private FlowLayoutPanel flpNew;
        private TabPage Customers;
        private Label label2;
        private Label label1;
        private TabPage teams;
        private Button button1;
        private FlowLayoutPanel flpWon;
        private Label lbWon;
        private Label lbProposition;
        private Label lbQualified;
        private Label lbNew;
        private DataGridView dataGridView3;
        private Label label3;
        private Label label5;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private DataGridViewTextBoxColumn teamName;
        private DataGridViewTextBoxColumn teamGender;
        private DataGridViewTextBoxColumn teamEmail;
        private DataGridViewTextBoxColumn teamTitle;
        private DataGridViewTextBoxColumn teamDepartment;
        private DataGridViewTextBoxColumn teamRole;
        private DataGridViewCheckBoxColumn teamActive;
        private DataGridViewTextBoxColumn teamLeads;
        private DataGridViewTextBoxColumn teamOpenLeads;
        private DataGridViewTextBoxColumn teamLostTeams;
        private DataGridViewTextBoxColumn teamLostLeads;
        private DataGridViewTextBoxColumn teamWonLeads;
        private Button btnPipelineAddLead;
        private Button btnCustomersRemoveCustomers;
        private Button btnCustomersAddCustomers;
        private Button btnUpdateFlps;
        private Button btnUpdateDgvCustomer;
        private DataGridView dgvCustomer;
        private Button btnMoreInfoCustomer;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn country;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewButtonColumn1;
        private Label lbLeadName;
        private DataGridView dgvCustomer_Lead;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private Label lbDateEnd;
        private Label lbDateStart;
        private Panel pSettingsModule;
        private Label lbSettings;
        private Button btnRestoreBackup;
        private Button btnSettingsSaveBackup;
        private tbPlaceHolder tbOcupacion;
        private tbPlaceHolder tbDepartment;
        private tbPlaceHolder tbPassword;
        private tbPlaceHolder tbRPassword;
        private tbPlaceHolder tbREmail;
        private tbPlaceHolder tbEmail;
        private tbPlaceHolder tbIdUser;
        private tbPlaceHolder tbReqMileagePricePerKilometer;
        private tbPlaceHolder tbReqMileageTotal;
        private tbPlaceHolder tbReqMileageDestination;
        private tbPlaceHolder tbReqMileageOrigin;
        private tbPlaceHolder tbReqMileageTitle;
        private tbPlaceHolder tbReqMileageMileage;
        private tbPlaceHolder tbReqAllowancesObservations;
        private tbPlaceHolder tbReqAllowancesTitle;
        private tbPlaceHolder tbManAllowancesIdAllowance;
        private tbPlaceHolder tbManAllowancesState;
        private tbPlaceHolder tbManAllowancesEndHour;
        private tbPlaceHolder tbManAllowancesStartHour;
        private tbPlaceHolder tbManAllowancesDate;
        private tbPlaceHolder tbManAllowancesObservations;
        private tbPlaceHolder tbManAllowancesTitle;
        private tbPlaceHolder tbManAllowancesEmail;
        private tbPlaceHolder tbManMileageState;
        private tbPlaceHolder tbManMileageFinal;
        private tbPlaceHolder tbManMileagePricePerKilometer;
        private tbPlaceHolder tbManMileageKilometers;
        private tbPlaceHolder tbManMileageDestination;
        private tbPlaceHolder tbManMileageOrigin;
        private tbPlaceHolder tbManMileageIdMileage;
        private tbPlaceHolder tbManMileageSubcategory;
        private tbPlaceHolder tbManMileageDate;
        private tbPlaceHolder tbManMileageTitle;
        private tbPlaceHolder tbManMileageEmail;
    }
}