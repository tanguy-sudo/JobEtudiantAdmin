<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOff
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TBoff = New System.Windows.Forms.TextBox()
        Me.LabelOff = New System.Windows.Forms.Label()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.TBPrenom = New System.Windows.Forms.TextBox()
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.TBAdresse = New System.Windows.Forms.TextBox()
        Me.TBVille = New System.Windows.Forms.TextBox()
        Me.TBCP = New System.Windows.Forms.TextBox()
        Me.TBTel = New System.Windows.Forms.TextBox()
        Me.TBLogo = New System.Windows.Forms.TextBox()
        Me.TBMail = New System.Windows.Forms.TextBox()
        Me.TBMdp = New System.Windows.Forms.TextBox()
        Me.LabelNomOff = New System.Windows.Forms.Label()
        Me.LabelPrenomOff = New System.Windows.Forms.Label()
        Me.LabelCP = New System.Windows.Forms.Label()
        Me.LabelVille = New System.Windows.Forms.Label()
        Me.LabelAdresse = New System.Windows.Forms.Label()
        Me.LabelTel = New System.Windows.Forms.Label()
        Me.LabelLogo = New System.Windows.Forms.Label()
        Me.LabelCouriel = New System.Windows.Forms.Label()
        Me.LabelMdp = New System.Windows.Forms.Label()
        Me.LabelIdCivilite = New System.Windows.Forms.Label()
        Me.LabelSite = New System.Windows.Forms.Label()
        Me.LabelIdType = New System.Windows.Forms.Label()
        Me.LabelCivilite = New System.Windows.Forms.Label()
        Me.TBCivilite = New System.Windows.Forms.TextBox()
        Me.LabelType = New System.Windows.Forms.Label()
        Me.TBType = New System.Windows.Forms.TextBox()
        Me.CBIdType = New System.Windows.Forms.ComboBox()
        Me.CBIdCivilite = New System.Windows.Forms.ComboBox()
        Me.DGVOffreur = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnModif = New System.Windows.Forms.Button()
        Me.BtnSupp = New System.Windows.Forms.Button()
        Me.TBSite = New System.Windows.Forms.TextBox()
        CType(Me.DGVOffreur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBoff
        '
        Me.TBoff.Location = New System.Drawing.Point(14, 49)
        Me.TBoff.Name = "TBoff"
        Me.TBoff.Size = New System.Drawing.Size(173, 20)
        Me.TBoff.TabIndex = 1
        Me.TBoff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelOff
        '
        Me.LabelOff.AutoSize = True
        Me.LabelOff.Location = New System.Drawing.Point(12, 33)
        Me.LabelOff.Name = "LabelOff"
        Me.LabelOff.Size = New System.Drawing.Size(72, 12)
        Me.LabelOff.TabIndex = 2
        Me.LabelOff.Text = "Rechercher"
        '
        'TBNom
        '
        Me.TBNom.Location = New System.Drawing.Point(292, 49)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(164, 20)
        Me.TBNom.TabIndex = 3
        Me.TBNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBPrenom
        '
        Me.TBPrenom.Location = New System.Drawing.Point(292, 96)
        Me.TBPrenom.Name = "TBPrenom"
        Me.TBPrenom.Size = New System.Drawing.Size(164, 20)
        Me.TBPrenom.TabIndex = 4
        Me.TBPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBID
        '
        Me.TBID.Location = New System.Drawing.Point(485, 284)
        Me.TBID.Name = "TBID"
        Me.TBID.ReadOnly = True
        Me.TBID.Size = New System.Drawing.Size(164, 20)
        Me.TBID.TabIndex = 5
        Me.TBID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TBID.Visible = False
        '
        'TBAdresse
        '
        Me.TBAdresse.Location = New System.Drawing.Point(292, 143)
        Me.TBAdresse.Name = "TBAdresse"
        Me.TBAdresse.Size = New System.Drawing.Size(164, 20)
        Me.TBAdresse.TabIndex = 6
        Me.TBAdresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBVille
        '
        Me.TBVille.Location = New System.Drawing.Point(292, 189)
        Me.TBVille.Name = "TBVille"
        Me.TBVille.Size = New System.Drawing.Size(164, 20)
        Me.TBVille.TabIndex = 7
        Me.TBVille.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBCP
        '
        Me.TBCP.Location = New System.Drawing.Point(675, 143)
        Me.TBCP.MaxLength = 5
        Me.TBCP.Name = "TBCP"
        Me.TBCP.Size = New System.Drawing.Size(164, 20)
        Me.TBCP.TabIndex = 8
        Me.TBCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBTel
        '
        Me.TBTel.Location = New System.Drawing.Point(485, 143)
        Me.TBTel.MaxLength = 10
        Me.TBTel.Name = "TBTel"
        Me.TBTel.Size = New System.Drawing.Size(164, 20)
        Me.TBTel.TabIndex = 11
        Me.TBTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBLogo
        '
        Me.TBLogo.Location = New System.Drawing.Point(292, 284)
        Me.TBLogo.Name = "TBLogo"
        Me.TBLogo.Size = New System.Drawing.Size(164, 20)
        Me.TBLogo.TabIndex = 10
        Me.TBLogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBMail
        '
        Me.TBMail.Location = New System.Drawing.Point(293, 236)
        Me.TBMail.Name = "TBMail"
        Me.TBMail.Size = New System.Drawing.Size(164, 20)
        Me.TBMail.TabIndex = 9
        Me.TBMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBMdp
        '
        Me.TBMdp.Location = New System.Drawing.Point(485, 96)
        Me.TBMdp.Name = "TBMdp"
        Me.TBMdp.Size = New System.Drawing.Size(164, 20)
        Me.TBMdp.TabIndex = 15
        Me.TBMdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelNomOff
        '
        Me.LabelNomOff.AutoSize = True
        Me.LabelNomOff.Location = New System.Drawing.Point(290, 34)
        Me.LabelNomOff.Name = "LabelNomOff"
        Me.LabelNomOff.Size = New System.Drawing.Size(30, 12)
        Me.LabelNomOff.TabIndex = 16
        Me.LabelNomOff.Text = "Nom"
        '
        'LabelPrenomOff
        '
        Me.LabelPrenomOff.AutoSize = True
        Me.LabelPrenomOff.Location = New System.Drawing.Point(290, 81)
        Me.LabelPrenomOff.Name = "LabelPrenomOff"
        Me.LabelPrenomOff.Size = New System.Drawing.Size(48, 12)
        Me.LabelPrenomOff.TabIndex = 17
        Me.LabelPrenomOff.Text = "Prénom"
        '
        'LabelCP
        '
        Me.LabelCP.AutoSize = True
        Me.LabelCP.Location = New System.Drawing.Point(673, 128)
        Me.LabelCP.Name = "LabelCP"
        Me.LabelCP.Size = New System.Drawing.Size(71, 12)
        Me.LabelCP.TabIndex = 21
        Me.LabelCP.Text = "Code postal"
        '
        'LabelVille
        '
        Me.LabelVille.AutoSize = True
        Me.LabelVille.Location = New System.Drawing.Point(291, 175)
        Me.LabelVille.Name = "LabelVille"
        Me.LabelVille.Size = New System.Drawing.Size(29, 12)
        Me.LabelVille.TabIndex = 20
        Me.LabelVille.Text = "Ville"
        '
        'LabelAdresse
        '
        Me.LabelAdresse.AutoSize = True
        Me.LabelAdresse.Location = New System.Drawing.Point(290, 128)
        Me.LabelAdresse.Name = "LabelAdresse"
        Me.LabelAdresse.Size = New System.Drawing.Size(51, 12)
        Me.LabelAdresse.TabIndex = 19
        Me.LabelAdresse.Text = "Adresse"
        '
        'LabelTel
        '
        Me.LabelTel.AutoSize = True
        Me.LabelTel.Location = New System.Drawing.Point(483, 128)
        Me.LabelTel.Name = "LabelTel"
        Me.LabelTel.Size = New System.Drawing.Size(79, 12)
        Me.LabelTel.TabIndex = 24
        Me.LabelTel.Text = "N° Téléphone"
        '
        'LabelLogo
        '
        Me.LabelLogo.AutoSize = True
        Me.LabelLogo.Location = New System.Drawing.Point(290, 269)
        Me.LabelLogo.Name = "LabelLogo"
        Me.LabelLogo.Size = New System.Drawing.Size(78, 12)
        Me.LabelLogo.TabIndex = 23
        Me.LabelLogo.Text = "Nom du Logo"
        '
        'LabelCouriel
        '
        Me.LabelCouriel.AutoSize = True
        Me.LabelCouriel.Location = New System.Drawing.Point(291, 221)
        Me.LabelCouriel.Name = "LabelCouriel"
        Me.LabelCouriel.Size = New System.Drawing.Size(50, 12)
        Me.LabelCouriel.TabIndex = 22
        Me.LabelCouriel.Text = "Courriel"
        '
        'LabelMdp
        '
        Me.LabelMdp.AutoSize = True
        Me.LabelMdp.Location = New System.Drawing.Point(483, 81)
        Me.LabelMdp.Name = "LabelMdp"
        Me.LabelMdp.Size = New System.Drawing.Size(78, 12)
        Me.LabelMdp.TabIndex = 25
        Me.LabelMdp.Text = "Mot de passe"
        '
        'LabelIdCivilite
        '
        Me.LabelIdCivilite.AutoSize = True
        Me.LabelIdCivilite.Location = New System.Drawing.Point(483, 175)
        Me.LabelIdCivilite.Name = "LabelIdCivilite"
        Me.LabelIdCivilite.Size = New System.Drawing.Size(55, 12)
        Me.LabelIdCivilite.TabIndex = 26
        Me.LabelIdCivilite.Text = "Id Civilité"
        '
        'LabelSite
        '
        Me.LabelSite.AutoSize = True
        Me.LabelSite.Location = New System.Drawing.Point(483, 33)
        Me.LabelSite.Name = "LabelSite"
        Me.LabelSite.Size = New System.Drawing.Size(26, 12)
        Me.LabelSite.TabIndex = 27
        Me.LabelSite.Text = "Site"
        '
        'LabelIdType
        '
        Me.LabelIdType.AutoSize = True
        Me.LabelIdType.Location = New System.Drawing.Point(673, 34)
        Me.LabelIdType.Name = "LabelIdType"
        Me.LabelIdType.Size = New System.Drawing.Size(105, 12)
        Me.LabelIdType.TabIndex = 28
        Me.LabelIdType.Text = "identifiant du type"
        '
        'LabelCivilite
        '
        Me.LabelCivilite.AutoSize = True
        Me.LabelCivilite.Location = New System.Drawing.Point(483, 221)
        Me.LabelCivilite.Name = "LabelCivilite"
        Me.LabelCivilite.Size = New System.Drawing.Size(48, 12)
        Me.LabelCivilite.TabIndex = 30
        Me.LabelCivilite.Text = "Civilité :"
        '
        'TBCivilite
        '
        Me.TBCivilite.Enabled = False
        Me.TBCivilite.Location = New System.Drawing.Point(485, 236)
        Me.TBCivilite.Name = "TBCivilite"
        Me.TBCivilite.ReadOnly = True
        Me.TBCivilite.Size = New System.Drawing.Size(164, 20)
        Me.TBCivilite.TabIndex = 29
        Me.TBCivilite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelType
        '
        Me.LabelType.AutoSize = True
        Me.LabelType.Location = New System.Drawing.Point(673, 81)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(97, 12)
        Me.LabelType.TabIndex = 32
        Me.LabelType.Text = "Type de l'offreur"
        '
        'TBType
        '
        Me.TBType.Location = New System.Drawing.Point(675, 96)
        Me.TBType.Name = "TBType"
        Me.TBType.ReadOnly = True
        Me.TBType.Size = New System.Drawing.Size(164, 20)
        Me.TBType.TabIndex = 31
        Me.TBType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBIdType
        '
        Me.CBIdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBIdType.FormattingEnabled = True
        Me.CBIdType.Location = New System.Drawing.Point(675, 49)
        Me.CBIdType.Name = "CBIdType"
        Me.CBIdType.Size = New System.Drawing.Size(164, 20)
        Me.CBIdType.TabIndex = 33
        '
        'CBIdCivilite
        '
        Me.CBIdCivilite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBIdCivilite.FormattingEnabled = True
        Me.CBIdCivilite.Location = New System.Drawing.Point(485, 189)
        Me.CBIdCivilite.Name = "CBIdCivilite"
        Me.CBIdCivilite.Size = New System.Drawing.Size(164, 20)
        Me.CBIdCivilite.TabIndex = 34
        '
        'DGVOffreur
        '
        Me.DGVOffreur.AllowUserToAddRows = False
        Me.DGVOffreur.AllowUserToDeleteRows = False
        Me.DGVOffreur.AllowUserToOrderColumns = True
        Me.DGVOffreur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOffreur.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nom})
        Me.DGVOffreur.Location = New System.Drawing.Point(14, 81)
        Me.DGVOffreur.Name = "DGVOffreur"
        Me.DGVOffreur.ReadOnly = True
        Me.DGVOffreur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVOffreur.Size = New System.Drawing.Size(160, 165)
        Me.DGVOffreur.TabIndex = 35
        '
        'ID
        '
        Me.ID.HeaderText = "Id"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom (et prénom)"
        Me.Nom.Name = "Nom"
        Me.Nom.ReadOnly = True
        '
        'BtnModif
        '
        Me.BtnModif.Location = New System.Drawing.Point(675, 196)
        Me.BtnModif.Name = "BtnModif"
        Me.BtnModif.Size = New System.Drawing.Size(164, 37)
        Me.BtnModif.TabIndex = 36
        Me.BtnModif.Text = "Modifier"
        Me.BtnModif.UseVisualStyleBackColor = True
        '
        'BtnSupp
        '
        Me.BtnSupp.Location = New System.Drawing.Point(675, 267)
        Me.BtnSupp.Name = "BtnSupp"
        Me.BtnSupp.Size = New System.Drawing.Size(164, 37)
        Me.BtnSupp.TabIndex = 37
        Me.BtnSupp.Text = "Supprimer"
        Me.BtnSupp.UseVisualStyleBackColor = True
        '
        'TBSite
        '
        Me.TBSite.Location = New System.Drawing.Point(485, 49)
        Me.TBSite.Name = "TBSite"
        Me.TBSite.Size = New System.Drawing.Size(164, 20)
        Me.TBSite.TabIndex = 14
        Me.TBSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormOff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 456)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSupp)
        Me.Controls.Add(Me.BtnModif)
        Me.Controls.Add(Me.DGVOffreur)
        Me.Controls.Add(Me.CBIdCivilite)
        Me.Controls.Add(Me.CBIdType)
        Me.Controls.Add(Me.LabelType)
        Me.Controls.Add(Me.TBType)
        Me.Controls.Add(Me.LabelCivilite)
        Me.Controls.Add(Me.TBCivilite)
        Me.Controls.Add(Me.LabelIdType)
        Me.Controls.Add(Me.LabelSite)
        Me.Controls.Add(Me.LabelIdCivilite)
        Me.Controls.Add(Me.LabelMdp)
        Me.Controls.Add(Me.LabelTel)
        Me.Controls.Add(Me.LabelLogo)
        Me.Controls.Add(Me.LabelCouriel)
        Me.Controls.Add(Me.LabelCP)
        Me.Controls.Add(Me.LabelVille)
        Me.Controls.Add(Me.LabelAdresse)
        Me.Controls.Add(Me.LabelPrenomOff)
        Me.Controls.Add(Me.LabelNomOff)
        Me.Controls.Add(Me.TBMdp)
        Me.Controls.Add(Me.TBSite)
        Me.Controls.Add(Me.TBTel)
        Me.Controls.Add(Me.TBLogo)
        Me.Controls.Add(Me.TBMail)
        Me.Controls.Add(Me.TBCP)
        Me.Controls.Add(Me.TBVille)
        Me.Controls.Add(Me.TBAdresse)
        Me.Controls.Add(Me.TBID)
        Me.Controls.Add(Me.TBPrenom)
        Me.Controls.Add(Me.TBNom)
        Me.Controls.Add(Me.LabelOff)
        Me.Controls.Add(Me.TBoff)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(0, 100)
        Me.MaximizeBox = False
        Me.Name = "FormOff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.DGVOffreur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBoff As TextBox
    Friend WithEvents LabelOff As Label
    Friend WithEvents TBNom As TextBox
    Friend WithEvents TBPrenom As TextBox
    Friend WithEvents TBID As TextBox
    Friend WithEvents TBAdresse As TextBox
    Friend WithEvents TBVille As TextBox
    Friend WithEvents TBCP As TextBox
    Friend WithEvents TBTel As TextBox
    Friend WithEvents TBLogo As TextBox
    Friend WithEvents TBMail As TextBox
    Friend WithEvents TBMdp As TextBox
    Friend WithEvents LabelNomOff As Label
    Friend WithEvents LabelPrenomOff As Label
    Friend WithEvents LabelCP As Label
    Friend WithEvents LabelVille As Label
    Friend WithEvents LabelAdresse As Label
    Friend WithEvents LabelTel As Label
    Friend WithEvents LabelLogo As Label
    Friend WithEvents LabelCouriel As Label
    Friend WithEvents LabelMdp As Label
    Friend WithEvents LabelIdCivilite As Label
    Friend WithEvents LabelSite As Label
    Friend WithEvents LabelIdType As Label
    Friend WithEvents LabelCivilite As Label
    Friend WithEvents TBCivilite As TextBox
    Friend WithEvents LabelType As Label
    Friend WithEvents TBType As TextBox
    Friend WithEvents CBIdType As ComboBox
    Friend WithEvents CBIdCivilite As ComboBox
    Friend WithEvents DGVOffreur As DataGridView
    Friend WithEvents BtnModif As Button
    Friend WithEvents BtnSupp As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents TBSite As TextBox
End Class
