﻿'Zachary Christensen
'RCET 2265
'Fall 2023
'Address Label
'https://github.com/Minidude140/AddressLabel.git
Public Class AddressLabel
    'Custom Methods
    ''' <summary>
    ''' Clears any data entered in the text boxes
    ''' </summary>
    Sub CLearTextBoxes()
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
    End Sub

    ''' <summary>
    ''' Sets the Default State of Display Label and Text Boxes
    ''' </summary>
    Sub SetDefaults()
        DisplayLabel.Text = "Address Will Display Here"
        CLearTextBoxes()
    End Sub

    'Event Handlers
    Private Sub AddressLabel_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
        CLearTextBoxes()
    End Sub
End Class
