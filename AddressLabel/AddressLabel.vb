'Zachary Christensen
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

    ''' <summary>
    ''' Inputs two strings and concatenates with a space in between
    ''' </summary>
    ''' <param name="First"></param>
    ''' <param name="Second"></param>
    ''' <returns></returns>
    Function ConcatenateNames(First As String, Second As String) As String
        Dim fullName As String
        fullName = $"{First} {Second}"
        Return fullName
    End Function

    ''' <summary>
    ''' Updates the Display Label 
    ''' </summary>
    Sub UpdateDisplay()
        DisplayLabel.Text = ConcatenateNames(FirstNameTextBox.Text, LastNameTextBox.Text)
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

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        UpdateDisplay()
    End Sub
End Class
