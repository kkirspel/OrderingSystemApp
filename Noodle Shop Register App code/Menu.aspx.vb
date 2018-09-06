'   Kevin Kirspel
'   3/29/2013
'   Noodle Shop Program 3

'   At the Menu page, the user selects the type of food they would like, and
'   chooses an option within that type of food. Once the user has correctly selected
'   at least one option, they can continue to the Review page.
'   The user can also clear the currently selected items from here.


Public Class About
    Inherits System.Web.UI.Page

    'Begins by assuming the continue button will be enabled.
    'If when the selection has been changed the index isn't on the original item,
    'every other check box is checked to see if which others are also 'checked' 
    '(which enables their related drop-down list). Of the one's checked, if their 
    'related drop-down list also has a current index that's not "0" (the original item),
    'Then nothing happens and the continue button remains enabled. In any other case
    '(any ddl having a current index of "0"), the continue button is disabled.
    Protected Sub ddlNoodle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlNoodle.SelectedIndexChanged
        enableContinue = True
        If ddlNoodle.SelectedIndex = 0 Then
            enableContinue = False
        Else
            If ddlRice.Enabled = True Then
                If ddlRice.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
            If ddlOther.Enabled = True Then
                If ddlOther.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
            If ddlToppings.Enabled = True Then
                If ddlToppings.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
            If ddlTea.Enabled = True Then
                If ddlTea.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
        End If
        If enableContinue = True Then
            btnContinue.Enabled = True
        Else
            btnContinue.Enabled = False
        End If
    End Sub

    'Follows the same logic as the above method.
    Protected Sub ddlRice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlRice.SelectedIndexChanged
        enableContinue = True
        If ddlRice.SelectedIndex = 0 Then
            enableContinue = False
        Else
            If ddlNoodle.Enabled = True Then
                If ddlNoodle.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
            If ddlOther.Enabled = True Then
                If ddlOther.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
            If ddlToppings.Enabled = True Then
                If ddlToppings.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
            If ddlTea.Enabled = True Then
                If ddlTea.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
        End If
        If enableContinue = True Then
            btnContinue.Enabled = True
        Else
            btnContinue.Enabled = False
        End If
    End Sub

    'Follows the same logic as the above method.
    Protected Sub ddlOther_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlOther.SelectedIndexChanged
        enableContinue = True
        If ddlOther.SelectedIndex = 0 Then
            enableContinue = False
        Else
            If ddlNoodle.Enabled = True Then
                If ddlNoodle.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
            If ddlRice.Enabled = True Then
                If ddlRice.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
            If ddlToppings.Enabled = True Then
                If ddlToppings.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
            If ddlTea.Enabled = True Then
                If ddlTea.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
        End If
        If enableContinue = True Then
            btnContinue.Enabled = True
        Else
            btnContinue.Enabled = False
        End If
    End Sub

    'Follows the same logic as the above method.
    Protected Sub ddlToppings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlToppings.SelectedIndexChanged
        enableContinue = True
        If ddlToppings.SelectedIndex = 0 Then
            enableContinue = False
        Else
            If ddlNoodle.Enabled = True Then
                If ddlNoodle.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
            If ddlRice.Enabled = True Then
                If ddlRice.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
            If ddlOther.Enabled = True Then
                If ddlOther.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
            If ddlTea.Enabled = True Then
                If ddlTea.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
        End If
        If enableContinue = True Then
            btnContinue.Enabled = True
        Else
            btnContinue.Enabled = False
        End If
    End Sub

    'Follows the same logic as the above method.
    Protected Sub ddlTea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlTea.SelectedIndexChanged
        enableContinue = True
        If ddlTea.SelectedIndex = 0 Then
            enableContinue = False
        Else
            If ddlNoodle.Enabled = True Then
                If ddlNoodle.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
            If ddlRice.Enabled = True Then
                If ddlRice.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
            If ddlOther.Enabled = True Then
                If ddlOther.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
            If ddlToppings.Enabled = True Then
                If ddlToppings.SelectedIndex = 0 Then
                    enableContinue = False
                End If
            End If
        End If
        If enableContinue = True Then
            btnContinue.Enabled = True
        Else
            btnContinue.Enabled = False
        End If
    End Sub

    'When checked, this checkbox is disabled along with the continue button. However, the
    'drop down list relating to this checkbox is enabled.
    Protected Sub cbxNoodle_CheckedChanged(sender As Object, e As EventArgs) Handles cbxNoodle.CheckedChanged
        If cbxNoodle.Checked = True Then
            cbxNoodle.Enabled = False
            ddlNoodle.Enabled = True
            btnContinue.Enabled = False
        End If
    End Sub

    'Follows the same logic as the above method.
    Protected Sub cbxRice_CheckedChanged(sender As Object, e As EventArgs) Handles cbxRice.CheckedChanged
        If cbxRice.Checked = True Then
            cbxRice.Enabled = False
            ddlRice.Enabled = True
            btnContinue.Enabled = False
        End If
    End Sub

    'Follows the same logic as the above method.
    Protected Sub cbxOther_CheckedChanged(sender As Object, e As EventArgs) Handles cbxOther.CheckedChanged
        If cbxOther.Checked = True Then
            cbxOther.Enabled = False
            ddlOther.Enabled = True
            btnContinue.Enabled = False
        End If
    End Sub

    'Follows the same logic as the above method.
    Protected Sub cbxToppings_CheckedChanged(sender As Object, e As EventArgs) Handles cbxToppings.CheckedChanged
        If cbxToppings.Checked = True Then
            cbxToppings.Enabled = False
            ddlToppings.Enabled = True
            btnContinue.Enabled = False
        End If
    End Sub

    'Follows the same logic as the above method.
    Protected Sub cbxTea_CheckedChanged(sender As Object, e As EventArgs) Handles cbxTea.CheckedChanged
        If cbxTea.Checked = True Then
            cbxTea.Enabled = False
            ddlTea.Enabled = True
            btnContinue.Enabled = False
        End If
    End Sub

    'Resets everything to the page's original state.
    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbxNoodle.Enabled = True
        cbxRice.Enabled = True
        cbxOther.Enabled = True
        cbxToppings.Enabled = True
        cbxTea.Enabled = True

        cbxNoodle.Checked = False
        cbxRice.Checked = False
        cbxOther.Checked = False
        cbxToppings.Checked = False
        cbxTea.Checked = False

        ddlNoodle.SelectedIndex = 0
        ddlRice.SelectedIndex = 0
        ddlOther.SelectedIndex = 0
        ddlToppings.SelectedIndex = 0
        ddlTea.SelectedIndex = 0

        ddlNoodle.Enabled = False
        ddlRice.Enabled = False
        ddlOther.Enabled = False
        ddlToppings.Enabled = False
        ddlTea.Enabled = False

        btnContinue.Enabled = False
    End Sub

    'When clicked, saves the appropiate data to a global variable and then
    'opens the next page.
    Protected Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If ddlNoodle.SelectedIndex = 1 Then
            intRamenNumber += 1
        ElseIf ddlNoodle.SelectedIndex = 2 Then
            intUdonNumber += 1
        ElseIf ddlNoodle.SelectedIndex = 3 Then
            intSobaNumber += 1
        ElseIf ddlNoodle.SelectedIndex = 4 Then
            intShoyuNumber += 1
        ElseIf ddlNoodle.SelectedIndex = 5 Then
            intTonkotsuNumber += 1
        ElseIf ddlNoodle.SelectedIndex = 6 Then
            intTonkotsuShoyuNumber += 1
        End If

        If ddlRice.SelectedIndex = 1 Then
            intSmallRiceNumber += 1
        ElseIf ddlRice.SelectedIndex = 2 Then
            intRegularRiceNumber += 1
        ElseIf ddlRice.SelectedIndex = 3 Then
            intKimchiRiceNumber += 1
        End If

        If ddlOther.SelectedIndex = 1 Then
            intGyozaNumber += 1
        End If

        If ddlToppings.SelectedIndex = 1 Then
            intKaedamaNumber += 1
        ElseIf ddlToppings.SelectedIndex = 2 Then
            intChashuPorkNumber += 1
        ElseIf ddlToppings.SelectedIndex = 3 Then
            intNoriNumber += 1
        ElseIf ddlToppings.SelectedIndex = 4 Then
            intKimchiNumber += 1
        End If

        If ddlTea.SelectedIndex = 1 Then
            intOolongNumber += 1
        ElseIf ddlTea.SelectedIndex = 2 Then
            intGreenNumber += 1
        End If

        Response.Redirect("review.aspx")
    End Sub

End Class