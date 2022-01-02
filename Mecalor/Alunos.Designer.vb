<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alunos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroCheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroTextBox7 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBALUNOSLISTARBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_ESCOLADataSet1 = New Mecalor.DB_ESCOLADataSet()
        Me.TBALUNOSLISTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_ALUNOS_LISTARTableAdapter1 = New Mecalor.DB_ESCOLADataSetTableAdapters.TB_ALUNOS_LISTARTableAdapter()
        Me.TBALUNOSLISTARBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBALUNOSLISTARBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_ESCOLADataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBALUNOSLISTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBALUNOSLISTARBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.ExcluirToolStripMenuItem, Me.FecharToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1167, 24)
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
        Me.GroupBox1.Controls.Add(Me.MetroCheckBox1)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox7)
        Me.GroupBox1.Controls.Add(Me.MetroLabel7)
        Me.GroupBox1.Controls.Add(Me.MetroLabel6)
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
        Me.GroupBox1.Location = New System.Drawing.Point(658, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 244)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alunos - Editar"
        Me.GroupBox1.Visible = False
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(407, 215)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 15
        Me.MetroButton1.Text = "OK"
        '
        'MetroCheckBox1
        '
        Me.MetroCheckBox1.AutoSize = True
        Me.MetroCheckBox1.Location = New System.Drawing.Point(125, 179)
        Me.MetroCheckBox1.Name = "MetroCheckBox1"
        Me.MetroCheckBox1.Size = New System.Drawing.Size(26, 15)
        Me.MetroCheckBox1.TabIndex = 14
        Me.MetroCheckBox1.Text = " "
        Me.MetroCheckBox1.UseVisualStyleBackColor = True
        '
        'MetroTextBox7
        '
        Me.MetroTextBox7.Location = New System.Drawing.Point(125, 204)
        Me.MetroTextBox7.Name = "MetroTextBox7"
        Me.MetroTextBox7.Size = New System.Drawing.Size(75, 23)
        Me.MetroTextBox7.TabIndex = 13
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(27, 204)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel7.TabIndex = 11
        Me.MetroLabel7.Text = "Curso"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(27, 175)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel6.TabIndex = 10
        Me.MetroLabel6.Text = "Ativo"
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
        Me.MetroLabel5.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel5.TabIndex = 4
        Me.MetroLabel5.Text = "CPF"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(27, 116)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "Nascimento"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(27, 87)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Nome"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(27, 57)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Matricula"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DataGridView1.DataSource = Me.TBALUNOSLISTARBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(776, 411)
        Me.DataGridView1.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "aluno_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "aluno_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "aluno_matricula"
        Me.DataGridViewTextBoxColumn2.HeaderText = "aluno_matricula"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "aluno_nome"
        Me.DataGridViewTextBoxColumn3.HeaderText = "aluno_nome"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "aluno_dat_nascimento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "aluno_dat_nascimento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "aluno_ativo"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "aluno_ativo"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "aluno_cpf"
        Me.DataGridViewTextBoxColumn5.HeaderText = "aluno_cpf"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "curso_id"
        Me.DataGridViewTextBoxColumn6.HeaderText = "curso_id"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'TBALUNOSLISTARBindingSource1
        '
        Me.TBALUNOSLISTARBindingSource1.DataMember = "TB_ALUNOS_LISTAR"
        Me.TBALUNOSLISTARBindingSource1.DataSource = Me.DB_ESCOLADataSet1
        '
        'DB_ESCOLADataSet1
        '
        Me.DB_ESCOLADataSet1.DataSetName = "DB_ESCOLADataSet"
        Me.DB_ESCOLADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBALUNOSLISTARBindingSource
        '
        Me.TBALUNOSLISTARBindingSource.DataMember = "TB_ALUNOS_LISTAR"
        '
        'TB_ALUNOS_LISTARTableAdapter1
        '
        Me.TB_ALUNOS_LISTARTableAdapter1.ClearBeforeFill = True
        '
        'TBALUNOSLISTARBindingSource2
        '
        Me.TBALUNOSLISTARBindingSource2.DataMember = "TB_ALUNOS_LISTAR"
        Me.TBALUNOSLISTARBindingSource2.DataSource = Me.DB_ESCOLADataSet1
        '
        'Alunos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Alunos"
        Me.Text = "Alunos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBALUNOSLISTARBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_ESCOLADataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBALUNOSLISTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBALUNOSLISTARBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FecharToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MetroCheckBox1 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroTextBox7 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DB_ESCOLADataSet As DB_ESCOLADataSet
    Friend WithEvents TBALUNOSLISTARBindingSource As BindingSource
    Friend WithEvents TB_ALUNOS_LISTARTableAdapter As DB_ESCOLADataSetTableAdapters.TB_ALUNOS_LISTARTableAdapter
    Friend WithEvents AlunoidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlunomatriculaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlunonomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlunodatnascimentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlunoativoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents AlunocpfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CursoidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DB_ESCOLADataSet1 As DB_ESCOLADataSet
    Friend WithEvents TBALUNOSLISTARBindingSource1 As BindingSource
    Friend WithEvents TB_ALUNOS_LISTARTableAdapter1 As DB_ESCOLADataSetTableAdapters.TB_ALUNOS_LISTARTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents TBALUNOSLISTARBindingSource2 As BindingSource
End Class
