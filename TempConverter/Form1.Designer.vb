<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCelsius = New System.Windows.Forms.Label()
        Me.lblFahrenheit = New System.Windows.Forms.Label()
        Me.txtCelsius = New System.Windows.Forms.TextBox()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCelsius
        '
        Me.lblCelsius.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelsius.Location = New System.Drawing.Point(16, 31)
        Me.lblCelsius.Name = "lblCelsius"
        Me.lblCelsius.Size = New System.Drawing.Size(146, 34)
        Me.lblCelsius.TabIndex = 0
        Me.lblCelsius.Text = "Temperature on C"
        Me.lblCelsius.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFahrenheit
        '
        Me.lblFahrenheit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFahrenheit.Location = New System.Drawing.Point(16, 97)
        Me.lblFahrenheit.Name = "lblFahrenheit"
        Me.lblFahrenheit.Size = New System.Drawing.Size(146, 34)
        Me.lblFahrenheit.TabIndex = 1
        Me.lblFahrenheit.Text = "Temperature on F"
        Me.lblFahrenheit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCelsius
        '
        Me.txtCelsius.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelsius.Location = New System.Drawing.Point(181, 39)
        Me.txtCelsius.Name = "txtCelsius"
        Me.txtCelsius.Size = New System.Drawing.Size(131, 26)
        Me.txtCelsius.TabIndex = 2
        Me.txtCelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFahrenheit.Location = New System.Drawing.Point(180, 103)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(131, 26)
        Me.txtFahrenheit.TabIndex = 3
        Me.txtFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.Green
        Me.btnConvert.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnConvert.FlatAppearance.BorderSize = 0
        Me.btnConvert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConvert.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.ForeColor = System.Drawing.Color.Transparent
        Me.btnConvert.Location = New System.Drawing.Point(20, 159)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(291, 49)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Firebrick
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Transparent
        Me.btnClear.Location = New System.Drawing.Point(20, 224)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(291, 49)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(324, 294)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtFahrenheit)
        Me.Controls.Add(Me.txtCelsius)
        Me.Controls.Add(Me.lblFahrenheit)
        Me.Controls.Add(Me.lblCelsius)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(340, 333)
        Me.MinimumSize = New System.Drawing.Size(340, 333)
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.Text = "Temperature Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCelsius As System.Windows.Forms.Label
    Friend WithEvents lblFahrenheit As System.Windows.Forms.Label
    Friend WithEvents txtCelsius As System.Windows.Forms.TextBox
    Friend WithEvents txtFahrenheit As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
