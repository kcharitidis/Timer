Imports System.IO

Public Class Form1
    Dim intrvl As Integer = 0
    Dim quotelist As New List(Of String)
    Dim qcount = 0
    Dim qall = 0
    Dim qmethod = "tooltip"
    Dim menuItem As New MenuItem("Exit")
    Dim popupmenu As New MenuItem("PopUp")
    Dim tooltipmenu As New MenuItem("Tooltip")
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
        If (passedMinutesLabel.Text Mod 20 = 0 And passedSecondsLabel.Text = 0) Then
            If (qmethod = "popup") Then
                MsgBox(quotelist(CInt(Math.Ceiling(Rnd() * qall))))
            Else
                NotifyIcon1.BalloonTipText = quotelist(CInt(Math.Ceiling(Rnd() * qall)))
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
        tooltipmenu.Checked = True
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
                ltimeHourLabel.Text = Format(Val(etimehourLabel.Text - ctimehourLabel.Text), "00")
            Else
                ltimeHourLabel.Text = Format(Val(etimehourLabel.Text - ctimehourLabel.Text) - 1, "00")
            End If
        End If
        If (Val(etimeMinuteLabel.Text) - Val(ctimeMinuteLabel.Text) > 0) Then
            ltimeMinuteLabel.Text = Format(Val(etimeMinuteLabel.Text) - Val(ctimeMinuteLabel.Text) - 1, "00")
        ElseIf (Val(etimeMinuteLabel.Text) - Val(ctimeMinuteLabel.Text) = 0) Then
            ltimeMinuteLabel.Text = "00"
        Else
            ltimeMinuteLabel.Text = Format(60 + Val(etimeMinuteLabel.Text) - Val(ctimeMinuteLabel.Text), "00")
        End If
        If ((Val(etimeSecondLabel.Text) - Val(ctimeSecondLabel.Text) >= 0)) Then
            ltimeSecondLabel.Text = Format(Val(etimeSecondLabel.Text) - Val(ctimeSecondLabel.Text), "00")
        Else
            ltimeSecondLabel.Text = Format((60 + etimeSecondLabel.Text - ctimeSecondLabel.Text), "00")
        End If

    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        reloader()
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - 335
        y = Screen.PrimaryScreen.WorkingArea.Height - 250
        Me.Location = New Point(x, y)

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
        contextMenu.MenuItems.Add(popupmenu)
        contextMenu.MenuItems.Add(tooltipmenu)
        contextMenu.MenuItems.Add(menuItem)
        NotifyIcon1.ContextMenu = contextMenu

        AddHandler menuItem.Click, AddressOf menuItem_Click
        AddHandler popupmenu.Click, AddressOf popupmenu_Click
        AddHandler tooltipmenu.Click, AddressOf tooltipmenu_Click

    End Sub

    Private Sub menuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
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
