<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Me.WMinimize = New System.Windows.Forms.Button()
        Me.WClose = New System.Windows.Forms.Button()
        Me.Analizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Seleccionar = New System.Windows.Forms.Button()
        Me.Ruta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FolderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Progreso_Etiqueta = New System.Windows.Forms.Label()
        Me.Progreso_Fondo = New System.Windows.Forms.Label()
        Me.Progreso = New System.Windows.Forms.Label()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Precio_CopyFullSingle = New System.Windows.Forms.TextBox()
        Me.Precio_CopyBlackSingle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Precio_PrintBlackSimple = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Precio_PrintFullSingle = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Precio_Scan = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Precio_CopyFullDuplex = New System.Windows.Forms.TextBox()
        Me.Precio_CopyBlackDuplex = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Precio_PrintFullDuplex = New System.Windows.Forms.TextBox()
        Me.Precio_PrintBlackDuplex = New System.Windows.Forms.TextBox()
        Me.AnalizarContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AnalisisSharpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.AnalizarContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'WMinimize
        '
        Me.WMinimize.BackColor = System.Drawing.Color.Transparent
        Me.WMinimize.FlatAppearance.BorderSize = 0
        Me.WMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.WMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WMinimize.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WMinimize.ForeColor = System.Drawing.Color.White
        Me.WMinimize.Location = New System.Drawing.Point(710, 0)
        Me.WMinimize.Name = "WMinimize"
        Me.WMinimize.Size = New System.Drawing.Size(40, 30)
        Me.WMinimize.TabIndex = 9
        Me.WMinimize.TabStop = False
        Me.WMinimize.Text = "_"
        Me.WMinimize.UseVisualStyleBackColor = False
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
        Me.WClose.Location = New System.Drawing.Point(750, 0)
        Me.WClose.Name = "WClose"
        Me.WClose.Size = New System.Drawing.Size(50, 30)
        Me.WClose.TabIndex = 10
        Me.WClose.TabStop = False
        Me.WClose.Text = "X"
        Me.WClose.UseVisualStyleBackColor = False
        '
        'Analizar
        '
        Me.Analizar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Analizar.FlatAppearance.BorderSize = 2
        Me.Analizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Analizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Analizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Analizar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Analizar.ForeColor = System.Drawing.Color.White
        Me.Analizar.Location = New System.Drawing.Point(630, 350)
        Me.Analizar.Name = "Analizar"
        Me.Analizar.Size = New System.Drawing.Size(130, 40)
        Me.Analizar.TabIndex = 11
        Me.Analizar.Text = "Analizar"
        Me.Analizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(50, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 40)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Printer Analyst"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(80, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 30)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Por favor, escoge tu directorio de análisis"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Seleccionar
        '
        Me.Seleccionar.BackColor = System.Drawing.Color.Transparent
        Me.Seleccionar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Seleccionar.FlatAppearance.BorderSize = 2
        Me.Seleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Seleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Seleccionar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seleccionar.ForeColor = System.Drawing.Color.White
        Me.Seleccionar.Location = New System.Drawing.Point(660, 132)
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Size = New System.Drawing.Size(100, 30)
        Me.Seleccionar.TabIndex = 18
        Me.Seleccionar.Text = "Seleccionar"
        Me.Seleccionar.UseVisualStyleBackColor = False
        '
        'Ruta
        '
        Me.Ruta.BackColor = System.Drawing.Color.Silver
        Me.Ruta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ruta.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ruta.Location = New System.Drawing.Point(380, 135)
        Me.Ruta.MaxLength = 24
        Me.Ruta.Name = "Ruta"
        Me.Ruta.ReadOnly = True
        Me.Ruta.Size = New System.Drawing.Size(268, 25)
        Me.Ruta.TabIndex = 17
        Me.Ruta.Text = "[Vacio]"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(80, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(639, 109)
        Me.Label3.TabIndex = 55
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Progreso_Etiqueta
        '
        Me.Progreso_Etiqueta.BackColor = System.Drawing.Color.Transparent
        Me.Progreso_Etiqueta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Progreso_Etiqueta.ForeColor = System.Drawing.Color.White
        Me.Progreso_Etiqueta.Location = New System.Drawing.Point(50, 355)
        Me.Progreso_Etiqueta.Name = "Progreso_Etiqueta"
        Me.Progreso_Etiqueta.Size = New System.Drawing.Size(120, 30)
        Me.Progreso_Etiqueta.TabIndex = 56
        Me.Progreso_Etiqueta.Text = "Procesando..."
        Me.Progreso_Etiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Progreso_Etiqueta.Visible = False
        '
        'Progreso_Fondo
        '
        Me.Progreso_Fondo.BackColor = System.Drawing.Color.White
        Me.Progreso_Fondo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Progreso_Fondo.ForeColor = System.Drawing.Color.White
        Me.Progreso_Fondo.Location = New System.Drawing.Point(180, 360)
        Me.Progreso_Fondo.Name = "Progreso_Fondo"
        Me.Progreso_Fondo.Size = New System.Drawing.Size(430, 20)
        Me.Progreso_Fondo.TabIndex = 57
        Me.Progreso_Fondo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Progreso_Fondo.Visible = False
        '
        'Progreso
        '
        Me.Progreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Progreso.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Progreso.ForeColor = System.Drawing.Color.White
        Me.Progreso.Location = New System.Drawing.Point(180, 360)
        Me.Progreso.Name = "Progreso"
        Me.Progreso.Size = New System.Drawing.Size(137, 20)
        Me.Progreso.TabIndex = 58
        Me.Progreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Progreso.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(90, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 25)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Copia Full Color"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(80, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 30)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Precios"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Precio_CopyFullSingle
        '
        Me.Precio_CopyFullSingle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Precio_CopyFullSingle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Precio_CopyFullSingle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio_CopyFullSingle.Location = New System.Drawing.Point(200, 240)
        Me.Precio_CopyFullSingle.MaxLength = 64
        Me.Precio_CopyFullSingle.Name = "Precio_CopyFullSingle"
        Me.Precio_CopyFullSingle.Size = New System.Drawing.Size(50, 25)
        Me.Precio_CopyFullSingle.TabIndex = 62
        Me.Precio_CopyFullSingle.Text = "0"
        '
        'Precio_CopyBlackSingle
        '
        Me.Precio_CopyBlackSingle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Precio_CopyBlackSingle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Precio_CopyBlackSingle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio_CopyBlackSingle.Location = New System.Drawing.Point(200, 270)
        Me.Precio_CopyBlackSingle.MaxLength = 64
        Me.Precio_CopyBlackSingle.Name = "Precio_CopyBlackSingle"
        Me.Precio_CopyBlackSingle.Size = New System.Drawing.Size(50, 25)
        Me.Precio_CopyBlackSingle.TabIndex = 66
        Me.Precio_CopyBlackSingle.Text = "0"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(90, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 25)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Copia Negro"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Precio_PrintBlackSimple
        '
        Me.Precio_PrintBlackSimple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Precio_PrintBlackSimple.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Precio_PrintBlackSimple.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio_PrintBlackSimple.Location = New System.Drawing.Point(450, 270)
        Me.Precio_PrintBlackSimple.MaxLength = 64
        Me.Precio_PrintBlackSimple.Name = "Precio_PrintBlackSimple"
        Me.Precio_PrintBlackSimple.Size = New System.Drawing.Size(50, 25)
        Me.Precio_PrintBlackSimple.TabIndex = 72
        Me.Precio_PrintBlackSimple.Text = "0"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(320, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 25)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Impresión Negro"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Precio_PrintFullSingle
        '
        Me.Precio_PrintFullSingle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Precio_PrintFullSingle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Precio_PrintFullSingle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio_PrintFullSingle.Location = New System.Drawing.Point(450, 240)
        Me.Precio_PrintFullSingle.MaxLength = 64
        Me.Precio_PrintFullSingle.Name = "Precio_PrintFullSingle"
        Me.Precio_PrintFullSingle.Size = New System.Drawing.Size(50, 25)
        Me.Precio_PrintFullSingle.TabIndex = 68
        Me.Precio_PrintFullSingle.Text = "0"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(320, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 25)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Impresión Full Color"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Precio_Scan
        '
        Me.Precio_Scan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Precio_Scan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Precio_Scan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio_Scan.Location = New System.Drawing.Point(640, 240)
        Me.Precio_Scan.MaxLength = 64
        Me.Precio_Scan.Name = "Precio_Scan"
        Me.Precio_Scan.Size = New System.Drawing.Size(50, 25)
        Me.Precio_Scan.TabIndex = 74
        Me.Precio_Scan.Text = "0"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(580, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 25)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Escaner"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(200, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 25)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Simple"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(250, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 25)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Doble"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Precio_CopyFullDuplex
        '
        Me.Precio_CopyFullDuplex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Precio_CopyFullDuplex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Precio_CopyFullDuplex.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio_CopyFullDuplex.Location = New System.Drawing.Point(250, 240)
        Me.Precio_CopyFullDuplex.MaxLength = 64
        Me.Precio_CopyFullDuplex.Name = "Precio_CopyFullDuplex"
        Me.Precio_CopyFullDuplex.Size = New System.Drawing.Size(50, 25)
        Me.Precio_CopyFullDuplex.TabIndex = 76
        Me.Precio_CopyFullDuplex.Text = "0"
        '
        'Precio_CopyBlackDuplex
        '
        Me.Precio_CopyBlackDuplex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Precio_CopyBlackDuplex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Precio_CopyBlackDuplex.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio_CopyBlackDuplex.Location = New System.Drawing.Point(250, 270)
        Me.Precio_CopyBlackDuplex.MaxLength = 64
        Me.Precio_CopyBlackDuplex.Name = "Precio_CopyBlackDuplex"
        Me.Precio_CopyBlackDuplex.Size = New System.Drawing.Size(50, 25)
        Me.Precio_CopyBlackDuplex.TabIndex = 77
        Me.Precio_CopyBlackDuplex.Text = "0"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(500, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 25)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Doble"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(450, 210)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 25)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "Simple"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Precio_PrintFullDuplex
        '
        Me.Precio_PrintFullDuplex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Precio_PrintFullDuplex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Precio_PrintFullDuplex.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio_PrintFullDuplex.Location = New System.Drawing.Point(500, 240)
        Me.Precio_PrintFullDuplex.MaxLength = 64
        Me.Precio_PrintFullDuplex.Name = "Precio_PrintFullDuplex"
        Me.Precio_PrintFullDuplex.Size = New System.Drawing.Size(50, 25)
        Me.Precio_PrintFullDuplex.TabIndex = 80
        Me.Precio_PrintFullDuplex.Text = "0"
        '
        'Precio_PrintBlackDuplex
        '
        Me.Precio_PrintBlackDuplex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Precio_PrintBlackDuplex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Precio_PrintBlackDuplex.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio_PrintBlackDuplex.Location = New System.Drawing.Point(500, 270)
        Me.Precio_PrintBlackDuplex.MaxLength = 64
        Me.Precio_PrintBlackDuplex.Name = "Precio_PrintBlackDuplex"
        Me.Precio_PrintBlackDuplex.Size = New System.Drawing.Size(50, 25)
        Me.Precio_PrintBlackDuplex.TabIndex = 81
        Me.Precio_PrintBlackDuplex.Text = "0"
        '
        'AnalizarContextMenu
        '
        Me.AnalizarContextMenu.BackColor = System.Drawing.Color.White
        Me.AnalizarContextMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalizarContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnalisisSharpToolStripMenuItem})
        Me.AnalizarContextMenu.Name = "AnalizarContextMenu"
        Me.AnalizarContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.AnalizarContextMenu.ShowImageMargin = False
        Me.AnalizarContextMenu.Size = New System.Drawing.Size(192, 48)
        '
        'AnalisisSharpToolStripMenuItem
        '
        Me.AnalisisSharpToolStripMenuItem.Name = "AnalisisSharpToolStripMenuItem"
        Me.AnalisisSharpToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AnalisisSharpToolStripMenuItem.Text = "Análisis Individual Sharp"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 427)
        Me.Controls.Add(Me.Precio_PrintBlackDuplex)
        Me.Controls.Add(Me.Precio_PrintFullDuplex)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Precio_CopyBlackDuplex)
        Me.Controls.Add(Me.Precio_CopyFullDuplex)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Precio_Scan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Precio_PrintBlackSimple)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Precio_PrintFullSingle)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Precio_CopyBlackSingle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Precio_CopyFullSingle)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Progreso)
        Me.Controls.Add(Me.Progreso_Fondo)
        Me.Controls.Add(Me.Progreso_Etiqueta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Seleccionar)
        Me.Controls.Add(Me.Ruta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Analizar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WMinimize)
        Me.Controls.Add(Me.WClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.AnalizarContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WMinimize As Button
    Friend WithEvents WClose As Button
    Friend WithEvents Analizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Seleccionar As Button
    Friend WithEvents Ruta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FolderDialog As FolderBrowserDialog
    Friend WithEvents Progreso_Etiqueta As Label
    Friend WithEvents Progreso_Fondo As Label
    Friend WithEvents Progreso As Label
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Precio_CopyFullSingle As TextBox
    Friend WithEvents Precio_CopyBlackSingle As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Precio_PrintBlackSimple As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Precio_PrintFullSingle As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Precio_Scan As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Precio_CopyFullDuplex As TextBox
    Friend WithEvents Precio_CopyBlackDuplex As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Precio_PrintFullDuplex As TextBox
    Friend WithEvents Precio_PrintBlackDuplex As TextBox
    Friend WithEvents AnalizarContextMenu As ContextMenuStrip
    Friend WithEvents AnalisisSharpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
