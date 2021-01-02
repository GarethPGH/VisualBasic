Imports System.IO
Imports TestScores
Public Class Form1
    Private frmReport As New ReportForm
    Private Const intMAX_INDEX As Integer = 4
    Private Students() As StudentScores
    Private strFileName As String = String.Empty

    'Open Reports 
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.Filter = "text files (*.txt)|*.txt|all files (*.*)|*.*"
        OpenFileDialog1.FileName = String.Empty
        Dim strLine As String = String.Empty
        Dim readFile As StreamReader
        Dim diagResult As DialogResult = OpenFileDialog1.ShowDialog()

        If diagResult = DialogResult.OK Then
            strFileName = OpenFileDialog1.FileName
            readFile = New StreamReader(strFileName)
            While Not readFile.EndOfStream
                strLine = readFile.ReadLine
                frmReport.lstTestData.Items.Add(strLine)
            End While
            frmReport.Show()
        ElseIf diagResult = DialogResult.Cancel Then
            MessageBox.Show("No File Selected")
        End If
    End Sub
    'Create Report with Student Name, Test Scores and Averages 
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim strFileName As String
        Dim diagResult As DialogResult
        Dim writeFile As StreamWriter
        Dim strName As String
        Dim strScore As String
        Dim strAverage As String
        Dim intCounter As Integer = 1

        diagResult = SaveFileDialog1.ShowDialog()

        If diagResult = DialogResult.OK Then
            strFileName = SaveFileDialog1.FileName
            writeFile = New StreamWriter(strFileName)
            writeFile.WriteLine("Student Test Scores and Averages")
            writeFile.WriteLine()
            For Each student In Students
                strName = String.Format("{0, -20}{1, -10}", "Name:", student.strStudentName)
                writeFile.WriteLine(strName)
                For intIndex = 0 To intMAX_INDEX
                    strScore = String.Format("{0, -20}{1, -20}", "Score " & intCounter & ":", student.dblScores(intIndex))
                    writeFile.WriteLine(strScore)
                    intCounter += 1
                Next
                intCounter = 1
                strAverage = String.Format("{0, -20}{1, -15}", "Average:", student.dblAverage)
                writeFile.WriteLine(strAverage)
                writeFile.WriteLine()
            Next
            writeFile.Close()
        ElseIf diagResult = DialogResult.Cancel Then
            MessageBox.Show("Nothing Has Been Saved")
        End If
    End Sub
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("Use Form to get Student Test Averages using Individual Test Scores" & vbNewLine & "Save the Results to a Report File: File > Save" & vbNewLine & "Open Reports to View: File > Open" & vbNewLine & "Print Open Report: Report > Print")
    End Sub

    'Print Reports
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Dim diagResult As DialogResult
        diagResult = PrintDialog1.ShowDialog()

        If diagResult = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        ElseIf diagResult = DialogResult.Cancel Then
            MessageBox.Show("Nothing Printed")
        End If
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fileReader As StreamReader
        Dim intH As Integer = 12
        Dim intV As Integer = 12
        Try
            fileReader = File.OpenText(strFileName)
            Do While Not fileReader.EndOfStream
                e.Graphics.DrawString(fileReader.ReadLine(), New Font("Verdana", 12, FontStyle.Regular), Brushes.Black, intH, intV)
                intV += 17
            Loop
        Catch ex As Exception
            MessageBox.Show("Error: No File to Print")
        End Try
    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        assignTextFields()
        setTextboxes()
    End Sub

    'Calculate Average
    Private Function calculateAverage(ByVal testArray As Double()) As Double
        Dim dblAverage As Double = 0.0
        Dim dblSum As Double = 0.0
        For Each item In testArray
            dblSum += item
        Next
        dblAverage = dblSum / testArray.Length
        Return dblAverage
    End Function

    'Verify String and Double Input
    Private Function verifyName(ByVal str As String) As Boolean
        Dim blnIsValid As Boolean = False
        If Not str = String.Empty Then
            blnIsValid = True
        End If
        Return blnIsValid
    End Function

    Private Function verifyScore(ByVal strDbl As String) As Boolean
        Dim dblParse As Double
        Dim blnIsValid As Boolean = False
        If Double.TryParse(strDbl, dblParse) Then
            If dblParse >= 0.0 And dblParse <= 100.0 Then
                blnIsValid = True
            End If
        End If
        Return blnIsValid
    End Function
    'Create Structure
    Private Function createStructure(ByVal strName As String, ByVal dblValues As Double(), ByVal dblAv As Double) As StudentScores
        Dim structStudent As New StudentScores
        structStudent.strStudentName = strName
        ReDim structStudent.dblScores(intMAX_INDEX)
        For intIndex = 0 To intMAX_INDEX
            structStudent.dblScores(intIndex) = dblValues(intIndex)
        Next
        structStudent.dblAverage = dblAv

        Return structStudent
    End Function
    'Create a Double Array
    Private Function createDoubleArray(ByVal strdbl1 As String, ByVal strdbl2 As String, ByVal strdbl3 As String, ByVal strdbl4 As String, ByVal strdbl5 As String) As Double()
        Dim blnValid As Boolean = False
        Dim str As String = ""
        Dim dblArray(intMAX_INDEX) As Double
        Dim strArr() As String = {strdbl1, strdbl2, strdbl3, strdbl4, strdbl5}

        For intIndex = 0 To intMAX_INDEX
            If verifyScore(strArr(intIndex)) Then
                dblArray(intIndex) = CDbl(strArr(intIndex))
                blnValid = True
            Else
                While Not blnValid
                    str = InputBox("Enter a Score between 0 and 100", "Enter Correct Input")
                    Double.TryParse(str, dblArray(intIndex))
                    If verifyScore(dblArray(intIndex)) Then
                        blnValid = True
                    End If
                End While
            End If
        Next
        Return dblArray
    End Function
    'Assign Values from Textfields into Structures
    Private Sub assignTextFields()
        Dim strName As String = ""

        If verifyName(txtStudentA.Text) Then
            strName = txtStudentA.Text
        End If
        Dim dblScores() As Double = createDoubleArray(txt1a.Text, txt2a.Text, txt3a.Text, txt4a.Text, txt5a.Text)
        Dim dblAv As Double = calculateAverage(dblScores)
        Students(0) = createStructure(strName, dblScores, dblAv)

        If verifyName(txtStudentB.Text) Then
            strName = txtStudentB.Text
        Else
            strName = ""
        End If
        dblScores = createDoubleArray(txt1b.Text, txt2b.Text, txt3b.Text, txt4b.Text, txt5b.Text)
        dblAv = calculateAverage(dblScores)
        Students(1) = createStructure(strName, dblScores, dblAv)

        If verifyName(txtStudentC.Text) Then
            strName = txtStudentC.Text
        Else
            strName = ""
        End If
        dblScores = createDoubleArray(txt1c.Text, txt2c.Text, txt3c.Text, txt4c.Text, txt5c.Text)
        dblAv = calculateAverage(dblScores)
        Students(2) = createStructure(strName, dblScores, dblAv)

        If verifyName(txtStudentD.Text) Then
            strName = txtStudentD.Text
        Else
            strName = ""
        End If
        dblScores = createDoubleArray(txt1d.Text, txt2d.Text, txt3d.Text, txt4d.Text, txt5d.Text)
        dblAv = calculateAverage(dblScores)
        Students(3) = createStructure(strName, dblScores, dblAv)

        If verifyName(txtStudentE.Text) Then
            strName = txtStudentE.Text
        Else
            strName = ""
        End If
        dblScores = createDoubleArray(txt1e.Text, txt2e.Text, txt3e.Text, txt4e.Text, txt5e.Text)
        dblAv = calculateAverage(dblScores)
        Students(4) = createStructure(strName, dblScores, dblAv)

        If verifyName(txtStudentF.Text) Then
            strName = txtStudentF.Text
        Else
            strName = ""
        End If
        dblScores = createDoubleArray(txt1f.Text, txt2f.Text, txt3f.Text, txt4f.Text, txt5f.Text)
        dblAv = calculateAverage(dblScores)
        Students(5) = createStructure(strName, dblScores, dblAv)
    End Sub
    'Form Closing Warning
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim strInput = InputBox("Do you want to Close the application? Type Y or Yes for yes")
        strInput = strInput.ToUpper
        If strInput = "Y" Or strInput = "YES" Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
    'Create Structure Array, and Assign Default Values on Form Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Const intStdMAX As Integer = 5
        ReDim Students(intStdMAX)

        For intIndex = 0 To intStdMAX
            Students(intIndex).strStudentName = "Student"
            ReDim Students(intIndex).dblScores(intMAX_INDEX)
            For intInnerIndex = 0 To intMAX_INDEX
                Students(intIndex).dblScores(intInnerIndex) = 0.0
            Next
            Students(intIndex).dblAverage = 0.0
        Next

        setTextboxes()

        txtavA.Text = String.Empty
        txtavB.Text = String.Empty
        txtavC.Text = String.Empty
        txtavD.Text = String.Empty
        txtavE.Text = String.Empty
        txtavF.Text = String.Empty
    End Sub
    'Set Textboxes with Values from Structures
    Private Sub setTextboxes()
        'I want to simplify this with a For loop, but dont know how I can using explicitly named textfields

        txtStudentA.Text = Students(0).strStudentName
        txt1a.Text = Students(0).dblScores(0).ToString
        txt2a.Text = Students(0).dblScores(1).ToString
        txt3a.Text = Students(0).dblScores(2).ToString
        txt4a.Text = Students(0).dblScores(3).ToString
        txt5a.Text = Students(0).dblScores(4).ToString
        txtavA.Text = Students(0).dblAverage.ToString

        txtStudentB.Text = Students(1).strStudentName
        txt1b.Text = Students(1).dblScores(0).ToString
        txt2b.Text = Students(1).dblScores(1).ToString
        txt3b.Text = Students(1).dblScores(2).ToString
        txt4b.Text = Students(1).dblScores(3).ToString
        txt5b.Text = Students(1).dblScores(4).ToString
        txtavB.Text = Students(1).dblAverage.ToString

        txtStudentC.Text = Students(2).strStudentName
        txt1c.Text = Students(2).dblScores(0).ToString
        txt2c.Text = Students(2).dblScores(1).ToString
        txt3c.Text = Students(2).dblScores(2).ToString
        txt4c.Text = Students(2).dblScores(3).ToString
        txt5c.Text = Students(2).dblScores(4).ToString
        txtavC.Text = Students(2).dblAverage.ToString

        txtStudentD.Text = Students(3).strStudentName
        txt1d.Text = Students(3).dblScores(0).ToString
        txt2d.Text = Students(3).dblScores(1).ToString
        txt3d.Text = Students(3).dblScores(2).ToString
        txt4d.Text = Students(3).dblScores(3).ToString
        txt5d.Text = Students(3).dblScores(4).ToString
        txtavD.Text = Students(3).dblAverage.ToString

        txtStudentE.Text = Students(4).strStudentName
        txt1e.Text = Students(4).dblScores(0).ToString
        txt2e.Text = Students(4).dblScores(1).ToString
        txt3e.Text = Students(4).dblScores(2).ToString
        txt4e.Text = Students(4).dblScores(3).ToString
        txt5e.Text = Students(4).dblScores(4).ToString
        txtavE.Text = Students(4).dblAverage.ToString

        txtStudentF.Text = Students(5).strStudentName
        txt1f.Text = Students(5).dblScores(0).ToString
        txt2f.Text = Students(5).dblScores(1).ToString
        txt3f.Text = Students(5).dblScores(2).ToString
        txt4f.Text = Students(5).dblScores(3).ToString
        txt5f.Text = Students(5).dblScores(4).ToString
        txtavF.Text = Students(5).dblAverage.ToString
    End Sub
    'Clear Textfields on Mouse Click
    Private Sub txtStudentA_MouseClick(sender As Object, e As MouseEventArgs) Handles txtStudentF.MouseClick, txtStudentE.MouseClick, txtStudentD.MouseClick, txtStudentC.MouseClick, txtStudentB.MouseClick, txtStudentA.MouseClick, txt5f.MouseClick, txt5e.MouseClick, txt5d.MouseClick, txt5c.MouseClick, txt5b.MouseClick, txt5a.MouseClick, txt4f.MouseClick, txt4e.MouseClick, txt4d.MouseClick, txt4c.MouseClick, txt4b.MouseClick, txt4a.MouseClick, txt3f.MouseClick, txt3e.MouseClick, txt3d.MouseClick, txt3c.MouseClick, txt3b.MouseClick, txt3a.MouseClick, txt2f.MouseClick, txt2e.MouseClick, txt2d.MouseClick, txt2c.MouseClick, txt2b.MouseClick, txt2a.MouseClick, txt1f.MouseClick, txt1e.MouseClick, txt1d.MouseClick, txt1c.MouseClick, txt1b.MouseClick, txt1a.MouseClick
        ActiveControl.Text = String.Empty
    End Sub
End Class
