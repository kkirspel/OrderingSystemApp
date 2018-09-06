'   Kevin Kirspel
'   3/29/2013
'   Noodle Shop Program 3

'   At the Review page, the user is shown what all they have selected to order 
'   so far. This includes each type of food, a quantity for each, and the total
'   price of that food type. The tax and sub total are defaultly shown, and after
'   a tip amount is selected, the tip and final total amounts are shown too.
'   The user can go back to the Menu page to order more, or they can check out with
'   what is currently displayed.
'   They can also clear the entire order from here.


Public Class Review1
    Inherits System.Web.UI.Page

    Dim decQuantityPrice As Decimal = 0
    Dim decSubTotal As Decimal = 0
    Dim decTax As Decimal = 0
    Dim decTip As Decimal = 0
    Dim decFinalTotal As Decimal = 0

    'If any item had been selected in the previous page within the current
    'customer order, it's name is loaded into a list box, the quantity into
    'the next list box, and then the total price of however many of this item
    'is loaded into the last list box.
    'Suntotal and tax are calculated and displayed, as well as the customer
    'name and email from the first page.
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If intRamenNumber > 0 Then
            lbxItems.Items.Add("Miso Ramen")
            lbxQuantity.Items.Add(intRamenNumber)
            decQuantityPrice = intRamenNumber * 5.5
            decSubTotal += decQuantityPrice
            lbxPrice.Items.Add(FormatCurrency(decQuantityPrice, , , TriState.True, TriState.True))
        End If
        If intUdonNumber > 0 Then
            lbxItems.Items.Add("Kit Udon")
            lbxQuantity.Items.Add(intUdonNumber)
            decQuantityPrice = intUdonNumber * 6.25
            decSubTotal += decQuantityPrice
            lbxPrice.Items.Add(FormatCurrency(decQuantityPrice, , , TriState.True, TriState.True))
        End If
        If intSobaNumber > 0 Then
            lbxItems.Items.Add("Zaru Soba")
            lbxQuantity.Items.Add(intSobaNumber)
            decQuantityPrice = intSobaNumber * 5.95
            decSubTotal += decQuantityPrice
            lbxPrice.Items.Add(FormatCurrency(decQuantityPrice, , , TriState.True, TriState.True))
        End If
        If intShoyuNumber > 0 Then
            lbxItems.Items.Add("Shoyu Ramen")
            lbxQuantity.Items.Add(intShoyuNumber)
            decQuantityPrice = intShoyuNumber * 6.95
            decSubTotal += decQuantityPrice
            lbxPrice.Items.Add(FormatCurrency(decQuantityPrice, , , TriState.True, TriState.True))
        End If
        If intTonkotsuNumber > 0 Then
            lbxItems.Items.Add("Tonkotsu Ramen")
            lbxQuantity.Items.Add(intTonkotsuNumber)
            decQuantityPrice = intTonkotsuNumber * 6.95
            decSubTotal += decQuantityPrice
            lbxPrice.Items.Add(FormatCurrency(decQuantityPrice, , , TriState.True, TriState.True))
        End If
        If intTonkotsuShoyuNumber > 0 Then
            lbxItems.Items.Add("Tonkotsu-Shoyu Ramen")
            lbxQuantity.Items.Add(intTonkotsuShoyuNumber)
            decQuantityPrice = intTonkotsuShoyuNumber * 6.95
            decSubTotal += decQuantityPrice
            lbxPrice.Items.Add(FormatCurrency(decQuantityPrice, , , TriState.True, TriState.True))
        End If

        If intSmallRiceNumber > 0 Then
            lbxItems.Items.Add("Fried Rice (small)")
            lbxQuantity.Items.Add(intSmallRiceNumber)
            decQuantityPrice = intSmallRiceNumber * 3.95
            decSubTotal += decQuantityPrice
            lbxPrice.Items.Add(FormatCurrency(decQuantityPrice, , , TriState.True, TriState.True))
        End If
        If intRegularRiceNumber > 0 Then
            lbxItems.Items.Add("Fried Rice (regular)")
            lbxQuantity.Items.Add(intRegularRiceNumber)
            decQuantityPrice = intRegularRiceNumber * 5.75
            decSubTotal += decQuantityPrice
            lbxPrice.Items.Add(FormatCurrency(decQuantityPrice, , , TriState.True, TriState.True))
        End If
        If intKimchiRiceNumber > 0 Then
            lbxItems.Items.Add("Kimchi Fried Rice")
            lbxQuantity.Items.Add(intKimchiRiceNumber)
            decQuantityPrice = intKimchiRiceNumber * 6.95
            decSubTotal += decQuantityPrice
            lbxPrice.Items.Add(FormatCurrency(decQuantityPrice, , , TriState.True, TriState.True))
        End If

        If intGyozaNumber > 0 Then
            lbxItems.Items.Add("Gyoza")
            lbxQuantity.Items.Add(intGyozaNumber)
            decQuantityPrice = intGyozaNumber * 5.15
            decSubTotal += decQuantityPrice
            lbxPrice.Items.Add(FormatCurrency(decQuantityPrice, , , TriState.True, TriState.True))
        End If

        If intKaedamaNumber > 0 Then
            lbxItems.Items.Add("Kaedama")
            lbxQuantity.Items.Add(intKaedamaNumber)
            decQuantityPrice = intKaedamaNumber * 1.5
            decSubTotal += decQuantityPrice
            lbxPrice.Items.Add(FormatCurrency(decQuantityPrice, , , TriState.True, TriState.True))
        End If
        If intChashuPorkNumber > 0 Then
            lbxItems.Items.Add("Chashu Pork")
            lbxQuantity.Items.Add(intChashuPorkNumber)
            decQuantityPrice = intChashuPorkNumber * 2.5
            decSubTotal += decQuantityPrice
            lbxPrice.Items.Add(FormatCurrency(decQuantityPrice, , , TriState.True, TriState.True))
        End If
        If intNoriNumber > 0 Then
            lbxItems.Items.Add("Nori")
            lbxQuantity.Items.Add(intNoriNumber)
            decQuantityPrice = intNoriNumber * 0.75
            decSubTotal += decQuantityPrice
            lbxPrice.Items.Add(FormatCurrency(decQuantityPrice, , , TriState.True, TriState.True))
        End If
        If intKimchiNumber > 0 Then
            lbxItems.Items.Add("Kimchi")
            lbxQuantity.Items.Add(intKimchiNumber)
            decQuantityPrice = intKimchiNumber * 1.0
            decSubTotal += decQuantityPrice
            lbxPrice.Items.Add(FormatCurrency(decQuantityPrice, , , TriState.True, TriState.True))
        End If

        If intOolongNumber > 0 Then
            lbxItems.Items.Add("Hot Oolong Tea")
            lbxQuantity.Items.Add(intOolongNumber)
            decQuantityPrice = intOolongNumber * 1.25
            decSubTotal += decQuantityPrice
            lbxPrice.Items.Add(FormatCurrency(decQuantityPrice, , , TriState.True, TriState.True))
        End If
        If intGreenNumber > 0 Then
            lbxItems.Items.Add("Hot Green Tea")
            lbxQuantity.Items.Add(intGreenNumber)
            decQuantityPrice = intGreenNumber * 1.25
            decSubTotal += decQuantityPrice
            lbxPrice.Items.Add(FormatCurrency(decQuantityPrice, , , TriState.True, TriState.True))
        End If

        lblSubtotal.Text = FormatCurrency(decSubTotal, , , TriState.True, TriState.True)
        decTax = decSubTotal * 0.07
        lblTax.Text = FormatCurrency(decTax, , , TriState.True, TriState.True)
        lblCustomer.Text = strFirstName + " " + strLastName
        lblCustomerEmail.Text = strEmail
    End Sub

    'Once a tip percentage is picked from the appropriate drop-down list, the
    'tip and final cost are calculated ad displayed.
    'The Checkout button is then enabled.
    Protected Sub ddlTip_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlTip.SelectedIndexChanged
        If ddlTip.SelectedIndex > 0 Then
            decTip = ddlTip.SelectedValue * decSubTotal
            lblTipAmount.Text = "(" + FormatCurrency(decTip, , , TriState.True, TriState.True) + ")"
            decFinalTotal = decTip + decTax + decSubTotal
            lblTotalCost.Text = FormatCurrency(decFinalTotal, , , TriState.True, TriState.True)
            btnCheckout.Enabled = True
        Else
            btnCheckout.Enabled = False
        End If
    End Sub

    'Reloads the last page, Menu, so that additional items can be ordered.
    Protected Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Response.Redirect("menu.aspx")
    End Sub

    'Resets all global variables and returns to the Home page. 
    'Basically finishes the current transaction and starts a new one.
    Protected Sub btnBack0_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        intRamenNumber = 0
        intUdonNumber = 0
        intSobaNumber = 0
        intShoyuNumber = 0
        intTonkotsuNumber = 0
        intTonkotsuShoyuNumber = 0
        intSmallRiceNumber = 0
        intRegularRiceNumber = 0
        intKimchiRiceNumber = 0
        intGyozaNumber = 0
        intKaedamaNumber = 0
        intChashuPorkNumber = 0
        intNoriNumber = 0
        intKimchiNumber = 0
        intOolongNumber = 0
        intGreenNumber = 0
        MsgBox("You have completed your order.")
        Response.Redirect("home.aspx")
    End Sub

    'Resets all global variables, as well as resetting the current page.
    'Basically clears the current transaction completely, except for customer
    'info from the first page, without closing the transaction.
    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        intRamenNumber = 0
        intUdonNumber = 0
        intSobaNumber = 0
        intShoyuNumber = 0
        intTonkotsuNumber = 0
        intTonkotsuShoyuNumber = 0
        intSmallRiceNumber = 0
        intRegularRiceNumber = 0
        intKimchiRiceNumber = 0
        intGyozaNumber = 0
        intKaedamaNumber = 0
        intChashuPorkNumber = 0
        intNoriNumber = 0
        intKimchiNumber = 0
        intOolongNumber = 0
        intGreenNumber = 0

        decSubTotal = 0
        lbxItems.Items.Clear()
        lbxQuantity.Items.Clear()
        lbxPrice.Items.Clear()
        lblSubtotal.Text = ""
        lblTax.Text = ""
        lblTipAmount.Text = ""
        lblTotalCost.Text = ""
        ddlTip.SelectedIndex = 0
        btnCheckout.Enabled = False
    End Sub
End Class