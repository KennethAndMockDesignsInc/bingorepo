﻿Imports Microsoft.Reporting.WinForms

Public Class Form1
    Dim bestsize As Integer = 11
    Dim letsgoprice As String
    Dim winners As String
    Dim speech As Object = CreateObject("SAPI.SpVoice")



    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click

        BCheckButton.Checked = True
        ICheckButton.Checked = True
        NCheckButton.Checked = True
        GCheckButton.Checked = True
        OCheckButton.Checked = True
        KryptonCheckButton101.Checked = True
        KryptonCheckButton102.Checked = True
        KryptonCheckButton103.Checked = True
        KryptonCheckButton104.Checked = True
        KryptonCheckButton105.Checked = True

        Label1.Text = ""
        KryptonLabel1.Text = ""
        KryptonLabel2.Text = ""
        KryptonLabel3.Text = ""
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ProgressBar1.Value = 0
        Timer1.Stop()
        myanimation.Stop()
        lettertimer.Stop()
        KryptonButton157.Visible = True
        KryptonButton157.Text = "LETS GO BINGO"
        animestarter.Visible = False
        PAUSE.Visible = False
        letterstart.Visible = False
        Dim LOC = (PictureBox1.Location.X) - 315
        Dim loc3 = (PictureBox3.Location.Y)
        PictureBox1.Location = New Point(PictureBox1.Location.X - LOC, PictureBox1.Location.Y)
        PictureBox3.Location = New Point(PictureBox3.Location.X, PictureBox3.Location.Y - loc3)
        Dim numbers = Enumerable.Range(0, 76).ToList()
        Dim RandomClass As New Random()
        Dim RandomIndex As Integer
        For i As Integer = 1 To 75
            RandomIndex = RandomClass.Next(1, numbers.Count)
            ComboBox1.Items.Add(numbers(RandomIndex))
            ComboBox2.Items.Add(numbers(RandomIndex))
            ComboBox3.Items.Add(numbers(RandomIndex))
            numbers.RemoveAt(RandomIndex)
        Next
        KryptonCheckButton1.Checked = False
        KryptonCheckButton2.Checked = False
        KryptonCheckButton3.Checked = False
        KryptonCheckButton4.Checked = False
        KryptonCheckButton5.Checked = False
        KryptonCheckButton6.Checked = False
        KryptonCheckButton7.Checked = False
        KryptonCheckButton8.Checked = False
        KryptonCheckButton9.Checked = False
        KryptonCheckButton10.Checked = False
        KryptonCheckButton11.Checked = False
        KryptonCheckButton12.Checked = False
        KryptonCheckButton13.Checked = False
        KryptonCheckButton14.Checked = False
        KryptonCheckButton15.Checked = False
        KryptonCheckButton16.Checked = False
        KryptonCheckButton17.Checked = False
        KryptonCheckButton18.Checked = False
        KryptonCheckButton19.Checked = False
        KryptonCheckButton20.Checked = False
        KryptonCheckButton21.Checked = False
        KryptonCheckButton22.Checked = False
        KryptonCheckButton23.Checked = False
        KryptonCheckButton24.Checked = False
        KryptonCheckButton25.Checked = False
        KryptonCheckButton26.Checked = False
        KryptonCheckButton27.Checked = False
        KryptonCheckButton28.Checked = False
        KryptonCheckButton29.Checked = False
        KryptonCheckButton30.Checked = False
        KryptonCheckButton31.Checked = False
        KryptonCheckButton32.Checked = False
        KryptonCheckButton33.Checked = False
        KryptonCheckButton34.Checked = False
        KryptonCheckButton35.Checked = False
        KryptonCheckButton36.Checked = False
        KryptonCheckButton37.Checked = False
        KryptonCheckButton38.Checked = False
        KryptonCheckButton39.Checked = False
        KryptonCheckButton40.Checked = False
        KryptonCheckButton41.Checked = False
        KryptonCheckButton42.Checked = False
        KryptonCheckButton43.Checked = False
        KryptonCheckButton44.Checked = False
        KryptonCheckButton45.Checked = False
        KryptonCheckButton46.Checked = False
        KryptonCheckButton47.Checked = False
        KryptonCheckButton48.Checked = False
        KryptonCheckButton49.Checked = False
        KryptonCheckButton50.Checked = False
        KryptonCheckButton51.Checked = False
        KryptonCheckButton52.Checked = False
        KryptonCheckButton53.Checked = False
        KryptonCheckButton54.Checked = False
        KryptonCheckButton55.Checked = False
        KryptonCheckButton56.Checked = False
        KryptonCheckButton57.Checked = False
        KryptonCheckButton58.Checked = False
        KryptonCheckButton59.Checked = False
        KryptonCheckButton60.Checked = False
        KryptonCheckButton61.Checked = False
        KryptonCheckButton62.Checked = False
        KryptonCheckButton63.Checked = False
        KryptonCheckButton64.Checked = False
        KryptonCheckButton65.Checked = False
        KryptonCheckButton66.Checked = False
        KryptonCheckButton67.Checked = False
        KryptonCheckButton68.Checked = False
        KryptonCheckButton69.Checked = False
        KryptonCheckButton70.Checked = False
        KryptonCheckButton71.Checked = False
        KryptonCheckButton72.Checked = False
        KryptonCheckButton73.Checked = False
        KryptonCheckButton74.Checked = False
        KryptonCheckButton75.Checked = False



        a101.Checked = False
        a102.Checked = False
        a103.Checked = False
        a104.Checked = False
        a105.Checked = False
        a106.Checked = False
        a107.Checked = False
        a108.Checked = False
        a109.Checked = False
        a110.Checked = False
        a111.Checked = False
        a112.Checked = False
        a113.Checked = False
        a114.Checked = False
        a115.Checked = False
        a116.Checked = False
        a117.Checked = False
        a118.Checked = False
        a119.Checked = False
        a120.Checked = False
        a121.Checked = False
        a122.Checked = False
        a123.Checked = False
        a124.Checked = False
        a125.Checked = False
        a126.Checked = False
        a127.Checked = False
        a128.Checked = False
        a129.Checked = False
        a130.Checked = False
        a131.Checked = False
        a132.Checked = False
        a133.Checked = False
        a134.Checked = False
        a135.Checked = False
        a136.Checked = False
        a137.Checked = False
        a138.Checked = False
        a139.Checked = False
        a140.Checked = False
        a141.Checked = False
        a142.Checked = False
        a143.Checked = False
        a144.Checked = False
        a145.Checked = False
        a146.Checked = False
        a147.Checked = False
        a148.Checked = False
        a149.Checked = False
        a150.Checked = False
        a151.Checked = False
        a152.Checked = False
        a153.Checked = False
        a154.Checked = False
        a155.Checked = False
        a156.Checked = False
        a157.Checked = False
        a158.Checked = False
        a159.Checked = False
        a160.Checked = False
        a161.Checked = False
        a162.Checked = False
        a163.Checked = False
        a164.Checked = False
        a165.Checked = False
        a166.Checked = False
        a167.Checked = False
        a168.Checked = False
        a169.Checked = False
        a170.Checked = False
        a171.Checked = False
        a172.Checked = False
        a173.Checked = False
        a174.Checked = False
        a175.Checked = False

        a101.Text = ""
        a102.Text = ""
        a103.Text = ""
        a104.Text = ""
        a105.Text = ""
        a106.Text = ""
        a107.Text = ""
        a108.Text = ""
        a109.Text = ""
        a110.Text = ""
        a111.Text = ""
        a112.Text = ""
        a113.Text = ""
        a114.Text = ""
        a115.Text = ""
        a116.Text = ""
        a117.Text = ""
        a118.Text = ""
        a119.Text = ""
        a120.Text = ""
        a121.Text = ""
        a122.Text = ""
        a123.Text = ""
        a124.Text = ""
        a125.Text = ""
        a126.Text = ""
        a127.Text = ""
        a128.Text = ""
        a129.Text = ""
        a130.Text = ""
        a131.Text = ""
        a132.Text = ""
        a133.Text = ""
        a134.Text = ""
        a135.Text = ""
        a136.Text = ""
        a137.Text = ""
        a138.Text = ""
        a139.Text = ""
        a140.Text = ""
        a141.Text = ""
        a142.Text = ""
        a143.Text = ""
        a144.Text = ""
        a145.Text = ""
        a146.Text = ""
        a147.Text = ""
        a148.Text = ""
        a149.Text = ""
        a150.Text = ""
        a151.Text = ""
        a152.Text = ""
        a153.Text = ""
        a154.Text = ""
        a155.Text = ""
        a156.Text = ""
        a157.Text = ""
        a158.Text = ""
        a159.Text = ""
        a160.Text = ""
        a161.Text = ""
        a162.Text = ""
        a163.Text = ""
        a164.Text = ""
        a165.Text = ""
        a166.Text = ""
        a167.Text = ""
        a168.Text = ""
        a169.Text = ""
        a170.Text = ""
        a171.Text = ""
        a172.Text = ""
        a173.Text = ""
        a174.Text = ""
        a175.Text = ""

        PictureBox2.BringToFront()
    End Sub
    Private Sub textAnimation()
        'Dim forb As String
        'If KryptonLabel1.Text = "B" Then
        '    Dim brange = Enumerable.Range(0, 6).ToList()
        '    Dim RandomClass As New Random()
        '    Dim RandomIndex As Integer
        '    RandomIndex = RandomClass.Next(1, brange.Count)
        '    If RandomIndex = 1 Then
        '        forb = "Basement"
        '    ElseIf RandomIndex = 2 Then
        '        forb = "Blame"
        '    ElseIf RandomIndex = 3 Then
        '        forb = "Brain"
        '    ElseIf RandomIndex = 4 Then
        '        forb = "Brake"
        '    ElseIf RandomIndex = 5 Then
        '        forb = "Brush"
        '    End If
        'End If
        Dim bnum As Integer
        bnum = Integer.Parse(ComboBox1.Text)
        PictureBox1.Location = New Point(PictureBox1.Location.X + 5, PictureBox1.Location.Y)
        If PictureBox1.Location.X = 600 Then
            myanimation.Stop()
            Dim LOC = (PictureBox1.Location.X) - 315
            PictureBox1.Location = New Point(PictureBox1.Location.X - LOC, PictureBox1.Location.Y)
            If yesnospeak.Text = "Yes" Then
                Dim v As Integer = myvoice.SelectedIndex
                Dim r As Integer = repeatmyvoice.SelectedIndex
                'speech.Voice = speech.getvoices.item(v)
                'speech.rate = vrate.Text
                'speech.speak("Sah Let Rung")
                'speech.speak(KryptonLabel1.Text)
                'speech.speak(Label1.Text)
                Dim last As String = Label1.Text
                Dim first As String = Label1.Text
                If first.Length > 1 Then
                    first = first.Chars(0)
                    last = last.Substring(last.Length - 1)
                ElseIf first.Length = 1 Then
                    first = Label1.Text
                    last = ""
                End If
                speech.speak(Label1.Text)
                speech.rate = repeatrate.Text
                speech.Voice = speech.getvoices.item(r)
                For m As Integer = 1 To repeattimes.Text

                    speech.speak(KryptonLabel1.Text & "" + "" & first & "" + "" & last & "")
                Next
            ElseIf yesnospeak.Text = "Beep" Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            Else

            End If
            called()

            If ProgressBar1.Value = 75 Then
                    Timer1.Stop()
                    KryptonButton157.Visible = True
                    KryptonButton157.Text = "LETS GO BINGO"
                    animestarter.Visible = False
                    PAUSE.Visible = False
                Else
                    Timer1.Start()
                End If
                PictureBox1.SendToBack()
                mynumbers(bnum)

            End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)

        ComboBox1.SelectedIndex = ProgressBar1.Value - 1
        ComboBox2.SelectedIndex = ProgressBar1.Value - 1
        ComboBox3.SelectedIndex = ProgressBar1.Value - 2
        Dim bnum As Integer
        bnum = Integer.Parse(ComboBox1.Text)

        If BCheckButton.Checked = True Then
            If bnum >= 1 And bnum <= 15 Then
                ComboBox4.Items.Add(ComboBox1.Items(ProgressBar1.Value - 1))
                PictureBox1.BringToFront()
                PictureBox3.BringToFront()
                KryptonLabel1.Text = "B"
                Label1.Text = "" & bnum & ""
                Timer1.Stop()
                lettertimer.Start()

            End If
        End If

        If ICheckButton.Checked = True Then
            If bnum >= 16 And bnum <= 30 Then
                ComboBox4.Items.Add(ComboBox1.Items(ProgressBar1.Value - 1))
                PictureBox1.BringToFront()
                PictureBox3.BringToFront()
                KryptonLabel1.Text = "I"
                Label1.Text = "" & bnum & ""
                Timer1.Stop()
                lettertimer.Start()
            End If
        End If

        If NCheckButton.Checked = True Then
            If bnum >= 31 And bnum <= 45 Then
                ComboBox4.Items.Add(ComboBox1.Items(ProgressBar1.Value - 1))
                PictureBox1.BringToFront()
                PictureBox3.BringToFront()
                KryptonLabel1.Text = "N"
                Label1.Text = "" & bnum & ""
                Timer1.Stop()
                lettertimer.Start()
            End If
        End If

        If GCheckButton.Checked = True Then
            If bnum >= 46 And bnum <= 60 Then
                ComboBox4.Items.Add(ComboBox1.Items(ProgressBar1.Value - 1))
                PictureBox1.BringToFront()
                PictureBox3.BringToFront()
                KryptonLabel1.Text = "G"
                Label1.Text = "" & bnum & ""
                Timer1.Stop()
                lettertimer.Start()
            End If
        End If

        If OCheckButton.Checked = True Then
            If bnum >= 61 And bnum <= 75 Then
                ComboBox4.Items.Add(ComboBox1.Items(ProgressBar1.Value - 1))
                PictureBox1.BringToFront()
                PictureBox3.BringToFront()
                KryptonLabel1.Text = "O"
                Label1.Text = "" & bnum & ""
                Timer1.Stop()
                lettertimer.Start()
            End If
        End If
        lastcall()
        If ProgressBar1.Value = 75 Then
            Timer1.Stop()

        End If
    End Sub

    Private Sub KryptonButton157_Click(sender As Object, e As EventArgs) Handles KryptonButton157.Click
        PictureBox2.SendToBack()
        Timer1.Start()
        Timer1.Interval = ToolStripTextBox1.Text
        ProgressBar1.Maximum = 75
        KryptonButton157.Visible = False
        animestarter.Visible = False
        PAUSE.Visible = True
        letterstart.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        repeatmyvoice.SelectedIndex = 0
        myvoice.SelectedIndex = 0
        vrate.SelectedIndex = 10
        repeatrate.SelectedIndex = 10
        repeattimes.SelectedIndex = 0
        labelspeed.SelectedIndex = 3
        ToolStripTextBox1.SelectedIndex = 1
        ToolStripTextBox2.SelectedIndex = 1
        labelbackcolor.SelectedIndex = 1
        Timer2.Start()
        Timer2.Interval = 500
        Timer3.Start()

        BCheckButton.Checked = True
        ICheckButton.Checked = True
        NCheckButton.Checked = True
        GCheckButton.Checked = True
        OCheckButton.Checked = True
        KryptonCheckButton101.Checked = True
        KryptonCheckButton102.Checked = True
        KryptonCheckButton103.Checked = True
        KryptonCheckButton104.Checked = True
        KryptonCheckButton105.Checked = True

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ProgressBar1.Value = 0
        Label1.Text = ""
        KryptonLabel1.Text = ""
        Dim numbers = Enumerable.Range(0, 76).ToList()
        Dim RandomClass As New Random()
        Dim RandomIndex As Integer
        For i As Integer = 1 To 75
            RandomIndex = RandomClass.Next(1, numbers.Count)
            ComboBox1.Items.Add(numbers(RandomIndex))
            ComboBox2.Items.Add(numbers(RandomIndex))
            ComboBox3.Items.Add(numbers(RandomIndex))
            numbers.RemoveAt(RandomIndex)
        Next
    End Sub
    Public Sub mynumbers(ByVal val As Integer)

        KryptonLabel3.Text = ComboBox4.Items.Count
        If BCheckButton.Checked = True Then

            If val = 1 Then
                KryptonCheckButton1.Checked = True
            End If
            If val = 2 Then
                KryptonCheckButton2.Checked = True
            End If
            If val = 3 Then
                KryptonCheckButton3.Checked = True
            End If
            If val = 4 Then
                KryptonCheckButton4.Checked = True
            End If
            If val = 5 Then
                KryptonCheckButton5.Checked = True
            End If
            If val = 6 Then
                KryptonCheckButton6.Checked = True
            End If
            If val = 7 Then
                KryptonCheckButton7.Checked = True
            End If
            If val = 8 Then
                KryptonCheckButton8.Checked = True
            End If
            If val = 9 Then
                KryptonCheckButton9.Checked = True
            End If
            If val = 10 Then
                KryptonCheckButton10.Checked = True
            End If
            If val = 11 Then
                KryptonCheckButton11.Checked = True
            End If
            If val = 12 Then
                KryptonCheckButton12.Checked = True
            End If
            If val = 13 Then
                KryptonCheckButton13.Checked = True
            End If
            If val = 14 Then
                KryptonCheckButton14.Checked = True
            End If
            If val = 15 Then
                KryptonCheckButton15.Checked = True
            End If
        End If

        If ICheckButton.Checked = True Then
            If val = 16 Then
                KryptonCheckButton16.Checked = True
            End If
            If val = 17 Then
                KryptonCheckButton17.Checked = True
            End If
            If val = 18 Then
                KryptonCheckButton18.Checked = True
            End If
            If val = 19 Then
                KryptonCheckButton19.Checked = True
            End If
            If val = 20 Then
                KryptonCheckButton20.Checked = True
            End If
            If val = 21 Then
                KryptonCheckButton21.Checked = True
            End If
            If val = 22 Then
                KryptonCheckButton22.Checked = True
            End If
            If val = 23 Then
                KryptonCheckButton23.Checked = True
            End If
            If val = 24 Then
                KryptonCheckButton24.Checked = True
            End If
            If val = 25 Then
                KryptonCheckButton25.Checked = True
            End If
            If val = 26 Then
                KryptonCheckButton26.Checked = True
            End If
            If val = 27 Then
                KryptonCheckButton27.Checked = True
            End If
            If val = 28 Then
                KryptonCheckButton28.Checked = True
            End If
            If val = 29 Then
                KryptonCheckButton29.Checked = True
            End If
            If val = 30 Then
                KryptonCheckButton30.Checked = True
            End If
        End If

        If NCheckButton.Checked = True Then
            If val = 31 Then
                KryptonCheckButton31.Checked = True
            End If
            If val = 32 Then
                KryptonCheckButton32.Checked = True
            End If
            If val = 33 Then
                KryptonCheckButton33.Checked = True
            End If
            If val = 34 Then
                KryptonCheckButton34.Checked = True
            End If
            If val = 35 Then
                KryptonCheckButton35.Checked = True
            End If
            If val = 36 Then
                KryptonCheckButton36.Checked = True
            End If
            If val = 37 Then
                KryptonCheckButton37.Checked = True
            End If
            If val = 38 Then
                KryptonCheckButton38.Checked = True
            End If
            If val = 39 Then
                KryptonCheckButton39.Checked = True
            End If
            If val = 40 Then
                KryptonCheckButton40.Checked = True
            End If
            If val = 41 Then
                KryptonCheckButton41.Checked = True
            End If
            If val = 42 Then
                KryptonCheckButton42.Checked = True
            End If
            If val = 43 Then
                KryptonCheckButton43.Checked = True
            End If
            If val = 44 Then
                KryptonCheckButton44.Checked = True
            End If
            If val = 45 Then
                KryptonCheckButton45.Checked = True
            End If
        End If

        If GCheckButton.Checked = True Then
            If val = 46 Then
                KryptonCheckButton46.Checked = True
            End If
            If val = 47 Then
                KryptonCheckButton47.Checked = True
            End If
            If val = 48 Then
                KryptonCheckButton48.Checked = True
            End If
            If val = 49 Then
                KryptonCheckButton49.Checked = True
            End If
            If val = 50 Then
                KryptonCheckButton50.Checked = True
            End If
            If val = 51 Then
                KryptonCheckButton51.Checked = True
            End If
            If val = 52 Then
                KryptonCheckButton52.Checked = True
            End If
            If val = 53 Then
                KryptonCheckButton53.Checked = True
            End If
            If val = 54 Then
                KryptonCheckButton54.Checked = True
            End If
            If val = 55 Then
                KryptonCheckButton55.Checked = True
            End If
            If val = 56 Then
                KryptonCheckButton56.Checked = True
            End If
            If val = 57 Then
                KryptonCheckButton57.Checked = True
            End If
            If val = 58 Then
                KryptonCheckButton58.Checked = True
            End If
            If val = 59 Then
                KryptonCheckButton59.Checked = True
            End If
            If val = 60 Then
                KryptonCheckButton60.Checked = True
            End If
        End If

        If OCheckButton.Checked = True Then
            If val = 61 Then
                KryptonCheckButton61.Checked = True
            End If
            If val = 62 Then
                KryptonCheckButton62.Checked = True
            End If
            If val = 63 Then
                KryptonCheckButton63.Checked = True
            End If
            If val = 64 Then
                KryptonCheckButton64.Checked = True
            End If
            If val = 65 Then
                KryptonCheckButton65.Checked = True
            End If
            If val = 66 Then
                KryptonCheckButton66.Checked = True
            End If
            If val = 67 Then
                KryptonCheckButton67.Checked = True
            End If
            If val = 68 Then
                KryptonCheckButton68.Checked = True
            End If
            If val = 69 Then
                KryptonCheckButton69.Checked = True
            End If
            If val = 70 Then
                KryptonCheckButton70.Checked = True
            End If
            If val = 71 Then
                KryptonCheckButton71.Checked = True
            End If
            If val = 72 Then
                KryptonCheckButton72.Checked = True
            End If
            If val = 73 Then
                KryptonCheckButton73.Checked = True
            End If
            If val = 74 Then
                KryptonCheckButton74.Checked = True
            End If
            If val = 75 Then
                KryptonCheckButton75.Checked = True
            End If
        End If
    End Sub

    Public Sub mynumbersoff(ByVal val As Integer)
        KryptonLabel3.Text = ComboBox4.Items.Count
        If val = 1 Then
            KryptonCheckButton1.Checked = False
        End If
        If val = 2 Then
            KryptonCheckButton2.Checked = False
        End If
        If val = 3 Then
            KryptonCheckButton3.Checked = False
        End If
        If val = 4 Then
            KryptonCheckButton4.Checked = False
        End If
        If val = 5 Then
            KryptonCheckButton5.Checked = False
        End If
        If val = 6 Then
            KryptonCheckButton6.Checked = False
        End If
        If val = 7 Then
            KryptonCheckButton7.Checked = False
        End If
        If val = 8 Then
            KryptonCheckButton8.Checked = False
        End If
        If val = 9 Then
            KryptonCheckButton9.Checked = False
        End If
        If val = 10 Then
            KryptonCheckButton10.Checked = False
        End If
        If val = 11 Then
            KryptonCheckButton11.Checked = False
        End If
        If val = 12 Then
            KryptonCheckButton12.Checked = False
        End If
        If val = 13 Then
            KryptonCheckButton13.Checked = False
        End If
        If val = 14 Then
            KryptonCheckButton14.Checked = False
        End If
        If val = 15 Then
            KryptonCheckButton15.Checked = False
        End If
        If val = 16 Then
            KryptonCheckButton16.Checked = False
        End If
        If val = 17 Then
            KryptonCheckButton17.Checked = False
        End If
        If val = 18 Then
            KryptonCheckButton18.Checked = False
        End If
        If val = 19 Then
            KryptonCheckButton19.Checked = False
        End If
        If val = 20 Then
            KryptonCheckButton20.Checked = False
        End If
        If val = 21 Then
            KryptonCheckButton21.Checked = False
        End If
        If val = 22 Then
            KryptonCheckButton22.Checked = False
        End If
        If val = 23 Then
            KryptonCheckButton23.Checked = False
        End If
        If val = 24 Then
            KryptonCheckButton24.Checked = False
        End If
        If val = 25 Then
            KryptonCheckButton25.Checked = False
        End If
        If val = 26 Then
            KryptonCheckButton26.Checked = False
        End If
        If val = 27 Then
            KryptonCheckButton27.Checked = False
        End If
        If val = 28 Then
            KryptonCheckButton28.Checked = False
        End If
        If val = 29 Then
            KryptonCheckButton29.Checked = False
        End If
        If val = 30 Then
            KryptonCheckButton30.Checked = False
        End If
        If val = 31 Then
            KryptonCheckButton31.Checked = False
        End If
        If val = 32 Then
            KryptonCheckButton32.Checked = False
        End If
        If val = 33 Then
            KryptonCheckButton33.Checked = False
        End If
        If val = 34 Then
            KryptonCheckButton34.Checked = False
        End If
        If val = 35 Then
            KryptonCheckButton35.Checked = False
        End If
        If val = 36 Then
            KryptonCheckButton36.Checked = False
        End If
        If val = 37 Then
            KryptonCheckButton37.Checked = False
        End If
        If val = 38 Then
            KryptonCheckButton38.Checked = False
        End If
        If val = 39 Then
            KryptonCheckButton39.Checked = False
        End If
        If val = 40 Then
            KryptonCheckButton40.Checked = False
        End If
        If val = 41 Then
            KryptonCheckButton41.Checked = False
        End If
        If val = 42 Then
            KryptonCheckButton42.Checked = False
        End If
        If val = 43 Then
            KryptonCheckButton43.Checked = False
        End If
        If val = 44 Then
            KryptonCheckButton44.Checked = False
        End If
        If val = 45 Then
            KryptonCheckButton45.Checked = False
        End If
        If val = 46 Then
            KryptonCheckButton46.Checked = False
        End If
        If val = 47 Then
            KryptonCheckButton47.Checked = False
        End If
        If val = 48 Then
            KryptonCheckButton48.Checked = False
        End If
        If val = 49 Then
            KryptonCheckButton49.Checked = False
        End If
        If val = 50 Then
            KryptonCheckButton50.Checked = False
        End If
        If val = 51 Then
            KryptonCheckButton51.Checked = False
        End If
        If val = 52 Then
            KryptonCheckButton52.Checked = False
        End If
        If val = 53 Then
            KryptonCheckButton53.Checked = False
        End If
        If val = 54 Then
            KryptonCheckButton54.Checked = False
        End If
        If val = 55 Then
            KryptonCheckButton55.Checked = False
        End If
        If val = 56 Then
            KryptonCheckButton56.Checked = False
        End If
        If val = 57 Then
            KryptonCheckButton57.Checked = False
        End If
        If val = 58 Then
            KryptonCheckButton58.Checked = False
        End If
        If val = 59 Then
            KryptonCheckButton59.Checked = False
        End If
        If val = 60 Then
            KryptonCheckButton60.Checked = False
        End If
        If val = 61 Then
            KryptonCheckButton61.Checked = False
        End If
        If val = 62 Then
            KryptonCheckButton62.Checked = False
        End If
        If val = 63 Then
            KryptonCheckButton63.Checked = False
        End If
        If val = 64 Then
            KryptonCheckButton64.Checked = False
        End If
        If val = 65 Then
            KryptonCheckButton65.Checked = False
        End If
        If val = 66 Then
            KryptonCheckButton66.Checked = False
        End If
        If val = 67 Then
            KryptonCheckButton67.Checked = False
        End If
        If val = 68 Then
            KryptonCheckButton68.Checked = False
        End If
        If val = 69 Then
            KryptonCheckButton69.Checked = False
        End If
        If val = 70 Then
            KryptonCheckButton70.Checked = False
        End If
        If val = 71 Then
            KryptonCheckButton71.Checked = False
        End If
        If val = 72 Then
            KryptonCheckButton72.Checked = False
        End If
        If val = 73 Then
            KryptonCheckButton73.Checked = False
        End If
        If val = 74 Then
            KryptonCheckButton74.Checked = False
        End If
        If val = 75 Then
            KryptonCheckButton75.Checked = False
        End If
    End Sub

    Private Sub PREV_Click(sender As Object, e As EventArgs) Handles PREV.Click
        PictureBox2.SendToBack()
        If ComboBox1.Text = "" Then
        Else
            PAUSE.PerformClick()
            Dim vnum As Integer
            vnum = Integer.Parse(ComboBox1.Text)
            mynumbers(vnum)
        End If
        If PictureBox1.Location.X > 600 Then
            Dim LOC = (PictureBox1.Location.X) - 315
            PictureBox1.Location = New Point(PictureBox1.Location.X - LOC, PictureBox1.Location.Y)
        End If
        If ProgressBar1.Value > 1 Then
            ProgressBar1.Value = ProgressBar1.Value - 1

            ComboBox1.SelectedIndex = ProgressBar1.Value - 1
            ComboBox2.SelectedIndex = ProgressBar1.Value
            ComboBox3.SelectedIndex = ProgressBar1.Value - 2
            ComboBox4.Items.Remove(ComboBox1.Items(ProgressBar1.Value))
            Dim bnum As Integer
            mynumbersoff(ComboBox2.Text)
            bnum = Integer.Parse(ComboBox1.Text)
            If BCheckButton.Checked = True Then
                If bnum >= 1 And bnum <= 15 Then
                    Label1.Text = "" & bnum & ""
                    KryptonLabel1.Text = "B"

                End If
            End If

            If ICheckButton.Checked = True Then
                If bnum >= 16 And bnum <= 30 Then
                    Label1.Text = "" & bnum & ""
                    KryptonLabel1.Text = "I"

                End If
            End If

            If NCheckButton.Checked = True Then
                If bnum >= 31 And bnum <= 45 Then
                    Label1.Text = "" & bnum & ""
                    KryptonLabel1.Text = "N"

                End If
            End If

            If GCheckButton.Checked = True Then
                If bnum >= 46 And bnum <= 60 Then
                    Label1.Text = "" & bnum & ""
                    KryptonLabel1.Text = "G"

                End If
            End If

            If OCheckButton.Checked = True Then
                If bnum >= 61 And bnum <= 75 Then
                    Label1.Text = "" & bnum & ""
                    KryptonLabel1.Text = "O"

                End If
            End If
            lastcall()
        End If
        If ProgressBar1.Value < 75 Then
            Timer1.Stop()

        End If
        called()
    End Sub
    Public Sub lastcall()

        If Not ComboBox3.Text = "" Then
            Dim num2 As Integer = Integer.Parse(ComboBox3.Text)
            If BCheckButton.Checked = True Then
                If num2 >= 1 And num2 <= 15 Then
                    KryptonLabel2.Text = "B" + "" & num2 & ""
                End If
            End If

            If ICheckButton.Checked = True Then
                If num2 >= 16 And num2 <= 30 Then
                    KryptonLabel2.Text = "I" + "" & num2 & ""
                End If
            End If

            If NCheckButton.Checked = True Then
                If num2 >= 31 And num2 <= 45 Then
                    KryptonLabel2.Text = "N" + "" & num2 & ""
                End If
            End If

            If GCheckButton.Checked = True Then
                If num2 >= 46 And num2 <= 60 Then
                    KryptonLabel2.Text = "G" + "" & num2 & ""
                End If
            End If

            If OCheckButton.Checked = True Then
                If num2 >= 61 And num2 <= 75 Then
                    KryptonLabel2.Text = "O" + "" & num2 & ""
                End If
            End If
        End If
    End Sub
    Private Sub NEXXT_Click(sender As Object, e As EventArgs) Handles NEXXT.Click

        PictureBox2.SendToBack()

        If ComboBox1.Text = "" Then
        Else
            PAUSE.PerformClick()
            Dim vnum As Integer
            vnum = Integer.Parse(ComboBox1.Text)
            mynumbers(vnum)
        End If
        If PictureBox1.Location.X > 600 Then
            Dim LOC = (PictureBox1.Location.X) - 315
            PictureBox1.Location = New Point(PictureBox1.Location.X - LOC, PictureBox1.Location.Y)
        End If
        If ProgressBar1.Value < 75 Then
            ProgressBar1.Value = ProgressBar1.Value + 1
            ComboBox1.SelectedIndex = ProgressBar1.Value - 1
            ComboBox2.SelectedIndex = ProgressBar1.Value - 1
            ComboBox3.SelectedIndex = ProgressBar1.Value - 2

            Dim bnum As Integer
            bnum = Integer.Parse(ComboBox1.Text)
            mynumbers(bnum)
            If BCheckButton.Checked = True Then
                If bnum >= 1 And bnum <= 15 Then
                    Label1.Text = "" & bnum & ""
                    KryptonLabel1.Text = "B"
                    ComboBox4.Items.Add(ComboBox1.Items(ProgressBar1.Value - 1))
                End If
            End If

            If ICheckButton.Checked = True Then
                If bnum >= 16 And bnum <= 30 Then
                    Label1.Text = "" & bnum & ""
                    KryptonLabel1.Text = "I"
                    ComboBox4.Items.Add(ComboBox1.Items(ProgressBar1.Value - 1))
                End If
            End If

            If NCheckButton.Checked = True Then
                If bnum >= 31 And bnum <= 45 Then
                    Label1.Text = "" & bnum & ""
                    KryptonLabel1.Text = "N"
                    ComboBox4.Items.Add(ComboBox1.Items(ProgressBar1.Value - 1))
                End If
            End If

            If GCheckButton.Checked = True Then
                If bnum >= 46 And bnum <= 60 Then
                    Label1.Text = "" & bnum & ""
                    KryptonLabel1.Text = "G"
                    ComboBox4.Items.Add(ComboBox1.Items(ProgressBar1.Value - 1))
                End If
            End If

            If OCheckButton.Checked = True Then
                If bnum >= 61 And bnum <= 75 Then
                    Label1.Text = "" & bnum & ""
                    KryptonLabel1.Text = "O"
                    ComboBox4.Items.Add(ComboBox1.Items(ProgressBar1.Value - 1))
                End If
            End If
            lastcall()
        End If
        If ProgressBar1.Value = 75 Then
            Timer1.Stop()

        End If
        called()
    End Sub

    Private Sub PAUSE_Click(sender As Object, e As EventArgs) Handles PAUSE.Click
        If Timer1.Enabled = True Then
            Timer1.Stop()
            KryptonButton157.Visible = True
            KryptonButton157.Text = "CONTINUE"
            PAUSE.Visible = False
            animestarter.Visible = False
            letterstart.Visible = False
        ElseIf myanimation.Enabled = True Then
            myanimation.Stop()
            animestarter.Visible = True
            animestarter.Text = "CONTINUE"
            PAUSE.Visible = False
            KryptonButton157.Visible = False
            letterstart.Visible = False
        ElseIf lettertimer.Enabled = True Then
            lettertimer.Stop()
            letterstart.Visible = True
            letterstart.Text = "CONTINUE"
            PAUSE.Visible = False
            animestarter.Visible = False
            KryptonButton157.Visible = False
        End If
    End Sub

    Private Sub KryptonCheckButton1_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton1.Click
        If KryptonCheckButton1.Checked = True Then
            KryptonCheckButton1.Checked = False
        ElseIf KryptonCheckButton1.Checked = False Then
            KryptonCheckButton1.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton2_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton2.Click
        If KryptonCheckButton2.Checked = True Then
            KryptonCheckButton2.Checked = False
        ElseIf KryptonCheckButton2.Checked = False Then
            KryptonCheckButton2.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton3_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton3.Click
        If KryptonCheckButton3.Checked = True Then
            KryptonCheckButton3.Checked = False
        ElseIf KryptonCheckButton3.Checked = False Then
            KryptonCheckButton3.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton4_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton4.Click
        If KryptonCheckButton4.Checked = True Then
            KryptonCheckButton4.Checked = False
        ElseIf KryptonCheckButton4.Checked = False Then
            KryptonCheckButton4.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton5_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton5.Click
        If KryptonCheckButton5.Checked = True Then
            KryptonCheckButton5.Checked = False
        ElseIf KryptonCheckButton5.Checked = False Then
            KryptonCheckButton5.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton6_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton6.Click
        If KryptonCheckButton6.Checked = True Then
            KryptonCheckButton6.Checked = False
        ElseIf KryptonCheckButton6.Checked = False Then
            KryptonCheckButton6.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton7_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton7.Click
        If KryptonCheckButton7.Checked = True Then
            KryptonCheckButton7.Checked = False
        ElseIf KryptonCheckButton7.Checked = False Then
            KryptonCheckButton7.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton8_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton8.Click
        If KryptonCheckButton8.Checked = True Then
            KryptonCheckButton8.Checked = False
        ElseIf KryptonCheckButton8.Checked = False Then
            KryptonCheckButton8.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton9_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton9.Click
        If KryptonCheckButton9.Checked = True Then
            KryptonCheckButton9.Checked = False
        ElseIf KryptonCheckButton9.Checked = False Then
            KryptonCheckButton9.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton10_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton10.Click
        If KryptonCheckButton10.Checked = True Then
            KryptonCheckButton10.Checked = False
        ElseIf KryptonCheckButton10.Checked = False Then
            KryptonCheckButton10.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton11_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton11.Click
        If KryptonCheckButton11.Checked = True Then
            KryptonCheckButton11.Checked = False
        ElseIf KryptonCheckButton11.Checked = False Then
            KryptonCheckButton11.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton12_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton12.Click
        If KryptonCheckButton12.Checked = True Then
            KryptonCheckButton12.Checked = False
        ElseIf KryptonCheckButton12.Checked = False Then
            KryptonCheckButton12.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton13_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton13.Click
        If KryptonCheckButton13.Checked = True Then
            KryptonCheckButton13.Checked = False
        ElseIf KryptonCheckButton13.Checked = False Then
            KryptonCheckButton13.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton14_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton14.Click
        If KryptonCheckButton14.Checked = True Then
            KryptonCheckButton14.Checked = False
        ElseIf KryptonCheckButton14.Checked = False Then
            KryptonCheckButton14.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton15_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton15.Click
        If KryptonCheckButton15.Checked = True Then
            KryptonCheckButton15.Checked = False
        ElseIf KryptonCheckButton15.Checked = False Then
            KryptonCheckButton15.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton16_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton16.Click
        If KryptonCheckButton16.Checked = True Then
            KryptonCheckButton16.Checked = False
        ElseIf KryptonCheckButton16.Checked = False Then
            KryptonCheckButton16.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton17_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton17.Click
        If KryptonCheckButton17.Checked = True Then
            KryptonCheckButton17.Checked = False
        ElseIf KryptonCheckButton17.Checked = False Then
            KryptonCheckButton17.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton18_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton18.Click
        If KryptonCheckButton18.Checked = True Then
            KryptonCheckButton18.Checked = False
        ElseIf KryptonCheckButton18.Checked = False Then
            KryptonCheckButton18.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton19_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton19.Click
        If KryptonCheckButton19.Checked = True Then
            KryptonCheckButton19.Checked = False
        ElseIf KryptonCheckButton19.Checked = False Then
            KryptonCheckButton19.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton20_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton20.Click
        If KryptonCheckButton20.Checked = True Then
            KryptonCheckButton20.Checked = False
        ElseIf KryptonCheckButton20.Checked = False Then
            KryptonCheckButton20.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton21_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton21.Click
        If KryptonCheckButton21.Checked = True Then
            KryptonCheckButton21.Checked = False
        ElseIf KryptonCheckButton21.Checked = False Then
            KryptonCheckButton21.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton22_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton22.Click
        If KryptonCheckButton22.Checked = True Then
            KryptonCheckButton22.Checked = False
        ElseIf KryptonCheckButton22.Checked = False Then
            KryptonCheckButton22.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton23_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton23.Click
        If KryptonCheckButton23.Checked = True Then
            KryptonCheckButton23.Checked = False
        ElseIf KryptonCheckButton23.Checked = False Then
            KryptonCheckButton23.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton24_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton24.Click
        If KryptonCheckButton24.Checked = True Then
            KryptonCheckButton24.Checked = False
        ElseIf KryptonCheckButton24.Checked = False Then
            KryptonCheckButton24.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton25_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton25.Click
        If KryptonCheckButton25.Checked = True Then
            KryptonCheckButton25.Checked = False
        ElseIf KryptonCheckButton25.Checked = False Then
            KryptonCheckButton25.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton26_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton26.Click
        If KryptonCheckButton26.Checked = True Then
            KryptonCheckButton26.Checked = False
        ElseIf KryptonCheckButton26.Checked = False Then
            KryptonCheckButton26.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton27_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton27.Click
        If KryptonCheckButton27.Checked = True Then
            KryptonCheckButton27.Checked = False
        ElseIf KryptonCheckButton27.Checked = False Then
            KryptonCheckButton27.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton28_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton28.Click
        If KryptonCheckButton28.Checked = True Then
            KryptonCheckButton28.Checked = False
        ElseIf KryptonCheckButton28.Checked = False Then
            KryptonCheckButton28.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton29_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton29.Click
        If KryptonCheckButton29.Checked = True Then
            KryptonCheckButton29.Checked = False
        ElseIf KryptonCheckButton29.Checked = False Then
            KryptonCheckButton29.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton30_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton30.Click
        If KryptonCheckButton30.Checked = True Then
            KryptonCheckButton30.Checked = False
        ElseIf KryptonCheckButton30.Checked = False Then
            KryptonCheckButton30.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton31_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton31.Click
        If KryptonCheckButton31.Checked = True Then
            KryptonCheckButton31.Checked = False
        ElseIf KryptonCheckButton31.Checked = False Then
            KryptonCheckButton31.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton32_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton32.Click
        If KryptonCheckButton32.Checked = True Then
            KryptonCheckButton32.Checked = False
        ElseIf KryptonCheckButton32.Checked = False Then
            KryptonCheckButton32.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton33_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton33.Click
        If KryptonCheckButton33.Checked = True Then
            KryptonCheckButton33.Checked = False
        ElseIf KryptonCheckButton33.Checked = False Then
            KryptonCheckButton33.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton34_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton34.Click
        If KryptonCheckButton34.Checked = True Then
            KryptonCheckButton34.Checked = False
        ElseIf KryptonCheckButton34.Checked = False Then
            KryptonCheckButton34.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton35_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton35.Click
        If KryptonCheckButton35.Checked = True Then
            KryptonCheckButton35.Checked = False
        ElseIf KryptonCheckButton35.Checked = False Then
            KryptonCheckButton35.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton36_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton36.Click
        If KryptonCheckButton36.Checked = True Then
            KryptonCheckButton36.Checked = False
        ElseIf KryptonCheckButton36.Checked = False Then
            KryptonCheckButton36.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton37_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton37.Click
        If KryptonCheckButton37.Checked = True Then
            KryptonCheckButton37.Checked = False
        ElseIf KryptonCheckButton37.Checked = False Then
            KryptonCheckButton37.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton38_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton38.Click
        If KryptonCheckButton38.Checked = True Then
            KryptonCheckButton38.Checked = False
        ElseIf KryptonCheckButton38.Checked = False Then
            KryptonCheckButton38.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton39_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton39.Click
        If KryptonCheckButton39.Checked = True Then
            KryptonCheckButton39.Checked = False
        ElseIf KryptonCheckButton39.Checked = False Then
            KryptonCheckButton39.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton40_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton40.Click
        If KryptonCheckButton40.Checked = True Then
            KryptonCheckButton40.Checked = False
        ElseIf KryptonCheckButton40.Checked = False Then
            KryptonCheckButton40.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton41_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton41.Click
        If KryptonCheckButton41.Checked = True Then
            KryptonCheckButton41.Checked = False
        ElseIf KryptonCheckButton41.Checked = False Then
            KryptonCheckButton41.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton42_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton42.Click
        If KryptonCheckButton42.Checked = True Then
            KryptonCheckButton42.Checked = False
        ElseIf KryptonCheckButton42.Checked = False Then
            KryptonCheckButton42.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton43_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton43.Click
        If KryptonCheckButton43.Checked = True Then
            KryptonCheckButton43.Checked = False
        ElseIf KryptonCheckButton43.Checked = False Then
            KryptonCheckButton43.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton44_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton44.Click
        If KryptonCheckButton44.Checked = True Then
            KryptonCheckButton44.Checked = False
        ElseIf KryptonCheckButton44.Checked = False Then
            KryptonCheckButton44.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton45_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton45.Click
        If KryptonCheckButton45.Checked = True Then
            KryptonCheckButton45.Checked = False
        ElseIf KryptonCheckButton45.Checked = False Then
            KryptonCheckButton45.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton46_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton46.Click
        If KryptonCheckButton46.Checked = True Then
            KryptonCheckButton46.Checked = False
        ElseIf KryptonCheckButton46.Checked = False Then
            KryptonCheckButton46.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton47_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton47.Click
        If KryptonCheckButton47.Checked = True Then
            KryptonCheckButton47.Checked = False
        ElseIf KryptonCheckButton47.Checked = False Then
            KryptonCheckButton47.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton48_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton48.Click
        If KryptonCheckButton48.Checked = True Then
            KryptonCheckButton48.Checked = False
        ElseIf KryptonCheckButton48.Checked = False Then
            KryptonCheckButton48.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton49_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton49.Click
        If KryptonCheckButton49.Checked = True Then
            KryptonCheckButton49.Checked = False
        ElseIf KryptonCheckButton49.Checked = False Then
            KryptonCheckButton49.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton50_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton50.Click
        If KryptonCheckButton50.Checked = True Then
            KryptonCheckButton50.Checked = False
        ElseIf KryptonCheckButton50.Checked = False Then
            KryptonCheckButton50.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton51_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton51.Click
        If KryptonCheckButton51.Checked = True Then
            KryptonCheckButton51.Checked = False
        ElseIf KryptonCheckButton51.Checked = False Then
            KryptonCheckButton51.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton52_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton52.Click
        If KryptonCheckButton52.Checked = True Then
            KryptonCheckButton52.Checked = False
        ElseIf KryptonCheckButton52.Checked = False Then
            KryptonCheckButton52.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton53_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton53.Click
        If KryptonCheckButton53.Checked = True Then
            KryptonCheckButton53.Checked = False
        ElseIf KryptonCheckButton53.Checked = False Then
            KryptonCheckButton53.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton54_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton54.Click
        If KryptonCheckButton54.Checked = True Then
            KryptonCheckButton54.Checked = False
        ElseIf KryptonCheckButton54.Checked = False Then
            KryptonCheckButton54.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton55_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton55.Click
        If KryptonCheckButton55.Checked = True Then
            KryptonCheckButton55.Checked = False
        ElseIf KryptonCheckButton55.Checked = False Then
            KryptonCheckButton55.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton56_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton56.Click
        If KryptonCheckButton56.Checked = True Then
            KryptonCheckButton56.Checked = False
        ElseIf KryptonCheckButton56.Checked = False Then
            KryptonCheckButton56.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton57_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton57.Click
        If KryptonCheckButton57.Checked = True Then
            KryptonCheckButton57.Checked = False
        ElseIf KryptonCheckButton57.Checked = False Then
            KryptonCheckButton57.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton58_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton58.Click
        If KryptonCheckButton58.Checked = True Then
            KryptonCheckButton58.Checked = False
        ElseIf KryptonCheckButton58.Checked = False Then
            KryptonCheckButton58.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton59_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton59.Click
        If KryptonCheckButton59.Checked = True Then
            KryptonCheckButton59.Checked = False
        ElseIf KryptonCheckButton59.Checked = False Then
            KryptonCheckButton59.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton60_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton60.Click
        If KryptonCheckButton60.Checked = True Then
            KryptonCheckButton60.Checked = False
        ElseIf KryptonCheckButton60.Checked = False Then
            KryptonCheckButton60.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton61_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton61.Click
        If KryptonCheckButton61.Checked = True Then
            KryptonCheckButton61.Checked = False
        ElseIf KryptonCheckButton61.Checked = False Then
            KryptonCheckButton61.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton62_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton62.Click
        If KryptonCheckButton62.Checked = True Then
            KryptonCheckButton62.Checked = False
        ElseIf KryptonCheckButton62.Checked = False Then
            KryptonCheckButton62.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton63_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton63.Click
        If KryptonCheckButton63.Checked = True Then
            KryptonCheckButton63.Checked = False
        ElseIf KryptonCheckButton63.Checked = False Then
            KryptonCheckButton63.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton64_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton64.Click
        If KryptonCheckButton64.Checked = True Then
            KryptonCheckButton64.Checked = False
        ElseIf KryptonCheckButton64.Checked = False Then
            KryptonCheckButton64.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton65_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton65.Click
        If KryptonCheckButton65.Checked = True Then
            KryptonCheckButton65.Checked = False
        ElseIf KryptonCheckButton65.Checked = False Then
            KryptonCheckButton65.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton66_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton66.Click
        If KryptonCheckButton66.Checked = True Then
            KryptonCheckButton66.Checked = False
        ElseIf KryptonCheckButton66.Checked = False Then
            KryptonCheckButton66.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton67_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton67.Click
        If KryptonCheckButton67.Checked = True Then
            KryptonCheckButton67.Checked = False
        ElseIf KryptonCheckButton67.Checked = False Then
            KryptonCheckButton67.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton68_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton68.Click
        If KryptonCheckButton68.Checked = True Then
            KryptonCheckButton68.Checked = False
        ElseIf KryptonCheckButton68.Checked = False Then
            KryptonCheckButton68.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton69_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton69.Click
        If KryptonCheckButton69.Checked = True Then
            KryptonCheckButton69.Checked = False
        ElseIf KryptonCheckButton69.Checked = False Then
            KryptonCheckButton69.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton70_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton70.Click
        If KryptonCheckButton70.Checked = True Then
            KryptonCheckButton70.Checked = False
        ElseIf KryptonCheckButton70.Checked = False Then
            KryptonCheckButton70.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton71_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton71.Click
        If KryptonCheckButton71.Checked = True Then
            KryptonCheckButton71.Checked = False
        ElseIf KryptonCheckButton71.Checked = False Then
            KryptonCheckButton71.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton72_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton72.Click
        If KryptonCheckButton72.Checked = True Then
            KryptonCheckButton72.Checked = False
        ElseIf KryptonCheckButton72.Checked = False Then
            KryptonCheckButton72.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton73_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton73.Click
        If KryptonCheckButton73.Checked = True Then
            KryptonCheckButton73.Checked = False
        ElseIf KryptonCheckButton73.Checked = False Then
            KryptonCheckButton73.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton74_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton74.Click
        If KryptonCheckButton74.Checked = True Then
            KryptonCheckButton74.Checked = False
        ElseIf KryptonCheckButton74.Checked = False Then
            KryptonCheckButton74.Checked = True
        End If
    End Sub

    Private Sub KryptonCheckButton75_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton75.Click
        If KryptonCheckButton75.Checked = True Then
            KryptonCheckButton75.Checked = False
        ElseIf KryptonCheckButton75.Checked = False Then
            KryptonCheckButton75.Checked = True
        End If
    End Sub

    Private Sub BCheckButton_Click(sender As Object, e As EventArgs) Handles BCheckButton.Click
        If BCheckButton.Checked = True Then
            KryptonCheckButton101.Checked = True
        ElseIf BCheckButton.Checked = False Then
            KryptonCheckButton101.Checked = False
        End If
    End Sub

    Private Sub ICheckButton_Click(sender As Object, e As EventArgs) Handles ICheckButton.Click
        If ICheckButton.Checked = True Then
            KryptonCheckButton102.Checked = True
        ElseIf ICheckButton.Checked = False Then
            KryptonCheckButton102.Checked = False
        End If
    End Sub

    Private Sub NCheckButton_Click(sender As Object, e As EventArgs) Handles NCheckButton.Click
        If NCheckButton.Checked = True Then
            KryptonCheckButton103.Checked = True
        ElseIf NCheckButton.Checked = False Then
            KryptonCheckButton103.Checked = False
        End If
    End Sub

    Private Sub GCheckButton_Click(sender As Object, e As EventArgs) Handles GCheckButton.Click
        If GCheckButton.Checked = True Then
            KryptonCheckButton104.Checked = True
        ElseIf GCheckButton.Checked = False Then
            KryptonCheckButton104.Checked = False
        End If
    End Sub

    Private Sub OCheckButton_Click(sender As Object, e As EventArgs) Handles OCheckButton.Click
        If OCheckButton.Checked = True Then
            KryptonCheckButton105.Checked = True
        ElseIf OCheckButton.Checked = False Then
            KryptonCheckButton105.Checked = False
        End If
    End Sub

    Private Sub KryptonCheckButton101_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton101.Click
        If KryptonCheckButton101.Checked = True Then
            BCheckButton.Checked = True
        ElseIf KryptonCheckButton101.Checked = False Then
            BCheckButton.Checked = False
        End If
    End Sub

    Private Sub KryptonCheckButton102_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton102.Click
        If KryptonCheckButton102.Checked = True Then
            ICheckButton.Checked = True
        ElseIf KryptonCheckButton102.Checked = False Then
            ICheckButton.Checked = False
        End If
    End Sub

    Private Sub KryptonCheckButton103_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton103.Click
        If KryptonCheckButton103.Checked = True Then
            NCheckButton.Checked = True
        ElseIf KryptonCheckButton103.Checked = False Then
            NCheckButton.Checked = False
        End If
    End Sub

    Private Sub KryptonCheckButton104_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton104.Click
        If KryptonCheckButton104.Checked = True Then
            GCheckButton.Checked = True
        ElseIf KryptonCheckButton104.Checked = False Then
            GCheckButton.Checked = False
        End If
    End Sub

    Private Sub KryptonCheckButton105_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton105.Click
        If KryptonCheckButton105.Checked = True Then
            OCheckButton.Checked = True
        ElseIf KryptonCheckButton105.Checked = False Then
            OCheckButton.Checked = False
        End If
    End Sub

    Private Sub InsideSquareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsideSquareToolStripMenuItem.Click
        a1.Checked = False
        a2.Checked = False
        a3.Checked = True
        a4.Checked = False
        a5.Checked = False
        b1.Checked = False
        b2.Checked = False
        b3.Checked = True
        b4.Checked = False
        b5.Checked = False
        c1.Checked = False
        c2.Checked = False

        c4.Checked = False
        c5.Checked = False
        d1.Checked = False
        d2.Checked = False
        d3.Checked = True
        d4.Checked = False
        d5.Checked = False
        e1.Checked = False
        e2.Checked = False
        e3.Checked = True
        e4.Checked = False
        e5.Checked = False

        a11.Checked = False
        a22.Checked = False
        a33.Checked = True
        a44.Checked = False
        a55.Checked = False
        b11.Checked = False
        b22.Checked = False
        b33.Checked = True
        b44.Checked = False
        b55.Checked = False
        c11.Checked = False
        c22.Checked = False

        c44.Checked = False
        c55.Checked = False
        d11.Checked = False
        d22.Checked = False
        d33.Checked = True
        d44.Checked = False
        d55.Checked = False
        e11.Checked = False
        e22.Checked = False
        e33.Checked = True
        e44.Checked = False
        e55.Checked = False

        letsgoprice = "PRICE: " + insidesquareprice.Text
        KryptonNumericUpDown1.Text = insidesquarewinner.Text
        Label2.Text = letsgoprice
        labeltext.Text = "Any Horizontal Line"

    End Sub

    Private Sub myanimation_Tick(sender As Object, e As EventArgs) Handles myanimation.Tick
        textAnimation()
    End Sub
    Private Sub animestarter_Click(sender As Object, e As EventArgs) Handles animestarter.Click
        myanimation.Start()
        KryptonButton157.Visible = False
        PAUSE.Visible = True
        animestarter.Visible = False
        letterstart.Visible = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label2.Text = letsgoprice Then
            Label2.Text = " "
        ElseIf Label2.Text = " " Then
            Label2.Text = letsgoprice
        End If
        KryptonHeaderGroup1.ValuesSecondary.Heading = Label2.Text
        KryptonHeaderGroup2.ValuesSecondary.Heading = Label2.Text
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        a1.Checked = True
        a2.Checked = True
        a3.Checked = True
        a4.Checked = True
        a5.Checked = True
        b1.Checked = False
        b2.Checked = False
        b3.Checked = False
        b4.Checked = False
        b5.Checked = False
        c1.Checked = False
        c2.Checked = False

        c4.Checked = False
        c5.Checked = False
        d1.Checked = False
        d2.Checked = False
        d3.Checked = False
        d4.Checked = False
        d5.Checked = False
        e1.Checked = False
        e2.Checked = False
        e3.Checked = False
        e4.Checked = False
        e5.Checked = False

        a11.Checked = True
        a22.Checked = True
        a33.Checked = True
        a44.Checked = True
        a55.Checked = True
        b11.Checked = False
        b22.Checked = False
        b33.Checked = False
        b44.Checked = False
        b55.Checked = False
        c11.Checked = False
        c22.Checked = False

        c44.Checked = False
        c55.Checked = False
        d11.Checked = False
        d22.Checked = False
        d33.Checked = False
        d44.Checked = False
        d55.Checked = False
        e11.Checked = False
        e22.Checked = False
        e33.Checked = False
        e44.Checked = False
        e55.Checked = False

        letsgoprice = "PRICE: " + horizontalprice.Text
        KryptonNumericUpDown1.Text = horizontalwinner.Text
        Label2.Text = letsgoprice
        labeltext.Text = "Any Vertical Line"
    End Sub

    Private Sub KToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KToolStripMenuItem.Click
        a1.Checked = True
        a2.Checked = True
        a3.Checked = True
        a4.Checked = True
        a5.Checked = True
        b1.Checked = False
        b2.Checked = False
        b3.Checked = True
        b4.Checked = False
        b5.Checked = False
        c1.Checked = False
        c2.Checked = False

        c4.Checked = False
        c5.Checked = False
        d1.Checked = False
        d2.Checked = True
        d3.Checked = False
        d4.Checked = True
        d5.Checked = False
        e1.Checked = True
        e2.Checked = False
        e3.Checked = False
        e4.Checked = False
        e5.Checked = True

        a11.Checked = True
        a22.Checked = True
        a33.Checked = True
        a44.Checked = True
        a55.Checked = True
        b11.Checked = False
        b22.Checked = False
        b33.Checked = True
        b44.Checked = False
        b55.Checked = False
        c11.Checked = False
        c22.Checked = False

        c44.Checked = False
        c55.Checked = False
        d11.Checked = False
        d22.Checked = True
        d33.Checked = False
        d44.Checked = True
        d55.Checked = False
        e11.Checked = True
        e22.Checked = False
        e33.Checked = False
        e44.Checked = False
        e55.Checked = True

        letsgoprice = "PRICE: " + kprice.Text
        KryptonNumericUpDown1.Text = kwinner.Text
        Label2.Text = letsgoprice
        labeltext.Text = "K"
    End Sub

    Private Sub MToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MToolStripMenuItem.Click
        a1.Checked = True
        a2.Checked = True
        a3.Checked = True
        a4.Checked = True
        a5.Checked = True
        b1.Checked = False
        b2.Checked = True
        b3.Checked = False
        b4.Checked = False
        b5.Checked = False
        c1.Checked = False
        c2.Checked = False

        c4.Checked = False
        c5.Checked = False
        d1.Checked = False
        d2.Checked = True
        d3.Checked = False
        d4.Checked = False
        d5.Checked = False
        e1.Checked = True
        e2.Checked = True
        e3.Checked = True
        e4.Checked = True
        e5.Checked = True

        a11.Checked = True
        a22.Checked = True
        a33.Checked = True
        a44.Checked = True
        a55.Checked = True
        b11.Checked = False
        b22.Checked = True
        b33.Checked = False
        b44.Checked = False
        b55.Checked = False
        c11.Checked = False
        c22.Checked = False

        c44.Checked = False
        c55.Checked = False
        d11.Checked = False
        d22.Checked = True
        d33.Checked = False
        d44.Checked = False
        d55.Checked = False
        e11.Checked = True
        e22.Checked = True
        e33.Checked = True
        e44.Checked = True
        e55.Checked = True

        letsgoprice = "PRICE: " + mprice.Text
        KryptonNumericUpDown1.Text = mwinner.Text
        Label2.Text = letsgoprice
        labeltext.Text = "M"
    End Sub

    Private Sub DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DToolStripMenuItem.Click
        a1.Checked = True
        a2.Checked = True
        a3.Checked = True
        a4.Checked = True
        a5.Checked = True
        b1.Checked = True
        b2.Checked = False
        b3.Checked = False
        b4.Checked = False
        b5.Checked = True
        c1.Checked = True
        c2.Checked = False

        c4.Checked = False
        c5.Checked = True
        d1.Checked = True
        d2.Checked = False
        d3.Checked = False
        d4.Checked = False
        d5.Checked = True
        e1.Checked = False
        e2.Checked = True
        e3.Checked = True
        e4.Checked = True
        e5.Checked = False

        a11.Checked = True
        a22.Checked = True
        a33.Checked = True
        a44.Checked = True
        a55.Checked = True
        b11.Checked = True
        b22.Checked = False
        b33.Checked = False
        b44.Checked = False
        b55.Checked = True
        c11.Checked = True
        c22.Checked = False

        c44.Checked = False
        c55.Checked = True
        d11.Checked = True
        d22.Checked = False
        d33.Checked = False
        d44.Checked = False
        d55.Checked = True
        e11.Checked = False
        e22.Checked = True
        e33.Checked = True
        e44.Checked = True
        e55.Checked = False

        letsgoprice = "PRICE: " + dprice.Text
        KryptonNumericUpDown1.Text = dwinner.Text
        Label2.Text = letsgoprice
        labeltext.Text = "D"
    End Sub

    Private Sub IToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IToolStripMenuItem.Click
        a1.Checked = False
        a2.Checked = False
        a3.Checked = False
        a4.Checked = False
        a5.Checked = False
        b1.Checked = True
        b2.Checked = False
        b3.Checked = False
        b4.Checked = False
        b5.Checked = True
        c1.Checked = True
        c2.Checked = True

        c4.Checked = True
        c5.Checked = True
        d1.Checked = True
        d2.Checked = False
        d3.Checked = False
        d4.Checked = False
        d5.Checked = True
        e1.Checked = False
        e2.Checked = False
        e3.Checked = False
        e4.Checked = False
        e5.Checked = False

        a11.Checked = False
        a22.Checked = False
        a33.Checked = False
        a44.Checked = False
        a55.Checked = False
        b11.Checked = True
        b22.Checked = False
        b33.Checked = False
        b44.Checked = False
        b55.Checked = True
        c11.Checked = True
        c22.Checked = True

        c44.Checked = True
        c55.Checked = True
        d11.Checked = True
        d22.Checked = False
        d33.Checked = False
        d44.Checked = False
        d55.Checked = True
        e11.Checked = False
        e22.Checked = False
        e33.Checked = False
        e44.Checked = False
        e55.Checked = False

        letsgoprice = "PRICE: " + iprice.Text
        KryptonNumericUpDown1.Text = iwinner.Text
        Label2.Text = letsgoprice
        labeltext.Text = "I"
    End Sub


    Public Sub called()


        If ComboBox4.Items.Count >= 1 Then
            a101.Text = ComboBox4.Items(0)
            a101.Checked = True
        Else
            a101.Text = ""
            a101.Checked = False
        End If
        If ComboBox4.Items.Count >= 2 Then
            a102.Text = ComboBox4.Items(1)
            a102.Checked = True
        Else
            a102.Text = ""
            a102.Checked = False
        End If
        If ComboBox4.Items.Count >= 3 Then
            a103.Text = ComboBox4.Items(2)
            a103.Checked = True
        Else
            a103.Text = ""
            a103.Checked = False
        End If
        If ComboBox4.Items.Count >= 4 Then
            a104.Text = ComboBox4.Items(3)
            a104.Checked = True
        Else
            a104.Text = ""
            a104.Checked = False
        End If
        If ComboBox4.Items.Count >= 5 Then
            a105.Text = ComboBox4.Items(4)
            a105.Checked = True
        Else
            a105.Text = ""
            a105.Checked = False
        End If
        If ComboBox4.Items.Count >= 6 Then
            a106.Text = ComboBox4.Items(5)
            a106.Checked = True
        Else
            a106.Text = ""
            a106.Checked = False
        End If
        If ComboBox4.Items.Count >= 7 Then
            a107.Text = ComboBox4.Items(6)
            a107.Checked = True
        Else
            a107.Text = ""
            a107.Checked = False
        End If
        If ComboBox4.Items.Count >= 8 Then
            a108.Text = ComboBox4.Items(7)
            a108.Checked = True
        Else
            a108.Text = ""
            a108.Checked = False
        End If
        If ComboBox4.Items.Count >= 9 Then
            a109.Text = ComboBox4.Items(8)
            a109.Checked = True
        Else
            a109.Text = ""
            a109.Checked = False
        End If
        If ComboBox4.Items.Count >= 10 Then
            a110.Text = ComboBox4.Items(9)
            a110.Checked = True
        Else
            a110.Text = ""
            a110.Checked = False
        End If
        If ComboBox4.Items.Count >= 11 Then
            a111.Text = ComboBox4.Items(10)
            a111.Checked = True
        Else
            a111.Text = ""
            a111.Checked = False
        End If
        If ComboBox4.Items.Count >= 12 Then
            a112.Text = ComboBox4.Items(11)
            a112.Checked = True
        Else
            a112.Text = ""
            a112.Checked = False
        End If
        If ComboBox4.Items.Count >= 13 Then
            a113.Text = ComboBox4.Items(12)
            a113.Checked = True
        Else
            a113.Text = ""
            a113.Checked = False
        End If
        If ComboBox4.Items.Count >= 14 Then
            a114.Text = ComboBox4.Items(13)
            a114.Checked = True
        Else
            a114.Text = ""
            a114.Checked = False
        End If
        If ComboBox4.Items.Count >= 15 Then
            a115.Text = ComboBox4.Items(14)
            a115.Checked = True
        Else
            a115.Text = ""
            a115.Checked = False
        End If


        If ComboBox4.Items.Count >= 16 Then
            a116.Text = ComboBox4.Items(15)
            a116.Checked = True
        Else
            a116.Text = ""
            a116.Checked = False
        End If
        If ComboBox4.Items.Count >= 17 Then
            a117.Text = ComboBox4.Items(16)
            a117.Checked = True
        Else
            a117.Text = ""
            a117.Checked = False
        End If
        If ComboBox4.Items.Count >= 18 Then
            a118.Text = ComboBox4.Items(17)
            a118.Checked = True
        Else
            a118.Text = ""
            a118.Checked = False
        End If
        If ComboBox4.Items.Count >= 19 Then
            a119.Text = ComboBox4.Items(18)
            a119.Checked = True
        Else
            a119.Text = ""
            a119.Checked = False
        End If
        If ComboBox4.Items.Count >= 20 Then
            a120.Text = ComboBox4.Items(19)
            a120.Checked = True
        Else
            a120.Text = ""
            a120.Checked = False
        End If
        If ComboBox4.Items.Count >= 21 Then
            a121.Text = ComboBox4.Items(20)
            a121.Checked = True
        Else
            a121.Text = ""
            a121.Checked = False
        End If
        If ComboBox4.Items.Count >= 22 Then
            a122.Text = ComboBox4.Items(21)
            a122.Checked = True
        Else
            a122.Text = ""
            a122.Checked = False
        End If
        If ComboBox4.Items.Count >= 23 Then
            a123.Text = ComboBox4.Items(22)
            a123.Checked = True
        Else
            a123.Text = ""
            a123.Checked = False
        End If
        If ComboBox4.Items.Count >= 24 Then
            a124.Text = ComboBox4.Items(23)
            a124.Checked = True
        Else
            a124.Text = ""
            a124.Checked = False
        End If
        If ComboBox4.Items.Count >= 25 Then
            a125.Text = ComboBox4.Items(24)
            a125.Checked = True
        Else
            a125.Text = ""
            a125.Checked = False
        End If
        If ComboBox4.Items.Count >= 26 Then
            a126.Text = ComboBox4.Items(25)
            a126.Checked = True
        Else
            a126.Text = ""
            a126.Checked = False
        End If
        If ComboBox4.Items.Count >= 27 Then
            a127.Text = ComboBox4.Items(26)
            a127.Checked = True
        Else
            a127.Text = ""
            a127.Checked = False
        End If
        If ComboBox4.Items.Count >= 28 Then
            a128.Text = ComboBox4.Items(27)
            a128.Checked = True
        Else
            a128.Text = ""
            a128.Checked = False
        End If
        If ComboBox4.Items.Count >= 29 Then
            a129.Text = ComboBox4.Items(28)
            a129.Checked = True
        Else
            a129.Text = ""
            a129.Checked = False
        End If
        If ComboBox4.Items.Count >= 30 Then
            a130.Text = ComboBox4.Items(29)
            a130.Checked = True
        Else
            a130.Text = ""
            a130.Checked = False
        End If


        If ComboBox4.Items.Count >= 31 Then
            a131.Text = ComboBox4.Items(30)
            a131.Checked = True
        Else
            a131.Text = ""
            a131.Checked = False
        End If
        If ComboBox4.Items.Count >= 32 Then
            a132.Text = ComboBox4.Items(31)
            a132.Checked = True
        Else
            a132.Text = ""
            a132.Checked = False
        End If
        If ComboBox4.Items.Count >= 33 Then
            a133.Text = ComboBox4.Items(32)
            a133.Checked = True
        Else
            a133.Text = ""
            a133.Checked = False
        End If
        If ComboBox4.Items.Count >= 34 Then
            a134.Text = ComboBox4.Items(33)
            a134.Checked = True
        Else
            a134.Text = ""
            a134.Checked = False
        End If
        If ComboBox4.Items.Count >= 35 Then
            a135.Text = ComboBox4.Items(34)
            a135.Checked = True
        Else
            a135.Text = ""
            a135.Checked = False
        End If
        If ComboBox4.Items.Count >= 36 Then
            a136.Text = ComboBox4.Items(35)
            a136.Checked = True
        Else
            a136.Text = ""
            a136.Checked = False
        End If
        If ComboBox4.Items.Count >= 37 Then
            a137.Text = ComboBox4.Items(36)
            a137.Checked = True
        Else
            a137.Text = ""
            a137.Checked = False
        End If
        If ComboBox4.Items.Count >= 38 Then
            a138.Text = ComboBox4.Items(37)
            a138.Checked = True
        Else
            a138.Text = ""
            a138.Checked = False
        End If
        If ComboBox4.Items.Count >= 39 Then
            a139.Text = ComboBox4.Items(38)
            a139.Checked = True
        Else
            a139.Text = ""
            a139.Checked = False
        End If
        If ComboBox4.Items.Count >= 40 Then
            a140.Text = ComboBox4.Items(39)
            a140.Checked = True
        Else
            a140.Text = ""
            a140.Checked = False
        End If
        If ComboBox4.Items.Count >= 41 Then
            a141.Text = ComboBox4.Items(40)
            a141.Checked = True
        Else
            a141.Text = ""
            a141.Checked = False
        End If
        If ComboBox4.Items.Count >= 42 Then
            a142.Text = ComboBox4.Items(41)
            a142.Checked = True
        Else
            a142.Text = ""
            a142.Checked = False
        End If
        If ComboBox4.Items.Count >= 43 Then
            a143.Text = ComboBox4.Items(42)
            a143.Checked = True
        Else
            a143.Text = ""
            a143.Checked = False
        End If
        If ComboBox4.Items.Count >= 44 Then
            a144.Text = ComboBox4.Items(43)
            a144.Checked = True
        Else
            a144.Text = ""
            a144.Checked = False
        End If
        If ComboBox4.Items.Count >= 45 Then
            a145.Text = ComboBox4.Items(44)
            a145.Checked = True
        Else
            a145.Text = ""
            a145.Checked = False
        End If





        If ComboBox4.Items.Count >= 46 Then
            a146.Text = ComboBox4.Items(45)
            a146.Checked = True
        Else
            a146.Text = ""
            a146.Checked = False
        End If
        If ComboBox4.Items.Count >= 47 Then
            a147.Text = ComboBox4.Items(46)
            a147.Checked = True
        Else
            a147.Text = ""
            a147.Checked = False
        End If
        If ComboBox4.Items.Count >= 48 Then
            a148.Text = ComboBox4.Items(47)
            a148.Checked = True
        Else
            a148.Text = ""
            a148.Checked = False
        End If
        If ComboBox4.Items.Count >= 49 Then
            a149.Text = ComboBox4.Items(48)
            a149.Checked = True
        Else
            a149.Text = ""
            a149.Checked = False
        End If
        If ComboBox4.Items.Count >= 50 Then
            a150.Text = ComboBox4.Items(49)
            a150.Checked = True
        Else
            a150.Text = ""
            a150.Checked = False
        End If
        If ComboBox4.Items.Count >= 51 Then
            a151.Text = ComboBox4.Items(50)
            a151.Checked = True
        Else
            a151.Text = ""
            a151.Checked = False
        End If
        If ComboBox4.Items.Count >= 52 Then
            a152.Text = ComboBox4.Items(51)
            a152.Checked = True
        Else
            a152.Text = ""
            a152.Checked = False
        End If
        If ComboBox4.Items.Count >= 53 Then
            a153.Text = ComboBox4.Items(52)
            a153.Checked = True
        Else
            a153.Text = ""
            a153.Checked = False
        End If
        If ComboBox4.Items.Count >= 54 Then
            a154.Text = ComboBox4.Items(53)
            a154.Checked = True
        Else
            a154.Text = ""
            a154.Checked = False
        End If
        If ComboBox4.Items.Count >= 55 Then
            a155.Text = ComboBox4.Items(54)
            a155.Checked = True
        Else
            a155.Text = ""
            a155.Checked = False
        End If
        If ComboBox4.Items.Count >= 56 Then
            a156.Text = ComboBox4.Items(55)
            a156.Checked = True
        Else
            a156.Text = ""
            a156.Checked = False
        End If
        If ComboBox4.Items.Count >= 57 Then
            a157.Text = ComboBox4.Items(56)
            a157.Checked = True
        Else
            a157.Text = ""
            a157.Checked = False
        End If
        If ComboBox4.Items.Count >= 58 Then
            a158.Text = ComboBox4.Items(57)
            a158.Checked = True
        Else
            a158.Text = ""
            a158.Checked = False
        End If
        If ComboBox4.Items.Count >= 59 Then
            a159.Text = ComboBox4.Items(58)
            a159.Checked = True
        Else
            a159.Text = ""
            a159.Checked = False
        End If
        If ComboBox4.Items.Count >= 60 Then
            a160.Text = ComboBox4.Items(59)
            a160.Checked = True
        Else
            a160.Text = ""
            a160.Checked = False
        End If


        If ComboBox4.Items.Count >= 61 Then
            a161.Text = ComboBox4.Items(60)
            a161.Checked = True
        Else
            a161.Text = ""
            a161.Checked = False
        End If
        If ComboBox4.Items.Count >= 62 Then
            a162.Text = ComboBox4.Items(61)
            a162.Checked = True
        Else
            a162.Text = ""
            a162.Checked = False
        End If
        If ComboBox4.Items.Count >= 63 Then
            a163.Text = ComboBox4.Items(62)
            a163.Checked = True
        Else
            a163.Text = ""
            a163.Checked = False
        End If
        If ComboBox4.Items.Count >= 64 Then
            a164.Text = ComboBox4.Items(63)
            a164.Checked = True
        Else
            a164.Text = ""
            a164.Checked = False
        End If
        If ComboBox4.Items.Count >= 65 Then
            a165.Text = ComboBox4.Items(64)
            a165.Checked = True
        Else
            a165.Text = ""
            a165.Checked = False
        End If
        If ComboBox4.Items.Count >= 66 Then
            a166.Text = ComboBox4.Items(65)
            a166.Checked = True
        Else
            a166.Text = ""
            a166.Checked = False
        End If
        If ComboBox4.Items.Count >= 67 Then
            a167.Text = ComboBox4.Items(66)
            a167.Checked = True
        Else
            a167.Text = ""
            a167.Checked = False
        End If
        If ComboBox4.Items.Count >= 68 Then
            a168.Text = ComboBox4.Items(67)
            a168.Checked = True
        Else
            a168.Text = ""
            a168.Checked = False
        End If
        If ComboBox4.Items.Count >= 69 Then
            a169.Text = ComboBox4.Items(68)
            a169.Checked = True
        Else
            a169.Text = ""
            a169.Checked = False
        End If
        If ComboBox4.Items.Count >= 70 Then
            a170.Text = ComboBox4.Items(69)
            a170.Checked = True
        Else
            a170.Text = ""
            a170.Checked = False
        End If
        If ComboBox4.Items.Count >= 71 Then
            a171.Text = ComboBox4.Items(70)
            a171.Checked = True
        Else
            a171.Text = ""
            a171.Checked = False
        End If
        If ComboBox4.Items.Count >= 72 Then
            a172.Text = ComboBox4.Items(71)
            a172.Checked = True
        Else
            a172.Text = ""
            a172.Checked = False
        End If
        If ComboBox4.Items.Count >= 73 Then
            a173.Text = ComboBox4.Items(72)
            a173.Checked = True
        Else
            a173.Text = ""
            a173.Checked = False
        End If
        If ComboBox4.Items.Count >= 74 Then
            a174.Text = ComboBox4.Items(73)
            a174.Checked = True
        Else
            a174.Text = ""
            a174.Checked = False
        End If
        If ComboBox4.Items.Count >= 75 Then
            a175.Text = ComboBox4.Items(74)
            a175.Checked = True
        Else
            a175.Text = ""
            a175.Checked = False
        End If

    End Sub

    Private Sub SwitchViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SwitchViewToolStripMenuItem.Click
        If KryptonHeaderGroup4.Visible = True Then
            KryptonHeaderGroup4.Visible = False
            KryptonHeaderGroup7.Visible = True
        ElseIf KryptonHeaderGroup7.Visible = True Then
            KryptonHeaderGroup4.Visible = True
            KryptonHeaderGroup7.Visible = False
        End If
    End Sub

    Private Sub a1_Click(sender As Object, e As EventArgs) Handles a1.Click
        If a1.Checked = True Then
            a11.Checked = True
        ElseIf a1.Checked = False Then
            a11.Checked = False
        End If
    End Sub

    Private Sub a2_Click(sender As Object, e As EventArgs) Handles a2.Click
        If a2.Checked = True Then
            a22.Checked = True
        ElseIf a2.Checked = False Then
            a22.Checked = False
        End If
    End Sub

    Private Sub a3_Click(sender As Object, e As EventArgs) Handles a3.Click
        If a3.Checked = True Then
            a33.Checked = True
        ElseIf a3.Checked = False Then
            a33.Checked = False
        End If
    End Sub

    Private Sub a4_Click(sender As Object, e As EventArgs) Handles a4.Click
        If a4.Checked = True Then
            a44.Checked = True
        ElseIf a4.Checked = False Then
            a44.Checked = False
        End If
    End Sub

    Private Sub a5_Click(sender As Object, e As EventArgs) Handles a5.Click
        If a5.Checked = True Then
            a55.Checked = True
        ElseIf a5.Checked = False Then
            a55.Checked = False
        End If
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        If b1.Checked = True Then
            b11.Checked = True
        ElseIf b1.Checked = False Then
            b11.Checked = False
        End If
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        If b2.Checked = True Then
            b22.Checked = True
        ElseIf b2.Checked = False Then
            b22.Checked = False
        End If
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        If b3.Checked = True Then
            b33.Checked = True
        ElseIf b3.Checked = False Then
            b33.Checked = False
        End If
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        If b4.Checked = True Then
            b44.Checked = True
        ElseIf b4.Checked = False Then
            b44.Checked = False
        End If
    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        If b5.Checked = True Then
            b55.Checked = True
        ElseIf b5.Checked = False Then
            b55.Checked = False
        End If
    End Sub

    Private Sub c1_Click(sender As Object, e As EventArgs) Handles c1.Click
        If c1.Checked = True Then
            c11.Checked = True
        ElseIf c1.Checked = False Then
            c11.Checked = False
        End If
    End Sub

    Private Sub c2_Click(sender As Object, e As EventArgs) Handles c2.Click
        If c2.Checked = True Then
            c22.Checked = True
        ElseIf c2.Checked = False Then
            c22.Checked = False
        End If
    End Sub

    Private Sub c4_Click(sender As Object, e As EventArgs) Handles c4.Click
        If c4.Checked = True Then
            c44.Checked = True
        ElseIf c4.Checked = False Then
            c44.Checked = False
        End If
    End Sub

    Private Sub c5_Click(sender As Object, e As EventArgs) Handles c5.Click
        If c5.Checked = True Then
            c55.Checked = True
        ElseIf c5.Checked = False Then
            c55.Checked = False
        End If
    End Sub

    Private Sub d1_Click(sender As Object, e As EventArgs) Handles d1.Click
        If d1.Checked = True Then
            d11.Checked = True
        ElseIf d1.Checked = False Then
            d11.Checked = False
        End If
    End Sub

    Private Sub d2_Click(sender As Object, e As EventArgs) Handles d2.Click
        If d2.Checked = True Then
            d22.Checked = True
        ElseIf d2.Checked = False Then
            d22.Checked = False
        End If
    End Sub

    Private Sub d3_Click(sender As Object, e As EventArgs) Handles d3.Click
        If d3.Checked = True Then
            d33.Checked = True
        ElseIf d3.Checked = False Then
            d33.Checked = False
        End If
    End Sub

    Private Sub d4_Click(sender As Object, e As EventArgs) Handles d4.Click
        If d4.Checked = True Then
            d44.Checked = True
        ElseIf d4.Checked = False Then
            d44.Checked = False
        End If
    End Sub

    Private Sub d5_Click(sender As Object, e As EventArgs) Handles d5.Click
        If d5.Checked = True Then
            d55.Checked = True
        ElseIf d5.Checked = False Then
            d55.Checked = False
        End If
    End Sub

    Private Sub e1_Click(sender As Object, e As EventArgs) Handles e1.Click
        If e1.Checked = True Then
            e11.Checked = True
        ElseIf e1.Checked = False Then
            e11.Checked = False
        End If
    End Sub

    Private Sub e2_Click(sender As Object, e As EventArgs) Handles e2.Click
        If e2.Checked = True Then
            e22.Checked = True
        ElseIf e2.Checked = False Then
            e22.Checked = False
        End If
    End Sub

    Private Sub e3_Click(sender As Object, e As EventArgs) Handles e3.Click
        If e3.Checked = True Then
            e33.Checked = True
        ElseIf e3.Checked = False Then
            e33.Checked = False
        End If
    End Sub

    Private Sub e4_Click(sender As Object, e As EventArgs) Handles e4.Click
        If e4.Checked = True Then
            e44.Checked = True
        ElseIf e4.Checked = False Then
            e44.Checked = False
        End If
    End Sub

    Private Sub e5_Click(sender As Object, e As EventArgs) Handles e5.Click
        If e5.Checked = True Then
            e55.Checked = True
        ElseIf e5.Checked = False Then
            e55.Checked = False
        End If
    End Sub

    Private Sub a11_Click(sender As Object, e As EventArgs) Handles a11.Click
        If a11.Checked = True Then
            a1.Checked = True
        ElseIf a11.Checked = False Then
            a1.Checked = False
        End If
    End Sub

    Private Sub a22_Click(sender As Object, e As EventArgs) Handles a22.Click
        If a22.Checked = True Then
            a2.Checked = True
        ElseIf a22.Checked = False Then
            a2.Checked = False
        End If
    End Sub

    Private Sub a33_Click(sender As Object, e As EventArgs) Handles a33.Click
        If a33.Checked = True Then
            a3.Checked = True
        ElseIf a33.Checked = False Then
            a3.Checked = False
        End If
    End Sub

    Private Sub a44_Click(sender As Object, e As EventArgs) Handles a44.Click
        If a44.Checked = True Then
            a4.Checked = True
        ElseIf a44.Checked = False Then
            a4.Checked = False
        End If
    End Sub

    Private Sub a55_Click(sender As Object, e As EventArgs) Handles a55.Click
        If a55.Checked = True Then
            a5.Checked = True
        ElseIf a55.Checked = False Then
            a5.Checked = False
        End If
    End Sub

    Private Sub b11_Click(sender As Object, e As EventArgs) Handles b11.Click
        If b11.Checked = True Then
            b1.Checked = True
        ElseIf b11.Checked = False Then
            b1.Checked = False
        End If
    End Sub

    Private Sub b22_Click(sender As Object, e As EventArgs) Handles b22.Click
        If b22.Checked = True Then
            b2.Checked = True
        ElseIf b22.Checked = False Then
            b2.Checked = False
        End If
    End Sub

    Private Sub b33_Click(sender As Object, e As EventArgs) Handles b33.Click
        If b33.Checked = True Then
            b3.Checked = True
        ElseIf b33.Checked = False Then
            b3.Checked = False
        End If
    End Sub

    Private Sub b44_Click(sender As Object, e As EventArgs) Handles b44.Click
        If b44.Checked = True Then
            b4.Checked = True
        ElseIf b44.Checked = False Then
            b4.Checked = False
        End If
    End Sub

    Private Sub b55_Click(sender As Object, e As EventArgs) Handles b55.Click
        If b55.Checked = True Then
            b5.Checked = True
        ElseIf b55.Checked = False Then
            b5.Checked = False
        End If
    End Sub

    Private Sub c11_Click(sender As Object, e As EventArgs) Handles c11.Click
        If c11.Checked = True Then
            c1.Checked = True
        ElseIf c11.Checked = False Then
            c1.Checked = False
        End If
    End Sub

    Private Sub c22_Click(sender As Object, e As EventArgs) Handles c22.Click
        If c22.Checked = True Then
            c2.Checked = True
        ElseIf c22.Checked = False Then
            c2.Checked = False
        End If
    End Sub

    Private Sub c44_Click(sender As Object, e As EventArgs) Handles c44.Click
        If c44.Checked = True Then
            c4.Checked = True
        ElseIf c44.Checked = False Then
            c4.Checked = False
        End If
    End Sub

    Private Sub c55_Click(sender As Object, e As EventArgs) Handles c55.Click
        If c55.Checked = True Then
            c5.Checked = True
        ElseIf c55.Checked = False Then
            c5.Checked = False
        End If
    End Sub

    Private Sub d11_Click(sender As Object, e As EventArgs) Handles d11.Click
        If d11.Checked = True Then
            d1.Checked = True
        ElseIf d11.Checked = False Then
            d1.Checked = False
        End If
    End Sub

    Private Sub d22_Click(sender As Object, e As EventArgs) Handles d22.Click
        If d22.Checked = True Then
            d2.Checked = True
        ElseIf d22.Checked = False Then
            d2.Checked = False
        End If
    End Sub

    Private Sub d33_Click(sender As Object, e As EventArgs) Handles d33.Click
        If d33.Checked = True Then
            d3.Checked = True
        ElseIf d33.Checked = False Then
            d3.Checked = False
        End If
    End Sub

    Private Sub d44_Click(sender As Object, e As EventArgs) Handles d44.Click
        If d44.Checked = True Then
            d4.Checked = True
        ElseIf d44.Checked = False Then
            d4.Checked = False
        End If
    End Sub

    Private Sub d55_Click(sender As Object, e As EventArgs) Handles d55.Click
        If d55.Checked = True Then
            d5.Checked = True
        ElseIf d55.Checked = False Then
            d5.Checked = False
        End If
    End Sub

    Private Sub e11_Click(sender As Object, e As EventArgs) Handles e11.Click
        If e11.Checked = True Then
            e1.Checked = True
        ElseIf e11.Checked = False Then
            e1.Checked = False
        End If
    End Sub

    Private Sub e22_Click(sender As Object, e As EventArgs) Handles e22.Click
        If e22.Checked = True Then
            e2.Checked = True
        ElseIf e22.Checked = False Then
            e2.Checked = False
        End If
    End Sub

    Private Sub e33_Click(sender As Object, e As EventArgs) Handles e33.Click
        If e33.Checked = True Then
            e3.Checked = True
        ElseIf e33.Checked = False Then
            e3.Checked = False
        End If
    End Sub

    Private Sub e44_Click(sender As Object, e As EventArgs) Handles e44.Click
        If e44.Checked = True Then
            e4.Checked = True
        ElseIf e44.Checked = False Then
            e4.Checked = False
        End If
    End Sub

    Private Sub e55_Click(sender As Object, e As EventArgs) Handles e55.Click
        If e55.Checked = True Then
            e5.Checked = True
        ElseIf e55.Checked = False Then
            e5.Checked = False
        End If
    End Sub

    Private Sub CustomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomToolStripMenuItem.Click
        'a1.Checked = False
        'a2.Checked = False
        'a3.Checked = False
        'a4.Checked = False
        'a5.Checked = False
        'b1.Checked = False
        'b2.Checked = False
        'b3.Checked = False
        'b4.Checked = False
        'b5.Checked = False
        'c1.Checked = False
        'c2.Checked = False

        'c4.Checked = False
        'c5.Checked = False
        'd1.Checked = False
        'd2.Checked = False
        'd3.Checked = False
        'd4.Checked = False
        'd5.Checked = False
        'e1.Checked = False
        'e2.Checked = False
        'e3.Checked = False
        'e4.Checked = False
        'e5.Checked = False

        'a11.Checked = False
        'a22.Checked = False
        'a33.Checked = False
        'a44.Checked = False
        'a55.Checked = False
        'b11.Checked = False
        'b22.Checked = False
        'b33.Checked = False
        'b44.Checked = False
        'b55.Checked = False
        'c11.Checked = False
        'c22.Checked = False

        'c44.Checked = False
        'c55.Checked = False
        'd11.Checked = False
        'd22.Checked = False
        'd33.Checked = False
        'd44.Checked = False
        'd55.Checked = False
        'e11.Checked = False
        'e22.Checked = False
        'e33.Checked = False
        'e44.Checked = False
        'e55.Checked = False



        letsgoprice = "PRICE: " + customprice.Text
        KryptonNumericUpDown1.Text = customwinner.Text
        Label2.Text = letsgoprice
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If labelshow.Text = "Show" Then
            KryptonPanel1.Visible = True
        ElseIf labelshow.text = "Hide" Then
            KryptonPanel1.Visible = False
        End If
        If labelbackcolor.SelectedIndex = 0 Then
            KryptonPanel1.StateCommon.Color1 = Color.Yellow
            KryptonPanel1.StateCommon.Color2 = Color.Yellow
            KryptonLabel4.BackColor = Color.Yellow
        ElseIf labelbackcolor.SelectedIndex = 1 Then
            KryptonPanel1.StateCommon.Color1 = Color.White
            KryptonPanel1.StateCommon.Color2 = Color.White
            KryptonLabel4.BackColor = Color.White
        End If

        Dim x = KryptonPanel1.Size.Width - KryptonLabel4.Size.Width

        KryptonLabel4.Text = labeltext.Text
        Timer3.Interval = labelspeed.Text
        KryptonLabel4.Location = New Point(KryptonLabel4.Location.X + 4, KryptonLabel4.Location.Y)
        If KryptonLabel4.Location.X > x Then
            Timer3.Stop()
            Timer4.Start()
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If labelshow.Text = "Show" Then
            KryptonPanel1.Visible = True
        ElseIf labelshow.Text = "Hide" Then
            KryptonPanel1.Visible = False
        End If
        'LightGoldenrodYellow
        If labelbackcolor.SelectedIndex = 0 Then
            KryptonPanel1.StateCommon.Color1 = Color.Yellow
            KryptonPanel1.StateCommon.Color2 = Color.Yellow
            KryptonLabel4.BackColor = Color.Yellow
        ElseIf labelbackcolor.SelectedIndex = 1 Then
            KryptonPanel1.StateCommon.Color1 = Color.White
            KryptonPanel1.StateCommon.Color2 = Color.White
            KryptonLabel4.BackColor = Color.White
        End If
        KryptonLabel4.Text = labeltext.Text
        Timer4.Interval = labelspeed.Text
        KryptonLabel4.Location = New Point(KryptonLabel4.Location.X - 4, KryptonLabel4.Location.Y)
        If KryptonLabel4.Location.X < 10 Then
            Timer4.Stop()
            Timer3.Start()

        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Sure you wanna exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub lettertimer_Tick(sender As Object, e As EventArgs) Handles lettertimer.Tick
        lettertimer.Interval = 50
        PictureBox3.Location = New Point(PictureBox3.Location.X, PictureBox3.Location.Y - 10)
        If PictureBox3.Location.Y = -230 Or PictureBox3.Location.Y < -230 Then
            lettertimer.Stop()
            Dim loc3 = (PictureBox3.Location.Y)
            PictureBox3.Location = New Point(PictureBox3.Location.X, PictureBox3.Location.Y - loc3)
            PictureBox3.SendToBack()
            If yesnospeak.Text = "Yes" Then
                Dim v As Integer = myvoice.SelectedIndex
                Dim r As Integer = repeatmyvoice.SelectedIndex
                speech.Voice = speech.getvoices.item(v)
                speech.rate = vrate.Text
                speech.speak("Sah Let Rung!" + "" & KryptonLabel1.Text & "")
            End If

            myanimation.Start()
            myanimation.Interval = ToolStripTextBox2.Text

        End If
    End Sub

    Private Sub letterstart_Click(sender As Object, e As EventArgs) Handles letterstart.Click
        lettertimer.Start()
        KryptonButton157.Visible = False
        PAUSE.Visible = True
        animestarter.Visible = False
        letterstart.Visible = False
    End Sub

    Private Sub CheckerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckerToolStripMenuItem.Click
        Form4.ShowDialog()
    End Sub

    Private Sub BlackoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackoutToolStripMenuItem.Click
        a1.Checked = True
        a2.Checked = True
        a3.Checked = True
        a4.Checked = True
        a5.Checked = True
        b1.Checked = True
        b2.Checked = True
        b3.Checked = True
        b4.Checked = True
        b5.Checked = True
        c1.Checked = True
        c2.Checked = True

        c4.Checked = True
        c5.Checked = True
        d1.Checked = True
        d2.Checked = True
        d3.Checked = True
        d4.Checked = True
        d5.Checked = True
        e1.Checked = True
        e2.Checked = True
        e3.Checked = True
        e4.Checked = True
        e5.Checked = True

        a11.Checked = True
        a22.Checked = True
        a33.Checked = True
        a44.Checked = True
        a55.Checked = True
        b11.Checked = True
        b22.Checked = True
        b33.Checked = True
        b44.Checked = True
        b55.Checked = True
        c11.Checked = True
        c22.Checked = True

        c44.Checked = True
        c55.Checked = True
        d11.Checked = True
        d22.Checked = True
        d33.Checked = True
        d44.Checked = True
        d55.Checked = True
        e11.Checked = True
        e22.Checked = True
        e33.Checked = True
        e44.Checked = True
        e55.Checked = True

        letsgoprice = "PRICE: " + blackprice.Text
        KryptonNumericUpDown1.Text = blackwinner.Text
        Label2.Text = letsgoprice
        labeltext.Text = "Blackout"
    End Sub

    Private Sub SemiBlackoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SemiBlackoutToolStripMenuItem.Click
        a1.Checked = True
        a2.Checked = True
        a3.Checked = True
        a4.Checked = True
        a5.Checked = True
        b1.Checked = True
        b2.Checked = True
        b3.Checked = True
        b4.Checked = True
        b5.Checked = True
        c1.Checked = True
        c2.Checked = True

        c4.Checked = False
        c5.Checked = True
        d1.Checked = True
        d2.Checked = True
        d3.Checked = True
        d4.Checked = True
        d5.Checked = True
        e1.Checked = True
        e2.Checked = True
        e3.Checked = True
        e4.Checked = True
        e5.Checked = True

        a11.Checked = True
        a22.Checked = True
        a33.Checked = True
        a44.Checked = True
        a55.Checked = True
        b11.Checked = True
        b22.Checked = True
        b33.Checked = True
        b44.Checked = True
        b55.Checked = True
        c11.Checked = True
        c22.Checked = True

        c44.Checked = False
        c55.Checked = True
        d11.Checked = True
        d22.Checked = True
        d33.Checked = True
        d44.Checked = True
        d55.Checked = True
        e11.Checked = True
        e22.Checked = True
        e33.Checked = True
        e44.Checked = True
        e55.Checked = True

        letsgoprice = "PRICE: " + semiprice.Text
        KryptonNumericUpDown1.Text = semiwinner.Text
        Label2.Text = letsgoprice
        labeltext.Text = "Semi-Blackout"
    End Sub

    Private Sub DoubleVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoubleVerticalToolStripMenuItem.Click
        a1.Checked = False
        a2.Checked = False
        a3.Checked = False
        a4.Checked = False
        a5.Checked = False
        b1.Checked = False
        b2.Checked = False
        b3.Checked = False
        b4.Checked = False
        b5.Checked = False
        c1.Checked = True
        c2.Checked = True

        c4.Checked = True
        c5.Checked = True
        d1.Checked = True
        d2.Checked = True
        d3.Checked = True
        d4.Checked = True
        d5.Checked = True
        e1.Checked = False
        e2.Checked = False
        e3.Checked = False
        e4.Checked = False
        e5.Checked = False

        a11.Checked = False
        a22.Checked = False
        a33.Checked = False
        a44.Checked = False
        a55.Checked = False
        b11.Checked = False
        b22.Checked = False
        b33.Checked = False
        b44.Checked = False
        b55.Checked = False
        c11.Checked = True
        c22.Checked = True

        c44.Checked = True
        c55.Checked = True
        d11.Checked = True
        d22.Checked = True
        d33.Checked = True
        d44.Checked = True
        d55.Checked = True
        e11.Checked = False
        e22.Checked = False
        e33.Checked = False
        e44.Checked = False
        e55.Checked = False

        letsgoprice = "PRICE: " + doublevprice.Text
        KryptonNumericUpDown1.Text = doublevwin.Text
        Label2.Text = letsgoprice
        labeltext.Text = "Any Double Vertical Line"
    End Sub

    Private Sub DoubleHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoubleHorizontalToolStripMenuItem.Click
        a1.Checked = False
        a2.Checked = True
        a3.Checked = True
        a4.Checked = False
        a5.Checked = False
        b1.Checked = False
        b2.Checked = True
        b3.Checked = True
        b4.Checked = False
        b5.Checked = False
        c1.Checked = False
        c2.Checked = True

        c4.Checked = False
        c5.Checked = False
        d1.Checked = False
        d2.Checked = True
        d3.Checked = True
        d4.Checked = False
        d5.Checked = False
        e1.Checked = False
        e2.Checked = True
        e3.Checked = True
        e4.Checked = False
        e5.Checked = False

        a11.Checked = False
        a22.Checked = True
        a33.Checked = True
        a44.Checked = False
        a55.Checked = False
        b11.Checked = False
        b22.Checked = True
        b33.Checked = True
        b44.Checked = False
        b55.Checked = False
        c11.Checked = False
        c22.Checked = True

        c44.Checked = False
        c55.Checked = False
        d11.Checked = False
        d22.Checked = True
        d33.Checked = True
        d44.Checked = False
        d55.Checked = False
        e11.Checked = False
        e22.Checked = True
        e33.Checked = True
        e44.Checked = False
        e55.Checked = False

        letsgoprice = "PRICE: " + doublehprice.Text
        KryptonNumericUpDown1.Text = doublehwin.Text
        Label2.Text = letsgoprice
        labeltext.Text = "Any Double Horizontal Line"
    End Sub

    Private Sub IntersectingHVLinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntersectingHVLinesToolStripMenuItem.Click
        a1.Checked = False
        a2.Checked = False
        a3.Checked = True
        a4.Checked = False
        a5.Checked = False
        b1.Checked = False
        b2.Checked = False
        b3.Checked = True
        b4.Checked = False
        b5.Checked = False
        c1.Checked = True
        c2.Checked = True

        c4.Checked = True
        c5.Checked = True
        d1.Checked = False
        d2.Checked = False
        d3.Checked = True
        d4.Checked = False
        d5.Checked = False
        e1.Checked = False
        e2.Checked = False
        e3.Checked = True
        e4.Checked = False
        e5.Checked = False

        a11.Checked = False
        a22.Checked = False
        a33.Checked = True
        a44.Checked = False
        a55.Checked = False
        b11.Checked = False
        b22.Checked = False
        b33.Checked = True
        b44.Checked = False
        b55.Checked = False
        c11.Checked = True
        c22.Checked = True

        c44.Checked = True
        c55.Checked = True
        d11.Checked = False
        d22.Checked = False
        d33.Checked = True
        d44.Checked = False
        d55.Checked = False
        e11.Checked = False
        e22.Checked = False
        e33.Checked = True
        e44.Checked = False
        e55.Checked = False

        letsgoprice = "PRICE: " + interprice.Text
        KryptonNumericUpDown1.Text = interwin.Text
        Label2.Text = letsgoprice
        labeltext.Text = "Any Intersecting Vertical And Horizontal Line"
    End Sub

    Private Sub LastManStandingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LastManStandingToolStripMenuItem.Click
        a1.Checked = False
        a2.Checked = False
        a3.Checked = False
        a4.Checked = False
        a5.Checked = False
        b1.Checked = False
        b2.Checked = False
        b3.Checked = False
        b4.Checked = False
        b5.Checked = False
        c1.Checked = False
        c2.Checked = False

        c4.Checked = False
        c5.Checked = False
        d1.Checked = False
        d2.Checked = False
        d3.Checked = False
        d4.Checked = False
        d5.Checked = False
        e1.Checked = False
        e2.Checked = False
        e3.Checked = False
        e4.Checked = False
        e5.Checked = False

        a11.Checked = False
        a22.Checked = False
        a33.Checked = False
        a44.Checked = False
        a55.Checked = False
        b11.Checked = False
        b22.Checked = False
        b33.Checked = False
        b44.Checked = False
        b55.Checked = False
        c11.Checked = False
        c22.Checked = False

        c44.Checked = False
        c55.Checked = False
        d11.Checked = False
        d22.Checked = False
        d33.Checked = False
        d44.Checked = False
        d55.Checked = False
        e11.Checked = False
        e22.Checked = False
        e33.Checked = False
        e44.Checked = False
        e55.Checked = False

        letsgoprice = "PRICE: " + lastprice.Text
        KryptonNumericUpDown1.Text = lastwinner.Text
        labeltext.Text = "Last Man Standing"
    End Sub
End Class
