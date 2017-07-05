namespace DatabaseWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dimProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorksDW2014DataSet = new DatabaseWindowsForms.AdventureWorksDW2014DataSet();
            this.dimProductTableAdapter = new DatabaseWindowsForms.AdventureWorksDW2014DataSetTableAdapters.DimProductTableAdapter();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turkishDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.japaneseDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.germanDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thaiDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hebrewDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arabicDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chineseDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frenchDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.largePhotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealerPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysToManufactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeRangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.safetyStockLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishedGoodsFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.standardCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frenchProductNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spanishProductNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishProductNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeUnitMeasureCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightUnitMeasureCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSubcategoryKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAlternateKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dimProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDW2014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dimProductBindingSource
            // 
            this.dimProductBindingSource.DataMember = "DimProduct";
            this.dimProductBindingSource.DataSource = this.adventureWorksDW2014DataSet;
            // 
            // adventureWorksDW2014DataSet
            // 
            this.adventureWorksDW2014DataSet.DataSetName = "AdventureWorksDW2014DataSet";
            this.adventureWorksDW2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dimProductTableAdapter
            // 
            this.dimProductTableAdapter.ClearBeforeFill = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // turkishDescriptionDataGridViewTextBoxColumn
            // 
            this.turkishDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TurkishDescription";
            this.turkishDescriptionDataGridViewTextBoxColumn.HeaderText = "TurkishDescription";
            this.turkishDescriptionDataGridViewTextBoxColumn.Name = "turkishDescriptionDataGridViewTextBoxColumn";
            // 
            // japaneseDescriptionDataGridViewTextBoxColumn
            // 
            this.japaneseDescriptionDataGridViewTextBoxColumn.DataPropertyName = "JapaneseDescription";
            this.japaneseDescriptionDataGridViewTextBoxColumn.HeaderText = "JapaneseDescription";
            this.japaneseDescriptionDataGridViewTextBoxColumn.Name = "japaneseDescriptionDataGridViewTextBoxColumn";
            // 
            // germanDescriptionDataGridViewTextBoxColumn
            // 
            this.germanDescriptionDataGridViewTextBoxColumn.DataPropertyName = "GermanDescription";
            this.germanDescriptionDataGridViewTextBoxColumn.HeaderText = "GermanDescription";
            this.germanDescriptionDataGridViewTextBoxColumn.Name = "germanDescriptionDataGridViewTextBoxColumn";
            // 
            // thaiDescriptionDataGridViewTextBoxColumn
            // 
            this.thaiDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ThaiDescription";
            this.thaiDescriptionDataGridViewTextBoxColumn.HeaderText = "ThaiDescription";
            this.thaiDescriptionDataGridViewTextBoxColumn.Name = "thaiDescriptionDataGridViewTextBoxColumn";
            // 
            // hebrewDescriptionDataGridViewTextBoxColumn
            // 
            this.hebrewDescriptionDataGridViewTextBoxColumn.DataPropertyName = "HebrewDescription";
            this.hebrewDescriptionDataGridViewTextBoxColumn.HeaderText = "HebrewDescription";
            this.hebrewDescriptionDataGridViewTextBoxColumn.Name = "hebrewDescriptionDataGridViewTextBoxColumn";
            // 
            // arabicDescriptionDataGridViewTextBoxColumn
            // 
            this.arabicDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ArabicDescription";
            this.arabicDescriptionDataGridViewTextBoxColumn.HeaderText = "ArabicDescription";
            this.arabicDescriptionDataGridViewTextBoxColumn.Name = "arabicDescriptionDataGridViewTextBoxColumn";
            // 
            // chineseDescriptionDataGridViewTextBoxColumn
            // 
            this.chineseDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ChineseDescription";
            this.chineseDescriptionDataGridViewTextBoxColumn.HeaderText = "ChineseDescription";
            this.chineseDescriptionDataGridViewTextBoxColumn.Name = "chineseDescriptionDataGridViewTextBoxColumn";
            // 
            // frenchDescriptionDataGridViewTextBoxColumn
            // 
            this.frenchDescriptionDataGridViewTextBoxColumn.DataPropertyName = "FrenchDescription";
            this.frenchDescriptionDataGridViewTextBoxColumn.HeaderText = "FrenchDescription";
            this.frenchDescriptionDataGridViewTextBoxColumn.Name = "frenchDescriptionDataGridViewTextBoxColumn";
            // 
            // englishDescriptionDataGridViewTextBoxColumn
            // 
            this.englishDescriptionDataGridViewTextBoxColumn.DataPropertyName = "EnglishDescription";
            this.englishDescriptionDataGridViewTextBoxColumn.HeaderText = "EnglishDescription";
            this.englishDescriptionDataGridViewTextBoxColumn.Name = "englishDescriptionDataGridViewTextBoxColumn";
            // 
            // largePhotoDataGridViewImageColumn
            // 
            this.largePhotoDataGridViewImageColumn.DataPropertyName = "LargePhoto";
            this.largePhotoDataGridViewImageColumn.HeaderText = "LargePhoto";
            this.largePhotoDataGridViewImageColumn.Name = "largePhotoDataGridViewImageColumn";
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            // 
            // styleDataGridViewTextBoxColumn
            // 
            this.styleDataGridViewTextBoxColumn.DataPropertyName = "Style";
            this.styleDataGridViewTextBoxColumn.HeaderText = "Style";
            this.styleDataGridViewTextBoxColumn.Name = "styleDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // dealerPriceDataGridViewTextBoxColumn
            // 
            this.dealerPriceDataGridViewTextBoxColumn.DataPropertyName = "DealerPrice";
            this.dealerPriceDataGridViewTextBoxColumn.HeaderText = "DealerPrice";
            this.dealerPriceDataGridViewTextBoxColumn.Name = "dealerPriceDataGridViewTextBoxColumn";
            // 
            // productLineDataGridViewTextBoxColumn
            // 
            this.productLineDataGridViewTextBoxColumn.DataPropertyName = "ProductLine";
            this.productLineDataGridViewTextBoxColumn.HeaderText = "ProductLine";
            this.productLineDataGridViewTextBoxColumn.Name = "productLineDataGridViewTextBoxColumn";
            // 
            // daysToManufactureDataGridViewTextBoxColumn
            // 
            this.daysToManufactureDataGridViewTextBoxColumn.DataPropertyName = "DaysToManufacture";
            this.daysToManufactureDataGridViewTextBoxColumn.HeaderText = "DaysToManufacture";
            this.daysToManufactureDataGridViewTextBoxColumn.Name = "daysToManufactureDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // sizeRangeDataGridViewTextBoxColumn
            // 
            this.sizeRangeDataGridViewTextBoxColumn.DataPropertyName = "SizeRange";
            this.sizeRangeDataGridViewTextBoxColumn.HeaderText = "SizeRange";
            this.sizeRangeDataGridViewTextBoxColumn.Name = "sizeRangeDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // listPriceDataGridViewTextBoxColumn
            // 
            this.listPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice";
            this.listPriceDataGridViewTextBoxColumn.HeaderText = "ListPrice";
            this.listPriceDataGridViewTextBoxColumn.Name = "listPriceDataGridViewTextBoxColumn";
            // 
            // reorderPointDataGridViewTextBoxColumn
            // 
            this.reorderPointDataGridViewTextBoxColumn.DataPropertyName = "ReorderPoint";
            this.reorderPointDataGridViewTextBoxColumn.HeaderText = "ReorderPoint";
            this.reorderPointDataGridViewTextBoxColumn.Name = "reorderPointDataGridViewTextBoxColumn";
            // 
            // safetyStockLevelDataGridViewTextBoxColumn
            // 
            this.safetyStockLevelDataGridViewTextBoxColumn.DataPropertyName = "SafetyStockLevel";
            this.safetyStockLevelDataGridViewTextBoxColumn.HeaderText = "SafetyStockLevel";
            this.safetyStockLevelDataGridViewTextBoxColumn.Name = "safetyStockLevelDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // finishedGoodsFlagDataGridViewCheckBoxColumn
            // 
            this.finishedGoodsFlagDataGridViewCheckBoxColumn.DataPropertyName = "FinishedGoodsFlag";
            this.finishedGoodsFlagDataGridViewCheckBoxColumn.HeaderText = "FinishedGoodsFlag";
            this.finishedGoodsFlagDataGridViewCheckBoxColumn.Name = "finishedGoodsFlagDataGridViewCheckBoxColumn";
            // 
            // standardCostDataGridViewTextBoxColumn
            // 
            this.standardCostDataGridViewTextBoxColumn.DataPropertyName = "StandardCost";
            this.standardCostDataGridViewTextBoxColumn.HeaderText = "StandardCost";
            this.standardCostDataGridViewTextBoxColumn.Name = "standardCostDataGridViewTextBoxColumn";
            // 
            // frenchProductNameDataGridViewTextBoxColumn
            // 
            this.frenchProductNameDataGridViewTextBoxColumn.DataPropertyName = "FrenchProductName";
            this.frenchProductNameDataGridViewTextBoxColumn.HeaderText = "FrenchProductName";
            this.frenchProductNameDataGridViewTextBoxColumn.Name = "frenchProductNameDataGridViewTextBoxColumn";
            // 
            // spanishProductNameDataGridViewTextBoxColumn
            // 
            this.spanishProductNameDataGridViewTextBoxColumn.DataPropertyName = "SpanishProductName";
            this.spanishProductNameDataGridViewTextBoxColumn.HeaderText = "SpanishProductName";
            this.spanishProductNameDataGridViewTextBoxColumn.Name = "spanishProductNameDataGridViewTextBoxColumn";
            // 
            // englishProductNameDataGridViewTextBoxColumn
            // 
            this.englishProductNameDataGridViewTextBoxColumn.DataPropertyName = "EnglishProductName";
            this.englishProductNameDataGridViewTextBoxColumn.HeaderText = "EnglishProductName";
            this.englishProductNameDataGridViewTextBoxColumn.Name = "englishProductNameDataGridViewTextBoxColumn";
            // 
            // sizeUnitMeasureCodeDataGridViewTextBoxColumn
            // 
            this.sizeUnitMeasureCodeDataGridViewTextBoxColumn.DataPropertyName = "SizeUnitMeasureCode";
            this.sizeUnitMeasureCodeDataGridViewTextBoxColumn.HeaderText = "SizeUnitMeasureCode";
            this.sizeUnitMeasureCodeDataGridViewTextBoxColumn.Name = "sizeUnitMeasureCodeDataGridViewTextBoxColumn";
            // 
            // weightUnitMeasureCodeDataGridViewTextBoxColumn
            // 
            this.weightUnitMeasureCodeDataGridViewTextBoxColumn.DataPropertyName = "WeightUnitMeasureCode";
            this.weightUnitMeasureCodeDataGridViewTextBoxColumn.HeaderText = "WeightUnitMeasureCode";
            this.weightUnitMeasureCodeDataGridViewTextBoxColumn.Name = "weightUnitMeasureCodeDataGridViewTextBoxColumn";
            // 
            // productSubcategoryKeyDataGridViewTextBoxColumn
            // 
            this.productSubcategoryKeyDataGridViewTextBoxColumn.DataPropertyName = "ProductSubcategoryKey";
            this.productSubcategoryKeyDataGridViewTextBoxColumn.HeaderText = "ProductSubcategoryKey";
            this.productSubcategoryKeyDataGridViewTextBoxColumn.Name = "productSubcategoryKeyDataGridViewTextBoxColumn";
            // 
            // productAlternateKeyDataGridViewTextBoxColumn
            // 
            this.productAlternateKeyDataGridViewTextBoxColumn.DataPropertyName = "ProductAlternateKey";
            this.productAlternateKeyDataGridViewTextBoxColumn.HeaderText = "ProductAlternateKey";
            this.productAlternateKeyDataGridViewTextBoxColumn.Name = "productAlternateKeyDataGridViewTextBoxColumn";
            // 
            // productKeyDataGridViewTextBoxColumn
            // 
            this.productKeyDataGridViewTextBoxColumn.DataPropertyName = "ProductKey";
            this.productKeyDataGridViewTextBoxColumn.HeaderText = "ProductKey";
            this.productKeyDataGridViewTextBoxColumn.Name = "productKeyDataGridViewTextBoxColumn";
            this.productKeyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productKeyDataGridViewTextBoxColumn,
            this.productAlternateKeyDataGridViewTextBoxColumn,
            this.productSubcategoryKeyDataGridViewTextBoxColumn,
            this.weightUnitMeasureCodeDataGridViewTextBoxColumn,
            this.sizeUnitMeasureCodeDataGridViewTextBoxColumn,
            this.englishProductNameDataGridViewTextBoxColumn,
            this.spanishProductNameDataGridViewTextBoxColumn,
            this.frenchProductNameDataGridViewTextBoxColumn,
            this.standardCostDataGridViewTextBoxColumn,
            this.finishedGoodsFlagDataGridViewCheckBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.safetyStockLevelDataGridViewTextBoxColumn,
            this.reorderPointDataGridViewTextBoxColumn,
            this.listPriceDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.sizeRangeDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.daysToManufactureDataGridViewTextBoxColumn,
            this.productLineDataGridViewTextBoxColumn,
            this.dealerPriceDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.styleDataGridViewTextBoxColumn,
            this.modelNameDataGridViewTextBoxColumn,
            this.largePhotoDataGridViewImageColumn,
            this.englishDescriptionDataGridViewTextBoxColumn,
            this.frenchDescriptionDataGridViewTextBoxColumn,
            this.chineseDescriptionDataGridViewTextBoxColumn,
            this.arabicDescriptionDataGridViewTextBoxColumn,
            this.hebrewDescriptionDataGridViewTextBoxColumn,
            this.thaiDescriptionDataGridViewTextBoxColumn,
            this.germanDescriptionDataGridViewTextBoxColumn,
            this.japaneseDescriptionDataGridViewTextBoxColumn,
            this.turkishDescriptionDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dimProductBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 327);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dimProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDW2014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AdventureWorksDW2014DataSet adventureWorksDW2014DataSet;
        private System.Windows.Forms.BindingSource dimProductBindingSource;
        private AdventureWorksDW2014DataSetTableAdapters.DimProductTableAdapter dimProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turkishDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn japaneseDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn germanDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thaiDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hebrewDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arabicDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chineseDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frenchDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn largePhotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealerPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysToManufactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeRangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn safetyStockLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finishedGoodsFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frenchProductNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spanishProductNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishProductNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeUnitMeasureCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightUnitMeasureCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSubcategoryKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAlternateKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

