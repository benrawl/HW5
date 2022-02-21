Public Class frmDevConferenceRegistration
    'Declaring a constant variable for if the user checks yes for previously attended
    'to get a 15% discount.
    Const _cdecPreviouslyAttended As Decimal = 0.015D

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Integer variable for the number of employees, which must be <=16 and > 0
        Dim intNumberOfEmployees As Integer
        'Decimal variable for the cost per person, calculated after the button is pressed
        Dim decCostPerPerson As Decimal

        'Decimal variable for the total cost
        Dim decTotalCost As Decimal

        If IsNumeric(txtNumberOfEmployees.Text) Then
            intNumberOfEmployees = Convert.ToInt32(txtNumberOfEmployees.Text)
            If intNumberOfEmployees.Equals(0) Or intNumberOfEmployees > 16 Then
                Select Case intNumberOfEmployees
                    Case 1
                        decCostPerPerson = 795
                    Case 2
                        decCostPerPerson = 645
                    Case 3
                        decCostPerPerson = 645
                    Case 4
                        decCostPerPerson = 645
                    Case 5
                        decCostPerPerson = 475
                    Case 6
                        decCostPerPerson = 475
                    Case 7
                        decCostPerPerson = 475
                    Case 8
                        decCostPerPerson = 385
                    Case 9
                        decCostPerPerson = 385
                    Case 10
                        decCostPerPerson = 385
                    Case 11
                        decCostPerPerson = 385
                    Case 12
                        decCostPerPerson = 385
                    Case 13
                        decCostPerPerson = 385
                    Case 14
                        decCostPerPerson = 385
                    Case 15
                        decCostPerPerson = 385
                    Case 16
                        decCostPerPerson = 385
                End Select
            Else
                MessageBox.Show("Please enter a value less than 16 and greater than zero", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNumberOfEmployees.SelectAll()
                txtNumberOfEmployees.Focus()
            End If
        Else
            MessageBox.Show("Please enter a numeric value", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNumberOfEmployees.SelectAll()
            txtNumberOfEmployees.Focus()
        End If
        decTotalCost = intNumberOfEmployees * decCostPerPerson
        Select Case radYes.Checked
            Case True
                decTotalCost = decTotalCost - (decTotalCost * _cdecPreviouslyAttended
                        End Select
        lblTotalCost.Text = "Total Cost for all Employees:" & decTotalCost.ToString("c")
    End Sub

    'Clear Button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumberOfEmployees.Clear()
        lblTotalCost.Text = ""
    End Sub
End Class


