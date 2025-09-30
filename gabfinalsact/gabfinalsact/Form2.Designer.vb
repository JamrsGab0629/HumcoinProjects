<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Size = New GroupBox()
        rbLarge = New RadioButton()
        rbSmall = New RadioButton()
        rbMedium = New RadioButton()
        txtBreadSticks = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtChickenWings = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txtBreadSticksTotal = New TextBox()
        txtChickenWingsTotal = New TextBox()
        Label5 = New Label()
        txtSideOrdersTotal = New TextBox()
        Label6 = New Label()
        GroupBox1 = New GroupBox()
        chkOlives = New CheckBox()
        chkOnions = New CheckBox()
        chkSausage = New CheckBox()
        chkPepperoni = New CheckBox()
        chkCheese = New CheckBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        txtSodaCan = New TextBox()
        txtSoda8oz = New TextBox()
        txtSoda15L = New TextBox()
        txtJuice = New TextBox()
        txtWater = New TextBox()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        txtSodaCanTotal = New TextBox()
        txtSoda8ozTotal = New TextBox()
        txtSoda15LTotal = New TextBox()
        txtJuiceTotal = New TextBox()
        txtWaterTotal = New TextBox()
        Label21 = New Label()
        txtToppingsTotal = New TextBox()
        Label22 = New Label()
        txtDrinksTotal = New TextBox()
        Label23 = New Label()
        txtTotal = New TextBox()
        btnHome = New Button()
        btnCompute = New Button()
        PictureBox1 = New PictureBox()
        Label24 = New Label()
        Size.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Size
        ' 
        Size.Controls.Add(rbLarge)
        Size.Controls.Add(rbSmall)
        Size.Controls.Add(rbMedium)
        Size.Location = New Point(70, 115)
        Size.Name = "Size"
        Size.Size = New Size(163, 100)
        Size.TabIndex = 0
        Size.TabStop = False
        Size.Text = "Size"
        ' 
        ' rbLarge
        ' 
        rbLarge.AutoSize = True
        rbLarge.Location = New Point(6, 75)
        rbLarge.Name = "rbLarge"
        rbLarge.Size = New Size(95, 19)
        rbLarge.TabIndex = 2
        rbLarge.TabStop = True
        rbLarge.Text = "Large(400.00)"
        rbLarge.UseVisualStyleBackColor = True
        ' 
        ' rbSmall
        ' 
        rbSmall.AutoSize = True
        rbSmall.Location = New Point(6, 22)
        rbSmall.Name = "rbSmall"
        rbSmall.Size = New Size(95, 19)
        rbSmall.TabIndex = 1
        rbSmall.TabStop = True
        rbSmall.Text = "Small(150.00)"
        rbSmall.UseVisualStyleBackColor = True
        ' 
        ' rbMedium
        ' 
        rbMedium.AutoSize = True
        rbMedium.Location = New Point(6, 47)
        rbMedium.Name = "rbMedium"
        rbMedium.Size = New Size(111, 19)
        rbMedium.TabIndex = 1
        rbMedium.TabStop = True
        rbMedium.Text = "Medium(250.00)"
        rbMedium.UseVisualStyleBackColor = True
        ' 
        ' txtBreadSticks
        ' 
        txtBreadSticks.Location = New Point(515, 111)
        txtBreadSticks.Name = "txtBreadSticks"
        txtBreadSticks.Size = New Size(64, 23)
        txtBreadSticks.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(412, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 19)
        Label1.TabIndex = 2
        Label1.Text = "Bread Sticks"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(401, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 19)
        Label2.TabIndex = 3
        Label2.Text = "ChickenWings"
        ' 
        ' txtChickenWings
        ' 
        txtChickenWings.Location = New Point(515, 145)
        txtChickenWings.Name = "txtChickenWings"
        txtChickenWings.Size = New Size(64, 23)
        txtChickenWings.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(603, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 19)
        Label3.TabIndex = 5
        Label3.Text = "30.00"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(603, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 19)
        Label4.TabIndex = 6
        Label4.Text = "90.00"
        ' 
        ' txtBreadSticksTotal
        ' 
        txtBreadSticksTotal.Location = New Point(665, 111)
        txtBreadSticksTotal.Name = "txtBreadSticksTotal"
        txtBreadSticksTotal.Size = New Size(64, 23)
        txtBreadSticksTotal.TabIndex = 7
        ' 
        ' txtChickenWingsTotal
        ' 
        txtChickenWingsTotal.Location = New Point(665, 149)
        txtChickenWingsTotal.Name = "txtChickenWingsTotal"
        txtChickenWingsTotal.Size = New Size(64, 23)
        txtChickenWingsTotal.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(367, 182)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 19)
        Label5.TabIndex = 9
        Label5.Text = "Total Side Orders"
        ' 
        ' txtSideOrdersTotal
        ' 
        txtSideOrdersTotal.Location = New Point(652, 178)
        txtSideOrdersTotal.Name = "txtSideOrdersTotal"
        txtSideOrdersTotal.Size = New Size(116, 23)
        txtSideOrdersTotal.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(465, 85)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 19)
        Label6.TabIndex = 11
        Label6.Text = "Side Orders"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(chkOlives)
        GroupBox1.Controls.Add(chkOnions)
        GroupBox1.Controls.Add(chkSausage)
        GroupBox1.Controls.Add(chkPepperoni)
        GroupBox1.Controls.Add(chkCheese)
        GroupBox1.Location = New Point(56, 221)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(177, 156)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Additional Toppings"
        ' 
        ' chkOlives
        ' 
        chkOlives.AutoSize = True
        chkOlives.Location = New Point(16, 124)
        chkOlives.Name = "chkOlives"
        chkOlives.Size = New Size(96, 19)
        chkOlives.TabIndex = 4
        chkOlives.Text = "Olives (25.00)"
        chkOlives.UseVisualStyleBackColor = True
        ' 
        ' chkOnions
        ' 
        chkOnions.AutoSize = True
        chkOnions.Location = New Point(16, 99)
        chkOnions.Name = "chkOnions"
        chkOnions.Size = New Size(102, 19)
        chkOnions.TabIndex = 3
        chkOnions.Text = "Onions (15.00)"
        chkOnions.UseVisualStyleBackColor = True
        ' 
        ' chkSausage
        ' 
        chkSausage.AutoSize = True
        chkSausage.Location = New Point(16, 74)
        chkSausage.Name = "chkSausage"
        chkSausage.Size = New Size(107, 19)
        chkSausage.TabIndex = 2
        chkSausage.Text = "Sausage (40.00)"
        chkSausage.UseVisualStyleBackColor = True
        ' 
        ' chkPepperoni
        ' 
        chkPepperoni.AutoSize = True
        chkPepperoni.Location = New Point(16, 48)
        chkPepperoni.Name = "chkPepperoni"
        chkPepperoni.Size = New Size(118, 19)
        chkPepperoni.TabIndex = 1
        chkPepperoni.Text = "Pepperoni (50.00)"
        chkPepperoni.UseVisualStyleBackColor = True
        ' 
        ' chkCheese
        ' 
        chkCheese.AutoSize = True
        chkCheese.Location = New Point(16, 22)
        chkCheese.Name = "chkCheese"
        chkCheese.Size = New Size(99, 19)
        chkCheese.TabIndex = 0
        chkCheese.Text = "Cheese(25.00)"
        chkCheese.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(391, 210)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 19)
        Label7.TabIndex = 13
        Label7.Text = "Drinks"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(412, 243)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 19)
        Label8.TabIndex = 14
        Label8.Text = "Soda n Can"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(419, 274)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 19)
        Label9.TabIndex = 15
        Label9.Text = "Soda 0 oz"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(416, 306)
        Label10.Name = "Label10"
        Label10.Size = New Size(66, 19)
        Label10.TabIndex = 16
        Label10.Text = "Soda 1.5 L"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(434, 341)
        Label11.Name = "Label11"
        Label11.Size = New Size(37, 19)
        Label11.TabIndex = 17
        Label11.Text = "Juice"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(412, 371)
        Label12.Name = "Label12"
        Label12.Size = New Size(85, 19)
        Label12.TabIndex = 18
        Label12.Text = "Water 120 Ml"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(504, 210)
        Label13.Name = "Label13"
        Label13.Size = New Size(28, 19)
        Label13.TabIndex = 19
        Label13.Text = "qty"
        ' 
        ' txtSodaCan
        ' 
        txtSodaCan.Location = New Point(504, 243)
        txtSodaCan.Name = "txtSodaCan"
        txtSodaCan.Size = New Size(60, 23)
        txtSodaCan.TabIndex = 20
        ' 
        ' txtSoda8oz
        ' 
        txtSoda8oz.Location = New Point(504, 277)
        txtSoda8oz.Name = "txtSoda8oz"
        txtSoda8oz.Size = New Size(60, 23)
        txtSoda8oz.TabIndex = 21
        ' 
        ' txtSoda15L
        ' 
        txtSoda15L.Location = New Point(504, 303)
        txtSoda15L.Name = "txtSoda15L"
        txtSoda15L.Size = New Size(60, 23)
        txtSoda15L.TabIndex = 22
        ' 
        ' txtJuice
        ' 
        txtJuice.Location = New Point(504, 338)
        txtJuice.Name = "txtJuice"
        txtJuice.Size = New Size(60, 23)
        txtJuice.TabIndex = 23
        ' 
        ' txtWater
        ' 
        txtWater.Location = New Point(504, 368)
        txtWater.Name = "txtWater"
        txtWater.Size = New Size(60, 23)
        txtWater.TabIndex = 24
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(593, 210)
        Label14.Name = "Label14"
        Label14.Size = New Size(67, 19)
        Label14.TabIndex = 25
        Label14.Text = "Unit price"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(626, 243)
        Label15.Name = "Label15"
        Label15.Size = New Size(44, 19)
        Label15.TabIndex = 26
        Label15.Text = "30.00"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(626, 277)
        Label16.Name = "Label16"
        Label16.Size = New Size(41, 19)
        Label16.TabIndex = 27
        Label16.Text = "15.00"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(626, 309)
        Label17.Name = "Label17"
        Label17.Size = New Size(44, 19)
        Label17.TabIndex = 28
        Label17.Text = "60.00"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(626, 335)
        Label18.Name = "Label18"
        Label18.Size = New Size(44, 19)
        Label18.TabIndex = 29
        Label18.Text = "30.00"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(626, 376)
        Label19.Name = "Label19"
        Label19.Size = New Size(44, 19)
        Label19.TabIndex = 30
        Label19.Text = "20.00"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(687, 210)
        Label20.Name = "Label20"
        Label20.Size = New Size(63, 19)
        Label20.TabIndex = 31
        Label20.Text = "Sub Total"
        ' 
        ' txtSodaCanTotal
        ' 
        txtSodaCanTotal.Location = New Point(690, 243)
        txtSodaCanTotal.Name = "txtSodaCanTotal"
        txtSodaCanTotal.Size = New Size(60, 23)
        txtSodaCanTotal.TabIndex = 32
        ' 
        ' txtSoda8ozTotal
        ' 
        txtSoda8ozTotal.Location = New Point(690, 274)
        txtSoda8ozTotal.Name = "txtSoda8ozTotal"
        txtSoda8ozTotal.Size = New Size(60, 23)
        txtSoda8ozTotal.TabIndex = 33
        ' 
        ' txtSoda15LTotal
        ' 
        txtSoda15LTotal.Location = New Point(690, 306)
        txtSoda15LTotal.Name = "txtSoda15LTotal"
        txtSoda15LTotal.Size = New Size(60, 23)
        txtSoda15LTotal.TabIndex = 34
        ' 
        ' txtJuiceTotal
        ' 
        txtJuiceTotal.Location = New Point(690, 338)
        txtJuiceTotal.Name = "txtJuiceTotal"
        txtJuiceTotal.Size = New Size(60, 23)
        txtJuiceTotal.TabIndex = 35
        ' 
        ' txtWaterTotal
        ' 
        txtWaterTotal.Location = New Point(690, 376)
        txtWaterTotal.Name = "txtWaterTotal"
        txtWaterTotal.Size = New Size(60, 23)
        txtWaterTotal.TabIndex = 36
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(28, 411)
        Label21.Name = "Label21"
        Label21.Size = New Size(95, 19)
        Label21.TabIndex = 37
        Label21.Text = "Total Toppings"
        ' 
        ' txtToppingsTotal
        ' 
        txtToppingsTotal.Location = New Point(129, 411)
        txtToppingsTotal.Name = "txtToppingsTotal"
        txtToppingsTotal.Size = New Size(104, 23)
        txtToppingsTotal.TabIndex = 38
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(434, 426)
        Label22.Name = "Label22"
        Label22.Size = New Size(82, 19)
        Label22.TabIndex = 39
        Label22.Text = "Total Drinks"
        ' 
        ' txtDrinksTotal
        ' 
        txtDrinksTotal.Location = New Point(532, 426)
        txtDrinksTotal.Name = "txtDrinksTotal"
        txtDrinksTotal.Size = New Size(104, 23)
        txtDrinksTotal.TabIndex = 40
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(364, 516)
        Label23.Name = "Label23"
        Label23.Size = New Size(76, 19)
        Label23.TabIndex = 41
        Label23.Text = "Total Order"
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(446, 512)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(104, 23)
        txtTotal.TabIndex = 42
        ' 
        ' btnHome
        ' 
        btnHome.Font = New Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHome.Location = New Point(693, 534)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(75, 53)
        btnHome.TabIndex = 43
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' btnCompute
        ' 
        btnCompute.Font = New Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCompute.Location = New Point(199, 501)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(105, 50)
        btnCompute.TabIndex = 44
        btnCompute.Text = "Compute"
        btnCompute.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlText
        PictureBox1.Location = New Point(-1, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(908, 80)
        PictureBox1.TabIndex = 45
        PictureBox1.TabStop = False
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Sitka Heading", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(234, 7)
        Label24.Name = "Label24"
        Label24.Size = New Size(373, 69)
        Label24.TabIndex = 46
        Label24.Text = "Gabs Pizza Shop"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(906, 611)
        Controls.Add(Label24)
        Controls.Add(PictureBox1)
        Controls.Add(btnCompute)
        Controls.Add(btnHome)
        Controls.Add(txtTotal)
        Controls.Add(Label23)
        Controls.Add(txtDrinksTotal)
        Controls.Add(Label22)
        Controls.Add(txtToppingsTotal)
        Controls.Add(Label21)
        Controls.Add(txtWaterTotal)
        Controls.Add(txtJuiceTotal)
        Controls.Add(txtSoda15LTotal)
        Controls.Add(txtSoda8ozTotal)
        Controls.Add(txtSodaCanTotal)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(txtWater)
        Controls.Add(txtJuice)
        Controls.Add(txtSoda15L)
        Controls.Add(txtSoda8oz)
        Controls.Add(txtSodaCan)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(GroupBox1)
        Controls.Add(Label6)
        Controls.Add(txtSideOrdersTotal)
        Controls.Add(Label5)
        Controls.Add(txtChickenWingsTotal)
        Controls.Add(txtBreadSticksTotal)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtChickenWings)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtBreadSticks)
        Controls.Add(Size)
        Name = "Form2"
        Text = "Form2"
        Size.ResumeLayout(False)
        Size.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Size As GroupBox
    Friend WithEvents rbSmall As RadioButton
    Friend WithEvents rbLarge As RadioButton
    Friend WithEvents rbMedium As RadioButton
    Friend WithEvents txtBreadSticks As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtChickenWings As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBreadSticksTotal As TextBox
    Friend WithEvents txtChickenWingsTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSideOrdersTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkOnions As CheckBox
    Friend WithEvents chkSausage As CheckBox
    Friend WithEvents chkPepperoni As CheckBox
    Friend WithEvents chkCheese As CheckBox
    Friend WithEvents chkOlives As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSodaCan As TextBox
    Friend WithEvents txtSoda8oz As TextBox
    Friend WithEvents txtSoda15L As TextBox
    Friend WithEvents txtJuice As TextBox
    Friend WithEvents txtWater As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtSodaCanTotal As TextBox
    Friend WithEvents txtSoda8ozTotal As TextBox
    Friend WithEvents txtSoda15LTotal As TextBox
    Friend WithEvents txtJuiceTotal As TextBox
    Friend WithEvents txtWaterTotal As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtToppingsTotal As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtDrinksTotal As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnHome As Button
    Friend WithEvents btnCompute As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label24 As Label
End Class
