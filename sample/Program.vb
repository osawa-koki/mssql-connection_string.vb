Imports System
Imports System.Data.SqlClient

Module Program
  Sub Main(args As String())
    Dim SqlConnectionStringBuilder As New SqlConnectionStringBuilder()
    SqlConnectionStringBuilder.DataSource = "localhost"
    SqlConnectionStringBuilder.UserID = "userid"
    SqlConnectionStringBuilder.Password = "password"
    SqlConnectionStringBuilder.InitialCatalog = "database"
    SqlConnectionStringBuilder.TrustServerCertificate = True

    Dim connection_string = SqlConnectionStringBuilder.ConnectionString

    Console.WriteLine(connection_string)

    ' -> Data Source=localhost;Initial Catalog=database;User ID=userid;Password=password;TrustServerCertificate=True
  End Sub
End Module
