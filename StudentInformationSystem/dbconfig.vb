Imports MySqlConnector
Module dbconfig
    Private _con As New MySqlConnection("host=localhost;database=vp_project;user=root;password=;port=3306;")

    Public Property Con As MySqlConnection
        Get
            Return _con
        End Get
        Set(value As MySqlConnection)
            _con = value
        End Set
    End Property
End Module
