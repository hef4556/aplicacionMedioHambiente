<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resultados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Resultados))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTipoConsumo = New System.Windows.Forms.TextBox()
        Me.UsuariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KWHDataSet = New APLKCACION_EXTRASEGUNDOPARCIALDELIACAL.KWHDataSet()
        Me.UsuariosTableAdapter = New APLKCACION_EXTRASEGUNDOPARCIALDELIACAL.KWHDataSetTableAdapters.usuariosTableAdapter()
        Me.TableAdapterManager = New APLKCACION_EXTRASEGUNDOPARCIALDELIACAL.KWHDataSetTableAdapters.TableAdapterManager()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KWHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tu tipo de Consumo es: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(605, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'txtTipoConsumo
        '
        Me.txtTipoConsumo.Enabled = False
        Me.txtTipoConsumo.Location = New System.Drawing.Point(140, 17)
        Me.txtTipoConsumo.Name = "txtTipoConsumo"
        Me.txtTipoConsumo.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoConsumo.TabIndex = 2
        '
        'UsuariosDataGridView
        '
        Me.UsuariosDataGridView.AutoGenerateColumns = False
        Me.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.UsuariosDataGridView.DataSource = Me.UsuariosBindingSource
        Me.UsuariosDataGridView.Location = New System.Drawing.Point(15, 97)
        Me.UsuariosDataGridView.Name = "UsuariosDataGridView"
        Me.UsuariosDataGridView.Size = New System.Drawing.Size(542, 220)
        Me.UsuariosDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn3.HeaderText = "estado"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "tipoCuota"
        Me.DataGridViewTextBoxColumn4.HeaderText = "tipoCuota"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "pagoNormal"
        Me.DataGridViewTextBoxColumn5.HeaderText = "pagoNormal"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "pagoReducido"
        Me.DataGridViewTextBoxColumn6.HeaderText = "pagoReducido"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.KWHDataSet
        '
        'KWHDataSet
        '
        Me.KWHDataSet.DataSetName = "KWHDataSet"
        Me.KWHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.costosTableAdapter = Nothing
        Me.TableAdapterManager.estadosTableAdapter = Nothing
        Me.TableAdapterManager.KWHTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = APLKCACION_EXTRASEGUNDOPARCIALDELIACAL.KWHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'Resultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(671, 339)
        Me.Controls.Add(Me.UsuariosDataGridView)
        Me.Controls.Add(Me.txtTipoConsumo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Resultados"
        Me.Text = "Resultados"
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KWHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTipoConsumo As TextBox
    Friend WithEvents KWHDataSet As KWHDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As KWHDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents TableAdapterManager As KWHDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuariosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
