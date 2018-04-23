using System;
using DXSample;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using DevExpress.XtraEditors.Filtering;
using DevExpress.Data.Filtering.Helpers;

namespace Q264421 {
    public partial class Form1 :Form {
        public Form1() {
            InitializeComponent();
            FilterColumnCollection columns = new FilterColumnCollection();
            columns.Add(new UnboundFilterColumn("Order ID", "OrderID", typeof(int), spinEdit, FilterColumnClauseClass.Generic));
            columns.Add(new UnboundFilterColumn("Product", "Product", typeof(string), textEdit, FilterColumnClauseClass.String));
            columns.Add(new UnboundFilterColumn("Discount", "Discount", typeof(decimal), spinEdit, FilterColumnClauseClass.Generic));
            filterControl.SetFilterColumnsCollection(columns);
            filterControl.FilterCriteria = CriteriaOperator.Parse("Product between ('Alice Munton', 'Icura') && Discount > .05");
            filterControl.SetDefaultColumn(filterControl.FilterColumns["OrderID"]);
        }
    }
}
