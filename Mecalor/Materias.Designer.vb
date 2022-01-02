<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Materias
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBMATERIASLISTARBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_ESCOLADataSet1 = New Mecalor.DB_ESCOLADataSet()
        Me.TBMATERIASLISTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.TB_MATERIAS_LISTARTableAdapter1 = New Mecalor.DB_ESCOLADataSetTableAdapters.TB_MATERIAS_LISTARTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBMATERIASLISTARBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_ESCOLADataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBMATERIASLISTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.ExcluirToolStripMenuItem, Me.FecharToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(919, 24)
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
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView1.DataSource = Me.TBMATERIASLISTARBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(247, 411)
        Me.DataGridView1.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "materia_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "materia_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "materia_nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "materia_nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'TBMATERIASLISTARBindingSource1
        '
        Me.TBMATERIASLISTARBindingSource1.DataMember = "TB_MATERIAS_LISTAR"
        Me.TBMATERIASLISTARBindingSource1.DataSource = Me.DB_ESCOLADataSet1
        '
        'DB_ESCOLADataSet1
        '
        Me.DB_ESCOLADataSet1.DataSetName = "DB_ESCOLADataSet"
        Me.DB_ESCOLADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBMATERIASLISTARBindingSource
        '
        Me.TBMATERIASLISTARBindingSource.DataMember = "TB_MATERIAS_LISTAR"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MetroButton1)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox2)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox1)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(416, 219)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(503, 135)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cursos - Editar"
        Me.GroupBox1.Visible = False
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(416, 103)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 11
        Me.MetroButton1.Text = "OK"
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
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(27, 57)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Matéria"
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
        'TB_MATERIAS_LISTARTableAdapter1
        '
        Me.TB_MATERIAS_LISTARTableAdapter1.ClearBeforeFill = True
        '
        'Materias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Materias"
        Me.Text = "Materiais"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBMATERIASLISTARBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_ESCOLADataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBMATERIASLISTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FecharToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DB_ESCOLADataSet As DB_ESCOLADataSet
    Friend WithEvents TBMATERIASLISTARBindingSource As BindingSource
    Friend WithEvents TB_MATERIAS_LISTARTableAdapter As DB_ESCOLADataSetTableAdapters.TB_MATERIAS_LISTARTableAdapter
    Friend WithEvents MateriaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterianomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DB_ESCOLADataSet1 As DB_ESCOLADataSet
    Friend WithEvents TBMATERIASLISTARBindingSource1 As BindingSource
    Friend WithEvents TB_MATERIAS_LISTARTableAdapter1 As DB_ESCOLADataSetTableAdapters.TB_MATERIAS_LISTARTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
