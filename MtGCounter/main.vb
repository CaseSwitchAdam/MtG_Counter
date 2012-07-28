Public Class main
    Dim m, s, t As Integer
    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        t = 0
        s = 0
        m = 0
        time.Start()
    End Sub

    Private Sub resethealth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resethealth.Click
        player1set.Text = healthdefaults.Text
        player2set.Text = healthdefaults.Text
        player3set.Text = healthdefaults.Text
        player4set.Text = healthdefaults.Text
    End Sub

    Private Sub player1add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player1add.Click
        player1set.Text += 1
    End Sub

    Private Sub player1sub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player1sub.Click
        player1set.Text -= 1
    End Sub

    Private Sub player2add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player2add.Click
        player2set.Text += 1
    End Sub

    Private Sub player2sub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player2sub.Click
        player2set.Text -= 1
    End Sub

    Private Sub player3add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player3add.Click
        player3set.Text += 1
    End Sub

    Private Sub player3sub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player3sub.Click
        player3set.Text -= 1
    End Sub

    Private Sub player4add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player4add.Click
        player4set.Text += 1
    End Sub

    Private Sub player4sub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player4sub.Click
        player4set.Text -= 1
    End Sub

    Private Sub die_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles die.Click
        dielabel.Text = Int(Rnd() * 6) + 1
    End Sub

    Private Sub coin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles coin.Click
        Dim a As Boolean = Int(Rnd() * 2)
        If a = 0 Then
            coinlabel.Text = ("Tails")
        Else
            coinlabel.Text = ("Heads")
        End If

    End Sub

    Private Sub randomgen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles randomgen.Click
        Dim b As Integer = (Rnd() * (random2.Text - random1.Text) + random1.Text)
        definedrandomlabel.Text = b
    End Sub

    Private Sub timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer1.Tick
        timer1.Stop()
        If autoupdate.Checked = True Then
            playerlist1.Items.Add(player1set.Text)
        End If
    End Sub

    Private Sub timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer2.Tick
        timer2.Stop()
        If autoupdate.Checked = True Then
            playerlist2.Items.Add(player2set.Text)
        End If
    End Sub

    Private Sub timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer3.Tick
        timer3.Stop()
        If autoupdate.Checked = True Then
            playerlist3.Items.Add(player3set.Text)
        End If
    End Sub

    Private Sub timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer4.Tick
        timer4.Stop()
        If autoupdate.Checked = True Then
            playerlist4.Items.Add(player4set.Text)
        End If
    End Sub

    Private Sub player1set_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player1set.TextChanged
        timer1.Stop()
        timer1.Start()
    End Sub

    Private Sub player2set_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player2set.TextChanged
        timer2.Stop()
        timer2.Start()
    End Sub

    Private Sub player3set_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player3set.TextChanged
        timer3.Stop()
        timer3.Start()
    End Sub

    Private Sub player4set_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player4set.TextChanged
        timer4.Stop()
        timer4.Start()
    End Sub

    Private Sub clear1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear1.Click
        playerlist1.Items.Clear()
    End Sub

    Private Sub clear2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear2.Click
        playerlist2.Items.Clear()
    End Sub

    Private Sub clear3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear3.Click
        playerlist3.Items.Clear()
    End Sub

    Private Sub clear4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear4.Click
        playerlist4.Items.Clear()
    End Sub

    Private Sub player1update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player1update.Click
        playerlist1.Items.Add(player1set.Text)
    End Sub

    Private Sub player2update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player2update.Click
        playerlist2.Items.Add(player2set.Text)
    End Sub

    Private Sub player3update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player3update.Click
        playerlist3.Items.Add(player3set.Text)
    End Sub

    Private Sub player4update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player4update.Click
        playerlist4.Items.Add(player4set.Text)
    End Sub

    Private Sub Startstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Startstop.Click
        If t = 0 Then
            t = 1
        Else
            t = 0
        End If
    End Sub

    Private Sub time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time.Tick
        If t = 1 Then
            If s > 59 Then
                s = 0
                m = m + 1
            Else
                s = s + 1
            End If
        End If
        If s < 10 Then
            ticker.Text = (m & ":0" & s)
        Else
            ticker.Text = (m & ":" & s)
        End If
    End Sub

    Private Sub timereset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timereset.Click
        m = 0
        s = 0
        ticker.Text = (m & ":" & s)
    End Sub
End Class