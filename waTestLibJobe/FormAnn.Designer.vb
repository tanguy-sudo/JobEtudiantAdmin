<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAnn
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
        Me.txtLieu = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtOff = New System.Windows.Forms.TextBox()
        Me.txtTarif = New System.Windows.Forms.TextBox()
        Me.txtDuree = New System.Windows.Forms.TextBox()
        Me.cboCateg = New System.Windows.Forms.ComboBox()
        Me.DteAnn = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRecherche = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DGVAnn = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitreAn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.offreur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTitre = New System.Windows.Forms.TextBox()
        Me.TextBoxidAn = New System.Windows.Forms.TextBox()
        Me.btnSupp = New System.Windows.Forms.Button()
        CType(Me.DGVAnn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLieu
        '
        Me.txtLieu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLieu.Location = New System.Drawing.Point(427, 240)
        Me.txtLieu.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLieu.Name = "txtLieu"
        Me.txtLieu.Size = New System.Drawing.Size(195, 20)
        Me.txtLieu.TabIndex = 5
        Me.txtLieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(427, 147)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(461, 60)
        Me.txtDesc.TabIndex = 7
        Me.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOff
        '
        Me.txtOff.Cursor = System.Windows.Forms.Cursors.No
        Me.txtOff.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOff.Location = New System.Drawing.Point(707, 298)
        Me.txtOff.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOff.Name = "txtOff"
        Me.txtOff.ReadOnly = True
        Me.txtOff.Size = New System.Drawing.Size(181, 20)
        Me.txtOff.TabIndex = 9
        Me.txtOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTarif
        '
        Me.txtTarif.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTarif.Location = New System.Drawing.Point(707, 240)
        Me.txtTarif.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTarif.Name = "txtTarif"
        Me.txtTarif.Size = New System.Drawing.Size(156, 20)
        Me.txtTarif.TabIndex = 10
        Me.txtTarif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDuree
        '
        Me.txtDuree.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuree.Location = New System.Drawing.Point(707, 94)
        Me.txtDuree.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDuree.Name = "txtDuree"
        Me.txtDuree.Size = New System.Drawing.Size(181, 20)
        Me.txtDuree.TabIndex = 11
        Me.txtDuree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboCateg
        '
        Me.cboCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCateg.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCateg.FormattingEnabled = True
        Me.cboCateg.Location = New System.Drawing.Point(427, 297)
        Me.cboCateg.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCateg.Name = "cboCateg"
        Me.cboCateg.Size = New System.Drawing.Size(195, 20)
        Me.cboCateg.TabIndex = 13
        '
        'DteAnn
        '
        Me.DteAnn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DteAnn.Location = New System.Drawing.Point(427, 94)
        Me.DteAnn.Margin = New System.Windows.Forms.Padding(2)
        Me.DteAnn.Name = "DteAnn"
        Me.DteAnn.Size = New System.Drawing.Size(201, 20)
        Me.DteAnn.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(424, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 12)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Date de début"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(704, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 12)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Durée de la mission"
        '
        'txtRecherche
        '
        Me.txtRecherche.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecherche.Location = New System.Drawing.Point(55, 66)
        Me.txtRecherche.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRecherche.Name = "txtRecherche"
        Me.txtRecherche.Size = New System.Drawing.Size(209, 20)
        Me.txtRecherche.TabIndex = 17
        Me.txtRecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 12)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Recherche sur le titre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(704, 225)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 12)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Tarif"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(424, 132)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 12)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Description de la mission"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(424, 225)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 12)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Lieu de la mission"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(704, 283)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 12)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Nom de l'offreur"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(424, 282)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 12)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Catégorie"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(868, 240)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 18)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "€"
        '
        'DGVAnn
        '
        Me.DGVAnn.AllowUserToAddRows = False
        Me.DGVAnn.AllowUserToDeleteRows = False
        Me.DGVAnn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVAnn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAnn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.TitreAn, Me.offreur})
        Me.DGVAnn.Location = New System.Drawing.Point(55, 114)
        Me.DGVAnn.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVAnn.Name = "DGVAnn"
        Me.DGVAnn.ReadOnly = True
        Me.DGVAnn.RowTemplate.Height = 24
        Me.DGVAnn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVAnn.Size = New System.Drawing.Size(330, 178)
        Me.DGVAnn.TabIndex = 25
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'TitreAn
        '
        Me.TitreAn.HeaderText = "Titre de l'annonce"
        Me.TitreAn.Name = "TitreAn"
        Me.TitreAn.ReadOnly = True
        '
        'offreur
        '
        Me.offreur.HeaderText = "Offreur de l'annonce"
        Me.offreur.Name = "offreur"
        Me.offreur.ReadOnly = True
        '
        'btnMod
        '
        Me.btnMod.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod.Location = New System.Drawing.Point(707, 338)
        Me.btnMod.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(104, 36)
        Me.btnMod.TabIndex = 27
        Me.btnMod.Text = "Modifier l'annonce"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(533, 25)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 12)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Titre de la mission"
        '
        'txtTitre
        '
        Me.txtTitre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitre.Location = New System.Drawing.Point(536, 40)
        Me.txtTitre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTitre.Name = "txtTitre"
        Me.txtTitre.Size = New System.Drawing.Size(243, 20)
        Me.txtTitre.TabIndex = 28
        Me.txtTitre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxidAn
        '
        Me.TextBoxidAn.Location = New System.Drawing.Point(786, 40)
        Me.TextBoxidAn.Name = "TextBoxidAn"
        Me.TextBoxidAn.Size = New System.Drawing.Size(16, 20)
        Me.TextBoxidAn.TabIndex = 30
        Me.TextBoxidAn.Visible = False
        '
        'btnSupp
        '
        Me.btnSupp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupp.Location = New System.Drawing.Point(528, 338)
        Me.btnSupp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSupp.Name = "btnSupp"
        Me.btnSupp.Size = New System.Drawing.Size(104, 36)
        Me.btnSupp.TabIndex = 26
        Me.btnSupp.Text = "Supprimer l'annonce"
        Me.btnSupp.UseVisualStyleBackColor = True
        '
        'FormAnn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 456)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBoxidAn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTitre)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnSupp)
        Me.Controls.Add(Me.DGVAnn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRecherche)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DteAnn)
        Me.Controls.Add(Me.cboCateg)
        Me.Controls.Add(Me.txtDuree)
        Me.Controls.Add(Me.txtTarif)
        Me.Controls.Add(Me.txtOff)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtLieu)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(0, 100)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormAnn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.DGVAnn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLieu As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtOff As TextBox
    Friend WithEvents txtTarif As TextBox
    Friend WithEvents txtDuree As TextBox
    Friend WithEvents cboCateg As ComboBox
    Friend WithEvents DteAnn As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRecherche As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DGVAnn As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents TitreAn As DataGridViewTextBoxColumn
    Friend WithEvents offreur As DataGridViewTextBoxColumn
    Friend WithEvents btnMod As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTitre As TextBox
    Friend WithEvents TextBoxidAn As TextBox
    Friend WithEvents btnSupp As Button
End Class
