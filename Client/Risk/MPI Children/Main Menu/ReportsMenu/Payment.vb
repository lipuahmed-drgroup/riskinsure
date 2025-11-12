Imports DGVCopyNS.DGVCopyClass
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports System.Globalization

Public Class Payment

    Private Function isValid() As Boolean

        Dim d1 As DateTime
        If Not DateTime.TryParse(StartDateTextBox.Text, d1) Then
            MsgBox("Start date is not valid")
            Return False
        End If

        If Not DateTime.TryParse(EndDateTextBox.Text, d1) Then
            MsgBox("End date is not valid")
            Return False
        End If

        Return True
    End Function

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click

        If isValid() Then

            Dim filename = "payment_order_" & CDate(EndDateTextBox.Text).ToString("ddMMyyyy") & ".csv"
            Dim filepath = ComboBox1.Text + "\" + filename
            Dim sw As New StreamWriter(filepath)
            'Dim sw As StreamWriter


            filename = "payment_order_log_" & CDate(EndDateTextBox.Text).ToString("ddMMyyyy") & ".csv"
            Dim filepath1 = ComboBox1.Text + "\" + filename
            Dim sw1 As New StreamWriter(filepath1)
            'Dim sw1 As StreamWriter


            Dim strSQL As String

            Dim dtEFT As New DataTable
            Dim dtCheque As New DataTable
            Dim dtRemittance As New DataTable
            Dim dtHeaderRecord As New DataTable

            Dim str As String
            str = ""
            Dim str1 As String
            str1 = ""
            Dim ClaimNumber As String
            ClaimNumber = ""

            Dim TotalPaymentCount As Integer
            Dim TotalPaymentAmount As Double
            Dim PaymentAmount As Double
            TotalPaymentCount = 0
            TotalPaymentAmount = 0
            PaymentAmount = 0

            Dim PaymentDate As DateTime
            PaymentDate = DateTime.Now

            Try
                'sw = New StreamWriter(filepath)
                'sw1 = New StreamWriter(filepath1)
                '-------------------------- Get Header Record -------------------------------------------------------------------
                strSQL = " SELECT RecordType,CustomerCode,CustomerName,CustomerFileReference,ScheduledDate,Currency,[Version] FROM tblHeaderRecord"
                dtHeaderRecord = GetPaymentRecord(strSQL).Tables(0)

                If dtHeaderRecord.Rows.Count = 1 Then
                    str = """" & dtHeaderRecord.Rows(0)(0).ToString() & """,""" & _
                                dtHeaderRecord.Rows(0)(1).ToString() & """,""" & _
                                dtHeaderRecord.Rows(0)(2).ToString() & """,""" & _
                                dtHeaderRecord.Rows(0)(3).ToString() & """,""" & _
                                DateTime.Today.ToString("ddMMyyyy") & """,""" & _
                                dtHeaderRecord.Rows(0)(5).ToString() & """,""" & _
                                dtHeaderRecord.Rows(0)(6).ToString() & """"
                    sw.Write(str)
                    sw.WriteLine()
                    str = ""
                End If

                '-------------------------- Get EFT Payment Record -------------------------------------------------------------------
                If PaymentTypeComboBox.Text = "ALL" Or PaymentTypeComboBox.Text = "EFT" Then
                    strSQL = " SELECT RecordType,SupplierNumber,ClaimNumber, PaymentAmount ,LodgementReference,BSBNumber,AccountNumber,AccountName, PaymentDate " & _
                            " FROM tblPayment  " & _
                            " WHERE PaymentAmount > 0  " & _
                            " AND (LodgementReference IS NOT NULL OR LodgementReference <>'')  " & _
                            " AND ( AccountNumber  IS NOT NULL OR AccountNumber <>'')  " & _
                            " AND ( BSBNumber  IS NOT NULL OR BSBNumber <>'')  " & _
                            " AND IsProcessed = 0  " & _
                            " AND PaymentDate BETWEEN  '" & CDate(StartDateTextBox.Text).ToString("MM/dd/yyyy") & "' AND ' " & CDate(EndDateTextBox.Text).ToString("MM/dd/yyyy") & "'"
                    dtEFT = GetPaymentRecord(strSQL).Tables(0)

                    '-- EFT Remittance Record
                    ' ,RemittanceLayoutCode,ReturnToAddressIdentifier
                    strSQL = " SELECT ClaimNumber, RecordType,UPPER(RemittanceDeliveryType) AS RemittanceDeliveryType,PayeeName,AddresseName,Street1,Street2,Street3,City,State,PostCode,'AU' AS COUNTRY  " & _
                        " ,Fax,Email " & _
                        " FROM dbo.tblRemittanceRecord " & _
                        " WHERE (PayeeName IS NOT NULL OR PayeeName <>'')  " & _
                        " AND (RemittanceDeliveryType <>'None' OR RemittanceDeliveryType='' OR RemittanceDeliveryType IS NOT NULL)  " & _
                        " AND ClaimNumber IN  " & _
                        " ( Select ClaimNumber  " & _
                        " FROM tblPayment  " & _
                        "  WHERE PaymentAmount > 0  " & _
                        " AND (LodgementReference IS NOT NULL OR LodgementReference <>'')  " & _
                        " AND ( AccountNumber  IS NOT NULL OR AccountNumber <>'')  " & _
                        " AND ( BSBNumber  IS NOT NULL OR BSBNumber <>'')  " & _
                        " AND IsProcessed = 0  " & _
                        " AND PaymentDate BETWEEN  '" & CDate(StartDateTextBox.Text).ToString("MM/dd/yyyy") & "' AND ' " & CDate(EndDateTextBox.Text).ToString("MM/dd/yyyy") & "')"

                    dtRemittance = GetPaymentRecord(strSQL).Tables(0)
                End If

                '----------Write EFT and Remittance Record into file ---------------------------------------------------------------------------
                For i = 0 To dtEFT.Rows.Count - 1
                    ClaimNumber = dtEFT.Rows(i)(2).ToString()
                    PaymentDate = CDate(dtEFT.Rows(i)("PaymentDate"))

                    For j = 0 To dtEFT.Columns.Count - 2
                        If j = 3 Then
                            str = str + """" + CDbl(dtEFT.Rows(i)(j).ToString()).ToString("N2").ToString().Replace(",", "") + """"
                            PaymentAmount = CDbl(dtEFT.Rows(i)(j).ToString())
                            TotalPaymentAmount = TotalPaymentAmount + PaymentAmount
                            'TotalPaymentAmount = TotalPaymentAmount + CDbl(dtEFT.Rows(i)(j).ToString())
                        Else
                            str = str + """" + dtEFT.Rows(i)(j).ToString() + """"
                        End If
                        If Not j = dtEFT.Columns.Count - 2 Then
                            str = str + ","
                        End If
                    Next
                    If Not i = dtEFT.Rows.Count Then
                        TotalPaymentCount = TotalPaymentCount + 1
                        sw.Write(str)
                        sw.WriteLine()
                        str = ""

                        '------- Write Remittance Record --------------
                        If IsValidRemittance(dtRemittance, ClaimNumber, i, dtEFT, sw1) > -1 Then
                            For k = 0 To dtRemittance.Rows.Count - 1
                                If ClaimNumber = dtRemittance.Rows(k)(0).ToString() Then
                                    For l = 1 To dtRemittance.Columns.Count - 1

                                        str = str + """" + dtRemittance.Rows(k)(l).ToString() + """"
                                        If Not l = dtRemittance.Columns.Count - 1 Then
                                            str = str + ","
                                        End If
                                    Next
                                    If Not k = dtRemittance.Rows.Count Then
                                        sw.Write(str)
                                        sw.WriteLine()
                                        str = ""
                                    End If
                                End If
                            Next

                            '------- Write Invoice Record -----------------------------------------------------------------------------------------------------------------------
                            '"I","Payer Ref1","Payee Ref1","01012016","01022016","100.00","Inv Description1","50.00","Ded Description1"
                            str = """I"",""" & ClaimNumber & ""","""",""" & PaymentDate.ToString("ddMMyyyy") & """,""" & PaymentDate.AddDays(1).ToString("ddMMyyyy") & """,""" & PaymentAmount.ToString("N2").ToString().Replace(",", "") & """,""Mobile phone insurance claim " & ClaimNumber & """"
                            sw.Write(str)
                            sw.WriteLine()
                            str = ""
                        End If
                    End If
                Next
                '-------------------------------------------------------------------------------------------------------------------------

                '---------------------- Get Cheque Payment Record ------------------------------------------------------------------------
                If PaymentTypeComboBox.Text = "ALL" Or PaymentTypeComboBox.Text = "Cheque" Then
                    strSQL = " SELECT RecordType, '' SupplierNumber, ClaimNumber, PaymentAmount, PaymentDate " & _
                            " FROM tblChequePayment " & _
                            " WHERE PaymentAmount > 0 " & _
                            " AND IsProcessed = 0 " & _
                            " AND PaymentDate BETWEEN  '" & CDate(StartDateTextBox.Text).ToString("MM/dd/yyyy") & "' AND ' " & CDate(EndDateTextBox.Text).ToString("MM/dd/yyyy") & "'"

                    dtCheque = GetPaymentRecord(strSQL).Tables(0)

                    '----- Get Remittance Record
                    ' ,RemittanceLayoutCode,ReturnToAddressIdentifier
                    strSQL = " SELECT ClaimNumber, RecordType,UPPER(RemittanceDeliveryType) AS RemittanceDeliveryType,PayeeName,AddresseName,Street1,Street2,Street3,City,State,PostCode,'AU' AS COUNTRY " & _
                            " ,Fax,Email " & _
                            "  FROM dbo.tblRemittanceRecord  " & _
                            " WHERE (PayeeName IS NOT NULL OR PayeeName <>'')  " & _
                            " AND (RemittanceDeliveryType ='POST') " & _
                            " AND ClaimNumber IN  (" & _
                            " Select ClaimNumber  " & _
                            " FROM tblChequePayment   " & _
                            " WHERE PaymentAmount >0  " & _
                            " AND IsProcessed = 0 " & _
                            " AND PaymentDate BETWEEN  '" & CDate(StartDateTextBox.Text).ToString("MM/dd/yyyy") & "' AND ' " & CDate(EndDateTextBox.Text).ToString("MM/dd/yyyy") & "')"
                    dtRemittance = GetPaymentRecord(strSQL).Tables(0)
                End If

                '-------- Write Checque Record
                For i = 0 To dtCheque.Rows.Count - 1
                    ClaimNumber = dtCheque.Rows(i)(2).ToString()
                    PaymentDate = CDate(dtCheque.Rows(i)("PaymentDate"))

                    If IsValidRemittance(dtRemittance, ClaimNumber, i, dtCheque, sw1) > -1 Then
                        TotalPaymentCount = TotalPaymentCount + 1

                        For j = 0 To dtCheque.Columns.Count - 2
                            If j = 3 Then
                                str = str + """" + CDbl(dtCheque.Rows(i)(j).ToString()).ToString("N2").ToString().Replace(",", "") + """"
                                PaymentAmount = CDbl(dtCheque.Rows(i)(j).ToString())
                                TotalPaymentAmount = TotalPaymentAmount + PaymentAmount
                                'TotalPaymentAmount = TotalPaymentAmount + CDbl(dtCheque.Rows(i)(j).ToString())
                            Else
                                str = str + """" + dtCheque.Rows(i)(j).ToString() + """"
                            End If
                            If Not j = dtCheque.Columns.Count - 2 Then
                                str = str + ","
                            End If
                        Next
                        If Not i = dtCheque.Rows.Count Then
                            sw.Write(str)
                            sw.WriteLine()
                            str = ""

                            '------- Write Remittance Record --------------
                            For k = 0 To dtRemittance.Rows.Count - 1
                                If ClaimNumber = dtRemittance.Rows(k)(0).ToString() Then
                                    For l = 1 To dtRemittance.Columns.Count - 1
                                        str = str + """" + dtRemittance.Rows(k)(l).ToString() + """"

                                        If Not l = dtRemittance.Columns.Count - 1 Then
                                            str = str + ","
                                        End If
                                    Next
                                    If Not k = dtRemittance.Rows.Count Then
                                        sw.Write(str)
                                        sw.WriteLine()
                                        str = ""
                                    End If
                                End If
                            Next
                            '------------------------------------------
                        End If
                        '------- Write Invoice Record --------------
                        '"I","Payer Ref1","Payee Ref1","01012016","01022016","100.00","Inv Description1","50.00","Ded Description1"
                        str = """I"",""" & ClaimNumber & ""","""",""" & PaymentDate.ToString("ddMMyyyy") & """,""" & PaymentDate.AddDays(1).ToString("ddMMyyyy") & """,""" & PaymentAmount.ToString("N2").ToString().Replace(",", "") & """,""Mobile phone insurance claim " & ClaimNumber & """"
                        sw.Write(str)
                        sw.WriteLine()
                        str = ""

                    End If
                    '--- Remittance record cheque
                   
                Next


                '---- Trailer Record
                str = """T"",""" & TotalPaymentCount & """,""" & TotalPaymentAmount & """"
                sw.Write(str)
                sw.WriteLine()
                str = ""

                sw.Close()
                sw1.Close()

                MsgBox("Payment file is saved here: " & filepath)

            Catch ex As Exception
                'If sw.Equals(StreamWriter.Null) = False Then
                sw.Close()
                'End If
                sw1.Close()
                MsgBox(ex.ToString())
            End Try
        End If

    End Sub

    Private Sub PreviewButton_Click(sender As Object, e As EventArgs) Handles PreviewButton.Click

        Dim strSQL As String

        DataGridViewEFTPayment.DataSource = Nothing
        DataGridViewChequePayment.DataSource = Nothing

        Try
            '-------------------------- Get EFT Payment Record -------------------------------------------------------------------
            If PaymentTypeComboBox.Text = "ALL" Or PaymentTypeComboBox.Text = "EFT" Then
                strSQL = " SELECT RecordType,SupplierNumber,ClaimNumber,Round(PaymentAmount,2) AS PaymentAmount,LodgementReference,BSBNumber,AccountNumber,AccountName " & _
                        " FROM tblPayment  " & _
                        " WHERE PaymentAmount > 0  " & _
                        " AND (LodgementReference IS NOT NULL OR LodgementReference <>'')  " & _
                        " AND ( AccountNumber  IS NOT NULL OR AccountNumber <>'')  " & _
                        " AND ( BSBNumber  IS NOT NULL OR BSBNumber <>'')  " & _
                        " AND IsProcessed = 0  " & _
                        " AND PaymentDate BETWEEN  '" & CDate(StartDateTextBox.Text).ToString("MM/dd/yyyy") & "' AND ' " & CDate(EndDateTextBox.Text).ToString("MM/dd/yyyy") & "'"

                DataGridViewEFTPayment.DataSource = GetPaymentRecord(strSQL).Tables(0)
            End If

            '---------------------- Get Cheque Payment Record -----------------------------------------------------------------------
            If PaymentTypeComboBox.Text = "ALL" Or PaymentTypeComboBox.Text = "Cheque" Then

                ' SELECT C.RecordType, SupplierNumber, C.ClaimNumber, PaymentAmount, ChequeNumber  
                'FROM tblChequePayment AS C  
                'INNER JOIN [tblRemittanceRecord] AS R
                'ON C.ClaimNumber = R.ClaimNumber  
                'WHERE PaymentAmount > 0 
                'AND R.RemittanceDeliveryType ='POST'
                ' AND IsProcessed = 0   AND PaymentDate BETWEEN  '01/01/2000' AND ' 01/01/2016'



                strSQL = " SELECT C.RecordType, SupplierNumber, C.ClaimNumber, PaymentAmount, ChequeNumber " & _
                        " FROM tblChequePayment AS C " & _
                        " INNER JOIN [tblRemittanceRecord] AS R  " & _
                        " ON C.ClaimNumber = R.ClaimNumber " & _
                        " WHERE PaymentAmount > 0 " & _
                        " AND R.RemittanceDeliveryType ='POST'" & _
                        " AND IsProcessed = 0  " & _
                        " AND PaymentDate BETWEEN  '" & CDate(StartDateTextBox.Text).ToString("MM/dd/yyyy") & "' AND ' " & CDate(EndDateTextBox.Text).ToString("MM/dd/yyyy") & "'"
                DataGridViewChequePayment.DataSource = GetPaymentRecord(strSQL).Tables(0)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())

        End Try
    End Sub

    Private Function GetPaymentRecord(ByVal strSQL As String) As DataSet
        Dim ds As New DataSet()
        Dim constring As String = System.Configuration.ConfigurationManager.ConnectionStrings("Risk.My.MySettings.RiskConnectionString").ConnectionString
        Using con As New OdbcConnection(constring)
            Using cmd As New OdbcCommand(strSQL, con)
                cmd.CommandType = CommandType.Text
                Using sda As New OdbcDataAdapter(cmd)
                    sda.Fill(ds)
                    con.Close()
                End Using
            End Using
        End Using
        Return ds
    End Function

    Private Function IsValidRemittance(ByVal dsRemittance As DataTable,
                                       ByVal ClaimNumber As String,
                                       ByVal index As Int32,
                                       ByVal dtPayment As DataTable,
                                       ByRef sw1 As StreamWriter) As Int32

        For i = 0 To dsRemittance.Rows.Count - 1
            If dsRemittance.Rows(i)("ClaimNumber").ToString() = ClaimNumber Then


                '--------------- For Cheque Payment, Delivery type must be "POST"
                If dtPayment.Rows(index)("RecordType").ToString = "C" And dsRemittance.Rows(i)("RemittanceDeliveryType") <> "POST" Then
                    sw1.Write("Payment Type: Cheque, Claim Number:" + ClaimNumber & ",Remittance delivery type must be POST")
                    sw1.WriteLine()
                    Return -1
                End If

                If dsRemittance.Rows(i)("RemittanceDeliveryType") = "EMAIL" And dsRemittance.Rows(i)("PayeeName") <> "" And dsRemittance.Rows(i)("Email") <> "" Then
                    Return i

                ElseIf dsRemittance.Rows(i)("RemittanceDeliveryType") = "POST" And dsRemittance.Rows(i)("PayeeName") <> "" And dsRemittance.Rows(i)("Street1") <> "" And dsRemittance.Rows(i)("PostCode") <> "" Then
                    Return i

                Else
                    If dsRemittance.Rows(i)("RemittanceDeliveryType") = "EMAIL" Then
                        If dtPayment.Rows(index)("RecordType").ToString = "E" Then
                            sw1.Write("Payment Type: EFT, Claim Number:" + ClaimNumber & " Email Address or Payee Name is Missing")
                            sw1.WriteLine()

                            For j = 1 To dsRemittance.Columns.Count - 1
                                sw1.Write(dsRemittance.Rows(i)(j).ToString() & ",")
                            Next

                        Else
                            sw1.Write("Payment Type: Cheque, Claim Number:" + ClaimNumber & " Required remittance information is missing")
                            sw1.WriteLine()
                            sw1.Write(dtPayment.Rows(index)("RecordType").ToString() & "," &
                                      dtPayment.Rows(index)("SupplierNumber").ToString() & "," &
                                      dtPayment.Rows(index)("ClaimNumber").ToString() & "," &
                                      dtPayment.Rows(index)("PaymentAmount").ToString())

                            sw1.WriteLine()
                            For j = 1 To dsRemittance.Columns.Count - 1
                                sw1.Write(dsRemittance.Rows(i)(j).ToString() & ",")
                            Next
                        End If
                        sw1.WriteLine()
                        ' print email data missing

                    ElseIf dsRemittance.Rows(i)("RemittanceDeliveryType") = "POST" Then
                        ' print post data missing
                        If dtPayment.Rows(index)("RecordType").ToString = "E" Then
                            sw1.Write("Payment Type: EFT, Claim Number:" + ClaimNumber & " Email Address or Payee Name is Missing")
                            sw1.WriteLine()

                            For j = 1 To dsRemittance.Columns.Count - 1
                                sw1.Write(dsRemittance.Rows(i)(j).ToString() & ",")
                            Next

                        Else
                            sw1.Write("Payment Type: Cheque, Claim Number:" + ClaimNumber & " Required remittance information is missing")
                            sw1.WriteLine()
                            sw1.Write(dtPayment.Rows(index)("RecordType").ToString() & "," &
                                      dtPayment.Rows(index)("SupplierNumber").ToString() & "," &
                                      dtPayment.Rows(index)("ClaimNumber").ToString() & "," &
                                      dtPayment.Rows(index)("PaymentAmount").ToString())

                            sw1.WriteLine()
                            For j = 1 To dsRemittance.Columns.Count - 1
                                sw1.Write(dsRemittance.Rows(i)(j).ToString() & ",")
                            Next
                        End If
                        sw1.WriteLine()
                    Else
                        ' no need to send remittance for this claim
                    End If

                    Return -1
                End If

            End If
        Next

        Return -1
    End Function

End Class