<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.KWHDataSet = New APLKCACION_EXTRASEGUNDOPARCIALDELIACAL.KWHDataSet()
        Me.EstadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadosTableAdapter = New APLKCACION_EXTRASEGUNDOPARCIALDELIACAL.KWHDataSetTableAdapters.estadosTableAdapter()
        Me.TableAdapterManager = New APLKCACION_EXTRASEGUNDOPARCIALDELIACAL.KWHDataSetTableAdapters.TableAdapterManager()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New APLKCACION_EXTRASEGUNDOPARCIALDELIACAL.KWHDataSetTableAdapters.usuariosTableAdapter()
        CType(Me.KWHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(54, 15)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(179, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Estado"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Registrar y Continuar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cboEstado
        '
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "Chiapas", "Chihuahua", "Coahuila", "Colima", "Distrito Federal", "Durango", "Estado de México", "Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "Michoacán", "Morelos", "Nayarit", "Nuevo León", "Oaxaca", "Puebla", "Querétaro", "Quintana Roo", "San Luis Potosí", "Sinaloa", "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz", "Yucatán", "Zacatecas"})
        Me.cboEstado.Location = New System.Drawing.Point(55, 41)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(178, 21)
        Me.cboEstado.TabIndex = 6
        '
        'KWHDataSet
        '
        Me.KWHDataSet.DataSetName = "KWHDataSet"
        Me.KWHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstadosBindingSource
        '
        Me.EstadosBindingSource.DataMember = "estados"
        Me.EstadosBindingSource.DataSource = Me.KWHDataSet
        '
        'EstadosTableAdapter
        '
        Me.EstadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.costosTableAdapter = Nothing
        Me.TableAdapterManager.estadosTableAdapter = Me.EstadosTableAdapter
        Me.TableAdapterManager.KWHTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = APLKCACION_EXTRASEGUNDOPARCIALDELIACAL.KWHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.KWHDataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 113)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Name = "Registro"
        Me.Text = "Registro"
        CType(Me.KWHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents KWHDataSet As KWHDataSet
    Friend WithEvents EstadosBindingSource As BindingSource
    Friend WithEvents EstadosTableAdapter As KWHDataSetTableAdapters.estadosTableAdapter
    Friend WithEvents TableAdapterManager As KWHDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuariosTableAdapter As KWHDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents UsuariosBindingSource As BindingSource
End Class
