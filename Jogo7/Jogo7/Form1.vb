Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tentativas As Integer
        tentativas = 0

        Me.Label3.Text = tentativas


        Dim maximo As Integer

        If Me.RadioButton1.Checked Then
            maximo = 100
        Else
            maximo = 1000
        End If

        Dim gerador As New Random
        Dim numero, tent As Integer
        numero = gerador.Next(maximo + 1)


        tent = InputBox("Tente adivinha no numero")

        While tent <> numero
            If tent > numero Then
                tent = InputBox("O numero é muito alto. Tente novamente")
            Else
                tent = InputBox("O numero é muito baixo. Tente novamente")
            End If
            tentativas += 1
            Me.Label3.Text = tentativas
        End While


        MessageBox.Show("Parabens!!!  Acertou")
        


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label3.Text = "0"
    End Sub
End Class
