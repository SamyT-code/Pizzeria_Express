'**********************************
'*Travail : Pizzeria Express
'*Programmeur : Samy Touabi
'*Date de conception : 6 juin 2020
'**********************************

Public Class frmPizzeriaPresto

    ' Déclarer les prix des unités des garnitures régulières
    Const decPrix_PEPPERONIS As Decimal = 0.15
    Const decPrix_OLIVES As Decimal = 0.15
    Const decPrix_CHAMPIGNONS As Decimal = 0.15
    Const decPrix_ONIONS As Decimal = 0.15

    ' Déclarer les prix des unités des garnitures spéciales
    Const decPrix_ANANAS As Decimal = 0.3
    Const decPrix_BACONS As Decimal = 0.3
    Const decPrix_ANCHOIS As Decimal = 0.3
    Const decPrix_POIVRONS As Decimal = 0.3

    Dim decPrix_POINTE As Decimal 'Déclarer la variable des prix des unités de pointes de pizza

    'Déclarer le prix des sauces
    Const decPrix_MAYONNAISE As Decimal = 0.25
    Const decPrix_KETSHUP As Decimal = 0.25
    Const decPrix_BBQ As Decimal = 0.5
    Const decPrix_SRIRACHA As Decimal = 0.5

    'Déclarer les prix des livraisons
    Const intLivraison_STANDARD As Integer = 5
    Const intLivraison_EXPRESS As Integer = 10
    Dim intCout_LIVRAISON As Integer

    Private Sub frmPizzeriaExpress_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Form de base de taille réduite qui cache la facture
        Width = 590
        Height = 470

        radStandard.Checked = True 'Set le radiobutton "Standard" a true par défaut
        btnQuitter.Enabled = False 'Empêcher à l'utilisateur de cliquer sur le bouton Quitter

        txtPourboire.Text = "0.00$" 'Pourboire de base : 0$

    End Sub
    Private Sub btnFacture_Click(sender As Object, e As EventArgs) Handles btnFacture.Click

        'Aggrandir le form pour montrer la facture
        Width = 840
        Height = 470

        Dim intNombre_POINTES As Integer 'Déclarer la variable du nombre de pointes

        If cboPointes.SelectedIndex >= 0 Then 'Déterminer le nombre de pointes

            'Afficher l’élément sélectionné et incrémenter cette valeur à la varaible Nombre_POINTES.
            lblPointes.Text = "Pointes (" & cboPointes.SelectedItem & ") :"
            intNombre_POINTES = Val(cboPointes.SelectedItem)

        Else

            'Afficher les caractères tapés et incrémenter cette valeur à la varaible Nombre_POINTES.
            lblPointes.Text = "Pointes (" & cboPointes.Text & ") :"
            intNombre_POINTES = Val(cboPointes.Text)

        End If


        'Saisir le nombre de garnitures dans les champs de saisie
        Dim intNombre_PEPPERONIS As Integer = Val(txtPepperonis.Text)
        Dim intNombre_OLIVES As Integer = Val(txtOlives.Text)
        Dim intNombre_CHAMPIGNONS As Integer = Val(txtChampignons.Text)
        Dim intNombre_ONIONS As Integer = Val(txtOnions.Text)

        'Saisir le nombre de garnitures dans les champs de saisie
        Dim intNombre_ANANAS As Integer = Val(txtAnanas.Text)
        Dim intNombre_BACONS As Integer = Val(txtBacons.Text)
        Dim intNombre_ANCHOIS As Integer = Val(txtAnchois.Text)
        Dim intNombre_POIVRONS As Integer = Val(txtPoivrons.Text)

        'Montrer le nombre de chaque garniture dans les labels
        lblPepperonis.Text = "Pepperonis (" & intNombre_PEPPERONIS & ") :"
        lblOlives.Text = "Olives (" & intNombre_OLIVES & ") :"
        lblChampignons.Text = "Champignons (" & intNombre_CHAMPIGNONS & ") :"
        lblOnions.Text = "Onions (" & intNombre_ONIONS & ") :"

        'Montrer le nombre de chaque garniture dans les labels
        lblAnanas.Text = "Ananas (" & intNombre_ANANAS & ") :"
        lblBacon.Text = "Bacons (" & intNombre_BACONS & ") :"
        lblAnchois.Text = "Anchois (" & intNombre_ANCHOIS & ") :"
        lblPoivrons.Text = "Poivrons (" & intNombre_POIVRONS & ") :"

        If intNombre_POINTES >= 6 Then 'Donner un rabais au prix de chaque pointe s'il y en a 6 ou plus
            decPrix_POINTE = 0.8
        Else
            decPrix_POINTE = 1
        End If

        'Déclarer les variables des coûts et incrémenter une valeur
        Dim decCout_POINTES As Decimal = decPrix_POINTE * intNombre_POINTES

        'Déclarer les variables des coûts et incrémenter une valeur
        Dim decCout_PEPPERONIS As Decimal = decPrix_PEPPERONIS * intNombre_PEPPERONIS
        Dim decCout_OLIVES As Decimal = decPrix_OLIVES * intNombre_OLIVES
        Dim decCout_CHAMPIGNONS As Decimal = decPrix_CHAMPIGNONS * intNombre_CHAMPIGNONS
        Dim decCout_ONIONS As Decimal = decPrix_ONIONS * intNombre_ONIONS

        'Déclarer les variables des coûts et incrémenter une valeur
        Dim decCout_ANANAS As Decimal = decPrix_ANANAS * intNombre_ANANAS
        Dim decCout_BACONS As Decimal = decPrix_BACONS * intNombre_BACONS
        Dim decCout_ANCHOIS As Decimal = decPrix_ANCHOIS * intNombre_ANCHOIS
        Dim decCout_POIVRONS As Decimal = decPrix_POIVRONS * intNombre_POIVRONS

        'Changer la valeur des labels de prix
        lblPrixPointes.Text = FormatCurrency(decCout_POINTES)

        'Changer la valeur des labels de prix
        lblPrixPepperonis.Text = FormatCurrency(decCout_PEPPERONIS)
        lblPrixOlives.Text = FormatCurrency(decCout_OLIVES)
        lblPrixChampignons.Text = FormatCurrency(decCout_CHAMPIGNONS)
        lblPrixOnions.Text = FormatCurrency(decCout_ONIONS)

        'Changer la valeur des labels de prix
        lblPrixAnanas.Text = FormatCurrency(decCout_ANANAS)
        lblPrixBacon.Text = FormatCurrency(decCout_BACONS)
        lblPrixAnchois.Text = FormatCurrency(decCout_ANCHOIS)
        lblPrixPoivrons.Text = FormatCurrency(decCout_POIVRONS)

        'Déclarer les variables des coûts des sauces
        Dim decCout_MAYONNAISE As Decimal
        Dim decCout_KETSHUP As Decimal
        Dim decCout_BBQ As Decimal
        Dim decCout_SRIRACHA As Decimal

        If chkMayonnaise.Checked Then 'Sauce mayonnaise: oui ou non
            lblMayonnaise.Text = "Mayonnaise (oui)"
            decCout_MAYONNAISE = decPrix_MAYONNAISE
            lblPrixMayonnaise.Text = FormatCurrency(decCout_MAYONNAISE)
        Else
            lblMayonnaise.Text = "Mayonnaise (non)"
            decCout_MAYONNAISE = 0
            lblPrixMayonnaise.Text = FormatCurrency(decCout_MAYONNAISE)
        End If

        If chkKetshup.Checked Then 'Sauce ketshup: oui ou non
            lblKetshup.Text = "Ketshup (oui)"
            decCout_KETSHUP = decPrix_KETSHUP
            lblPrixKetshup.Text = FormatCurrency(decCout_KETSHUP)
        Else
            lblKetshup.Text = "Ketshup (non)"
            decCout_KETSHUP = 0
            lblPrixKetshup.Text = FormatCurrency(decCout_KETSHUP)
        End If

        If chkBBQ.Checked Then 'Sauce BBQ: oui ou non
            lblBBQ.Text = "Sauce BBQ (oui)"
            decCout_BBQ = decPrix_BBQ
            lblPrixBBQ.Text = FormatCurrency(decCout_BBQ)
        Else
            lblBBQ.Text = "Sauce BBQ (non)"
            decCout_BBQ = 0
            lblPrixBBQ.Text = FormatCurrency(decCout_BBQ)
        End If

        If chkSriracha.Checked Then 'Sauce sriracha : oui ou non
            lblSriracha.Text = "Sriracha (oui)"
            decCout_SRIRACHA = decPrix_SRIRACHA
            lblPrixSriracha.Text = FormatCurrency(decCout_SRIRACHA)
        Else
            lblSriracha.Text = "Sriracha (non)"
            decCout_SRIRACHA = 0
            lblPrixSriracha.Text = FormatCurrency(decCout_SRIRACHA)
        End If


        Dim decPourboire As Decimal = Val(txtPourboire.Text) 'Déterminer le pourboire
        lblPrixPourboire.Text = FormatCurrency(decPourboire)

        If decPourboire > 0 Then 'Déterminer si l'utilisateur a donné un pourboire
            lblPourboire.Text = "Pourboire (oui) :"
            txtPourboire.ForeColor = Color.Green 'Couleur verte s'il y a un pourboire
        Else
            lblPourboire.Text = "Pourboire (non) :"
            txtPourboire.ForeColor = Color.Red 'Couleur rouge s'il n'y a pas de pourboire
        End If

        'Déclarer les variables de sous-total, taxes, et total
        Dim decSoustotal As Decimal
        Dim decTaxes As Decimal
        Dim decTotal As Decimal

        'Calculer le sous-total
        decSoustotal = decCout_ANANAS + decCout_ANCHOIS + decCout_BACONS + decCout_BBQ + decCout_CHAMPIGNONS + decCout_KETSHUP _
            + intCout_LIVRAISON + decCout_MAYONNAISE + decCout_OLIVES + decCout_ONIONS + decCout_PEPPERONIS + decCout_POINTES _
            + decCout_POIVRONS + decCout_SRIRACHA + decPourboire
        'Le coût de livraison est déterminé plus bas dans le code

        lblPrixSousTotal.Text = FormatCurrency(decSoustotal) 'Coût sous-total

        decTaxes = decSoustotal * 0.13 'Coût des taxes
        lblPrixTaxes.Text = FormatCurrency(decTaxes)

        decTotal = decSoustotal * 1.13 'Coût total
        lblPrixTotal.Text = FormatCurrency(decTotal)

        'Empêcher à l'utilisateur de changer de méthode de livraison s'il clique sur le bouton facture
        radStandard.Enabled = False
        radExpress.Enabled = False

        'Empêcher à l'utilisateur de changer de données dans les champs de saisie s'il clique sur le bouton
        txtAnanas.Enabled = False
        txtAnchois.Enabled = False
        txtBacons.Enabled = False
        txtChampignons.Enabled = False
        txtOlives.Enabled = False
        txtOnions.Enabled = False
        txtPepperonis.Enabled = False
        txtPoivrons.Enabled = False
        txtPourboire.Enabled = False

        cboPointes.Enabled = False 'Empêche à  l'utilisateur de changer le nombre de pointes

        'Empêche l'utilisateur de changer les checkbox
        chkBBQ.Enabled = False
        chkKetshup.Enabled = False
        chkMayonnaise.Enabled = False
        chkSriracha.Enabled = False

        btnFacture.Enabled = False 'Empêcher à l'utilisateur de recliquer sur le bouton Facture
        btnQuitter.Enabled = True 'Permettre à l'utilisateur de cliquer sur le bouton Quitter


    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click

        'Réduire le form pour cacher la facture
        Width = 590
        Height = 470

        radStandard.Enabled = True 'Permet à l'utilisateur de changer de forme de livraison
        radExpress.Enabled = True 'Permet à l'utilisateur de changer de forme de livraison

        'Permettre à l'utilisateur de changer de données dans les champs de saisie s'il clique sur le bouton
        txtAnanas.Enabled = True
        txtAnchois.Enabled = True
        txtBacons.Enabled = True
        txtChampignons.Enabled = True
        txtOlives.Enabled = True
        txtOnions.Enabled = True
        txtPepperonis.Enabled = True
        txtPoivrons.Enabled = True
        txtPourboire.Enabled = True


        cboPointes.Enabled = True 'Permet à  l'utilisateur de changer le nombre de pointes

        'Permet l'utilisateur de changer les checkbox
        chkBBQ.Enabled = True
        chkKetshup.Enabled = True
        chkMayonnaise.Enabled = True
        chkSriracha.Enabled = True

        btnQuitter.Enabled = False 'Empêcher à l'utilisateur de cliquer sur le bouton Quitter
        btnFacture.Enabled = True 'Permettre à l'utilisateur de cliquer sur le bouton Facture

    End Sub

    Private Sub txtPourboire_Click(sender As Object, e As EventArgs) Handles txtPourboire.Click

        txtPourboire.Text = "" & "$"

        Call Pourboire() 'Appeler le sub pourboire (en bas du code)

    End Sub

    Private Sub txtPourboire_TextChanged(sender As Object, e As EventArgs) Handles txtPourboire.TextChanged

        Call Pourboire() 'Appeler le sub pourboire (en bas du code)

    End Sub

    Private Sub radStandard_CheckedChanged(sender As Object, e As EventArgs) Handles radStandard.CheckedChanged

        lblLivraison.Text = "Livraison (standard) :" 'Changer la valeur de la label de livraison
        intCout_LIVRAISON = intLivraison_STANDARD
        lblPrixLivraison.Text = FormatCurrency(intCout_LIVRAISON) 'Coût = 5$

    End Sub

    Private Sub radExpress_CheckedChanged(sender As Object, e As EventArgs) Handles radExpress.CheckedChanged

        lblLivraison.Text = "Livraison (express) :" 'Changer la valeur de la label de livraison
        intCout_LIVRAISON = intLivraison_EXPRESS
        lblPrixLivraison.Text = FormatCurrency(intCout_LIVRAISON) 'Coût = 10$

    End Sub

    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click

        'Révèle le fonctionnement de l'application
        MessageBox.Show("Bonjour et bienvenue à l'application Pizzeria Presto, fière de vous sevir lors du confinement. Choisissez le nombre de garnitures sur chaque pointes et vos sauces ainsi que le nombre de pointes de pizzas (1$ chacune) désirés avant de passer à la caisse. Si vous achetez 6 pointes ou plus, le prix de chaque pointe diminue à 80¢.")

    End Sub

    Private Sub btnCoutRegulier_Click(sender As Object, e As EventArgs) Handles btnCoutRegulier.Click

        'Révèle le coût des garnitures régulières
        MessageBox.Show("Chaque unité de garniture régulière vous côute 15¢") ' 15¢ par garniture

    End Sub

    Private Sub btnCoutSpecial_Click(sender As Object, e As EventArgs) Handles btnCoutSpecial.Click

        'Révèle le coût des garnitures régulières
        MessageBox.Show("Chaque unité de garniture spéciale vous côute 30¢") ' 30¢ par garniture

    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click

        MessageBox.Show("Bon appétit!") 'Montrer le message juste avant de quitter
        End 'Quitter l'application

    End Sub

    Sub Pourboire()

        Dim decPourboire As Decimal = Val(txtPourboire.Text) 'Déterminer le pourboire
        lblPrixPourboire.Text = FormatCurrency(decPourboire)

        If decPourboire > 0 Then 'Déterminer si l'utilisateur a donné un pourboire
            lblPourboire.Text = "Pourboire (oui) :"
            txtPourboire.ForeColor = Color.Green 'Couleur verte s'il y a un pourboire
        Else
            lblPourboire.Text = "Pourboire (non) :"
            txtPourboire.ForeColor = Color.Red 'Couleur rouge s'il n'y a pas de pourboire
        End If

    End Sub

End Class
