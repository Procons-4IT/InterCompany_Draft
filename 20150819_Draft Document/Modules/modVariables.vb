Public Module modVariables

    Public oApplication As clsListener
    Public strSQL As String
    Public cfl_Text As String
    Public cfl_Btn As String

    Public CompanyDecimalSeprator As String
    Public CompanyThousandSeprator As String
    Public strCardCode As String = ""
    Public blnDraft As Boolean = False
    Public blnError As Boolean = False
    Public strDocEntry As String

    Public Enum ValidationResult As Integer
        CANCEL = 0
        OK = 1
    End Enum

    Public Enum DocumentType As Integer
        RENTAL_QUOTATION = 1
        RENTAL_ORDER
        RENTAL_RETURN
    End Enum

    Public Const frm_WAREHOUSES As Integer = 62

    Public Const frm_StockRequest As String = "frm_StRequest"
    Public Const frm_InvSO As String = "frm_InvSO"
    Public Const frm_Warehouse As String = "62"
    Public Const frm_SalesOrder As String = "139"
    Public Const frm_Invoice As String = "133"
  
    Public Const mnu_FIND As String = "1281"
    Public Const mnu_ADD As String = "1282"
    Public Const mnu_CLOSE As String = "1286"
    Public Const mnu_NEXT As String = "1288"
    Public Const mnu_PREVIOUS As String = "1289"
    Public Const mnu_FIRST As String = "1290"
    Public Const mnu_LAST As String = "1291"
    Public Const mnu_ADD_ROW As String = "1292"
    Public Const mnu_DELETE_ROW As String = "1293"
    Public Const mnu_TAX_GROUP_SETUP As String = "8458"
    Public Const mnu_DEFINE_ALTERNATIVE_ITEMS As String = "11531"
    Public Const mnu_CloseOrderLines As String = "DABT_910"
    Public Const mnu_InvSO As String = "DABT_911"
    
    Public Const xml_MENU As String = "Menu.xml"
    Public Const xml_MENU_REMOVE As String = "RemoveMenus.xml"
    Public Const xml_StRequest As String = "StRequest.xml"
    Public Const xml_InvSO As String = "frm_InvSO.xml"

    Public Const frm_DocDetails As String = "frm_DocDetails"
    Public Const xml_DocDetails As String = "frm_DocDetails.xml"
    Public Const mnu_DocDetails As String = "mnu_Draft"


    ''Sales
    Public Function getHashtable() As Hashtable
        Dim Sales As Hashtable = New Hashtable()
        Sales(23) = "Sales Quotation"
        Sales(17) = "Sales Order"
        Sales(15) = "Delivery"
        Sales(16) = "Returns"
        Sales(13) = "A/R Invoice"
        Sales(14) = "A/R Credit Memo"
        Return Sales
    End Function
    Public Function PurchaseHash() As Hashtable
        Dim Purchse As Hashtable = New Hashtable()
        Purchse(1470000113) = "Purchase Request"
        Purchse(540000006) = "Purchase Quotation"
        Purchse(22) = "Purchase Order"
        Purchse(20) = "Goods Receipt PO"
        Purchse(21) = "Goods Returns"
        Purchse(18) = "A/P Invoice"
        Purchse(19) = "A/P Credit Memo"
        Return Purchse
    End Function

End Module
