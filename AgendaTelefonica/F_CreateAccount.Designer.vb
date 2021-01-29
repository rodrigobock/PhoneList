<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_CreateAccount
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
        Me.tb_phone = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_lastname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_username = New System.Windows.Forms.Label()
        Me.tb_user = New System.Windows.Forms.TextBox()
        Me.tb_psw = New System.Windows.Forms.TextBox()
        Me.lb_password = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_phone
        '
        Me.tb_phone.BackColor = System.Drawing.Color.White
        Me.tb_phone.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_phone.Location = New System.Drawing.Point(12, 187)
        Me.tb_phone.Name = "tb_phone"
        Me.tb_phone.Size = New System.Drawing.Size(206, 31)
        Me.tb_phone.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Phone Number"
        '
        'tb_lastname
        '
        Me.tb_lastname.BackColor = System.Drawing.Color.White
        Me.tb_lastname.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_lastname.Location = New System.Drawing.Point(12, 117)
        Me.tb_lastname.Name = "tb_lastname"
        Me.tb_lastname.Size = New System.Drawing.Size(423, 31)
        Me.tb_lastname.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Last Name"
        '
        'tb_name
        '
        Me.tb_name.BackColor = System.Drawing.Color.White
        Me.tb_name.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_name.Location = New System.Drawing.Point(12, 43)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Size = New System.Drawing.Size(423, 31)
        Me.tb_name.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name:"
        '
        'lb_username
        '
        Me.lb_username.AutoSize = True
        Me.lb_username.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_username.Location = New System.Drawing.Point(7, 232)
        Me.lb_username.Name = "lb_username"
        Me.lb_username.Size = New System.Drawing.Size(98, 25)
        Me.lb_username.TabIndex = 9
        Me.lb_username.Text = "Username"
        '
        'tb_user
        '
        Me.tb_user.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_user.Location = New System.Drawing.Point(9, 260)
        Me.tb_user.Name = "tb_user"
        Me.tb_user.Size = New System.Drawing.Size(426, 32)
        Me.tb_user.TabIndex = 10
        '
        'tb_psw
        '
        Me.tb_psw.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_psw.Location = New System.Drawing.Point(9, 335)
        Me.tb_psw.Name = "tb_psw"
        Me.tb_psw.Size = New System.Drawing.Size(426, 32)
        Me.tb_psw.TabIndex = 12
        '
        'lb_password
        '
        Me.lb_password.AutoSize = True
        Me.lb_password.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_password.Location = New System.Drawing.Point(7, 307)
        Me.lb_password.Name = "lb_password"
        Me.lb_password.Size = New System.Drawing.Size(94, 25)
        Me.lb_password.TabIndex = 11
        Me.lb_password.Text = "Password"
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.White
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(233, 414)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(214, 49)
        Me.btn_cancel.TabIndex = 14
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.White
        Me.btn_save.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(13, 414)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(214, 49)
        Me.btn_save.TabIndex = 13
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'F_CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(459, 482)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.tb_psw)
        Me.Controls.Add(Me.lb_password)
        Me.Controls.Add(Me.tb_user)
        Me.Controls.Add(Me.lb_username)
        Me.Controls.Add(Me.tb_phone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_lastname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_name)
        Me.Controls.Add(Me.Label1)
        Me.Name = "F_CreateAccount"
        Me.Text = "F_CreateAccount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_phone As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_lastname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_username As Label
    Friend WithEvents tb_user As TextBox
    Friend WithEvents tb_psw As TextBox
    Friend WithEvents lb_password As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_save As Button
End Class
