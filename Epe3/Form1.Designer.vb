<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        BtnLogin = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(262, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 25)
        Label1.TabIndex = 0
        Label1.Text = "Bienvenido"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(87, 190)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 25)
        Label2.TabIndex = 1
        Label2.Text = "Usuario:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(87, 279)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 25)
        Label3.TabIndex = 2
        Label3.Text = "Contraseña:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(262, 187)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(182, 31)
        txtUsername.TabIndex = 3
        txtUsername.Text = "fra"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(262, 273)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(182, 31)
        txtPassword.TabIndex = 4
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(260, 351)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(184, 34)
        BtnLogin.TabIndex = 5
        BtnLogin.Text = "Iniciar Sesion"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(591, 471)
        Controls.Add(BtnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "LoginForm"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents BtnLogin As Button

End Class
