﻿Imports DTO.QuanLyDaiLyDTO
Namespace QuanLyDaiLyBUS
    Public Class MatHangBUS
        Public Function IsValid_SoLuongTon(MatHang As MatHangDTO) As Boolean
            If MatHang.SoLuongTon < 0 Then
                Return False
            Else
                Return True
            End If
        End Function
    End Class
End Namespace
