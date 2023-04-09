Module Font_Functions
    Public TheForecolor As Color
    Public TheBackcolor As Color
    Public TheBackground As Color
    Public Function FontFromString(ByVal sFont As String) As Font
        sFont = sFont.Substring(1, sFont.Length - 2)
        'sFont = Replace(sFont, ",", vbNullString)
        sFont = Replace(sFont, "Font:", vbNullString)
        Dim sElement() As String = Split(sFont, ", ")
        Dim sSingle() As String
        Dim sValue As String
        Dim FontName As String = vbNullString
        Dim FontSize As Single
        Dim FontStyle As FontStyle = Drawing.FontStyle.Regular
        Dim FontUnit As GraphicsUnit = GraphicsUnit.Point
        Dim gdiCharSet As Byte
        Dim gdiVerticalFont As Boolean

        For Each sValue In sElement
            sValue = Trim(sValue)
            sSingle = Split(sValue, "=")
            If sSingle.GetUpperBound(0) > 0 Then
                If sSingle(0) = "Name" Then
                    FontName = sSingle(1)
                ElseIf sSingle(0) = "Size" Then
                    FontSize = CSng(sSingle(1))
                ElseIf sSingle(0) = "Units" Then
                    FontUnit = CInt(sSingle(1))
                ElseIf sSingle(0) = "GdiCharSet" Then
                    gdiCharSet = CByte(sSingle(1))
                ElseIf sSingle(0) = "GdiVerticalFont" Then
                    gdiVerticalFont = CBool(sSingle(1))
                End If
            End If
        Next
        Return New Font(FontName, FontSize, FontStyle, FontUnit, gdiCharSet, gdiVerticalFont)
    End Function

    Public Sub FormColor(ByVal form As Form)
        Dim lbl As Control
        For Each lbl In form.Controls
            If TypeOf lbl Is Label Or TypeOf lbl Is TextBox Or TypeOf lbl Is RichTextBox Or TypeOf lbl Is CheckBox Or TypeOf lbl Is ComboBox Or TypeOf lbl Is GroupBox Then

                lbl.ForeColor = TheBackcolor

            End If
        Next

    End Sub
End Module
