
Public Class clsPuntoEspacial
#Region "AREA DE DATOS"
    '*******************************************************************
    ' Declaracion de los Atributos privados para encapsulamiento
    Private aCoordenadaX As Integer
    Private aCoordenadaY As Integer
    Private aCoordenadaZ As Integer

    ' Metodos Get y Set para manipulacion de datos de la clase
    ' CoordenadaX
    '*********************************************************
    Public Property CoordenadaX As Integer
        Get
            CoordenadaX = aCoordenadaX
        End Get
        Set(ByVal value As Integer)
            aCoordenadaX = value
        End Set
    End Property
    ' CoordenadaY
    '*********************************************************
    Public Property CoordenadaY As Integer
        Get
            CoordenadaY = aCoordenadaY
        End Get
        Set(ByVal value As Integer)
            aCoordenadaY = value
        End Set
    End Property
    ' CoordenadaZ
    '*********************************************************
    Public Property CoordenadaZ As Integer
        Get
            CoordenadaZ = aCoordenadaZ
        End Get
        Set(ByVal value As Integer)
            aCoordenadaZ = value
        End Set
    End Property
#End Region

#Region "AREA DE METODOS Y FUNCIONALIDAD"
    '*******************************************************************
    ' Metodo constructor y destructor de la clase
    ' Constructor
    Public Sub New()
        ' Que hacer al instanciar el objeto
        aCoordenadaX = 0
        aCoordenadaY = 0
        aCoordenadaZ = 0
    End Sub
    ' Constructor
    Public Sub New(ByVal x As Integer, ByVal y As Integer, ByVal z As Integer)
        ' Que hacer al instanciar el objeto
        aCoordenadaX = x
        aCoordenadaY = y
        aCoordenadaZ = z
    End Sub
    ' Destructor

    ' Metodos publicos para la funcionalidad de la clase
    ' Distancia Origen
    Public Function DistanciaOrigen() As Double
        DistanciaOrigen = Math.Sqrt((aCoordenadaX ^ 2) + (aCoordenadaY ^ 2) + (aCoordenadaZ ^ 2))
    End Function

#End Region

End Class
