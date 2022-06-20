Public Class ProductClass
    Dim prodID As String
    Dim prodName As String
    Dim prodQuantity As Integer
    Dim prodOriginalPrice As Decimal
    Dim prodDiscountPrice As Decimal
    Dim hasDiscount As Integer

    Public Sub New()
        prodID = ""
        prodName = ""
        prodQuantity = 0
        prodOriginalPrice = 0
        prodDiscountPrice = 0
        hasDiscount = 0
    End Sub

    Public Sub New(ByVal newProdID As String, ByVal newProdName As String, ByVal newProdQuantity As Integer, ByVal newProdOriginalPrice As Decimal, ByVal newProdDiscountPrice As Decimal, ByVal newHasDiscount As Integer)
        prodID = newProdID
        prodName = newProdName
        prodQuantity = newProdQuantity
        prodOriginalPrice = newProdOriginalPrice
        prodDiscountPrice = newProdDiscountPrice
        hasDiscount = newHasDiscount

    End Sub

    Public Property ManageProdID() As String
        Get
            Return prodID
        End Get
        Set(value As String)
            prodID = value
        End Set
    End Property

    Public Property ManageProdName() As String
        Get
            Return prodName
        End Get
        Set(value As String)
            prodName = value
        End Set
    End Property
    Public Property ManageProdQuantity() As Integer
        Get
            Return prodQuantity
        End Get
        Set(value As Integer)
            prodQuantity = value
        End Set
    End Property
    Public Property ManageProdOriginalPrice() As Decimal
        Get
            Return prodOriginalPrice
        End Get
        Set(value As Decimal)
            prodOriginalPrice = value
        End Set
    End Property
    Public Property ManageProdDiscountPrice() As Decimal
        Get
            Return prodDiscountPrice
        End Get
        Set(value As Decimal)
            prodDiscountPrice = value
        End Set
    End Property

    Public Property ManageHasDiscount() As Integer
        Get
            Return hasDiscount
        End Get
        Set(value As Integer)
            hasDiscount = value
        End Set
    End Property


End Class
