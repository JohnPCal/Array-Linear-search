<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formLinearArray
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
        Me.btnInitiateArray = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnInitiateArray
        '
        Me.btnInitiateArray.Location = New System.Drawing.Point(98, 12)
        Me.btnInitiateArray.Name = "btnInitiateArray"
        Me.btnInitiateArray.Size = New System.Drawing.Size(181, 45)
        Me.btnInitiateArray.TabIndex = 0
        Me.btnInitiateArray.Text = "Initialise array"
        Me.btnInitiateArray.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(98, 193)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(181, 45)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(98, 113)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(181, 26)
        Me.txtFind.TabIndex = 2
        '
        'formLinearArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 252)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnInitiateArray)
        Me.Name = "formLinearArray"
        Me.Text = "Linear Array Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInitiateArray As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtFind As TextBox
End Class
