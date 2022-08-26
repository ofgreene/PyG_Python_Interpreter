
Imports System.Text.RegularExpressions
Public Class Form1

    'ArrayList to store initially-parsed Python code in RichTextBox1 populated by GetPythonLines Sub
    Dim PythonLines As ArrayList = New ArrayList()
    'HashTable for storing relevant shape dimensions and characteristics populated in step two for use in final GCode output Sub
    Dim ShapeData As Hashtable = New Hashtable()
    Dim indexHeightWord As Integer
    Dim indexRadiusWord As Integer
    'ArrayList populated with finalized GCode to be read and displayed in RichTextBox3 in final step
    Dim GCodeLines As ArrayList = New ArrayList()
    ' Tester arraylist for step 2
    Dim Step2Tester As ArrayList = New ArrayList()

    Public Sub GetPythonLines(PythonCode As String)
        ' lookbehind regex operator saying "if there is a whitespace followed by "def" then split there, but keep the "def" as part of the substring"
        Dim delimiterPattern As String = "\s(?=def)"
        Dim CodeBlock() As String = Regex.Split(PythonCode, delimiterPattern)
        For Each block As String In CodeBlock
            PythonLines.Add(block)   ' + "SPLIT"

        Next
        'TESTING
        'For Each Line As String In PythonLines
        'RichTextBox3.AppendText(Line)
        'Next
    End Sub

    Public Sub GetShapeDataIndices(PythonLines As ArrayList)

        'Parse through each individual block of our Python code, which is still represented as an ArrayList PythonLines at this stage
        For Each blockRoundOne As String In PythonLines
            ' If this particular block of code contains "__init__" i.e. if it's our constructor method then:
            Dim constPattern As Regex = New Regex("_+\s*([i][n][i][t])")
            Dim match As Match = constPattern.Match(blockRoundOne)
            If match.Success Then
                ' split our block of code into an array of strings, split by whitespace 
                Dim individualWords() As String = Regex.Split(blockRoundOne, "\s+")

                ' initialize two variables to represent patterns we'll search in our chosen block.                
                Dim height As String = "height"
                Dim radius As String = "radius"

                ' get the indices of our height and radius patterns, this will tell us which comes first in the constructor, will help in the next part
                indexHeightWord = Array.IndexOf(individualWords, height, 0)
                indexRadiusWord = Array.IndexOf(individualWords, radius, 0)

                'TESTING
                'RichTextBox3.AppendText(blockRoundOne)
                'RichTextBox3.AppendText(blockRoundOne + "SPLIT")
                'Dim constPattern As String = "\s(?=init)"
                'If (Regex.IsMatch(blockRoundOne, constPattern)) Then

                'For Each test In individualWords
                'RichTextBox3.AppendText(test + "SPLIT")
                'Next

                'RichTextBox3.AppendText(indexHeightWord)
                'RichTextBox3.AppendText(indexRadiusWord)

            End If

        Next
    End Sub

    Public Sub GetShapeDataValues(indexHeightWord As Integer, indexRadiusWord As Integer)
        'TESTING
        'then parse through our individual blocks of code again find the one that has the object declaration with variable values (our shape dimensions!)
        'Dim cylinderPattern As String = "="
        'For Each blockRoundTwo As String In PythonLines
        '    ' If our block Of code has the Object declaration Then
        '    For Each Line As String In PythonLines
        '        RichTextBox3.AppendText(blockRoundTwo + "SPLIT")
        '    Next
        '    'If (Regex.IsMatch(blockRoundTwo, cylinderPattern)) Then
        '    '        ' initialize Int variables to hold indices of "(" And ","  And ")" from constructor line
        '    '        RichTextBox3.AppendText(block2)

        'Iterate through each block of code in our Python code one more
        For Each blockRoundTwo As String In PythonLines
            ' If the block of code has "Cylinder(" in it, I.e. if it's the block containing the Cylinder object instantiation
            Dim objDecPattern As Regex = New Regex("[C][y][l][i][n][d][e][r][(]")
            Dim match As Match = objDecPattern.Match(blockRoundTwo)
            If match.Success Then
                ' then create a string array indivChar(), split by ever7 single character
                Dim pattern As String = (".*")                   '"[0-9]+,[0-9]+"
                Dim indivChar() As String = Regex.Split(blockRoundTwo, pattern)

                ' variables for indices of the "(" "," and ")" characters, i.e. the characters immediately preceding the height and radius values
                Dim indexConstructorP1 As Integer = blockRoundTwo.LastIndexOf("(")
                Dim indexConstructorCom As Integer = blockRoundTwo.LastIndexOf(",")
                Dim indexConstructorP2 As Integer = blockRoundTwo.LastIndexOf(")")


                'TESTING
                'Dim indexPatternTester As Integer = Array.LastIndexOf(indivChar, "(")
                'Dim numberPatternTester As String = blockRoundTwo.Substring(indexPatternTester, 5)
                ' RichTextBox3.Text = numberPatternTester
                'RichTextBox3.Text = indexConstructorCom
                'RichTextBox3.AppendText(indexConstructorP1)
                'RichTextBox3.AppendText(indexConstructorCom)
                'RichTextBox3.AppendText(indexConstructorP2)

                'For Each indiv In indivChar
                'RichTextBox3.AppendText(indiv)
                'Next

                'If the index Of our radius variable Is less than the index Of our height variable: i.e. if radius is the first arg, and height the second
                If (indexRadiusWord < indexHeightWord) Then
                    ' String variable representing substring of our chosen block of text starting at the commona (height is second parameter in constructor
                    ' and to the end of the string, trim off the unecessary characters in next step
                    Dim sHeightValue As String = blockRoundTwo.Substring(indexConstructorCom)

                    ' creating an array of characters for use in TrimStart() and TrimEnd() methods for characters we dont want in out substrings containing Height and Radius
                    Dim charactersToTrim() As Char = New Char() {",", "' '", ")", "#", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                    "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
                    Dim charactersToTrim2() As Char = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}

                    ' Trimming off unwanted characters, in this case, everything not a number.
                    sHeightValue = sHeightValue.TrimStart(charactersToTrim)
                    ' then trimming off everyting else after the numerical characters
                    sHeightValue = sHeightValue.TrimEnd(charactersToTrim)

                    ' Finally, our height variable int value converted from substring isolated by the above line
                    Dim CylinderHeight As Integer = Integer.Parse(sHeightValue)

                    ' String variable to hold String value of our found radius parameter (radius is first parameter in constructor)
                    ' take everything after the opening parenth first
                    Dim sRadiusValue As String = blockRoundTwo.Substring(indexConstructorP1)

                    'CANNOT DO THIS, WILL KEEP HEIGHT VALUES AND CONCATENATE TO RADIUS VALUE 
                    'then trim everything that is not a number
                    sRadiusValue = sRadiusValue.Substring(sRadiusValue.IndexOf(",")).TrimEnd(charactersToTrim2)

                    ' Finally, our radius variable int value converted from substring isolated by the above line
                    Dim CylinderRadius As Integer = Integer.Parse(sRadiusValue.Trim)

                    ' Add height and radius int values to ShapeData HashTable with corresponding key names, for calling in final GCodeLines() sub
                    ShapeData.Add("CylinderHeight", CylinderHeight)
                    ShapeData.Add("CylinderRadius", CylinderRadius)

                    'TESTING
                    'RichTextBox3.AppendText(sHeightValue)
                    'RichTextBox3.AppendText(sHeightValue)
                    'RichTextBox3.AppendText(sRadiusValue)
                    'Step2Tester.Add(sRadiusValue)
                    'Step2Tester.Add(sHeightValue)

                    ' For Each ShapeTest As String In Step2Tester
                    ' RichTextBox3.AppendText(ShapeTest)
                    'Next
                Else
                    'else if index of height value index is less than radius value index, i.e. if height is the first arg and radius the second arg
                    Dim sHeightValue As String = blockRoundTwo.Substring(indexConstructorP1)

                    ' creating an array of characters for use in TrimStart() and TrimEnd() methods for characters we dont want in out substrings containing Height and Radius
                    Dim charactersToTrim() As Char = New Char() {",", "' '", ")", "#", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                    "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
                    Dim charactersToTrim2() As Char = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}

                    ' Trimming off unwanted characters, in this case, everything not a number.
                    sHeightValue = sHeightValue.TrimEnd(charactersToTrim)
                    ' AGAIN, WILL NOT WORK, cannot isolate only first value using TrimEnd() without losing height value as well or concatenating both digits together after removal of all non number char
                    ' then trimming off everyting else after the numerical characters
                    sHeightValue = sHeightValue.TrimEnd(charactersToTrim2)

                    ' Finally, our height variable int value converted from substring isolated by the above line
                    Dim CylinderHeight As Integer = Integer.Parse(sHeightValue)

                    ' String variable to hold String value of our found radius parameter (radius is first parameter in constructor)
                    ' take everything after the opening parenth first
                    Dim sRadiusValue As String = blockRoundTwo.Substring(indexConstructorCom)

                    'CANNOT DO THIS, WILL KEEP HEIGHT VALUES AND CONCATENATE TO RADIUS VALUE , cannot isolate one digit without sacrificing the other using TrimEnd()
                    'then trim everything that is not a number
                    sRadiusValue = sRadiusValue.Substring(sRadiusValue.IndexOf(",")).TrimStart(charactersToTrim2) ' does not work as comma is start of substring

                    ' Finally, our radius variable int value converted from substring isolated by the above line
                    Dim CylinderRadius As Integer = Integer.Parse(sRadiusValue.Trim)

                    ' Add height and radius int values to ShapeData HashTable with corresponding key names, for calling in final GCodeLines() sub
                    ShapeData.Add("CylinderHeight", CylinderHeight)
                    ShapeData.Add("CylinderRadius", CylinderRadius)

                End If
            End If
        Next

    End Sub

    Private Sub pbSave_Click(sender As Object, e As EventArgs) Handles pbSave.Click
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
            Then
            My.Computer.FileSystem.WriteAllText _
                (SaveFileDialog1.FileName, RichTextBox3.Text, True)
        End If
    End Sub

    Private Sub pbOpen_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbOpen.Click

        Dim myOpenFileDialog As New OpenFileDialog()


        myOpenFileDialog.CheckFileExists = True
        myOpenFileDialog.DefaultExt = "txt"
        myOpenFileDialog.InitialDirectory = "D:\PyG\PyG\"
        myOpenFileDialog.Multiselect = False

        If myOpenFileDialog.ShowDialog = DialogResult.OK Then
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(myOpenFileDialog.FileName)
        End If

    End Sub

    Private Sub treeList_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treeLibrary.AfterSelect
        RichTextBox2.Text = treeLibrary.SelectedNode.Tag
    End Sub
    Public Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        'Dim fileReader As String
        'fileReader = My.Computer.FileSystem.ReadAllText("D:\PyG\PyG\PythonCylinderExample.txt")
        'RichTextBox1.Text = fileReader

        Dim PythonCode As String = RichTextBox1.Text

        GetPythonLines(PythonCode)
        GetShapeDataIndices(PythonLines)
        GetShapeDataValues(indexHeightWord, indexRadiusWord)

        'GetGCodeLines(ShapeData As HashTable)
        'Dim key As ICollection = ShapeData.Keys
        'For Each k In key
        'RichTextBox3.AppendText(k)


        ' 6/8/22 Idea for how to tackle CONTD:
        ' Use string variable initialized in Open button sup as translation method input parameter.
        ' Declare and initialize a new ArrayList of string elements split on certain character delimiters. Possiblly last whitespace
        ' character before first word character in each line.
        ' pass arraylist elements through while loop containing conditonals for different character patterns and manipulating them to
        ' fit G-Code syntax based on which character patterns match (i.e. I'm using Regex patterns to match and then manipulate the string elements
        ' should the match be found. That's how I'll do the translation of the code. Or most of the it.
        ' and then based on which G-Code options i've selected in my GUI dropdowns they will generate additional supplementary lines of code for the 
        ' script's back end functionality like the code to turn on the machine will always be at the top so the button will automatically insert that
        ' into the first line of the script, and the last line will always be to turn off the machine tool etc etc. That's all easier stuff.
        ' main body of the work is still in getting this string manipulation and file writing to function properly since that's the heart of the program.

    End Sub
    'Public Sub pbOpen_Click(sender As Object, e As EventArgs) Handles pbOpen.Click
    '    If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
    '        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)

    '    End If


    '    'Dim fileReader As String
    '    'fileReader = My.Computer.FileSystem.ReadAllText("D:\PyG\PyG\PythonCylinderExample.txt")
    '    'RichTextBox1.Text = fileReader


    '    ' 5/28/22 Idea for how to tackle:
    '    ' take richtextbox1.text and set as value for string variable to use to RUN Button as translation method intake string parameter.
    '    ' See RUN button sub for next steps.
    'End Sub

    Public Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Application.Restart()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim addCmd As String = treeLibrary.SelectedNode.Name + vbNewLine
        RichTextBox3.AppendText(addCmd)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        ' RichTextBox3.Text = RichTextBox3.Text.Remove(RichTextBox3.Text.LastIndexOf(Environment.NewLine))

    End Sub

    Private Sub toolbtn2_Click(sender As Object, e As EventArgs) Handles toolbtn2.Click
        Dim gitHub As String = "https://github.com/ofgreene"
        Process.Start(gitHub)
    End Sub

    Private Sub toolbtn1_Click(sender As Object, e As EventArgs) Handles toolbtn1.Click
        Dim python As String = "https://www.python.org/"
        Process.Start(python)
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Dim glossary As String = "https://cncphilosophy.com/cnc-milling-machine-terminology/"
        Process.Start(glossary)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("D:\PyG\PyG\GCodeExampleCylinderPipe.txt")
        Dim PythonCode As String = fileReader
        RichTextBox3.AppendText(PythonCode)
    End Sub
    Public Sub GetGCodeLines()

    End Sub
    Private Sub pnlPython_Paint(sender As Object, e As PaintEventArgs) Handles pnlPython.Paint

    End Sub

    Private Sub menuMain_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles menuMain.ItemClicked

    End Sub

    Private Sub toolbtn1_Hover(sender As Object, e As EventArgs) Handles toolbtn1.MouseHover
        toolbtn1.Text = "Test"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub iconCNC_Click(sender As Object, e As EventArgs) Handles iconCNC.Click
        lblCNC.ForeColor = Color.MediumBlue
        lblCAD.ForeColor = Color.Black
        lblText.ForeColor = Color.Black
    End Sub

    Private Sub iconCAD_Click(sender As Object, e As EventArgs) Handles iconCAD.Click
        lblCAD.ForeColor = Color.MediumBlue
        lblCNC.ForeColor = Color.Black
        lblText.ForeColor = Color.Black

    End Sub

    Private Sub iconText_Click(sender As Object, e As EventArgs) Handles iconText.Click
        lblText.ForeColor = Color.MediumBlue
        lblCAD.ForeColor = Color.Black
        lblCNC.ForeColor = Color.Black

    End Sub
End Class
