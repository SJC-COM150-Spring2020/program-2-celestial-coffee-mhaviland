Public Class Form1
    Dim Cost As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        Dim Cost As Double

        Dim Address As String
        Dim Name As String

        Name = txtName.Text
        Address = txtAddress.Text

        If radDecafQuarter.Enabled = radDecafQuarter.Checked Then
            Cost = Cost + 3.25
        ElseIf radDecafHalf.Enabled = radDecafHalf.Checked Then
            Cost = Cost + 7.02
        ElseIf radDecafPound.Enabled = radDecafPound.Checked Then
            Cost = Cost + 13.52
        End If

        If radRegQuarter.Enabled = radRegQuarter.Checked Then
            Cost = Cost + 3.25
        ElseIf radRegHalf.Enabled = radRegHalf.Checked Then
            Cost = Cost + 7.02
        ElseIf radRegPound.Enabled = radRegPound.Checked Then
            Cost = Cost + 13.52

        End If

        MessageBox.Show("Name:" & Name & vbNewLine & "Address:" & Address & vbNewLine & "$ " & Cost)

    End Sub

    Private Sub radDecafQuarter_CheckedChanged(sender As Object, e As EventArgs) Handles radDecafQuarter.CheckedChanged
        If radDecafQuarter.Enabled = radDecafQuarter.Checked Then
            Cost = cost + 3.25
        End If
    End Sub
End Class
