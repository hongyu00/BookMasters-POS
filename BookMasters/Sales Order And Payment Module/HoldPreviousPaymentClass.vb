Public Class HoldPreviousPaymentClass
    Dim paymentID As String = ""
    Dim prodCount As Integer = 0
    Dim productsList As New List(Of ProductClass)
    Dim totalProdCount As Integer = 0

    Dim memberID As String = ""
    Dim memberPoints As Integer
    Dim hasMember As Boolean = False
    Dim isNewMember As Boolean = False
    Dim isRenewMember As Boolean = False

    Dim voucherID As String = ""
    Dim voucherDiscountAmount As Decimal = 0
    Dim hasVoucher As Boolean = False

    Public Sub New()
    End Sub

    Public Sub New(paymentID As String, prodCount As Integer, productsList As List(Of ProductClass), totalProdCount As Integer, memberID As String, memberPoints As Integer, hasMember As Boolean, isNewMember As Boolean, isRenewMember As Boolean, voucherID As String, voucherDiscountAmount As Decimal, hasVoucher As Boolean)
        Me.paymentID = paymentID
        Me.prodCount = prodCount
        Me.productsList = productsList
        Me.totalProdCount = totalProdCount
        Me.memberID = memberID
        Me.memberPoints = memberPoints
        Me.hasMember = hasMember
        Me.isNewMember = isNewMember
        Me.isRenewMember = isRenewMember
        Me.voucherID = voucherID
        Me.voucherDiscountAmount = voucherDiscountAmount
        Me.hasVoucher = hasVoucher

    End Sub

    Public Property managePaymentID() As String
        Get
            Return paymentID
        End Get
        Set(ByVal value As String)
            paymentID = value
        End Set
    End Property

    Public Property manageProdCount() As Integer
        Get
            Return prodCount
        End Get
        Set(ByVal value As Integer)
            prodCount = value
        End Set
    End Property
    Public Property manageProductsList() As List(Of ProductClass)
        Get
            Return productsList
        End Get
        Set(ByVal value As List(Of ProductClass))
            productsList = value
        End Set
    End Property
    Public Property manageTotalProdCount() As Integer
        Get
            Return totalProdCount
        End Get
        Set(ByVal value As Integer)
            totalProdCount = value
        End Set
    End Property
    Public Property manageMemberID() As String
        Get
            Return memberID
        End Get
        Set(ByVal value As String)
            memberID = value
        End Set
    End Property
    Public Property manageMemberPoints() As Integer
        Get
            Return memberPoints
        End Get
        Set(ByVal value As Integer)
            memberPoints = value
        End Set
    End Property
    Public Property manageHasMember() As Boolean
        Get
            Return hasMember
        End Get
        Set(ByVal value As Boolean)
            hasMember = value
        End Set
    End Property
    Public Property manageIsNewMember() As Boolean
        Get
            Return isNewMember
        End Get
        Set(ByVal value As Boolean)
            isNewMember = value
        End Set
    End Property
    Public Property manageIsRenewMember() As Boolean
        Get
            Return isRenewMember
        End Get
        Set(ByVal value As Boolean)
            isRenewMember = value
        End Set
    End Property
    Public Property manageVoucherID() As String
        Get
            Return voucherID
        End Get
        Set(ByVal value As String)
            voucherID = value
        End Set
    End Property
    Public Property manageVoucherDiscountAmount() As Decimal
        Get
            Return voucherDiscountAmount
        End Get
        Set(ByVal value As Decimal)
            voucherDiscountAmount = value
        End Set
    End Property
    Public Property manageHasVoucher() As Boolean
        Get
            Return hasVoucher
        End Get
        Set(ByVal value As Boolean)
            hasVoucher = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
