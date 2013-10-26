<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSURF
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
		Me.gbChooseImageScene = New System.Windows.Forms.GroupBox()
		Me.rdoWebcam = New System.Windows.Forms.RadioButton()
		Me.rdoImageFile = New System.Windows.Forms.RadioButton()
		Me.lblImageScene = New System.Windows.Forms.Label()
		Me.lblImageToFind = New System.Windows.Forms.Label()
		Me.txtImageScene = New System.Windows.Forms.TextBox()
		Me.txtImageToFind = New System.Windows.Forms.TextBox()
		Me.btnImageScene = New System.Windows.Forms.Button()
		Me.btnImageToFind = New System.Windows.Forms.Button()
		Me.btnPerformSURFOrGetImageToTrack = New System.Windows.Forms.Button()
		Me.ckDrawKeyPoints = New System.Windows.Forms.CheckBox()
		Me.ckDrawMatchingLines = New System.Windows.Forms.CheckBox()
		Me.ibResult = New Emgu.CV.UI.ImageBox()
		Me.ofdImageScene = New System.Windows.Forms.OpenFileDialog()
		Me.ofdImageToFind = New System.Windows.Forms.OpenFileDialog()
		Me.gbChooseImageScene.SuspendLayout
		CType(Me.ibResult,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'gbChooseImageScene
		'
		Me.gbChooseImageScene.Controls.Add(Me.rdoWebcam)
		Me.gbChooseImageScene.Controls.Add(Me.rdoImageFile)
		Me.gbChooseImageScene.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gbChooseImageScene.Location = New System.Drawing.Point(2, 2)
		Me.gbChooseImageScene.Name = "gbChooseImageScene"
		Me.gbChooseImageScene.Size = New System.Drawing.Size(190, 80)
		Me.gbChooseImageScene.TabIndex = 0
		Me.gbChooseImageScene.TabStop = false
		Me.gbChooseImageScene.Text = "choose image source:"
		'
		'rdoWebcam
		'
		Me.rdoWebcam.AutoSize = true
		Me.rdoWebcam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.rdoWebcam.Location = New System.Drawing.Point(22, 52)
		Me.rdoWebcam.Name = "rdoWebcam"
		Me.rdoWebcam.Size = New System.Drawing.Size(92, 24)
		Me.rdoWebcam.TabIndex = 1
		Me.rdoWebcam.Text = "webcam"
		Me.rdoWebcam.UseVisualStyleBackColor = true
		'
		'rdoImageFile
		'
		Me.rdoImageFile.AutoSize = true
		Me.rdoImageFile.Checked = true
		Me.rdoImageFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.rdoImageFile.Location = New System.Drawing.Point(22, 26)
		Me.rdoImageFile.Name = "rdoImageFile"
		Me.rdoImageFile.Size = New System.Drawing.Size(102, 24)
		Me.rdoImageFile.TabIndex = 0
		Me.rdoImageFile.TabStop = true
		Me.rdoImageFile.Text = "image file"
		Me.rdoImageFile.UseVisualStyleBackColor = true
		'
		'lblImageScene
		'
		Me.lblImageScene.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblImageScene.Location = New System.Drawing.Point(196, 0)
		Me.lblImageScene.Name = "lblImageScene"
		Me.lblImageScene.Size = New System.Drawing.Size(274, 26)
		Me.lblImageScene.TabIndex = 1
		Me.lblImageScene.Text = "choose image scene:"
		Me.lblImageScene.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblImageToFind
		'
		Me.lblImageToFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblImageToFind.Location = New System.Drawing.Point(194, 28)
		Me.lblImageToFind.Name = "lblImageToFind"
		Me.lblImageToFind.Size = New System.Drawing.Size(276, 26)
		Me.lblImageToFind.TabIndex = 2
		Me.lblImageToFind.Text = "choose sub-image to find in scene:"
		Me.lblImageToFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'txtImageScene
		'
		Me.txtImageScene.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtImageScene.Location = New System.Drawing.Point(470, 0)
		Me.txtImageScene.Name = "txtImageScene"
		Me.txtImageScene.ReadOnly = true
		Me.txtImageScene.Size = New System.Drawing.Size(264, 27)
		Me.txtImageScene.TabIndex = 3
		'
		'txtImageToFind
		'
		Me.txtImageToFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtImageToFind.Location = New System.Drawing.Point(470, 28)
		Me.txtImageToFind.Name = "txtImageToFind"
		Me.txtImageToFind.ReadOnly = true
		Me.txtImageToFind.Size = New System.Drawing.Size(264, 27)
		Me.txtImageToFind.TabIndex = 4
		'
		'btnImageScene
		'
		Me.btnImageScene.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnImageScene.Location = New System.Drawing.Point(734, 2)
		Me.btnImageScene.Name = "btnImageScene"
		Me.btnImageScene.Size = New System.Drawing.Size(30, 24)
		Me.btnImageScene.TabIndex = 5
		Me.btnImageScene.Text = "..."
		Me.btnImageScene.UseVisualStyleBackColor = true
		'
		'btnImageToFind
		'
		Me.btnImageToFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnImageToFind.Location = New System.Drawing.Point(734, 30)
		Me.btnImageToFind.Name = "btnImageToFind"
		Me.btnImageToFind.Size = New System.Drawing.Size(30, 24)
		Me.btnImageToFind.TabIndex = 6
		Me.btnImageToFind.Text = "..."
		Me.btnImageToFind.UseVisualStyleBackColor = true
		'
		'btnPerformSURFOrGetImageToTrack
		'
		Me.btnPerformSURFOrGetImageToTrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnPerformSURFOrGetImageToTrack.Location = New System.Drawing.Point(772, 2)
		Me.btnPerformSURFOrGetImageToTrack.Name = "btnPerformSURFOrGetImageToTrack"
		Me.btnPerformSURFOrGetImageToTrack.Size = New System.Drawing.Size(152, 52)
		Me.btnPerformSURFOrGetImageToTrack.TabIndex = 7
		Me.btnPerformSURFOrGetImageToTrack.Text = "Perform SURF Detection"
		Me.btnPerformSURFOrGetImageToTrack.UseVisualStyleBackColor = true
		'
		'ckDrawKeyPoints
		'
		Me.ckDrawKeyPoints.AutoSize = true
		Me.ckDrawKeyPoints.Checked = true
		Me.ckDrawKeyPoints.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ckDrawKeyPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.ckDrawKeyPoints.Location = New System.Drawing.Point(342, 60)
		Me.ckDrawKeyPoints.Name = "ckDrawKeyPoints"
		Me.ckDrawKeyPoints.Size = New System.Drawing.Size(142, 24)
		Me.ckDrawKeyPoints.TabIndex = 8
		Me.ckDrawKeyPoints.Text = "draw keypoints"
		Me.ckDrawKeyPoints.UseVisualStyleBackColor = true
		'
		'ckDrawMatchingLines
		'
		Me.ckDrawMatchingLines.AutoSize = true
		Me.ckDrawMatchingLines.Checked = true
		Me.ckDrawMatchingLines.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ckDrawMatchingLines.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.ckDrawMatchingLines.Location = New System.Drawing.Point(500, 60)
		Me.ckDrawMatchingLines.Name = "ckDrawMatchingLines"
		Me.ckDrawMatchingLines.Size = New System.Drawing.Size(180, 24)
		Me.ckDrawMatchingLines.TabIndex = 9
		Me.ckDrawMatchingLines.Text = "draw matching lines"
		Me.ckDrawMatchingLines.UseVisualStyleBackColor = true
		'
		'ibResult
		'
		Me.ibResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ibResult.Enabled = false
		Me.ibResult.Location = New System.Drawing.Point(2, 88)
		Me.ibResult.Name = "ibResult"
		Me.ibResult.Size = New System.Drawing.Size(960, 480)
		Me.ibResult.TabIndex = 2
		Me.ibResult.TabStop = false
		'
		'frmSURF
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(964, 570)
		Me.Controls.Add(Me.ibResult)
		Me.Controls.Add(Me.ckDrawMatchingLines)
		Me.Controls.Add(Me.ckDrawKeyPoints)
		Me.Controls.Add(Me.btnPerformSURFOrGetImageToTrack)
		Me.Controls.Add(Me.btnImageToFind)
		Me.Controls.Add(Me.btnImageScene)
		Me.Controls.Add(Me.txtImageToFind)
		Me.Controls.Add(Me.txtImageScene)
		Me.Controls.Add(Me.lblImageToFind)
		Me.Controls.Add(Me.lblImageScene)
		Me.Controls.Add(Me.gbChooseImageScene)
		Me.Name = "frmSURF"
		Me.Text = "Instructions: use ""..."" buttons to choose both image files, then press Perform SU"& _ 
    "RF button"
		Me.gbChooseImageScene.ResumeLayout(false)
		Me.gbChooseImageScene.PerformLayout
		CType(Me.ibResult,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub
    Friend WithEvents gbChooseImageScene As System.Windows.Forms.GroupBox
    Friend WithEvents rdoWebcam As System.Windows.Forms.RadioButton
    Friend WithEvents rdoImageFile As System.Windows.Forms.RadioButton
    Friend WithEvents lblImageScene As System.Windows.Forms.Label
    Friend WithEvents lblImageToFind As System.Windows.Forms.Label
    Friend WithEvents txtImageScene As System.Windows.Forms.TextBox
    Friend WithEvents txtImageToFind As System.Windows.Forms.TextBox
    Friend WithEvents btnImageScene As System.Windows.Forms.Button
    Friend WithEvents btnImageToFind As System.Windows.Forms.Button
    Friend WithEvents btnPerformSURFOrGetImageToTrack As System.Windows.Forms.Button
    Friend WithEvents ckDrawKeyPoints As System.Windows.Forms.CheckBox
    Friend WithEvents ckDrawMatchingLines As System.Windows.Forms.CheckBox
    Friend WithEvents ibResult As Emgu.CV.UI.ImageBox
    Friend WithEvents ofdImageScene As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ofdImageToFind As System.Windows.Forms.OpenFileDialog

End Class
