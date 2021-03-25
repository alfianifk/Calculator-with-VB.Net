Public Class Calculator
    Dim numSatu, numDua As Double
    Dim operatorAritmatika As String

    Private Sub satu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles satu.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "1"
        Else
            txtInput.Text = "1"
        End If
    End Sub

    Private Sub dua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dua.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "2"
        Else
            txtInput.Text = "2"
        End If
    End Sub

    Private Sub tiga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tiga.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "3"
        Else
            txtInput.Text = "3"
        End If
    End Sub

    Private Sub empat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empat.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "4"
        Else
            txtInput.Text = "4"
        End If
    End Sub
    Private Sub lima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lima.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "5"
        Else
            txtInput.Text = "5"
        End If
    End Sub
    Private Sub enam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enam.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "6"
        Else
            txtInput.Text = "6"
        End If
    End Sub
    Private Sub tujuh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tujuh.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "7"
        Else
            txtInput.Text = "7"
        End If
    End Sub
    Private Sub delapan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delapan.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "8"
        Else
            txtInput.Text = "8"
        End If
    End Sub
    Private Sub sembilan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sembilan.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "9"
        Else
            txtInput.Text = "9"
        End If
    End Sub

    Private Sub nol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nol.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "0"
        Else
            txtInput.Text = "0"
        End If
    End Sub

    Private Sub nolNol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nolNol.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "00"
        Else
            txtInput.Text = "00"
        End If
    End Sub

    Private Sub kali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kali.Click
        numSatu = txtInput.Text
        txtInput.Text = ""
        operatorAritmatika = "*"
    End Sub

    Private Sub tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambah.Click
        numSatu = txtInput.Text
        txtInput.Text = ""
        operatorAritmatika = "+"
    End Sub

    Private Sub kurang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kurang.Click
        numSatu = txtInput.Text
        txtInput.Text = ""
        operatorAritmatika = "-"
    End Sub

    Private Sub bagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bagi.Click
        numSatu = txtInput.Text
        txtInput.Text = ""
        operatorAritmatika = "/"
    End Sub

    Private Sub samaDengan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles samaDengan.Click
        numDua = txtInput.Text
        If operatorAritmatika = "*" Then
            txtInput.Text = numSatu * numDua
        ElseIf operatorAritmatika = "/" Then
            txtInput.Text = numSatu / numDua
        ElseIf operatorAritmatika = "+" Then
            txtInput.Text = numSatu + numDua
        ElseIf operatorAritmatika = "-" Then
            txtInput.Text = numSatu - numDua
        Else
            MsgBox("Mohoh maaf, ada yang salah")
        End If
    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        txtInput.Clear()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        End
    End Sub

    Private Sub titik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles titik.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += ","
        Else
            txtInput.Text = ","
        End If
    End Sub
End Class
