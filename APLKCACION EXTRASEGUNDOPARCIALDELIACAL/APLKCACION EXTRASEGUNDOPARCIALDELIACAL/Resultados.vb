Public Class Resultados
    Private Sub Resultados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub Resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KWHDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.KWHDataSet.usuarios)
        Dim pago = UsuariosTableAdapter.selectPagoNormal(Registro.user)
        If (pago < 750) Then
            txtTipoConsumo.Text = "bajo"
        ElseIf (pago >= 750 And pago < 1250) Then
            txtTipoConsumo.Text = "bajo"
        Else
            txtTipoConsumo.Text = "alto"
        End If
    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KWHDataSet)

    End Sub
End Class