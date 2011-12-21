Public Class Plotic
    Private strGunName As String
    Private bmpImage As Bitmap
    Private grhGraphic As Graphics

    Private dblRecoilUp As Double
    Private dblRecoilRight As Double
    Private dblRecoilLeft As Double
    Private dblSpreadMin As Double
    Private dblSpreadInc As Double
    Private dblAdjRecoilH As Double
    Private dblAdjRecoilV As Double
    Private dblAdjSpreadMin As Double
    Private dblAdjSpreadInc As Double
    Private intBurst As Integer
    Private intBulletsPerBurst As Integer
    Private dblFirstShot As Double

    Property GunName() As String
        Get
            Return strGunName
        End Get
        Set(ByVal Value As String)
            strGunName = Value
        End Set
    End Property


    Property RecoilUp() As Double
        Get
            Return dblRecoilUp
        End Get
        Set(ByVal Value As Double)
            dblRecoilUp = Value
        End Set
    End Property
    Property RecoilRight() As Double
        Get
            Return dblRecoilRight
        End Get
        Set(ByVal Value As Double)
            dblRecoilRight = Value
        End Set
    End Property
    Property RecoilLeft() As Double
        Get
            Return dblRecoilLeft
        End Get
        Set(ByVal Value As Double)
            dblRecoilLeft = Value
        End Set
    End Property
    Property SpreadMin() As Double
        Get
            Return dblSpreadMin
        End Get
        Set(ByVal Value As Double)
            dblSpreadMin = Value
        End Set
    End Property
    Property SpreadInc() As Double
        Get
            Return dblSpreadInc
        End Get
        Set(ByVal Value As Double)
            dblSpreadInc = Value
        End Set
    End Property
    Property AdjRecoilH() As Double
        Get
            Return dblAdjRecoilH
        End Get
        Set(ByVal Value As Double)
            dblAdjRecoilH = Value
        End Set
    End Property
    Property AdjRecoilV() As Double
        Get
            Return dblAdjRecoilV
        End Get
        Set(ByVal Value As Double)
            dblAdjRecoilV = Value
        End Set
    End Property
    Property AdjSpreadMin() As Double
        Get
            Return dblAdjSpreadMin
        End Get
        Set(ByVal Value As Double)
            dblAdjSpreadMin = Value
        End Set
    End Property
    Property AdjSpreadInc() As Double
        Get
            Return dblAdjSpreadInc
        End Get
        Set(ByVal Value As Double)
            dblAdjSpreadInc = Value
        End Set
    End Property
    Property FirstShot() As Double
        Get
            Return dblFirstShot
        End Get
        Set(ByVal Value As Double)
            dblFirstShot = Value
        End Set
    End Property
    Property Burst() As Integer
        Get
            Return intBurst
        End Get
        Set(ByVal Value As Integer)
            intBurst = Value
        End Set
    End Property
    Property BulletsPerBurst() As Integer
        Get
            Return intBulletsPerBurst
        End Get
        Set(ByVal Value As Integer)
            intBulletsPerBurst = Value
        End Set
    End Property
    Property Image() As Bitmap
        Get
            Return bmpImage
        End Get
        Set(ByVal Value As Bitmap)
            bmpImage = Value
        End Set
    End Property
    Property Graphic() As Graphics
        Get
            Return grhGraphic
        End Get
        Set(ByVal Value As Graphics)
            grhGraphic = Value
        End Set
    End Property

    Public Sub New()
        Dim b As Bitmap = New Bitmap(2000, 2000)
        Dim g As Graphics = Graphics.FromImage(b)
        Me.Image = b
        Me.grhGraphic = g
    End Sub
End Class
