Imports System.Security.Cryptography
Public NotInheritable Class Encryptor
    ReadOnly TripleDes As New TripleDESCryptoServiceProvider

    Private Function TruncateHash(key As String, length As Integer) As Byte()
        Dim sha1 As New SHA1CryptoServiceProvider
        Dim keyBytes() As Byte = Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)
        ReDim Preserve hash(length - 1)
        Return hash
    End Function

    Sub New(key As String)
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
    End Sub

    Public Function EncryptData(plainText As String) As String
        Dim plaintextBytes() As Byte = Text.Encoding.Unicode.GetBytes(plainText)
        Dim ms As New IO.MemoryStream
        Dim encStream As New CryptoStream(ms, TripleDes.CreateEncryptor(), CryptoStreamMode.Write)
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function DecryptData(cipherText As String) As String
        Dim encryptedBytes() As Byte = Convert.FromBase64String(cipherText)
        Dim ms As New IO.MemoryStream
        Dim decStream As New CryptoStream(ms, TripleDes.CreateDecryptor(), CryptoStreamMode.Write)
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()
        Return Text.Encoding.Unicode.GetString(ms.ToArray)
    End Function
End Class