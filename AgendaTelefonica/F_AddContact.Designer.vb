<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_AddContact
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_name = New System.Windows.Forms.TextBox()
        Me.tb_lastname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_phone = New System.Windows.Forms.MaskedTextBox()
        Me.tb_otherphone = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_group = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_addPhoto = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(148, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'tb_name
        '
        Me.tb_name.BackColor = System.Drawing.Color.White
        Me.tb_name.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_name.Location = New System.Drawing.Point(15, 199)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Size = New System.Drawing.Size(423, 31)
        Me.tb_name.TabIndex = 0
        '
        'tb_lastname
        '
        Me.tb_lastname.BackColor = System.Drawing.Color.White
        Me.tb_lastname.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_lastname.Location = New System.Drawing.Point(15, 273)
        Me.tb_lastname.Name = "tb_lastname"
        Me.tb_lastname.Size = New System.Drawing.Size(423, 31)
        Me.tb_lastname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone Number"
        '
        'tb_phone
        '
        Me.tb_phone.BackColor = System.Drawing.Color.White
        Me.tb_phone.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_phone.Location = New System.Drawing.Point(15, 343)
        Me.tb_phone.Name = "tb_phone"
        Me.tb_phone.Size = New System.Drawing.Size(195, 31)
        Me.tb_phone.TabIndex = 2
        '
        'tb_otherphone
        '
        Me.tb_otherphone.BackColor = System.Drawing.Color.White
        Me.tb_otherphone.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_otherphone.Location = New System.Drawing.Point(243, 343)
        Me.tb_otherphone.Name = "tb_otherphone"
        Me.tb_otherphone.Size = New System.Drawing.Size(195, 31)
        Me.tb_otherphone.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(239, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Other Number"
        '
        'tb_group
        '
        Me.tb_group.BackColor = System.Drawing.Color.White
        Me.tb_group.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_group.Location = New System.Drawing.Point(15, 417)
        Me.tb_group.Name = "tb_group"
        Me.tb_group.Size = New System.Drawing.Size(423, 31)
        Me.tb_group.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 390)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Group"
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.White
        Me.btn_save.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(4, 506)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(214, 49)
        Me.btn_save.TabIndex = 5
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.White
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(224, 506)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(214, 49)
        Me.btn_cancel.TabIndex = 6
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_addPhoto
        '
        Me.btn_addPhoto.Location = New System.Drawing.Point(297, 138)
        Me.btn_addPhoto.Name = "btn_addPhoto"
        Me.btn_addPhoto.Size = New System.Drawing.Size(75, 23)
        Me.btn_addPhoto.TabIndex = 7
        Me.btn_addPhoto.Text = "Add photo"
        Me.btn_addPhoto.UseVisualStyleBackColor = True
        '
        'F_AddContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(450, 558)
        Me.Controls.Add(Me.btn_addPhoto)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.tb_group)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_otherphone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_phone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_lastname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "F_AddContact"
        Me.Text = "AddContact"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_name As TextBox
    Friend WithEvents tb_lastname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_phone As MaskedTextBox
    Friend WithEvents tb_otherphone As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_group As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_addPhoto As Button
End Class
