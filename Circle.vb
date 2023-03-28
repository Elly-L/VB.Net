Public Class Circle
    Inherits Shape


    Private radius As Integer

    Public Overrides Sub get_dimension()
        Console.WriteLine("Enter the radius")
        radius = Console.ReadLine()
    End Sub

    Public Overrides Sub compute_area()
        area = Math.PI * Math.Pow(radius, 2)
    End Sub

    Public Overrides Sub compute_perimeter()
        perimeter = Math.PI * radius * 2
    End Sub
End Class
