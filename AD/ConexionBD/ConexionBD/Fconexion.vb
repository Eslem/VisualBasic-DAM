Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

'Si necesitaramos acceso con SQLSERVER
'Imports System.Data.SqlClient


Public Class Fconexion
    Dim rutaBD As String = Application.StartupPath + "\bd.mdb"
    Dim conString As String = "server=localhost; user id=root;password=root;database=vb"
    Dim MysqlConn As MySQLConnection



    Public Sub Conexion()

        'El primer paso en un acceso a datos consiste en establecer una conexión con la Base de Datos. 
        'Esta operación la llevaremos a cabo gracias a las clases Connection de ADO.NET, que permiten conectar a un origen de datos.
        'En ADO.NET existen dos implementaciones para algunos de los objetos, cada uno específico del origen de datos al que vayamos a conectar. 
        'En este caso, si queremos conectar con Microsoft SQL Server lo haremos a través de la clase System.Data.SqlClient.SqlConnection. 
        'Si quisieramos hacerlo con un proveedor de datos OLEDB, lo hariamos a través de la clase System.Data.OleDb.OleDbConnection.




        'Try
        'Utilizaremos los métodos Open() y Close() para conectar y desconectar de la Base de Datos, respectivamente.
        'El constructor de la clase Connection que empleemos (SqlConnection o OleDbConnection) recibirá como parámetro la cadena de conexión que se aplique 
        '  a su propiedad ConnectionString.

        ' Crea el objeto Conexión
        'Dim con As OleDbConnection
        ' Pasa la cadena de conexión

        'con = New OleDbConnection()
        'con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & rutaBD

        'Otras cadenas de conexion:
        'ORACLE:  "Provider=MSDAORA; Data Source=ORACLE8i7;Persist Security Info=False;Integrated Security=Yes"
        'SQLSERVER: "Provider=SQLOLEDB;Data Source=(local);Integrated Security=SSPI;database=ejemplo;uid=sa;pwd=;"

        MysqlConn = New MySqlConnection()

        MysqlConn.ConnectionString = conString
        Try
            MysqlConn.Open()
            ' Conecta con la Base de Datos
            ' con.Open()
            MessageBox.Show("¡Conectado!")
            ' Desconecta de la Base de Datos
            'con.Close()
            MysqlConn.Close()
            MessageBox.Show("¡Desconectado!")
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        'Catch excepcion As OleDbException
        ' Se puede producir algún error durante al conectar o durante la conexión
        'MessageBox.Show(excepcion.Message)
        'MessageBox.Show("Error al conectar con la Base de Datos")
        ' End Try
    End Sub

    Public Sub Insercion()

        'Una vez que hemos establecido la conexión con el SGBD, la siguiente operación que normalmente querremos llevar a cabo será la de enviarle sentencias
        'para realizar diferentes operaciones con los datos. Las clases Command de ADO.NET son las que nos permitirán llevar a cabo tales operaciones.
        'Un objeto Command nos va a permitir ejecutar una sentencia SQL sobre la fuente de datos con la que hemos conectado. También podremos obtener un cojunto de resultados.
        'En este caso, esos datos pasarán a otro tipos de objetos como DataReader o DataAdapter.
        'Los objetos Command se deben crear a partir de la conexión que ya se ha establecido y contendrá una sentencia a SQL a ejecutar sobre dicha conexión.

        'Dim con As OleDbConnection
        'con = New OleDbConnection()
        ' con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & rutaBD

        MysqlConn = New MySqlConnection()

        MysqlConn.ConnectionString = conString

        ' Crea el comando SQL
        'Dim comando As New OleDbCommand()
        Try


            Dim stm As String = "INSERT INTO Alumnos VALUES (123, 'Pablo','Neruda','23/12/1996')"
            Dim comando As New MySqlCommand(stm, MysqlConn)

            'CommandText : Contiene la cadena de texto que representa la sentencia SQL que se ejecutará sobre la fuente de datos.
            'comando.CommandText = "INSERT INTO Alumnos VALUES (123, 'Pablo','Neruda','23/12/1996')"
            'comando.Connection = con
            Dim resultados As Integer
            ' Conecta con la Base de Datos
            'con.Open()
            MysqlConn.Open()

            'Try
            ' Ejecuta la sentencia SQL (NonQuery ya que es una inserción). Sólo devuelve el número de filas afectadas
            'ExecuteNonQuery : Ejecuta la sentencia SQL contenida en la propiedad CommandText del objeto Command. 
            'En este caso la sentencia que se ejecuta debe ser una sentencia de un tipo que no devuelva resultado alguno (UPDATE, DELETE, INSERT).
            resultados = comando.ExecuteNonQuery()

            ' Catch excepcion As OleDbException
            ' End Try

            ' Desconecta de la Base de Datos
            MysqlConn.Close()
            MessageBox.Show("Se han añadido " & resultados & " filas")

        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Conexion()
    End Sub

    Private Sub BtnInsercion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsercion.Click
        Insercion()
    End Sub

    Private Sub ConsultaEscalar()
        '   Dim con As OleDbConnection
        'con = New OleDbConnection()
        'con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & rutaBD
        MysqlConn = New MySqlConnection()

        MysqlConn.ConnectionString = conString

        Try
            Dim stm As String = "SELECT COUNT(*) FROM Alumnos"
            Dim comando As New MySqlCommand(stm, MysqlConn)

            Dim resultados As Integer
            ' Conecta con la Base de Datos
            'con.Open()
            MysqlConn.Open()

            ' Crea el comando SQL
            'Dim comando As New OleDbCommand()

            '   'CommandText : Contiene la cadena de texto que representa la sentencia SQL que se ejecutará sobre la fuente de datos.
            ' comando.CommandText = "SELECT COUNT(*) FROM Alumnos"
            'comando.Connection = con
            '
            ' Conecta con la Base de Datos
            ' con.Open()
            ' Ejecuta la sentencia SQL (NonQuery ya que es una ' ' ' inserción). Sólo devuelve el número de filas afectadas
            resultados = comando.ExecuteScalar()
            ' Desconecta de la Base de Datos
            MysqlConn.Close()
            MessageBox.Show("Hay " & resultados & " alumnos.")
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


    Private Sub BtnConsultaEsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultaEsc.Click
        ConsultaEscalar()
    End Sub

    Private Sub Consulta()
        ' Dim con As OleDbConnection
        'con = New OleDbConnection()
        'con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & rutaBD

        ' Crea el comando SQL
        ' Dim comando As New OleDbCommand()

        'CommandText : Contiene la cadena de texto que representa la sentencia SQL que se ejecutará sobre la fuente de datos.
        ' comando.CommandText = "SELECT * FROM Alumnos"
        ' comando.Connection = con
        MysqlConn = New MySqlConnection()

        MysqlConn.ConnectionString = conString

        Try

            Dim stm As String = "SELECT * FROM Alumnos"
            Dim comando As New MySqlCommand(stm, MysqlConn)

            MysqlConn.Open()
            'Un objeto DataReader permite la navegación hacia delante y de sólo lectura de los registros devueltos por una consulta.
            ' Crea el DataReader
            Dim lectorDatos As MySqlDataReader
            ' Conecta con la Base de Datos
            'Para obtener un objeto DataReader tendremos que ejecutar un método ExecuteReader() de un objeto Command basado en una consulta SQL.
            lectorDatos = comando.ExecuteReader()


            'Read() : Desplaza el cursor actual al siguiente registro permitiendo obtener los valores del mismo a través del objeto DataReader. 
            'Además, devolverá True si quedan más elementos dentro del objeto DataReader y False si hemos llegado al final del conjunto de registros. 
            'La posición inicial de un objeto DataReader es justo antes del primer registro por lo que lo primero que deberemos hacer será realizar una llamada a este método para empezar a obtener valores.
            ' Recorre las filas devueltas en el DataReader y los muestra en un ListBox
            Me.ListaAlumnos.Items.Clear()
            While lectorDatos.Read()
                Me.ListaAlumnos.Items.Add(lectorDatos("Nombre"))
            End While

            ' Cierra el objeto DataReader, liberando sus recursos
            lectorDatos.Close()
            ' Desconecta de la Base de Datos
            MysqlConn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        Consulta()
    End Sub
    Private Sub TrabajandoDataSet()

        ' DataSet es el almacén de datos por excelencia de ADO.NET.
        ' Un objeto DataSet es capaz de almacenar y representar a una Base de Datos en memoria y desconectada del proveedor de datos (Base de Datos) que contiene tablas y sus relaciones.
        ' Cada tabla contenida dentro del objeto DataSet se encuentra disponible a través de su propiedad Tables, que es una colección de objetos System.Data.DataTable. 
        ' Cada objeto System.Data.DataTable es una colección de objetos System.Data.DataRow que representan las filas de la Base de Datos. 
        ' Y siguiendo con esto, cada objeto DataRow posee una colección de objetos DataColumn que representan cada una de las filas de la fila actual.
        ' Para poder crear e inicializar las tablas del DataSet deberemos hacer uso del objeto DataAdapter (SqlAdapter para Microsoft SQL Server y OleDbDataAdapter para OLEdb).
        ' Al objeto DataAdapter le pasaremos como parámetro la cadena que represente la consulta que queremos hacer, y que rellenará de datos el DataSet. 
        ' Del objeto DataAdapter utilizaremos su método Fill(), que tiene dos parámetros: uno el objeto DataSet que se rellenará de datos y otro que será el nombre que tendrá la tabla dentro del objeto DataSet.

        ' Dim con As OleDbConnection
        'con = New OleDbConnection()
        'con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & rutaBD

        MysqlConn = New MySqlConnection()

        MysqlConn.ConnectionString = conString

        ' Crea el DataAdapter
        ' Dim adaptadordatos As New OleDbDataAdapter("SELECT * FROM Alumnos ORDER BY Nombre", con)
        Dim adaptadordatos As New MySqlDataAdapter("SELECT Nombre, Apellidos FROM Alumnos ORDER BY Nombre", MysqlConn)


        'Crea el DataSet
        Dim conjuntoDatos As New DataSet()
        Try
            ' Conecta a la Base de Datos, carga el DataSet y desconecta
            'con.Open()
            MysqlConn.Open()

            adaptadordatos.Fill(conjuntoDatos, "Alumnos")

            MysqlConn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)

        Finally
            MysqlConn.Dispose()
        End Try

        ' Ahora DESCONECTADO, puede trabajar con los datos del DataSet
        Dim tabla As DataTable
        tabla = conjuntoDatos.Tables("Alumnos")
        Dim fila As DataRow
        Me.ListaAlumnos.Items.Clear()
        For Each fila In tabla.Rows
            ' Muestra los datos en un ListBox
            Me.ListaAlumnos.Items.Add(fila.Item("Nombre") & " " & fila.Item("Apellidos"))
        Next
    End Sub

    Private Sub BtnConsultaDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultaDesc.Click
        TrabajandoDataSet()
    End Sub

    Private Sub ListaAlumnos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaAlumnos.SelectedIndexChanged

    End Sub
End Class
