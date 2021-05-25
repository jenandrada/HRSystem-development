Imports SortOrder = System.Windows.Forms.SortOrder

Module HardCoded

    ' Determine whether Windows XP or a later operating system is present.
    Friend ReadOnly isRunningXPOrLater As Boolean =
        OSFeature.Feature.IsPresent(OSFeature.Themes)

    ' Declare a Hashtable array in which to store the groups.
    Friend groupTables() As Hashtable

    ' Declare a variable to store the current grouping column.
    Friend groupColumn As Integer = 0

    Friend Sub SortingOrder(listView As ListView, Optional col As Integer = 0)
        'Set the sort order to ascending when changing column groups; otherwise, reverse the sort order.
        If listView.Sorting = SortOrder.Descending OrElse
                isRunningXPOrLater And col <> groupColumn Then
            listView.Sorting = SortOrder.Ascending
        Else
            listView.Sorting = SortOrder.Descending
        End If
        groupColumn = col

        ' Set the groups to those created for the clicked column.
        If isRunningXPOrLater Then
            SetGroups(col, listView)
        End If
    End Sub

    Friend Sub ListViewGrouping(listView As ListView, Optional col As Integer = 0)
        If isRunningXPOrLater Then
            ' Create the groupsTable array and populate it with one hash table for each column.
            groupTables = New Hashtable(listView.Columns.Count) {}
            Dim column As Integer
            For column = 0 To listView.Columns.Count - 1
                ' Create a hash table containing all the groups needed for a single column.
                groupTables(column) = CreateGroupsTable(column, listView)
            Next column

            ' Start with the groups created for the Title column.
            SetGroups(col, listView)
        End If
    End Sub

    ' Sets myListView to the groups created for the specified column.
    Friend Sub SetGroups(column As Integer, listView As ListView)
        Try
            ' Remove the current groups.
            listView.Groups.Clear()

            ' Retrieve the hash table corresponding to the column.
            Dim groups As Hashtable = groupTables(column)

            ' Copy the groups for the column to an array.
            Dim groupsArray(groups.Count - 1) As ListViewGroup
            groups.Values.CopyTo(groupsArray, 0)

            ' Sort the groups and add them to myListView.
            Array.Sort(groupsArray, New ListViewGroupSorter(listView.Sorting))
            listView.Groups.AddRange(groupsArray)

            ' Iterate through the items in myListView, assigning each one to the appropriate group.
            Dim item As ListViewItem
            For Each item In listView.Items
                ' Retrieve the subitem text corresponding to the column.
                Dim subItemText As String = item.SubItems(column).Text

                ' For the Title column, use only the first letter.
                If column = 0 Then
                    subItemText = subItemText.Substring(0, 1)
                End If

                ' Assign the item to the matching group.
                item.Group = CType(groups(subItemText), ListViewGroup)
            Next item
        Catch ex As Exception
            Log_Report(ex.ToString)
        End Try

    End Sub 'SetGroups

    ' Creates a Hashtable object with one entry for each unique subitem value (or initial letter for
    ' the parent item) in the specified column.
    Friend Function CreateGroupsTable(column As Integer, listView As ListView) As Hashtable

        ' Create a Hashtable object.
        Dim groups As New Hashtable()
        Try

            ' Iterate through the items in myListView.
            Dim item As ListViewItem
            For Each item In listView.Items
                ' Retrieve the text value for the column.
                Dim subItemText As String = item.SubItems(column).Text

                ' Use the initial letter instead if it is the first column.
                If column = 0 Then
                    subItemText = subItemText.Substring(0, 1)
                End If

                ' If the groups table does not already contain a group for the subItemText value, add a
                ' new group using the subItemText value for the group header and Hashtable key.
                If Not groups.Contains(subItemText) Then
                    groups.Add(subItemText, New ListViewGroup(subItemText,
                        HorizontalAlignment.Left))
                End If
            Next item

            ' Return the Hashtable object.
            Return groups
        Catch ex As Exception
            Log_Report(ex.ToString())
            Return groups
        End Try

    End Function 'CreateGroupsTable

    ' Sorts ListViewGroup objects by header value.
    Private Class ListViewGroupSorter
        Implements IComparer

        Private ReadOnly order As SortOrder

        ' Stores the sort order.
        Public Sub New(theOrder As SortOrder)
            order = theOrder
        End Sub 'New

        ' Compares the groups by header value, using the saved sort order to return the correct value.
        Public Function Compare(x As Object, y As Object) As Integer _
            Implements IComparer.Compare
            Dim result As Integer = String.Compare(
                CType(x, ListViewGroup).Header,
                CType(y, ListViewGroup).Header)
            If order = SortOrder.Ascending Then
                Return result
            Else
                Return -result
            End If
        End Function 'Compare

    End Class 'ListViewGroupSorter

End Module