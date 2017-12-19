<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel_Left = New System.Windows.Forms.Panel()
        Me.Au_Secours = New System.Windows.Forms.Button()
        Me.Propriétés = New System.Windows.Forms.Button()
        Me.Imprimer = New System.Windows.Forms.Button()
        Me.Rechercher = New System.Windows.Forms.Button()
        Me.SQL_Server = New System.Windows.Forms.Button()
        Me.Swap_Date = New System.Windows.Forms.Button()
        Me.Explorateur = New System.Windows.Forms.Button()
        Me.Iron_Text = New System.Windows.Forms.TextBox()
        Me.Masque = New System.Windows.Forms.Button()
        Me.Header = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel_Left.SuspendLayout()
        Me.Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Left
        '
        Me.Panel_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel_Left.Controls.Add(Me.Au_Secours)
        Me.Panel_Left.Controls.Add(Me.Propriétés)
        Me.Panel_Left.Controls.Add(Me.Imprimer)
        Me.Panel_Left.Controls.Add(Me.Rechercher)
        Me.Panel_Left.Controls.Add(Me.SQL_Server)
        Me.Panel_Left.Controls.Add(Me.Swap_Date)
        Me.Panel_Left.Controls.Add(Me.Explorateur)
        Me.Panel_Left.Controls.Add(Me.Iron_Text)
        Me.Panel_Left.Controls.Add(Me.Masque)
        Me.Panel_Left.Cursor = System.Windows.Forms.Cursors.Arrow
        resources.ApplyResources(Me.Panel_Left, "Panel_Left")
        Me.Panel_Left.Name = "Panel_Left"
        '
        'Au_Secours
        '
        resources.ApplyResources(Me.Au_Secours, "Au_Secours")
        Me.Au_Secours.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Au_Secours.FlatAppearance.BorderSize = 0
        Me.Au_Secours.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Au_Secours.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Au_Secours.Image = Global.SlidingPanel.My.Resources.Resources.Q
        Me.Au_Secours.Name = "Au_Secours"
        Me.Au_Secours.UseCompatibleTextRendering = True
        Me.Au_Secours.UseVisualStyleBackColor = True
        '
        'Propriétés
        '
        resources.ApplyResources(Me.Propriétés, "Propriétés")
        Me.Propriétés.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Propriétés.FlatAppearance.BorderSize = 0
        Me.Propriétés.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Propriétés.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Propriétés.Image = Global.SlidingPanel.My.Resources.Resources.System
        Me.Propriétés.Name = "Propriétés"
        Me.Propriétés.UseCompatibleTextRendering = True
        Me.Propriétés.UseVisualStyleBackColor = True
        '
        'Imprimer
        '
        resources.ApplyResources(Me.Imprimer, "Imprimer")
        Me.Imprimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Imprimer.FlatAppearance.BorderSize = 0
        Me.Imprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Imprimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Imprimer.Image = Global.SlidingPanel.My.Resources.Resources.Print
        Me.Imprimer.Name = "Imprimer"
        Me.Imprimer.UseCompatibleTextRendering = True
        Me.Imprimer.UseVisualStyleBackColor = True
        '
        'Rechercher
        '
        resources.ApplyResources(Me.Rechercher, "Rechercher")
        Me.Rechercher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Rechercher.FlatAppearance.BorderSize = 0
        Me.Rechercher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Rechercher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Rechercher.Image = Global.SlidingPanel.My.Resources.Resources.Loupe
        Me.Rechercher.Name = "Rechercher"
        Me.Rechercher.UseCompatibleTextRendering = True
        Me.Rechercher.UseVisualStyleBackColor = True
        '
        'SQL_Server
        '
        resources.ApplyResources(Me.SQL_Server, "SQL_Server")
        Me.SQL_Server.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SQL_Server.FlatAppearance.BorderSize = 0
        Me.SQL_Server.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SQL_Server.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.SQL_Server.Image = Global.SlidingPanel.My.Resources.Resources.BD
        Me.SQL_Server.Name = "SQL_Server"
        Me.SQL_Server.UseCompatibleTextRendering = True
        Me.SQL_Server.UseVisualStyleBackColor = True
        '
        'Swap_Date
        '
        resources.ApplyResources(Me.Swap_Date, "Swap_Date")
        Me.Swap_Date.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Swap_Date.FlatAppearance.BorderSize = 0
        Me.Swap_Date.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Swap_Date.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Swap_Date.Image = Global.SlidingPanel.My.Resources.Resources._1
        Me.Swap_Date.Name = "Swap_Date"
        Me.Swap_Date.UseCompatibleTextRendering = True
        Me.Swap_Date.UseVisualStyleBackColor = True
        '
        'Explorateur
        '
        resources.ApplyResources(Me.Explorateur, "Explorateur")
        Me.Explorateur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Explorateur.FlatAppearance.BorderSize = 0
        Me.Explorateur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Explorateur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Explorateur.Image = Global.SlidingPanel.My.Resources.Resources.WebNoir
        Me.Explorateur.Name = "Explorateur"
        Me.Explorateur.UseCompatibleTextRendering = True
        Me.Explorateur.UseVisualStyleBackColor = True
        '
        'Iron_Text
        '
        Me.Iron_Text.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Iron_Text.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.Iron_Text, "Iron_Text")
        Me.Iron_Text.ForeColor = System.Drawing.Color.White
        Me.Iron_Text.Name = "Iron_Text"
        '
        'Masque
        '
        resources.ApplyResources(Me.Masque, "Masque")
        Me.Masque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Masque.FlatAppearance.BorderSize = 0
        Me.Masque.Name = "Masque"
        Me.Masque.UseCompatibleTextRendering = True
        Me.Masque.UseVisualStyleBackColor = True
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Header.Controls.Add(Me.Button1)
        Me.Header.Controls.Add(Me.TextBox3)
        Me.Header.Controls.Add(Me.TextBox2)
        resources.ApplyResources(Me.Header, "Header")
        Me.Header.Name = "Header"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.TextBox3, "TextBox3")
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Name = "TextBox3"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.TextBox2, "TextBox2")
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Name = "TextBox2"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Controls.Add(Me.Panel_Left)
        Me.Controls.Add(Me.Header)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Panel_Left.ResumeLayout(False)
        Me.Panel_Left.PerformLayout()
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Left As Panel
    Friend WithEvents Masque As Button
    Friend WithEvents Header As Panel
    Friend WithEvents Iron_Text As TextBox
    Friend WithEvents Au_Secours As Button
    Friend WithEvents Propriétés As Button
    Friend WithEvents Imprimer As Button
    Friend WithEvents Rechercher As Button
    Friend WithEvents SQL_Server As Button
    Friend WithEvents Swap_Date As Button
    Friend WithEvents Explorateur As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
End Class
