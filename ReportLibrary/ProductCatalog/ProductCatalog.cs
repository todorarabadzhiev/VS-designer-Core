namespace Telerik.Reporting.Examples.CSharp
{
    using System.ComponentModel;
    using Telerik.Reporting;

    /// <summary>
    /// Summary description for Report1.
    /// </summary>
    [Description("Product Catalog Report. (Multilingual)")]
    public partial class ProductCatalog : Report
    {
        public ProductCatalog()
        {
            /// <summary>
            /// Required for Telerik Reporting designer support
            /// </summary>
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void groupHeaderSection1_ItemDataBound(object sender, System.EventArgs e)
        {
            Telerik.Reporting.Processing.GroupSection section = (Telerik.Reporting.Processing.GroupSection)sender;
            object row = section.DataObject.RawData;
        }
    }
}