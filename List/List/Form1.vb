Public Class Form1

	Private colTfnos As List(Of CTelefono)
	Private cm As CurrencyManager

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		colTfnos = FactoriaCTelefono.ObtenerColeccionCTelefono()
		listTfnos.DataSource = colTfnos
		listTfnos.DisplayMember = "Nombre"
		ctTfnoSelec.DataBindings.Add("Text", colTfnos, "Telefono")
		cm = TryCast(listTfnos.BindingContext(colTfnos), CurrencyManager)

	End Sub

	Private Sub btAñadir_Click(sender As Object, e As EventArgs) Handles btAñadir.Click

		Dim tef As Decimal = 0

		If ctNombre.Text.Length <> 0 AndAlso ctTfno.Text.Length <> 0 AndAlso Decimal.TryParse(ctTfno.Text, tef) Then

			colTfnos.Add(FactoriaCTelefono.CrearCTelefono(ctNombre.Text, tef))
			cm.Position = cm.Count
			cm.Refresh()

		End If

	End Sub

	Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click



	End Sub

	Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click



	End Sub
End Class
