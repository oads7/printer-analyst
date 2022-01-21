<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataRange
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.WClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateStart = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.DateEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.User = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'WClose
        '
        Me.WClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WClose.FlatAppearance.BorderSize = 0
        Me.WClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.WClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.WClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WClose.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WClose.ForeColor = System.Drawing.Color.White
        Me.WClose.Location = New System.Drawing.Point(349, 1)
        Me.WClose.Name = "WClose"
        Me.WClose.Size = New System.Drawing.Size(50, 30)
        Me.WClose.TabIndex = 11
        Me.WClose.TabStop = False
        Me.WClose.Text = "X"
        Me.WClose.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 30)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Define un rango de fecha y usuario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(70, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 30)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Inicio"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(70, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 30)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Fin"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateStart
        '
        Me.DateStart.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.DateStart.Location = New System.Drawing.Point(130, 95)
        Me.DateStart.Name = "DateStart"
        Me.DateStart.Size = New System.Drawing.Size(250, 27)
        Me.DateStart.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(398, 258)
        Me.Label4.TabIndex = 19
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Aceptar
        '
        Me.Aceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Aceptar.FlatAppearance.BorderSize = 2
        Me.Aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Aceptar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aceptar.ForeColor = System.Drawing.Color.White
        Me.Aceptar.Location = New System.Drawing.Point(280, 220)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(100, 30)
        Me.Aceptar.TabIndex = 20
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = False
        '
        'DateEnd
        '
        Me.DateEnd.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.DateEnd.Location = New System.Drawing.Point(130, 135)
        Me.DateEnd.Name = "DateEnd"
        Me.DateEnd.Size = New System.Drawing.Size(250, 27)
        Me.DateEnd.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(100, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 30)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Usuario"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'User
        '
        Me.User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.User.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User.Location = New System.Drawing.Point(180, 180)
        Me.User.MaxLength = 64
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(200, 25)
        Me.User.TabIndex = 77
        '
        'DataRange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(400, 260)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateEnd)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.WClose)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DataRange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataRange"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateStart As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Aceptar As Button
    Friend WithEvents DateEnd As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents User As TextBox
End Class
