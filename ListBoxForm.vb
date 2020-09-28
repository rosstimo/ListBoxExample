
Option Strict On
Option Explicit On
Public Class ListBoxForm
    'Display a list of Invoice Title/Numbers - Store Invoice Data in a List
    'Display selected Invoice in ListBox - Combobox selected item used to reference the above mentioned list
    'Save and retrieve invoice data to/from files (File IO)
    'SaveFormatted Invoice
    'Print Formatted Invoice

    Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click
        'Simple example to add data to the list box and combo box
        InvoiceListBox.Items.Add(UserDataTextBox.Text)
        InvoiceComboBox.Items.Add(UserDataTextBox.Text)

    End Sub
    Private Sub ShowInvoice_Click(sender As Object, e As EventArgs) Handles ShowInvoiceButton.Click
        'Display formatted invoice in 
        'DisplayInListBox()
        getFakeData()
        InvoiceListBox.Items.Add(getFakeData().Item(0) & ": " & getFakeData().Item(1) & getFakeData().Item(2) & Double.Parse(getFakeData().Item(3)).ToString("C") & Double.Parse(getFakeData().Item(4)).ToString("C"))
        'Console.WriteLine(getFakeData().Item(2))
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'TODO: Clear ListBox and ComboBox
        InvoiceListBox.Items.Clear()
        InvoiceComboBox.Items.Clear()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Function HorizontalBoarder(length As Integer, characterSet As String) As String
        'Create string of desired length form characterSet pattern
        Dim tempString As String
        For i = 1 To length
            tempString &= characterSet
        Next
        Return tempString 'Str(Len(tempString))
    End Function

    Private Function MainHeader(length As Integer, title As String, characterSet As String) As String
        'create boxed title header
        'TODO: might want multiple lines, Might want choice other than center justify
        'may be replaced with gereral purpose row with columns creator
        Dim tempString As String
        tempString = title

        Do Until tempString.Length >= length - 2 '2 should be replaced with length of
            tempString = " " & tempString & " " 'this doesn't work for odd number of charactors
        Loop

        Return characterSet & tempString & characterSet 'Str(Len(characterSet & tempString & characterSet))
    End Function

    Private Function columnHeaders(firstColumn As String, secondColumn As String, thirdColumn As String, fourthColumn As String) As String
        'TODO - Take as args a list of Column Headers, Row length, inner seperator char and outer seperator char
        'Description, Unit, Rate, Subtotal
        Dim columnWidth As Integer
        columnWidth = 20
        firstColumn = "* " & firstColumn
        secondColumn = "| " & secondColumn
        thirdColumn = "| " & thirdColumn
        fourthColumn = "| " & fourthColumn

        Return firstColumn.PadRight(columnWidth) & secondColumn.PadRight(columnWidth) &
             thirdColumn.PadRight(columnWidth) & fourthColumn.PadRight(columnWidth - 1) & "*"
    End Function

    Private Sub DisplayInListBox()
        'Add formatted Invoice Example to list box
        'TODO: May want to keep multiple sets of invoice data in a list or file
        InvoiceListBox.Items.Add(HorizontalBoarder(80, "*"))
        InvoiceListBox.Items.Add(MainHeader(80, "INVOICE", "*"))
        InvoiceListBox.Items.Add(HorizontalBoarder(80, "*"))
        InvoiceListBox.Items.Add(columnHeaders("Description", "Unit", "Rate", "Subtotal"))

    End Sub

    Private Sub InvoiceListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InvoiceListBox.SelectedIndexChanged
        'Identified index and value of selected
        Console.WriteLine(InvoiceListBox.SelectedIndex)
        Console.WriteLine(InvoiceListBox.SelectedItem)
    End Sub

    Private Sub InvoiceComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InvoiceComboBox.SelectedIndexChanged
        'Identified index and value of selected
        Console.WriteLine(InvoiceComboBox.SelectedIndex)
        Console.WriteLine(InvoiceComboBox.SelectedItem)
        DisplaySelected()

    End Sub

    Private Sub DisplaySelected()
        'Select item from combobox and display info in Listbox
        Dim comboIndex As Integer
        comboIndex = InvoiceComboBox.SelectedIndex
        InvoiceListBox.Items.Clear()

        InvoiceListBox.Items.Add("Invoice #: " & InvoiceComboBox.SelectedItem.ToString)
        DisplayInListBox()
        'Save Data to List
        'TODO: Grab data from file

    End Sub

    Private Function getFakeData() As List(Of String)
        '"Description", "Unit", "Rate", "Subtotal"
        Dim description As String
        Dim quantiy As Double
        Dim units As String
        Dim rate As Double
        Dim subTotal As Double
        Dim invoiceData As New List(Of String)

        description = "Milage"
        quantiy = 50.2
        units = "mi"
        rate = 0.5
        subTotal = quantiy * rate

        invoiceData.Add(description)
        invoiceData.Add(quantiy.ToString)
        invoiceData.Add(units)
        invoiceData.Add(rate.ToString)
        invoiceData.Add(subTotal.ToString)

        'print each string value in the list
        'For Each value As String In invoiceData
        '    Console.WriteLine(value)
        'Next

        Return invoiceData

    End Function

End Class
