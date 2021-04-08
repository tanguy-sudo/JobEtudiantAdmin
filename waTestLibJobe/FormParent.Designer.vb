<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormParent
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
        Me.btnOff = New System.Windows.Forms.Button()
        Me.btnEtu = New System.Windows.Forms.Button()
        Me.btnCategories = New System.Windows.Forms.Button()
        Me.btnAnn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOff
        '
        Me.btnOff.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOff.Location = New System.Drawing.Point(356, 29)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(115, 43)
        Me.btnOff.TabIndex = 0
        Me.btnOff.Text = "offreurs"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'btnEtu
        '
        Me.btnEtu.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEtu.Location = New System.Drawing.Point(525, 29)
        Me.btnEtu.Name = "btnEtu"
        Me.btnEtu.Size = New System.Drawing.Size(115, 43)
        Me.btnEtu.TabIndex = 1
        Me.btnEtu.Text = "étudiants"
        Me.btnEtu.UseVisualStyleBackColor = True
        '
        'btnCategories
        '
        Me.btnCategories.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategories.Location = New System.Drawing.Point(185, 29)
        Me.btnCategories.Name = "btnCategories"
        Me.btnCategories.Size = New System.Drawing.Size(115, 43)
        Me.btnCategories.TabIndex = 2
        Me.btnCategories.Text = "catégories"
        Me.btnCategories.UseVisualStyleBackColor = True
        '
        'btnAnn
        '
        Me.btnAnn.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnn.Location = New System.Drawing.Point(689, 29)
        Me.btnAnn.Name = "btnAnn"
        Me.btnAnn.Size = New System.Drawing.Size(115, 43)
        Me.btnAnn.TabIndex = 3
        Me.btnAnn.Text = "annonces"
        Me.btnAnn.UseVisualStyleBackColor = True
        '
        'FormParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.btnAnn)
        Me.Controls.Add(Me.btnCategories)
        Me.Controls.Add(Me.btnEtu)
        Me.Controls.Add(Me.btnOff)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormParent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOff As Button
    Friend WithEvents btnEtu As Button
    Friend WithEvents btnCategories As Button
    Friend WithEvents btnAnn As Button
End Class
