Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Move The Image Box / Graphic
        ' Dim temp1, temp2, temp3, temp4 As Integer

        Static Xint As Integer = 0
        Dim vehicle As PictureBox
        If (bicycle_box.Visible = True) Then
            vehicle = bicycle_box
        Else
            vehicle = train_box
        End If
        Xint = vehicle.Left
        Static Yint As Integer = vehicle.Top
        Static Width As Integer = vehicle.Width
        Static Height As Integer = vehicle.Height
        'set new x coordinate.

        Xint -= 10
        If (Xint <= vehicle.Width) Then
            Xint = Me.Width
        End If
        'Move Image.
        vehicle.SetBounds(Xint, Yint, Width, Height)
    End Sub

    Private Sub stop_btn_Click_1(sender As Object, e As EventArgs) Handles stop_btn.Click
        Timer1.Stop()

        bicycle_box.Left = 329
        train_box.Left = 329

    End Sub

    Private Sub start_btn_Click_1(sender As Object, e As EventArgs) Handles start_btn.Click
        Timer1.Start()
        Debug.WriteLine("Timer Started")
    End Sub

    Private Sub train_btn_CheckedChanged(sender As Object, e As EventArgs) Handles train_btn.CheckedChanged
        train_box.Visible = True
        bicycle_box.Visible = False
    End Sub

    Private Sub bicycle_btn_CheckedChanged(sender As Object, e As EventArgs) Handles bicycle_btn.CheckedChanged
        train_box.Visible = False
        bicycle_box.Visible = True
    End Sub
End Class
