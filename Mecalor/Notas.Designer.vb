<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NotaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlunoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MateriaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBNOTASLISTARBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_ESCOLADataSet = New Mecalor.DB_ESCOLADataSet()
        Me.TBNOTASLISTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroTextBox5 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox4 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.TB_NOTAS_LISTARTableAdapter = New Mecalor.DB_ESCOLADataSetTableAdapters.TB_NOTAS_LISTARTableAdapter()
        Me.TBNOTASLISTARBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBNOTASLISTARBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_ESCOLADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBNOTASLISTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TBNOTASLISTARBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.ExcluirToolStripMenuItem, Me.FecharToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.NovoToolStripMenuItem.Text = "Novo"
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ExcluirToolStripMenuItem.Text = "Excluir"
        '
        'FecharToolStripMenuItem
        '
        Me.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem"
        Me.FecharToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FecharToolStripMenuItem.Text = "Fechar"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NotaidDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn, Me.NotaDataGridViewTextBoxColumn, Me.AlunoidDataGridViewTextBoxColumn, Me.MateriaidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TBNOTASLISTARBindingSource2
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Location = New System.Drawing.Point(12, 27)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Size = New System.Drawing.Size(549, 396)
        Me.DataGridView1.TabIndex = 1
        '
        'NotaidDataGridViewTextBoxColumn
        '
        Me.NotaidDataGridViewTextBoxColumn.DataPropertyName = "nota_id"
        Me.NotaidDataGridViewTextBoxColumn.HeaderText = "nota_id"
        Me.NotaidDataGridViewTextBoxColumn.Name = "NotaidDataGridViewTextBoxColumn"
        Me.NotaidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        '
        'NotaDataGridViewTextBoxColumn
        '
        Me.NotaDataGridViewTextBoxColumn.DataPropertyName = "nota"
        Me.NotaDataGridViewTextBoxColumn.HeaderText = "nota"
        Me.NotaDataGridViewTextBoxColumn.Name = "NotaDataGridViewTextBoxColumn"
        '
        'AlunoidDataGridViewTextBoxColumn
        '
        Me.AlunoidDataGridViewTextBoxColumn.DataPropertyName = "aluno_id"
        Me.AlunoidDataGridViewTextBoxColumn.HeaderText = "aluno_id"
        Me.AlunoidDataGridViewTextBoxColumn.Name = "AlunoidDataGridViewTextBoxColumn"
        '
        'MateriaidDataGridViewTextBoxColumn
        '
        Me.MateriaidDataGridViewTextBoxColumn.DataPropertyName = "materia_id"
        Me.MateriaidDataGridViewTextBoxColumn.HeaderText = "materia_id"
        Me.MateriaidDataGridViewTextBoxColumn.Name = "MateriaidDataGridViewTextBoxColumn"
        '
        'TBNOTASLISTARBindingSource1
        '
        Me.TBNOTASLISTARBindingSource1.DataMember = "TB_NOTAS_LISTAR"
        Me.TBNOTASLISTARBindingSource1.DataSource = Me.DB_ESCOLADataSet
        '
        'DB_ESCOLADataSet
        '
        Me.DB_ESCOLADataSet.DataSetName = "DB_ESCOLADataSet"
        Me.DB_ESCOLADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBNOTASLISTARBindingSource
        '
        Me.TBNOTASLISTARBindingSource.DataMember = "TB_NOTAS_LISTAR"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MetroButton1)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox5)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox4)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox3)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox2)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox1)
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(291, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 213)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Notas - Editar"
        Me.GroupBox1.Visible = False
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(399, 184)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 10
        Me.MetroButton1.Text = "OK"
        '
        'MetroTextBox5
        '
        Me.MetroTextBox5.Location = New System.Drawing.Point(125, 145)
        Me.MetroTextBox5.Name = "MetroTextBox5"
        Me.MetroTextBox5.Size = New System.Drawing.Size(75, 23)
        Me.MetroTextBox5.TabIndex = 9
        '
        'MetroTextBox4
        '
        Me.MetroTextBox4.Location = New System.Drawing.Point(125, 116)
        Me.MetroTextBox4.Name = "MetroTextBox4"
        Me.MetroTextBox4.Size = New System.Drawing.Size(75, 23)
        Me.MetroTextBox4.TabIndex = 8
        '
        'MetroTextBox3
        '
        Me.MetroTextBox3.Location = New System.Drawing.Point(125, 87)
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.Size = New System.Drawing.Size(75, 23)
        Me.MetroTextBox3.TabIndex = 7
        '
        'MetroTextBox2
        '
        Me.MetroTextBox2.Location = New System.Drawing.Point(125, 57)
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.Size = New System.Drawing.Size(75, 23)
        Me.MetroTextBox2.TabIndex = 6
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.Location = New System.Drawing.Point(125, 29)
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.Size = New System.Drawing.Size(75, 23)
        Me.MetroTextBox1.TabIndex = 5
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(27, 146)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel5.TabIndex = 4
        Me.MetroLabel5.Text = "Nota"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(27, 116)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "Data Nota"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(27, 87)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Matéria"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(27, 57)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Aluno"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(27, 29)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(21, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "ID"
        '
        'TB_NOTAS_LISTARTableAdapter
        '
        Me.TB_NOTAS_LISTARTableAdapter.ClearBeforeFill = True
        '
        'TBNOTASLISTARBindingSource2
        '
        Me.TBNOTASLISTARBindingSource2.DataMember = "TB_NOTAS_LISTAR"
        Me.TBNOTASLISTARBindingSource2.DataSource = Me.DB_ESCOLADataSet
        '
        'Notas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Notas"
        Me.Text = "Notas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBNOTASLISTARBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_ESCOLADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBNOTASLISTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TBNOTASLISTARBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FecharToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MetroTextBox5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents TBNOTASLISTARBindingSource As BindingSource
    Friend WithEvents TB_NOTAS_LISTARTableAdapter As DB_ESCOLADataSetTableAdapters.TB_NOTAS_LISTARTableAdapter
    Friend WithEvents DB_ESCOLADataSet As DB_ESCOLADataSet
    Friend WithEvents TBNOTASLISTARBindingSource1 As BindingSource
    Friend WithEvents NotaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlunoidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MateriaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TBNOTASLISTARBindingSource2 As BindingSource
End Class
