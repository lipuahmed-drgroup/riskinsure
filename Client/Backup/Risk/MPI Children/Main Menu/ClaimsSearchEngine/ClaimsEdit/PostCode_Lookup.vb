Public Class PostCode_Lookup
    Private m_Filter_Locality As String = "Locality like '%'"
    Private m_Filter_Postcode As String = "Pcode like '%'"
    Private m_Filter As String = ""


    Private Sub T_PostcodeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_PostcodeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.T_PostcodeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RiskDataSet)




    End Sub
    Public Overloads Sub Showdialog(Optional ByVal Pcode As String = "")
        If Not Pcode = "" And Not Pcode = Nothing Then
            PostcodeTextBox.Text = Pcode
            m_Filter_Postcode = "Pcode like '" + PostcodeTextBox.Text + "%'"
            Filter()
        End If

        MyBase.ShowDialog()
    End Sub
    Private Sub PostCode_Lookup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.T_PostcodeDataGridView.AutoGenerateColumns = False
        Me.T_PostcodeDataGridView.DataSource = T_PostcodeBindingSource
        Me.T_PostcodeTableAdapter.Fill(Me.RiskDataSet.t_Postcode)



    End Sub

    Private Sub LocalityTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalityTextBox.TextChanged
        If Not LocalityTextBox.Text = "" Then
            m_Filter_Locality = "Locality like '" + LocalityTextBox.Text + "%'"
        Else
            m_Filter_Locality = "Locality like '%'"
        End If

        Filter()
    End Sub

    Private Sub PostcodeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PostcodeTextBox.TextChanged
        If Not PostcodeTextBox.Text = "" Then
            m_Filter_Postcode = "Pcode like '" + PostcodeTextBox.Text + "%'"
        Else
            m_Filter_Postcode = "Pcode like '%'"
        End If

        Filter()
    End Sub

    Private Sub Filter()
        m_Filter = m_Filter_Locality + " and " + m_Filter_Postcode
        T_PostcodeBindingSource.Filter = m_Filter
    End Sub
End Class