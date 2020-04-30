Public Class Form2

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.addparticipant()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Form1.player(1)
        TextBox2.Text = Form1.player(2)
        TextBox3.Text = Form1.player(3)
        TextBox4.Text = Form1.player(4)
        TextBox5.Text = Form1.player(5)
        TextBox6.Text = Form1.player(6)

        TextBox7.Text = Form1.plr(1)
        TextBox8.Text = Form1.plr(2)
        TextBox9.Text = Form1.plr(3)
        TextBox10.Text = Form1.plr(4)
        TextBox11.Text = Form1.plr(5)
        TextBox12.Text = Form1.plr(6)

        TextBox13.Text = Form1.plrque(1)
        TextBox14.Text = Form1.plrque(2)
        TextBox15.Text = Form1.plrque(3)
        TextBox16.Text = Form1.plrque(4)
        TextBox17.Text = Form1.plrque(5)
        TextBox18.Text = Form1.plrque(6)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.player(1) = TextBox1.Text
        Form1.player(2) = TextBox2.Text
        Form1.player(3) = TextBox3.Text
        Form1.player(4) = TextBox4.Text
        Form1.player(5) = TextBox5.Text
        Form1.player(6) = TextBox6.Text

        Form1.addparticipant()

        Me.Close()
    End Sub

    Public Sub reset_point()
        Form1.Label9.Text = Form1.plrque(1)
        Form1.Label10.Text = Form1.plrque(2)
        Form1.Label11.Text = Form1.plrque(3)
        Form1.Label22.Text = Form1.plrque(4)
        Form1.Label23.Text = Form1.plrque(5)
        Form1.Label24.Text = Form1.plrque(6)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.plr(1) = TextBox7.Text
        Form1.plr(2) = TextBox8.Text
        Form1.plr(3) = TextBox9.Text
        Form1.plr(4) = TextBox10.Text
        Form1.plr(5) = TextBox11.Text
        Form1.plr(6) = TextBox12.Text

        Form1.addparticipant()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.player(1) = TextBox1.Text
        Form1.player(2) = TextBox2.Text
        Form1.player(3) = TextBox3.Text
        Form1.player(4) = TextBox4.Text
        Form1.player(5) = TextBox5.Text
        Form1.player(6) = TextBox6.Text

        Form1.plr(1) = TextBox7.Text
        Form1.plr(2) = TextBox8.Text
        Form1.plr(3) = TextBox9.Text
        Form1.plr(4) = TextBox10.Text
        Form1.plr(5) = TextBox11.Text
        Form1.plr(6) = TextBox12.Text

        Form1.plrque(1) = TextBox13.Text
        Form1.plrque(2) = TextBox14.Text
        Form1.plrque(3) = TextBox15.Text
        Form1.plrque(4) = TextBox16.Text
        Form1.plrque(5) = TextBox17.Text
        Form1.plrque(6) = TextBox18.Text

        Form1.addparticipant()
        reset_point()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.plrque(1) = TextBox13.Text
        Form1.plrque(2) = TextBox14.Text
        Form1.plrque(3) = TextBox15.Text
        Form1.plrque(4) = TextBox16.Text
        Form1.plrque(5) = TextBox17.Text
        Form1.plrque(6) = TextBox18.Text

        reset_point()
        Me.Close()
    End Sub

   
End Class