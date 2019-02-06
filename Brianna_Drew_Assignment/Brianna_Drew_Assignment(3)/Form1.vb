'
' This is a form that performs as a basic sales receipt producer for a store.
'
' Written by: Brianna Drew (0622446) - March 2018
'
' Purpose: To produce a properly formatted sales receipt for a store based on input.
'
' Parameters: None.
'
' Subroutine Required: The form itself loading has a subroutine as well as each button on the form has it's own subroutine.
'
' Modifications: - March 3/18 - Program started, basic features dragged to form (buttons, text box, label) as well as almost the entire
'                               program written (except for coding of the reset button).
'                - March 4/18 - Reset button and it's code added, some comments added.
'                - March 6/18 - Rest of comments added.
'

Public Class Form1


    ' This section of code defines the variables required (at class-level).
    Dim fmtStr As String = "{0, 18}{1, 18}" ' Definition for variable that holds the format for character padding for elements on the receipt.
    Dim itemCount As Integer = 0 ' Definition for variable to hold the number of items added to the receipt.
    Dim totalCost As Double = 0.0 ' Definition for variable to hold the total cost of items in the transaction before tax.
    Dim taxCalc As Double = 0.0 ' Definition for variable to hold the calculated tax to be added to the total cost of the transaction.
    Dim finalCost As Double = 0.0 ' Definition for variable to hold the total cost of items in the transaction including tax.


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This subroutine runs when the form (program) first loads.

        salesReceipt.Items.Add(" Welcome to Brianna's Rockin' Records!") ' Add a "welcome" statement to the receipt (list box).
        salesReceipt.Items.Add(" ") ' Add blank line to receipt (list box) to format.
        salesReceipt.Items.Add("         " & DateAndTime.Now.ToString) ' Add the current date and time to the receipt (list box).
        salesReceipt.Items.Add(" ") ' Add blank line to receipt (list box) to format.

    End Sub


    Private Sub addItem_Click(sender As Object, e As EventArgs) Handles addItem.Click
        ' This subroutine runs when the "add item to receipt" button is clicked.

        If Not IsNumeric(priceBox.Text) Then ' If what was entered as the item price is not a numerical value, then...
            MessageBox.Show("Invalid Price Format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ' A small window appears showing the
            ' error along with a ok button and exclamation icon.
        Else ' If what was entered as the item price is a numerical value, then...
            salesReceipt.Items.Add(String.Format(fmtStr, itemBox.Text, FormatCurrency(priceBox.Text))) ' Adds the item name and price entered to the
            ' receipt (list box) formatted with the character padding, as well as the price formatted as currency.
            totalCost += priceBox.Text ' Adds the price of item entered to the sum of the item prices.
            itemCount += 1 ' Number of items increases by 1.
        End If

        itemBox.Clear() ' Clear the item entered from the box in which it was inputted.
        priceBox.Clear() ' Clear the item price entered from the box in which it was inputted.

    End Sub


    Private Sub endSale_Click(sender As Object, e As EventArgs) Handles endSale.Click
        ' This subroutine runs when the "end transaction" button is clicked.

        endSale.Enabled = False ' Disables the "end transaction" button.
        addItem.Enabled = False ' Disables the "add item to receipt" button.
        salesReceipt.Items.Add(String.Format(fmtStr, "---------------", "----------")) ' Adds dotted line to seperate items and calculations to the
        ' receipt (list box) formatted with the character padding.
        salesReceipt.Items.Add(String.Format(fmtStr, "Cost of Items: ", (FormatCurrency(totalCost)))) ' Adds the total cost of items (before tax) to
        ' the receipt (list box) formatted with the character padding and with the actual value formatted as a currency.
        salesReceipt.Items.Add(String.Format(fmtStr, "Number of Items: ", itemCount)) ' Adds the total number of items purchased to the receipt
        ' (list box) formatted with the character padding.
        taxCalc = totalCost * 0.13 ' Calculates the amount of tax to be added to the cost of items and assigns that value to the designated variable.
        salesReceipt.Items.Add(String.Format(fmtStr, "Taxes: ", (FormatCurrency(taxCalc)))) ' Adds the tax to be added to the cost of items to the
        ' receipt (list box) formatted with the character padding and with the actual value formatted as a currency.
        finalCost = totalCost + taxCalc ' Calculates the final cost by adding the tax to the cost of items and assigns that value to the designated variable.
        salesReceipt.Items.Add(String.Format(fmtStr, "Total Cost: ", (FormatCurrency(finalCost)))) ' Adds the total cost (including tax) to the receipt
        ' (list box) formatted with the character padding and with the actual value formatted as a currency.
        salesReceipt.Items.Add(" ") ' Add blank line to receipt (list box) to format.
        salesReceipt.Items.Add("Thank you for shopping with us!") ' Add a "farewell" statement to the receipt (list box).
        salesReceipt.Items.Add("Come back again soon!") ' Add a "farewell" statement to the receipt (list box).

    End Sub


    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        ' This subroutine runs when the "reset" button is clicked.

        endSale.Enabled = True ' Re-enables the "end transaction" button.
        addItem.Enabled = True ' Re-enables the "add item to receipt" button.
        salesReceipt.Items.Clear() ' Clears everything from the receipt (list box).
        itemCount = 0 ' Resets variable that holds the number of items added to the receipt to 0.
        totalCost = 0.0 ' Resets variable that holds the total cost of items in the transaction before tax to 0.
        taxCalc = 0.0 ' Resets variable that holds the calculated tax to be added to the total cost of the transaction to 0.
        finalCost = 0.0 ' Resets variable that holds the total cost of items in the transaction including tax to 0.
        salesReceipt.Items.Add(" Welcome to Brianna's Rockin' Records!") ' Add a "welcome" statement to the receipt (list box).
        salesReceipt.Items.Add(" ") ' Add blank line to receipt (list box) to format.
        salesReceipt.Items.Add("         " & DateAndTime.Now.ToString) ' Add the current date and time to the receipt (list box).
        salesReceipt.Items.Add(" ") ' Add blank line to receipt (list box) to format.

    End Sub


    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        ' This subroutine runs when the "exit" button is clicked.

        Me.Close() ' Program closes.

    End Sub


End Class
