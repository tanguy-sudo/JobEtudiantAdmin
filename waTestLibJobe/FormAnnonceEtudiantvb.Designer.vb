<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAnnonceEtudiantvb
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
        Me.ButtonAfficher = New System.Windows.Forms.Button()
        Me.DataGridViewAnnonce = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.titre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Offreur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.état = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewAnnonce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonAfficher
        '
        Me.ButtonAfficher.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAfficher.Location = New System.Drawing.Point(72, 200)
        Me.ButtonAfficher.Name = "ButtonAfficher"
        Me.ButtonAfficher.Size = New System.Drawing.Size(402, 21)
        Me.ButtonAfficher.TabIndex = 1
        Me.ButtonAfficher.Text = "Plus de détails"
        Me.ButtonAfficher.UseVisualStyleBackColor = True
        '
        'DataGridViewAnnonce
        '
        Me.DataGridViewAnnonce.AllowUserToAddRows = False
        Me.DataGridViewAnnonce.AllowUserToDeleteRows = False
        Me.DataGridViewAnnonce.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewAnnonce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAnnonce.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.titre, Me.Offreur, Me.état})
        Me.DataGridViewAnnonce.Location = New System.Drawing.Point(72, 31)
        Me.DataGridViewAnnonce.Name = "DataGridViewAnnonce"
        Me.DataGridViewAnnonce.ReadOnly = True
        Me.DataGridViewAnnonce.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewAnnonce.Size = New System.Drawing.Size(402, 138)
        Me.DataGridViewAnnonce.TabIndex = 2
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'titre
        '
        Me.titre.HeaderText = "Titre de l'annonce"
        Me.titre.Name = "titre"
        Me.titre.ReadOnly = True
        '
        'Offreur
        '
        Me.Offreur.HeaderText = "Offreur de l'annonce"
        Me.Offreur.Name = "Offreur"
        Me.Offreur.ReadOnly = True
        '
        'état
        '
        Me.état.HeaderText = "etat"
        Me.état.Name = "état"
        Me.état.ReadOnly = True
        '
        'FormAnnonceEtudiantvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 241)
        Me.Controls.Add(Me.DataGridViewAnnonce)
        Me.Controls.Add(Me.ButtonAfficher)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormAnnonceEtudiantvb"
        Me.Text = "Afficher les participations"
        CType(Me.DataGridViewAnnonce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonAfficher As Button
    Friend WithEvents DataGridViewAnnonce As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents titre As DataGridViewTextBoxColumn
    Friend WithEvents Offreur As DataGridViewTextBoxColumn
    Friend WithEvents état As DataGridViewTextBoxColumn
End Class
