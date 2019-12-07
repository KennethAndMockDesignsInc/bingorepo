﻿Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class Form2
    Public sqlcon As New SqlConnection With {.ConnectionString = "Data Source=KMDI-ACER-E15\KMDISQLSERVER;Network Library=DBMSSOCN;Initial Catalog=RAFFLEDATA;User ID=kmdiadmin;Password=kmdiadmin;"}

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MYFILL()
        MYFILL2()
        MYFILL3()

    End Sub


    Public Sub MYFILL()
        Try
            sqlcon.Open()
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource
            ds.Clear()
            Dim load As String = "select ID,NUMBER,ITEM,RECEIVED,LABEL from raffletable WHERE LABEL = '1'"
            Dim scmd As SqlCommand = New SqlCommand(load, sqlcon)
            da.SelectCommand = scmd
            da.Fill(ds, "raffletable")
            bs.DataSource = ds
            bs.DataMember = "raffletable"
            KryptonDataGridView1.DataSource = bs
            KryptonDataGridView1.Columns("ID").Visible = False
            KryptonDataGridView1.Columns("LABEL").Visible = False
            With KryptonDataGridView1
                .DefaultCellStyle.BackColor = Color.White
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub
    Public Sub MYFILL2()
        Try
            sqlcon.Open()
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource
            ds.Clear()
            Dim load As String = "select ID,NUMBER,ITEM,RECEIVED,LABEL from raffletable WHERE LABEL = '2'"
            Dim scmd As SqlCommand = New SqlCommand(load, sqlcon)
            da.SelectCommand = scmd
            da.Fill(ds, "raffletable")
            bs.DataSource = ds
            bs.DataMember = "raffletable"
            KryptonDataGridView2.DataSource = bs
            KryptonDataGridView2.Columns("ID").Visible = False
            KryptonDataGridView2.Columns("LABEL").Visible = False
            With KryptonDataGridView1
                .DefaultCellStyle.BackColor = Color.White
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub KryptonButton141_Click(sender As Object, e As EventArgs) Handles KryptonButton141.Click

        NUMBER.Text = NUMBER.Text.Replace("'", "")
        NUMBER.Text = NUMBER.Text.Replace("""", "")
        ITEM.Text = ITEM.Text.Replace("'", "")
        ITEM.Text = ITEM.Text.Replace("""", "")
        LABEL.Text = LABEL.Text.Replace("'", "")
        LABEL.Text = LABEL.Text.Replace("""", "")
        additem(NUMBER.Text, ITEM.Text, LABEL.Text)
        MYFILL()
    End Sub
    Public Sub additem(ByVal NUMBER As String, ByVal ITEM As String, ByVal LABEL As String)
        Try
            sqlcon.Open()
            Dim add As String = "insert into raffletable (number,item,LABEL)
values('" & NUMBER & "'," &
"'" & ITEM & "'," &
"'" & LABEL & "')"
            Dim sqlcmd As SqlCommand = New SqlCommand(add, sqlcon)
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub KryptonButton138_Click(sender As Object, e As EventArgs) Handles KryptonButton138.Click
        MYFILL()
    End Sub

    Private Sub KryptonButton140_Click(sender As Object, e As EventArgs) Handles KryptonButton140.Click
        ID.Text = ID.Text.Replace("'", "")
        ID.Text = ID.Text.Replace("""", "")
        NUMBER.Text = NUMBER.Text.Replace("'", "")
        NUMBER.Text = NUMBER.Text.Replace("""", "")
        ITEM.Text = ITEM.Text.Replace("'", "")
        ITEM.Text = ITEM.Text.Replace("""", "")

        UPDATEITEM(ID.Text, NUMBER.Text, ITEM.Text)
        MYFILL()
    End Sub
    Public Sub UPDATEITEM(ByVal ID As String, ByVal NUMBER As String, ByVal ITEM As String)
        Try
            sqlcon.Open()
            Dim update As String = "update raffletable set number='" & NUMBER & "',item='" & ITEM & "' 
where id ='" & ID & "'"
            Dim sqlcmd As SqlCommand = New SqlCommand(update, sqlcon)
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub KryptonDataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles KryptonDataGridView1.SelectionChanged
        Dim selecteditems As DataGridViewSelectedRowCollection = KryptonDataGridView1.SelectedRows
        ComboBox1.Items.Clear()
        Dim id As String
        For Each selecteditem As DataGridViewRow In selecteditems
            id = selecteditem.Cells("id").Value.ToString
            ComboBox1.Items.Add(id)
        Next
    End Sub

    Private Sub KryptonDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles KryptonDataGridView1.CellClick
        If KryptonDataGridView1.RowCount >= 0 And e.RowIndex >= 0 Then
            ID.Text = KryptonDataGridView1.Item(0, e.RowIndex).Value.ToString
            NUMBER.Text = KryptonDataGridView1.Item(1, e.RowIndex).Value.ToString
            ITEM.Text = KryptonDataGridView1.Item(2, e.RowIndex).Value.ToString
        End If
    End Sub

    Private Sub KryptonButton139_Click(sender As Object, e As EventArgs) Handles KryptonButton139.Click
        For i As Integer = 0 To ComboBox1.Items.Count - 1
            Dim x As String
            x = ComboBox1.Items(i)
            deleteitem(x)
        Next
        MYFILL()
    End Sub
    Public Sub deleteitem(ByVal id As String)
        Try
            sqlcon.Open()
            Dim delete As String = "delete from raffletable where id ='" & id & "'"
            Dim sqlcmd As SqlCommand = New SqlCommand(delete, sqlcon)
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        PictureBox2.Visible = True
        PictureBox1.Visible = False

        KryptonButton4.Visible = False
        ResetToolStripMenuItem.PerformClick()
        KryptonLabel3.Text = ""
        ProgressBar1.Increment(1)
        ComboBox5.SelectedIndex = ProgressBar1.Value - 1
        search(ComboBox5.Text)
        BeLazy()
        Timer1.Start()
        Timer1.Interval = 100
        KryptonButton1.Enabled = False
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click

        MYFILL()
        MYFILL2()
        KryptonTextBox1.Focus()
        TabControl1.SelectedTab = TabPage2
        KryptonLabel4.Text = ""
        'ComboBox3.Items.Clear()
        ProgressBar1.Value = 0
        ProgressBar2.Value = 0
        ProgressBar3.Value = 0
        ProgressBar2.Maximum = 13

        Dim range = Enumerable.Range(0, 14).ToList()
        Dim myrandom As New Random()
        Dim mynum As Integer
        For i As Integer = 1 To 13
            mynum = myrandom.Next(1, range.Count)
            ComboBox3.Items.Add(range(mynum))
            range.RemoveAt(mynum)
        Next



        KryptonDataGridView1.SelectAll()
        Dim selecteditems As DataGridViewSelectedRowCollection = KryptonDataGridView1.SelectedRows
        ComboBox4.Items.Clear()
        ComboBox5.Items.Clear()
        ComboBox5.Text = ""
        Dim c As String
        Dim rec As String
        For Each selecteditem As DataGridViewRow In selecteditems
            c = selecteditem.Cells("NUMBER").Value.ToString
            rec = selecteditem.Cells("received").Value.ToString
            If rec = "" Then
                ComboBox4.Items.Add(c)
            Else
            End If
        Next
        Dim h = Enumerable.Range(0, ComboBox4.Items.Count).ToList()
        Dim j As New Random()
        Dim k As Integer
        For i As Integer = 0 To ComboBox4.Items.Count - 1
            k = j.Next(0, h.Count)
            ComboBox5.Items.Add(ComboBox4.Items(h(k)))
            h.RemoveAt(k)
        Next
        ProgressBar1.Maximum = ComboBox4.Items.Count


        KryptonDataGridView2.SelectAll()
        Dim selecteditems2 As DataGridViewSelectedRowCollection = KryptonDataGridView2.SelectedRows
        ComboBox6.Items.Clear()
        ComboBox7.Items.Clear()
        ComboBox7.Text = ""
        Dim c2 As String
        Dim rec2 As String
        For Each selecteditem As DataGridViewRow In selecteditems2
            c2 = selecteditem.Cells("NUMBER").Value.ToString
            rec2 = selecteditem.Cells("received").Value.ToString
            If rec2 = "" Then
                ComboBox6.Items.Add(c2)
            Else
            End If
        Next
        Dim h2 = Enumerable.Range(0, ComboBox6.Items.Count).ToList()
        Dim j2 As New Random()
        Dim k2 As Integer
        For i2 As Integer = 0 To ComboBox6.Items.Count - 1
            k2 = j2.Next(0, h2.Count)
            ComboBox7.Items.Add(ComboBox6.Items(h2(k2)))
            h2.RemoveAt(k2)
        Next
        ProgressBar3.Maximum = ComboBox6.Items.Count
    End Sub

    Public Sub search(ByVal number As String)
        Try
            sqlcon.Open()
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource
            ds.Clear()
            Dim search As String = "select * from raffletable where number ='" & number & "'"
            Dim sqlcmd As SqlCommand = New SqlCommand(search, sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "raffletable")
            bs.DataSource = ds
            bs.DataMember = "raffletable"
            KryptonLabel4.DataBindings.Clear()

            KryptonLabel4.DataBindings.Add("text", bs, "item")
            If KryptonLabel4.Text = "" Then
                KryptonLabel4.Text = "0 Result"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar2.Increment(1)
        ComboBox3.SelectedIndex = ProgressBar2.Value - 1
        KryptonLabel5.Text = ComboBox3.Text
        If ProgressBar2.Value = 13 Then
            Timer1.Stop()
            PictureBox2.Visible = False
            PictureBox1.Visible = True
            KryptonButton4.Visible = True
            KryptonLabel5.Text = ComboBox5.Text
            ProgressBar2.Value = 0
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            Dim mystr As String = KryptonLabel4.Text
            Dim separate = mystr.Split(" ")
            KryptonLabel3.Text = ""
            For i As Integer = 0 To separate.Length - 1
                Dim myrandom As New Random()
                Dim ShuffledItems = separate(i).OrderBy(Function() myrandom.Next).ToArray()
                KryptonLabel3.Text = KryptonLabel3.Text + " " + ShuffledItems
            Next
        End If
    End Sub

    Private Sub KryptonButton2_Click(sender As Object, e As EventArgs) Handles KryptonButton2.Click

        Dim mystr As String = KryptonLabel4.Text
        Dim separate = mystr.Split(" ")
        KryptonLabel3.Text = ""
        For i As Integer = 0 To separate.Length - 1
            Dim myrandom As New Random()
            Dim ShuffledItems = separate(i).OrderBy(Function() myrandom.Next).ToArray()
            KryptonLabel3.Text = KryptonLabel3.Text + " " + ShuffledItems
        Next
    End Sub

    Private Sub KryptonButton3_Click(sender As Object, e As EventArgs) Handles KryptonButton3.Click
        KryptonLabel3.Text = KryptonLabel4.Text
    End Sub

    Private Sub KryptonButton4_Click(sender As Object, e As EventArgs) Handles KryptonButton4.Click
        received(KryptonLabel5.Text)
        MYFILL()
        MYFILL2()
    End Sub
    Public Sub received(ByVal number As String)
        Try
            sqlcon.Open()
            Dim rec As String = "update raffletable set received = '" & KryptonTextBox1.Text & "' where number = '" & number & "'"
            Dim sqlcmd As SqlCommand = New SqlCommand(rec, sqlcon)
            sqlcmd.ExecuteNonQuery()
            KryptonTextBox1.Clear()
            KryptonTextBox1.Focus()
            KryptonButton4.Visible = False
            KryptonLabel5.Text = ""
            KryptonLabel3.Text = ""
            countitem2()
            countitem1()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Public Sub countitem2()
        Try
            Dim str As String = "select count(item) from raffletable where label = 2 and received=''"
            Dim cmd As SqlCommand = New SqlCommand(str, sqlcon)
            Dim read As SqlDataReader = cmd.ExecuteReader
            While read.Read
                KryptonButton9.Text = read(0).ToString
            End While
            read.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub countitem1()
        Try
            Dim str As String = "select count(item) from raffletable where label = 1 and received=''"
            Dim cmd As SqlCommand = New SqlCommand(str, sqlcon)
            Dim read As SqlDataReader = cmd.ExecuteReader
            While read.Read
                KryptonButton1.Text = read(0).ToString
            End While
            read.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub KryptonButton5_Click(sender As Object, e As EventArgs) Handles KryptonButton5.Click

        CNUMBER.Text = CNUMBER.Text.Replace("'", "")
        CNUMBER.Text = CNUMBER.Text.Replace("""", "")
        CITEM.Text = CITEM.Text.Replace("'", "")
        CITEM.Text = CITEM.Text.Replace("""", "")
        CLABEL.Text = CLABEL.Text.Replace("'", "")
        CLABEL.Text = CLABEL.Text.Replace("""", "")
        additem(CNUMBER.Text, CITEM.Text, CLABEL.Text)
        MYFILL2()
    End Sub

    Private Sub KryptonButton6_Click(sender As Object, e As EventArgs) Handles KryptonButton6.Click
        CID.Text = CID.Text.Replace("'", "")
        CID.Text = CID.Text.Replace("""", "")
        CNUMBER.Text = CNUMBER.Text.Replace("'", "")
        CNUMBER.Text = CNUMBER.Text.Replace("""", "")
        CITEM.Text = CITEM.Text.Replace("'", "")
        CITEM.Text = CITEM.Text.Replace("""", "")

        UPDATEITEM(CID.Text, CNUMBER.Text, CITEM.Text)
        MYFILL2()
    End Sub

    Private Sub KryptonDataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles KryptonDataGridView2.SelectionChanged
        Dim selecteditems As DataGridViewSelectedRowCollection = KryptonDataGridView2.SelectedRows
        ComboBox2.Items.Clear()
        Dim x As String
        For Each selecteditem As DataGridViewRow In selecteditems
            x = selecteditem.Cells.Item("id").Value.ToString
            ComboBox2.Items.Add(x)
        Next
    End Sub

    Private Sub KryptonButton7_Click(sender As Object, e As EventArgs) Handles KryptonButton7.Click
        For i As Integer = 0 To ComboBox2.Items.Count - 1
            Dim x As String
            x = ComboBox2.Items(i)
            deleteitem(x)
        Next
        MYFILL2()
    End Sub

    Private Sub KryptonDataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles KryptonDataGridView2.CellClick
        If KryptonDataGridView2.RowCount >= 0 And e.RowIndex >= 0 Then
            CID.Text = KryptonDataGridView2.Item(0, e.RowIndex).Value.ToString
            CNUMBER.Text = KryptonDataGridView2.Item(1, e.RowIndex).Value.ToString
            CITEM.Text = KryptonDataGridView2.Item(2, e.RowIndex).Value.ToString
        End If
    End Sub

    Private Sub KryptonButton9_Click(sender As Object, e As EventArgs) Handles KryptonButton9.Click
        PictureBox2.Visible = True
        PictureBox1.Visible = False

        KryptonButton4.Visible = False
        ResetToolStripMenuItem.PerformClick()
        KryptonLabel3.Text = ""
        ProgressBar3.Increment(1)
        ComboBox7.SelectedIndex = ProgressBar3.Value - 1
        search(ComboBox7.Text)
        BeLazy()
        Timer2.Start()
        Timer2.Interval = 100
        KryptonButton9.Enabled = False
    End Sub
    Public Sub BeLazy()
        For i = 1 To 15
            Threading.Thread.Sleep(17)
            Application.DoEvents()
        Next
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar2.Increment(1)
        ComboBox3.SelectedIndex = ProgressBar2.Value - 1
        KryptonLabel5.Text = ComboBox3.Text
        If ProgressBar2.Value = 13 Then
            Timer2.Stop()
            PictureBox2.Visible = False
            PictureBox1.Visible = True
            KryptonButton4.Visible = True
            KryptonLabel5.Text = ComboBox7.Text
            ProgressBar2.Value = 0

            Dim mystr As String = KryptonLabel4.Text
            Dim separate = mystr.Split(" ")
            KryptonLabel3.Text = ""
            For i As Integer = 0 To separate.Length - 1
                Dim myrandom As New Random()
                Dim ShuffledItems = separate(i).OrderBy(Function() myrandom.Next).ToArray()
                KryptonLabel3.Text = KryptonLabel3.Text + " " + ShuffledItems
            Next
        End If
    End Sub

    Private Sub EditItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditItemsToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage5
        MYFILL3()
        MYFILL2()
        MYFILL()
    End Sub

    Private Sub KryptonButton8_Click(sender As Object, e As EventArgs) Handles KryptonButton8.Click
        MYFILL2()
    End Sub
    Private Sub KryptonLabel3_MouseDown(sender As Object, e As MouseEventArgs) Handles KryptonLabel3.MouseDown
        If e.Button = MouseButtons.Right Then
            KryptonButton1.Enabled = False
            KryptonButton9.Enabled = True
        ElseIf e.Button = MouseButtons.Left Then
            KryptonButton1.Enabled = True
            KryptonButton9.Enabled = False
        End If
    End Sub

    Private Sub KryptonTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles KryptonTextBox1.KeyDown
        'If e.KeyValue = Keys.Enter Then
        '    If KryptonButton1.Enabled = True Then
        '        KryptonButton1.PerformClick()
        '        KryptonButton1.Enabled = False
        '    ElseIf KryptonButton9.Enabled = True Then
        '        KryptonButton9.PerformClick()
        '        KryptonButton9.Enabled = False
        '    End If
        'End If
    End Sub

    Private Sub KryptonLabel5_MouseDown(sender As Object, e As MouseEventArgs) Handles KryptonLabel5.MouseDown
        If e.Button = MouseButtons.Right Then
            KryptonButton1.Enabled = False
            KryptonButton9.Enabled = True
        ElseIf e.Button = MouseButtons.Left Then
            KryptonButton1.Enabled = True
            KryptonButton9.Enabled = False
        End If
    End Sub

    Private Sub KryptonButton13_Click(sender As Object, e As EventArgs) Handles KryptonButton13.Click
        MYFILL3()
        MYFILL2()
        MYFILL()
    End Sub
    Public Sub MYFILL3()
        Try
            sqlcon.Open()
            Dim DS As New DataSet
            Dim DA As New SqlDataAdapter
            Dim BS As New BindingSource
            DS.Clear()
            Dim STR As String = "SELECT * FROM RAFFLETABLE"
            Dim SQLCMD As SqlCommand = New SqlCommand(STR, sqlcon)
            DA.SelectCommand = SQLCMD
            DA.Fill(DS, "RAFFLETABLE")
            BS.DataSource = DS
            BS.DataMember = "RAFFLETABLE"
            KryptonDataGridView3.DataSource = BS
            KryptonDataGridView3.Columns("ID").Visible = False
            countitem2()
            countitem1()
            With KryptonDataGridView3
                .DefaultCellStyle.BackColor = Color.WhiteSmoke
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub KryptonDataGridView3_SelectionChanged(sender As Object, e As EventArgs) Handles KryptonDataGridView3.SelectionChanged
        Dim selecteditems As DataGridViewSelectedRowCollection = KryptonDataGridView3.SelectedRows
        ComboBox8.Items.Clear()
        Dim X As String
        For Each selecteditem As DataGridViewRow In selecteditems
            X = selecteditem.Cells("ID").Value.ToString()
            ComboBox8.Items.Add(X)
        Next
    End Sub

    Private Sub KryptonDataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles KryptonDataGridView3.CellClick
        If KryptonDataGridView3.RowCount >= 0 And e.RowIndex >= 0 Then
            FINALID.Text = KryptonDataGridView3.Item(0, e.RowIndex).Value.ToString
            FINALNUMBER.Text = KryptonDataGridView3.Item(1, e.RowIndex).Value.ToString
            FINALITEM.Text = KryptonDataGridView3.Item(2, e.RowIndex).Value.ToString
            FINALRECEIVED.Text = KryptonDataGridView3.Item(3, e.RowIndex).Value.ToString
            FINALLABEL.Text = KryptonDataGridView3.Item(4, e.RowIndex).Value.ToString
        End If
    End Sub

    Private Sub KryptonButton10_Click(sender As Object, e As EventArgs) Handles KryptonButton10.Click
        FINALID.Text = FINALID.Text.Replace("'", "")
        FINALID.Text = FINALID.Text.Replace("""", "")
        FINALNUMBER.Text = FINALNUMBER.Text.Replace("'", "")
        FINALNUMBER.Text = FINALNUMBER.Text.Replace("""", "")
        FINALITEM.Text = FINALITEM.Text.Replace("'", "")
        FINALITEM.Text = FINALITEM.Text.Replace("""", "")
        FINALRECEIVED.Text = FINALRECEIVED.Text.Replace("'", "")
        FINALRECEIVED.Text = FINALRECEIVED.Text.Replace("""", "")
        FINALLABEL.Text = FINALLABEL.Text.Replace("'", "")
        FINALLABEL.Text = FINALLABEL.Text.Replace("""", "")

        FINALADD(FINALNUMBER.Text, FINALITEM.Text, FINALLABEL.Text)
        MYFILL3()
        MYFILL()
        MYFILL2()
    End Sub
    Public Sub FINALADD(ByVal NUMBER As String,
                        ByVal ITEM As String,
                        ByVal LABEL As String)
        Try
            sqlcon.Open()
            Dim FIND As String = "SELECT * FROM RAFFLETABLE WHERE NUMBER = '" & NUMBER & "'"
            Dim CMD As SqlCommand = New SqlCommand(FIND, sqlcon)
            Dim README As SqlDataReader = CMD.ExecuteReader
            If README.HasRows = True Then
                README.Close()
                MessageBox.Show("INVALID ENTRY DUPLICATE ITEM NUMBER", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                README.Close()
                Dim INSERT As String = "INSERT INTO RAFFLETABLE (NUMBER,ITEM,LABEL) VALUES
('" & NUMBER & "','" & ITEM & "','" & LABEL & "')"
                Dim SQLCMD As SqlCommand = New SqlCommand(INSERT, sqlcon)
                SQLCMD.ExecuteNonQuery()
            End If



        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub KryptonButton11_Click(sender As Object, e As EventArgs) Handles KryptonButton11.Click
        FINALID.Text = FINALID.Text.Replace("'", "")
        FINALID.Text = FINALID.Text.Replace("""", "")
        FINALNUMBER.Text = FINALNUMBER.Text.Replace("'", "")
        FINALNUMBER.Text = FINALNUMBER.Text.Replace("""", "")
        FINALITEM.Text = FINALITEM.Text.Replace("'", "")
        FINALITEM.Text = FINALITEM.Text.Replace("""", "")
        FINALRECEIVED.Text = FINALRECEIVED.Text.Replace("'", "")
        FINALRECEIVED.Text = FINALRECEIVED.Text.Replace("""", "")
        FINALLABEL.Text = FINALLABEL.Text.Replace("'", "")
        FINALLABEL.Text = FINALLABEL.Text.Replace("""", "")

        FINALUPDATE(FINALID.Text, FINALNUMBER.Text, FINALITEM.Text, FINALRECEIVED.Text, FINALLABEL.Text)
        MYFILL3()
        MYFILL()
        MYFILL2()
    End Sub
    Public Sub FINALUPDATE(ByVal ID As String,
                           ByVal NUMBER As String,
                        ByVal ITEM As String,
                           ByVal RECEIVED As String,
                        ByVal LABEL As String)
        Try
            sqlcon.Open()

            Dim UPDATE As String = "UPDATE RAFFLETABLE SET  NUMBER='" & NUMBER & "',ITEM='" & ITEM & "',RECEIVED='" & RECEIVED & "',LABEL='" & LABEL & "'
WHERE ID = '" & ID & "'"
            Dim SQLCMD As SqlCommand = New SqlCommand(UPDATE, sqlcon)
                SQLCMD.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub KryptonButton12_Click(sender As Object, e As EventArgs) Handles KryptonButton12.Click
        For I As Integer = 0 To ComboBox8.Items.Count - 1
            Dim ID As String = ComboBox8.Items(I)
            deleteitem(ID)
        Next
        MYFILL3()
        MYFILL()
        MYFILL2()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Sure you wanna exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub KryptonButton14_Click(sender As Object, e As EventArgs) Handles KryptonButton14.Click
        Dim word As String
        Dim result As String
        Dim mystr As String = Trim(KryptonLabel4.Text)
        Dim separate = mystr.Split(" ")
        For i As Integer = 0 To separate.Length - 1

            Dim separatedtoarray As [String] = separate(i)
            Dim separatedwordlenght As Integer = separatedtoarray.Length
            Dim range = Enumerable.Range(0, separatedwordlenght - 1).ToList()
            Dim myrandom As New Random()
            Dim mynum As Integer
            For r As Integer = 1 To separatedwordlenght - 2
                mynum = myrandom.Next(1, range.Count)
                word = word + separatedtoarray(range(mynum))
                range.RemoveAt(mynum)
            Next
            Dim firstletter As String = separatedtoarray(0)
            Dim lastletter As String = separatedtoarray(separatedwordlenght - 1)
            result = result + " " + (firstletter + word + lastletter)
            word = ""
        Next
        KryptonLabel3.Text = ""
        KryptonLabel3.Text = Trim(result)
    End Sub


    Public Sub regevent()
        PictureBox2.Visible = True
        PictureBox1.Visible = False

        KryptonButton4.Visible = False
        ResetToolStripMenuItem.PerformClick()
        KryptonLabel3.Text = ""
        ProgressBar1.Increment(1)
        ComboBox5.SelectedIndex = ProgressBar1.Value - 1
        search(ComboBox5.Text)
        BeLazy()
        Timer1.Start()
        Timer1.Interval = 100
    End Sub
    Public Sub casualevent()
        PictureBox2.Visible = True
        PictureBox1.Visible = False

        KryptonButton4.Visible = False
        ResetToolStripMenuItem.PerformClick()
        KryptonLabel3.Text = ""
        ProgressBar3.Increment(1)
        ComboBox7.SelectedIndex = ProgressBar3.Value - 1
        search(ComboBox7.Text)
        BeLazy()
        Timer2.Start()
        Timer2.Interval = 100
    End Sub
End Class