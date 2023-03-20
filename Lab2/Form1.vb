Public Class Form1
    Dim r As New Random


    Dim betm As Decimal
    Dim leftm As Decimal
    Dim startm As Decimal
    Dim chosen_character As String
    Dim rounds As Integer


    Dim ranking As Integer = 0
    Dim counter1 As Decimal
    Dim counter2 As Decimal
    Dim counter3 As Decimal
    Dim counter4 As Decimal
    Dim counter5 As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'disables buttons when starting game
        btn_startrace.Enabled = False
        btn_nextround.Enabled = False
        tb_moneyleft.Enabled = False

        'stops timers
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timer5.Stop()


    End Sub

    Private Sub btn_startrace_Click(sender As Object, e As EventArgs) Handles btn_startrace.Click

        'increment rounds by 1
        rounds += 1
        lbl_round.Text = "Round: " & rounds
        'enabling start race btn
        btn_startrace.Enabled = False

        'timer starting
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        Timer5.Start()

        'check to see which character is chosen
        chosen_character = GroupBox1.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True).Text

    End Sub

    Private Sub btn_placebet_Click(sender As Object, e As EventArgs) Handles btn_placebet.Click
        chosen_character = GroupBox1.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True).Text

        'validation for money
        If (tb_startmoney.Text = "" Or tb_placebet.Text = "") Then
            MsgBox("Nothing entered, Try Again", MsgBoxStyle.Information)
        Else
            If (IsNumeric(tb_startmoney.Text) And IsNumeric(tb_placebet.Text) AndAlso tb_startmoney.Text > 0 AndAlso tb_placebet.Text > 0) Then
                startm = CType(tb_startmoney.Text, Decimal)
                betm = CType(tb_placebet.Text, Decimal)

                If (startm < betm) Then
                    MsgBox("Betting more than you can afford, try again!", MsgBoxStyle.Critical, "Error")
                ElseIf (lbl_round.Text = "ROUND: X") Then

                    tb_moneyleft.Text = startm
                    leftm = CType(tb_moneyleft.Text, Decimal)
                    tb_placebet.Enabled = False
                    tb_startmoney.Enabled = False
                    btn_placebet.Enabled = False
                    btn_startrace.Enabled = True
                    GroupBox1.Enabled = False

                    'if rounds = 12 or no money left ask if wants to restart or close application
                ElseIf (rounds = 12 Or leftm = 0) Then

                    Dim entry = MsgBox("Looks like the gambling is over, Would you like to restart?", MsgBoxStyle.YesNo, "Restart?")

                    If (entry = 6) Then

                        MsgBox("restarting...")
                        Timer1.Stop()
                        Timer2.Stop()
                        Timer3.Stop()
                        Timer4.Stop()
                        Timer5.Stop()

                        startm = 0
                        leftm = 0
                        betm = 0

                        tb_startmoney.Enabled = True

                        btn_placebet.Enabled = True
                        btn_nextround.Enabled = False
                        btn_startrace.Enabled = False


                        Reset()
                        ResetRound()

                    Else
                        MsgBox("Thank you for using this service!")
                        End
                    End If
                ElseIf (leftm < betm) Then
                    MsgBox("Betting more than you can afford, try again2!", MsgBoxStyle.Critical, "Error")
                Else
                    tb_moneyleft.Text = leftm
                    leftm = CType(tb_moneyleft.Text, Decimal)
                    tb_placebet.Enabled = False
                    tb_startmoney.Enabled = False
                    btn_placebet.Enabled = False
                    btn_startrace.Enabled = False
                    btn_nextround.Enabled = True

                    GroupBox1.Enabled = False


                End If

            Else
                MsgBox("Please enter numbers", MsgBoxStyle.Information)
            End If

            'btn_nextround.Enabled = False

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'random num between 1,10 to fill progress bar
        counter1 += r.Next(1, 10)
        If (counter1 >= 100) Then

            ranking += 1
            lbl_standing1.Text = ranking
            pb_1.Value = 100
            Timer1.Stop()
            checkRace()

        End If

        'make the progress bar move
        If (counter1 <= pb_1.Maximum) Then
            pb_1.Value = counter1
        Else
            counter1 = 0
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'random num between 1,10 to fill progress bar
        counter2 += r.Next(1, 10)
        If (counter2 >= 100) Then

            ranking += 1
            lbl_standing2.Text = ranking
            pb_2.Value = 100
            Timer2.Stop()
            checkRace()

        End If

        'make the progress bar move
        If (counter2 <= pb_2.Maximum) Then
            pb_2.Value = counter2
        Else
            counter2 = 0
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        counter3 += r.Next(1, 10)
        If (counter3 >= 100) Then

            ranking += 1
            lbl_standing3.Text = ranking
            pb_3.Value = 100
            Timer3.Stop()
            checkRace()
        End If

        If (counter3 <= pb_3.Maximum) Then
            pb_3.Value = counter3
        Else
            counter2 = 0
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        counter4 += r.Next(1, 10)
        If (counter4 >= 100) Then

            ranking += 1
            lbl_standing4.Text = ranking
            pb_4.Value = 100
            Timer4.Stop()
            checkRace()
        End If

        If (counter4 <= pb_4.Maximum) Then
            pb_4.Value = counter4
        Else
            counter4 = 0
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        counter5 += r.Next(1, 10)
        If (counter5 >= 100) Then

            ranking += 1
            lbl_standing5.Text = ranking
            pb_5.Value = 100
            Timer5.Stop()
            checkRace()
        End If

        If (counter5 <= pb_5.Maximum) Then
            pb_5.Value = counter5
        Else
            counter5 = 0
        End If
    End Sub

    Sub checkRace()

        'when the ranking hits 5
        If (ranking = 5) Then
            'checkes which character is chosen and see if they are first 
            If (chosen_character = "yellow" AndAlso lbl_standing1.Text = "1") Then
                leftm += betm
                tb_moneyleft.Text = leftm
                betm = 0
                tb_placebet.Enabled = True
                btn_placebet.Enabled = True
                GroupBox1.Enabled = True
                MsgBox("Yellow Wins!")

            ElseIf (chosen_character = "red" AndAlso lbl_standing2.Text = "1") Then
                leftm += betm
                tb_moneyleft.Text = leftm
                betm = 0
                tb_placebet.Enabled = True
                btn_placebet.Enabled = True
                GroupBox1.Enabled = True
                MsgBox("Red Wins!")

            ElseIf (chosen_character = "blue" AndAlso lbl_standing3.Text = "1") Then
                leftm += betm
                tb_moneyleft.Text = leftm
                betm = 0
                tb_placebet.Enabled = True
                btn_placebet.Enabled = True
                GroupBox1.Enabled = True
                MsgBox("Blue Wins!")

            ElseIf (chosen_character = "pink" AndAlso lbl_standing4.Text = "1") Then
                leftm += betm
                tb_moneyleft.Text = leftm
                betm = 0
                tb_placebet.Enabled = True
                btn_placebet.Enabled = True
                GroupBox1.Enabled = True
                MsgBox("Pink Wins!")

            ElseIf (chosen_character = "green" AndAlso lbl_standing5.Text = "1") Then
                leftm += betm
                tb_moneyleft.Text = leftm
                betm = 0
                tb_placebet.Enabled = True
                btn_placebet.Enabled = True
                GroupBox1.Enabled = True
                MsgBox("Green Wins!")

            Else
                'if chosen character is not first than you lost
                MsgBox("Sorry You Lost!")
                leftm -= betm
                tb_moneyleft.Text = leftm
                betm = 0
                tb_placebet.Enabled = True
                btn_placebet.Enabled = True
                GroupBox1.Enabled = True
            End If



        End If
    End Sub

    Private Sub btn_nextround_Click(sender As Object, e As EventArgs) Handles btn_nextround.Click
        'validation
        If (tb_placebet.Text = "") Then
            MsgBox("Nothing entered, Try Again", MsgBoxStyle.Information)
        Else
            If (IsNumeric(tb_placebet.Text) AndAlso tb_placebet.Text > 0) Then
                startm = CType(tb_startmoney.Text, Decimal)
                betm = CType(tb_placebet.Text, Decimal)

                If (startm < betm) Then
                    MsgBox("Betting more than you can afford, try again!", MsgBoxStyle.Critical)
                Else
                    tb_moneyleft.Text = leftm
                    leftm = CType(tb_moneyleft.Text, Decimal)

                    tb_placebet.Enabled = False
                    tb_startmoney.Enabled = False
                    btn_placebet.Enabled = False
                    btn_startrace.Enabled = False
                    'GroupBox1.Enabled = False

                End If

            Else
                MsgBox("Please enter numbers", MsgBoxStyle.Information)
            End If

        End If

        rounds += 1
        lbl_round.Text = "Round: " & rounds


        Reset()

        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Timer4.Enabled = True
        Timer5.Enabled = True
        btn_nextround.Enabled = False

        chosen_character = GroupBox1.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True).Text
    End Sub

    Sub Reset()
        'resetting everything
        counter1 = 0
        counter2 = 0
        counter3 = 0
        counter4 = 0
        counter5 = 0


        ranking = 0


        lbl_standing1.Text = ""
        lbl_standing2.Text = ""
        lbl_standing3.Text = ""
        lbl_standing4.Text = ""
        lbl_standing5.Text = ""




    End Sub

    Sub ResetRound()
        lbl_round.Text = "ROUND: X"
        rounds = 0
    End Sub


End Class
