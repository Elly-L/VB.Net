Public MustInherit Class shape
    Protected area, perimeter As Double

    Protected Overridable Sub print()
        Console.WriteLine("Area = " & area & "Perimeter = " & perimeter)
    End Sub
    Public MustOverride Sub get_dimension()
    Public MustOverride Sub compute_area()
    Public MustOverride Sub compute_perimeter()


End Class
