Imports System.Threading

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Invoke(New MethodInvoker(Sub() tr0 = MakeString("ABCDEF2", 5)))
        Me.Invoke(New MethodInvoker(Sub() tr1 = MakeString("ABCDEF1234567890", 5)))
        Dim tr2 As String = Nothing
        Me.Invoke(New MethodInvoker(Sub() tr2 = MakeString("ABCDEF1234567890", 10)))
        Dim tr3 As String = Nothing
        Me.Invoke(New MethodInvoker(Sub() tr3 = MakeString("ABCDEF1234567890", 10)))
        Dim tr4 As String = Nothing
        Me.Invoke(New MethodInvoker(Sub() tr4 = MakeString("ABCDEF1234567890", 10)))
        Dim tr5 As String = Nothing
        Me.Invoke(New MethodInvoker(Sub() tr5 = MakeString("ABCDEF1234567890", 10)))
        Dim tr6 As String = Nothing
        Me.Invoke(New MethodInvoker(Sub() tr6 = Program.RandomHeXA(14)))
        Me.Invoke(New MethodInvoker(Sub() Me.TextBox1.Text = tr0 & tr1 & tr2 & tr3 & tr4 & tr5 & tr6))
        Me.Invoke(New MethodInvoker(Sub() Me.TextBox1.Refresh()))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'start
        Call TryingMuchBetter()
    End Sub
    Public Shared w3 As New Object
    Dim ui As Integer = 1, iui As Integer = 1
    Sub TryingMuchBetter()
        '64 strings
        Dim BigRandm As New Random
        Dim RollDiceRandm As New Random
        Dim privKeyHex As String = Nothing
        ' Dim HexString As New List(Of String) From {"1,2,3,4,5,6,7,8,9,0,A,B,C,D,E,F"}
        Dim IntRandm As Integer = BigRandm.Next(1, 64)
        ' Dim Hex64String As String = CreateRandomString("0", 64) 'lll
        Dim yourString As String
        yourString = Me.TextBox1.Text
        Dim RefreshedHex As String

        GoTo 38649
38649:
            'For ui As Integer = 1 To 65 - 1
            'For iui As Integer = 1 To 18 - 1
            Mid(yourString, ui, 1) = iui
        If iui = 10 Then
            Mid(yourString, ui, 1) = "0"
        ElseIf iui = 11 Then
            Mid(yourString, ui, 1) = "A"
        ElseIf iui = 12 Then
            Mid(yourString, ui, 1) = "B"
        ElseIf iui = 13 Then
            Mid(yourString, ui, 1) = "C"
        ElseIf iui = 14 Then
            Mid(yourString, ui, 1) = "D"
        ElseIf iui = 15 Then
            Mid(yourString, ui, 1) = "E"
        ElseIf iui = 16 Then
            Mid(yourString, ui, 1) = "F"
        ElseIf iui = 17 Then
            Dim naj As String = Mid(Me.TextBox1.Text, ui, 1)
            Mid(yourString, ui, 1) = naj
            End If
            RefreshedHex = yourString
            iui += 1
        Me.Invoke(New MethodInvoker(Sub() Me.Label2.Text = RefreshedHex))
        Me.Invoke(New MethodInvoker(Sub() Me.Label2.Refresh()))
        '  GoTo 2345

        If iui >= 18 Then
            ui += 1
            iui = 1
            GoTo 38649
        End If
        If ui >= 64 Then
            Dim tr1 As String = Nothing
            Dim tr0 As String = Nothing
            Me.Invoke(New MethodInvoker(Sub() tr0 = MakeString("ABCDEF2", 5)))
            Me.Invoke(New MethodInvoker(Sub() tr1 = MakeString("ABCDEF1234567890", 5)))
            Dim tr2 As String = Nothing
            Me.Invoke(New MethodInvoker(Sub() tr2 = MakeString("ABCDEF1234567890", 10)))
            Dim tr3 As String = Nothing
            Me.Invoke(New MethodInvoker(Sub() tr3 = MakeString("ABCDEF1234567890", 10)))
            Dim tr4 As String = Nothing
            Me.Invoke(New MethodInvoker(Sub() tr4 = MakeString("ABCDEF1234567890", 10)))
            Dim tr5 As String = Nothing
            Me.Invoke(New MethodInvoker(Sub() tr5 = MakeString("ABCDEF1234567890", 10)))
            Dim tr6 As String = Nothing
            Me.Invoke(New MethodInvoker(Sub() tr6 = Program.RandomHeXA(14)))
            Me.Invoke(New MethodInvoker(Sub() Me.TextBox1.Text = tr0 & tr1 & tr2 & tr3 & tr4 & tr5 & tr6))
            Me.Invoke(New MethodInvoker(Sub() Me.TextBox1.Refresh()))
            ui = 1
            iui = 1
            GoTo 38649
        Else GoTo 38649
            End If

    End Sub
    Private rnd As New Random()
    Public Function MakeString(ByVal styy As String, ByVal i As Integer) As String
        Dim dicts As New List(Of String) ' From {styy}
        For Each gh In styy
            dicts.Add(gh)
        Next
        Dim str As String = ""
        Dim io As Integer = i - 1
        For j As Integer = 0 To io
            str &= dicts.Item(rnd.Next(0, dicts.Count))
        Next j
        Return str
    End Function
End Class
