Imports System.Runtime.InteropServices
Public Class setset
    Private Sub setset_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim interInteropServices As UInteger
    Private mute As Integer = &H80000
    Private up As Integer = &HA0000
    Private down As Integer = &H90000
    Private WM_APPCOMMAND As Integer = &H319
    <DllImport("user32.dll")>
    Public Shared Function SendMessageW(hWnd As IntPtr, Msg As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function
    '音量加大
    Private Sub btnUp_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(up))
    End Sub
    '靜音
    Private Sub btnZero_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(mute))
        If Button1.Text = "音量關" Then
            Button1.Text = "音量開"
            Button1.BackColor = Color.RoyalBlue
        ElseIf Button1.Text = "音量開" Then
            Button1.Text = "音量關"
            Button1.BackColor = Color.Tomato
        End If
    End Sub
    '音量減小
    Private Sub btnDown_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(down))
    End Sub
End Class