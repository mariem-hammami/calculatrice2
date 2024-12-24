Public Class calculatrice2
    Dim A As String
    Dim B As String
    Dim op = ""
    Private txt_afficher As Object

    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        If op = "" Then
            A = A + "0"
        Else
            B = B + "0"
        End If
        txt_afficher.Text = A + " " + op + " " + B
    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        If op = "" Then
            A = A + "1"
        Else
            B = B + "1"

        End If
        txt_afficher.Text = A + " " + op + " " + B
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        If op = "" Then
            A = A + "2"
        Else
            B = B + "2"
        End If
        txt_afficher.text = A + " " + op + " " + B
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        If op = "" Then
            A = A + "3"
        Else
            B = B + "3"
        End If
        txt_afficher.text = A + " " + op + " " + B
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        If op = "" Then
            A = A + "4"
        Else
            B = B + "4"
        End If
        txt_afficher.text = A + " " + op + " " + B
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        If op = "" Then
            A = A + "5"
        Else
            B = B + "5"

        End If
        txt_afficher.Text = A + " " + op + " " + B
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        If op = "" Then
            A = A + "6"
        Else
            B = B + "6"
        End If
        txt_afficher.Text = A + " " + op + " " + B
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        If op = "" Then
            A = A + "7"
        Else
            B = B + "7"
        End If
        txt_afficher.text = A + " " + op + " " + B
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        If op = "" Then
            A = A + "8"
        Else
            B = B + "8"
        End If
        txt_afficher.Text = A + " " + op + " " + B
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        If op = "" Then
            A = A + "9"
        Else
            B = B + "9"
        End If
        txt_afficher.Text = A + " " + op + " " + B
    End Sub

    Private Sub btn_c_Click(sender As Object, e As EventArgs) Handles btn_c.Click
        txt_afficher.Text = ""
    End Sub

    Private Sub btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        Dim test = True
        Dim res As Double
        If IsNumeric(A) And IsNumeric(B) And Not op = "" Then
            Dim va = Integer.Parse(A)
            Dim vb = Integer.Parse(B)
            If op = "+" Then
                res = va + vb
            ElseIf op = "-" Then
                res = va - vb
            ElseIf op = "*" Then
                res = va * vb
            ElseIf op = "/" And Not op = "" Then
                res = va / vb
            Else
                MessageBox.Show("A et B doivent etre des entiers")
                test = False
            End If
            If test Then
                txt_afficher.text = txt_affiche.text + "=" + res.ToString
            End If
        End If
    End Sub

    Private Sub btn_plus_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        If Not A = "" Then
            op = "+"
        End If
        txt_afficher.text = A + " " + op + " " + B
    End Sub

    Private Sub btn_minus_Click(sender As Object, e As EventArgs) Handles btn_minus.Click
        If Not A = "" Then
            op = "-"
        End If
        txt_afficher.text = A + " " + op + " " + B
    End Sub

    Private Sub btn_mult_Click(sender As Object, e As EventArgs) Handles btn_mult.Click
        If Not A = "" Then
            op = "*"
        End If
        txt_afficher.text = A + " " + op + " " + B
    End Sub

    Private Sub btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        If Not A = "" Then
            op = "/"
        End If
        txt_afficher.text = A + " " + op + " " + B
    End Sub

    Private Sub txt_afficher_TextChanged(sender As Object, e As EventArgs) Handles txt_afficher.TextChanged

    End Sub
End Class
