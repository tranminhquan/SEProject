﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TiepNhanDaiLy
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThemDaiLy = New DevExpress.XtraBars.BarButtonItem()
        Me.btnXoaDaiLy = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCapNhatDaiLy = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThoat = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvTiepNhanDaiLy = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnXacNhan = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cbTenLoaiDaiLy = New System.Windows.Forms.ComboBox()
        Me.cbQuan = New System.Windows.Forms.ComboBox()
        Me.txbMaDaiLy = New System.Windows.Forms.TextBox()
        Me.txbTenDaiLy = New System.Windows.Forms.TextBox()
        Me.txbDiaChi = New System.Windows.Forms.TextBox()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.txbNgayTiepNhan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rtxbInfo = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.fpnlNote = New DevExpress.Utils.FlyoutPanel()
        Me.lblThongbao = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txbDienThoai = New System.Windows.Forms.TextBox()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvTiepNhanDaiLy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.fpnlNote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fpnlNote.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 782)
        Me.RibbonStatusBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1085, 36)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarButtonItem1, Me.btnThemDaiLy, Me.btnXoaDaiLy, Me.btnCapNhatDaiLy, Me.btnThoat})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RibbonControl1.MaxItemId = 11
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(1085, 168)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ImageIndex = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnThemDaiLy
        '
        Me.btnThemDaiLy.Caption = "Thêm đại lý"
        Me.btnThemDaiLy.Glyph = Global.QuanLyDaiLy.My.Resources.Resources.Button_Add_icon
        Me.btnThemDaiLy.Id = 3
        Me.btnThemDaiLy.Name = "btnThemDaiLy"
        Me.btnThemDaiLy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnXoaDaiLy
        '
        Me.btnXoaDaiLy.Caption = "Xóa đại lý"
        Me.btnXoaDaiLy.Glyph = Global.QuanLyDaiLy.My.Resources.Resources.deleteIcon
        Me.btnXoaDaiLy.Id = 4
        Me.btnXoaDaiLy.Name = "btnXoaDaiLy"
        Me.btnXoaDaiLy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnCapNhatDaiLy
        '
        Me.btnCapNhatDaiLy.Caption = "Cập nhật đại lý"
        Me.btnCapNhatDaiLy.Enabled = False
        Me.btnCapNhatDaiLy.Glyph = Global.QuanLyDaiLy.My.Resources.Resources.updateIcon
        Me.btnCapNhatDaiLy.Id = 5
        Me.btnCapNhatDaiLy.Name = "btnCapNhatDaiLy"
        Me.btnCapNhatDaiLy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnThoat
        '
        Me.btnThoat.Caption = "Thoát"
        Me.btnThoat.Glyph = Global.QuanLyDaiLy.My.Resources.Resources.closeIcon
        Me.btnThoat.Id = 8
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup3, Me.RibbonPageGroup4, Me.RibbonPageGroup5})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Đại Lý"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnThemDaiLy)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnXoaDaiLy)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "RibbonPageGroup3"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnCapNhatDaiLy)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "RibbonPageGroup4"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btnThoat)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "RibbonPageGroup5"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Thêm đại lý"
        Me.BarButtonItem3.Glyph = Global.QuanLyDaiLy.My.Resources.Resources.Button_Add_icon
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.Name = "BarButtonItem3"
        Me.BarButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Thêm đại lý"
        Me.BarButtonItem4.Glyph = Global.QuanLyDaiLy.My.Resources.Resources.Button_Add_icon
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        Me.BarButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnThemDaiLy)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.dgvTiepNhanDaiLy)
        Me.Panel2.Location = New System.Drawing.Point(10, 452)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(775, 315)
        Me.Panel2.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(55, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 21)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "DANH SÁCH ĐẠI LÝ"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.QuanLyDaiLy.My.Resources.Resources.Actions_view_calendar_list_icon
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
        Me.dgvTiepNhanDaiLy.Size = New System.Drawing.Size(775, 276)
        Me.dgvTiepNhanDaiLy.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnXacNhan)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.cbTenLoaiDaiLy)
        Me.Panel1.Controls.Add(Me.cbQuan)
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
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 190)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(773, 260)
        Me.Panel1.TabIndex = 3
        '
        'btnXacNhan
        '
        Me.btnXacNhan.Enabled = False
        Me.btnXacNhan.Image = Global.QuanLyDaiLy.My.Resources.Resources.Ok_icon
        Me.btnXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXacNhan.Location = New System.Drawing.Point(615, 214)
        Me.btnXacNhan.Name = "btnXacNhan"
        Me.btnXacNhan.Size = New System.Drawing.Size(139, 45)
        Me.btnXacNhan.TabIndex = 35
        Me.btnXacNhan.Text = "Xác nhận thêm"
        Me.btnXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXacNhan.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(58, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 21)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "THÔNG TIN ĐẠI LÝ"
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
        Me.cbTenLoaiDaiLy.Location = New System.Drawing.Point(284, 140)
        Me.cbTenLoaiDaiLy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbTenLoaiDaiLy.Name = "cbTenLoaiDaiLy"
        Me.cbTenLoaiDaiLy.Size = New System.Drawing.Size(105, 24)
        Me.cbTenLoaiDaiLy.TabIndex = 31
        '
        'cbQuan
        '
        Me.cbQuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbQuan.FormattingEnabled = True
        Me.cbQuan.Location = New System.Drawing.Point(90, 141)
        Me.cbQuan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbQuan.Name = "cbQuan"
        Me.cbQuan.Size = New System.Drawing.Size(105, 24)
        Me.cbQuan.TabIndex = 30
        '
        'txbMaDaiLy
        '
        Me.txbMaDaiLy.Location = New System.Drawing.Point(90, 50)
        Me.txbMaDaiLy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbMaDaiLy.Name = "txbMaDaiLy"
        Me.txbMaDaiLy.ReadOnly = True
        Me.txbMaDaiLy.Size = New System.Drawing.Size(300, 23)
        Me.txbMaDaiLy.TabIndex = 29
        '
        'txbTenDaiLy
        '
        Me.txbTenDaiLy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbTenDaiLy.Location = New System.Drawing.Point(90, 95)
        Me.txbTenDaiLy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbTenDaiLy.Name = "txbTenDaiLy"
        Me.txbTenDaiLy.ReadOnly = True
        Me.txbTenDaiLy.Size = New System.Drawing.Size(299, 23)
        Me.txbTenDaiLy.TabIndex = 28
        '
        'txbDiaChi
        '
        Me.txbDiaChi.Location = New System.Drawing.Point(520, 141)
        Me.txbDiaChi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbDiaChi.Multiline = True
        Me.txbDiaChi.Name = "txbDiaChi"
        Me.txbDiaChi.ReadOnly = True
        Me.txbDiaChi.Size = New System.Drawing.Size(234, 68)
        Me.txbDiaChi.TabIndex = 26
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(520, 93)
        Me.txbEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.ReadOnly = True
        Me.txbEmail.Size = New System.Drawing.Size(234, 23)
        Me.txbEmail.TabIndex = 25
        '
        'txbNgayTiepNhan
        '
        Me.txbNgayTiepNhan.Location = New System.Drawing.Point(520, 50)
        Me.txbNgayTiepNhan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbNgayTiepNhan.Name = "txbNgayTiepNhan"
        Me.txbNgayTiepNhan.ReadOnly = True
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
        Me.Label7.Location = New System.Drawing.Point(415, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "E-mail:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(207, 143)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 189)
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.rtxbInfo)
        Me.Panel3.Location = New System.Drawing.Point(808, 190)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(253, 255)
        Me.Panel3.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(42, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 21)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "THÔNG TIN"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.QuanLyDaiLy.My.Resources.Resources.infoIcon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 27)
        Me.Button1.TabIndex = 16
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rtxbInfo
        '
        Me.rtxbInfo.Location = New System.Drawing.Point(0, 33)
        Me.rtxbInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtxbInfo.Name = "rtxbInfo"
        Me.rtxbInfo.ReadOnly = True
        Me.rtxbInfo.Size = New System.Drawing.Size(251, 198)
        Me.rtxbInfo.TabIndex = 0
        Me.rtxbInfo.Text = ""
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(532, 68)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(554, 10)
        Me.Button2.TabIndex = 27
        Me.Button2.UseVisualStyleBackColor = True
        '
        'fpnlNote
        '
        Me.fpnlNote.Controls.Add(Me.lblThongbao)
        Me.fpnlNote.Controls.Add(Me.label)
        Me.fpnlNote.Location = New System.Drawing.Point(549, 68)
        Me.fpnlNote.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fpnlNote.Name = "fpnlNote"
        Me.fpnlNote.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top
        Me.fpnlNote.OwnerControl = Me.Button2
        Me.fpnlNote.Size = New System.Drawing.Size(455, 89)
        Me.fpnlNote.TabIndex = 30
        '
        'lblThongbao
        '
        Me.lblThongbao.AutoSize = True
        Me.lblThongbao.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblThongbao.ForeColor = System.Drawing.Color.Red
        Me.lblThongbao.Location = New System.Drawing.Point(154, 32)
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
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'txbDienThoai
        '
        Me.txbDienThoai.Location = New System.Drawing.Point(90, 183)
        Me.txbDienThoai.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbDienThoai.Name = "txbDienThoai"
        Me.txbDienThoai.ReadOnly = True
        Me.txbDienThoai.Size = New System.Drawing.Size(300, 23)
        Me.txbDienThoai.TabIndex = 29
        '
        'TiepNhanDaiLy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 818)
        Me.Controls.Add(Me.fpnlNote)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "TiepNhanDaiLy"
        Me.Ribbon = Me.RibbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "TIẾP NHẬN ĐẠI LÝ"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvTiepNhanDaiLy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.fpnlNote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fpnlNote.ResumeLayout(False)
        Me.fpnlNote.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThemDaiLy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnXoaDaiLy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnCapNhatDaiLy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnThoat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbTenLoaiDaiLy As ComboBox
    Friend WithEvents cbQuan As ComboBox
    Friend WithEvents txbMaDaiLy As TextBox
    Friend WithEvents txbTenDaiLy As TextBox
    Friend WithEvents txbDiaChi As TextBox
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents txbNgayTiepNhan As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvTiepNhanDaiLy As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents rtxbInfo As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents fpnlNote As DevExpress.Utils.FlyoutPanel
    Friend WithEvents label As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblThongbao As Label
    Friend WithEvents btnXacNhan As Button
    Friend WithEvents txbDienThoai As TextBox
End Class
