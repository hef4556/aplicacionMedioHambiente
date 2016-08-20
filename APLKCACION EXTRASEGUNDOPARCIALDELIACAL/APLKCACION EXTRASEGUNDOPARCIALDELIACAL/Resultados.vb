Public Class Resultados
    Private Sub Resultados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub Resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Coneccion con la base de datos de access
        'TODO: esta línea de código carga datos en la tabla 'KWHDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.KWHDataSet.usuarios)
        'se Carga la pagina y se le indica al usuario en la parte superior si su tipo de consumo es Bajo, medio o alto
        Dim pago = UsuariosTableAdapter.selectPagoNormal(Registro.user)
        If (pago < 750) Then
            txtTipoConsumo.Text = "bajo"
        ElseIf (pago >= 750 And pago < 1250) Then
            txtTipoConsumo.Text = "uso medio"
        Else
            txtTipoConsumo.Text = "alto"
        End If
    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KWHDataSet)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Se crean variables y se llenan para saber los datos con cuales trabajar
            'se obtiene el pago que normalmente realiza el usuario para despues hacer el descuento
            Dim pago = UsuariosTableAdapter.selectPagoNormal(Registro.user)
            Dim descuento As Double
            'Se calcula el descuento a aplicar por la media que genera el panel solar por un mes con sol
            descuento = TextBox1.Text * 30
            'se le avisa del ahorro total al usuario
            MsgBox("Se generaria un descuento de $" + descuento.ToString + " si se usaran los paneles indicados")
            Dim pr = pago - descuento
            'Despuyes se agregan dichos datos a la base de datos de access
            UsuariosTableAdapter.updateReducido(pr, Registro.user)
            Me.UsuariosTableAdapter.Fill(Me.KWHDataSet.usuarios)
        Catch ex As Exception
            MsgBox("Porfavor ingresa numeros enteros ..." + ex.Message)
        End Try

    End Sub

    Private Sub UsuariosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsuariosDataGridView.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'se obtiene el precio que generan los focos prendidos
        Dim focosNormales = 60 * Form1.focos
        'despues se le resta este precio a el pago normal para despues generar el pago por descuento con los focos ahorradores
        Dim pn = UsuariosTableAdapter.selectPagoNormal(Registro.user)
        Dim pr = pn - focosNormales
        pr = pr + Form1.focos * 20
        'se actualiza la tabla con los nuevos datos
        UsuariosTableAdapter.updateReducido(pr, Registro.user)
        'se le avisa al usuario de cuanto ha sido su nuevo ahorro
        Dim descuento = Form1.focos * 20
        Me.UsuariosTableAdapter.Fill(Me.KWHDataSet.usuarios)
        MsgBox("El uso de focos led reduciria tu cuenta hasta " + descuento.ToString + " pesos")
    End Sub
End Class