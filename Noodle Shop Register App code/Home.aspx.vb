'   Kevin Kirspel
'   3/29/2013
'   Noodle Shop Program 3

'   The Home page is set up to correctly gather the user's name and email
'   address. After the input is validated, the user is able to continue to
'   The Menu page.
'   The user can also clear the current entered data from here.

Public Class _Default
    Inherits System.Web.UI.Page

    'When text is entered in a text box, the continue button is automatically 
    'disabled. 
    'Then after checking every character for being numeric, a boolean is turned 
    'true to validate this text box (one of three),  if no numeric characters 
    'are found.
    'Lastly, if all three booleans that validate the three textboxes are true, 
    'the continue button is re-enabled.
    Public Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        btnContinue.Enabled = False
        validFirstName = True
        If txtFirstName.Text.Length < 0 Then
            lblFirstNameError.Text = "* required entry"
        Else
            For Each Character As Char In txtFirstName.Text
                If Char.IsNumber(Character) Then
                    lblFirstNameError.Text = "* cannot be numeric"
                    validFirstName = False
                End If
            Next
        End If
        If validFirstName = True Then
            lblFirstNameError.Text = ""
            If validLastName = True And validEmail = True Then
                btnContinue.Enabled = True
            End If
        End If
    End Sub

    ' Follows the same logic as the above method.
    Public Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        btnContinue.Enabled = False
        validLastName = True
        If txtLastName.Text.Length < 0 Then
            lblLastNameError.Text = "* required entry"
        Else
            For Each Character As Char In txtLastName.Text
                If Char.IsNumber(Character) Then
                    lblLastNameError.Text = "* cannot be numeric"
                    validLastName = False
                End If
            Next
        End If
        If validLastName = True Then
            lblLastNameError.Text = ""
            If validFirstName = True And validEmail = True Then
                btnContinue.Enabled = True
            End If
        End If
    End Sub

    'Follows the same logic as the above methods, except that a 
    'RegularExpressionValidator checks for the correct email format.
    Public Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        btnContinue.Enabled = False
        validEmail = True
        If validEmail = True Then
            If validFirstName = True And validLastName = True Then
                btnContinue.Enabled = True
            End If
        End If
    End Sub

    'Resets textboxes, booleans, and the continue button to orginal state.
    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtEmail.Text = ""
        lblFirstNameError.Text = ""
        lblLastNameError.Text = ""
        validFirstName = False
        validLastName = False
        validEmail = False
        btnContinue.Enabled = False
    End Sub

    'Stores the text datas to global variables and opens the menu page.
    Protected Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        strFirstName = txtFirstName.Text
        strLastName = txtLastName.Text
        strEmail = txtEmail.Text
        Response.Redirect("menu.aspx")
    End Sub

End Class