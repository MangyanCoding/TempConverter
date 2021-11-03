Public Class frmMain
    Dim temp_cel As Double
    Dim temp_fah As Double


    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        If (txtCelsius.Text = "" And txtFahrenheit.Text = "") Then
            MsgBox("Please input one unit of temperature!")
        ElseIf (txtCelsius.Text <> "" And txtFahrenheit.Text <> "") Then
            MsgBox("Please input one unit only!")
        ElseIf (txtCelsius.Text = "" And IsNumeric(txtFahrenheit.Text)) Then
            temp_fah = Val(txtFahrenheit.Text)
            temp_cel = (temp_fah - 32) / 1.8
            txtCelsius.Text = Math.Round(temp_cel, 2)
        ElseIf (txtFahrenheit.Text = "" And IsNumeric(txtCelsius.Text)) Then
            temp_cel = Val(txtCelsius.Text)
            temp_fah = (temp_cel * 1.8) + 32
            txtFahrenheit.Text = Math.Round(temp_fah, 2)
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCelsius.Clear()
        txtFahrenheit.Clear()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
