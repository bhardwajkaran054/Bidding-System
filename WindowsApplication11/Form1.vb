''' <summary>
''' This Software created by Karan Bhardwaj, require any help contact bhardwajkaran054@gmail.com or visit https://karanbhardwaj.me/
''' Get more project vist my GitHub repository https://github.com/bhardwajkaran054/
''' </summary>
''' <remarks></remarks>
Public Class Form1
    Public player(6) As String  'player represent the name of the players
    Public plr(6) As Integer 'plr array represent the credits of all players
    Public plrque(6) As Integer 'number of question credditedto the player account
    Public flag As Boolean = False
    Public wait(6) As Integer
    Public deduct As Integer
    Public tabselect As Integer = 1 'variable for NEXT Button 
    Public MAXTAB As Integer = 16
    'function for deduction
    Public Sub deduction()
        If wait(1) = 1 Then
            plr(1) = plr(1) - deduct
        End If
        If wait(2) = 1 Then
            plr(2) = plr(2) - deduct
        End If
        If wait(3) = 1 Then
            plr(3) = plr(3) - deduct
        End If
        If wait(4) = 1 Then
            plr(4) = plr(4) - deduct
        End If
        If wait(5) = 1 Then
            plr(5) = plr(5) - deduct
        End If
        If wait(6) = 1 Then
            plr(6) = plr(6) - deduct
        End If
    End Sub


    'funtion on set all players name on the labels
    Public Sub addparticipant()

        Label12.Text = player(1)
        Label13.Text = player(2)
        Label14.Text = player(3)
        Label15.Text = player(4)
        Label16.Text = player(5)
        Label2.Text = player(6)

        Label6.Text = plr(1)
        Label17.Text = plr(2)
        Label18.Text = plr(3)
        Label19.Text = plr(4)
        Label20.Text = plr(5)
        Label21.Text = plr(6)

        getgraph()

        'sorting()
    End Sub
    'graph funtion
    Public Sub getgraph()
        Dim i As Integer
        Me.Chart1.Series.Clear()
        Me.Chart1.Series.Add("Money")

        For i = 1 To 6
            Me.Chart1.Series("Money").Points.AddXY(player(i), plr(i))
        Next i

        reset1()
    End Sub
  
    Private Sub AddParticipantToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddParticipantToolStripMenuItem.Click
        player(1) = InputBox("Enter 1st Player Name", "Add Participant", "")
        plr(1) = InputBox("Enter 1st Players Credit", "Add Participant", "")

        player(2) = InputBox("Enter 2nd Player Name", "Add Participant", "")
        plr(2) = InputBox("Enter 2nd Player Credit", "Add Participant", "")

        player(3) = InputBox("Enter 3rd Player Name", "Add Participant", "")
        plr(3) = InputBox("Enter 3rd Player Credit", "Add Participant", "")

        player(4) = InputBox("Enter 4th Player Name", "Add Participant", "")
        plr(4) = InputBox("Enter 4th Player Credit", "Add Participant", "")

        player(5) = InputBox("Enter 5th Player Name", "Add Participant", "")
        plr(5) = InputBox("Enter 5th Player Credit", "Add Participant", "")

        player(6) = InputBox("Enter 6th Player Name", "Add Participant", "")
        plr(6) = InputBox("Enter 6th Player Credit", "Add Participant", "")

        addparticipant()

        MessageBox.Show("Participant added succesfully")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        'set default group name 
        player(1) = "Group1"
        player(2) = "Group2"
        player(3) = "Group3"
        player(4) = "Group4"
        player(5) = "Group5"
        player(6) = "Group6"

        'set default credits
        plr(1) = 100
        plr(2) = 100
        plr(3) = 100
        plr(4) = 100
        plr(5) = 100
        plr(6) = 100

        'set default value 0
        plrque(1) = 0
        plrque(2) = 0
        plrque(3) = 0
        plrque(4) = 0
        plrque(5) = 0
        plrque(6) = 0

        Form2.ShowDialog()
        'addparticipant()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        addparticipant()
        MessageBox.Show("Done")
    End Sub


    Private Sub MinimiseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimiseToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = InputBox("Enter Bid Amount", "Bidding", "")
        If IsNumeric(TextBox1.Text) Then
            PictureBox1.Visible = True
            Button4.Enabled = True
            Button5.Enabled = True
        Else
            MsgBox("Enter Numeric Value !!!", MsgBoxStyle.Exclamation)
            TextBox1.Text = 0
        End If
        
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If flag = True Then
            deduct = TextBox1.Text
            deduction()

        End If
        PictureBox1.Visible = False
        plrque(1) = plrque(1) + 1
        Label9.Text = plrque(1)
        plr(1) = plr(1) - TextBox1.Text
        addparticipant()
    End Sub

    Public Sub reset_button()
        Button4.Enabled = False
        Button7.Enabled = False
        Button10.Enabled = False
        Button15.Enabled = False
        Button16.Enabled = False
        Button17.Enabled = False
        Button5.Enabled = False
        Button11.Enabled = False
        Button8.Enabled = False
        Button18.Enabled = False
        Button19.Enabled = False
        Button20.Enabled = False
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PictureBox1.Visible = False
        PictureBox8.Visible = True
        flag = True
        wait(1) = 1
        reset_button()
        Button3.Visible = False

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox2.Text = InputBox("Enter Bid Amount", "Bidding", "")
        If IsNumeric(TextBox2.Text) Then
            PictureBox2.Visible = True
            Button7.Enabled = True
            Button8.Enabled = True
        Else
            MsgBox("Enter Numeric value!!!", MsgBoxStyle.Exclamation)
            TextBox2.Text = 0
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox3.Text = InputBox("Enter Bid Amount", "Bidding", "")
        If IsNumeric(TextBox3.Text) Then
            PictureBox3.Visible = True
            Button10.Enabled = True
            Button11.Enabled = True
        Else
            MsgBox("Enter Numeric value!!!", MsgBoxStyle.Exclamation)
            TextBox3.Text = 0
        End If
        
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox4.Text = InputBox("Enter Bid Amount", "Bidding", "")
        If IsNumeric(TextBox4.Text) Then
            PictureBox4.Visible = True
            Button15.Enabled = True
            Button18.Enabled = True
        Else
            MsgBox("Enter Numeric value!!!", MsgBoxStyle.Exclamation)
            TextBox4.Text = 0
        End If
     
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox5.Text = InputBox("Enter Bid Amount", "Bidding", "")
        If IsNumeric(TextBox5.Text) Then
            PictureBox5.Visible = True
            Button16.Enabled = True
            Button19.Enabled = True
        Else
            MsgBox("Enter Numeric value!!!", MsgBoxStyle.Exclamation)
            TextBox5.Text = 0
        End If
        
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox6.Text = InputBox("Enter Bid Amount", "Bidding", "")
        If IsNumeric(TextBox6.Text) Then
            PictureBox6.Visible = True
            Button17.Enabled = True
            Button20.Enabled = True
        Else
            MsgBox("Enter Numeric value!!!", MsgBoxStyle.Exclamation)
            TextBox6.Text = 0
        End If
      
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If flag = True Then
            deduct = TextBox2.Text
            deduction()


        End If
        PictureBox2.Visible = False
        plrque(2) = plrque(2) + 1
        Label10.Text = plrque(2)
        plr(2) = plr(2) - TextBox2.Text
        addparticipant()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PictureBox2.Visible = False
        PictureBox9.Visible = True
        wait(2) = 1
        flag = True
        reset_button()
        Button6.Visible = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If flag = True Then
            deduct = TextBox3.Text
            deduction()

        End If
        PictureBox3.Visible = False
        plrque(3) = plrque(3) + 1
        Label11.Text = plrque(3)
        plr(3) = plr(3) - TextBox3.Text
        addparticipant()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        PictureBox3.Visible = False
        PictureBox10.Visible = True
        wait(3) = 1
        flag = True
        reset_button()
        Button9.Visible = False
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        PictureBox4.Visible = False
        PictureBox11.Visible = True
        wait(4) = 1
        flag = True
        reset_button()
        Button12.Visible = False
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If flag = True Then
            deduct = TextBox4.Text
            deduction()

        End If
        PictureBox4.Visible = False
        plrque(4) = plrque(4) + 1
        Label22.Text = plrque(4)
        plr(4) = plr(4) - TextBox4.Text
        addparticipant()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If flag = True Then
            deduct = TextBox5.Text
            deduction()

        End If
        PictureBox5.Visible = False
        plrque(5) = plrque(5) + 1
        Label23.Text = plrque(5)
        plr(5) = plr(5) - TextBox5.Text
        addparticipant()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        PictureBox5.Visible = False
        PictureBox12.Visible = True
        wait(5) = 1
        flag = True
        reset_button()
        Button13.Visible = False
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        PictureBox6.Visible = False
        PictureBox13.Visible = True
        wait(6) = 1
        flag = True
        reset_button()
        Button14.Visible = False
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If flag = True Then
            deduct = TextBox6.Text
            deduction()

        End If
        PictureBox6.Visible = False
        plrque(6) = plrque(6) + 1
        Label24.Text = plrque(6)
        plr(6) = plr(6) - TextBox6.Text
        addparticipant()
    End Sub

    Public Sub reset1()
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox5.Text = 0
        TextBox6.Text = 0
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False

        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        PictureBox13.Visible = False

        Button4.Enabled = False
        Button7.Enabled = False
        Button10.Enabled = False
        Button15.Enabled = False
        Button16.Enabled = False
        Button17.Enabled = False
        Button5.Enabled = False
        Button11.Enabled = False
        Button8.Enabled = False
        Button18.Enabled = False
        Button19.Enabled = False
        Button20.Enabled = False

        Button3.Visible = True
        Button6.Visible = True
        Button9.Visible = True
        Button12.Visible = True
        Button13.Visible = True
        Button14.Visible = True

        flag = False
        wait(1) = 0
        wait(2) = 0
        wait(3) = 0
        wait(4) = 0
        wait(5) = 0
        wait(6) = 0

        'reset base value to 0
        TextBox7.Text = 0
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.ShowDialog()
        ' reset1()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If flag = True Then
            If TextBox7.Text = 0 Then
                TextBox7.Text = InputBox("Enter Base Amount", "Bidding", "")
            End If
            If IsNumeric(TextBox7.Text) Then
                deduct = TextBox7.Text
                deduction()
                addparticipant()
            Else
                MsgBox("Enter Numeric value!!!", MsgBoxStyle.Exclamation)
                TextBox7.Text = ""
                TextBox7.Select()
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

   

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If tabselect < MAXTAB Then
            TabControl1.SelectTab(tabselect)
            tabselect += 1
        End If
        
    End Sub
End Class
