<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEtudiant
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
        Me.ButtonModifier = New System.Windows.Forms.Button()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.TextBoxMail = New System.Windows.Forms.TextBox()
        Me.TextBoxPrenom = New System.Windows.Forms.TextBox()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.TextBoxIdCiv = New System.Windows.Forms.TextBox()
        Me.TextBoxCV = New System.Windows.Forms.TextBox()
        Me.TextBoxMdp = New System.Windows.Forms.TextBox()
        Me.TextBoxTel = New System.Windows.Forms.TextBox()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.LabelDateNaiss = New System.Windows.Forms.Label()
        Me.LabelMailEtu = New System.Windows.Forms.Label()
        Me.LabelMdp = New System.Windows.Forms.Label()
        Me.LabelTel = New System.Windows.Forms.Label()
        Me.LabeIdCiv = New System.Windows.Forms.Label()
        Me.LabeCV = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.ButtonAnnonceEtu = New System.Windows.Forms.Button()
        Me.TextBoxDateNaiss = New System.Windows.Forms.DateTimePicker()
        Me.SelectEtudiant = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prénom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTNsupprimer = New System.Windows.Forms.Button()
        Me.TxtRecherche = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.SelectEtudiant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonModifier
        '
        Me.ButtonModifier.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModifier.Location = New System.Drawing.Point(650, 344)
        Me.ButtonModifier.Name = "ButtonModifier"
        Me.ButtonModifier.Size = New System.Drawing.Size(187, 21)
        Me.ButtonModifier.TabIndex = 3
        Me.ButtonModifier.Text = "Modifier"
        Me.ButtonModifier.UseVisualStyleBackColor = True
        '
        'TextBoxId
        '
        Me.TextBoxId.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBoxId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxId.Location = New System.Drawing.Point(443, 300)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.ReadOnly = True
        Me.TextBoxId.Size = New System.Drawing.Size(187, 20)
        Me.TextBoxId.TabIndex = 12
        Me.TextBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxMail
        '
        Me.TextBoxMail.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMail.Location = New System.Drawing.Point(443, 254)
        Me.TextBoxMail.Name = "TextBoxMail"
        Me.TextBoxMail.Size = New System.Drawing.Size(187, 20)
        Me.TextBoxMail.TabIndex = 14
        Me.TextBoxMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrenom.Location = New System.Drawing.Point(443, 153)
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.Size = New System.Drawing.Size(187, 20)
        Me.TextBoxPrenom.TabIndex = 16
        Me.TextBoxPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNom.Location = New System.Drawing.Point(443, 103)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(187, 20)
        Me.TextBoxNom.TabIndex = 17
        Me.TextBoxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxIdCiv
        '
        Me.TextBoxIdCiv.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBoxIdCiv.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIdCiv.Location = New System.Drawing.Point(650, 254)
        Me.TextBoxIdCiv.Name = "TextBoxIdCiv"
        Me.TextBoxIdCiv.ReadOnly = True
        Me.TextBoxIdCiv.Size = New System.Drawing.Size(187, 20)
        Me.TextBoxIdCiv.TabIndex = 18
        Me.TextBoxIdCiv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxCV
        '
        Me.TextBoxCV.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBoxCV.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCV.Location = New System.Drawing.Point(650, 207)
        Me.TextBoxCV.Name = "TextBoxCV"
        Me.TextBoxCV.ReadOnly = True
        Me.TextBoxCV.Size = New System.Drawing.Size(187, 20)
        Me.TextBoxCV.TabIndex = 19
        Me.TextBoxCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxMdp
        '
        Me.TextBoxMdp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMdp.Location = New System.Drawing.Point(650, 153)
        Me.TextBoxMdp.Name = "TextBoxMdp"
        Me.TextBoxMdp.Size = New System.Drawing.Size(187, 20)
        Me.TextBoxMdp.TabIndex = 20
        Me.TextBoxMdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxTel
        '
        Me.TextBoxTel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTel.Location = New System.Drawing.Point(650, 103)
        Me.TextBoxTel.MaxLength = 10
        Me.TextBoxTel.Name = "TextBoxTel"
        Me.TextBoxTel.Size = New System.Drawing.Size(187, 20)
        Me.TextBoxTel.TabIndex = 21
        Me.TextBoxTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrenom.Location = New System.Drawing.Point(441, 136)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(48, 12)
        Me.LabelPrenom.TabIndex = 23
        Me.LabelPrenom.Text = "Prénom"
        '
        'LabelDateNaiss
        '
        Me.LabelDateNaiss.AutoSize = True
        Me.LabelDateNaiss.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDateNaiss.Location = New System.Drawing.Point(441, 192)
        Me.LabelDateNaiss.Name = "LabelDateNaiss"
        Me.LabelDateNaiss.Size = New System.Drawing.Size(108, 12)
        Me.LabelDateNaiss.TabIndex = 24
        Me.LabelDateNaiss.Text = "Date de naissance"
        '
        'LabelMailEtu
        '
        Me.LabelMailEtu.AutoSize = True
        Me.LabelMailEtu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMailEtu.Location = New System.Drawing.Point(441, 239)
        Me.LabelMailEtu.Name = "LabelMailEtu"
        Me.LabelMailEtu.Size = New System.Drawing.Size(50, 12)
        Me.LabelMailEtu.TabIndex = 25
        Me.LabelMailEtu.Text = "Courriel"
        '
        'LabelMdp
        '
        Me.LabelMdp.AutoSize = True
        Me.LabelMdp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMdp.Location = New System.Drawing.Point(648, 138)
        Me.LabelMdp.Name = "LabelMdp"
        Me.LabelMdp.Size = New System.Drawing.Size(78, 12)
        Me.LabelMdp.TabIndex = 26
        Me.LabelMdp.Text = "Mot de passe"
        '
        'LabelTel
        '
        Me.LabelTel.AutoSize = True
        Me.LabelTel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTel.Location = New System.Drawing.Point(648, 88)
        Me.LabelTel.Name = "LabelTel"
        Me.LabelTel.Size = New System.Drawing.Size(64, 12)
        Me.LabelTel.TabIndex = 27
        Me.LabelTel.Text = "Téléphone"
        '
        'LabeIdCiv
        '
        Me.LabeIdCiv.AutoSize = True
        Me.LabeIdCiv.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabeIdCiv.Location = New System.Drawing.Point(648, 239)
        Me.LabeIdCiv.Name = "LabeIdCiv"
        Me.LabeIdCiv.Size = New System.Drawing.Size(41, 12)
        Me.LabeIdCiv.TabIndex = 29
        Me.LabeIdCiv.Text = "civilité"
        '
        'LabeCV
        '
        Me.LabeCV.AutoSize = True
        Me.LabeCV.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabeCV.Location = New System.Drawing.Point(648, 192)
        Me.LabeCV.Name = "LabeCV"
        Me.LabeCV.Size = New System.Drawing.Size(96, 12)
        Me.LabeCV.TabIndex = 30
        Me.LabeCV.Text = "curriculum vitae"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.Location = New System.Drawing.Point(441, 88)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(30, 12)
        Me.LabelNom.TabIndex = 31
        Me.LabelNom.Text = "Nom"
        '
        'ButtonAnnonceEtu
        '
        Me.ButtonAnnonceEtu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnnonceEtu.Location = New System.Drawing.Point(12, 253)
        Me.ButtonAnnonceEtu.Name = "ButtonAnnonceEtu"
        Me.ButtonAnnonceEtu.Size = New System.Drawing.Size(287, 21)
        Me.ButtonAnnonceEtu.TabIndex = 32
        Me.ButtonAnnonceEtu.Text = "Afficher les participations"
        Me.ButtonAnnonceEtu.UseVisualStyleBackColor = True
        '
        'TextBoxDateNaiss
        '
        Me.TextBoxDateNaiss.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDateNaiss.Location = New System.Drawing.Point(443, 207)
        Me.TextBoxDateNaiss.Name = "TextBoxDateNaiss"
        Me.TextBoxDateNaiss.Size = New System.Drawing.Size(187, 20)
        Me.TextBoxDateNaiss.TabIndex = 34
        '
        'SelectEtudiant
        '
        Me.SelectEtudiant.AllowUserToAddRows = False
        Me.SelectEtudiant.AllowUserToDeleteRows = False
        Me.SelectEtudiant.AllowUserToOrderColumns = True
        Me.SelectEtudiant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SelectEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SelectEtudiant.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Nom, Me.Prénom})
        Me.SelectEtudiant.Location = New System.Drawing.Point(12, 113)
        Me.SelectEtudiant.Name = "SelectEtudiant"
        Me.SelectEtudiant.ReadOnly = True
        Me.SelectEtudiant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SelectEtudiant.Size = New System.Drawing.Size(286, 132)
        Me.SelectEtudiant.TabIndex = 36
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom"
        Me.Nom.Name = "Nom"
        Me.Nom.ReadOnly = True
        '
        'Prénom
        '
        Me.Prénom.HeaderText = "Prénom"
        Me.Prénom.Name = "Prénom"
        Me.Prénom.ReadOnly = True
        '
        'BTNsupprimer
        '
        Me.BTNsupprimer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNsupprimer.Location = New System.Drawing.Point(443, 344)
        Me.BTNsupprimer.Name = "BTNsupprimer"
        Me.BTNsupprimer.Size = New System.Drawing.Size(187, 21)
        Me.BTNsupprimer.TabIndex = 37
        Me.BTNsupprimer.Text = "Supprimer l'étudiant"
        Me.BTNsupprimer.UseVisualStyleBackColor = True
        '
        'TxtRecherche
        '
        Me.TxtRecherche.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRecherche.Location = New System.Drawing.Point(12, 79)
        Me.TxtRecherche.Name = "TxtRecherche"
        Me.TxtRecherche.Size = New System.Drawing.Size(286, 20)
        Me.TxtRecherche.TabIndex = 38
        Me.TxtRecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 64)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 12)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Recherche sur le nom ou le prénom"
        '
        'FormEtudiant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 456)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtRecherche)
        Me.Controls.Add(Me.BTNsupprimer)
        Me.Controls.Add(Me.SelectEtudiant)
        Me.Controls.Add(Me.TextBoxDateNaiss)
        Me.Controls.Add(Me.ButtonAnnonceEtu)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.LabeCV)
        Me.Controls.Add(Me.LabeIdCiv)
        Me.Controls.Add(Me.LabelTel)
        Me.Controls.Add(Me.LabelMdp)
        Me.Controls.Add(Me.LabelMailEtu)
        Me.Controls.Add(Me.LabelDateNaiss)
        Me.Controls.Add(Me.LabelPrenom)
        Me.Controls.Add(Me.TextBoxTel)
        Me.Controls.Add(Me.TextBoxMdp)
        Me.Controls.Add(Me.TextBoxCV)
        Me.Controls.Add(Me.TextBoxIdCiv)
        Me.Controls.Add(Me.TextBoxNom)
        Me.Controls.Add(Me.TextBoxPrenom)
        Me.Controls.Add(Me.TextBoxMail)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.ButtonModifier)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(0, 100)
        Me.Name = "FormEtudiant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.SelectEtudiant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonModifier As Button
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents TextBoxMail As TextBox
    Friend WithEvents TextBoxPrenom As TextBox
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents TextBoxIdCiv As TextBox
    Friend WithEvents TextBoxCV As TextBox
    Friend WithEvents TextBoxMdp As TextBox
    Friend WithEvents TextBoxTel As TextBox
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents LabelDateNaiss As Label
    Friend WithEvents LabelMailEtu As Label
    Friend WithEvents LabelMdp As Label
    Friend WithEvents LabelTel As Label
    Friend WithEvents LabeIdCiv As Label
    Friend WithEvents LabeCV As Label
    Friend WithEvents LabelNom As Label
    Friend WithEvents ButtonAnnonceEtu As Button
    Friend WithEvents TextBoxDateNaiss As DateTimePicker
    Friend WithEvents SelectEtudiant As DataGridView
    Friend WithEvents BTNsupprimer As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Prénom As DataGridViewTextBoxColumn
    Friend WithEvents TxtRecherche As TextBox
    Friend WithEvents Label3 As Label
End Class
