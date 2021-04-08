<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCateg
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
        Me.DGVCateg = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNewCateg = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCateg = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRecherche = New System.Windows.Forms.TextBox()
        Me.TextBoxidCateg = New System.Windows.Forms.TextBox()
        CType(Me.DGVCateg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVCateg
        '
        Me.DGVCateg.AllowUserToAddRows = False
        Me.DGVCateg.AllowUserToDeleteRows = False
        Me.DGVCateg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVCateg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCateg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Categ})
        Me.DGVCateg.Location = New System.Drawing.Point(37, 90)
        Me.DGVCateg.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVCateg.Name = "DGVCateg"
        Me.DGVCateg.ReadOnly = True
        Me.DGVCateg.RowTemplate.Height = 24
        Me.DGVCateg.Size = New System.Drawing.Size(230, 214)
        Me.DGVCateg.TabIndex = 26
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Categ
        '
        Me.Categ.HeaderText = "Catégorie"
        Me.Categ.Name = "Categ"
        Me.Categ.ReadOnly = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(785, 141)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 12)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Ajouter une catégorie"
        '
        'txtNewCateg
        '
        Me.txtNewCateg.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewCateg.Location = New System.Drawing.Point(723, 164)
        Me.txtNewCateg.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNewCateg.Name = "txtNewCateg"
        Me.txtNewCateg.Size = New System.Drawing.Size(243, 20)
        Me.txtNewCateg.TabIndex = 31
        Me.txtNewCateg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(778, 195)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(143, 36)
        Me.btnNew.TabIndex = 30
        Me.btnNew.Text = "Ajouter la catégorie"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(367, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 12)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Nom de la catégorie sélectionnée"
        '
        'txtCateg
        '
        Me.txtCateg.Location = New System.Drawing.Point(341, 119)
        Me.txtCateg.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCateg.Name = "txtCateg"
        Me.txtCateg.Size = New System.Drawing.Size(243, 20)
        Me.txtCateg.TabIndex = 34
        Me.txtCateg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(309, 150)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 36)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Supprimer la catégorie"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(474, 150)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 36)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Modifier la catégorie"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtRecherche)
        Me.GroupBox1.Controls.Add(Me.DGVCateg)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txtCateg)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(63, 43)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(653, 333)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Les catégories existantes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 12)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Rechercher une catégorie"
        '
        'txtRecherche
        '
        Me.txtRecherche.Location = New System.Drawing.Point(37, 49)
        Me.txtRecherche.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRecherche.Name = "txtRecherche"
        Me.txtRecherche.Size = New System.Drawing.Size(230, 20)
        Me.txtRecherche.TabIndex = 37
        Me.txtRecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxidCateg
        '
        Me.TextBoxidCateg.Location = New System.Drawing.Point(652, 162)
        Me.TextBoxidCateg.Name = "TextBoxidCateg"
        Me.TextBoxidCateg.Size = New System.Drawing.Size(10, 20)
        Me.TextBoxidCateg.TabIndex = 38
        Me.TextBoxidCateg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBoxidCateg.Visible = False
        '
        'FormCateg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 456)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBoxidCateg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNewCateg)
        Me.Controls.Add(Me.btnNew)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(0, 100)
        Me.Name = "FormCateg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.DGVCateg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVCateg As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Categ As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNewCateg As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCateg As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRecherche As TextBox
    Friend WithEvents TextBoxidCateg As TextBox
End Class
