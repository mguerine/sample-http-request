Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Linq
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class TelaPrincipal

    Private Function ReceiveResponse(uri As Uri, contentType As String, method As String) As String
        'Criando as variáveis usadas na criação da requisição HTTP
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader
        Dim responseString As String

        responseString = ""

        Try
            'Construindo a requisição HTTP com a rota da URL passada
            request = DirectCast(WebRequest.Create(uri), HttpWebRequest)
            'Fazendo a requisição e coletando a resposta
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            'Lendo a resposta à requisição
            reader = New StreamReader(response.GetResponseStream())

            'Transformando a resposta em string para facilitar a leitura do JSON
            Dim rawresp As String
            rawresp = reader.ReadToEnd()

            'Fazendo o parse da string
            Dim array As JArray = JArray.Parse(rawresp)

            'Imprimindo no console os itens encontrados no array
            For Each item As JObject In array
                responseString += item.ToString
                Console.WriteLine(item)

            Next

        Catch ex As Exception
            'Em caso de erro, abrir uma messagebox
            MsgBox(ex.ToString)
        Finally
            If Not response Is Nothing Then
                response.Close()
            End If
        End Try

        Return responseString
    End Function


    Private Function SendRequest(uri As Uri, jsonDataBytes As Byte(), contentType As String, method As String) As String
        Dim response As String
        Dim request As WebRequest

        'Construindo a requisição HTTP com a rota da URL passada
        request = WebRequest.Create(uri)
        'Criando o objeto JSON da requisição
        request.ContentLength = jsonDataBytes.Length
        request.ContentType = contentType
        request.Method = method

        'Fazendo a escrita das informações no server via requisição HTTP POST
        Using requestStream = request.GetRequestStream
            requestStream.Write(jsonDataBytes, 0, jsonDataBytes.Length)
            requestStream.Close()

            'Capturando a resposta do server após escrita
            Using responseStream = request.GetResponse.GetResponseStream
                Using reader As New StreamReader(responseStream)
                    response = reader.ReadToEnd()
                End Using
            End Using
        End Using

        Return response
    End Function

    Private Sub BTSend_Click(sender As Object, e As EventArgs) Handles BTSend.Click
        'String JSON usada para cadastro de usuário
        Dim jsonString As String
        '{
        '"matricula":"$matricula",
        '"nome":"nome",
        '"email":"email",
        '"saldo":0
        '}

        'Construindo a string com os valores preenchidos no formulário
        '** Não fiz validação de dados!! Isso deve ser feito na versão principal do S.I.S.T.E.MA. !!
        jsonString = "{""matricula"":""" &
                        TBMatricula.Text &
                        """,""nome"":""" &
                        TBNome.Text &
                        """,""email"":""" &
                        TBEmail.Text &
                        """,""saldo"":" &
                        TBSaldo.Text & "}"

        'URL para a rota de criação de usuários (definida na API pelo Erick)
        Dim myUri As New Uri("https://sistemaifrj.herokuapp.com/users/")

        'Codificando a string JSON para ser enviada na requisição HTTP do tipo POST
        Dim data = Encoding.UTF8.GetBytes(jsonString)
        Dim result_post = SendRequest(myUri, data, "application/json", "POST")
        Console.WriteLine(result_post)

    End Sub

    Private Sub BTReceive_Click(sender As Object, e As EventArgs) Handles BTReceive.Click
        'URL para rota de lista de usuários (definida na API pelo Erick)
        Dim myUri As New Uri("https://sistemaifrj.herokuapp.com/users/")

        'Usando a função ReceiveResponse para buscar os usuários cadastrados. Usando o método GET para a requisição HTTP
        Dim result_post = ReceiveResponse(myUri, "application/json", "GET")

        'Imprimindo no console o resultado da busca
        Console.WriteLine(result_post)

    End Sub
End Class
