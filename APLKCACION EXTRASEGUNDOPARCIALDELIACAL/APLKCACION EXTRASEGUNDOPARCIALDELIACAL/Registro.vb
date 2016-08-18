Public Class Registro
    Public user As String

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KWHDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.KWHDataSet.usuarios)
        'TODO: esta línea de código carga datos en la tabla 'KWHDataSet.estados' Puede moverla o quitarla según sea necesario.
        Me.EstadosTableAdapter.Fill(Me.KWHDataSet.estados)
        cboEstado.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim usuario, estado, tarifa As String
        Try
            'se crean variablas para guardar al usuario y al esado donde recide
            usuario = txtUsuario.Text
            user = usuario
            estado = cboEstado.Text
            tarifa = EstadosTableAdapter.getTarifa(estado)
            UsuariosTableAdapter.insertUsuario(usuario, estado, tarifa)
            Me.Hide()
            Form1.Show()
        Catch EXCEPTION As InvalidCastException
            MsgBox("Recuerda que el nombre debe llevar letras")
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