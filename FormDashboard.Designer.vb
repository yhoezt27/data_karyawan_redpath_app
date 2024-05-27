Imports Org.BouncyCastle.Pqc.Crypto

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBoxEtnisPapua = New GroupBox()
        TextBoxEtnisPapua = New TextBox()
        LabelEtnisPapua = New Label()
        GroupBoxEtnisNonPapua = New GroupBox()
        TextBoxEtnisNonPapua = New TextBox()
        LabelEtnisNonPapua = New Label()
        GroupBoxSevenTribes = New GroupBox()
        TextBoxSevenTribes = New TextBox()
        LabelSevenTribes = New Label()
        GroupBoxMendekatiPensiun = New GroupBox()
        TextBoxMendekatiPensiun = New TextBox()
        LabelMendekatiPensiun = New Label()
        ButtonRefresh = New Button()
        GroupBoxEtnisPapua.SuspendLayout()
        GroupBoxEtnisNonPapua.SuspendLayout()
        GroupBoxSevenTribes.SuspendLayout()
        GroupBoxMendekatiPensiun.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBoxEtnisPapua
        ' 
        GroupBoxEtnisPapua.Controls.Add(TextBoxEtnisPapua)
        GroupBoxEtnisPapua.Controls.Add(LabelEtnisPapua)
        GroupBoxEtnisPapua.Location = New Point(12, 12)
        GroupBoxEtnisPapua.Name = "GroupBoxEtnisPapua"
        GroupBoxEtnisPapua.Size = New Size(200, 100)
        GroupBoxEtnisPapua.TabIndex = 0
        GroupBoxEtnisPapua.TabStop = False
        GroupBoxEtnisPapua.Text = "Etnis Papua"
        ' 
        ' TextBoxEtnisPapua
        ' 
        TextBoxEtnisPapua.Location = New Point(6, 48)
        TextBoxEtnisPapua.Name = "TextBoxEtnisPapua"
        TextBoxEtnisPapua.ReadOnly = True
        TextBoxEtnisPapua.Size = New Size(188, 23)
        TextBoxEtnisPapua.TabIndex = 1
        ' 
        ' LabelEtnisPapua
        ' 
        LabelEtnisPapua.AutoSize = True
        LabelEtnisPapua.Location = New Point(6, 25)
        LabelEtnisPapua.Name = "LabelEtnisPapua"
        LabelEtnisPapua.Size = New Size(89, 15)
        LabelEtnisPapua.TabIndex = 0
        LabelEtnisPapua.Text = "Jumlah Pekerja:"
        ' 
        ' GroupBoxEtnisNonPapua
        ' 
        GroupBoxEtnisNonPapua.Controls.Add(TextBoxEtnisNonPapua)
        GroupBoxEtnisNonPapua.Controls.Add(LabelEtnisNonPapua)
        GroupBoxEtnisNonPapua.Location = New Point(228, 12)
        GroupBoxEtnisNonPapua.Name = "GroupBoxEtnisNonPapua"
        GroupBoxEtnisNonPapua.Size = New Size(200, 100)
        GroupBoxEtnisNonPapua.TabIndex = 1
        GroupBoxEtnisNonPapua.TabStop = False
        GroupBoxEtnisNonPapua.Text = "Etnis Non Papua"
        ' 
        ' TextBoxEtnisNonPapua
        ' 
        TextBoxEtnisNonPapua.Location = New Point(6, 48)
        TextBoxEtnisNonPapua.Name = "TextBoxEtnisNonPapua"
        TextBoxEtnisNonPapua.ReadOnly = True
        TextBoxEtnisNonPapua.Size = New Size(188, 23)
        TextBoxEtnisNonPapua.TabIndex = 1
        ' 
        ' LabelEtnisNonPapua
        ' 
        LabelEtnisNonPapua.AutoSize = True
        LabelEtnisNonPapua.Location = New Point(6, 25)
        LabelEtnisNonPapua.Name = "LabelEtnisNonPapua"
        LabelEtnisNonPapua.Size = New Size(89, 15)
        LabelEtnisNonPapua.TabIndex = 0
        LabelEtnisNonPapua.Text = "Jumlah Pekerja:"
        ' 
        ' GroupBoxSevenTribes
        ' 
        GroupBoxSevenTribes.Controls.Add(TextBoxSevenTribes)
        GroupBoxSevenTribes.Controls.Add(LabelSevenTribes)
        GroupBoxSevenTribes.Location = New Point(12, 118)
        GroupBoxSevenTribes.Name = "GroupBoxSevenTribes"
        GroupBoxSevenTribes.Size = New Size(200, 100)
        GroupBoxSevenTribes.TabIndex = 2
        GroupBoxSevenTribes.TabStop = False
        GroupBoxSevenTribes.Text = "7 Tribes"
        ' 
        ' TextBoxSevenTribes
        ' 
        TextBoxSevenTribes.Location = New Point(6, 48)
        TextBoxSevenTribes.Name = "TextBoxSevenTribes"
        TextBoxSevenTribes.ReadOnly = True
        TextBoxSevenTribes.Size = New Size(188, 23)
        TextBoxSevenTribes.TabIndex = 1
        ' 
        ' LabelSevenTribes
        ' 
        LabelSevenTribes.AutoSize = True
        LabelSevenTribes.Location = New Point(6, 25)
        LabelSevenTribes.Name = "LabelSevenTribes"
        LabelSevenTribes.Size = New Size(89, 15)
        LabelSevenTribes.TabIndex = 0
        LabelSevenTribes.Text = "Jumlah Pekerja:"
        ' 
        ' GroupBoxMendekatiPensiun
        ' 
        GroupBoxMendekatiPensiun.Controls.Add(TextBoxMendekatiPensiun)
        GroupBoxMendekatiPensiun.Controls.Add(LabelMendekatiPensiun)
        GroupBoxMendekatiPensiun.Location = New Point(228, 118)
        GroupBoxMendekatiPensiun.Name = "GroupBoxMendekatiPensiun"
        GroupBoxMendekatiPensiun.Size = New Size(200, 100)
        GroupBoxMendekatiPensiun.TabIndex = 3
        GroupBoxMendekatiPensiun.TabStop = False
        GroupBoxMendekatiPensiun.Text = "Mendekati Pensiun"
        ' 
        ' TextBoxMendekatiPensiun
        ' 
        TextBoxMendekatiPensiun.Location = New Point(6, 48)
        TextBoxMendekatiPensiun.Name = "TextBoxMendekatiPensiun"
        TextBoxMendekatiPensiun.ReadOnly = True
        TextBoxMendekatiPensiun.Size = New Size(188, 23)
        TextBoxMendekatiPensiun.TabIndex = 1
        ' 
        ' LabelMendekatiPensiun
        ' 
        LabelMendekatiPensiun.AutoSize = True
        LabelMendekatiPensiun.Location = New Point(6, 25)
        LabelMendekatiPensiun.Name = "LabelMendekatiPensiun"
        LabelMendekatiPensiun.Size = New Size(89, 15)
        LabelMendekatiPensiun.TabIndex = 0
        LabelMendekatiPensiun.Text = "Jumlah Pekerja:"
        ' 
        ' ButtonRefresh
        ' 
        ButtonRefresh.Location = New Point(353, 224)
        ButtonRefresh.Name = "ButtonRefresh"
        ButtonRefresh.Size = New Size(75, 23)
        ButtonRefresh.TabIndex = 4
        ButtonRefresh.Text = "Refresh"
        ButtonRefresh.UseVisualStyleBackColor = True
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(444, 259)
        Controls.Add(ButtonRefresh)
        Controls.Add(GroupBoxMendekatiPensiun)
        Controls.Add(GroupBoxSevenTribes)
        Controls.Add(GroupBoxEtnisNonPapua)
        Controls.Add(GroupBoxEtnisPapua)
        Name = "FormDashboard"
        Text = "Dashboard"
        GroupBoxEtnisPapua.ResumeLayout(False)
        GroupBoxEtnisPapua.PerformLayout()
        GroupBoxEtnisNonPapua.ResumeLayout(False)
        GroupBoxEtnisNonPapua.PerformLayout()
        GroupBoxSevenTribes.ResumeLayout(False)
        GroupBoxSevenTribes.PerformLayout()
        GroupBoxMendekatiPensiun.ResumeLayout(False)
        GroupBoxMendekatiPensiun.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxEtnisPapua As GroupBox
    Friend WithEvents TextBoxEtnisPapua As TextBox
    Friend WithEvents LabelEtnisPapua As Label
    Friend WithEvents GroupBoxEtnisNonPapua As GroupBox
    Friend WithEvents TextBoxEtnisNonPapua As TextBox
    Friend WithEvents LabelEtnisNonPapua As Label
    Friend WithEvents GroupBoxSevenTribes As GroupBox
    Friend WithEvents TextBoxSevenTribes As TextBox
    Friend WithEvents LabelSevenTribes As Label
    Friend WithEvents GroupBoxMendekatiPensiun As GroupBox
    Friend WithEvents TextBoxMendekatiPensiun As TextBox
    Friend WithEvents LabelMendekatiPensiun As Label
    Friend WithEvents ButtonRefresh As Button

End Class
