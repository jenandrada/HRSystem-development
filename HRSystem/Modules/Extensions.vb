Imports System.Reflection

Public Module Extensions

    Public Function ToDataTable(Of T As Class)(data As List(Of T)) As DataTable
        Dim result As New DataTable()
        Dim type As Type = GetType(T)
        Dim list = (From p As PropertyInfo In type.GetProperties() Where (p.CanRead AndAlso (p.GetIndexParameters().Length = 0)) Select New With {.[Property] = p, .Column = New DataColumn(p.Name, p.PropertyType)})
        result.Columns.AddRange((From obj In list Select obj.Column).ToArray())
        If (Not data Is Nothing) Then
            result.BeginLoadData()
            Array.ForEach(Of T)(data.ToArray(), Function(item As T) result.Rows.Add((From obj In list Select obj.[Property].GetValue(item, Nothing)).ToArray()))
            result.EndLoadData()
        End If
        result.AcceptChanges()
        list = Nothing
        type = Nothing
        Return result
    End Function

End Module