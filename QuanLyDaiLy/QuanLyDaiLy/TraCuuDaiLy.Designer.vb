﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TraCuuDaiLy
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnTraCuu = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cbTenLoaiDaiLy = New System.Windows.Forms.ComboBox()
        Me.cbSoSanh = New System.Windows.Forms.ComboBox()
        Me.cbQuan = New System.Windows.Forms.ComboBox()
        Me.txbTienNo = New System.Windows.Forms.TextBox()
        Me.txbDienThoai = New System.Windows.Forms.TextBox()
        Me.txbMaDaiLy = New System.Windows.Forms.TextBox()
        Me.txbTenDaiLy = New System.Windows.Forms.TextBox()
        Me.txbDiaChi = New System.Windows.Forms.TextBox()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.txbNgayTiepNhan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvTiepNhanDaiLy = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnThemDaiLy = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.fpnlNote = New DevExpress.Utils.FlyoutPanel()
        Me.lblThongbao = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvTiepNhanDaiLy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.fpnlNote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fpnlNote.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnTraCuu, Me.BarButtonItem3})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RibbonControl.MaxItemId = 3
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(1273, 168)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnTraCuu
        '
        Me.btnTraCuu.Caption = "Tra cứu"
        Me.btnTraCuu.Glyph = Global.QuanLyDaiLy.My.Resources.Resources.Zoom_icon
        Me.btnTraCuu.Id = 1
        Me.btnTraCuu.Name = "btnTraCuu"
        Me.btnTraCuu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Thoát"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.LargeGlyph = Global.QuanLyDaiLy.My.Resources.Resources.closeIcon
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup3})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnTraCuu)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "RibbonPageGroup2"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 693)
        Me.RibbonStatusBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1273, 36)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.cbTenLoaiDaiLy)
        Me.Panel1.Controls.Add(Me.cbSoSanh)
        Me.Panel1.Controls.Add(Me.cbQuan)
        Me.Panel1.Controls.Add(Me.txbTienNo)
        Me.Panel1.Controls.Add(Me.txbDienThoai)
        Me.Panel1.Controls.Add(Me.txbMaDaiLy)
        Me.Panel1.Controls.Add(Me.txbTenDaiLy)
        Me.Panel1.Controls.Add(Me.txbDiaChi)
        Me.Panel1.Controls.Add(Me.txbEmail)
        Me.Panel1.Controls.Add(Me.txbNgayTiepNhan)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 187)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(773, 266)
        Me.Panel1.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(58, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(295, 21)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "THÔNG TIN ĐẠI LÝ CẦN TRA CỨU"
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.QuanLyDaiLy.My.Resources.Resources.note_edit_icon
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel5.Location = New System.Drawing.Point(3, 2)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(47, 41)
        Me.Panel5.TabIndex = 32
        '
        'cbTenLoaiDaiLy
        '
        Me.cbTenLoaiDaiLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTenLoaiDaiLy.FormattingEnabled = True
        Me.cbTenLoaiDaiLy.Location = New System.Drawing.Point(283, 140)
        Me.cbTenLoaiDaiLy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbTenLoaiDaiLy.Name = "cbTenLoaiDaiLy"
        Me.cbTenLoaiDaiLy.Size = New System.Drawing.Size(105, 24)
        Me.cbTenLoaiDaiLy.TabIndex = 31
        '
        'cbSoSanh
        '
        Me.cbSoSanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSoSanh.FormattingEnabled = True
        Me.cbSoSanh.Items.AddRange(New Object() {"Bằng", "Lớn hơn", "Nhỏ hơn"})
        Me.cbSoSanh.Location = New System.Drawing.Point(90, 225)
        Me.cbSoSanh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSoSanh.Name = "cbSoSanh"
        Me.cbSoSanh.Size = New System.Drawing.Size(98, 24)
        Me.cbSoSanh.TabIndex = 30
        '
        'cbQuan
        '
        Me.cbQuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbQuan.FormattingEnabled = True
        Me.cbQuan.Location = New System.Drawing.Point(90, 142)
        Me.cbQuan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbQuan.Name = "cbQuan"
        Me.cbQuan.Size = New System.Drawing.Size(111, 24)
        Me.cbQuan.TabIndex = 30
        '
        'txbTienNo
        '
        Me.txbTienNo.Location = New System.Drawing.Point(204, 226)
        Me.txbTienNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbTienNo.Name = "txbTienNo"
        Me.txbTienNo.Size = New System.Drawing.Size(186, 23)
        Me.txbTienNo.TabIndex = 29
        '
        'txbDienThoai
        '
        Me.txbDienThoai.Location = New System.Drawing.Point(90, 183)
        Me.txbDienThoai.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbDienThoai.Name = "txbDienThoai"
        Me.txbDienThoai.Size = New System.Drawing.Size(300, 23)
        Me.txbDienThoai.TabIndex = 29
        '
        'txbMaDaiLy
        '
        Me.txbMaDaiLy.Location = New System.Drawing.Point(90, 50)
        Me.txbMaDaiLy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbMaDaiLy.Name = "txbMaDaiLy"
        Me.txbMaDaiLy.Size = New System.Drawing.Size(300, 23)
        Me.txbMaDaiLy.TabIndex = 29
        '
        'txbTenDaiLy
        '
        Me.txbTenDaiLy.Location = New System.Drawing.Point(90, 95)
        Me.txbTenDaiLy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbTenDaiLy.Name = "txbTenDaiLy"
        Me.txbTenDaiLy.Size = New System.Drawing.Size(299, 23)
        Me.txbTenDaiLy.TabIndex = 28
        '
        'txbDiaChi
        '
        Me.txbDiaChi.Location = New System.Drawing.Point(520, 142)
        Me.txbDiaChi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbDiaChi.Multiline = True
        Me.txbDiaChi.Name = "txbDiaChi"
        Me.txbDiaChi.Size = New System.Drawing.Size(234, 107)
        Me.txbDiaChi.TabIndex = 26
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(520, 94)
        Me.txbEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(234, 23)
        Me.txbEmail.TabIndex = 25
        '
        'txbNgayTiepNhan
        '
        Me.txbNgayTiepNhan.Location = New System.Drawing.Point(520, 50)
        Me.txbNgayTiepNhan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbNgayTiepNhan.Name = "txbNgayTiepNhan"
        Me.txbNgayTiepNhan.Size = New System.Drawing.Size(234, 23)
        Me.txbNgayTiepNhan.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(415, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Địa chỉ:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(415, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "E-mail:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(209, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Loại đại lý:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(415, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ngày tiếp nhận:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Tiền nợ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Điện thoại:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Quận:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tên đại lý:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mã đại lý:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.dgvTiepNhanDaiLy)
        Me.Panel2.Location = New System.Drawing.Point(12, 466)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(773, 210)
        Me.Panel2.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(55, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(177, 21)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "DANH SÁCH ĐẠI LÝ"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.QuanLyDaiLy.My.Resources.Resources.Zoom_icon
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.Location = New System.Drawing.Point(2, 2)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(45, 37)
        Me.Panel4.TabIndex = 1
        '
        'dgvTiepNhanDaiLy
        '
        Me.dgvTiepNhanDaiLy.AllowUserToAddRows = False
        Me.dgvTiepNhanDaiLy.AllowUserToDeleteRows = False
        Me.dgvTiepNhanDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTiepNhanDaiLy.Location = New System.Drawing.Point(0, 41)
        Me.dgvTiepNhanDaiLy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvTiepNhanDaiLy.Name = "dgvTiepNhanDaiLy"
        Me.dgvTiepNhanDaiLy.ReadOnly = True
        Me.dgvTiepNhanDaiLy.Size = New System.Drawing.Size(773, 166)
        Me.dgvTiepNhanDaiLy.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Location = New System.Drawing.Point(791, 187)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(470, 491)
        Me.Panel3.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(55, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(193, 21)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "BIỂU ĐỒ PHÁT TRIỂN"
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = Global.QuanLyDaiLy.My.Resources.Resources.chart_icon
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel6.Location = New System.Drawing.Point(2, 2)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(45, 37)
        Me.Panel6.TabIndex = 1
        '
        'btnThemDaiLy
        '
        Me.btnThemDaiLy.Caption = "Thêm đại lý"
        Me.btnThemDaiLy.Glyph = Global.QuanLyDaiLy.My.Resources.Resources.Button_Add_icon
        Me.btnThemDaiLy.Id = 3
        Me.btnThemDaiLy.Name = "btnThemDaiLy"
        Me.btnThemDaiLy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Thêm đại lý"
        Me.BarButtonItem1.Glyph = Global.QuanLyDaiLy.My.Resources.Resources.Button_Add_icon
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnThemDaiLy)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup1"
        '
        'fpnlNote
        '
        Me.fpnlNote.Controls.Add(Me.lblThongbao)
        Me.fpnlNote.Controls.Add(Me.label)
        Me.fpnlNote.Location = New System.Drawing.Point(570, 61)
        Me.fpnlNote.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fpnlNote.Name = "fpnlNote"
        Me.fpnlNote.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top
        Me.fpnlNote.OwnerControl = Me.Button2
        Me.fpnlNote.Size = New System.Drawing.Size(640, 89)
        Me.fpnlNote.TabIndex = 32
        '
        'lblThongbao
        '
        Me.lblThongbao.AutoSize = True
        Me.lblThongbao.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lblThongbao.ForeColor = System.Drawing.Color.Red
        Me.lblThongbao.Location = New System.Drawing.Point(171, 34)
        Me.lblThongbao.Name = "lblThongbao"
        Me.lblThongbao.Size = New System.Drawing.Size(0, 17)
        Me.lblThongbao.TabIndex = 1
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.label.ForeColor = System.Drawing.Color.Red
        Me.label.Location = New System.Drawing.Point(23, 32)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(125, 21)
        Me.label.TabIndex = 0
        Me.label.Text = "THÔNG BÁO: "
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(554, 61)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(671, 10)
        Me.Button2.TabIndex = 31
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'TraCuuDaiLy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 729)
        Me.Controls.Add(Me.fpnlNote)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "TraCuuDaiLy"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "TRA CỨU ĐẠI LÝ"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvTiepNhanDaiLy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.fpnlNote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fpnlNote.ResumeLayout(False)
        Me.fpnlNote.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cbTenLoaiDaiLy As ComboBox
    Friend WithEvents cbSoSanh As ComboBox
    Friend WithEvents cbQuan As ComboBox
    Friend WithEvents txbTienNo As TextBox
    Friend WithEvents txbDienThoai As TextBox
    Friend WithEvents txbMaDaiLy As TextBox
    Friend WithEvents txbTenDaiLy As TextBox
    Friend WithEvents txbDiaChi As TextBox
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents txbNgayTiepNhan As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgvTiepNhanDaiLy As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnThemDaiLy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTraCuu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents fpnlNote As DevExpress.Utils.FlyoutPanel
    Friend WithEvents lblThongbao As Label
    Friend WithEvents label As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
End Class
