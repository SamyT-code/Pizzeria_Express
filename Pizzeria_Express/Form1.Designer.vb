<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizzeriaPresto
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.grpRegulieres = New System.Windows.Forms.GroupBox()
        Me.txtOnions = New System.Windows.Forms.TextBox()
        Me.txtChampignons = New System.Windows.Forms.TextBox()
        Me.txtOlives = New System.Windows.Forms.TextBox()
        Me.txtPepperonis = New System.Windows.Forms.TextBox()
        Me.lblInviteOnions = New System.Windows.Forms.Label()
        Me.lblInviteChampignons = New System.Windows.Forms.Label()
        Me.lblInviteOlives = New System.Windows.Forms.Label()
        Me.lblInvitePepperonis = New System.Windows.Forms.Label()
        Me.btnCoutRegulier = New System.Windows.Forms.Button()
        Me.grpSpeciales = New System.Windows.Forms.GroupBox()
        Me.txtPoivrons = New System.Windows.Forms.TextBox()
        Me.txtAnchois = New System.Windows.Forms.TextBox()
        Me.txtBacons = New System.Windows.Forms.TextBox()
        Me.txtAnanas = New System.Windows.Forms.TextBox()
        Me.lblInvitePoivrons = New System.Windows.Forms.Label()
        Me.lblInviteAnchois = New System.Windows.Forms.Label()
        Me.lblInviteBacon = New System.Windows.Forms.Label()
        Me.lblInviteAnanas = New System.Windows.Forms.Label()
        Me.btnCoutSpecial = New System.Windows.Forms.Button()
        Me.grpLivraison = New System.Windows.Forms.GroupBox()
        Me.radExpress = New System.Windows.Forms.RadioButton()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.btnFacture = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.picFacture = New System.Windows.Forms.PictureBox()
        Me.picPizza = New System.Windows.Forms.PictureBox()
        Me.lblPepperonis = New System.Windows.Forms.Label()
        Me.lblOlives = New System.Windows.Forms.Label()
        Me.lblChampignons = New System.Windows.Forms.Label()
        Me.lblOnions = New System.Windows.Forms.Label()
        Me.lblAnanas = New System.Windows.Forms.Label()
        Me.lblBacon = New System.Windows.Forms.Label()
        Me.lblAnchois = New System.Windows.Forms.Label()
        Me.lblPoivrons = New System.Windows.Forms.Label()
        Me.lblLivraison = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblTaxes = New System.Windows.Forms.Label()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.lblSousTotal = New System.Windows.Forms.Label()
        Me.lblPrixPepperonis = New System.Windows.Forms.Label()
        Me.lblPrixOlives = New System.Windows.Forms.Label()
        Me.lblPrixChampignons = New System.Windows.Forms.Label()
        Me.lblPrixOnions = New System.Windows.Forms.Label()
        Me.lblPrixAnanas = New System.Windows.Forms.Label()
        Me.lblPrixBacon = New System.Windows.Forms.Label()
        Me.lblPrixAnchois = New System.Windows.Forms.Label()
        Me.lblPrixPoivrons = New System.Windows.Forms.Label()
        Me.lblPrixLivraison = New System.Windows.Forms.Label()
        Me.lblPrixSousTotal = New System.Windows.Forms.Label()
        Me.lblPrixTaxes = New System.Windows.Forms.Label()
        Me.lblPrixTotal = New System.Windows.Forms.Label()
        Me.lblFacture = New System.Windows.Forms.Label()
        Me.lblInvitePointes = New System.Windows.Forms.Label()
        Me.cboPointes = New System.Windows.Forms.ComboBox()
        Me.lblPointes = New System.Windows.Forms.Label()
        Me.lblPrixPointes = New System.Windows.Forms.Label()
        Me.chkMayonnaise = New System.Windows.Forms.CheckBox()
        Me.chkKetshup = New System.Windows.Forms.CheckBox()
        Me.chkBBQ = New System.Windows.Forms.CheckBox()
        Me.chkSriracha = New System.Windows.Forms.CheckBox()
        Me.lblInviteSauce = New System.Windows.Forms.Label()
        Me.lblMayonnaise = New System.Windows.Forms.Label()
        Me.lblKetshup = New System.Windows.Forms.Label()
        Me.lblBBQ = New System.Windows.Forms.Label()
        Me.lblSriracha = New System.Windows.Forms.Label()
        Me.lblPrixMayonnaise = New System.Windows.Forms.Label()
        Me.lblPrixKetshup = New System.Windows.Forms.Label()
        Me.lblPrixBBQ = New System.Windows.Forms.Label()
        Me.lblPrixSriracha = New System.Windows.Forms.Label()
        Me.lblBonDeCommande = New System.Windows.Forms.Label()
        Me.lblInvitePourboire = New System.Windows.Forms.Label()
        Me.txtPourboire = New System.Windows.Forms.TextBox()
        Me.lblPourboire = New System.Windows.Forms.Label()
        Me.lblPrixPourboire = New System.Windows.Forms.Label()
        Me.grpRegulieres.SuspendLayout()
        Me.grpSpeciales.SuspendLayout()
        Me.grpLivraison.SuspendLayout()
        CType(Me.picFacture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInstructions
        '
        Me.btnInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructions.Location = New System.Drawing.Point(604, 37)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(130, 34)
        Me.btnInstructions.TabIndex = 0
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'grpRegulieres
        '
        Me.grpRegulieres.Controls.Add(Me.txtOnions)
        Me.grpRegulieres.Controls.Add(Me.txtChampignons)
        Me.grpRegulieres.Controls.Add(Me.txtOlives)
        Me.grpRegulieres.Controls.Add(Me.txtPepperonis)
        Me.grpRegulieres.Controls.Add(Me.lblInviteOnions)
        Me.grpRegulieres.Controls.Add(Me.lblInviteChampignons)
        Me.grpRegulieres.Controls.Add(Me.lblInviteOlives)
        Me.grpRegulieres.Controls.Add(Me.lblInvitePepperonis)
        Me.grpRegulieres.Controls.Add(Me.btnCoutRegulier)
        Me.grpRegulieres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRegulieres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpRegulieres.Location = New System.Drawing.Point(248, 86)
        Me.grpRegulieres.Name = "grpRegulieres"
        Me.grpRegulieres.Size = New System.Drawing.Size(216, 237)
        Me.grpRegulieres.TabIndex = 2
        Me.grpRegulieres.TabStop = False
        Me.grpRegulieres.Text = "Garnitures régulières"
        '
        'txtOnions
        '
        Me.txtOnions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOnions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOnions.Location = New System.Drawing.Point(136, 175)
        Me.txtOnions.Name = "txtOnions"
        Me.txtOnions.Size = New System.Drawing.Size(50, 27)
        Me.txtOnions.TabIndex = 8
        Me.txtOnions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtChampignons
        '
        Me.txtChampignons.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChampignons.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtChampignons.Location = New System.Drawing.Point(136, 140)
        Me.txtChampignons.Name = "txtChampignons"
        Me.txtChampignons.Size = New System.Drawing.Size(50, 27)
        Me.txtChampignons.TabIndex = 7
        Me.txtChampignons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOlives
        '
        Me.txtOlives.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOlives.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOlives.Location = New System.Drawing.Point(136, 102)
        Me.txtOlives.Name = "txtOlives"
        Me.txtOlives.Size = New System.Drawing.Size(50, 27)
        Me.txtOlives.TabIndex = 6
        Me.txtOlives.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPepperonis
        '
        Me.txtPepperonis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPepperonis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPepperonis.Location = New System.Drawing.Point(136, 67)
        Me.txtPepperonis.Name = "txtPepperonis"
        Me.txtPepperonis.Size = New System.Drawing.Size(50, 27)
        Me.txtPepperonis.TabIndex = 5
        Me.txtPepperonis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblInviteOnions
        '
        Me.lblInviteOnions.AutoSize = True
        Me.lblInviteOnions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInviteOnions.ForeColor = System.Drawing.Color.Black
        Me.lblInviteOnions.Location = New System.Drawing.Point(6, 179)
        Me.lblInviteOnions.Name = "lblInviteOnions"
        Me.lblInviteOnions.Size = New System.Drawing.Size(64, 18)
        Me.lblInviteOnions.TabIndex = 4
        Me.lblInviteOnions.Text = "Onions :"
        '
        'lblInviteChampignons
        '
        Me.lblInviteChampignons.AutoSize = True
        Me.lblInviteChampignons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInviteChampignons.ForeColor = System.Drawing.Color.Black
        Me.lblInviteChampignons.Location = New System.Drawing.Point(6, 144)
        Me.lblInviteChampignons.Name = "lblInviteChampignons"
        Me.lblInviteChampignons.Size = New System.Drawing.Size(108, 18)
        Me.lblInviteChampignons.TabIndex = 3
        Me.lblInviteChampignons.Text = "Champignons :"
        '
        'lblInviteOlives
        '
        Me.lblInviteOlives.AutoSize = True
        Me.lblInviteOlives.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInviteOlives.ForeColor = System.Drawing.Color.Black
        Me.lblInviteOlives.Location = New System.Drawing.Point(6, 106)
        Me.lblInviteOlives.Name = "lblInviteOlives"
        Me.lblInviteOlives.Size = New System.Drawing.Size(57, 18)
        Me.lblInviteOlives.TabIndex = 2
        Me.lblInviteOlives.Text = "Olives :"
        '
        'lblInvitePepperonis
        '
        Me.lblInvitePepperonis.AutoSize = True
        Me.lblInvitePepperonis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvitePepperonis.ForeColor = System.Drawing.Color.Black
        Me.lblInvitePepperonis.Location = New System.Drawing.Point(6, 67)
        Me.lblInvitePepperonis.Name = "lblInvitePepperonis"
        Me.lblInvitePepperonis.Size = New System.Drawing.Size(91, 18)
        Me.lblInvitePepperonis.TabIndex = 1
        Me.lblInvitePepperonis.Text = "Pepperonis :"
        '
        'btnCoutRegulier
        '
        Me.btnCoutRegulier.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCoutRegulier.ForeColor = System.Drawing.Color.Black
        Me.btnCoutRegulier.Location = New System.Drawing.Point(6, 26)
        Me.btnCoutRegulier.Name = "btnCoutRegulier"
        Me.btnCoutRegulier.Size = New System.Drawing.Size(75, 23)
        Me.btnCoutRegulier.TabIndex = 0
        Me.btnCoutRegulier.Text = "Coût"
        Me.btnCoutRegulier.UseVisualStyleBackColor = True
        '
        'grpSpeciales
        '
        Me.grpSpeciales.Controls.Add(Me.txtPoivrons)
        Me.grpSpeciales.Controls.Add(Me.txtAnchois)
        Me.grpSpeciales.Controls.Add(Me.txtBacons)
        Me.grpSpeciales.Controls.Add(Me.txtAnanas)
        Me.grpSpeciales.Controls.Add(Me.lblInvitePoivrons)
        Me.grpSpeciales.Controls.Add(Me.lblInviteAnchois)
        Me.grpSpeciales.Controls.Add(Me.lblInviteBacon)
        Me.grpSpeciales.Controls.Add(Me.lblInviteAnanas)
        Me.grpSpeciales.Controls.Add(Me.btnCoutSpecial)
        Me.grpSpeciales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSpeciales.ForeColor = System.Drawing.Color.Fuchsia
        Me.grpSpeciales.Location = New System.Drawing.Point(518, 86)
        Me.grpSpeciales.Name = "grpSpeciales"
        Me.grpSpeciales.Size = New System.Drawing.Size(216, 237)
        Me.grpSpeciales.TabIndex = 3
        Me.grpSpeciales.TabStop = False
        Me.grpSpeciales.Text = "Garnitures spéciales"
        '
        'txtPoivrons
        '
        Me.txtPoivrons.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoivrons.ForeColor = System.Drawing.Color.Fuchsia
        Me.txtPoivrons.Location = New System.Drawing.Point(137, 179)
        Me.txtPoivrons.Name = "txtPoivrons"
        Me.txtPoivrons.Size = New System.Drawing.Size(50, 27)
        Me.txtPoivrons.TabIndex = 9
        Me.txtPoivrons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAnchois
        '
        Me.txtAnchois.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnchois.ForeColor = System.Drawing.Color.Fuchsia
        Me.txtAnchois.Location = New System.Drawing.Point(137, 138)
        Me.txtAnchois.Name = "txtAnchois"
        Me.txtAnchois.Size = New System.Drawing.Size(50, 27)
        Me.txtAnchois.TabIndex = 10
        Me.txtAnchois.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBacons
        '
        Me.txtBacons.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBacons.ForeColor = System.Drawing.Color.Fuchsia
        Me.txtBacons.Location = New System.Drawing.Point(137, 102)
        Me.txtBacons.Name = "txtBacons"
        Me.txtBacons.Size = New System.Drawing.Size(50, 27)
        Me.txtBacons.TabIndex = 11
        Me.txtBacons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAnanas
        '
        Me.txtAnanas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnanas.ForeColor = System.Drawing.Color.Fuchsia
        Me.txtAnanas.Location = New System.Drawing.Point(137, 66)
        Me.txtAnanas.Name = "txtAnanas"
        Me.txtAnanas.Size = New System.Drawing.Size(50, 27)
        Me.txtAnanas.TabIndex = 12
        Me.txtAnanas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblInvitePoivrons
        '
        Me.lblInvitePoivrons.AutoSize = True
        Me.lblInvitePoivrons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvitePoivrons.ForeColor = System.Drawing.Color.Black
        Me.lblInvitePoivrons.Location = New System.Drawing.Point(6, 179)
        Me.lblInvitePoivrons.Name = "lblInvitePoivrons"
        Me.lblInvitePoivrons.Size = New System.Drawing.Size(75, 18)
        Me.lblInvitePoivrons.TabIndex = 5
        Me.lblInvitePoivrons.Text = "Poivrons :"
        '
        'lblInviteAnchois
        '
        Me.lblInviteAnchois.AutoSize = True
        Me.lblInviteAnchois.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInviteAnchois.ForeColor = System.Drawing.Color.Black
        Me.lblInviteAnchois.Location = New System.Drawing.Point(6, 142)
        Me.lblInviteAnchois.Name = "lblInviteAnchois"
        Me.lblInviteAnchois.Size = New System.Drawing.Size(69, 18)
        Me.lblInviteAnchois.TabIndex = 4
        Me.lblInviteAnchois.Text = "Anchois :"
        '
        'lblInviteBacon
        '
        Me.lblInviteBacon.AutoSize = True
        Me.lblInviteBacon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInviteBacon.ForeColor = System.Drawing.Color.Black
        Me.lblInviteBacon.Location = New System.Drawing.Point(6, 102)
        Me.lblInviteBacon.Name = "lblInviteBacon"
        Me.lblInviteBacon.Size = New System.Drawing.Size(67, 18)
        Me.lblInviteBacon.TabIndex = 3
        Me.lblInviteBacon.Text = "Bacons :"
        '
        'lblInviteAnanas
        '
        Me.lblInviteAnanas.AutoSize = True
        Me.lblInviteAnanas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInviteAnanas.ForeColor = System.Drawing.Color.Black
        Me.lblInviteAnanas.Location = New System.Drawing.Point(6, 66)
        Me.lblInviteAnanas.Name = "lblInviteAnanas"
        Me.lblInviteAnanas.Size = New System.Drawing.Size(65, 18)
        Me.lblInviteAnanas.TabIndex = 2
        Me.lblInviteAnanas.Text = "Ananas :"
        '
        'btnCoutSpecial
        '
        Me.btnCoutSpecial.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCoutSpecial.ForeColor = System.Drawing.Color.Black
        Me.btnCoutSpecial.Location = New System.Drawing.Point(6, 26)
        Me.btnCoutSpecial.Name = "btnCoutSpecial"
        Me.btnCoutSpecial.Size = New System.Drawing.Size(75, 23)
        Me.btnCoutSpecial.TabIndex = 1
        Me.btnCoutSpecial.Text = "Coût"
        Me.btnCoutSpecial.UseVisualStyleBackColor = True
        '
        'grpLivraison
        '
        Me.grpLivraison.Controls.Add(Me.radExpress)
        Me.grpLivraison.Controls.Add(Me.radStandard)
        Me.grpLivraison.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLivraison.ForeColor = System.Drawing.Color.Green
        Me.grpLivraison.Location = New System.Drawing.Point(249, 354)
        Me.grpLivraison.Name = "grpLivraison"
        Me.grpLivraison.Size = New System.Drawing.Size(484, 73)
        Me.grpLivraison.TabIndex = 4
        Me.grpLivraison.TabStop = False
        Me.grpLivraison.Text = "Méthode de livraison"
        '
        'radExpress
        '
        Me.radExpress.AutoSize = True
        Me.radExpress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radExpress.ForeColor = System.Drawing.Color.Black
        Me.radExpress.Location = New System.Drawing.Point(250, 27)
        Me.radExpress.Name = "radExpress"
        Me.radExpress.Size = New System.Drawing.Size(206, 24)
        Me.radExpress.TabIndex = 1
        Me.radExpress.Text = "Express (10 min - 10 $)"
        Me.radExpress.UseVisualStyleBackColor = True
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStandard.ForeColor = System.Drawing.Color.Black
        Me.radStandard.Location = New System.Drawing.Point(5, 27)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(203, 24)
        Me.radStandard.TabIndex = 0
        Me.radStandard.Text = "Standard (20 min - 5 $)"
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'btnFacture
        '
        Me.btnFacture.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacture.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFacture.Location = New System.Drawing.Point(499, 493)
        Me.btnFacture.Name = "btnFacture"
        Me.btnFacture.Size = New System.Drawing.Size(108, 32)
        Me.btnFacture.TabIndex = 5
        Me.btnFacture.Text = "Facture"
        Me.btnFacture.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitter.ForeColor = System.Drawing.Color.Red
        Me.btnQuitter.Location = New System.Drawing.Point(626, 493)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(108, 32)
        Me.btnQuitter.TabIndex = 6
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'picFacture
        '
        Me.picFacture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFacture.Image = Global.Meals_on_Wheels.My.Resources.Resources.facture
        Me.picFacture.Location = New System.Drawing.Point(979, 463)
        Me.picFacture.Name = "picFacture"
        Me.picFacture.Size = New System.Drawing.Size(101, 60)
        Me.picFacture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFacture.TabIndex = 7
        Me.picFacture.TabStop = False
        '
        'picPizza
        '
        Me.picPizza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPizza.Image = Global.Meals_on_Wheels.My.Resources.Resources.pizza2
        Me.picPizza.Location = New System.Drawing.Point(12, 86)
        Me.picPizza.Name = "picPizza"
        Me.picPizza.Size = New System.Drawing.Size(197, 244)
        Me.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPizza.TabIndex = 1
        Me.picPizza.TabStop = False
        '
        'lblPepperonis
        '
        Me.lblPepperonis.AutoSize = True
        Me.lblPepperonis.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPepperonis.Location = New System.Drawing.Point(781, 112)
        Me.lblPepperonis.Name = "lblPepperonis"
        Me.lblPepperonis.Size = New System.Drawing.Size(136, 16)
        Me.lblPepperonis.TabIndex = 8
        Me.lblPepperonis.Text = "Pepperonis (0) :"
        '
        'lblOlives
        '
        Me.lblOlives.AutoSize = True
        Me.lblOlives.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOlives.Location = New System.Drawing.Point(781, 139)
        Me.lblOlives.Name = "lblOlives"
        Me.lblOlives.Size = New System.Drawing.Size(104, 16)
        Me.lblOlives.TabIndex = 9
        Me.lblOlives.Text = "Olives (0) :"
        '
        'lblChampignons
        '
        Me.lblChampignons.AutoSize = True
        Me.lblChampignons.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChampignons.Location = New System.Drawing.Point(781, 165)
        Me.lblChampignons.Name = "lblChampignons"
        Me.lblChampignons.Size = New System.Drawing.Size(144, 16)
        Me.lblChampignons.TabIndex = 10
        Me.lblChampignons.Text = "Champignons (0) :"
        '
        'lblOnions
        '
        Me.lblOnions.AutoSize = True
        Me.lblOnions.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnions.Location = New System.Drawing.Point(781, 193)
        Me.lblOnions.Name = "lblOnions"
        Me.lblOnions.Size = New System.Drawing.Size(104, 16)
        Me.lblOnions.TabIndex = 11
        Me.lblOnions.Text = "Onions (0) :"
        '
        'lblAnanas
        '
        Me.lblAnanas.AutoSize = True
        Me.lblAnanas.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnanas.Location = New System.Drawing.Point(781, 219)
        Me.lblAnanas.Name = "lblAnanas"
        Me.lblAnanas.Size = New System.Drawing.Size(104, 16)
        Me.lblAnanas.TabIndex = 12
        Me.lblAnanas.Text = "Ananas (0) :"
        '
        'lblBacon
        '
        Me.lblBacon.AutoSize = True
        Me.lblBacon.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBacon.Location = New System.Drawing.Point(781, 245)
        Me.lblBacon.Name = "lblBacon"
        Me.lblBacon.Size = New System.Drawing.Size(96, 16)
        Me.lblBacon.TabIndex = 13
        Me.lblBacon.Text = "Bacon (0) :"
        '
        'lblAnchois
        '
        Me.lblAnchois.AutoSize = True
        Me.lblAnchois.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnchois.Location = New System.Drawing.Point(781, 271)
        Me.lblAnchois.Name = "lblAnchois"
        Me.lblAnchois.Size = New System.Drawing.Size(112, 16)
        Me.lblAnchois.TabIndex = 14
        Me.lblAnchois.Text = "Anchois (0) :"
        '
        'lblPoivrons
        '
        Me.lblPoivrons.AutoSize = True
        Me.lblPoivrons.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoivrons.Location = New System.Drawing.Point(781, 298)
        Me.lblPoivrons.Name = "lblPoivrons"
        Me.lblPoivrons.Size = New System.Drawing.Size(120, 16)
        Me.lblPoivrons.TabIndex = 15
        Me.lblPoivrons.Text = "Poivrons (0) :"
        '
        'lblLivraison
        '
        Me.lblLivraison.AutoSize = True
        Me.lblLivraison.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLivraison.Location = New System.Drawing.Point(781, 325)
        Me.lblLivraison.Name = "lblLivraison"
        Me.lblLivraison.Size = New System.Drawing.Size(184, 16)
        Me.lblLivraison.TabIndex = 16
        Me.lblLivraison.Text = "Livraison (standard) :"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.Red
        Me.lbltotal.Location = New System.Drawing.Point(780, 480)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(64, 16)
        Me.lbltotal.TabIndex = 17
        Me.lbltotal.Text = "Total :"
        '
        'lblTaxes
        '
        Me.lblTaxes.AutoSize = True
        Me.lblTaxes.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxes.Location = New System.Drawing.Point(780, 463)
        Me.lblTaxes.Name = "lblTaxes"
        Me.lblTaxes.Size = New System.Drawing.Size(64, 16)
        Me.lblTaxes.TabIndex = 19
        Me.lblTaxes.Text = "Taxes :"
        '
        'btnRetour
        '
        Me.btnRetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRetour.Location = New System.Drawing.Point(910, 33)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(140, 44)
        Me.btnRetour.TabIndex = 20
        Me.btnRetour.Text = "Retour au bon de commande"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'lblSousTotal
        '
        Me.lblSousTotal.AutoSize = True
        Me.lblSousTotal.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSousTotal.Location = New System.Drawing.Point(781, 441)
        Me.lblSousTotal.Name = "lblSousTotal"
        Me.lblSousTotal.Size = New System.Drawing.Size(104, 16)
        Me.lblSousTotal.TabIndex = 21
        Me.lblSousTotal.Text = "Sous total :"
        '
        'lblPrixPepperonis
        '
        Me.lblPrixPepperonis.AutoSize = True
        Me.lblPrixPepperonis.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixPepperonis.Location = New System.Drawing.Point(986, 112)
        Me.lblPrixPepperonis.Name = "lblPrixPepperonis"
        Me.lblPrixPepperonis.Size = New System.Drawing.Size(48, 16)
        Me.lblPrixPepperonis.TabIndex = 22
        Me.lblPrixPepperonis.Text = "$0.00"
        '
        'lblPrixOlives
        '
        Me.lblPrixOlives.AutoSize = True
        Me.lblPrixOlives.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixOlives.Location = New System.Drawing.Point(986, 139)
        Me.lblPrixOlives.Name = "lblPrixOlives"
        Me.lblPrixOlives.Size = New System.Drawing.Size(48, 16)
        Me.lblPrixOlives.TabIndex = 23
        Me.lblPrixOlives.Text = "$0.00"
        '
        'lblPrixChampignons
        '
        Me.lblPrixChampignons.AutoSize = True
        Me.lblPrixChampignons.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixChampignons.Location = New System.Drawing.Point(986, 165)
        Me.lblPrixChampignons.Name = "lblPrixChampignons"
        Me.lblPrixChampignons.Size = New System.Drawing.Size(48, 16)
        Me.lblPrixChampignons.TabIndex = 24
        Me.lblPrixChampignons.Text = "$0.00"
        '
        'lblPrixOnions
        '
        Me.lblPrixOnions.AutoSize = True
        Me.lblPrixOnions.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixOnions.Location = New System.Drawing.Point(986, 193)
        Me.lblPrixOnions.Name = "lblPrixOnions"
        Me.lblPrixOnions.Size = New System.Drawing.Size(48, 16)
        Me.lblPrixOnions.TabIndex = 25
        Me.lblPrixOnions.Text = "$0.00"
        '
        'lblPrixAnanas
        '
        Me.lblPrixAnanas.AutoSize = True
        Me.lblPrixAnanas.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixAnanas.Location = New System.Drawing.Point(986, 219)
        Me.lblPrixAnanas.Name = "lblPrixAnanas"
        Me.lblPrixAnanas.Size = New System.Drawing.Size(48, 16)
        Me.lblPrixAnanas.TabIndex = 26
        Me.lblPrixAnanas.Text = "$0.00"
        '
        'lblPrixBacon
        '
        Me.lblPrixBacon.AutoSize = True
        Me.lblPrixBacon.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixBacon.Location = New System.Drawing.Point(986, 245)
        Me.lblPrixBacon.Name = "lblPrixBacon"
        Me.lblPrixBacon.Size = New System.Drawing.Size(48, 16)
        Me.lblPrixBacon.TabIndex = 27
        Me.lblPrixBacon.Text = "$0.00"
        '
        'lblPrixAnchois
        '
        Me.lblPrixAnchois.AutoSize = True
        Me.lblPrixAnchois.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixAnchois.Location = New System.Drawing.Point(986, 271)
        Me.lblPrixAnchois.Name = "lblPrixAnchois"
        Me.lblPrixAnchois.Size = New System.Drawing.Size(48, 16)
        Me.lblPrixAnchois.TabIndex = 28
        Me.lblPrixAnchois.Text = "$0.00"
        '
        'lblPrixPoivrons
        '
        Me.lblPrixPoivrons.AutoSize = True
        Me.lblPrixPoivrons.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixPoivrons.Location = New System.Drawing.Point(986, 298)
        Me.lblPrixPoivrons.Name = "lblPrixPoivrons"
        Me.lblPrixPoivrons.Size = New System.Drawing.Size(48, 16)
        Me.lblPrixPoivrons.TabIndex = 29
        Me.lblPrixPoivrons.Text = "$0.00"
        '
        'lblPrixLivraison
        '
        Me.lblPrixLivraison.AutoSize = True
        Me.lblPrixLivraison.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixLivraison.Location = New System.Drawing.Point(986, 323)
        Me.lblPrixLivraison.Name = "lblPrixLivraison"
        Me.lblPrixLivraison.Size = New System.Drawing.Size(48, 16)
        Me.lblPrixLivraison.TabIndex = 30
        Me.lblPrixLivraison.Text = "$5.00"
        '
        'lblPrixSousTotal
        '
        Me.lblPrixSousTotal.AutoSize = True
        Me.lblPrixSousTotal.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixSousTotal.Location = New System.Drawing.Point(987, 441)
        Me.lblPrixSousTotal.Name = "lblPrixSousTotal"
        Me.lblPrixSousTotal.Size = New System.Drawing.Size(48, 16)
        Me.lblPrixSousTotal.TabIndex = 31
        Me.lblPrixSousTotal.Text = "$5.00"
        '
        'lblPrixTaxes
        '
        Me.lblPrixTaxes.AutoSize = True
        Me.lblPrixTaxes.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixTaxes.Location = New System.Drawing.Point(862, 463)
        Me.lblPrixTaxes.Name = "lblPrixTaxes"
        Me.lblPrixTaxes.Size = New System.Drawing.Size(48, 16)
        Me.lblPrixTaxes.TabIndex = 32
        Me.lblPrixTaxes.Text = "$0.65"
        '
        'lblPrixTotal
        '
        Me.lblPrixTotal.AutoSize = True
        Me.lblPrixTotal.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixTotal.ForeColor = System.Drawing.Color.Red
        Me.lblPrixTotal.Location = New System.Drawing.Point(862, 480)
        Me.lblPrixTotal.Name = "lblPrixTotal"
        Me.lblPrixTotal.Size = New System.Drawing.Size(48, 16)
        Me.lblPrixTotal.TabIndex = 33
        Me.lblPrixTotal.Text = "$5.65"
        '
        'lblFacture
        '
        Me.lblFacture.AutoSize = True
        Me.lblFacture.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacture.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFacture.Location = New System.Drawing.Point(776, 39)
        Me.lblFacture.Name = "lblFacture"
        Me.lblFacture.Size = New System.Drawing.Size(118, 32)
        Me.lblFacture.TabIndex = 34
        Me.lblFacture.Text = "Facture"
        '
        'lblInvitePointes
        '
        Me.lblInvitePointes.AutoSize = True
        Me.lblInvitePointes.Location = New System.Drawing.Point(12, 354)
        Me.lblInvitePointes.Name = "lblInvitePointes"
        Me.lblInvitePointes.Size = New System.Drawing.Size(120, 17)
        Me.lblInvitePointes.TabIndex = 35
        Me.lblInvitePointes.Text = "Pointes de pizza :"
        '
        'cboPointes
        '
        Me.cboPointes.FormattingEnabled = True
        Me.cboPointes.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cboPointes.Location = New System.Drawing.Point(138, 351)
        Me.cboPointes.Name = "cboPointes"
        Me.cboPointes.Size = New System.Drawing.Size(71, 24)
        Me.cboPointes.TabIndex = 36
        '
        'lblPointes
        '
        Me.lblPointes.AutoSize = True
        Me.lblPointes.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointes.Location = New System.Drawing.Point(781, 86)
        Me.lblPointes.Name = "lblPointes"
        Me.lblPointes.Size = New System.Drawing.Size(120, 16)
        Me.lblPointes.TabIndex = 37
        Me.lblPointes.Text = "Pointes (0) : "
        '
        'lblPrixPointes
        '
        Me.lblPrixPointes.AutoSize = True
        Me.lblPrixPointes.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixPointes.Location = New System.Drawing.Point(986, 86)
        Me.lblPrixPointes.Name = "lblPrixPointes"
        Me.lblPrixPointes.Size = New System.Drawing.Size(48, 16)
        Me.lblPrixPointes.TabIndex = 38
        Me.lblPrixPointes.Text = "$0.00"
        '
        'chkMayonnaise
        '
        Me.chkMayonnaise.AutoSize = True
        Me.chkMayonnaise.Location = New System.Drawing.Point(11, 409)
        Me.chkMayonnaise.Name = "chkMayonnaise"
        Me.chkMayonnaise.Size = New System.Drawing.Size(144, 21)
        Me.chkMayonnaise.TabIndex = 39
        Me.chkMayonnaise.Text = "Mayonnaise (25¢)"
        Me.chkMayonnaise.UseVisualStyleBackColor = True
        '
        'chkKetshup
        '
        Me.chkKetshup.AutoSize = True
        Me.chkKetshup.Location = New System.Drawing.Point(11, 436)
        Me.chkKetshup.Name = "chkKetshup"
        Me.chkKetshup.Size = New System.Drawing.Size(120, 21)
        Me.chkKetshup.TabIndex = 40
        Me.chkKetshup.Text = "Ketshup (25¢)"
        Me.chkKetshup.UseVisualStyleBackColor = True
        '
        'chkBBQ
        '
        Me.chkBBQ.AutoSize = True
        Me.chkBBQ.Location = New System.Drawing.Point(11, 463)
        Me.chkBBQ.Name = "chkBBQ"
        Me.chkBBQ.Size = New System.Drawing.Size(141, 21)
        Me.chkBBQ.TabIndex = 41
        Me.chkBBQ.Text = "Sauce BBQ (50¢)"
        Me.chkBBQ.UseVisualStyleBackColor = True
        '
        'chkSriracha
        '
        Me.chkSriracha.AutoSize = True
        Me.chkSriracha.Location = New System.Drawing.Point(11, 490)
        Me.chkSriracha.Name = "chkSriracha"
        Me.chkSriracha.Size = New System.Drawing.Size(121, 21)
        Me.chkSriracha.TabIndex = 42
        Me.chkSriracha.Text = "Sriracha (50¢)"
        Me.chkSriracha.UseVisualStyleBackColor = True
        '
        'lblInviteSauce
        '
        Me.lblInviteSauce.AutoSize = True
        Me.lblInviteSauce.ForeColor = System.Drawing.Color.Teal
        Me.lblInviteSauce.Location = New System.Drawing.Point(8, 381)
        Me.lblInviteSauce.Name = "lblInviteSauce"
        Me.lblInviteSauce.Size = New System.Drawing.Size(56, 17)
        Me.lblInviteSauce.TabIndex = 43
        Me.lblInviteSauce.Text = "Sauce :"
        '
        'lblMayonnaise
        '
        Me.lblMayonnaise.AutoSize = True
        Me.lblMayonnaise.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMayonnaise.Location = New System.Drawing.Point(780, 355)
        Me.lblMayonnaise.Name = "lblMayonnaise"
        Me.lblMayonnaise.Size = New System.Drawing.Size(152, 16)
        Me.lblMayonnaise.TabIndex = 44
        Me.lblMayonnaise.Text = "Mayonnaise (non) :"
        '
        'lblKetshup
        '
        Me.lblKetshup.AutoSize = True
        Me.lblKetshup.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKetshup.Location = New System.Drawing.Point(780, 371)
        Me.lblKetshup.Name = "lblKetshup"
        Me.lblKetshup.Size = New System.Drawing.Size(128, 16)
        Me.lblKetshup.TabIndex = 45
        Me.lblKetshup.Text = "Ketshup (non) :"
        '
        'lblBBQ
        '
        Me.lblBBQ.AutoSize = True
        Me.lblBBQ.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBBQ.Location = New System.Drawing.Point(780, 387)
        Me.lblBBQ.Name = "lblBBQ"
        Me.lblBBQ.Size = New System.Drawing.Size(144, 16)
        Me.lblBBQ.TabIndex = 46
        Me.lblBBQ.Text = "Sauce BBQ (non) :"
        '
        'lblSriracha
        '
        Me.lblSriracha.AutoSize = True
        Me.lblSriracha.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSriracha.Location = New System.Drawing.Point(780, 403)
        Me.lblSriracha.Name = "lblSriracha"
        Me.lblSriracha.Size = New System.Drawing.Size(136, 16)
        Me.lblSriracha.TabIndex = 47
        Me.lblSriracha.Text = "Sriracha (non) :"
        '
        'lblPrixMayonnaise
        '
        Me.lblPrixMayonnaise.AutoSize = True
        Me.lblPrixMayonnaise.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixMayonnaise.Location = New System.Drawing.Point(986, 355)
        Me.lblPrixMayonnaise.Name = "lblPrixMayonnaise"
        Me.lblPrixMayonnaise.Size = New System.Drawing.Size(48, 16)
        Me.lblPrixMayonnaise.TabIndex = 49
        Me.lblPrixMayonnaise.Text = "$0.00"
        '
        'lblPrixKetshup
        '
        Me.lblPrixKetshup.AutoSize = True
        Me.lblPrixKetshup.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixKetshup.Location = New System.Drawing.Point(986, 371)
        Me.lblPrixKetshup.Name = "lblPrixKetshup"
        Me.lblPrixKetshup.Size = New System.Drawing.Size(48, 16)
        Me.lblPrixKetshup.TabIndex = 50
        Me.lblPrixKetshup.Text = "$0.00"
        '
        'lblPrixBBQ
        '
        Me.lblPrixBBQ.AutoSize = True
        Me.lblPrixBBQ.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixBBQ.Location = New System.Drawing.Point(986, 387)
        Me.lblPrixBBQ.Name = "lblPrixBBQ"
        Me.lblPrixBBQ.Size = New System.Drawing.Size(48, 16)
        Me.lblPrixBBQ.TabIndex = 51
        Me.lblPrixBBQ.Text = "$0.00"
        '
        'lblPrixSriracha
        '
        Me.lblPrixSriracha.AutoSize = True
        Me.lblPrixSriracha.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixSriracha.Location = New System.Drawing.Point(986, 403)
        Me.lblPrixSriracha.Name = "lblPrixSriracha"
        Me.lblPrixSriracha.Size = New System.Drawing.Size(48, 16)
        Me.lblPrixSriracha.TabIndex = 52
        Me.lblPrixSriracha.Text = "$0.00"
        '
        'lblBonDeCommande
        '
        Me.lblBonDeCommande.AutoSize = True
        Me.lblBonDeCommande.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBonDeCommande.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBonDeCommande.Location = New System.Drawing.Point(243, 39)
        Me.lblBonDeCommande.Name = "lblBonDeCommande"
        Me.lblBonDeCommande.Size = New System.Drawing.Size(267, 32)
        Me.lblBonDeCommande.TabIndex = 53
        Me.lblBonDeCommande.Text = "Bon de commande"
        '
        'lblInvitePourboire
        '
        Me.lblInvitePourboire.AutoSize = True
        Me.lblInvitePourboire.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvitePourboire.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblInvitePourboire.Location = New System.Drawing.Point(243, 437)
        Me.lblInvitePourboire.Name = "lblInvitePourboire"
        Me.lblInvitePourboire.Size = New System.Drawing.Size(102, 20)
        Me.lblInvitePourboire.TabIndex = 54
        Me.lblInvitePourboire.Text = "Pourboire :"
        '
        'txtPourboire
        '
        Me.txtPourboire.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPourboire.ForeColor = System.Drawing.Color.Red
        Me.txtPourboire.Location = New System.Drawing.Point(360, 435)
        Me.txtPourboire.Name = "txtPourboire"
        Me.txtPourboire.Size = New System.Drawing.Size(59, 22)
        Me.txtPourboire.TabIndex = 55
        Me.txtPourboire.Text = "0.00$"
        Me.txtPourboire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPourboire
        '
        Me.lblPourboire.AutoSize = True
        Me.lblPourboire.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPourboire.Location = New System.Drawing.Point(781, 419)
        Me.lblPourboire.Name = "lblPourboire"
        Me.lblPourboire.Size = New System.Drawing.Size(144, 16)
        Me.lblPourboire.TabIndex = 56
        Me.lblPourboire.Text = "Pourboire (non) :"
        '
        'lblPrixPourboire
        '
        Me.lblPrixPourboire.AutoSize = True
        Me.lblPrixPourboire.Font = New System.Drawing.Font("Monospac821 BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixPourboire.Location = New System.Drawing.Point(987, 419)
        Me.lblPrixPourboire.Name = "lblPrixPourboire"
        Me.lblPrixPourboire.Size = New System.Drawing.Size(48, 16)
        Me.lblPrixPourboire.TabIndex = 57
        Me.lblPrixPourboire.Text = "$0.00"
        '
        'frmPizzeriaPresto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1092, 535)
        Me.Controls.Add(Me.lblPrixPourboire)
        Me.Controls.Add(Me.lblPourboire)
        Me.Controls.Add(Me.txtPourboire)
        Me.Controls.Add(Me.lblInvitePourboire)
        Me.Controls.Add(Me.lblBonDeCommande)
        Me.Controls.Add(Me.lblPrixSriracha)
        Me.Controls.Add(Me.lblPrixBBQ)
        Me.Controls.Add(Me.lblPrixKetshup)
        Me.Controls.Add(Me.lblPrixMayonnaise)
        Me.Controls.Add(Me.lblSriracha)
        Me.Controls.Add(Me.lblBBQ)
        Me.Controls.Add(Me.lblKetshup)
        Me.Controls.Add(Me.lblMayonnaise)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.lblInviteSauce)
        Me.Controls.Add(Me.chkSriracha)
        Me.Controls.Add(Me.chkBBQ)
        Me.Controls.Add(Me.chkKetshup)
        Me.Controls.Add(Me.chkMayonnaise)
        Me.Controls.Add(Me.lblPrixPointes)
        Me.Controls.Add(Me.lblPointes)
        Me.Controls.Add(Me.cboPointes)
        Me.Controls.Add(Me.lblInvitePointes)
        Me.Controls.Add(Me.lblFacture)
        Me.Controls.Add(Me.lblPrixTotal)
        Me.Controls.Add(Me.lblPrixTaxes)
        Me.Controls.Add(Me.lblPrixSousTotal)
        Me.Controls.Add(Me.lblPrixLivraison)
        Me.Controls.Add(Me.lblPrixPoivrons)
        Me.Controls.Add(Me.lblPrixAnchois)
        Me.Controls.Add(Me.lblPrixBacon)
        Me.Controls.Add(Me.lblPrixAnanas)
        Me.Controls.Add(Me.lblPrixOnions)
        Me.Controls.Add(Me.lblPrixChampignons)
        Me.Controls.Add(Me.lblPrixOlives)
        Me.Controls.Add(Me.lblPrixPepperonis)
        Me.Controls.Add(Me.lblSousTotal)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.lblTaxes)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblLivraison)
        Me.Controls.Add(Me.lblPoivrons)
        Me.Controls.Add(Me.lblAnchois)
        Me.Controls.Add(Me.lblBacon)
        Me.Controls.Add(Me.lblAnanas)
        Me.Controls.Add(Me.lblOnions)
        Me.Controls.Add(Me.lblChampignons)
        Me.Controls.Add(Me.lblOlives)
        Me.Controls.Add(Me.lblPepperonis)
        Me.Controls.Add(Me.picFacture)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnFacture)
        Me.Controls.Add(Me.grpLivraison)
        Me.Controls.Add(Me.grpSpeciales)
        Me.Controls.Add(Me.grpRegulieres)
        Me.Controls.Add(Me.picPizza)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPizzeriaPresto"
        Me.Text = "Pizzeria Presto!"
        Me.grpRegulieres.ResumeLayout(False)
        Me.grpRegulieres.PerformLayout()
        Me.grpSpeciales.ResumeLayout(False)
        Me.grpSpeciales.PerformLayout()
        Me.grpLivraison.ResumeLayout(False)
        Me.grpLivraison.PerformLayout()
        CType(Me.picFacture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInstructions As Button
    Friend WithEvents picPizza As PictureBox
    Friend WithEvents grpRegulieres As GroupBox
    Friend WithEvents btnCoutRegulier As Button
    Friend WithEvents grpSpeciales As GroupBox
    Friend WithEvents btnCoutSpecial As Button
    Friend WithEvents txtOnions As TextBox
    Friend WithEvents txtChampignons As TextBox
    Friend WithEvents txtOlives As TextBox
    Friend WithEvents txtPepperonis As TextBox
    Friend WithEvents lblInviteOnions As Label
    Friend WithEvents lblInviteChampignons As Label
    Friend WithEvents lblInviteOlives As Label
    Friend WithEvents lblInvitePepperonis As Label
    Friend WithEvents txtPoivrons As TextBox
    Friend WithEvents txtAnchois As TextBox
    Friend WithEvents txtBacons As TextBox
    Friend WithEvents txtAnanas As TextBox
    Friend WithEvents lblInvitePoivrons As Label
    Friend WithEvents lblInviteAnchois As Label
    Friend WithEvents lblInviteBacon As Label
    Friend WithEvents lblInviteAnanas As Label
    Friend WithEvents grpLivraison As GroupBox
    Friend WithEvents radExpress As RadioButton
    Friend WithEvents radStandard As RadioButton
    Friend WithEvents btnFacture As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents picFacture As PictureBox
    Friend WithEvents lblPepperonis As Label
    Friend WithEvents lblOlives As Label
    Friend WithEvents lblChampignons As Label
    Friend WithEvents lblOnions As Label
    Friend WithEvents lblAnanas As Label
    Friend WithEvents lblBacon As Label
    Friend WithEvents lblAnchois As Label
    Friend WithEvents lblPoivrons As Label
    Friend WithEvents lblLivraison As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblTaxes As Label
    Friend WithEvents btnRetour As Button
    Friend WithEvents lblSousTotal As Label
    Friend WithEvents lblPrixPepperonis As Label
    Friend WithEvents lblPrixOlives As Label
    Friend WithEvents lblPrixChampignons As Label
    Friend WithEvents lblPrixOnions As Label
    Friend WithEvents lblPrixAnanas As Label
    Friend WithEvents lblPrixBacon As Label
    Friend WithEvents lblPrixAnchois As Label
    Friend WithEvents lblPrixPoivrons As Label
    Friend WithEvents lblPrixLivraison As Label
    Friend WithEvents lblPrixSousTotal As Label
    Friend WithEvents lblPrixTaxes As Label
    Friend WithEvents lblPrixTotal As Label
    Friend WithEvents lblFacture As Label
    Friend WithEvents lblInvitePointes As Label
    Friend WithEvents cboPointes As ComboBox
    Friend WithEvents lblPointes As Label
    Friend WithEvents lblPrixPointes As Label
    Friend WithEvents chkMayonnaise As CheckBox
    Friend WithEvents chkKetshup As CheckBox
    Friend WithEvents chkBBQ As CheckBox
    Friend WithEvents chkSriracha As CheckBox
    Friend WithEvents lblInviteSauce As Label
    Friend WithEvents lblMayonnaise As Label
    Friend WithEvents lblKetshup As Label
    Friend WithEvents lblBBQ As Label
    Friend WithEvents lblSriracha As Label
    Friend WithEvents lblPrixMayonnaise As Label
    Friend WithEvents lblPrixKetshup As Label
    Friend WithEvents lblPrixBBQ As Label
    Friend WithEvents lblPrixSriracha As Label
    Friend WithEvents lblBonDeCommande As Label
    Friend WithEvents lblInvitePourboire As Label
    Friend WithEvents txtPourboire As TextBox
    Friend WithEvents lblPourboire As Label
    Friend WithEvents lblPrixPourboire As Label
End Class
