﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThayDoiQuyDinh
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.cbApDung = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbMoi = New DevExpress.XtraEditors.TextEdit()
        Me.txbHienTai = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
        CType(Me.txbMoi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txbHienTai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Số đại lý tối đa của mỗi quận:"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(106, 171)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(112, 23)
        Me.btnCapNhat.TabIndex = 3
        Me.btnCapNhat.Text = "Cập nhật quy định"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'cbApDung
        '
        Me.cbApDung.AutoSize = True
        Me.cbApDung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbApDung.Location = New System.Drawing.Point(15, 126)
        Me.cbApDung.Name = "cbApDung"
        Me.cbApDung.Size = New System.Drawing.Size(408, 20)
        Me.cbApDung.TabIndex = 4
        Me.cbApDung.Text = "Áp dụng quy định số tiền thu được vượt quá số tiền đại lý đang nợ"
        Me.cbApDung.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hiện tại:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(357, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mới:"
        '
        'txbMoi
        '
        Me.txbMoi.Location = New System.Drawing.Point(396, 80)
        Me.txbMoi.Name = "txbMoi"
        Me.txbMoi.Properties.Mask.EditMask = "d"
        Me.txbMoi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txbMoi.Size = New System.Drawing.Size(70, 20)
        Me.txbMoi.TabIndex = 7
        '
        'txbHienTai
        '
        Me.txbHienTai.Enabled = False
        Me.txbHienTai.Location = New System.Drawing.Point(262, 80)
        Me.txbHienTai.Name = "txbHienTai"
        Me.txbHienTai.Properties.Mask.EditMask = "d"
        Me.txbHienTai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txbHienTai.Properties.ReadOnly = True
        Me.txbHienTai.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txbHienTai.Size = New System.Drawing.Size(70, 20)
        Me.txbHienTai.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(141, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "THAY ĐỔI QUY ĐỊNH"
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(278, 171)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(112, 23)
        Me.btnThoat.TabIndex = 10
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'ThayDoiQuyDinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 215)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txbHienTai)
        Me.Controls.Add(Me.txbMoi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbApDung)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ThayDoiQuyDinh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "THAY ĐỔI QUY ĐỊNH"
        CType(Me.txbMoi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txbHienTai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents cbApDung As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txbMoi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txbHienTai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents btnThoat As Button
End Class
