Imports System.IO

Public Class Form1
    Dim intrvl As Integer = 0
    Dim quotelist As New List(Of String)
    Dim qcount = 0
    Dim qall = 0
    Dim qmethod = "popup"
    Dim menuItem As New MenuItem("Exit")
    Dim popupmenu As New MenuItem("Pop Up")
    Dim tooltipmenu As New MenuItem("Tooltip")
    Dim quotemenu As New MenuItem("Quotes")
    Dim quotestylemenu As New MenuItem("Quote Style")
    Dim quoteintervalmenu As New MenuItem("Quote Interval")
    Dim interval1menu As New MenuItem("Every 1 min.")
    Dim interval5menu As New MenuItem("Every 5 min.")
    Dim interval10menu As New MenuItem("Every 10 min.")
    Dim interval15menu As New MenuItem("Every 15 min.")
    Dim interval20menu As New MenuItem("Every 20 min.")
    Dim qinterval = 10
    Dim workhours = 8

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        intrvl += Timer1.Interval
        ctimeSecondLabel.Text = TimeOfDay.ToString("ss")
        ctimeMinuteLabel.Text = TimeOfDay.ToString("mm")
        ctimehourLabel.Text = TimeOfDay.ToString("HH")
        If (ctimehourLabel.Text = etimehourLabel.Text And ctimeMinuteLabel.Text = etimeMinuteLabel.Text) Then
            Timer1.Stop()
            MessageBox.Show("It's Time to go home.")
        End If

        If (passedSecondsLabel.Text <> "59") Then
            passedSecondsLabel.Text = Format(Val(passedSecondsLabel.Text) + 1, "00")
        Else
            If (passedMinutesLabel.Text <> "59") Then
                passedMinutesLabel.Text = Format(Val(passedMinutesLabel.Text) + 1, "00")
                passedSecondsLabel.Text = "00"
                reloader()
            Else
                passedHoursLabel.Text = Format(Val(passedHoursLabel.Text) + 1, "00")
                passedSecondsLabel.Text = "00"
                passedMinutesLabel.Text = "00"
            End If
        End If


        If (ltimeSecondLabel.Text = "00") Then
            ltimeSecondLabel.Text = "59"
            ltimeMinuteLabel.Text = Format(Val(ltimeMinuteLabel.Text) - 1, "00")
            If (ltimeMinuteLabel.Text = "00") Then
                ltimeHourLabel.Text = Format(Val(ltimeHourLabel.Text) - 1, "00")
            End If
            reloader()
        Else
            ltimeSecondLabel.Text = Format(Val(ltimeSecondLabel.Text) - 1, "00")
        End If

        Dim secondspassed As Integer = passedHoursLabel.Text * 3600 + passedMinutesLabel.Text * 60 + passedSecondsLabel.Text
        secondspassedLabel.Text = Format(secondspassed / (workhours * 3600) * 100, ".00") + "%"
        ProgressBar1.Value = secondspassed / (workhours * 3600) * 100
        If ((passedMinutesLabel.Text Mod qinterval = 0 Or passedMinutesLabel.Text = "00") And passedSecondsLabel.Text = 0) Then
            Randomize()
            If (qmethod = "popup") Then
                MsgBox(quotelist(Int(qall * Rnd())))
            Else
                NotifyIcon1.BalloonTipText = quotelist(Int(qall * Rnd()))
                NotifyIcon1.ShowBalloonTip(20000)
            End If
        End If
        NotifyIcon1.Text = "Work Timer" + vbNewLine + "Time Left: " + ltimeHourLabel.Text + ":" + ltimeMinuteLabel.Text + ":" + ltimeSecondLabel.Text + "(" + Str(Format(secondspassed / (workhours * 3600) * 100, ".00")) + "%)"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Stop()
        reader()
        whours.Text = 8
        CreateContextMenu()
        popupmenu.Checked = True
        interval10menu.Checked = True
        NotifyIcon1.Text = "Work Timer"
    End Sub
    Private Sub loader()
        ctimeSecondLabel.Text = TimeOfDay.ToString("ss")
        ctimeMinuteLabel.Text = TimeOfDay.ToString("mm")
        ctimehourLabel.Text = TimeOfDay.ToString("HH")

        etimehourLabel.Text = Format(Val(stimeHourLabel.Text) + workhours, "00")
        etimeMinuteLabel.Text = Format(Val(stimeMinuteLabel.Text), "00")
        etimeSecondLabel.Text = Format(Val(stimeSecondLabel.Text), "00")


        If (Val(ctimehourLabel.Text) - Val(stimeHourLabel.Text) >= 0) Then
            If (Val(ctimeMinuteLabel.Text) - Val(stimeMinuteLabel.Text) >= 0) Then
                passedHoursLabel.Text = Format(Val(ctimehourLabel.Text - stimeHourLabel.Text), "00")
            Else
                passedHoursLabel.Text = Format(Val(ctimehourLabel.Text - stimeHourLabel.Text) - 1, "00")
            End If
        Else
            passedHoursLabel.Text = Format(Val(ctimehourLabel.Text - stimeHourLabel.Text), "00")
        End If
        If (Val(ctimeMinuteLabel.Text) - Val(stimeMinuteLabel.Text) >= 0) Then
            passedMinutesLabel.Text = Format(Val(ctimeMinuteLabel.Text) - Val(stimeMinuteLabel.Text), "00")
        Else
            passedMinutesLabel.Text = Format(60 - (Val(stimeMinuteLabel.Text) - Val(ctimeMinuteLabel.Text)), "00")
        End If
        If ((Val(ctimeSecondLabel.Text) - Val(stimeSecondLabel.Text) >= 0)) Then
            passedSecondsLabel.Text = Format(Val(ctimeSecondLabel.Text) - Val(stimeSecondLabel.Text), "00")
        Else
            passedSecondsLabel.Text = Format(60 - (stimeSecondLabel.Text - ctimeSecondLabel.Text), "00")
        End If


        If (Val(etimehourLabel.Text) - Val(ctimehourLabel.Text) >= 0) Then
            If (Val(etimeMinuteLabel.Text) - Val(ctimeMinuteLabel.Text) >= 0) Then
                ltimeHourLabel.Text = Format(Val(etimehourLabel.Text - ctimehourLabel.Text) , "00")
            Else
                ltimeHourLabel.Text = Format(Val(etimehourLabel.Text - ctimehourLabel.Text) - 1, "00")
            End If
        End If
        If (Val(etimeMinuteLabel.Text) - Val(ctimeMinuteLabel.Text) >= 0) Then
            ltimeMinuteLabel.Text = Format(Val(etimeMinuteLabel.Text) - Val(ctimeMinuteLabel.Text), "00")
        Else
            ltimeMinuteLabel.Text = Format(60 + Val(etimeMinuteLabel.Text) - Val(ctimeMinuteLabel.Text) - 1, "00")
        End If
        If ((Val(etimeSecondLabel.Text) - Val(ctimeSecondLabel.Text) >= 0)) Then
            ltimeSecondLabel.Text = Format(Val(etimeSecondLabel.Text) - Val(ctimeSecondLabel.Text), "00")

        Else
            ltimeSecondLabel.Text = Format((60 + etimeSecondLabel.Text - ctimeSecondLabel.Text), "00")
        End If

    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        reloader()

    End Sub
    Private Sub reloader()
        Timer1.Stop()
        stimeHourLabel.Text = starthourtb.Text
        stimeMinuteLabel.Text = startmintb.Text
        workhours = whours.Text
        loader()
        Timer1.Start()
    End Sub
    Sub reader()
        Dim reportsFolder As String
        reportsFolder = Path.Combine(Directory.GetCurrentDirectory(), "quotes")
        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(reportsFolder + "/bigquotes.txt",
           System.Text.Encoding.UTF8)
        Dim a As String

        Do
            a = reader.ReadLine
            qall += 1
            quotelist.Add(a)
        Loop Until a Is Nothing
        reader.Close()
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
            If Me.WindowState = FormWindowState.Minimized Then
                Me.Hide()
                NotifyIcon1.Visible = True
            End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
            Me.Show()
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.WindowState = FormWindowState.Normal
            NotifyIcon1.Visible = False
    End Sub

    Public Sub CreateContextMenu()

        Dim contextMenu As New ContextMenu
        contextMenu.MenuItems.Add(quotemenu)
        quotemenu.MenuItems.Add(quotestylemenu)
        quotestylemenu.MenuItems.Add(popupmenu)
        quotestylemenu.MenuItems.Add(tooltipmenu)
        quotemenu.MenuItems.Add(quoteintervalmenu)
        quoteintervalmenu.MenuItems.Add(interval1menu)
        quoteintervalmenu.MenuItems.Add(interval5menu)
        quoteintervalmenu.MenuItems.Add(interval10menu)
        quoteintervalmenu.MenuItems.Add(interval15menu)
        quoteintervalmenu.MenuItems.Add(interval20menu)
        contextMenu.MenuItems.Add(menuItem)
        NotifyIcon1.ContextMenu = contextMenu

        AddHandler menuItem.Click, AddressOf menuItem_Click
        AddHandler popupmenu.Click, AddressOf popupmenu_Click
        AddHandler tooltipmenu.Click, AddressOf tooltipmenu_Click
        AddHandler interval1menu.Click, AddressOf interval1menu_Click
        AddHandler interval5menu.Click, AddressOf interval5menu_Click
        AddHandler interval10menu.Click, AddressOf interval10menu_Click
        AddHandler interval15menu.Click, AddressOf interval15menu_Click
        AddHandler interval20menu.Click, AddressOf interval20menu_Click

    End Sub

    Private Sub menuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub interval5menu_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        qinterval = 5
        interval1menu.Checked = False
        interval5menu.Checked = True
        interval10menu.Checked = False
        interval15menu.Checked = False
        interval20menu.Checked = False
    End Sub

    Private Sub interval1menu_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        qinterval = 1
        interval1menu.Checked = True
        interval5menu.Checked = False
        interval10menu.Checked = False
        interval15menu.Checked = False
        interval20menu.Checked = False
    End Sub

    Private Sub interval10menu_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        qinterval = 10
        interval1menu.Checked = False
        interval5menu.Checked = False
        interval10menu.Checked = True
        interval15menu.Checked = False
        interval20menu.Checked = False
    End Sub

    Private Sub interval15menu_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        qinterval = 15
        interval1menu.Checked = False
        interval5menu.Checked = False
        interval10menu.Checked = False
        interval15menu.Checked = True
        interval20menu.Checked = False
    End Sub

    Private Sub interval20menu_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        qinterval = 20
        interval1menu.Checked = False
        interval5menu.Checked = False
        interval10menu.Checked = False
        interval15menu.Checked = False
        interval20menu.Checked = True
    End Sub

    Private Sub popupmenu_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        qmethod = "popup"
        tooltipmenu.Checked = False
        popupmenu.Checked = True
    End Sub

    Private Sub tooltipmenu_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        qmethod = "tooltip"
        tooltipmenu.Checked = True
        popupmenu.Checked = False
    End Sub

End Class
