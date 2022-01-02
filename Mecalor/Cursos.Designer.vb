<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cursos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TBALUNOSLISTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBCURSOSLISTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBESCOLADataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_ESCOLADataSet2 = New Mecalor.DB_ESCOLADataSet()
        Me.TBCURSOSLISTARBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_CURSOS_LISTARTableAdapter1 = New Mecalor.DB_ESCOLADataSetTableAdapters.TB_CURSOS_LISTARTableAdapter()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBALUNOSLISTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBCURSOSLISTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBESCOLADataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_ESCOLADataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBCURSOSLISTARBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.ExcluirToolStripMenuItem, Me.FecharToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(626, 24)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MetroButton1)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox2)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox1)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(280, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 126)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cursos - Editar"
        Me.GroupBox1.Visible = False
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(247, 97)
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
        Me.MetroLabel2.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Curso"
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DataGridView1.DataSource = Me.TBCURSOSLISTARBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(244, 411)
        Me.DataGridView1.TabIndex = 5
        '
        'TBALUNOSLISTARBindingSource
        '
        Me.TBALUNOSLISTARBindingSource.DataMember = "TB_ALUNOS_LISTAR"
        '
        'TBCURSOSLISTARBindingSource
        '
        Me.TBCURSOSLISTARBindingSource.DataMember = "TB_CURSOS_LISTAR"
        '
        'DB_ESCOLADataSet2
        '
        Me.DB_ESCOLADataSet2.DataSetName = "DB_ESCOLADataSet"
        Me.DB_ESCOLADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBCURSOSLISTARBindingSource1
        '
        Me.TBCURSOSLISTARBindingSource1.DataMember = "TB_CURSOS_LISTAR"
        Me.TBCURSOSLISTARBindingSource1.DataSource = Me.DB_ESCOLADataSet2
        '
        'TB_CURSOS_LISTARTableAdapter1
        '
        Me.TB_CURSOS_LISTARTableAdapter1.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "curso_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "curso_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "curso_nome"
        Me.DataGridViewTextBoxColumn3.HeaderText = "curso_nome"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Cursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Cursos"
        Me.Text = "Cursos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBALUNOSLISTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBCURSOSLISTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBESCOLADataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_ESCOLADataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBCURSOSLISTARBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FecharToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DBESCOLADataSetBindingSource As BindingSource
    Friend WithEvents DB_ESCOLADataSet As DB_ESCOLADataSet
    Friend WithEvents TBCURSOSLISTARBindingSource As BindingSource
    Friend WithEvents TB_CURSOS_LISTARTableAdapter As DB_ESCOLADataSetTableAdapters.TB_CURSOS_LISTARTableAdapter
    Friend WithEvents CursoidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CursonomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DB_ESCOLADataSet1 As DB_ESCOLADataSet
    Friend WithEvents TBALUNOSLISTARBindingSource As BindingSource
    Friend WithEvents TB_ALUNOS_LISTARTableAdapter As DB_ESCOLADataSetTableAdapters.TB_ALUNOS_LISTARTableAdapter
    Friend WithEvents AlunoidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlunomatriculaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlunonomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlunodatnascimentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlunoativoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents AlunocpfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DB_ESCOLADataSet2 As DB_ESCOLADataSet
    Friend WithEvents TBCURSOSLISTARBindingSource1 As BindingSource
    Friend WithEvents TB_CURSOS_LISTARTableAdapter1 As DB_ESCOLADataSetTableAdapters.TB_CURSOS_LISTARTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
