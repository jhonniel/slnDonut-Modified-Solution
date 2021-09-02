' Name:         Donut Solution
' Purpose:      Use Sub
' Programmer:   <Jhonniel Ygay> on <Sep 14,2020>



Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private TotalD, TotalC, Subtotal, SaleTax, Ftotal As Double
    Private Sub CostOfDoughnut()
        Dim dblDonut As Double

        If RadioButton1.Checked Then
            dblDonut = 0.75
        End If
        If RadioButton2.Checked Then
            dblDonut = 0.75
        End If
        If RadioButton3.Checked Then
            dblDonut = 0.75
        End If
        If RadioButton4.Checked Then
            dblDonut = 0.95

        End If
        TotalD = dblDonut
    End Sub

    Private Sub CostOfCoffee()
        Dim DblCoff As Double
        If RadioButton5.Checked Then
            DblCoff = 0
        End If
        If RadioButton6.Checked Then
            DblCoff = 1.5
        End If
        If RadioButton7.Checked Then
            DblCoff = 2.75

        End If
        TotalC = DblCoff

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub TotalwTax(ByVal dblTax As Double, ByVal TotalTax As Double)

        TotalTax = dblTax * 0.045
        SaleTax = TotalTax

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call CostOfDoughnut()
        Call CostOfCoffee()
        Subtotal = TotalD + TotalC
        Call TotalwTax(Subtotal, SaleTax)
        Ftotal = Subtotal + SaleTax
        lblSub.Text = Subtotal.ToString("n2")
        lblSale.Text = SaleTax.ToString("n2")
        lblTotal.Text = Ftotal.ToString("n2")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
