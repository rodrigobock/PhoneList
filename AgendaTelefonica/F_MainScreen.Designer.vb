﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_MainScreen
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_Updade = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.White
        Me.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Add.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.Location = New System.Drawing.Point(603, 30)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(174, 70)
        Me.btn_Add.TabIndex = 0
        Me.btn_Add.Text = "Add Contact"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'btn_Updade
        '
        Me.btn_Updade.BackColor = System.Drawing.Color.White
        Me.btn_Updade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Updade.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Updade.Location = New System.Drawing.Point(603, 132)
        Me.btn_Updade.Name = "btn_Updade"
        Me.btn_Updade.Size = New System.Drawing.Size(174, 70)
        Me.btn_Updade.TabIndex = 2
        Me.btn_Updade.Text = "Update Contact"
        Me.btn_Updade.UseVisualStyleBackColor = False
        '
        'btn_Delete
        '
        Me.btn_Delete.BackColor = System.Drawing.Color.White
        Me.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Delete.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete.Location = New System.Drawing.Point(603, 243)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(174, 70)
        Me.btn_Delete.TabIndex = 3
        Me.btn_Delete.Text = "Delete Contact"
        Me.btn_Delete.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(553, 283)
        Me.DataGridView1.TabIndex = 4
        '
        'F_MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(800, 343)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.btn_Updade)
        Me.Controls.Add(Me.btn_Add)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "F_MainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Screen"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Add As Button
    Friend WithEvents btn_Updade As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
