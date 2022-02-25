using RCM.DataAccess.Concrete.EntityFramework.Mapping;
using RCM.Model.Domain;
using System.Data.Entity;

namespace RCM.DataAccess.Concrete.EntityFramework.Context
{
    public class RCMContext : DbContext
    {
        public RCMContext()
            : base("name=RCMConnStr")
        {
            Database.SetInitializer<RCMContext>(null);// Veritabanım var, oluşturmaya çalışma


            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

            #region DbSet Properties

        public DbSet<AdressOfCustomer> AdressOfCustomers { get; set; }
        public DbSet<AuthorityType> AuthorityTypes { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<BranchCaseType> BranchCaseTypes { get; set; }
        public DbSet<BranchCaseTypeFlow> BranchCaseTypeFlows { get; set; }
        public DbSet<BranchConsumption> BranchConsumptions { get; set; }
        public DbSet<BranchCreditCard> BranchCreditCards { get; set; }
        public DbSet<BranchCreditCardFlow> BranchCreditCardFlows { get; set; }
        public DbSet<BranchDailyRevenue> BranchDailyRevenues { get; set; }
        public DbSet<BranchProductPrice> BranchProductPrices { get; set; }
        public DbSet<BranchRevenueDistribution> BranchRevenueDistributions { get; set; }
        public DbSet<BranchStock> BranchStocks { get; set; }
        public DbSet<BranchStockEntry> BranchStockEntries { get; set; }
        public DbSet<CaseType> CaseTypes { get; set; }
        public DbSet<ConsumeType> ConsumeTypes { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeMoneyFlow> EmployeeMoneyFlows { get; set; }
        public DbSet<EmployeePaymentType> EmployeePaymentTypes { get; set; }
        public DbSet<EmployeeRollCall> EmployeeRollCalls { get; set; }
        public DbSet<ExpenseFlow> ExpenseFlows { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<FirmType> FirmTypes { get; set; }
        public DbSet<MyException> MyExceptions { get; set; }
        public DbSet<PositionType> PositionTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductPhoto> ProductPhotoes { get; set; }
        public DbSet<RawMaterial> RawMaterials { get; set; }
        public DbSet<RollCallType> RollCallTypes { get; set; }
        public DbSet<SalaryType> SalaryTypes { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleNote> SaleNotes { get; set; }
        public DbSet<SaleNoteCategory> SaleNoteCategories { get; set; }
        public DbSet<SaleNoteOfProduct> SaleNoteOfProducts { get; set; }
        public DbSet<SaleType> SaleTypes { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierMoneyFlow> SupplierMoneyFlows { get; set; } 
        public DbSet<User> Users { get; set; }
        public DbSet<UserBranchAuthority> UserBranchAuthorities { get; set; }
        public DbSet<WorkType> WorkTypes { get; set; }
        public DbSet<RawMaterialOfProduct> RawMaterialOfProducts { get; set; }
        public DbSet<RawMaterialOfSupplier> RawMaterialOfSuppliers { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorityType>()
                .HasMany(e => e.UserBranchAuthorities)
                .WithRequired(e => e.AuthorityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.BranchCaseTypes)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.BranchCaseTypeFlows)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.BranchConsumptions)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.BranchCreditCards)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.BranchCreditCardFlows)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.BranchDailyRevenues)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.BranchProductPrices)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.BranchRevenueDistributions)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.BranchStocks)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.BranchStockEntries)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.EmployeeMoneyFlows)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.EmployeeRollCalls)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.ExpenseFlows)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.Suppliers)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.SupplierMoneyFlows)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.UserBranchAuthorities)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CaseType>()
                .HasMany(e => e.BranchCaseTypes)
                .WithRequired(e => e.CaseType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CaseType>()
                .HasMany(e => e.BranchCaseTypeFlows)
                .WithRequired(e => e.CaseType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CaseType>()
                .HasMany(e => e.BranchRevenueDistributions)
                .WithRequired(e => e.CaseType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CaseType>()
                .HasMany(e => e.EmployeeMoneyFlows)
                .WithRequired(e => e.CaseType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CaseType>()
                .HasMany(e => e.ExpenseFlows)
                .WithRequired(e => e.CaseType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CaseType>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.CaseType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CaseType>()
                .HasMany(e => e.SupplierMoneyFlows)
                .WithRequired(e => e.CaseType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConsumeType>()
                .HasMany(e => e.BranchConsumptions)
                .WithRequired(e => e.ConsumeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CreditCard>()
                .HasMany(e => e.BranchCreditCards)
                .WithRequired(e => e.CreditCard)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CreditCard>()
                .HasMany(e => e.BranchCreditCardFlows)
                .WithRequired(e => e.CreditCard)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.AdressOfCustomers)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeMoneyFlows)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.PaidEId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeRollCalls)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.RollCaledEId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeePaymentType>()
                .HasMany(e => e.EmployeeMoneyFlows)
                .WithRequired(e => e.EmployeePaymentType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExpenseType>()
                .HasMany(e => e.ExpenseFlows)
                .WithRequired(e => e.ExpenseType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FirmType>()
                .HasMany(e => e.Suppliers)
                .WithRequired(e => e.FirmType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PositionType>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.PositionType)
                .HasForeignKey(e => e.PositionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.BranchProductPrices)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Product1)
                .WithOptional(e => e.Product2)
                .HasForeignKey(e => e.TopPId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.RawMaterialOfProducts)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SaleDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SaleNoteOfProducts)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductCategory>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.ProductCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RawMaterial>()
                .HasMany(e => e.BranchStocks)
                .WithRequired(e => e.RawMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RawMaterial>()
                .HasMany(e => e.BranchStockEntries)
                .WithRequired(e => e.RawMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RawMaterial>()
                .HasMany(e => e.RawMaterialOfProducts)
                .WithRequired(e => e.RawMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RawMaterial>()
                .HasMany(e => e.RawMaterialOfSuppliers)
                .WithRequired(e => e.RawMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RollCallType>()
                .HasMany(e => e.EmployeeRollCalls)
                .WithRequired(e => e.RollCallType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalaryType>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.SalaryType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sale>()
                .HasMany(e => e.SaleDetails)
                .WithRequired(e => e.Sale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SaleNote>()
                .HasMany(e => e.SaleNoteOfProducts)
                .WithRequired(e => e.SaleNote)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SaleNoteCategory>()
                .HasMany(e => e.SaleNotes)
                .WithRequired(e => e.SaleNoteCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SaleType>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.SaleType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SaleType>()
                .HasMany(e => e.SaleType1)
                .WithOptional(e => e.SaleType2)
                .HasForeignKey(e => e.TopSTId);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.RawMaterialOfSuppliers)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.SupplierMoneyFlows)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.BranchCaseTypes)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.BranchCaseTypeFlows)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.BranchConsumptions)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.BranchCreditCards)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.BranchCreditCardFlows)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.BranchRevenueDistributions)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.BranchStocks)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.BranchStockEntries)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.EmployeeMoneyFlows)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.EmployeeRollCalls)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ExpenseFlows)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ExpenseFlows1)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SaleDetails)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Suppliers)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SupplierMoneyFlows)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserBranchAuthorities)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WorkType>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.WorkType)
                .WillCascadeOnDelete(false);

            modelBuilder.Configurations.Add(new AdressOfCustomerMap());
            modelBuilder.Configurations.Add(new AuthorityTypeMap());
            modelBuilder.Configurations.Add(new BranchMap());
            modelBuilder.Configurations.Add(new BranchCaseTypeMap());
            modelBuilder.Configurations.Add(new BranchCaseTypeFlowMap());
            modelBuilder.Configurations.Add(new BranchConsumptionMap());
            modelBuilder.Configurations.Add(new BranchCreditCardMap());
            modelBuilder.Configurations.Add(new BranchCreditCardFlowMap());
            modelBuilder.Configurations.Add(new BranchDailyRevenueMap());
            modelBuilder.Configurations.Add(new BranchProductPriceMap());
            modelBuilder.Configurations.Add(new BranchRevenueDistributionMap());
            modelBuilder.Configurations.Add(new BranchStockMap());
            modelBuilder.Configurations.Add(new BranchStockEntryMap());
            modelBuilder.Configurations.Add(new CaseTypeMap());
            modelBuilder.Configurations.Add(new ConsumeTypeMap());
            modelBuilder.Configurations.Add(new CreditCardMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeMoneyFlowMap());
            modelBuilder.Configurations.Add(new EmployeePaymentTypeMap());
            modelBuilder.Configurations.Add(new EmployeeRollCallMap());
            modelBuilder.Configurations.Add(new ExpenseFlowMap());
            modelBuilder.Configurations.Add(new ExpenseTypeMap());
            modelBuilder.Configurations.Add(new FirmTypeMap());
            modelBuilder.Configurations.Add(new MyExceptionMap());
            modelBuilder.Configurations.Add(new PositionTypeMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProductCategoryMap());
            modelBuilder.Configurations.Add(new ProductPhotoMap());
            modelBuilder.Configurations.Add(new RawMaterialMap());
            modelBuilder.Configurations.Add(new RollCallTypeMap());
            modelBuilder.Configurations.Add(new SalaryTypeMap());
            modelBuilder.Configurations.Add(new SaleMap());
            modelBuilder.Configurations.Add(new SaleNoteMap());
            modelBuilder.Configurations.Add(new SaleNoteCategoryMap());
            modelBuilder.Configurations.Add(new SaleNoteOfProductMap());
            modelBuilder.Configurations.Add(new SaleTypeMap());
            modelBuilder.Configurations.Add(new SupplierMap());
            modelBuilder.Configurations.Add(new SupplierMoneyFlowMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserBranchAuthorityMap());
            modelBuilder.Configurations.Add(new WorkTypeMap());
            modelBuilder.Configurations.Add(new RawMaterialOfProductMap());
            modelBuilder.Configurations.Add(new RawMaterialOfSupplierMap());
            modelBuilder.Configurations.Add(new SaleDetailMap());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
