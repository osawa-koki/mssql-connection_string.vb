# mssql-connection_string.vb

なんか、接続文字列を生成するためのクラスがあるとの噂が、、、  
2022年でのVBに関する説明なんてもはや考古学のような感じだが、、、  

## 説明

```vb
Dim SqlConnectionStringBuilder As New SqlConnectionStringBuilder()
SqlConnectionStringBuilder.DataSource = "localhost"
SqlConnectionStringBuilder.UserID = "userid"
SqlConnectionStringBuilder.Password = "password"
SqlConnectionStringBuilder.InitialCatalog = "database"
SqlConnectionStringBuilder.TrustServerCertificate = True

Dim connection_string = SqlConnectionStringBuilder.ConnectionString

Console.WriteLine(connection_string)

' -> Data Source=localhost;Initial Catalog=database;User ID=userid;Password=password;TrustServerCertificate=True
```

## 参考文献

- <https://learn.microsoft.com/ja-jp/dotnet/api/system.data.sqlclient.sqlconnectionstringbuilder>
