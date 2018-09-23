<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Altas
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Fecha_nacimientoLabel As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim DniLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim IdChoferLabel As System.Windows.Forms.Label
        Dim IdSociosLabel As System.Windows.Forms.Label
        Dim IdVehiculosLabel As System.Windows.Forms.Label
        Dim Fecha_origenLabel As System.Windows.Forms.Label
        Dim Fecha_destinoLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Altas))
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ChoferBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChoferBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_nacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NombreTextBox1 = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.DniTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.IdChoferTextBox = New System.Windows.Forms.TextBox()
        Me.IdSociosTextBox = New System.Windows.Forms.TextBox()
        Me.IdVehiculosTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_origenDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_destinoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.AñoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButagregarVehiculo = New System.Windows.Forms.Button()
        Me.ButtonEliminarVehioculo = New System.Windows.Forms.Button()
        Me.VehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New pruebaBD.Database1DataSet()
        Me.ViajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SociosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChoferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChoferTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ChoferTableAdapter()
        Me.TableAdapterManager = New pruebaBD.Database1DataSetTableAdapters.TableAdapterManager()
        Me.SociosTableAdapter = New pruebaBD.Database1DataSetTableAdapters.SociosTableAdapter()
        Me.ViajesTableAdapter = New pruebaBD.Database1DataSetTableAdapters.ViajesTableAdapter()
        Me.VehiculoTableAdapter = New pruebaBD.Database1DataSetTableAdapters.VehiculoTableAdapter()
        Me.ComboChofer = New System.Windows.Forms.ComboBox()
        Me.ComboSocios = New System.Windows.Forms.ComboBox()
        Me.ComboAuto = New System.Windows.Forms.ComboBox()
        NombreLabel = New System.Windows.Forms.Label()
        Fecha_nacimientoLabel = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        DniLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        IdChoferLabel = New System.Windows.Forms.Label()
        IdSociosLabel = New System.Windows.Forms.Label()
        IdVehiculosLabel = New System.Windows.Forms.Label()
        Fecha_origenLabel = New System.Windows.Forms.Label()
        Fecha_destinoLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        CType(Me.ChoferBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChoferBindingNavigator.SuspendLayout()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(38, 116)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 6
        NombreLabel.Text = "nombre:"
        '
        'Fecha_nacimientoLabel
        '
        Fecha_nacimientoLabel.AutoSize = True
        Fecha_nacimientoLabel.Location = New System.Drawing.Point(38, 143)
        Fecha_nacimientoLabel.Name = "Fecha_nacimientoLabel"
        Fecha_nacimientoLabel.Size = New System.Drawing.Size(91, 13)
        Fecha_nacimientoLabel.TabIndex = 8
        Fecha_nacimientoLabel.Text = "fecha nacimiento:"
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Location = New System.Drawing.Point(34, 347)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(45, 13)
        NombreLabel1.TabIndex = 12
        NombreLabel1.Text = "nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(34, 373)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(46, 13)
        ApellidoLabel.TabIndex = 14
        ApellidoLabel.Text = "apellido:"
        '
        'DniLabel
        '
        DniLabel.AutoSize = True
        DniLabel.Location = New System.Drawing.Point(34, 399)
        DniLabel.Name = "DniLabel"
        DniLabel.Size = New System.Drawing.Size(24, 13)
        DniLabel.TabIndex = 16
        DniLabel.Text = "dni:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(34, 425)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(53, 13)
        DireccionLabel.TabIndex = 18
        DireccionLabel.Text = "direccion:"
        '
        'IdChoferLabel
        '
        IdChoferLabel.AutoSize = True
        IdChoferLabel.Location = New System.Drawing.Point(1008, 97)
        IdChoferLabel.Name = "IdChoferLabel"
        IdChoferLabel.Size = New System.Drawing.Size(52, 13)
        IdChoferLabel.TabIndex = 22
        IdChoferLabel.Text = "id Chofer:"
        '
        'IdSociosLabel
        '
        IdSociosLabel.AutoSize = True
        IdSociosLabel.Location = New System.Drawing.Point(1006, 129)
        IdSociosLabel.Name = "IdSociosLabel"
        IdSociosLabel.Size = New System.Drawing.Size(53, 13)
        IdSociosLabel.TabIndex = 24
        IdSociosLabel.Text = "id Socios:"
        '
        'IdVehiculosLabel
        '
        IdVehiculosLabel.AutoSize = True
        IdVehiculosLabel.Location = New System.Drawing.Point(1008, 159)
        IdVehiculosLabel.Name = "IdVehiculosLabel"
        IdVehiculosLabel.Size = New System.Drawing.Size(67, 13)
        IdVehiculosLabel.TabIndex = 26
        IdVehiculosLabel.Text = "id Vehiculos:"
        '
        'Fecha_origenLabel
        '
        Fecha_origenLabel.AutoSize = True
        Fecha_origenLabel.Location = New System.Drawing.Point(1008, 192)
        Fecha_origenLabel.Name = "Fecha_origenLabel"
        Fecha_origenLabel.Size = New System.Drawing.Size(69, 13)
        Fecha_origenLabel.TabIndex = 28
        Fecha_origenLabel.Text = "fecha origen:"
        '
        'Fecha_destinoLabel
        '
        Fecha_destinoLabel.AutoSize = True
        Fecha_destinoLabel.Location = New System.Drawing.Point(1008, 218)
        Fecha_destinoLabel.Name = "Fecha_destinoLabel"
        Fecha_destinoLabel.Size = New System.Drawing.Size(74, 13)
        Fecha_destinoLabel.TabIndex = 30
        Fecha_destinoLabel.Text = "fecha destino:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(1008, 243)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 32
        TotalLabel.Text = "Total:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(139, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(37, 478)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1130, 313)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Agregar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ChoferBindingNavigator
        '
        Me.ChoferBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ChoferBindingNavigator.BindingSource = Me.ChoferBindingSource
        Me.ChoferBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ChoferBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ChoferBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ChoferBindingNavigatorSaveItem})
        Me.ChoferBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ChoferBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ChoferBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ChoferBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ChoferBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ChoferBindingNavigator.Name = "ChoferBindingNavigator"
        Me.ChoferBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ChoferBindingNavigator.Size = New System.Drawing.Size(1346, 25)
        Me.ChoferBindingNavigator.TabIndex = 3
        Me.ChoferBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ChoferBindingNavigatorSaveItem
        '
        Me.ChoferBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ChoferBindingNavigatorSaveItem.Image = CType(resources.GetObject("ChoferBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ChoferBindingNavigatorSaveItem.Name = "ChoferBindingNavigatorSaveItem"
        Me.ChoferBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ChoferBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChoferBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(135, 113)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreTextBox.TabIndex = 7
        '
        'Fecha_nacimientoDateTimePicker
        '
        Me.Fecha_nacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ChoferBindingSource, "fecha_nacimiento", True))
        Me.Fecha_nacimientoDateTimePicker.Location = New System.Drawing.Point(135, 139)
        Me.Fecha_nacimientoDateTimePicker.Name = "Fecha_nacimientoDateTimePicker"
        Me.Fecha_nacimientoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_nacimientoDateTimePicker.TabIndex = 9
        '
        'NombreTextBox1
        '
        Me.NombreTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "nombre", True))
        Me.NombreTextBox1.Location = New System.Drawing.Point(93, 344)
        Me.NombreTextBox1.Name = "NombreTextBox1"
        Me.NombreTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox1.TabIndex = 13
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(93, 370)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 15
        '
        'DniTextBox
        '
        Me.DniTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "dni", True))
        Me.DniTextBox.Location = New System.Drawing.Point(93, 396)
        Me.DniTextBox.Name = "DniTextBox"
        Me.DniTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DniTextBox.TabIndex = 17
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(93, 422)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 19
        '
        'IdChoferTextBox
        '
        Me.IdChoferTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "idChofer", True))
        Me.IdChoferTextBox.Location = New System.Drawing.Point(727, 94)
        Me.IdChoferTextBox.Name = "IdChoferTextBox"
        Me.IdChoferTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdChoferTextBox.TabIndex = 23
        '
        'IdSociosTextBox
        '
        Me.IdSociosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "idSocios", True))
        Me.IdSociosTextBox.Location = New System.Drawing.Point(727, 126)
        Me.IdSociosTextBox.Name = "IdSociosTextBox"
        Me.IdSociosTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdSociosTextBox.TabIndex = 25
        '
        'IdVehiculosTextBox
        '
        Me.IdVehiculosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "idVehiculos", True))
        Me.IdVehiculosTextBox.Location = New System.Drawing.Point(727, 156)
        Me.IdVehiculosTextBox.Name = "IdVehiculosTextBox"
        Me.IdVehiculosTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdVehiculosTextBox.TabIndex = 27
        '
        'Fecha_origenDateTimePicker
        '
        Me.Fecha_origenDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ViajesBindingSource, "fecha_origen", True))
        Me.Fecha_origenDateTimePicker.Location = New System.Drawing.Point(1088, 188)
        Me.Fecha_origenDateTimePicker.Name = "Fecha_origenDateTimePicker"
        Me.Fecha_origenDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_origenDateTimePicker.TabIndex = 29
        '
        'Fecha_destinoDateTimePicker
        '
        Me.Fecha_destinoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ViajesBindingSource, "fecha_destino", True))
        Me.Fecha_destinoDateTimePicker.Location = New System.Drawing.Point(1088, 214)
        Me.Fecha_destinoDateTimePicker.Name = "Fecha_destinoDateTimePicker"
        Me.Fecha_destinoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_destinoDateTimePicker.TabIndex = 31
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(1088, 240)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TotalTextBox.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Choferes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Socios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1127, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Viaje"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(250, 207)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(162, 478)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 38
        Me.Button5.Text = "Eliminar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.Location = New System.Drawing.Point(1031, 422)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(44, 13)
        ModeloLabel.TabIndex = 40
        ModeloLabel.Text = "modelo:"
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "modelo", True))
        Me.ModeloTextBox.Location = New System.Drawing.Point(1081, 419)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ModeloTextBox.TabIndex = 41
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(1031, 448)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(39, 13)
        MarcaLabel.TabIndex = 42
        MarcaLabel.Text = "marca:"
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(1081, 445)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MarcaTextBox.TabIndex = 43
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Location = New System.Drawing.Point(1031, 475)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(28, 13)
        AñoLabel.TabIndex = 44
        AñoLabel.Text = "año:"
        '
        'AñoDateTimePicker
        '
        Me.AñoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VehiculoBindingSource, "año", True))
        Me.AñoDateTimePicker.Location = New System.Drawing.Point(1081, 471)
        Me.AñoDateTimePicker.Name = "AñoDateTimePicker"
        Me.AñoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.AñoDateTimePicker.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1035, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "vehiculo"
        '
        'ButagregarVehiculo
        '
        Me.ButagregarVehiculo.Location = New System.Drawing.Point(1021, 555)
        Me.ButagregarVehiculo.Name = "ButagregarVehiculo"
        Me.ButagregarVehiculo.Size = New System.Drawing.Size(75, 23)
        Me.ButagregarVehiculo.TabIndex = 47
        Me.ButagregarVehiculo.Text = "agregar"
        Me.ButagregarVehiculo.UseVisualStyleBackColor = True
        '
        'ButtonEliminarVehioculo
        '
        Me.ButtonEliminarVehioculo.Location = New System.Drawing.Point(1183, 555)
        Me.ButtonEliminarVehioculo.Name = "ButtonEliminarVehioculo"
        Me.ButtonEliminarVehioculo.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminarVehioculo.TabIndex = 48
        Me.ButtonEliminarVehioculo.Text = "Eliminar"
        Me.ButtonEliminarVehioculo.UseVisualStyleBackColor = True
        '
        'VehiculoBindingSource
        '
        Me.VehiculoBindingSource.DataMember = "Vehiculo"
        Me.VehiculoBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViajesBindingSource
        '
        Me.ViajesBindingSource.DataMember = "Viajes"
        Me.ViajesBindingSource.DataSource = Me.Database1DataSet
        '
        'SociosBindingSource
        '
        Me.SociosBindingSource.DataMember = "Socios"
        Me.SociosBindingSource.DataSource = Me.Database1DataSet
        '
        'ChoferBindingSource
        '
        Me.ChoferBindingSource.DataMember = "Chofer"
        Me.ChoferBindingSource.DataSource = Me.Database1DataSet
        '
        'ChoferTableAdapter
        '
        Me.ChoferTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChoferTableAdapter = Me.ChoferTableAdapter
        Me.TableAdapterManager.SociosTableAdapter = Me.SociosTableAdapter
        Me.TableAdapterManager.UpdateOrder = pruebaBD.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VehiculoTableAdapter = Nothing
        Me.TableAdapterManager.ViajesTableAdapter = Me.ViajesTableAdapter
        '
        'SociosTableAdapter
        '
        Me.SociosTableAdapter.ClearBeforeFill = True
        '
        'ViajesTableAdapter
        '
        Me.ViajesTableAdapter.ClearBeforeFill = True
        '
        'VehiculoTableAdapter
        '
        Me.VehiculoTableAdapter.ClearBeforeFill = True
        '
        'ComboChofer
        '
        Me.ComboChofer.FormattingEnabled = True
        Me.ComboChofer.Location = New System.Drawing.Point(1088, 94)
        Me.ComboChofer.Name = "ComboChofer"
        Me.ComboChofer.Size = New System.Drawing.Size(200, 21)
        Me.ComboChofer.TabIndex = 49
        '
        'ComboSocios
        '
        Me.ComboSocios.FormattingEnabled = True
        Me.ComboSocios.Location = New System.Drawing.Point(1088, 124)
        Me.ComboSocios.Name = "ComboSocios"
        Me.ComboSocios.Size = New System.Drawing.Size(200, 21)
        Me.ComboSocios.TabIndex = 50
        '
        'ComboAuto
        '
        Me.ComboAuto.FormattingEnabled = True
        Me.ComboAuto.Location = New System.Drawing.Point(1088, 151)
        Me.ComboAuto.Name = "ComboAuto"
        Me.ComboAuto.Size = New System.Drawing.Size(200, 21)
        Me.ComboAuto.TabIndex = 51
        '
        'Altas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1346, 616)
        Me.Controls.Add(Me.ComboAuto)
        Me.Controls.Add(Me.ComboSocios)
        Me.Controls.Add(Me.ComboChofer)
        Me.Controls.Add(Me.ButtonEliminarVehioculo)
        Me.Controls.Add(Me.ButagregarVehiculo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(Me.MarcaTextBox)
        Me.Controls.Add(AñoLabel)
        Me.Controls.Add(Me.AñoDateTimePicker)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IdChoferLabel)
        Me.Controls.Add(Me.IdChoferTextBox)
        Me.Controls.Add(IdSociosLabel)
        Me.Controls.Add(Me.IdSociosTextBox)
        Me.Controls.Add(IdVehiculosLabel)
        Me.Controls.Add(Me.IdVehiculosTextBox)
        Me.Controls.Add(Fecha_origenLabel)
        Me.Controls.Add(Me.Fecha_origenDateTimePicker)
        Me.Controls.Add(Fecha_destinoLabel)
        Me.Controls.Add(Me.Fecha_destinoDateTimePicker)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(NombreLabel1)
        Me.Controls.Add(Me.NombreTextBox1)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(DniLabel)
        Me.Controls.Add(Me.DniTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Fecha_nacimientoLabel)
        Me.Controls.Add(Me.Fecha_nacimientoDateTimePicker)
        Me.Controls.Add(Me.ChoferBindingNavigator)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Altas"
        Me.Text = "Altas"
        CType(Me.ChoferBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChoferBindingNavigator.ResumeLayout(False)
        Me.ChoferBindingNavigator.PerformLayout()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Database1DataSet As pruebaBD.Database1DataSet
    Friend WithEvents ChoferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChoferTableAdapter As pruebaBD.Database1DataSetTableAdapters.ChoferTableAdapter
    Friend WithEvents TableAdapterManager As pruebaBD.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ChoferBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ChoferBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_nacimientoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SociosTableAdapter As pruebaBD.Database1DataSetTableAdapters.SociosTableAdapter
    Friend WithEvents SociosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViajesTableAdapter As pruebaBD.Database1DataSetTableAdapters.ViajesTableAdapter
    Friend WithEvents NombreTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DniTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ViajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdChoferTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdSociosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdVehiculosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_origenDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_destinoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents VehiculoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehiculoTableAdapter As pruebaBD.Database1DataSetTableAdapters.VehiculoTableAdapter
    Friend WithEvents ModeloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AñoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButagregarVehiculo As System.Windows.Forms.Button
    Friend WithEvents ButtonEliminarVehioculo As System.Windows.Forms.Button
    Friend WithEvents ComboChofer As System.Windows.Forms.ComboBox
    Friend WithEvents ComboSocios As System.Windows.Forms.ComboBox
    Friend WithEvents ComboAuto As System.Windows.Forms.ComboBox
End Class
