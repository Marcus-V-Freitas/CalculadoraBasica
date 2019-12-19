Imports ExampleVB1.Modulos
Public Class Form1

    'Events Click
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtResult.Text = CStr(Adicao(CInt(txtNumber1.Text), CInt(txtNumber2.Text)))

    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        txtResult.Text = CStr(Subtracao(CInt(txtNumber1.Text), CInt(txtNumber2.Text)))
    End Sub

    Private Sub btnMul_Click(sender As Object, e As EventArgs) Handles btnMul.Click
        txtResult.Text = CStr(Multiplicacao(CInt(txtNumber1.Text), CInt(txtNumber2.Text)))
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        txtResult.Text = CStr(Divisao(CInt(txtNumber1.Text), CInt(txtNumber2.Text)))
    End Sub

    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        txtResult.Text = CStr(Exponencial(CInt(txtNumber1.Text), CInt(txtNumber2.Text)))
    End Sub

    Private Sub btnFac_Click(sender As Object, e As EventArgs) Handles btnFac.Click
        txtResult.Text = CStr(Fatorial(CInt(txtNumber1.Text)))
    End Sub



End Class
