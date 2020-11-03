namespace ReportLibrary1
{
	partial class Report1
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for telerik Reporting designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.table1 = new Telerik.Reporting.Table();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.panel1 = new Telerik.Reporting.Panel();
            this.objectDataSource1 = new Telerik.Reporting.ObjectDataSource();
            this.objectDataSource2 = new Telerik.Reporting.ObjectDataSource();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(1.8D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.table1,
            this.panel1});
            this.detail.Name = "detail";
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.pageFooterSection1.Name = "pageFooterSection1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox1.Value = "= Fields.Id";
            // 
            // table1
            // 
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.879D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(5.265D)));
            this.table1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.24D)));
            this.table1.Body.SetCellContent(0, 0, this.textBox3);
            this.table1.Body.SetCellContent(0, 1, this.textBox5);
            tableGroup1.Name = "tableGroup";
            tableGroup1.ReportItem = this.textBox2;
            tableGroup2.Name = "tableGroup1";
            tableGroup2.ReportItem = this.textBox4;
            this.table1.ColumnGroups.Add(tableGroup1);
            this.table1.ColumnGroups.Add(tableGroup2);
            this.table1.DataSource = this.objectDataSource2;
            this.table1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox3,
            this.textBox5,
            this.textBox2,
            this.textBox4});
            this.table1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.346D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.table1.Name = "table1";
            tableGroup3.Groupings.Add(new Telerik.Reporting.Grouping(null));
            tableGroup3.Name = "detailTableGroup";
            this.table1.RowGroups.Add(tableGroup3);
            this.table1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.144D), Telerik.Reporting.Drawing.Unit.Inch(0.48D));
            // 
            // textBox2
            // 
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.879D), Telerik.Reporting.Drawing.Unit.Inch(0.24D));
            this.textBox2.Value = "Id";
            // 
            // textBox3
            // 
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.879D), Telerik.Reporting.Drawing.Unit.Inch(0.24D));
            this.textBox3.Value = "= Fields.Id";
            // 
            // textBox4
            // 
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.265D), Telerik.Reporting.Drawing.Unit.Inch(0.24D));
            this.textBox4.Value = "Position";
            // 
            // textBox5
            // 
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.265D), Telerik.Reporting.Drawing.Unit.Inch(0.24D));
            this.textBox5.Value = "= Fields.Position";
            // 
            // textBox6
            // 
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.9D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox6.Value = "= Fields.Name";
            // 
            // panel1
            // 
            this.panel1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox6,
            this.textBox1});
            this.panel1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.panel1.Name = "panel1";
            this.panel1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.5D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.panel1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataMember = "Report1Dara";
            this.objectDataSource1.DataSource = typeof(ParamsTest.Report1DataSource);
            this.objectDataSource1.Name = "objectDataSource1";
            this.objectDataSource1.Parameters.Add(new Telerik.Reporting.ObjectDataSourceParameter("param_string", typeof(string), "= Parameters.filter.Value"));
            // 
            // objectDataSource2
            // 
            this.objectDataSource2.DataMember = "GetData";
            this.objectDataSource2.DataSource = typeof(ParamsTest.SubDataSource);
            this.objectDataSource2.Name = "objectDataSource2";
            this.objectDataSource2.Parameters.Add(new Telerik.Reporting.ObjectDataSourceParameter("id", typeof(int), "= ReportItem.DataObject.Id"));
            // 
            // Report1
            // 
            this.DataSource = this.objectDataSource1;
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeaderSection1,
            this.detail,
            this.pageFooterSection1});
            this.Name = "Report1";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            reportParameter1.AllowBlank = false;
            reportParameter1.AutoRefresh = true;
            reportParameter1.Name = "filter";
            reportParameter1.Text = "filter";
            reportParameter1.Value = "{\"groups\":[{\"id\":1,\"mode\":\"full\"},{\"id\":2,\"mode\":\"full\"},{\"id\":3,\"mode\":\"partial\"" +
    ",\"people\":[12,13,14]}]}";
            reportParameter1.Visible = true;
            this.ReportParameters.Add(reportParameter1);
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(6.5D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

            }
		#endregion
		
		private Telerik.Reporting.PageHeaderSection pageHeaderSection1;
		private Telerik.Reporting.DetailSection detail;
		private Telerik.Reporting.PageFooterSection pageFooterSection1;
        private Telerik.Reporting.ObjectDataSource objectDataSource1;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.Table table1;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.ObjectDataSource objectDataSource2;
        private Telerik.Reporting.Panel panel1;
        private Telerik.Reporting.TextBox textBox6;
    }
}