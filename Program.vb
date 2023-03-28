Imports System

Module Program
    Sub Main(args As String())
        Dim circ As Circle = New Circle
        circ.get_dimension()
        circ.compute_area()
        circ.compute_perimeter()
    End Sub
End Module
