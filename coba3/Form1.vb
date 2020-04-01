Imports System.ComponentModel

Public Class Form1
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub btnkurang_Click(sender As Object, e As EventArgs) Handles btnkurang.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub btnkali_Click(sender As Object, e As EventArgs) Handles btnkali.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub btnbagi_Click(sender As Object, e As EventArgs) Handles btnbagi.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub btnhps_Click(sender As Object, e As EventArgs) Handles btnhps.Click
        bil1.Text = ""
        bil2.Clear()
        hsil.Text = ""
        hsil.Focus()
    End Sub

    Private Sub btnext_Click(sender As Object, e As EventArgs) Handles btnext.Click
        Me.Close()
    End Sub

    Private Sub Coba1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For i = 0 To 100
            Label4.Text = i
            BackgroundWorker1.ReportProgress(i)
            System.Threading.Thread.Sleep(200)
            Label4.Refresh()
        Next
        hsil.Text = Val(bil1.Text) + Val(bil2.Text)
        hsil.Text = Val(bil1.Text) - Val(bil2.Text)
        hsil.Text = Val(bil1.Text) * Val(bil2.Text)
        hsil.Text = Val(bil1.Text) / Val(bil2.Text)
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Label4.Text = "Success!"
    End Sub

    Private Sub Forel_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

End Class
