Public Class Registro
    Public user As String
    Public tarifa As String
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'se establece la coneccion con la base de datos
        'TODO: esta línea de código carga datos en la tabla 'KWHDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.KWHDataSet.usuarios)
        'TODO: esta línea de código carga datos en la tabla 'KWHDataSet.estados' Puede moverla o quitarla según sea necesario.
        Me.EstadosTableAdapter.Fill(Me.KWHDataSet.estados)
        cboEstado.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim usuario, estado As String
        Try
            'se crean variablas para guardar al usuario y al estado donde recide
            usuario = txtUsuario.Text
            user = usuario
            estado = cboEstado.Text
            'se suben los datos a la base de datos de access y se muestra la siguiente pagina
            tarifa = EstadosTableAdapter.getTarifa(estado)
            UsuariosTableAdapter.insertUsuario(usuario, estado, tarifa)
            Me.Hide()
            Form1.Show()
        Catch EXCEPTION As InvalidCastException
            MsgBox("Recuerda que el nombre debe llevar letras y numeros")
        End Try
    End Sub

    Private Sub Registro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub EstadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EstadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KWHDataSet)

    End Sub
End Class