﻿Imports DTO.QuanLyDaiLyDTO
Imports System
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Namespace QuanLyDaiLyDAL
    Public Class Shit
        Public connet As SqlConnection
        'Khoi tao ket noi
        Public Sub TaoKetNoi()
            connet = New SqlConnection("Data Source=(localdb)\MINHQUAN-s;Initial Catalog=QuanLyDaiLy;Integrated Security=True")
        End Sub
        'Mo ket noi den CSDL
        Public Function MoKetNoi() As Boolean
            Try
                connet.Open()
                Return True
            Catch ex As Exception
                MessageBox.Show("Kết nối đến CSDL không thành công, vui lòng thử lại", "THÔNG BÁO")
                Return False
            End Try
        End Function
        'Ngat ket noi voi CSDL
        Public Function NgatKetNoi() As Boolean
            Try
                If (connet.State = ConnectionState.Open) Then
                    connet.Close()
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function
        'Kiem tra xem ket noi co dang mo khong
        Public Function DangMo() As Boolean
            If (connet.State = ConnectionState.Open) Then
                Return True
            End If
            Return False
        End Function
        'Lay du lieu tu mot bang
        Public Function LayDuLieu(ByVal tenbang As String) As DataTable
            Dim dtTable As DataTable
            Dim adapter As SqlDataAdapter
            Dim dtSet As DataSet
            dtTable = New DataTable()
            dtSet = New DataSet()
            Try
                adapter = New SqlDataAdapter("SELECT * FROM " + tenbang, connet)
                adapter.Fill(dtSet)
                dtTable = dtSet.Tables(0)
            Catch ex As Exception
                MessageBox.Show("Không tải được dữ liệu", "THÔNG BÁO")
            End Try
            Return dtTable
        End Function
        'Lay du lieu tu bang voi dieu kien cho truoc
        Public Function LayDuLieu(ByVal tenbang As String, ByVal dieukien As String) As DataTable
            Dim dtTable As DataTable
            Dim adapter As SqlDataAdapter
            Dim dtSet As DataSet
            dtTable = New DataTable()
            dtSet = New DataSet()
            Try
                adapter = New SqlDataAdapter("SELECT * FROM " + tenbang + " WHERE " + dieukien, connet)
                adapter.Fill(dtSet)
                dtTable = dtSet.Tables(0)
            Catch ex As Exception
                MessageBox.Show("Không tải được dữ liệu", "THÔNG BÁO")
            End Try
            Return dtTable
        End Function
        'Lay du lieu tu mot thuoc tinh voi dieu kien cho truoc (neu co)
        Public Function LayDuLieu(ByVal tenbang As String, ByVal thuoctinh As String, Optional ByVal dieukien As String = "") As DataTable
            Dim dtTable As DataTable
            Dim adapter As SqlDataAdapter
            Dim dtSet As DataSet
            dtTable = New DataTable()
            dtSet = New DataSet()
            Try
                If (dieukien = "") Then
                    adapter = New SqlDataAdapter("SELECT" + thuoctinh + " FROM " + tenbang, connet)
                Else
                    adapter = New SqlDataAdapter("SELECT" + thuoctinh + " FROM " + tenbang + " WHERE " + dieukien, connet)
                End If
                adapter.Fill(dtSet)
                dtTable = dtSet.Tables(0)
            Catch ex As Exception
                MessageBox.Show("Không tải được dữ liệu", "THÔNG BÁO")
            End Try
            Return dtTable
        End Function

        'Them du lieu vao bang
        Public Sub ThemDuLieu(ByVal tenbang As String, ByVal ParamArray gtthuoctinh As String())
            Dim str As String = ("INSERT INTO " + tenbang + "VALUES('")
            'For Each i As String In gtthuoctinh
            '    str &= i & ","
            'Next
            'str = str.Remove(str.Length - 1, 1)
            'str &= " ) VALUES('"
            For Each i As String In gtthuoctinh
                str &= (i + "','")
            Next
            str = str.Remove(str.Length - 1, 2)
            str &= " )"

            Dim sqlCmd As SqlCommand
            sqlCmd = New SqlCommand(str, connet)
            Try
                sqlCmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("LỖI KHI NHẬP THÔNG TIN VÀO CSDL", "THÔNG BÁO")
            End Try
        End Sub

        'Ham them, xoa, sua, capnhat
    End Class
End Namespace

