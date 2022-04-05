using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GlobalLogAPI.Models.DB
{
    public partial class UUBillingEntity : DbContext
    {
        public UUBillingEntity()
        {
        }

        public UUBillingEntity(DbContextOptions<UUBillingEntity> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Area { get; set; } = null!;
        public virtual DbSet<ChangeUseType> ChangeUseType { get; set; } = null!;
        public virtual DbSet<ChangeUseType6203> ChangeUseType6203 { get; set; } = null!;
        public virtual DbSet<DBBADDEBT> DBBADDEBT { get; set; } = null!;
        public virtual DbSet<DBBADDEBTUU> DBBADDEBTUU { get; set; } = null!;
        public virtual DbSet<DBDEBT> DBDEBT { get; set; } = null!;
        public virtual DbSet<DBLOW> DBLOW { get; set; } = null!;
        public virtual DbSet<DBSM04> DBSM04 { get; set; } = null!;
        public virtual DbSet<DBWaterRate> DBWaterRate { get; set; } = null!;
        public virtual DbSet<DBWaterRate_Item> DBWaterRate_Item { get; set; } = null!;
        public virtual DbSet<Insurance> Insurance { get; set; } = null!;
        public virtual DbSet<LogGlobalError> LogGlobalError { get; set; } = null!;
        public virtual DbSet<METERDEP> METERDEP { get; set; } = null!;
        public virtual DbSet<METERDIPO> METERDIPO { get; set; } = null!;
        public virtual DbSet<METERINS> METERINS { get; set; } = null!;
        public virtual DbSet<METERJOIN> METERJOIN { get; set; } = null!;
        public virtual DbSet<METERTEST> METERTEST { get; set; } = null!;
        public virtual DbSet<OK> OK { get; set; } = null!;
        public virtual DbSet<PERMISSION> PERMISSION { get; set; } = null!;
        public virtual DbSet<PWA_Constant> PWA_Constant { get; set; } = null!;
        public virtual DbSet<PWA_Customer> PWA_Customer { get; set; } = null!;
        public virtual DbSet<PaidInsurance> PaidInsurance { get; set; } = null!;
        public virtual DbSet<RECEIPT> RECEIPT { get; set; } = null!;
        public virtual DbSet<RECEIPTLOT> RECEIPTLOT { get; set; } = null!;
        public virtual DbSet<RECEIPT_Service> RECEIPT_Service { get; set; } = null!;
        public virtual DbSet<ReportAccount15His> ReportAccount15His { get; set; } = null!;
        public virtual DbSet<TArea> TArea { get; set; } = null!;
        public virtual DbSet<TB_BankCompany> TB_BankCompany { get; set; } = null!;
        public virtual DbSet<TB_Group> TB_Group { get; set; } = null!;
        public virtual DbSet<TB_Group_Permission> TB_Group_Permission { get; set; } = null!;
        public virtual DbSet<TB_Promotion> TB_Promotion { get; set; } = null!;
        public virtual DbSet<TB_Promotion_MeterSize> TB_Promotion_MeterSize { get; set; } = null!;
        public virtual DbSet<TB_Promotion_UseType> TB_Promotion_UseType { get; set; } = null!;
        public virtual DbSet<TB_WaterUseTypeGroup> TB_WaterUseTypeGroup { get; set; } = null!;
        public virtual DbSet<TBank> TBank { get; set; } = null!;
        public virtual DbSet<TBigMeter> TBigMeter { get; set; } = null!;
        public virtual DbSet<TBrand> TBrand { get; set; } = null!;
        public virtual DbSet<TChangePassword> TChangePassword { get; set; } = null!;
        public virtual DbSet<TConcession> TConcession { get; set; } = null!;
        public virtual DbSet<TConcession_Area> TConcession_Area { get; set; } = null!;
        public virtual DbSet<TCust_Meter> TCust_Meter { get; set; } = null!;
        public virtual DbSet<TCustomer> TCustomer { get; set; } = null!;
        public virtual DbSet<TCustomer_Regis> TCustomer_Regis { get; set; } = null!;
        public virtual DbSet<TDiscount> TDiscount { get; set; } = null!;
        public virtual DbSet<TDiscountDebt> TDiscountDebt { get; set; } = null!;
        public virtual DbSet<TGoverment> TGoverment { get; set; } = null!;
        public virtual DbSet<TInvoice> TInvoice { get; set; } = null!;
        public virtual DbSet<TInvoiceDailyClose> TInvoiceDailyClose { get; set; } = null!;
        public virtual DbSet<TInvoiceEdit> TInvoiceEdit { get; set; } = null!;
        public virtual DbSet<TInvoiceHistory> TInvoiceHistory { get; set; } = null!;
        public virtual DbSet<TInvoiceMonthlyClose> TInvoiceMonthlyClose { get; set; } = null!;
        public virtual DbSet<TInvoiceReduce> TInvoiceReduce { get; set; } = null!;
        public virtual DbSet<TInvoiceReduceWater> TInvoiceReduceWater { get; set; } = null!;
        public virtual DbSet<TInvoiceService> TInvoiceService { get; set; } = null!;
        public virtual DbSet<TInvoice_Installment> TInvoice_Installment { get; set; } = null!;
        public virtual DbSet<TInvoice_New> TInvoice_New { get; set; } = null!;
        public virtual DbSet<TLog_Email> TLog_Email { get; set; } = null!;
        public virtual DbSet<TLog_LineOA> TLog_LineOA { get; set; } = null!;
        public virtual DbSet<TLog_PaymentAPI> TLog_PaymentAPI { get; set; } = null!;
        public virtual DbSet<TLog_PrintReason_Services> TLog_PrintReason_Services { get; set; } = null!;
        public virtual DbSet<TLog_PrintReason_Water> TLog_PrintReason_Water { get; set; } = null!;
        public virtual DbSet<TLog_PrintReason_WaterStream> TLog_PrintReason_WaterStream { get; set; } = null!;
        public virtual DbSet<TLog_Send_SMS> TLog_Send_SMS { get; set; } = null!;
        public virtual DbSet<TM_Config> TM_Config { get; set; } = null!;
        public virtual DbSet<TM_Menu> TM_Menu { get; set; } = null!;
        public virtual DbSet<TM_Option> TM_Option { get; set; } = null!;
        public virtual DbSet<TM_Option_Sub> TM_Option_Sub { get; set; } = null!;
        public virtual DbSet<TM_Status_Service_New> TM_Status_Service_New { get; set; } = null!;
        public virtual DbSet<TM_Status_Service_Normal> TM_Status_Service_Normal { get; set; } = null!;
        public virtual DbSet<TM_Template_SMS> TM_Template_SMS { get; set; } = null!;
        public virtual DbSet<TMenu> TMenu { get; set; } = null!;
        public virtual DbSet<TMenuGroup> TMenuGroup { get; set; } = null!;
        public virtual DbSet<TMeterSize> TMeterSize { get; set; } = null!;
        public virtual DbSet<TMeterType> TMeterType { get; set; } = null!;
        public virtual DbSet<TMobileComplaints> TMobileComplaints { get; set; } = null!;
        public virtual DbSet<TMobileNews> TMobileNews { get; set; } = null!;
        public virtual DbSet<TMobileRegis> TMobileRegis { get; set; } = null!;
        public virtual DbSet<TMobile_Member> TMobile_Member { get; set; } = null!;
        public virtual DbSet<TMobile_News> TMobile_News { get; set; } = null!;
        public virtual DbSet<TMobile_News_Log> TMobile_News_Log { get; set; } = null!;
        public virtual DbSet<TPaidARUU> TPaidARUU { get; set; } = null!;
        public virtual DbSet<TPlatform> TPlatform { get; set; } = null!;
        public virtual DbSet<TPrintReason> TPrintReason { get; set; } = null!;
        public virtual DbSet<TROUTE> TROUTE { get; set; } = null!;
        public virtual DbSet<TReadMeter> TReadMeter { get; set; } = null!;
        public virtual DbSet<TRefundUU> TRefundUU { get; set; } = null!;
        public virtual DbSet<TRefundUU_Item> TRefundUU_Item { get; set; } = null!;
        public virtual DbSet<TReq_Service> TReq_Service { get; set; } = null!;
        public virtual DbSet<TReq_ServiceHis> TReq_ServiceHis { get; set; } = null!;
        public virtual DbSet<TRunDocNo> TRunDocNo { get; set; } = null!;
        public virtual DbSet<TServiceCharge> TServiceCharge { get; set; } = null!;
        public virtual DbSet<TService_Type> TService_Type { get; set; } = null!;
        public virtual DbSet<TSystem_LogError> TSystem_LogError { get; set; } = null!;
        public virtual DbSet<TTumbon> TTumbon { get; set; } = null!;
        public virtual DbSet<TUseLog> TUseLog { get; set; } = null!;
        public virtual DbSet<TUser> TUser { get; set; } = null!;
        public virtual DbSet<TUser_Permission> TUser_Permission { get; set; } = null!;
        public virtual DbSet<TWaterStream> TWaterStream { get; set; } = null!;
        public virtual DbSet<TWaterSupply> TWaterSupply { get; set; } = null!;
        public virtual DbSet<TWaterUseType> TWaterUseType { get; set; } = null!;
        public virtual DbSet<TWaterUseTypeGroup> TWaterUseTypeGroup { get; set; } = null!;
        public virtual DbSet<TransferHistory> TransferHistory { get; set; } = null!;
        public virtual DbSet<TypePayment> TypePayment { get; set; } = null!;
        public virtual DbSet<View_1> View_1 { get; set; } = null!;
        public virtual DbSet<vCustomer> vCustomer { get; set; } = null!;
        public virtual DbSet<vExternalServiceWork> vExternalServiceWork { get; set; } = null!;
        public virtual DbSet<vExternalServiceWork_Detail> vExternalServiceWork_Detail { get; set; } = null!;
        public virtual DbSet<vInvoice> vInvoice { get; set; } = null!;
        public virtual DbSet<vInvoiceReduce_Detail> vInvoiceReduce_Detail { get; set; } = null!;
        public virtual DbSet<vInvoiceReduce_List> vInvoiceReduce_List { get; set; } = null!;
        public virtual DbSet<vLineOA> vLineOA { get; set; } = null!;
        public virtual DbSet<vPayment> vPayment { get; set; } = null!;
        public virtual DbSet<vRegisterCustomer> vRegisterCustomer { get; set; } = null!;
        public virtual DbSet<vReportMeter09> vReportMeter09 { get; set; } = null!;
        public virtual DbSet<vReportMeter16> vReportMeter16 { get; set; } = null!;
        public virtual DbSet<vReportService03> vReportService03 { get; set; } = null!;
        public virtual DbSet<vReportService05> vReportService05 { get; set; } = null!;
        public virtual DbSet<vRequestNoVat> vRequestNoVat { get; set; } = null!;
        public virtual DbSet<vRequestWaterStream> vRequestWaterStream { get; set; } = null!;
        public virtual DbSet<vWater_usage> vWater_usage { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=103.129.15.138,1434\\\\\\\\SQL2014;Database=BillingLocal_NK;User ID=billing;Password=uu@1234;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AMP_CODE).HasMaxLength(255);

                entity.Property(e => e.AMP_T).HasMaxLength(255);

                entity.Property(e => e.PROV_CODE).HasMaxLength(255);

                entity.Property(e => e.PROV_T).HasMaxLength(255);

                entity.Property(e => e.TAM_CODE).HasMaxLength(255);

                entity.Property(e => e.TAM_T).HasMaxLength(255);

                entity.Property(e => e.VILL_CODE).HasMaxLength(255);

                entity.Property(e => e.VILL_NO).HasMaxLength(255);

                entity.Property(e => e.VILL_T).HasMaxLength(255);
            });

            modelBuilder.Entity<ChangeUseType>(entity =>
            {
                entity.HasKey(e => new { e.WWCODE, e.CUSTCODE, e.REVYM });

                entity.Property(e => e.WWCODE).HasMaxLength(7);

                entity.Property(e => e.CUSTCODE).HasMaxLength(7);

                entity.Property(e => e.REVYM).HasMaxLength(4);

                entity.Property(e => e.CHGDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NEWTYPE).HasMaxLength(3);

                entity.Property(e => e.OLDTYPE).HasMaxLength(3);
            });

            modelBuilder.Entity<ChangeUseType6203>(entity =>
            {
                entity.HasKey(e => e.SCUSTCODE)
                    .HasName("PK_ChangUseType");

                entity.Property(e => e.SCUSTCODE).HasMaxLength(50);

                entity.Property(e => e.SCUSTNAME).HasMaxLength(250);

                entity.Property(e => e.SUSETYPE).HasMaxLength(50);

                entity.Property(e => e.new_usetype).HasMaxLength(50);
            });

            modelBuilder.Entity<DBBADDEBT>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BKCODE).HasMaxLength(20);

                entity.Property(e => e.CUSTADDR).HasMaxLength(75);

                entity.Property(e => e.CUSTCODE).HasMaxLength(7);

                entity.Property(e => e.CUSTNAME).HasMaxLength(75);

                entity.Property(e => e.CUSTSTAT).HasMaxLength(1);

                entity.Property(e => e.DEBTCLOSE).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DOCNO).HasMaxLength(12);

                entity.Property(e => e.REPDATE).HasMaxLength(12);

                entity.Property(e => e.REPYM).HasMaxLength(4);

                entity.Property(e => e.REVYM).HasMaxLength(4);

                entity.Property(e => e.ROUTE).HasMaxLength(7);

                entity.Property(e => e.USETYPE).HasMaxLength(3);

                entity.Property(e => e.WWCODE).HasMaxLength(7);
            });

            modelBuilder.Entity<DBBADDEBTUU>(entity =>
            {
                entity.HasKey(e => new { e.WWCODE, e.CUSTCODE, e.REVYM, e.REPYM });

                entity.Property(e => e.WWCODE).HasMaxLength(7);

                entity.Property(e => e.CUSTCODE).HasMaxLength(7);

                entity.Property(e => e.REVYM).HasMaxLength(4);

                entity.Property(e => e.REPYM).HasMaxLength(4);

                entity.Property(e => e.BKCODE).HasMaxLength(20);

                entity.Property(e => e.CUSTADDR).HasMaxLength(75);

                entity.Property(e => e.CUSTNAME).HasMaxLength(75);

                entity.Property(e => e.CUSTSTAT).HasMaxLength(1);

                entity.Property(e => e.DEBTCLOSE).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DOCNO).HasMaxLength(12);

                entity.Property(e => e.REPDATE).HasMaxLength(12);

                entity.Property(e => e.ROUTE).HasMaxLength(7);

                entity.Property(e => e.USETYPE).HasMaxLength(3);
            });

            modelBuilder.Entity<DBDEBT>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BKCODE).HasMaxLength(20);

                entity.Property(e => e.CUSTADDR).HasMaxLength(250);

                entity.Property(e => e.CUSTCODE).HasMaxLength(7);

                entity.Property(e => e.CUSTNAME).HasMaxLength(250);

                entity.Property(e => e.CUSTSTAT).HasMaxLength(1);

                entity.Property(e => e.DEBTCLOSE).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DOCNO).HasMaxLength(12);

                entity.Property(e => e.REPDATE).HasMaxLength(12);

                entity.Property(e => e.REPYM).HasMaxLength(4);

                entity.Property(e => e.REVYM).HasMaxLength(4);

                entity.Property(e => e.ROUTE).HasMaxLength(7);

                entity.Property(e => e.USETYPE).HasMaxLength(3);

                entity.Property(e => e.WWCODE).HasMaxLength(7);
            });

            modelBuilder.Entity<DBLOW>(entity =>
            {
                entity.HasKey(e => new { e.SWWCODE, e.SUSETYPE, e.dStart });

                entity.HasComment("อัตราค่าน้ำขั้นต่ำ");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.SUSETYPE)
                    .HasMaxLength(3)
                    .HasComment("ประเภทผู้ใช้น้ำ");

                entity.Property(e => e.dStart).HasColumnType("date");

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SCOMMENT).HasMaxLength(100);

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");

                entity.Property(e => e.nLowrate)
                    .HasColumnType("numeric(24, 0)")
                    .HasComment("ค่าน้ำขั้นต่ำ");

                entity.HasOne(d => d.SWWCODENavigation)
                    .WithMany(p => p.DBLOW)
                    .HasForeignKey(d => d.SWWCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DBLOW_REFERENCE_TWATERSU");
            });

            modelBuilder.Entity<DBSM04>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CALMTHD).HasMaxLength(1);

                entity.Property(e => e.CANTMTR).HasMaxLength(100);

                entity.Property(e => e.CANTREAD).HasMaxLength(100);

                entity.Property(e => e.CHGTYPE).HasMaxLength(1);

                entity.Property(e => e.CUSTCODE).HasMaxLength(7);

                entity.Property(e => e.CalWtusg).HasMaxLength(2);

                entity.Property(e => e.DateKeep).HasColumnType("datetime");

                entity.Property(e => e.LSTMTRRDDT).HasColumnType("datetime");

                entity.Property(e => e.MTRRDDT).HasColumnType("datetime");

                entity.Property(e => e.MTRWALK).HasMaxLength(1);

                entity.Property(e => e.PRSMTRSTAT).HasMaxLength(1);

                entity.Property(e => e.PRSRDANS).HasMaxLength(1);

                entity.Property(e => e.REVYM).HasMaxLength(4);

                entity.Property(e => e.SOL).HasMaxLength(2);

                entity.Property(e => e.WWCODE).HasMaxLength(7);
            });

            modelBuilder.Entity<DBWaterRate>(entity =>
            {
                entity.HasKey(e => e.nWaterRateID)
                    .HasName("PK_DBWaterRate_1");

                entity.Property(e => e.CUSETYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("ประเภทอัตาค่าน้ำ");

                entity.Property(e => e.IsActive).HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.dAdd)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.dStart).HasColumnType("date");

                entity.Property(e => e.dUpdate)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.sAddBy).HasComment("ผู้บันทึก");

                entity.Property(e => e.sDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.sUpdateBy).HasComment("ผู้แก้ไข");
            });

            modelBuilder.Entity<DBWaterRate_Item>(entity =>
            {
                entity.HasKey(e => new { e.nWaterRateID, e.nItem });

                entity.HasComment("อัตาค่าน้ำประปา");

                entity.Property(e => e.NACWTTRFAMT).HasComment("ค่าน้ำสะสมมาจนถึงชั้นนี้");

                entity.Property(e => e.NHIGUSGRAN).HasComment("การใช้น้ำสูงสุดในช่วง");

                entity.Property(e => e.NLOWUSGRAN).HasComment("การใช้น้ำต่ำสุดในช่วง");

                entity.Property(e => e.NWTTRFRT).HasComment("อัตราค่าน้ำในชั้นนี้");
            });

            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FLAG)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SCUSTADDR).HasMaxLength(255);

                entity.Property(e => e.SCUSTCODE)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.SCUSTNAME).HasMaxLength(255);

                entity.Property(e => e.SUSETYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogGlobalError>(entity =>
            {
                entity.HasKey(e => e.nID);

                entity.Property(e => e.dCreate).HasColumnType("datetime");
            });

            modelBuilder.Entity<METERDEP>(entity =>
            {
                entity.HasKey(e => new { e.SWWCODE, e.SMETERSIZE });

                entity.HasComment("ค่าธรรมเนียมฝากมาตร");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.SMETERSIZE)
                    .HasMaxLength(2)
                    .HasComment("รหัสขนาดมิเตอร์");

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.NFTSYEAR)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ปีที่ 1");

                entity.Property(e => e.NMETERMK)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ค่าธรรมเนียมประสานมาตร");

                entity.Property(e => e.NSECYEAR)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ปีที่ 2");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SCOMMENT).HasMaxLength(200);

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");

                entity.HasOne(d => d.SMETERSIZENavigation)
                    .WithMany(p => p.METERDEP)
                    .HasForeignKey(d => d.SMETERSIZE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_METERDEP_REFERENCE_TMETERSI");

                entity.HasOne(d => d.SWWCODENavigation)
                    .WithMany(p => p.METERDEP)
                    .HasForeignKey(d => d.SWWCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_METERDEP_REFERENCE_TWATERSU");
            });

            modelBuilder.Entity<METERDIPO>(entity =>
            {
                entity.HasKey(e => new { e.SWWCODE, e.SMETERSIZE });

                entity.HasComment("ค่ามัดจำมาตรวัดน้ำ");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.SMETERSIZE)
                    .HasMaxLength(2)
                    .HasComment("รหัสขนาดมิเตอร์");

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะ 1=Active 0=Not Active");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.NMTRDIPO)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ค่ามัดจำมาตรถาวร");

                entity.Property(e => e.NMTRDIPO2)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ค่ามัดจำมาตรชั่วคราว");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SCOMMENT).HasMaxLength(200);

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");

                entity.HasOne(d => d.SMETERSIZENavigation)
                    .WithMany(p => p.METERDIPO)
                    .HasForeignKey(d => d.SMETERSIZE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_METERDIP_REFERENCE_TMETERSI");

                entity.HasOne(d => d.SWWCODENavigation)
                    .WithMany(p => p.METERDIPO)
                    .HasForeignKey(d => d.SWWCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_METERDIP_REFERENCE_TWATERSU");
            });

            modelBuilder.Entity<METERINS>(entity =>
            {
                entity.HasKey(e => new { e.SWWCODE, e.SMETERSIZE });

                entity.HasComment("ค่าประกัน");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.SMETERSIZE)
                    .HasMaxLength(2)
                    .HasComment("รหัสขนาดมิเตอร์");

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SCOMMENT).HasMaxLength(200);

                entity.Property(e => e.SMTRINS)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ค่าประกันมาตรถาวร");

                entity.Property(e => e.SMTRINS2)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ค่าประกันมาตรชั่วคราว");

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");

                entity.HasOne(d => d.SMETERSIZENavigation)
                    .WithMany(p => p.METERINS)
                    .HasForeignKey(d => d.SMETERSIZE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_METERINS_REFERENCE_TMETERSI");

                entity.HasOne(d => d.SWWCODENavigation)
                    .WithMany(p => p.METERINS)
                    .HasForeignKey(d => d.SWWCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_METERINS_REFERENCE_TWATERSU");
            });

            modelBuilder.Entity<METERJOIN>(entity =>
            {
                entity.HasKey(e => new { e.SWWCODE, e.SMETERSIZE });

                entity.HasComment("ค่าประสานมาตร");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.SMETERSIZE)
                    .HasMaxLength(2)
                    .HasComment("รหัสขนาดมิเตอร์");

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.NMTRJOIN)
                    .HasColumnType("numeric(9, 0)")
                    .HasComment("ค่าประสานมาตร");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SCOMMENT).HasMaxLength(200);

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");

                entity.HasOne(d => d.SMETERSIZENavigation)
                    .WithMany(p => p.METERJOIN)
                    .HasForeignKey(d => d.SMETERSIZE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_METERJOI_REFERENCE_TMETERSI");

                entity.HasOne(d => d.SWWCODENavigation)
                    .WithMany(p => p.METERJOIN)
                    .HasForeignKey(d => d.SWWCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_METERJOI_REFERENCE_TWATERSU");
            });

            modelBuilder.Entity<METERTEST>(entity =>
            {
                entity.HasKey(e => new { e.SWWCODE, e.SMETERSIZE });

                entity.HasComment("ค่าตรวจสอบมาตรวัดน้ำ");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.SMETERSIZE)
                    .HasMaxLength(2)
                    .HasComment("รหัสขนาดมิเตอร์");

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.NTESTFEE)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("ค่าตรวจสอบ");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SCOMMENT).HasMaxLength(200);

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");

                entity.HasOne(d => d.SMETERSIZENavigation)
                    .WithMany(p => p.METERTEST)
                    .HasForeignKey(d => d.SMETERSIZE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_METERTES_REFERENCE_TMETERSI");
            });

            modelBuilder.Entity<OK>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.F17).HasMaxLength(255);

                entity.Property(e => e.F18).HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasColumnType("datetime");

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasColumnType("datetime");

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F32).HasColumnType("datetime");

                entity.Property(e => e.F34).HasMaxLength(255);

                entity.Property(e => e.F35).HasMaxLength(255);

                entity.Property(e => e.F36).HasMaxLength(255);

                entity.Property(e => e.F37).HasMaxLength(255);

                entity.Property(e => e.sAmphur).HasMaxLength(255);

                entity.Property(e => e.sMobile).HasMaxLength(255);

                entity.Property(e => e.sMoo).HasMaxLength(255);

                entity.Property(e => e.sName).HasMaxLength(255);

                entity.Property(e => e.sNo).HasMaxLength(255);

                entity.Property(e => e.sProvince).HasMaxLength(255);

                entity.Property(e => e.sTel).HasMaxLength(255);

                entity.Property(e => e.sTumbon).HasMaxLength(255);

                entity.Property(e => e.อีเมล์).HasMaxLength(255);
            });

            modelBuilder.Entity<PERMISSION>(entity =>
            {
                entity.HasKey(e => new { e.UserID, e.nGroupID, e.WWCODE });

                entity.Property(e => e.WWCODE).HasMaxLength(7);

                entity.Property(e => e.cStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PWA_Constant>(entity =>
            {
                entity.HasKey(e => e.REVYM);

                entity.Property(e => e.REVYM)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BA)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CUSTFLAG0)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CUSTFLAG1)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CUSTTOT)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PRODISCNT)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.WWCODE)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.WWNAMET)
                    .HasMaxLength(65)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PWA_Customer>(entity =>
            {
                entity.HasKey(e => new { e.REVYM, e.WWCODE, e.CUSTCODE });

                entity.Property(e => e.REVYM)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.WWCODE)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CUSTCODE)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CUSTNAME)
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Discount2)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.M1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PWA_FLAG)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaidInsurance>(entity =>
            {
                entity.HasKey(e => new { e.BILLNO, e.SWWCODE, e.DOCNO_REF });

                entity.Property(e => e.BILLNO)
                    .HasMaxLength(10)
                    .HasComment("เลขที่ใบเสร็จ");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.DOCNO_REF)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("เลขที่ใบแจ้งหนี้ที่ตัดชำระ");

                entity.Property(e => e.DADD).HasColumnType("datetime");

                entity.Property(e => e.cSTAT).HasComment("สถานะ 1=จ่ายหมด,2=มีเงินคงเหลือ");

                entity.Property(e => e.nLEAVE)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("จำนวนเงินคงเหลือ");

                entity.Property(e => e.nPAID).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<RECEIPT>(entity =>
            {
                entity.HasKey(e => new { e.WWCODE, e.CUSTCODE, e.BILLNO, e.BILLDATE, e.RowID });

                entity.Property(e => e.WWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.CUSTCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสลูกค้า");

                entity.Property(e => e.BILLNO)
                    .HasMaxLength(10)
                    .HasComment("เลขที่ใบเสร็จ");

                entity.Property(e => e.BILLDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่ออกใบเสร็จ");

                entity.Property(e => e.RowID).ValueGeneratedOnAdd();

                entity.Property(e => e.BILLFLAG)
                    .HasMaxLength(2)
                    .HasComment("สถานะใบเสร็จ");

                entity.Property(e => e.BILLTYPE)
                    .HasMaxLength(2)
                    .HasComment("ประเภทใบเสร็จ");

                entity.Property(e => e.CHEQUEBANK)
                    .HasMaxLength(255)
                    .HasComment("เช็คของธนาคาร");

                entity.Property(e => e.CHEQUEDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่เช็ค");

                entity.Property(e => e.CHEQUENO)
                    .HasMaxLength(250)
                    .HasComment("หมายเลขเช็ค");

                entity.Property(e => e.CHEQUEPAID)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("จำนวนเงินในเช็ค");

                entity.Property(e => e.Cash)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("เงินสด");

                entity.Property(e => e.CashCheque).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DEBT)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("ค้างจ่าย");

                entity.Property(e => e.FEE)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("ค่าธรรมเนียม");

                entity.Property(e => e.PAID)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("จำนวนเงินที่จ่าย");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(2)
                    .HasComment("ประเภทการจ่าย");

                entity.Property(e => e.REFBILLNO)
                    .HasMaxLength(10)
                    .HasComment("หมายเลขอ้างอิง");

                entity.Property(e => e.UserID).HasComment("รหัสผ้ัใช้งาน");

                entity.Property(e => e.cCutCounter)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.dPaid_Transfer).HasColumnType("datetime");

                entity.Property(e => e.dPrintDate).HasColumnType("datetime");

                entity.Property(e => e.nCutCounter).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<RECEIPTLOT>(entity =>
            {
                entity.HasKey(e => new { e.WWCODE, e.DOCNO, e.Billno });

                entity.HasIndex(e => e.Billno, "IX_RECEIPTLOT")
                    .HasFillFactor(90);

                entity.Property(e => e.WWCODE)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("รหัสประปา");

                entity.Property(e => e.DOCNO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("หมายเลขเอกสาร");

                entity.Property(e => e.Billno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("เลขที่ใบเสร็จ");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("จำนวนเงิน");

                entity.Property(e => e.Arrear)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("พื้นที่");

                entity.Property(e => e.BILLFLAG)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะใบเสร็จ");

                entity.Property(e => e.ChangeMoney)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("-");

                entity.Property(e => e.DISCNTAMT)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("ส่วนลด");

                entity.Property(e => e.LOT).HasComment("งวดที่");

                entity.Property(e => e.NETTRFWT)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("ใช้น้ำสุฑธิ");

                entity.Property(e => e.PROMOAMT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PRSWTUSG)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("ปริมาณน้ำที่ใช้");

                entity.Property(e => e.ReceiptMoney)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("จำนวนเงินที่รับ");

                entity.Property(e => e.SRVFEE)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("ค่าบริการ");

                entity.Property(e => e.TOTTRFWT)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("ค่าน้ำรวม");

                entity.Property(e => e.VAT)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("VAT");

                entity.Property(e => e.cARUU)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.cApprov_Cancel).HasMaxLength(1);

                entity.Property(e => e.cApprov_Cancel2).HasMaxLength(1);

                entity.Property(e => e.dARUU).HasColumnType("datetime");

                entity.Property(e => e.dApprov_Cancel).HasColumnType("datetime");

                entity.Property(e => e.dApprov_Cancel2).HasColumnType("datetime");

                entity.Property(e => e.dCancel).HasColumnType("datetime");

                entity.Property(e => e.dCancelAdd).HasColumnType("datetime");

                entity.Property(e => e.ddate)
                    .HasColumnType("datetime")
                    .HasComment("วันที่");

                entity.Property(e => e.sAppComment).HasMaxLength(512);

                entity.Property(e => e.sAppComment2).HasMaxLength(512);

                entity.Property(e => e.sReasonCancel)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.sUser).HasMaxLength(10);

                entity.Property(e => e.userid).HasComment("รหัสผ้ัใช้งาน");
            });

            modelBuilder.Entity<RECEIPT_Service>(entity =>
            {
                entity.HasKey(e => e.BILLNO)
                    .HasName("PK_RECEIPT_SERVICE");

                entity.HasComment("ชำระค่าบริการ");

                entity.Property(e => e.BILLNO)
                    .HasMaxLength(10)
                    .HasComment("เลขที่ใบเสร็จ");

                entity.Property(e => e.BILLDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("วันที่ออกใบเสร็จ");

                entity.Property(e => e.BILLFLAG)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("((1))")
                    .HasComment("สถานะใบเสร็จ");

                entity.Property(e => e.BILLTYPE)
                    .HasMaxLength(2)
                    .HasComment("ประเภทใบเสร็จ");

                entity.Property(e => e.CHEQUEBANK)
                    .HasMaxLength(255)
                    .HasComment("เช็คของธนาคาร");

                entity.Property(e => e.CHEQUEDATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("วันที่เช็ค");

                entity.Property(e => e.CHEQUENO)
                    .HasMaxLength(250)
                    .HasComment("หมายเลขเช็ค");

                entity.Property(e => e.CHEQUEPAID)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("จำนวนเงินในเช็ค");

                entity.Property(e => e.CUSTCODE)
                    .HasMaxLength(10)
                    .HasComment("รหัสลูกค้า");

                entity.Property(e => e.Cash)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("เงินสด");

                entity.Property(e => e.CashCheque).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChangeMoney).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DEBT)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("ค้างจ่าย");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.FEE)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("ค่าธรรมเนียม");

                entity.Property(e => e.PAID)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("จำนวนเงินที่จ่าย");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("((1))")
                    .HasComment("ประเภทการจ่าย");

                entity.Property(e => e.REFBILLNO).HasMaxLength(10);

                entity.Property(e => e.ReceiptMoney).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");

                entity.Property(e => e.WWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.cApprov_Cancel).HasMaxLength(1);

                entity.Property(e => e.cApprov_Cancel2).HasMaxLength(1);

                entity.Property(e => e.cCutCounter)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.dApprov_Cancel).HasColumnType("datetime");

                entity.Property(e => e.dApprov_Cancel2).HasColumnType("datetime");

                entity.Property(e => e.dCancel).HasColumnType("datetime");

                entity.Property(e => e.dCancelAdd).HasColumnType("datetime");

                entity.Property(e => e.dPaid_Transfer).HasColumnType("datetime");

                entity.Property(e => e.dPrintDate).HasColumnType("datetime");

                entity.Property(e => e.nCutCounter).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.sAppComment).HasMaxLength(512);

                entity.Property(e => e.sAppComment2).HasMaxLength(512);

                entity.Property(e => e.sCommentPrint)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.sInvoiceNo)
                    .HasMaxLength(20)
                    .HasComment("รหัสใบแจ้งหนี้");

                entity.Property(e => e.sReasonCancel)
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportAccount15His>(entity =>
            {
                entity.HasKey(e => new { e.SROUTE, e.SWWCODE, e.SREVYM });

                entity.Property(e => e.SROUTE).HasMaxLength(6);

                entity.Property(e => e.SWWCODE).HasMaxLength(7);

                entity.Property(e => e.SREVYM).HasMaxLength(4);

                entity.Property(e => e.NDISCNTAMT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NNORTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NSRVFEE).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NTOTTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NVAT2).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.SUMS).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.VAT).HasColumnType("numeric(10, 2)");
            });

            modelBuilder.Entity<TArea>(entity =>
            {
                entity.HasKey(e => e.sAreaCode)
                    .HasName("PK_TAREA");

                entity.Property(e => e.sAreaCode).HasMaxLength(6);

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DADD).HasColumnType("datetime");

                entity.Property(e => e.DUPDATE).HasColumnType("datetime");

                entity.Property(e => e.SCOMMENT).HasMaxLength(200);

                entity.Property(e => e.SWWCODE).HasMaxLength(7);

                entity.Property(e => e.cType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.sAreaHeadCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.sAreaHeadOfHeadCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.sAreaLongName).HasMaxLength(400);

                entity.Property(e => e.sAreaName).HasMaxLength(100);

                entity.Property(e => e.sPosCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TB_BankCompany>(entity =>
            {
                entity.HasKey(e => e.nBankID);

                entity.Property(e => e.IsActive).HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.IsDel).HasComment("สถานะการลบ");

                entity.Property(e => e.dAdd)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.dUpdate)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.sAddBy).HasComment("ผู้บันทึก");

                entity.Property(e => e.sBranch)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.sCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.sName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.sUpdateBy).HasComment("ผู้แก้ไข");
            });

            modelBuilder.Entity<TB_Group>(entity =>
            {
                entity.HasKey(e => e.nGroupID);

                entity.Property(e => e.dAdd).HasColumnType("datetime");

                entity.Property(e => e.dUpdate).HasColumnType("datetime");

                entity.Property(e => e.sDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.sName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TB_Group_Permission>(entity =>
            {
                entity.HasKey(e => new { e.nGroupID, e.nMenuID });
            });

            modelBuilder.Entity<TB_Promotion>(entity =>
            {
                entity.HasKey(e => e.nPromotionID);

                entity.Property(e => e.nPromotionID).ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.IsDel).HasComment("สถานะการลบ");

                entity.Property(e => e.PROMOBATH)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("จำนวนเงินที่ลด");

                entity.Property(e => e.PROMOCAL)
                    .HasMaxLength(1)
                    .HasComment("การคำนวณส่วนลดนโยบาย");

                entity.Property(e => e.PROMOCODE).HasMaxLength(3);

                entity.Property(e => e.PROMOPCEN)
                    .HasColumnType("numeric(5, 2)")
                    .HasComment("ส่่วนลดเป็นเปอร์เซ็นต์");

                entity.Property(e => e.PROMORATIO)
                    .HasMaxLength(4)
                    .HasComment("อัตราส่วนที่ลด");

                entity.Property(e => e.PROMOUNIT)
                    .HasColumnType("numeric(5, 2)")
                    .HasComment("จำนวนหน่วยน้ำที่ลด");

                entity.Property(e => e.SCOMMENT).HasMaxLength(500);

                entity.Property(e => e.dAdd)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.dEnd).HasColumnType("date");

                entity.Property(e => e.dStart).HasColumnType("date");

                entity.Property(e => e.dUpdate)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.sAddBy).HasComment("ผู้บันทึก");

                entity.Property(e => e.sUpdateBy).HasComment("ผู้แก้ไข");
            });

            modelBuilder.Entity<TB_Promotion_MeterSize>(entity =>
            {
                entity.HasKey(e => new { e.nPromotionID, e.SMETERSIZE });

                entity.Property(e => e.SMETERSIZE)
                    .HasMaxLength(2)
                    .HasComment("ขนาดมาตร");
            });

            modelBuilder.Entity<TB_Promotion_UseType>(entity =>
            {
                entity.HasKey(e => new { e.nPromotionID, e.SUSETYPE });

                entity.Property(e => e.SUSETYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("รหัสกลุ่มประเภทผู้ใช้น้ำ");
            });

            modelBuilder.Entity<TB_WaterUseTypeGroup>(entity =>
            {
                entity.HasKey(e => e.SUSETYPE)
                    .HasName("PK_TB_WaterUseTypeGroup_1");

                entity.Property(e => e.SUSETYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("รหัสกลุ่มประเภทผู้ใช้น้ำ");

                entity.Property(e => e.IsActive).HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.IsDel).HasComment("สถานะการลบ");

                entity.Property(e => e.SCOMMENT).HasMaxLength(200);

                entity.Property(e => e.SUSEMEAN)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasComment("ชื่อกลุ่มประเภทผู้ใช้น้ำ");

                entity.Property(e => e.dAdd)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.dUpdate)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.sAddBy).HasComment("ผู้บันทึก");

                entity.Property(e => e.sMainType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.sUpdateBy).HasComment("ผู้แก้ไข");
            });

            modelBuilder.Entity<TBank>(entity =>
            {
                entity.HasKey(e => e.SBKCODE)
                    .HasName("PK_TBank_1");

                entity.HasComment("ธนาคาร\r\n   DBST70");

                entity.Property(e => e.SBKCODE)
                    .HasMaxLength(4)
                    .HasComment("รหัสธนาคาร");

                entity.Property(e => e.BankFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SBANCH)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.SBANCHCODE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SBKNAME)
                    .HasMaxLength(45)
                    .HasComment("ชื่อธนาคาร");

                entity.Property(e => e.SCOMMENT).HasMaxLength(200);

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");

                entity.Property(e => e.SWWCODE).HasMaxLength(7);

                entity.HasOne(d => d.SWWCODENavigation)
                    .WithMany(p => p.TBank)
                    .HasForeignKey(d => d.SWWCODE)
                    .HasConstraintName("FK_TBank_TWaterSupply");
            });

            modelBuilder.Entity<TBigMeter>(entity =>
            {
                entity.HasKey(e => new { e.WWCODE, e.CUSTCODE })
                    .HasName("PK_DBSM56")
                    .IsClustered(false);

                entity.HasComment("มาตรใหญ่\r\n   DBSM56");

                entity.Property(e => e.WWCODE).HasMaxLength(7);

                entity.Property(e => e.CUSTCODE).HasMaxLength(7);

                entity.Property(e => e.BIGMETER).HasMaxLength(6);

                entity.Property(e => e.CONTROLMTR)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.NOOFHOUSE).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.TCustomer)
                    .WithOne(p => p.TBigMeter)
                    .HasForeignKey<TBigMeter>(d => new { d.WWCODE, d.CUSTCODE })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBIGMETE_REFERENCE_TCUSTOME");
            });

            modelBuilder.Entity<TBrand>(entity =>
            {
                entity.HasKey(e => e.SBRANDCODE)
                    .HasName("PK_TBRAND");

                entity.HasComment("ยี่ห้อ\r\n   DBST47");

                entity.Property(e => e.SBRANDCODE)
                    .HasMaxLength(2)
                    .HasComment("รหัสยี่ห้อ");

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SBRANDNAME)
                    .HasMaxLength(256)
                    .HasComment("ชื่อยี่ห้อ");

                entity.Property(e => e.SCOMMENT).HasMaxLength(200);

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");
            });

            modelBuilder.Entity<TChangePassword>(entity =>
            {
                entity.HasKey(e => new { e.SUSERID, e.nTime, e.SWWCODE })
                    .HasName("PK_CHANGEPASSWORD");

                entity.Property(e => e.SWWCODE).HasMaxLength(7);

                entity.Property(e => e.DUPDATE).HasColumnType("datetime");

                entity.Property(e => e.SNEWPASSWORD).HasMaxLength(50);

                entity.Property(e => e.SOLDPASSWORD).HasMaxLength(50);
            });

            modelBuilder.Entity<TConcession>(entity =>
            {
                entity.HasKey(e => e.CAREAID);

                entity.Property(e => e.CAREAID)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SAREANAME).HasMaxLength(100);
            });

            modelBuilder.Entity<TConcession_Area>(entity =>
            {
                entity.HasKey(e => e.NCAREAID);

                entity.Property(e => e.NCAREAID).ValueGeneratedNever();

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SAREANAME).HasMaxLength(100);

                entity.Property(e => e.SCOMMENT).HasMaxLength(200);

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");

                entity.Property(e => e.nTypeID).HasComment("TM_Option_Sub Type = 32");
            });

            modelBuilder.Entity<TCust_Meter>(entity =>
            {
                entity.HasKey(e => new { e.SWWCODE, e.SCUSTCODE });

                entity.HasComment("ข้อมูลมาตรลูกค้า\r\n   DBSM03");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.SCUSTCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสลูกค้า");

                entity.Property(e => e.BRKMTRDT).HasColumnType("datetime");

                entity.Property(e => e.CLSTCALMTHD).HasMaxLength(1);

                entity.Property(e => e.CLSTRDANS).HasMaxLength(1);

                entity.Property(e => e.CMETERSTAT)
                    .HasMaxLength(1)
                    .HasComment("ประเภทมาตร");

                entity.Property(e => e.CONTROLMTR).HasMaxLength(1);

                entity.Property(e => e.DBGNMTRDT).HasColumnType("datetime");

                entity.Property(e => e.DLSTCALDT).HasColumnType("datetime");

                entity.Property(e => e.DLSTMTRRDDT).HasColumnType("datetime");

                entity.Property(e => e.INVOICST)
                    .HasMaxLength(1)
                    .HasComment("1=ไม่พิมพ์,2=พิมพ์");

                entity.Property(e => e.NBGNMTRCNT).HasComment("เลขมาตรเริ่มต้น");

                entity.Property(e => e.NLSTMTRCNT).HasComment("เลขมาตรครั้งก่อน");

                entity.Property(e => e.REVYM).HasMaxLength(4);

                entity.Property(e => e.SERVFLAG).HasMaxLength(1);

                entity.Property(e => e.SLSTMTRRDR).HasMaxLength(4);

                entity.Property(e => e.SMETERNO)
                    .HasMaxLength(20)
                    .HasComment("รหัสมิเตอร์");

                entity.Property(e => e.SMETERSIZE)
                    .HasMaxLength(2)
                    .HasComment("ขนาดมาตร");

                entity.Property(e => e.SMTRMKCODE)
                    .HasMaxLength(2)
                    .HasComment("ยี่ห้อมาตร");
            });

            modelBuilder.Entity<TCustomer>(entity =>
            {
                entity.HasKey(e => new { e.SWWCODE, e.SCUSTCODE });

                entity.HasComment("ข้อมูลลูกค้า\r\n   DBSM01");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.SCUSTCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสลูกค้า");

                entity.Property(e => e.AID).HasMaxLength(4);

                entity.Property(e => e.CAREAID)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CCUSTSTAT)
                    .HasMaxLength(1)
                    .HasComment("สถานะผู้ใช้น้ำ (1=ปกติ,4=มาตรหาย,5=ถูกตัดมาตร,6=งดใช้น้ำชั่วคราว,7=ยกเลิกถาวร)");

                entity.Property(e => e.CDISCNTCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสสิทธิส่วนลด");

                entity.Property(e => e.CPROMOTCODE).HasMaxLength(1);

                entity.Property(e => e.CTEMPMTCUST)
                    .HasMaxLength(1)
                    .HasComment("แบบการติดตั้ง(1=ถาวร,2=ชั่วคราว,3=รับโอน)");

                entity.Property(e => e.CUSERTYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DBGNCUSTDT)
                    .HasColumnType("datetime")
                    .HasComment("วันที่ติดตั้ง");

                entity.Property(e => e.DLSTCONTDT)
                    .HasColumnType("datetime")
                    .HasComment("วันที่สิ้นสุดสัญญา");

                entity.Property(e => e.DLSTLVMTRDT)
                    .HasColumnType("datetime")
                    .HasComment("วันที่สิ้นสุดการฝากมาตร");

                entity.Property(e => e.DMA).HasMaxLength(20);

                entity.Property(e => e.DSTATUSDT)
                    .HasColumnType("datetime")
                    .HasComment("วันที่สิ้นสุดสัญญา");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.NSEQ)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("ลำดับการอ่านมาตร");

                entity.Property(e => e.PID).HasMaxLength(4);

                entity.Property(e => e.SACCODE)
                    .HasMaxLength(10)
                    .HasComment("หักเลขที่ บ/ช");

                entity.Property(e => e.SACNAME)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("ชื่อ บ/ช");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SBKCODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("ธนาคาร");

                entity.Property(e => e.SCONTRACNO)
                    .HasMaxLength(10)
                    .HasComment("หมายเชขสัญญา");

                entity.Property(e => e.SCUSTADDR)
                    .HasMaxLength(255)
                    .HasComment("ที่อยู่ลูกค้า");

                entity.Property(e => e.SCUSTADDR_OLD).HasMaxLength(75);

                entity.Property(e => e.SCUSTNAME)
                    .HasMaxLength(200)
                    .HasComment("ชื่อลูกค้า");

                entity.Property(e => e.SCUSTNAME_OLD).HasMaxLength(75);

                entity.Property(e => e.SGOVNCODE)
                    .HasMaxLength(4)
                    .HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.SGROUP_ROUTE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SGROUP_USETYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SMETERSIZE)
                    .HasMaxLength(2)
                    .HasComment("ขนาดมาตร");

                entity.Property(e => e.SNEARLOCATE).HasMaxLength(65);

                entity.Property(e => e.SROUTE)
                    .HasMaxLength(6)
                    .HasComment("เส้นทางอ่านมาตร");

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");

                entity.Property(e => e.SUSETYPE)
                    .HasMaxLength(3)
                    .HasComment("ประเภทการใช้น้ำ");

                entity.Property(e => e.TID).HasMaxLength(4);

                entity.Property(e => e.cBankType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("1=ออมทรัพย์ 2=กระแสรายวัน");

                entity.Property(e => e.cRefundGuarantee)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.cRegisType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("ประเภทแบบคำขอ 1=ติดตั้ง 2=วางท่อ 3=ใช้น้ำชั่วคราว 4=ขอเลขที่ใช้น้ำ");

                entity.Property(e => e.cdiscntsold)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.cprintflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("การพิมพ์จดหมายแจ้งหนี้");

                entity.Property(e => e.dBirthdate)
                    .HasColumnType("datetime")
                    .HasComment("วันเกิด");

                entity.Property(e => e.dDateExpire)
                    .HasColumnType("datetime")
                    .HasComment("วันที่หมดอายุ");

                entity.Property(e => e.dInformCancel).HasColumnType("datetime");

                entity.Property(e => e.dRefundDate).HasColumnType("datetime");

                entity.Property(e => e.dStatChange).HasColumnType("datetime");

                entity.Property(e => e.dchgdate).HasColumnType("datetime");

                entity.Property(e => e.nLeaveInsurance).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.nRefundAmount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.sAmphurCode)
                    .HasMaxLength(4)
                    .HasComment("อำเภอ");

                entity.Property(e => e.sBirthYear).HasMaxLength(4);

                entity.Property(e => e.sBranchCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.sCitizenID)
                    .HasMaxLength(13)
                    .HasComment("บัตรประจำตัวประชาชน");

                entity.Property(e => e.sCustComment).HasMaxLength(500);

                entity.Property(e => e.sDateExpire).HasMaxLength(50);

                entity.Property(e => e.sEmail).HasMaxLength(100);

                entity.Property(e => e.sFileCard)
                    .HasMaxLength(100)
                    .HasComment("ไฟล์บัตรประจำตัวประชาชน");

                entity.Property(e => e.sFileConfirm).HasMaxLength(100);

                entity.Property(e => e.sFileOther)
                    .HasMaxLength(100)
                    .HasComment("ไฟล์หลักฐานอื่นๆ");

                entity.Property(e => e.sFileOtherName)
                    .HasMaxLength(100)
                    .HasComment("ชื่อหลักฐานอื่นๆ");

                entity.Property(e => e.sFileRegistration)
                    .HasMaxLength(100)
                    .HasComment("ไฟล์สำเนาทะเบียนบ้าน");

                entity.Property(e => e.sFileRequest)
                    .HasMaxLength(100)
                    .HasComment("ไฟล์แบบคำขอ");

                entity.Property(e => e.sMobile)
                    .HasMaxLength(100)
                    .HasComment("โทรศัพท์ (มือถือสำรอง)");

                entity.Property(e => e.sMobileSMS)
                    .HasMaxLength(100)
                    .HasComment("โทรศัพท์ (มือถือส่ง SMS)");

                entity.Property(e => e.sMoo)
                    .HasMaxLength(100)
                    .HasComment("หมู่ที่");

                entity.Property(e => e.sNearPlace)
                    .HasMaxLength(100)
                    .HasComment("สถานที่ใกล้เคียง");

                entity.Property(e => e.sNo)
                    .HasMaxLength(100)
                    .HasComment("บ้านเลขที่");

                entity.Property(e => e.sPostcode)
                    .HasMaxLength(5)
                    .HasComment("รหัสไปรณีย์");

                entity.Property(e => e.sProv_Code)
                    .HasMaxLength(2)
                    .HasComment("จังหวัด");

                entity.Property(e => e.sRegisID)
                    .HasMaxLength(10)
                    .HasComment("รหัสใบคำขอ");

                entity.Property(e => e.sRoad)
                    .HasMaxLength(50)
                    .HasComment("ถนน");

                entity.Property(e => e.sTel)
                    .HasMaxLength(100)
                    .HasComment("เบอร์โทรศัพท์");

                entity.Property(e => e.sTumbonCode)
                    .HasMaxLength(6)
                    .HasComment("ตำบล");

                entity.Property(e => e.sVillage).HasMaxLength(100);

                entity.Property(e => e.sWork)
                    .HasMaxLength(200)
                    .HasComment("อาชีพ");

                entity.Property(e => e.sWorkPlace)
                    .HasMaxLength(200)
                    .HasComment("สถานที่ทำงาน");

                entity.Property(e => e.sWorkTel)
                    .HasMaxLength(100)
                    .HasComment("โทรศัพท์ (ที่ทำงาน)");

                entity.Property(e => e.schgtype).HasMaxLength(3);

                entity.Property(e => e.soldtype).HasMaxLength(3);
            });

            modelBuilder.Entity<TCustomer_Regis>(entity =>
            {
                entity.HasKey(e => e.sRegisID)
                    .HasName("PK_DBSM01");

                entity.HasComment("ข้อมูลการขึ้นทะเบียนลูกค้า\r\n   ");

                entity.HasIndex(e => e.SWWCODE, "IX_DBSM01_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.SWWCODE, "IX_DBSM01_2")
                    .HasFillFactor(90);

                entity.Property(e => e.sRegisID)
                    .HasMaxLength(10)
                    .HasComment("รหัส");

                entity.Property(e => e.CAREAID)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CUSERTYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.Deposit).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SCUSTCODE).HasMaxLength(7);

                entity.Property(e => e.SCUSTNAME)
                    .HasMaxLength(200)
                    .HasComment("ชื่อลูกค้า");

                entity.Property(e => e.SMETERSIZE)
                    .HasMaxLength(2)
                    .HasComment("ขนาดมาตร");

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.cRegisType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("ประเภทแบบคำขอ 1=ติดตั้ง 2=วางท่อ 3=ใช้น้ำชั่วคราว 4=ขอเลขที่ใช้น้ำ");

                entity.Property(e => e.cStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("1=ยื่นคำขอ 2=ใบเนอราคา 3=ขึ้นทะเบียน 0=ยกเลิก");

                entity.Property(e => e.dCancel)
                    .HasColumnType("datetime")
                    .HasComment("วันที่ยกเลิก");

                entity.Property(e => e.dCloseDate).HasColumnType("datetime");

                entity.Property(e => e.dDateExpire)
                    .HasColumnType("datetime")
                    .HasComment("วันที่หมดอายุ");

                entity.Property(e => e.dSendDate)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แจ้งผู้ยื่นคำขอ");

                entity.Property(e => e.nCost_Install)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("????????????????");

                entity.Property(e => e.nCost_Total).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.nFaucet).HasComment("จำนวนก๊อกน้ำ");

                entity.Property(e => e.nInsurance).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.nPipeInstall).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.sAmphurCode)
                    .HasMaxLength(4)
                    .HasComment("อำเภอ");

                entity.Property(e => e.sBirthYear).HasMaxLength(4);

                entity.Property(e => e.sBirthdate)
                    .HasColumnType("datetime")
                    .HasComment("วันเกิด");

                entity.Property(e => e.sBranchCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.sCancelBy).HasComment("ผู้ยกเลิก");

                entity.Property(e => e.sCancelDetail)
                    .HasMaxLength(200)
                    .HasComment("สาเหตุที่ยกเลิก");

                entity.Property(e => e.sCitizenID)
                    .HasMaxLength(13)
                    .HasComment("บัตรประจำตัวประชาชน");

                entity.Property(e => e.sDateExpire).HasMaxLength(50);

                entity.Property(e => e.sEmail).HasMaxLength(100);

                entity.Property(e => e.sFaucetSize)
                    .HasMaxLength(10)
                    .HasComment("ขนาดก๊อกน้ำ");

                entity.Property(e => e.sFileCard)
                    .HasMaxLength(100)
                    .HasComment("ไฟล์บัตรประจำตัวประชาชน");

                entity.Property(e => e.sFileOther)
                    .HasMaxLength(100)
                    .HasComment("ไฟล์หลักฐานอื่นๆ");

                entity.Property(e => e.sFileOtherName)
                    .HasMaxLength(100)
                    .HasComment("ชื่อหลักฐานอื่นๆ");

                entity.Property(e => e.sFileQuaOther)
                    .HasMaxLength(100)
                    .HasComment("แนบเอกสารประกอบ");

                entity.Property(e => e.sFileQuatation)
                    .HasMaxLength(100)
                    .HasComment("แนบใบเสนอราคา");

                entity.Property(e => e.sFileRegistration)
                    .HasMaxLength(100)
                    .HasComment("ไฟล์สำเนาทะเบียนบ้าน");

                entity.Property(e => e.sFileRequest)
                    .HasMaxLength(100)
                    .HasComment("ไฟล์แบบคำขอ");

                entity.Property(e => e.sMeterSize_In)
                    .HasMaxLength(10)
                    .HasComment("ขนาดท่อภายใน");

                entity.Property(e => e.sMobile)
                    .HasMaxLength(100)
                    .HasComment("โทรศัพท์ (มือถือสำรอง)");

                entity.Property(e => e.sMobileSMS)
                    .HasMaxLength(100)
                    .HasComment("โทรศัพท์ (มือถือส่ง SMS)");

                entity.Property(e => e.sMoo)
                    .HasMaxLength(50)
                    .HasComment("หมู่ที่");

                entity.Property(e => e.sNearPlace)
                    .HasMaxLength(100)
                    .HasComment("สถานที่ใกล้เคียง");

                entity.Property(e => e.sNo)
                    .HasMaxLength(100)
                    .HasComment("บ้านเลขที่");

                entity.Property(e => e.sPipeInstallName).HasMaxLength(200);

                entity.Property(e => e.sProv_Code)
                    .HasMaxLength(2)
                    .HasComment("จังหวัด");

                entity.Property(e => e.sQuatationNo).HasMaxLength(100);

                entity.Property(e => e.sReceiptNo).HasMaxLength(100);

                entity.Property(e => e.sRoad)
                    .HasMaxLength(50)
                    .HasComment("ถนน");

                entity.Property(e => e.sStatNote).HasMaxLength(500);

                entity.Property(e => e.sTel)
                    .HasMaxLength(100)
                    .HasComment("โทรศัพท์ (บ้าน)");

                entity.Property(e => e.sTumbonCode)
                    .HasMaxLength(6)
                    .HasComment("ตำบล");

                entity.Property(e => e.sUpdateQuaBy).HasComment("ผู้บันทึกใบเสนอราคา");

                entity.Property(e => e.sVillage).HasMaxLength(100);

                entity.Property(e => e.sWaterCode)
                    .HasMaxLength(20)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.sWork)
                    .HasMaxLength(200)
                    .HasComment("อาชีพ");

                entity.Property(e => e.sWorkPlace)
                    .HasMaxLength(200)
                    .HasComment("สถานที่ทำงาน");

                entity.Property(e => e.sWorkTel)
                    .HasMaxLength(100)
                    .HasComment("โทรศัพท์ (ที่ทำงาน)");
            });

            modelBuilder.Entity<TDiscount>(entity =>
            {
                entity.HasKey(e => e.SDISCNTCODE)
                    .HasName("PK_TDISCOUNT");

                entity.HasComment("สิทธิส่วนลด\r\n   DBST06");

                entity.Property(e => e.SDISCNTCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสส่วนลด");

                entity.Property(e => e.CDISCNTSRVF).HasMaxLength(1);

                entity.Property(e => e.CDISCNTTYPE)
                    .HasMaxLength(1)
                    .HasComment("ประเภทส่วนลด");

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.NDISCNTBAHT).HasComment("บาท");

                entity.Property(e => e.NDISCNTPCEN).HasComment("หน่วย/%/เงิน/เศษ/อัตรา");

                entity.Property(e => e.NDISCNTUNIT).HasComment("หน่วย");

                entity.Property(e => e.PROMOBATH).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PROMOCAL).HasMaxLength(1);

                entity.Property(e => e.PROMOCODE).HasMaxLength(3);

                entity.Property(e => e.PROMOPCEN).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PROMORATIO).HasMaxLength(4);

                entity.Property(e => e.PROMOSRVF).HasMaxLength(2);

                entity.Property(e => e.PROMOUNIT).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SCOMMENT).HasMaxLength(200);

                entity.Property(e => e.SDISCNTMEAN)
                    .HasMaxLength(512)
                    .HasComment("รายละเอียด");

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");
            });

            modelBuilder.Entity<TDiscountDebt>(entity =>
            {
                entity.HasKey(e => e.sDistDebtID)
                    .HasName("PK_TDISCOUNTDEBT");

                entity.HasComment("ใบลดหนี้");

                entity.Property(e => e.sDistDebtID)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("เลขที่ใบลดหนี้");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");

                entity.Property(e => e.dDate)
                    .HasColumnType("datetime")
                    .HasComment("ลงวันที่");

                entity.Property(e => e.nAmount)
                    .HasColumnType("decimal(10, 2)")
                    .HasComment("จำนวนเงิน");

                entity.Property(e => e.sInvoiceNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("อ้างอิง ใบเสร็จรับเงิน/ใบกำกับภาษี");

                entity.Property(e => e.sReason)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasComment("เหตุผลลดหนี้*");

                entity.Property(e => e.sReqReference)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("อ้างอิงใบคำขอ ");
            });

            modelBuilder.Entity<TGoverment>(entity =>
            {
                entity.HasKey(e => e.SGOVCODE)
                    .HasName("PK_TGOVERMENT");

                entity.HasComment("หน่วยงาน\r\n   DBST38");

                entity.Property(e => e.SGOVCODE)
                    .HasMaxLength(4)
                    .HasComment("รหัสหน่วยงาน");

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SCOMMENT).HasMaxLength(200);

                entity.Property(e => e.SGOVNAMEE)
                    .HasMaxLength(40)
                    .HasComment("ชื่อหน่วยงานภาษาอังกฤษ");

                entity.Property(e => e.SGOVNAMET)
                    .HasMaxLength(40)
                    .HasComment("ชื่อหน่วยงานภาษาไทย");

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");
            });

            modelBuilder.Entity<TInvoice>(entity =>
            {
                entity.HasKey(e => new { e.SWWCODE, e.SCUSTCODE, e.SDOCTYPE, e.SDOCNO })
                    .HasName("PK_DBSM08");

                entity.HasComment("ใบแจ้งหนี้\r\n   DBSM08");

                entity.HasIndex(e => new { e.SCUSTCODE, e.sBillno }, "IX_DBSM08")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.SWWCODE, e.SCUSTCODE }, "IX_DBSM08_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.SREVYM, "IX_DBSM08_2")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.SCUSTCODE, "IX_DBSM08_3")
                    .HasFillFactor(90);

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.SCUSTCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสลูกค้า");

                entity.Property(e => e.SDOCTYPE)
                    .HasMaxLength(2)
                    .HasComment("ประเภทเอกสาร");

                entity.Property(e => e.SDOCNO)
                    .HasMaxLength(10)
                    .HasComment("รหัสเอกสาร");

                entity.Property(e => e.CCOLFLAG).HasMaxLength(1);

                entity.Property(e => e.CINVOICECNT).HasMaxLength(10);

                entity.Property(e => e.CUSGCALMTHD)
                    .HasMaxLength(1)
                    .HasComment("ประเภทการคำนวน");

                entity.Property(e => e.CWARNLTFLAG).HasMaxLength(1);

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DCOLDATE).HasColumnType("datetime");

                entity.Property(e => e.DDOCDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่เอกสาร");

                entity.Property(e => e.DLSTMTRRDDT)
                    .HasColumnType("datetime")
                    .HasComment("วันที่อ่านมาตรครั้งล่าสุด");

                entity.Property(e => e.DLSTWARNDT).HasColumnType("datetime");

                entity.Property(e => e.DPRSMTRRDDT)
                    .HasColumnType("datetime")
                    .HasComment("วันที่อ่านมาตร");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.DWARNLTDT).HasColumnType("datetime");

                entity.Property(e => e.NADJAMT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NBALAMT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NCOLAMT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NDEBT)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NDISCNTAMT)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("ส่วนลด");

                entity.Property(e => e.NDISCNTAMT_Diff).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NLSTCALMTHD)
                    .HasMaxLength(1)
                    .HasComment("ประเภทการคำนวนครั้งก่อน");

                entity.Property(e => e.NLSTMTRCNT).HasComment("เลขมาตรครั้งก่อน");

                entity.Property(e => e.NNETTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NNETTRFWT_Diff).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NNORTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NNORTRFWT_Diff).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NPAID)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NPRSMTRCNT).HasComment("เลขมาตรครั้งนี้");

                entity.Property(e => e.NPRSMTRCNT_Diff).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NPRSWTUSG).HasComment("หน่วยน้ำที่ใช้");

                entity.Property(e => e.NPRSWTUSG_Diff).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NSRVFEE).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NSRVFEE_Diff).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NTOTTRFWT)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("จำนวนเงินรวม");

                entity.Property(e => e.NTOTTRFWT_Diff).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NVAT)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("vat");

                entity.Property(e => e.NVAT_Diff).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PROMOAMT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PROMOBATH).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PROMOCAL).HasMaxLength(1);

                entity.Property(e => e.PROMOCODE).HasMaxLength(3);

                entity.Property(e => e.PROMOPCEN).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PROMORATIO).HasMaxLength(4);

                entity.Property(e => e.PROMOUNIT).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SREFDOCNO)
                    .HasMaxLength(10)
                    .HasComment("หมายเลขเอกสารอ้างอิง");

                entity.Property(e => e.SREFDOCTYPE)
                    .HasMaxLength(2)
                    .HasComment("ประเภทเอกสารอ้างอิง");

                entity.Property(e => e.SREVYM)
                    .HasMaxLength(4)
                    .HasComment("ปีเดือนเอกสาร");

                entity.Property(e => e.SREVYMBADDEPT)
                    .HasMaxLength(4)
                    .HasComment("ปีเดือนเอกสาร");

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");

                entity.Property(e => e.cAR).HasMaxLength(1);

                entity.Property(e => e.cApprov_Cancel).HasMaxLength(1);

                entity.Property(e => e.cApprov_Cancel2).HasMaxLength(1);

                entity.Property(e => e.dARDate).HasColumnType("datetime");

                entity.Property(e => e.dApprov_Cancel).HasColumnType("datetime");

                entity.Property(e => e.dApprov_Cancel2).HasColumnType("datetime");

                entity.Property(e => e.dCancel).HasColumnType("datetime");

                entity.Property(e => e.dCancelAdd).HasColumnType("datetime");

                entity.Property(e => e.dCustNo).HasColumnType("datetime");

                entity.Property(e => e.sAppComment).HasMaxLength(512);

                entity.Property(e => e.sAppComment2).HasMaxLength(512);

                entity.Property(e => e.sBillno).HasMaxLength(10);

                entity.Property(e => e.sCustNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("เลขใบตัดมาตร");

                entity.Property(e => e.sReasonCancel)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.sysdate).HasColumnType("datetime");

                entity.Property(e => e.systime).HasColumnType("datetime");

                entity.Property(e => e.timestemp)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.userid).HasMaxLength(4);
            });

            modelBuilder.Entity<TInvoiceDailyClose>(entity =>
            {
                entity.HasKey(e => new { e.dDailyClose, e.SWWCODE, e.SCUSTCODE, e.SDOCTYPE, e.SDOCNO })
                    .HasName("PK_DailyClose");

                entity.HasComment("ปิดงานประจำวัน");

                entity.Property(e => e.dDailyClose).HasColumnType("datetime");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.SCUSTCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสลูกค้า");

                entity.Property(e => e.SDOCTYPE)
                    .HasMaxLength(2)
                    .HasComment("ประเภทเอกสาร");

                entity.Property(e => e.SDOCNO)
                    .HasMaxLength(10)
                    .HasComment("รหัสเอกสาร");

                entity.Property(e => e.CUSGCALMTHD)
                    .HasMaxLength(1)
                    .HasComment("ประเภทการคำนวน");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DDOCDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่เอกสาร");

                entity.Property(e => e.DLSTMTRRDDT)
                    .HasColumnType("datetime")
                    .HasComment("วันที่อ่านมาตรครั้งล่าสุด");

                entity.Property(e => e.DPRSMTRRDDT)
                    .HasColumnType("datetime")
                    .HasComment("วันที่อ่านมาตร");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.NDEBT).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NDISCNTAMT)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("ส่วนลด");

                entity.Property(e => e.NLSTCALMTHD)
                    .HasMaxLength(1)
                    .HasComment("ประเภทการคำนวนครั้งก่อน");

                entity.Property(e => e.NLSTMTRCNT).HasComment("เลขมาตรครั้งก่อน");

                entity.Property(e => e.NNETTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NNORTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NPAID).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NPRSMTRCNT).HasComment("เลขมาตรครั้งนี้");

                entity.Property(e => e.NPRSWTUSG).HasComment("หน่วยน้ำที่ใช้");

                entity.Property(e => e.NSRVFEE).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NTOTTRFWT)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("จำนวนเงินรวม");

                entity.Property(e => e.NVAT)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("vat");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SREVYM)
                    .HasMaxLength(4)
                    .HasComment("ปีเดือนเอกสาร");

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");
            });

            modelBuilder.Entity<TInvoiceEdit>(entity =>
            {
                entity.HasKey(e => new { e.nRowID, e.SWWCODE });

                entity.Property(e => e.SWWCODE).HasMaxLength(7);

                entity.Property(e => e.DADD).HasColumnType("datetime");

                entity.Property(e => e.DUPDATE).HasColumnType("datetime");

                entity.Property(e => e.NDISCNTAMT_Diff).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NNETTRFWT_Diff).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NNORTRFWT_Diff).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NSRVFEE_Diff).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NTOTTRFWT_Diff).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NVAT_Diff).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PROMOAMT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.SDOCNO).HasMaxLength(50);

                entity.Property(e => e.SREVYM).HasMaxLength(4);

                entity.Property(e => e.cType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.dRequest).HasColumnType("datetime");

                entity.Property(e => e.sReason).HasMaxLength(500);
            });

            modelBuilder.Entity<TInvoiceHistory>(entity =>
            {
                entity.HasKey(e => new { e.SWWCODE, e.SCUSTCODE, e.SREVYM })
                    .HasName("PK_InvoiceHistory");

                entity.HasComment("ใบแจ้งหนี้ตกค้าง\r\n   DBSM33");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.SCUSTCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสลูกค้า");

                entity.Property(e => e.SREVYM)
                    .HasMaxLength(4)
                    .HasComment("ปีเดือนเอกสาร");

                entity.Property(e => e.NDEBT)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("ค้างจ่าย");

                entity.Property(e => e.NDEBTLAST)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("-");

                entity.Property(e => e.NDISCNTAMT)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("ส่วนลด");

                entity.Property(e => e.NDOC).HasComment("จำนวนใบแจ้งหนี้");

                entity.Property(e => e.NNETTRFWT)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("ยอดก่อน VAT");

                entity.Property(e => e.NNORTRFWT)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("ยอดปกติ");

                entity.Property(e => e.NPAID)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("จำนวนเงิน");

                entity.Property(e => e.NPRSWTUSG).HasComment("หน่วยน้ำที่ใช้");

                entity.Property(e => e.NSEQ)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("ลำดับ");

                entity.Property(e => e.NSRVFEE)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("ค่าบริการ");

                entity.Property(e => e.NTOTTRFWT)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("จำนวนเงินรวม");

                entity.Property(e => e.NVAT)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("vat");

                entity.Property(e => e.PROMOAMT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.SCUSTNAME)
                    .HasMaxLength(150)
                    .HasComment("ชื่อลูกค้า");

                entity.Property(e => e.SROUTE)
                    .HasMaxLength(6)
                    .HasComment("เส้นทาง");

                entity.Property(e => e.SUSETYPE)
                    .HasMaxLength(3)
                    .HasComment("ประเภขลูกค้า");
            });

            modelBuilder.Entity<TInvoiceMonthlyClose>(entity =>
            {
                entity.HasKey(e => new { e.dMonthlyClose, e.SWWCODE, e.SCUSTCODE, e.SDOCTYPE, e.SDOCNO })
                    .HasName("PK_MonthlyClose");

                entity.HasComment("ปิดงานประจำเดือน");

                entity.Property(e => e.dMonthlyClose).HasColumnType("datetime");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.SCUSTCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสลูกค้า");

                entity.Property(e => e.SDOCTYPE)
                    .HasMaxLength(2)
                    .HasComment("ประเภทเอกสาร");

                entity.Property(e => e.SDOCNO)
                    .HasMaxLength(10)
                    .HasComment("รหัสเอกสาร");

                entity.Property(e => e.CUSGCALMTHD)
                    .HasMaxLength(1)
                    .HasComment("ประเภทการคำนวน");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DDOCDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่เอกสาร");

                entity.Property(e => e.DLSTMTRRDDT)
                    .HasColumnType("datetime")
                    .HasComment("วันที่อ่านมาตรครั้งล่าสุด");

                entity.Property(e => e.DPRSMTRRDDT)
                    .HasColumnType("datetime")
                    .HasComment("วันที่อ่านมาตร");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.NDEBT).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NDISCNTAMT)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("ส่วนลด");

                entity.Property(e => e.NLSTCALMTHD)
                    .HasMaxLength(1)
                    .HasComment("ประเภทการคำนวนครั้งก่อน");

                entity.Property(e => e.NLSTMTRCNT).HasComment("เลขมาตรครั้งก่อน");

                entity.Property(e => e.NNETTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NNORTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NPAID).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NPRSMTRCNT).HasComment("เลขมาตรครั้งนี้");

                entity.Property(e => e.NPRSWTUSG).HasComment("หน่วยน้ำที่ใช้");

                entity.Property(e => e.NSRVFEE).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NTOTTRFWT)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("จำนวนเงินรวม");

                entity.Property(e => e.NVAT)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("vat");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SREVYM)
                    .HasMaxLength(4)
                    .HasComment("ปีเดือนเอกสาร");

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");
            });

            modelBuilder.Entity<TInvoiceReduce>(entity =>
            {
                entity.HasKey(e => new { e.SWWCODE, e.sReduceNo, e.cInvoiceType })
                    .HasName("PK_TInvoiceReduce_1");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("?????????");

                entity.Property(e => e.sReduceNo).HasMaxLength(20);

                entity.Property(e => e.cInvoiceType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("????????????");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("???????????");

                entity.Property(e => e.SADDBY).HasComment("?????????");

                entity.Property(e => e.SCUSTADDR).HasMaxLength(250);

                entity.Property(e => e.SCUSTCODE)
                    .HasMaxLength(7)
                    .HasComment("??????????");

                entity.Property(e => e.SCUSTNAME).HasMaxLength(250);

                entity.Property(e => e.SREVYM)
                    .HasMaxLength(4)
                    .HasComment("???????????????");

                entity.Property(e => e.SUPDATEBY).HasComment("????????");

                entity.Property(e => e.dReduceDoc)
                    .HasColumnType("datetime")
                    .HasComment("???????????????????");

                entity.Property(e => e.nPrice)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("?????????");

                entity.Property(e => e.nTotal)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("????????????????");

                entity.Property(e => e.nVat)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("VAT");

                entity.Property(e => e.sBranchCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.sCitizenID)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.sCopyDoc).HasMaxLength(20);

                entity.Property(e => e.sDetail).HasMaxLength(500);

                entity.Property(e => e.sReason).HasMaxLength(500);

                entity.Property(e => e.sReduceDocNo).HasMaxLength(20);

                entity.Property(e => e.sRefBILLNO).HasMaxLength(10);

                entity.Property(e => e.sRefOLDReqID).HasMaxLength(20);

                entity.Property(e => e.sRefReq_ServiceID).HasMaxLength(10);
            });

            modelBuilder.Entity<TInvoiceReduceWater>(entity =>
            {
                entity.HasKey(e => new { e.SWWCODE, e.sReduceNo })
                    .HasName("PK_TInvoiceReduce_2");

                entity.Property(e => e.SWWCODE).HasMaxLength(7);

                entity.Property(e => e.sReduceNo).HasMaxLength(20);

                entity.Property(e => e.DADD).HasColumnType("datetime");

                entity.Property(e => e.DUPDATE).HasColumnType("datetime");

                entity.Property(e => e.SCUSTCODE).HasMaxLength(7);

                entity.Property(e => e.SREVYM).HasMaxLength(4);

                entity.Property(e => e.dReduceDate).HasColumnType("datetime");

                entity.Property(e => e.dReduceDoc).HasColumnType("datetime");

                entity.Property(e => e.nPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.nPriceDiff).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.nPriceOld).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.nTotal).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.nVat).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.sReason).HasMaxLength(500);

                entity.Property(e => e.sRefBILLNO).HasMaxLength(10);

                entity.Property(e => e.sRefInvoiceNo).HasMaxLength(10);
            });

            modelBuilder.Entity<TInvoiceService>(entity =>
            {
                entity.HasKey(e => new { e.sInvoiceNo, e.SWWCODE })
                    .HasName("PK_TINVOICESERVICE");

                entity.HasComment("???????????????????");

                entity.Property(e => e.sInvoiceNo)
                    .HasMaxLength(20)
                    .HasComment("????????????????");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("?????????");

                entity.Property(e => e.CCOLFLAG)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("????????????");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("???????????");

                entity.Property(e => e.SADDBY).HasComment("?????????");

                entity.Property(e => e.SCUSTCODE)
                    .HasMaxLength(7)
                    .HasComment("??????????");

                entity.Property(e => e.SREVYM)
                    .HasMaxLength(4)
                    .HasComment("???????????????");

                entity.Property(e => e.SUPDATEBY).HasComment("????????");

                entity.Property(e => e.cApprov_Cancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.cApprov_Cancel2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.cInvoiceType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.cRegisType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("ประเภทแบบคำขอ 1=ติดตั้ง 2=วางท่อ 3=ใช้น้ำชั่วคราว 4=ขอเลขที่ใช้น้ำ");

                entity.Property(e => e.dApprov_Cancel).HasColumnType("datetime");

                entity.Property(e => e.dApprov_Cancel2).HasColumnType("datetime");

                entity.Property(e => e.dCancel).HasColumnType("datetime");

                entity.Property(e => e.dInvoice)
                    .HasColumnType("datetime")
                    .HasComment("???????????????????");

                entity.Property(e => e.nDiscount)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("??????");

                entity.Property(e => e.nNet)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("??????? VAT");

                entity.Property(e => e.nPrice)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("?????????");

                entity.Property(e => e.nTotal)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("????????????????");

                entity.Property(e => e.nVat)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("VAT");

                entity.Property(e => e.sAppComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.sAppComment2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.sCancelComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.sEastNote).HasMaxLength(500);

                entity.Property(e => e.sRegisID)
                    .HasMaxLength(10)
                    .HasComment("????");

                entity.Property(e => e.sReq_ServiceID).HasMaxLength(10);

                entity.Property(e => e.sServiceType).HasComment("???????????? ");

                entity.Property(e => e.sUUNote).HasMaxLength(500);

                entity.Property(e => e.sWTRStreamNo).HasMaxLength(20);
            });

            modelBuilder.Entity<TInvoice_Installment>(entity =>
            {
                entity.HasKey(e => new { e.SWWCODE, e.SCUSTCODE, e.SDOCNO, e.SREVYM })
                    .HasName("PK_TINVOICE_INSTALLMENT");

                entity.HasComment("ขอผ่อนผันชำระค่าใช้น้ำ");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.SCUSTCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสลูกค้า");

                entity.Property(e => e.SDOCNO)
                    .HasMaxLength(10)
                    .HasComment("รหัสเอกสาร");

                entity.Property(e => e.SREVYM)
                    .HasMaxLength(4)
                    .HasComment("ปีเดือนเอกสาร");

                entity.Property(e => e.cStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะ 1 = บันทึก 2= อนุมติ 0= ไม่อนุมัติ");

                entity.Property(e => e.dAdd)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.dApprove)
                    .HasColumnType("datetime")
                    .HasComment("วันที่อนุมัติ");

                entity.Property(e => e.dEnd)
                    .HasColumnType("datetime")
                    .HasComment("ครบกำหนดผ่อนชำระ");

                entity.Property(e => e.dStart)
                    .HasColumnType("datetime")
                    .HasComment("เริ่มผ่อนชำระวันที่");

                entity.Property(e => e.nPeriod).HasComment("จำนวนงวด");

                entity.Property(e => e.nPeriodPay)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("งวดละ");

                entity.Property(e => e.sAddBy).HasComment("ผู้บันทึก");

                entity.Property(e => e.sApproveBy).HasComment("ผู้อนุมัติ");

                entity.Property(e => e.sApproveComment)
                    .IsUnicode(false)
                    .HasComment("เหตุผลการไม่อนุมัติ");

                entity.Property(e => e.sFilename)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("แนบไฟล์ขอผ่อนผันฯ");

                entity.Property(e => e.sReason)
                    .IsUnicode(false)
                    .HasComment("สาเหตุการขอผ่อนชำระ");
            });

            modelBuilder.Entity<TInvoice_New>(entity =>
            {
                entity.HasKey(e => new { e.SWWCODE, e.SCUSTCODE, e.SDOCTYPE, e.SDOCNO })
                    .HasName("PK_Invoice_New");

                entity.HasComment("ใบแจ้งหนี้ออกใหม่");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.SCUSTCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสลูกค้า");

                entity.Property(e => e.SDOCTYPE)
                    .HasMaxLength(2)
                    .HasComment("ประเภทเอกสาร");

                entity.Property(e => e.SDOCNO)
                    .HasMaxLength(10)
                    .HasComment("รหัสเอกสาร");

                entity.Property(e => e.CINVOICECNT).HasMaxLength(10);

                entity.Property(e => e.CUSGCALMTHD)
                    .HasMaxLength(1)
                    .HasComment("ประเภทการคำนวน");

                entity.Property(e => e.CWARNLTFLAG).HasMaxLength(1);

                entity.Property(e => e.DDOCDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่เอกสาร");

                entity.Property(e => e.DLSTMTRRDDT)
                    .HasColumnType("datetime")
                    .HasComment("วันที่อ่านมาตรครั้งล่าสุด");

                entity.Property(e => e.DLSTWARNDT).HasColumnType("datetime");

                entity.Property(e => e.DPRSMTRRDDT)
                    .HasColumnType("datetime")
                    .HasComment("วันที่อ่านมาตร");

                entity.Property(e => e.DWARNLTDT).HasColumnType("datetime");

                entity.Property(e => e.NADJAMT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NBALAMT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NCOLAMT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NDEBT)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NDISCNTAMT)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("ส่วนลด");

                entity.Property(e => e.NLSTCALMTHD)
                    .HasMaxLength(1)
                    .HasComment("ประเภทการคำนวนครั้งก่อน");

                entity.Property(e => e.NLSTMTRCNT).HasComment("เลขมาตรครั้งก่อน");

                entity.Property(e => e.NNETTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NNORTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NPRSMTRCNT).HasComment("เลขมาตรครั้งนี้");

                entity.Property(e => e.NPRSWTUSG).HasComment("หน่วยน้ำที่ใช้");

                entity.Property(e => e.NSRVFEE).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NTOTTRFWT)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("จำนวนเงินรวม");

                entity.Property(e => e.NVAT)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("vat");

                entity.Property(e => e.PROMOAMT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PROMOBATH).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PROMOCAL).HasMaxLength(1);

                entity.Property(e => e.PROMOCODE).HasMaxLength(3);

                entity.Property(e => e.PROMOPCEN).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PROMORATIO).HasMaxLength(4);

                entity.Property(e => e.PROMOUNIT).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.SREVYM)
                    .HasMaxLength(4)
                    .HasComment("ปีเดือนเอกสาร");
            });

            modelBuilder.Entity<TLog_Email>(entity =>
            {
                entity.HasKey(e => e.nLogID);

                entity.Property(e => e.dSend).HasColumnType("datetime");

                entity.Property(e => e.sCC)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.sFrom)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.sPageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.sRefData)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.sTo)
                    .HasMaxLength(2500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TLog_LineOA>(entity =>
            {
                entity.HasKey(e => e.nID)
                    .HasName("PK_TLineOA");

                entity.Property(e => e.nID).ValueGeneratedNever();

                entity.Property(e => e.IsPass).HasComment("ส่งผ่าน true ส่งไม่สำเร็จ false");

                entity.Property(e => e.SWWCode)
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasComment("รหัส ประปา");

                entity.Property(e => e.dCreate).HasColumnType("datetime");

                entity.Property(e => e.sCreateBy).HasComment("ผู้ทำรายการ");

                entity.Property(e => e.sDetailJson).HasComment("Body Json ที่ทำการส่งข้อมูล");

                entity.Property(e => e.sErrorsMessage).HasComment("ErrorsMessage");

                entity.Property(e => e.sMessage)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasComment("Message JSON");

                entity.Property(e => e.sStackTrace).HasComment("sStackTrace");
            });

            modelBuilder.Entity<TLog_PaymentAPI>(entity =>
            {
                entity.HasKey(e => e.nID);

                entity.Property(e => e.dActionDate).HasColumnType("datetime");

                entity.Property(e => e.dPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.nFee).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.nPaid).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.nTotal).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.sCustcode).HasMaxLength(10);

                entity.Property(e => e.sDetailJson)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.sMessage).HasMaxLength(250);

                entity.Property(e => e.sPostType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.sResultCode).HasMaxLength(5);

                entity.Property(e => e.sStatus).HasMaxLength(20);

                entity.Property(e => e.sType)
                    .HasMaxLength(3)
                    .HasComment("IN,OUT");

                entity.Property(e => e.sWWCode).HasMaxLength(10);
            });

            modelBuilder.Entity<TLog_PrintReason_Services>(entity =>
            {
                entity.HasKey(e => e.nID);

                entity.Property(e => e.BILLNO).HasMaxLength(10);

                entity.Property(e => e.CUSTCODE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.dCreate).HasColumnType("datetime");

                entity.Property(e => e.sCustName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.sInvoiceID)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.sNote)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.sRegisID)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TLog_PrintReason_Water>(entity =>
            {
                entity.HasKey(e => e.nID);

                entity.Property(e => e.BILLNO).HasMaxLength(10);

                entity.Property(e => e.CUSTCODE).HasMaxLength(10);

                entity.Property(e => e.dCreate).HasColumnType("datetime");

                entity.Property(e => e.sCustName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.sNote)
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TLog_PrintReason_WaterStream>(entity =>
            {
                entity.HasKey(e => e.nID);

                entity.Property(e => e.BILLNO).HasMaxLength(10);

                entity.Property(e => e.dCreate).HasColumnType("datetime");

                entity.Property(e => e.sInvoiceID)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.sNote)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.sWTSNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TLog_Send_SMS>(entity =>
            {
                entity.HasKey(e => e.nID);

                entity.Property(e => e.dDueDate).HasColumnType("datetime");

                entity.Property(e => e.dSend).HasColumnType("datetime");

                entity.Property(e => e.sCustCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.sDocNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.sMessage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.sMobileSMS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.sNotification)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TM_Config>(entity =>
            {
                entity.HasKey(e => e.nID);

                entity.Property(e => e.nID).ValueGeneratedNever();

                entity.Property(e => e.nValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.sDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.sName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.sValue)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TM_Menu>(entity =>
            {
                entity.HasKey(e => e.nMenuID);

                entity.Property(e => e.nMenuID)
                    .ValueGeneratedNever()
                    .HasComment("รหัสเมนู");

                entity.Property(e => e.IsActive).HasComment("สถานะการใช้งาน (1 = ใช้งาน, 0 = ไม่ใช้งาน)");

                entity.Property(e => e.nHeadID).HasComment("รหัสเมนูหลัก");

                entity.Property(e => e.nLevel).HasComment("ลำดับเมนู");

                entity.Property(e => e.sIcon)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("ไอคอนเมนู");

                entity.Property(e => e.sLink)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("ลิงค์เมนู");

                entity.Property(e => e.sName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("ชื่อเมนู");
            });

            modelBuilder.Entity<TM_Option>(entity =>
            {
                entity.HasKey(e => e.nID)
                    .HasName("PK_TM_MasterMain");

                entity.Property(e => e.nID)
                    .ValueGeneratedNever()
                    .HasComment("รหัสหลัก");

                entity.Property(e => e.sDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("รายละเอียด");

                entity.Property(e => e.sName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("ชื่อ");
            });

            modelBuilder.Entity<TM_Option_Sub>(entity =>
            {
                entity.HasKey(e => new { e.nID, e.nSubID })
                    .HasName("PK_TM_MasterSub");

                entity.Property(e => e.nID).HasComment("รหัสหลัก");

                entity.Property(e => e.nSubID).HasComment("รหัสย่อย");

                entity.Property(e => e.IsActive).HasComment("สถานะ (1 = ใช้งาน, 0 = ไม่ใช้งาน)");

                entity.Property(e => e.nOrder)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("ลำดับ");

                entity.Property(e => e.sDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("รายละเอียด");

                entity.Property(e => e.sName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("ชื่อ");

                entity.Property(e => e.sSubID)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("รหัสย่อย");
            });

            modelBuilder.Entity<TM_Status_Service_New>(entity =>
            {
                entity.HasKey(e => e.cStatus)
                    .HasName("PK_TM_Step_New");

                entity.Property(e => e.cStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("รหัสสถานะดำเนินงาน");

                entity.Property(e => e.IsActive).HasComment("สถานะการใช้งาน (1 = ใช้, 0 ไม่ใช้)");

                entity.Property(e => e.IsPipe).HasComment("ประเภทคำขอวางท่อ (1 = ใช่, 0 ไม่ใช่)");

                entity.Property(e => e.nOrder).HasComment("ลำดับ");

                entity.Property(e => e.sDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("รายละเอียด");

                entity.Property(e => e.sName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("ชื่อสถานะดำเนินงาน");
            });

            modelBuilder.Entity<TM_Status_Service_Normal>(entity =>
            {
                entity.HasKey(e => e.cStatus)
                    .HasName("PK_TM_Status_Normal");

                entity.Property(e => e.cStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("รหัสสถานะดำเนินงาน");

                entity.Property(e => e.IsActive).HasComment("สถานะการใช้งาน (1 = ใช้, 0 ไม่ใช้)");

                entity.Property(e => e.nOrder).HasComment("ลำดับ");

                entity.Property(e => e.sDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("รายละเอียด");

                entity.Property(e => e.sName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("ชื่อสถานะดำเนินงาน");
            });

            modelBuilder.Entity<TM_Template_SMS>(entity =>
            {
                entity.HasKey(e => e.nID);

                entity.Property(e => e.nID)
                    .ValueGeneratedNever()
                    .HasComment("รหัสรายการ");

                entity.Property(e => e.sDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("รายละเอียด");

                entity.Property(e => e.sMessage)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("ข้อความ");
            });

            modelBuilder.Entity<TMenu>(entity =>
            {
                entity.HasKey(e => e.sUrl);

                entity.Property(e => e.sUrl).HasMaxLength(100);

                entity.Property(e => e.cType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.sGroup).HasMaxLength(50);
            });

            modelBuilder.Entity<TMenuGroup>(entity =>
            {
                entity.HasKey(e => e.nGroupID);

                entity.Property(e => e.nGroupID).ValueGeneratedNever();

                entity.Property(e => e.sGroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.sHead)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.sURL)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMeterSize>(entity =>
            {
                entity.HasKey(e => e.SMETERSIZE)
                    .HasName("PK_TMETERSIZE");

                entity.HasComment("ขนาดมาตร\r\n   DBST43");

                entity.Property(e => e.SMETERSIZE)
                    .HasMaxLength(2)
                    .HasComment("รหัสขนาดมิเตอร์");

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SCOMMENT).HasMaxLength(200);

                entity.Property(e => e.SMTRSZMEAN)
                    .HasMaxLength(256)
                    .HasComment("ขนาดมิเตอร์");

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");
            });

            modelBuilder.Entity<TMeterType>(entity =>
            {
                entity.HasKey(e => e.sMeterTypeID);

                entity.Property(e => e.sMeterTypeID).ValueGeneratedNever();

                entity.Property(e => e.sMeterTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMobileComplaints>(entity =>
            {
                entity.HasKey(e => e.sComplaintsID);

                entity.Property(e => e.cStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.dUpdate).HasColumnType("datetime");

                entity.Property(e => e.sCategoryID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.sCategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.sChannelID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.sChannelName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.sComplaintsNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.sCustAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.sCustAreaID)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.sCustAreaName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.sCustDistrictID)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.sCustDistrictName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.sCustEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.sCustName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.sCustProvinceID)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.sCustProvinceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.sCustTel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.sCustcode)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.sDMA)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.sDetail).HasMaxLength(500);

                entity.Property(e => e.sOrgAbbr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.sPostCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.sResult).HasMaxLength(500);
            });

            modelBuilder.Entity<TMobileNews>(entity =>
            {
                entity.HasKey(e => e.sNewsID);

                entity.Property(e => e.DMA).HasMaxLength(50);

                entity.Property(e => e.dNewsDate).HasColumnType("datetime");

                entity.Property(e => e.dUpdate).HasColumnType("datetime");

                entity.Property(e => e.sDetail).HasMaxLength(500);

                entity.Property(e => e.sImageURL).HasMaxLength(250);

                entity.Property(e => e.sLinkURL).HasMaxLength(250);

                entity.Property(e => e.sTopic).HasMaxLength(250);

                entity.Property(e => e.sVDOURL).HasMaxLength(250);
            });

            modelBuilder.Entity<TMobileRegis>(entity =>
            {
                entity.HasKey(e => e.sRegisID);

                entity.Property(e => e.sRegisID).ValueGeneratedNever();

                entity.Property(e => e.dAdd).HasColumnType("datetime");

                entity.Property(e => e.dUpdate).HasColumnType("datetime");

                entity.Property(e => e.sCitizenID)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.sEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.sFirstName).HasMaxLength(100);

                entity.Property(e => e.sLastName).HasMaxLength(100);

                entity.Property(e => e.sMobileNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.sToken).HasMaxLength(500);
            });

            modelBuilder.Entity<TMobile_Member>(entity =>
            {
                entity.HasKey(e => new { e.sRegisID, e.sWWCode, e.sCustcode });

                entity.Property(e => e.sWWCode)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.sCustcode)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.dAdd).HasColumnType("datetime");
            });

            modelBuilder.Entity<TMobile_News>(entity =>
            {
                entity.HasKey(e => e.sNewsID);

                entity.Property(e => e.DMA).HasMaxLength(50);

                entity.Property(e => e.dNewsDate).HasColumnType("datetime");

                entity.Property(e => e.dUpdate).HasColumnType("datetime");

                entity.Property(e => e.sAreaName).HasMaxLength(200);

                entity.Property(e => e.sSubTitle).HasMaxLength(500);

                entity.Property(e => e.sText).HasMaxLength(500);

                entity.Property(e => e.sType).HasMaxLength(50);

                entity.Property(e => e.sURL).HasMaxLength(250);
            });

            modelBuilder.Entity<TMobile_News_Log>(entity =>
            {
                entity.HasKey(e => e.sID);

                entity.Property(e => e.dDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TPaidARUU>(entity =>
            {
                entity.HasKey(e => new { e.NLOT, e.SDOCNO })
                    .HasName("PK_PAIDARUU");

                entity.Property(e => e.SDOCNO).HasMaxLength(10);

                entity.Property(e => e.DPAIDDATE).HasColumnType("datetime");

                entity.Property(e => e.NPAIDARUU).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TPlatform>(entity =>
            {
                entity.HasKey(e => new { e.nPlatformID, e.SWWCODE });

                entity.Property(e => e.SWWCODE).HasMaxLength(7);

                entity.Property(e => e.PaymentType).HasMaxLength(2);

                entity.Property(e => e.dAdd).HasColumnType("datetime");

                entity.Property(e => e.dUpdate).HasColumnType("datetime");

                entity.Property(e => e.sComment).HasMaxLength(200);

                entity.Property(e => e.sDateCulture)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.sDateFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.sPlatformName).HasMaxLength(100);

                entity.Property(e => e.sTimeFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPrintReason>(entity =>
            {
                entity.HasKey(e => e.nReasonID);

                entity.Property(e => e.IsCheckDetail).HasComment("1 = ต้องกรอกรายละเอียด , 0 = ไม่ต้องกรอกรายละเอียด");

                entity.Property(e => e.dCreate).HasColumnType("datetime");

                entity.Property(e => e.dUpdate).HasColumnType("datetime");

                entity.Property(e => e.sDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.sReasonName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TROUTE>(entity =>
            {
                entity.HasKey(e => new { e.SWWCODE, e.SROUTE });

                entity.HasComment("เส้นทางอ่านมาตร");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.SROUTE)
                    .HasMaxLength(6)
                    .HasComment("รหัสเส้นทาง");

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.CTYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SCOMMENT)
                    .HasMaxLength(200)
                    .HasComment("รายละเอียด");

                entity.Property(e => e.SDETAIL).HasMaxLength(200);

                entity.Property(e => e.SROUTEHEAD).HasMaxLength(6);

                entity.Property(e => e.SRUOTENAME)
                    .HasMaxLength(100)
                    .HasComment("ชื่อเส้นทาง");

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");
            });

            modelBuilder.Entity<TReadMeter>(entity =>
            {
                entity.HasKey(e => new { e.WWCODE, e.CUSTCODE, e.REVYM })
                    .HasName("PK_DBSM04");

                entity.HasComment("?????????????????\r\n   DBSM04");

                entity.HasIndex(e => new { e.REVYM, e.CalWtusg }, "IX_DBSM04")
                    .HasFillFactor(90);

                entity.Property(e => e.WWCODE)
                    .HasMaxLength(7)
                    .HasComment("?????????");

                entity.Property(e => e.CUSTCODE)
                    .HasMaxLength(7)
                    .HasComment("??????????");

                entity.Property(e => e.REVYM)
                    .HasMaxLength(4)
                    .HasComment("??????????????????");

                entity.Property(e => e.ASMMTRCNT).HasComment("=0");

                entity.Property(e => e.ASMUNT).HasComment("????????????????????");

                entity.Property(e => e.CALMTHD)
                    .HasMaxLength(1)
                    .HasComment("3=????");

                entity.Property(e => e.CANTMTR)
                    .HasMaxLength(100)
                    .HasComment("????????????????");

                entity.Property(e => e.CANTREAD)
                    .HasMaxLength(100)
                    .HasComment("???????????????????");

                entity.Property(e => e.CCONDITION)
                    .HasMaxLength(1)
                    .HasComment("???????? 1=???????? 2=??????????? 3= ???????????? PRSMTRSTAT");

                entity.Property(e => e.CHGTYPE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.CREADTYPE)
                    .HasMaxLength(1)
                    .HasComment("??????????? 1=??????????? 2=?????????????? PRSRDANS");

                entity.Property(e => e.CalWtusg)
                    .HasMaxLength(2)
                    .HasComment("???????????????????????");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("????????????");

                entity.Property(e => e.DMETERLAST)
                    .HasColumnType("datetime")
                    .HasComment("??????????????????????? LSTMTRRDDT");

                entity.Property(e => e.DREADMETER)
                    .HasColumnType("datetime")
                    .HasComment("?????????????? MTRRDDT");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("???????????");

                entity.Property(e => e.DateKeep).HasColumnType("datetime");

                entity.Property(e => e.MTRWALK)
                    .HasMaxLength(1)
                    .HasComment("1=?????????? 2=???????????");

                entity.Property(e => e.NMETERLAST).HasComment("???????????????? LSTMTRCNT");

                entity.Property(e => e.NMETERUSE).HasComment("??????????????????? PRSWTUSG");

                entity.Property(e => e.NREADMETER).HasComment("????????????????? NPRSMTRCNT");

                entity.Property(e => e.SADDBY).HasComment("?????????");

                entity.Property(e => e.SOL).HasMaxLength(2);

                entity.Property(e => e.SUPDATEBY).HasComment("????????");
            });

            modelBuilder.Entity<TRefundUU>(entity =>
            {
                entity.HasKey(e => e.nID);

                entity.Property(e => e.dAdd)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.dPaidDate).HasColumnType("date");

                entity.Property(e => e.dUpdate)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.nTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.nTotalPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.sAddBy).HasComment("ผู้บันทึก");

                entity.Property(e => e.sCustAddr)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.sCustCode)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.sCustName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.sNote)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.sReason)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.sUpdateBy).HasComment("ผู้แก้ไข");
            });

            modelBuilder.Entity<TRefundUU_Item>(entity =>
            {
                entity.HasKey(e => new { e.nID, e.dDate, e.nItem });

                entity.Property(e => e.dDate).HasColumnType("date");

                entity.Property(e => e.nPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TReq_Service>(entity =>
            {
                entity.HasKey(e => new { e.sReq_ServiceID, e.SWWCODE })
                    .HasName("PK_TREQ_SERVICE");

                entity.HasComment("??????????????????????");

                entity.Property(e => e.sReq_ServiceID).HasMaxLength(10);

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("?????????");

                entity.Property(e => e.CAREAID).HasMaxLength(1);

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("????????????");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("???????????");

                entity.Property(e => e.SADDBY).HasComment("?????????");

                entity.Property(e => e.SCUSTCODE)
                    .HasMaxLength(7)
                    .HasComment("??????????");

                entity.Property(e => e.SDOCNO).HasMaxLength(10);

                entity.Property(e => e.SUPDATEBY).HasComment("????????");

                entity.Property(e => e.cPayType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.cRequestType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.cStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("1=???????? 2=????????? 3=???????????? 0=??????");

                entity.Property(e => e.dAns21)
                    .HasColumnType("datetime")
                    .HasComment("??????????????");

                entity.Property(e => e.dAns22)
                    .HasColumnType("datetime")
                    .HasComment("????????????");

                entity.Property(e => e.dCancel)
                    .HasColumnType("datetime")
                    .HasComment("????????????");

                entity.Property(e => e.dClose)
                    .HasColumnType("datetime")
                    .HasComment("????????????");

                entity.Property(e => e.dCutMTRUSE).HasColumnType("datetime");

                entity.Property(e => e.dRequest)
                    .HasColumnType("datetime")
                    .HasComment("???????????????");

                entity.Property(e => e.dSendDate)
                    .HasColumnType("datetime")
                    .HasComment("?????????????????????");

                entity.Property(e => e.dServiceDate).HasColumnType("datetime");

                entity.Property(e => e.dStopMTRUSE).HasColumnType("datetime");

                entity.Property(e => e.dUpdateQuaBy)
                    .HasColumnType("datetime")
                    .HasComment("??????????????????????");

                entity.Property(e => e.nCost_Estimate)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("????????????????");

                entity.Property(e => e.nInsurance).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.sAns1)
                    .HasMaxLength(512)
                    .HasComment("?????????????????");

                entity.Property(e => e.sAns101)
                    .HasMaxLength(200)
                    .HasComment("??????????");

                entity.Property(e => e.sAns102)
                    .HasMaxLength(100)
                    .HasComment("????");

                entity.Property(e => e.sAns103)
                    .HasMaxLength(100)
                    .HasComment("???");

                entity.Property(e => e.sAns104)
                    .HasMaxLength(6)
                    .HasComment("????");

                entity.Property(e => e.sAns105)
                    .HasMaxLength(6)
                    .HasComment("?????");

                entity.Property(e => e.sAns106)
                    .HasMaxLength(6)
                    .HasComment("???????");

                entity.Property(e => e.sAns10Village).HasMaxLength(100);

                entity.Property(e => e.sAns111)
                    .HasMaxLength(4)
                    .HasComment("???????????");

                entity.Property(e => e.sAns112)
                    .HasMaxLength(20)
                    .HasComment("???????????");

                entity.Property(e => e.sAns113)
                    .HasMaxLength(100)
                    .HasComment("?????????");

                entity.Property(e => e.sAns114)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("???????????");

                entity.Property(e => e.sAns12)
                    .HasMaxLength(3)
                    .HasComment("??????????????????????");

                entity.Property(e => e.sAns121).HasMaxLength(500);

                entity.Property(e => e.sAns13)
                    .HasMaxLength(512)
                    .HasComment("????? ");

                entity.Property(e => e.sAns141).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.sAns142).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.sAns151).HasMaxLength(60);

                entity.Property(e => e.sAns152).HasMaxLength(60);

                entity.Property(e => e.sAns153).HasMaxLength(60);

                entity.Property(e => e.sAns154).HasMaxLength(60);

                entity.Property(e => e.sAns155).HasMaxLength(60);

                entity.Property(e => e.sAns156).HasColumnType("datetime");

                entity.Property(e => e.sAns161).HasMaxLength(100);

                entity.Property(e => e.sAns171).HasMaxLength(512);

                entity.Property(e => e.sAns181).HasMaxLength(3);

                entity.Property(e => e.sAns19DOCNO).HasMaxLength(10);

                entity.Property(e => e.sAns20Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.sAns20Custstat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.sAns23)
                    .HasMaxLength(10)
                    .HasComment("????????");

                entity.Property(e => e.sAns3)
                    .HasMaxLength(512)
                    .HasComment("???????????????/???????????????");

                entity.Property(e => e.sAns41)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("???????????????");

                entity.Property(e => e.sAns42)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("?????????????????????");

                entity.Property(e => e.sAns51)
                    .HasMaxLength(2)
                    .HasComment("????????");

                entity.Property(e => e.sAns52)
                    .HasMaxLength(2)
                    .HasComment("??????");

                entity.Property(e => e.sAns53)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("???????????????");

                entity.Property(e => e.sAns54)
                    .HasMaxLength(20)
                    .HasComment("???????????");

                entity.Property(e => e.sAns55).HasComment("????????");

                entity.Property(e => e.sAns56)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("???????????");

                entity.Property(e => e.sAns5MeterStat).HasMaxLength(1);

                entity.Property(e => e.sAns6)
                    .HasMaxLength(512)
                    .HasComment("???????????????? ");

                entity.Property(e => e.sAns7)
                    .HasMaxLength(512)
                    .HasComment("????????????? ");

                entity.Property(e => e.sAns8)
                    .HasMaxLength(7)
                    .HasComment("????????????");

                entity.Property(e => e.sAns91)
                    .HasMaxLength(200)
                    .HasComment("???-???????");

                entity.Property(e => e.sAns910).HasMaxLength(50);

                entity.Property(e => e.sAns92)
                    .HasMaxLength(13)
                    .HasComment("?????????????????");

                entity.Property(e => e.sAns93)
                    .HasColumnType("datetime")
                    .HasComment("?????????? ");

                entity.Property(e => e.sAns94)
                    .HasColumnType("datetime")
                    .HasComment("???????");

                entity.Property(e => e.sAns95)
                    .HasMaxLength(60)
                    .HasComment("???????? (????)");

                entity.Property(e => e.sAns96)
                    .HasMaxLength(60)
                    .HasComment("???????? (????????? SMS)");

                entity.Property(e => e.sAns97)
                    .HasMaxLength(60)
                    .HasComment("???????? (??????????????)");

                entity.Property(e => e.sAns98)
                    .HasMaxLength(200)
                    .HasComment("?????");

                entity.Property(e => e.sAns99).HasMaxLength(4);

                entity.Property(e => e.sAns9USERTYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.sCancelBy).HasComment("?????????");

                entity.Property(e => e.sCancelDetail)
                    .HasMaxLength(200)
                    .HasComment("???????????????");

                entity.Property(e => e.sCloseBy).HasComment("?????????");

                entity.Property(e => e.sFileClose)
                    .HasMaxLength(100)
                    .HasComment("???????????????????????????");

                entity.Property(e => e.sFileCloseOther)
                    .HasMaxLength(100)
                    .HasComment("?????????????????????");

                entity.Property(e => e.sFileQuaOther)
                    .HasMaxLength(100)
                    .HasComment("???????????????");

                entity.Property(e => e.sFileQuatation)
                    .HasMaxLength(100)
                    .HasComment("?????????????");

                entity.Property(e => e.sFilename)
                    .HasMaxLength(100)
                    .HasComment("??????????????");

                entity.Property(e => e.sQuatationNo)
                    .HasMaxLength(10)
                    .HasComment("????????????????");

                entity.Property(e => e.sRecieveBy).HasComment("??????????");

                entity.Property(e => e.sRegisID).HasMaxLength(10);

                entity.Property(e => e.sServiceOther)
                    .HasMaxLength(200)
                    .HasComment("13. ????? ");

                entity.Property(e => e.sServiceType).HasComment("????????????");

                entity.Property(e => e.sUpdateQuaBy).HasComment("???????????????????");
            });

            modelBuilder.Entity<TReq_ServiceHis>(entity =>
            {
                entity.HasKey(e => new { e.nItem, e.sReq_ServiceID })
                    .HasName("PK_TREQ_SERVICEHIS");

                entity.Property(e => e.sReq_ServiceID).HasMaxLength(10);

                entity.Property(e => e.CCUSTSTART_new).HasMaxLength(2);

                entity.Property(e => e.CCUSTSTART_old).HasMaxLength(2);

                entity.Property(e => e.DUPDATE).HasColumnType("datetime");

                entity.Property(e => e.SCUSTCODE).HasMaxLength(7);

                entity.Property(e => e.SWWCODE).HasMaxLength(7);

                entity.Property(e => e.dAns21).HasColumnType("datetime");

                entity.Property(e => e.dAns21_old).HasColumnType("datetime");

                entity.Property(e => e.dAns22).HasColumnType("datetime");

                entity.Property(e => e.dAns22_old).HasColumnType("datetime");

                entity.Property(e => e.sAns1).HasMaxLength(512);

                entity.Property(e => e.sAns101).HasMaxLength(255);

                entity.Property(e => e.sAns101_old).HasMaxLength(255);

                entity.Property(e => e.sAns102).HasMaxLength(100);

                entity.Property(e => e.sAns102_old).HasMaxLength(100);

                entity.Property(e => e.sAns103).HasMaxLength(100);

                entity.Property(e => e.sAns103_old).HasMaxLength(100);

                entity.Property(e => e.sAns104).HasMaxLength(6);

                entity.Property(e => e.sAns104_old).HasMaxLength(6);

                entity.Property(e => e.sAns105).HasMaxLength(6);

                entity.Property(e => e.sAns105_old).HasMaxLength(6);

                entity.Property(e => e.sAns106).HasMaxLength(6);

                entity.Property(e => e.sAns106_old).HasMaxLength(6);

                entity.Property(e => e.sAns10Village).HasMaxLength(100);

                entity.Property(e => e.sAns10Village_old).HasMaxLength(100);

                entity.Property(e => e.sAns111).HasMaxLength(4);

                entity.Property(e => e.sAns111_old).HasMaxLength(4);

                entity.Property(e => e.sAns112).HasMaxLength(20);

                entity.Property(e => e.sAns112_old).HasMaxLength(20);

                entity.Property(e => e.sAns113).HasMaxLength(100);

                entity.Property(e => e.sAns113_old).HasMaxLength(100);

                entity.Property(e => e.sAns114)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.sAns114_old)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.sAns12).HasMaxLength(3);

                entity.Property(e => e.sAns12_old).HasMaxLength(3);

                entity.Property(e => e.sAns13).HasMaxLength(512);

                entity.Property(e => e.sAns13_old).HasMaxLength(512);

                entity.Property(e => e.sAns141).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.sAns141_old).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.sAns142).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.sAns142_old).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.sAns151).HasMaxLength(60);

                entity.Property(e => e.sAns151_old).HasMaxLength(60);

                entity.Property(e => e.sAns152).HasMaxLength(60);

                entity.Property(e => e.sAns152_old).HasMaxLength(60);

                entity.Property(e => e.sAns153).HasMaxLength(60);

                entity.Property(e => e.sAns153_old).HasMaxLength(60);

                entity.Property(e => e.sAns154).HasMaxLength(60);

                entity.Property(e => e.sAns154_old).HasMaxLength(60);

                entity.Property(e => e.sAns155).HasMaxLength(60);

                entity.Property(e => e.sAns155_old).HasMaxLength(60);

                entity.Property(e => e.sAns156).HasColumnType("datetime");

                entity.Property(e => e.sAns156_old).HasColumnType("datetime");

                entity.Property(e => e.sAns161).HasMaxLength(100);

                entity.Property(e => e.sAns161_old).HasMaxLength(100);

                entity.Property(e => e.sAns181).HasMaxLength(3);

                entity.Property(e => e.sAns181_old).HasMaxLength(3);

                entity.Property(e => e.sAns1_old).HasMaxLength(512);

                entity.Property(e => e.sAns23).HasMaxLength(10);

                entity.Property(e => e.sAns23_old).HasMaxLength(10);

                entity.Property(e => e.sAns3).HasMaxLength(512);

                entity.Property(e => e.sAns3_old).HasMaxLength(512);

                entity.Property(e => e.sAns41).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.sAns41_old).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.sAns42).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.sAns42_old).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.sAns51).HasMaxLength(2);

                entity.Property(e => e.sAns51_old).HasMaxLength(2);

                entity.Property(e => e.sAns52).HasMaxLength(2);

                entity.Property(e => e.sAns52_old).HasMaxLength(2);

                entity.Property(e => e.sAns53).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.sAns53_old).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.sAns54).HasMaxLength(20);

                entity.Property(e => e.sAns54_old).HasMaxLength(20);

                entity.Property(e => e.sAns56).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.sAns56_old).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.sAns6).HasMaxLength(512);

                entity.Property(e => e.sAns6_old).HasMaxLength(512);

                entity.Property(e => e.sAns7).HasMaxLength(512);

                entity.Property(e => e.sAns7_old).HasMaxLength(512);

                entity.Property(e => e.sAns8).HasMaxLength(1);

                entity.Property(e => e.sAns8_old).HasMaxLength(7);

                entity.Property(e => e.sAns91).HasMaxLength(200);

                entity.Property(e => e.sAns910).HasMaxLength(50);

                entity.Property(e => e.sAns910_old).HasMaxLength(50);

                entity.Property(e => e.sAns91_old).HasMaxLength(200);

                entity.Property(e => e.sAns92).HasMaxLength(13);

                entity.Property(e => e.sAns92_old).HasMaxLength(13);

                entity.Property(e => e.sAns93).HasColumnType("datetime");

                entity.Property(e => e.sAns93_old).HasColumnType("datetime");

                entity.Property(e => e.sAns94).HasColumnType("datetime");

                entity.Property(e => e.sAns94_old).HasColumnType("datetime");

                entity.Property(e => e.sAns95).HasMaxLength(60);

                entity.Property(e => e.sAns95_old).HasMaxLength(60);

                entity.Property(e => e.sAns96).HasMaxLength(60);

                entity.Property(e => e.sAns96_old).HasMaxLength(60);

                entity.Property(e => e.sAns97).HasMaxLength(60);

                entity.Property(e => e.sAns97_old).HasMaxLength(60);

                entity.Property(e => e.sAns98).HasMaxLength(200);

                entity.Property(e => e.sAns98_old).HasMaxLength(200);

                entity.Property(e => e.sAns99).HasMaxLength(4);

                entity.Property(e => e.sAns99_old).HasMaxLength(4);

                entity.Property(e => e.sAns9USERTYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.sAns9USERTYPE_old)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TRunDocNo>(entity =>
            {
                entity.HasKey(e => new { e.WWCODE, e.SDOCTYPE })
                    .HasName("PK_TRUNDOCNO");

                entity.HasComment("รหัสเอกสาร ล่าสุดSDOCTYPE 03=TCustomer_Regis |04=TReq_Service |05=QuatationNo |06=TinvoceServoce |07=RecieptService|01=TInvoice|02=Reciept");

                entity.Property(e => e.WWCODE).HasMaxLength(7);

                entity.Property(e => e.SDOCTYPE)
                    .HasMaxLength(2)
                    .HasComment("ประเภทเอกสาร");

                entity.Property(e => e.DUPDATE).HasColumnType("datetime");

                entity.Property(e => e.NLASTDOCNO)
                    .HasColumnType("numeric(10, 0)")
                    .HasComment("รหัสรันสุดท้าย");

                entity.Property(e => e.NLENGTHDOC).HasComment("ความกว้างรหัส *ถ้าไม่ครบเติม 0 ทางซ้าย");

                entity.Property(e => e.SDetail)
                    .HasMaxLength(100)
                    .HasComment("ชื่อประเภทเอกสาร");
            });

            modelBuilder.Entity<TServiceCharge>(entity =>
            {
                entity.HasKey(e => new { e.SWWCODE, e.SMETERSIZE })
                    .HasName("PK_TSERVICECHARGE");

                entity.HasComment("ค่าบริการ\r\n   DBST42");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.SMETERSIZE)
                    .HasMaxLength(2)
                    .HasComment("รหัสขนาดมิเตอร์");

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.NSRVFEE).HasComment("ค่าบริการ");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SCOMMENT).HasMaxLength(200);

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");

                entity.HasOne(d => d.SMETERSIZENavigation)
                    .WithMany(p => p.TServiceCharge)
                    .HasForeignKey(d => d.SMETERSIZE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TSERVICE_REFERENCE_TMETERSI");

                entity.HasOne(d => d.SWWCODENavigation)
                    .WithMany(p => p.TServiceCharge)
                    .HasForeignKey(d => d.SWWCODE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TSERVICE_REFERENCE_TWATERSU");
            });

            modelBuilder.Entity<TService_Type>(entity =>
            {
                entity.HasKey(e => new { e.sServiceType, e.cInternalService });

                entity.HasComment("????????????????????");

                entity.Property(e => e.sServiceType).HasComment("??????????");

                entity.Property(e => e.cInternalService)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("0=??????????????? 1=????????????");

                entity.Property(e => e.cOther)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("?????????? ?");

                entity.Property(e => e.nOrder).HasComment("????????????");

                entity.Property(e => e.sServiceName)
                    .HasMaxLength(200)
                    .HasComment("??????????");
            });

            modelBuilder.Entity<TSystem_LogError>(entity =>
            {
                entity.HasKey(e => e.nLogID);

                entity.Property(e => e.dLog).HasColumnType("datetime");

                entity.Property(e => e.sInnerException).HasColumnType("text");

                entity.Property(e => e.sMessage).HasColumnType("text");

                entity.Property(e => e.sRefID1).HasMaxLength(250);

                entity.Property(e => e.sRefID2).HasMaxLength(250);

                entity.Property(e => e.sRefID3).HasMaxLength(250);

                entity.Property(e => e.sSource).HasColumnType("text");

                entity.Property(e => e.sStackTrace).HasColumnType("text");
            });

            modelBuilder.Entity<TTumbon>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.sTumbon_name).HasMaxLength(60);

                entity.Property(e => e.sampherID).HasMaxLength(4);

                entity.Property(e => e.sprovID).HasMaxLength(2);

                entity.Property(e => e.stombonID).HasMaxLength(8);
            });

            modelBuilder.Entity<TUseLog>(entity =>
            {
                entity.HasKey(e => new { e.nLogID, e.SWWCODE })
                    .HasName("PK_USELOG");

                entity.Property(e => e.nLogID).ValueGeneratedOnAdd();

                entity.Property(e => e.SWWCODE).HasMaxLength(7);

                entity.Property(e => e.dLogDate).HasColumnType("datetime");

                entity.Property(e => e.sAction)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.sDetail)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.sUrl).HasMaxLength(100);
            });

            modelBuilder.Entity<TUser>(entity =>
            {
                entity.HasKey(e => new { e.SUSERID, e.SUSERNAME, e.SWWCODE })
                    .HasName("PK_PWD");

                entity.HasComment("ผู้ใช้งานระบบ\r\n   PWD");

                entity.Property(e => e.SUSERNAME).HasMaxLength(50);

                entity.Property(e => e.SWWCODE).HasMaxLength(7);

                entity.Property(e => e.CEmpType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะ 1=Active 0=Not Active");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DLASTUPDATE).HasColumnType("datetime");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SADDR).HasColumnType("text");

                entity.Property(e => e.SCOMMENT)
                    .HasMaxLength(200)
                    .HasComment("หมายเหตุยกเลิก");

                entity.Property(e => e.SEMAIL).HasMaxLength(200);

                entity.Property(e => e.SNAME).HasMaxLength(50);

                entity.Property(e => e.SPASSWORD).HasMaxLength(500);

                entity.Property(e => e.SPOSITION).HasMaxLength(200);

                entity.Property(e => e.STEL).HasMaxLength(20);

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");

                entity.Property(e => e.sFileLicense)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TUser_Permission>(entity =>
            {
                entity.HasKey(e => new { e.SUSERID, e.nMenuID });
            });

            modelBuilder.Entity<TWaterStream>(entity =>
            {
                entity.HasKey(e => new { e.sWTRStreamNo, e.SWWCODE })
                    .HasName("PK_TWATERSTREAM");

                entity.HasComment("น้ำท่อธาร");

                entity.Property(e => e.sWTRStreamNo)
                    .HasMaxLength(20)
                    .HasComment("เลขที่ใบแจ้งหนี้");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SCUSTADDR).HasMaxLength(500);

                entity.Property(e => e.SCUSTNAME)
                    .HasMaxLength(100)
                    .HasComment("รหัสลูกค้า");

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");

                entity.Property(e => e.dRequest).HasColumnType("datetime");

                entity.Property(e => e.sAmphur).HasMaxLength(4);

                entity.Property(e => e.sBranchCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.sCitizenID)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.sMoo).HasMaxLength(50);

                entity.Property(e => e.sNo)
                    .HasMaxLength(20)
                    .HasComment("วันที่ออกใบแจ้งหนี้");

                entity.Property(e => e.sProv).HasMaxLength(2);

                entity.Property(e => e.sRoad).HasMaxLength(50);

                entity.Property(e => e.sTumbon)
                    .HasMaxLength(6)
                    .HasComment("ประเภทบริการ ");
            });

            modelBuilder.Entity<TWaterSupply>(entity =>
            {
                entity.HasKey(e => e.SWWCODE)
                    .HasName("PK_CONSTANTS");

                entity.HasComment("ประปา");

                entity.Property(e => e.SWWCODE)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.Addresscompany)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.Company)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('-')")
                    .HasComment("ชื่อบริษัท UU ");

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DATAD07).HasMaxLength(6);

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.Numbercompany)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('-')")
                    .HasComment("เลขประจำตัวผู้เสียภาษี UU");

                entity.Property(e => e.REVYM).HasMaxLength(4);

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SCOMMENT)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");

                entity.Property(e => e.SWWADDRT)
                    .HasMaxLength(65)
                    .HasComment("ที่อยู่สำนักงาน ");

                entity.Property(e => e.SWWCODEH)
                    .HasMaxLength(7)
                    .HasComment("รหัสประปา");

                entity.Property(e => e.SWWCODEH2).HasMaxLength(7);

                entity.Property(e => e.SWWNAMET)
                    .HasMaxLength(65)
                    .HasComment("ชื่อภาษาไทย");

                entity.Property(e => e.WwTel).HasMaxLength(50);

                entity.Property(e => e.addressew).HasMaxLength(120);

                entity.Property(e => e.companyew).HasMaxLength(200);

                entity.Property(e => e.nLat).HasColumnType("numeric(12, 8)");

                entity.Property(e => e.nLong).HasColumnType("numeric(12, 8)");

                entity.Property(e => e.numberew).HasMaxLength(50);

                entity.Property(e => e.sAction_FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.sAction_Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.sApprove_FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.sApprove_Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.sInspector_FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.sInspector_Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.sLine_Url).HasColumnType("text");

                entity.Property(e => e.sMainType2_UseType)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.sManager_FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.sManager_Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.sPosition_FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.sPosition_Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.sSupervisor_FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.sSupervisor_Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.sTechnician_FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.sTechnician_Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TWaterUseType>(entity =>
            {
                entity.HasKey(e => e.SUSETYPE)
                    .HasName("PK_TWATERUSETYPE");

                entity.HasComment("ประเภทผู้ใช้น้ำ\r\n   DBST39");

                entity.Property(e => e.SUSETYPE)
                    .HasMaxLength(3)
                    .HasComment("รหัสประเภท");

                entity.Property(e => e.CGOVNFLAG)
                    .HasMaxLength(1)
                    .HasComment("-");

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("สถานะ 1=ใช้งาน 0=ยกเลิก");

                entity.Property(e => e.CUSERTYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DADD)
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.DUPDATE)
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไข");

                entity.Property(e => e.SADDBY).HasComment("ผู้บันทึก");

                entity.Property(e => e.SCOMMENT).HasMaxLength(200);

                entity.Property(e => e.SUPDATEBY).HasComment("ผู้แก้ไข");

                entity.Property(e => e.SUSEMEAN)
                    .HasMaxLength(90)
                    .HasComment("ชื่อประเภท");
            });

            modelBuilder.Entity<TWaterUseTypeGroup>(entity =>
            {
                entity.HasKey(e => new { e.SUSETYPEGROUP, e.SUSETYPE })
                    .HasName("PK_TWATERUSETYPEGROUP");

                entity.Property(e => e.SUSETYPEGROUP).HasMaxLength(3);

                entity.Property(e => e.SUSETYPE).HasMaxLength(3);

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CUSERTYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SUSEGroupMEAN).HasMaxLength(90);
            });

            modelBuilder.Entity<TransferHistory>(entity =>
            {
                entity.HasKey(e => e.nRowID);

                entity.Property(e => e.SWWCODE).HasMaxLength(7);

                entity.Property(e => e.dTransfer).HasColumnType("datetime");

                entity.Property(e => e.sTableName).HasMaxLength(20);
            });

            modelBuilder.Entity<TypePayment>(entity =>
            {
                entity.HasKey(e => e.PaymentType);

                entity.Property(e => e.PaymentType).HasMaxLength(2);

                entity.Property(e => e.CSTATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DADD).HasColumnType("datetime");

                entity.Property(e => e.DUPDATE).HasColumnType("datetime");

                entity.Property(e => e.PaymentTypeDesc)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SCOMMENT).HasMaxLength(200);
            });

            modelBuilder.Entity<View_1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_1");

                entity.Property(e => e.CCOLFLAG).HasMaxLength(1);

                entity.Property(e => e.NDEBT).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NTOTTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.SCUSTCODE).HasMaxLength(7);

                entity.Property(e => e.SCUSTNAME).HasMaxLength(200);

                entity.Property(e => e.SDOCNO).HasMaxLength(10);

                entity.Property(e => e.SREVYM).HasMaxLength(4);

                entity.Property(e => e.SUSETYPE).HasMaxLength(3);

                entity.Property(e => e.SWWCODE).HasMaxLength(7);
            });

            modelBuilder.Entity<vCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCustomer");

                entity.Property(e => e.CCUSTSTAT).HasMaxLength(1);

                entity.Property(e => e.SCUSTADDR).HasMaxLength(255);

                entity.Property(e => e.SCUSTCODE).HasMaxLength(7);

                entity.Property(e => e.SCUSTNAME).HasMaxLength(200);

                entity.Property(e => e.SUSETYPE).HasMaxLength(3);

                entity.Property(e => e.SWWCODE).HasMaxLength(7);

                entity.Property(e => e.Status)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.cBankType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<vExternalServiceWork>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vExternalServiceWork");

                entity.Property(e => e.DUPDATE).HasColumnType("datetime");

                entity.Property(e => e.SCUSTNAME).HasMaxLength(200);

                entity.Property(e => e.cStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.dRequest).HasColumnType("datetime");

                entity.Property(e => e.sName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.sReq_ServiceID).HasMaxLength(10);
            });

            modelBuilder.Entity<vExternalServiceWork_Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vExternalServiceWork_Detail");

                entity.Property(e => e.DUPDATE).HasColumnType("datetime");

                entity.Property(e => e.SREVYM).HasMaxLength(4);

                entity.Property(e => e.cPayType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.cStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.dCancel).HasColumnType("datetime");

                entity.Property(e => e.dInvoice).HasColumnType("datetime");

                entity.Property(e => e.dRequest).HasColumnType("datetime");

                entity.Property(e => e.nDiscount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.nPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.nTotal).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.nVat).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.sAns10Village).HasMaxLength(100);

                entity.Property(e => e.sAns91).HasMaxLength(200);

                entity.Property(e => e.sAns95).HasMaxLength(60);

                entity.Property(e => e.sAns96).HasMaxLength(60);

                entity.Property(e => e.sCancelDetail).HasMaxLength(200);

                entity.Property(e => e.sName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.sReq_ServiceID).HasMaxLength(10);

                entity.Property(e => e.sServiceOther).HasMaxLength(200);
            });

            modelBuilder.Entity<vInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vInvoice");

                entity.Property(e => e.CCUSTSTAT).HasMaxLength(1);

                entity.Property(e => e.DDOCDATE).HasColumnType("datetime");

                entity.Property(e => e.NNETTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NNORTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NSRVFEE).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NVAT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.SCUSTCODE).HasMaxLength(7);

                entity.Property(e => e.SDOCNO).HasMaxLength(10);

                entity.Property(e => e.SREVYM).HasMaxLength(4);

                entity.Property(e => e.SWWCODE).HasMaxLength(7);

                entity.Property(e => e.sBillno).HasMaxLength(10);
            });

            modelBuilder.Entity<vInvoiceReduce_Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vInvoiceReduce_Detail");

                entity.Property(e => e.SCUSTADDR).HasMaxLength(250);

                entity.Property(e => e.SCUSTCODE).HasMaxLength(7);

                entity.Property(e => e.SCUSTNAME).HasMaxLength(250);

                entity.Property(e => e.SREVYM).HasMaxLength(4);

                entity.Property(e => e.cInvoiceType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.dReduceDoc).HasColumnType("datetime");

                entity.Property(e => e.dUpdate).HasColumnType("datetime");

                entity.Property(e => e.nPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.nTotal).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.nVat).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.sBranchCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.sCitizenID)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.sCopyDoc).HasMaxLength(20);

                entity.Property(e => e.sDetail).HasMaxLength(500);

                entity.Property(e => e.sReason).HasMaxLength(500);

                entity.Property(e => e.sReduceDocNo).HasMaxLength(20);

                entity.Property(e => e.sReduceNo).HasMaxLength(20);

                entity.Property(e => e.sRefBILLNO).HasMaxLength(10);

                entity.Property(e => e.sRefOLDReqID).HasMaxLength(20);

                entity.Property(e => e.sRefReq_ServiceID).HasMaxLength(10);
            });

            modelBuilder.Entity<vInvoiceReduce_List>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vInvoiceReduce_List");

                entity.Property(e => e.SCUSTCODE).HasMaxLength(7);

                entity.Property(e => e.SCUSTNAME).HasMaxLength(250);

                entity.Property(e => e.cInvoiceType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.dUpdate).HasColumnType("datetime");

                entity.Property(e => e.nTotal).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.sReason).HasMaxLength(500);

                entity.Property(e => e.sReduceNo).HasMaxLength(20);

                entity.Property(e => e.sRefBILLNO).HasMaxLength(10);

                entity.Property(e => e.sRefReq_ServiceID).HasMaxLength(10);
            });

            modelBuilder.Entity<vLineOA>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vLineOA");

                entity.Property(e => e.CCUSTSTAT).HasMaxLength(1);

                entity.Property(e => e.DDOCDATE).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.NDISCNTAMT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NNETTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NNORTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NSRVFEE).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NTOTTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NVAT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.SCUSTCODE).HasMaxLength(7);

                entity.Property(e => e.SCUSTNAME).HasMaxLength(200);

                entity.Property(e => e.SDOCNO).HasMaxLength(10);

                entity.Property(e => e.SREVYM).HasMaxLength(4);

                entity.Property(e => e.SWWCODE).HasMaxLength(7);

                entity.Property(e => e.cBankType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<vPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPayment");

                entity.Property(e => e.BILLDATE).HasColumnType("datetime");

                entity.Property(e => e.BILLNO).HasMaxLength(10);

                entity.Property(e => e.CUSTCODE).HasMaxLength(7);

                entity.Property(e => e.DOCNO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PAID).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentTypeDesc).HasMaxLength(255);

                entity.Property(e => e.WWCODE).HasMaxLength(7);
            });

            modelBuilder.Entity<vRegisterCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRegisterCustomer");

                entity.Property(e => e.CCUSTSTAT).HasMaxLength(1);

                entity.Property(e => e.SCUSTADDR).HasMaxLength(255);

                entity.Property(e => e.SCUSTCODE).HasMaxLength(7);

                entity.Property(e => e.SCUSTNAME).HasMaxLength(200);

                entity.Property(e => e.SUSETYPE).HasMaxLength(3);

                entity.Property(e => e.SWWCODE).HasMaxLength(7);

                entity.Property(e => e.cBankType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<vReportMeter09>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vReportMeter09");

                entity.Property(e => e.CALDES)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CALWTUSGDes)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CCOLFLAG).HasMaxLength(1);

                entity.Property(e => e.CCUSTSTAT).HasMaxLength(1);

                entity.Property(e => e.CINVOICECNT).HasMaxLength(10);

                entity.Property(e => e.CUSGCALMTHD).HasMaxLength(1);

                entity.Property(e => e.CWARNLTFLAG).HasMaxLength(1);

                entity.Property(e => e.DADD).HasColumnType("datetime");

                entity.Property(e => e.DCOLDATE).HasColumnType("datetime");

                entity.Property(e => e.DDOCDATE).HasColumnType("datetime");

                entity.Property(e => e.DLSTMTRRDDT).HasColumnType("datetime");

                entity.Property(e => e.DLSTWARNDT).HasColumnType("datetime");

                entity.Property(e => e.DPRSMTRRDDT).HasColumnType("datetime");

                entity.Property(e => e.DUPDATE).HasColumnType("datetime");

                entity.Property(e => e.DWARNLTDT).HasColumnType("datetime");

                entity.Property(e => e.MTRDes)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MTRRDDT).HasColumnType("datetime");

                entity.Property(e => e.MTRSTMEAN)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NADJAMT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NBALAMT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NCOLAMT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NDEBT).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NDISCNTAMT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NDISCNTAMT_Diff).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NLSTCALMTHD).HasMaxLength(1);

                entity.Property(e => e.NNETTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NNETTRFWT_Diff).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NNORTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NNORTRFWT_Diff).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NPAID).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NPRSMTRCNT_Diff).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NPRSWTUSG_Diff).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NSEQ).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NSRVFEE).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NSRVFEE_Diff).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NTOTTRFWT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NTOTTRFWT_Diff).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NVAT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NVAT_Diff).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PROMOAMT).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PROMOBATH).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PROMOCAL).HasMaxLength(1);

                entity.Property(e => e.PROMOCODE).HasMaxLength(3);

                entity.Property(e => e.PROMOPCEN).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PROMORATIO).HasMaxLength(4);

                entity.Property(e => e.PROMOUNIT).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.RDANSDes)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SCUSTADDR).HasMaxLength(255);

                entity.Property(e => e.SCUSTCODE).HasMaxLength(7);

                entity.Property(e => e.SCUSTNAME).HasMaxLength(200);

                entity.Property(e => e.SDOCNO).HasMaxLength(10);

                entity.Property(e => e.SDOCTYPE).HasMaxLength(2);

                entity.Property(e => e.SREFDOCNO).HasMaxLength(10);

                entity.Property(e => e.SREFDOCTYPE).HasMaxLength(2);

                entity.Property(e => e.SREVYM).HasMaxLength(4);

                entity.Property(e => e.SROUTE).HasMaxLength(6);

                entity.Property(e => e.SUSETYPE).HasMaxLength(3);

                entity.Property(e => e.SWWCODE).HasMaxLength(7);

                entity.Property(e => e.cAR).HasMaxLength(1);

                entity.Property(e => e.cApprov_Cancel).HasMaxLength(1);

                entity.Property(e => e.cApprov_Cancel2).HasMaxLength(1);

                entity.Property(e => e.dARDate).HasColumnType("datetime");

                entity.Property(e => e.dApprov_Cancel).HasColumnType("datetime");

                entity.Property(e => e.dApprov_Cancel2).HasColumnType("datetime");

                entity.Property(e => e.dCancel).HasColumnType("datetime");

                entity.Property(e => e.dCancelAdd).HasColumnType("datetime");

                entity.Property(e => e.sAppComment).HasMaxLength(512);

                entity.Property(e => e.sAppComment2).HasMaxLength(512);

                entity.Property(e => e.sBillno).HasMaxLength(10);

                entity.Property(e => e.sReasonCancel)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.sysdate).HasColumnType("datetime");

                entity.Property(e => e.systime).HasColumnType("datetime");

                entity.Property(e => e.timestemp)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.userid).HasMaxLength(4);
            });

            modelBuilder.Entity<vReportMeter16>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vReportMeter16");

                entity.Property(e => e.CCONDITION1).HasMaxLength(100);

                entity.Property(e => e.CCONDITION2).HasMaxLength(100);

                entity.Property(e => e.CCONDITION3).HasMaxLength(100);

                entity.Property(e => e.CCUSTSTAT).HasMaxLength(1);

                entity.Property(e => e.CREADTYPE1).HasMaxLength(100);

                entity.Property(e => e.CREADTYPE2).HasMaxLength(100);

                entity.Property(e => e.DDOCDATE).HasColumnType("datetime");

                entity.Property(e => e.SCUSTADDR).HasMaxLength(255);

                entity.Property(e => e.SCUSTCODE).HasMaxLength(7);

                entity.Property(e => e.SCUSTNAME).HasMaxLength(200);

                entity.Property(e => e.SDOCNO).HasMaxLength(10);

                entity.Property(e => e.SREVYM).HasMaxLength(4);

                entity.Property(e => e.SWWCODE).HasMaxLength(7);
            });

            modelBuilder.Entity<vReportService03>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vReportService03");

                entity.Property(e => e.BILLDATE).HasColumnType("datetime");

                entity.Property(e => e.BILLNO).HasMaxLength(20);

                entity.Property(e => e.SCUSTNAME).HasMaxLength(250);

                entity.Property(e => e.SWWCODE).HasMaxLength(7);

                entity.Property(e => e.cInvoiceType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.nPrice).HasColumnType("numeric(12, 2)");

                entity.Property(e => e.nTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.nVat).HasColumnType("numeric(12, 2)");

                entity.Property(e => e.sBranchCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.sCitizenID).HasMaxLength(13);
            });

            modelBuilder.Entity<vReportService05>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vReportService05");

                entity.Property(e => e.BILLDATE).HasColumnType("datetime");

                entity.Property(e => e.BILLNO).HasMaxLength(4000);

                entity.Property(e => e.SCUSTCODE).HasMaxLength(7);

                entity.Property(e => e.SCUSTNAME).HasMaxLength(250);

                entity.Property(e => e.SMTRSZMEAN).HasMaxLength(256);

                entity.Property(e => e.nNet).HasColumnType("numeric(17, 6)");

                entity.Property(e => e.nTotal).HasColumnType("numeric(12, 2)");

                entity.Property(e => e.nVat).HasColumnType("numeric(16, 6)");

                entity.Property(e => e.sUUNote).HasMaxLength(500);
            });

            modelBuilder.Entity<vRequestNoVat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRequestNoVat");

                entity.Property(e => e.DUPDATE).HasColumnType("datetime");

                entity.Property(e => e.SCUSTADDR).HasMaxLength(255);

                entity.Property(e => e.SCUSTCODE).HasMaxLength(7);

                entity.Property(e => e.SCUSTNAME).HasMaxLength(200);

                entity.Property(e => e.SREVYM).HasMaxLength(4);

                entity.Property(e => e.cRequestType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.cStatus)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.dInvoice).HasColumnType("datetime");

                entity.Property(e => e.dRequest).HasColumnType("datetime");

                entity.Property(e => e.nDiscount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.nNet).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.nPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.nTotal).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.sAns13).HasMaxLength(512);

                entity.Property(e => e.sReq_ServiceID).HasMaxLength(10);

                entity.Property(e => e.sServiceOther).HasMaxLength(200);
            });

            modelBuilder.Entity<vRequestWaterStream>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRequestWaterStream");

                entity.Property(e => e.DUPDATE).HasColumnType("datetime");

                entity.Property(e => e.SCUSTADDR).HasMaxLength(500);

                entity.Property(e => e.SCUSTNAME).HasMaxLength(100);

                entity.Property(e => e.cStatus)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.dRequest).HasColumnType("datetime");

                entity.Property(e => e.sWTRStreamNo).HasMaxLength(20);
            });

            modelBuilder.Entity<vWater_usage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWater_usage");

                entity.Property(e => e.CANTMTR).HasMaxLength(100);

                entity.Property(e => e.CANTREAD).HasMaxLength(100);

                entity.Property(e => e.CUSTCODE).HasMaxLength(7);

                entity.Property(e => e.DMETERLAST).HasColumnType("datetime");

                entity.Property(e => e.DREADMETER).HasColumnType("datetime");

                entity.Property(e => e.REVYM).HasMaxLength(4);

                entity.Property(e => e.WWCODE).HasMaxLength(7);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
