using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreModelss
{
    public partial class Dotnet2023Context : DbContext
    {
        public Dotnet2023Context()
        {
        }

        public Dotnet2023Context(DbContextOptions<Dotnet2023Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; } = null!;
        public virtual DbSet<Assessment> Assessments { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Emp> Emps { get; set; } = null!;
        public virtual DbSet<GoIbIboRole> GoIbIboRoles { get; set; } = null!;
        public virtual DbSet<GoibiboFlightBooking> GoibiboFlightBookings { get; set; } = null!;
        public virtual DbSet<GoibiboItinery> GoibiboItineries { get; set; } = null!;
        public virtual DbSet<GoibiboUser> GoibiboUsers { get; set; } = null!;
        public virtual DbSet<GoibibobookingDetail> GoibibobookingDetails { get; set; } = null!;
        public virtual DbSet<Goibibohotel> Goibibohotels { get; set; } = null!;
        public virtual DbSet<HotelRoom> HotelRooms { get; set; } = null!;
        public virtual DbSet<ItenaryDetail> ItenaryDetails { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<QuizModel> QuizModels { get; set; } = null!;
        public virtual DbSet<QuizResultModel> QuizResultModels { get; set; } = null!;
        public virtual DbSet<TblAssessmentQuizTool> TblAssessmentQuizTools { get; set; } = null!;
        public virtual DbSet<TblGoibiboFlight> TblGoibiboFlights { get; set; } = null!;
        public virtual DbSet<TblGoibiboFlightCustomer> TblGoibiboFlightCustomers { get; set; } = null!;
        public virtual DbSet<TblGoibiboFlightsF> TblGoibiboFlightsFs { get; set; } = null!;
        public virtual DbSet<TblGoibiboHoliday> TblGoibiboHolidays { get; set; } = null!;
        public virtual DbSet<TblOnlineAssesmentCategory> TblOnlineAssesmentCategories { get; set; } = null!;
        public virtual DbSet<TblOnlineAssesmentInstructor> TblOnlineAssesmentInstructors { get; set; } = null!;
        public virtual DbSet<TblOnlineAssesmentQuestion> TblOnlineAssesmentQuestions { get; set; } = null!;
        public virtual DbSet<TblOnlineAssesmentUserResponse> TblOnlineAssesmentUserResponses { get; set; } = null!;
        public virtual DbSet<TblOnlineAssessmentAssessmentResult> TblOnlineAssessmentAssessmentResults { get; set; } = null!;
        public virtual DbSet<TblOnlineAssessmentQuestion> TblOnlineAssessmentQuestions { get; set; } = null!;
        public virtual DbSet<TblOnlineAssessmentQuiz> TblOnlineAssessmentQuizzes { get; set; } = null!;
        public virtual DbSet<TblOnlineAssessmentQuiz1> TblOnlineAssessmentQuizzes1 { get; set; } = null!;
        public virtual DbSet<TblOnlineAssessmentUser> TblOnlineAssessmentUsers { get; set; } = null!;
        public virtual DbSet<TblPharmCart> TblPharmCarts { get; set; } = null!;
        public virtual DbSet<TblPharmEasyLocation> TblPharmEasyLocations { get; set; } = null!;
        public virtual DbSet<TblPharmEasyPincode> TblPharmEasyPincodes { get; set; } = null!;
        public virtual DbSet<TblPharmEasyProd> TblPharmEasyProds { get; set; } = null!;
        public virtual DbSet<TblPharmEasyProduct> TblPharmEasyProducts { get; set; } = null!;
        public virtual DbSet<TblPharmEasyStore> TblPharmEasyStores { get; set; } = null!;
        public virtual DbSet<TblPharmEasyUser> TblPharmEasyUsers { get; set; } = null!;
        public virtual DbSet<TblPharmEasyUserCart> TblPharmEasyUserCarts { get; set; } = null!;
        public virtual DbSet<TblPharmEasyUserOrder> TblPharmEasyUserOrders { get; set; } = null!;
        public virtual DbSet<TblPharmEasyUserOrderItem> TblPharmEasyUserOrderItems { get; set; } = null!;
        public virtual DbSet<TblPharmEasyUserProduct> TblPharmEasyUserProducts { get; set; } = null!;
        public virtual DbSet<TblPharmEasyUserlogin> TblPharmEasyUserlogins { get; set; } = null!;
        public virtual DbSet<TblPharmEasyUsersignin> TblPharmEasyUsersignins { get; set; } = null!;
        public virtual DbSet<TblPharmOtherDetail> TblPharmOtherDetails { get; set; } = null!;
        public virtual DbSet<TblPharmProduct> TblPharmProducts { get; set; } = null!;
        public virtual DbSet<TblPharmStore> TblPharmStores { get; set; } = null!;
        public virtual DbSet<TblProduct> TblProducts { get; set; } = null!;
        public virtual DbSet<TblSnapdealCart> TblSnapdealCarts { get; set; } = null!;
        public virtual DbSet<TblSnapdealCart1> TblSnapdealCarts1 { get; set; } = null!;
        public virtual DbSet<TblSnapdealMyOrder> TblSnapdealMyOrders { get; set; } = null!;
        public virtual DbSet<TblSnapdealOngoingSale> TblSnapdealOngoingSales { get; set; } = null!;
        public virtual DbSet<TblSnapdealProduct> TblSnapdealProducts { get; set; } = null!;
        public virtual DbSet<TblSnapdealProduct1> TblSnapdealProducts1 { get; set; } = null!;
        public virtual DbSet<TblSnapdealRating> TblSnapdealRatings { get; set; } = null!;
        public virtual DbSet<TblSnapdealSubcategory> TblSnapdealSubcategories { get; set; } = null!;
        public virtual DbSet<TblSnapdealUpcomingSale> TblSnapdealUpcomingSales { get; set; } = null!;
        public virtual DbSet<TblSnapdealUser> TblSnapdealUsers { get; set; } = null!;
        public virtual DbSet<TblSnapdealWishList1> TblSnapdealWishLists1 { get; set; } = null!;
        public virtual DbSet<TblSnapdealWishlist> TblSnapdealWishlists { get; set; } = null!;
        public virtual DbSet<TblSnapdealWishlistNew> TblSnapdealWishlistNews { get; set; } = null!;
        public virtual DbSet<TblSnapdelCategory> TblSnapdelCategories { get; set; } = null!;
        public virtual DbSet<TblSnapdelCategoryType> TblSnapdelCategoryTypes { get; set; } = null!;
        public virtual DbSet<TblSnapdelTopCategory> TblSnapdelTopCategories { get; set; } = null!;
        public virtual DbSet<TblTataCliqBrand> TblTataCliqBrands { get; set; } = null!;
        public virtual DbSet<TblTataCliqCart> TblTataCliqCarts { get; set; } = null!;
        public virtual DbSet<TblTataCliqCategory> TblTataCliqCategories { get; set; } = null!;
        public virtual DbSet<TblTataCliqOrder> TblTataCliqOrders { get; set; } = null!;
        public virtual DbSet<TblTataCliqProduct> TblTataCliqProducts { get; set; } = null!;
        public virtual DbSet<TblTataCliqShopAddress> TblTataCliqShopAddresses { get; set; } = null!;
        public virtual DbSet<TblTataCliqUser> TblTataCliqUsers { get; set; } = null!;
        public virtual DbSet<TblTataCliqUserType> TblTataCliqUserTypes { get; set; } = null!;
        public virtual DbSet<TblTataCliqWishlist> TblTataCliqWishlists { get; set; } = null!;
        public virtual DbSet<TblUpcomingSale> TblUpcomingSales { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=GXWO2ATRAIN01;Database=Dotnet2023;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                        r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId");

                            j.ToTable("AspNetUserRoles");

                            j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.HasIndex(e => e.Email, "UQ__Customer__A9D10534FCC0B7F1")
                    .IsUnique();

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.ToTable("emp");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("emp_id");

                entity.Property(e => e.EmpAge).HasColumnName("emp_age");

                entity.Property(e => e.EmpCity)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("emp_city");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");
            });

            modelBuilder.Entity<GoIbIboRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__GoIbIboR__8AFACE1AAAD5C8F2");

                entity.HasIndex(e => e.RoleName, "UQ__GoIbIboR__8A2B616000651130")
                    .IsUnique();

                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoibiboFlightBooking>(entity =>
            {
                entity.HasKey(e => e.BookingId);
            });

            modelBuilder.Entity<GoibiboItinery>(entity =>
            {
                entity.HasKey(e => e.ItinaryId)
                    .HasName("PK__GoibiboI__01ABFD7A24B237D5");

                entity.ToTable("GoibiboItinery");

                entity.Property(e => e.ItinaryId)
                    .ValueGeneratedNever()
                    .HasColumnName("itinaryId");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Days).HasColumnName("days");
            });

            modelBuilder.Entity<GoibiboUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__GoibiboU__CB9A1CFF6D8C8EA1");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("userId");

                entity.Property(e => e.Pwd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pwd");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.GoibiboUsers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__GoibiboUs__RoleI__147C05D0");
            });

            modelBuilder.Entity<GoibibobookingDetail>(entity =>
            {
                entity.HasKey(e => e.TblId);

                entity.ToTable("GOIBIBOBookingDetails");
            });

            modelBuilder.Entity<Goibibohotel>(entity =>
            {
                entity.HasKey(e => e.HotelId)
                    .HasName("PK__GOIBIBOH__46023BDFA6F7DE6D");

                entity.ToTable("GOIBIBOHotels");

                entity.Property(e => e.HotelId).ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.HotelImggUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('../assets/Images/room.jpg')");

                entity.Property(e => e.HotelName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfRoom)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Type_of_room");
            });

            modelBuilder.Entity<HotelRoom>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.City)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.HotelImgUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HotelName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItenaryDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Afternoon)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("afternoon");

                entity.Property(e => e.Daysnum).HasColumnName("daysnum");

                entity.Property(e => e.Daytitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Evening)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("evening");

                entity.Property(e => e.Itinaryid).HasColumnName("itinaryid");

                entity.Property(e => e.Location1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("location1");

                entity.Property(e => e.Location2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("location2");

                entity.Property(e => e.Morning)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("morning");

                entity.HasOne(d => d.Itinary)
                    .WithMany()
                    .HasForeignKey(d => d.Itinaryid)
                    .HasConstraintName("FK__ItenaryDe__itina__77AABCF8");
            });

            //modelBuilder.Entity<Product>(entity =>
            //{
            //    entity.Property(e => e.Description)
            //        .HasMaxLength(250)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Name)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            //});

            modelBuilder.Entity<QuizModel>(entity =>
            {
                entity.HasKey(e => e.QuizId);

                entity.HasIndex(e => e.AssessmentId, "IX_QuizModels_AssessmentId");

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.QuizModels)
                    .HasForeignKey(d => d.AssessmentId);
            });

            modelBuilder.Entity<QuizResultModel>(entity =>
            {
                entity.HasKey(e => e.ResultId);

                entity.Property(e => e.UserResponse).HasColumnName("userResponse");
            });

            modelBuilder.Entity<TblAssessmentQuizTool>(entity =>
            {
                entity.HasKey(e => e.QuizId)
                    .HasName("PK__Tbl_Asse__8B42AE8E3B6FE75F");

                entity.ToTable("Tbl_Assessment_QuizTool");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.QuizName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblAssessmentQuizTools)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Tbl_Asses__Categ__2C538F61");

                entity.HasOne(d => d.Instructor)
                    .WithMany(p => p.TblAssessmentQuizTools)
                    .HasForeignKey(d => d.InstructorId)
                    .HasConstraintName("FK__Tbl_Asses__Instr__2B5F6B28");
            });

            modelBuilder.Entity<TblGoibiboFlight>(entity =>
            {
                entity.HasKey(e => e.FlightId);

                entity.ToTable("tbl_GoibiboFlights");
            });

            modelBuilder.Entity<TblGoibiboFlightCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("tbl_GoibiboFlightCustomers");
            });

            modelBuilder.Entity<TblGoibiboFlightsF>(entity =>
            {
                entity.HasKey(e => e.FlightId)
                    .HasName("PK__tbl_Goib__8A9E14EE857BE045");

                entity.ToTable("tbl_GoibiboFlightsF");

                entity.Property(e => e.FlightId).ValueGeneratedNever();

                entity.Property(e => e.FlightDestination).IsUnicode(false);

                entity.Property(e => e.FlightSource).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Logo).HasColumnName("logo");
            });

            modelBuilder.Entity<TblGoibiboHoliday>(entity =>
            {
                entity.HasKey(e => e.HolidayId)
                    .HasName("PK__tbl_Goib__D2D5D45563BD01EA");

                entity.ToTable("tbl_GoibiboHolidays");

                entity.Property(e => e.HolidayId)
                    .ValueGeneratedNever()
                    .HasColumnName("Holiday_id");

                entity.Property(e => e.Category)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Destination)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("H_id");
            });

            modelBuilder.Entity<TblOnlineAssesmentCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__Tbl_Onli__19093A0B97A5B92F");

                entity.ToTable("Tbl_OnlineAssesment_Categories");

                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.CatId).ValueGeneratedOnAdd();

                entity.Property(e => e.CategoryName).HasMaxLength(100);
            });

            modelBuilder.Entity<TblOnlineAssesmentInstructor>(entity =>
            {
                entity.HasKey(e => e.InstructorId)
                    .HasName("PK__Tbl_Onli__9D010A9B41EC65AC");

                entity.ToTable("Tbl_OnlineAssesment_Instructors");

                entity.Property(e => e.InstructorId).ValueGeneratedNever();

                entity.Property(e => e.InstructorName).HasMaxLength(255);

                entity.Property(e => e.InsturctId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblOnlineAssesmentQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId)
                    .HasName("PK__Tbl_Onli__0DC06FAC661F58DB");

                entity.ToTable("Tbl_OnlineAssesment_Questions");

                entity.Property(e => e.QuestionId).ValueGeneratedNever();

                entity.Property(e => e.IdQuestion).ValueGeneratedOnAdd();

                entity.Property(e => e.Option1).HasMaxLength(255);

                entity.Property(e => e.Option2).HasMaxLength(255);

                entity.Property(e => e.Option3).HasMaxLength(255);

                entity.Property(e => e.Option4).HasMaxLength(255);

                entity.Property(e => e.QuestionText).HasMaxLength(1000);

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.TblOnlineAssesmentQuestions)
                    .HasForeignKey(d => d.QuizId)
                    .HasConstraintName("FK__Tbl_Onlin__QuizI__4D2A7347");
            });

            modelBuilder.Entity<TblOnlineAssesmentUserResponse>(entity =>
            {
                entity.HasKey(e => e.UserResponseId)
                    .HasName("PK__Tbl_Onli__B2B564EB001DB875");

                entity.ToTable("Tbl_OnlineAssesment_UserResponses");

                entity.Property(e => e.UserResponseId).ValueGeneratedNever();

                entity.Property(e => e.IdUserResponse).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.TblOnlineAssesmentUserResponses)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK__Tbl_Onlin__Quest__7814D14C");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblOnlineAssesmentUserResponses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Tbl_Onlin__UserI__7720AD13");
            });

            modelBuilder.Entity<TblOnlineAssessmentAssessmentResult>(entity =>
            {
                entity.HasKey(e => e.AssessmentResultId)
                    .HasName("PK__Tbl_Onli__B8018D14E97A544C");

                entity.ToTable("Tbl_OnlineAssessment_AssessmentResults");

                entity.Property(e => e.AssessmentResultId).ValueGeneratedNever();

                entity.Property(e => e.IdAssessmentResult).ValueGeneratedOnAdd();

                entity.Property(e => e.PassOrFail).HasMaxLength(50);

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.TblOnlineAssessmentAssessmentResults)
                    .HasForeignKey(d => d.QuizId)
                    .HasConstraintName("FK__Tbl_Onlin__QuizI__7AF13DF7");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblOnlineAssessmentAssessmentResults)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Results_Users");
            });

            modelBuilder.Entity<TblOnlineAssessmentQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId)
                    .HasName("PK__Tbl_Onli__0DC06FACC023D170");

                entity.ToTable("Tbl_OnlineAssessmentQuestion");

                entity.Property(e => e.QuestionId).ValueGeneratedNever();

                entity.Property(e => e.Choice1).HasMaxLength(255);

                entity.Property(e => e.Choice2).HasMaxLength(255);

                entity.Property(e => e.Choice3).HasMaxLength(255);

                entity.Property(e => e.Choice4).HasMaxLength(255);

                entity.Property(e => e.QuestionText).HasMaxLength(255);

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.TblOnlineAssessmentQuestions)
                    .HasForeignKey(d => d.QuizId)
                    .HasConstraintName("FK__Tbl_Onlin__QuizI__6E8B6712");
            });

            modelBuilder.Entity<TblOnlineAssessmentQuiz>(entity =>
            {
                entity.HasKey(e => e.QuizId)
                    .HasName("PK__Tbl_Onli__8B42AE8E2D11EB23");

                entity.ToTable("Tbl_OnlineAssessment_Quizzes");

                entity.HasIndex(e => e.QuizName, "UQ_QuizName")
                    .IsUnique();

                entity.Property(e => e.QuizId).ValueGeneratedNever();

                entity.Property(e => e.IdQuiz).ValueGeneratedOnAdd();

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.QuizName).HasMaxLength(255);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblOnlineAssessmentQuizzes)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Tbl_Onlin__Categ__4589517F");

                entity.HasOne(d => d.Instructor)
                    .WithMany(p => p.TblOnlineAssessmentQuizzes)
                    .HasForeignKey(d => d.InstructorId)
                    .HasConstraintName("FK__Tbl_Onlin__Instr__44952D46");
            });

            modelBuilder.Entity<TblOnlineAssessmentQuiz1>(entity =>
            {
                entity.HasKey(e => e.QuizId)
                    .HasName("QuizId_PK");

                entity.ToTable("Tbl_OnlineAssessmentQuiz");

                entity.Property(e => e.QuizTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOnlineAssessmentUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Tbl_Onli__1788CC4C3687D26F");

                entity.ToTable("Tbl_OnlineAssessment_Users");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdUser).ValueGeneratedOnAdd();

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.Username).HasMaxLength(255);
            });

            modelBuilder.Entity<TblPharmCart>(entity =>
            {
                entity.HasKey(e => e.IProductId);

                entity.ToTable("tbl_Pharm_Cart");

                entity.Property(e => e.IProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("iProductId");

                entity.Property(e => e.DeProductPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("deProductPrice");

                entity.Property(e => e.ICartId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("iCartId");

                entity.Property(e => e.IQuantity).HasColumnName("iQuantity");

                entity.Property(e => e.VImageUrl)
                    .IsUnicode(false)
                    .HasColumnName("vImageUrl");

                entity.Property(e => e.VManufacturer)
                    .IsUnicode(false)
                    .HasColumnName("vManufacturer");

                entity.Property(e => e.VProductDescription)
                    .IsUnicode(false)
                    .HasColumnName("vProductDescription");

                entity.Property(e => e.VProductName)
                    .IsUnicode(false)
                    .HasColumnName("vProductName");

                entity.HasOne(d => d.IProduct)
                    .WithOne(p => p.TblPharmCart)
                    .HasForeignKey<TblPharmCart>(d => d.IProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Pharm__iProd__035179CE");
            });

            modelBuilder.Entity<TblPharmEasyLocation>(entity =>
            {
                entity.HasKey(e => e.ILocationId)
                    .HasName("PK__Tbl_Phar__1AC9AF76A4A4F6E5");

                entity.ToTable("Tbl_PharmEasy_Location");

                entity.Property(e => e.ILocationId)
                    .ValueGeneratedNever()
                    .HasColumnName("iLocationId");

                entity.Property(e => e.IId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("iId");

                entity.Property(e => e.VStoreLocation)
                    .IsUnicode(false)
                    .HasColumnName("vStoreLocation");
            });

            modelBuilder.Entity<TblPharmEasyPincode>(entity =>
            {
                entity.HasKey(e => e.IPincodeId)
                    .HasName("PK__Tbl_Phar__6B612BCE7A6F48BB");

                entity.ToTable("Tbl_PharmEasy_Pincode");

                entity.Property(e => e.IPincodeId)
                    .ValueGeneratedNever()
                    .HasColumnName("iPincodeId");

                entity.Property(e => e.IId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("iId");

                entity.Property(e => e.ILocationId).HasColumnName("iLocationId");

                entity.Property(e => e.IPincode).HasColumnName("iPincode");

                entity.HasOne(d => d.ILocation)
                    .WithMany(p => p.TblPharmEasyPincodes)
                    .HasForeignKey(d => d.ILocationId)
                    .HasConstraintName("FK__Tbl_Pharm__iLoca__5090EFD7");
            });

            modelBuilder.Entity<TblPharmEasyProd>(entity =>
            {
                entity.HasKey(e => e.IProductId)
                    .HasName("PK__Tbl_Phar__2A611C8442390680");

                entity.ToTable("Tbl_PharmEasy_Prod");

                entity.Property(e => e.IProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("iProductId");

                entity.Property(e => e.DExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("dExpiryDate");

                entity.Property(e => e.DeProductPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("deProductPrice");

                entity.Property(e => e.IId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("iId");

                entity.Property(e => e.ILocationId).HasColumnName("iLocationId");

                entity.Property(e => e.IPincodeId).HasColumnName("iPincodeId");

                entity.Property(e => e.IQuantity).HasColumnName("iQuantity");

                entity.Property(e => e.IStoreId).HasColumnName("iStoreId");

                entity.Property(e => e.VComposition)
                    .IsUnicode(false)
                    .HasColumnName("vComposition");

                entity.Property(e => e.VImageUrl)
                    .IsUnicode(false)
                    .HasColumnName("vImageUrl");

                entity.Property(e => e.VManufacturer)
                    .IsUnicode(false)
                    .HasColumnName("vManufacturer");

                entity.Property(e => e.VProductDescription)
                    .IsUnicode(false)
                    .HasColumnName("vProductDescription");

                entity.Property(e => e.VProductName)
                    .IsUnicode(false)
                    .HasColumnName("vProductName");

                entity.Property(e => e.VSideEffects)
                    .IsUnicode(false)
                    .HasColumnName("vSideEffects");

                entity.Property(e => e.VUses)
                    .IsUnicode(false)
                    .HasColumnName("vUses");

                entity.Property(e => e.VWarnings)
                    .IsUnicode(false)
                    .HasColumnName("vWarnings");

                entity.HasOne(d => d.ILocation)
                    .WithMany(p => p.TblPharmEasyProds)
                    .HasForeignKey(d => d.ILocationId)
                    .HasConstraintName("FK__Tbl_Pharm__iLoca__60C757A0");

                entity.HasOne(d => d.IPincode)
                    .WithMany(p => p.TblPharmEasyProds)
                    .HasForeignKey(d => d.IPincodeId)
                    .HasConstraintName("FK__Tbl_Pharm__iPinc__61BB7BD9");

                entity.HasOne(d => d.IStore)
                    .WithMany(p => p.TblPharmEasyProds)
                    .HasForeignKey(d => d.IStoreId)
                    .HasConstraintName("FK__Tbl_Pharm__iStor__62AFA012");
            });

            modelBuilder.Entity<TblPharmEasyProduct>(entity =>
            {
                entity.HasKey(e => e.IProductId)
                    .HasName("PK__tbl_Phar__2A611C844C5EFBE3");

                entity.ToTable("tbl_PharmEasy_Products");

                entity.Property(e => e.IProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("iProductId");

                entity.Property(e => e.BIsActive).HasColumnName("bIsActive");

                entity.Property(e => e.DExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("dExpiryDate");

                entity.Property(e => e.DeProductPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("deProductPrice");

                entity.Property(e => e.IId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("iId");

                entity.Property(e => e.IQuantity).HasColumnName("iQuantity");

                entity.Property(e => e.IStorePincode).HasColumnName("iStorePincode");

                entity.Property(e => e.VComposition)
                    .IsUnicode(false)
                    .HasColumnName("vComposition");

                entity.Property(e => e.VImageUrl)
                    .IsUnicode(false)
                    .HasColumnName("vImageUrl");

                entity.Property(e => e.VManufacturer)
                    .IsUnicode(false)
                    .HasColumnName("vManufacturer");

                entity.Property(e => e.VProductDescription)
                    .IsUnicode(false)
                    .HasColumnName("vProductDescription");

                entity.Property(e => e.VProductName)
                    .IsUnicode(false)
                    .HasColumnName("vProductName");

                entity.Property(e => e.VSideEffects)
                    .IsUnicode(false)
                    .HasColumnName("vSideEffects");

                entity.Property(e => e.VStoreLocation)
                    .IsUnicode(false)
                    .HasColumnName("vStoreLocation");

                entity.Property(e => e.VStoreName)
                    .IsUnicode(false)
                    .HasColumnName("vStoreName");

                entity.Property(e => e.VUses)
                    .IsUnicode(false)
                    .HasColumnName("vUses");

                entity.Property(e => e.VWarnings)
                    .IsUnicode(false)
                    .HasColumnName("vWarnings");
            });

            modelBuilder.Entity<TblPharmEasyStore>(entity =>
            {
                entity.HasKey(e => e.IStoreId)
                    .HasName("PK__Tbl_Phar__6806C5EAC78BAF99");

                entity.ToTable("Tbl_PharmEasy_Store");

                entity.Property(e => e.IStoreId)
                    .ValueGeneratedNever()
                    .HasColumnName("iStoreId");

                entity.Property(e => e.IId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("iId");

                entity.Property(e => e.IPincodeId).HasColumnName("iPincodeId");

                entity.Property(e => e.VStoreName)
                    .IsUnicode(false)
                    .HasColumnName("vStoreName");

                entity.HasOne(d => d.IPincode)
                    .WithMany(p => p.TblPharmEasyStores)
                    .HasForeignKey(d => d.IPincodeId)
                    .HasConstraintName("FK__Tbl_Pharm__iPinc__536D5C82");
            });

            modelBuilder.Entity<TblPharmEasyUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tbl_Phar__B9BE370FB13F1C5D");

                entity.ToTable("tbl_PharmEasy_User");

                entity.HasIndex(e => e.Email, "UQ__tbl_Phar__AB6E6164829D0231")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phonenumber).HasColumnName("phonenumber");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("date")
                    .HasColumnName("registration_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<TblPharmEasyUserCart>(entity =>
            {
                entity.HasKey(e => e.CartId)
                    .HasName("PK__tbl_Phar__2EF52A27DBE68CCB");

                entity.ToTable("tbl_PharmEasy_User_Cart");

                entity.Property(e => e.CartId).HasColumnName("cart_id");

                entity.Property(e => e.IProductId).HasColumnName("iProductId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("total_price");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.IProduct)
                    .WithMany(p => p.TblPharmEasyUserCarts)
                    .HasForeignKey(d => d.IProductId)
                    .HasConstraintName("FK_Cart_Product");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblPharmEasyUserCarts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Cart_User");
            });

            modelBuilder.Entity<TblPharmEasyUserOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__tbl_Phar__46596229F3D3AAC0");

                entity.ToTable("tbl_PharmEasy_User_Orders");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("order_date");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("total_amount");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblPharmEasyUserOrders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Order_User");
            });

            modelBuilder.Entity<TblPharmEasyUserOrderItem>(entity =>
            {
                entity.HasKey(e => e.OrderItemId)
                    .HasName("PK__tbl_Phar__3764B6BCEC1F26A7");

                entity.ToTable("tbl_PharmEasy_User_OrderItem");

                entity.Property(e => e.OrderItemId).HasColumnName("order_item_id");

                entity.Property(e => e.IProductId).HasColumnName("iProductId");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.IProduct)
                    .WithMany(p => p.TblPharmEasyUserOrderItems)
                    .HasForeignKey(d => d.IProductId)
                    .HasConstraintName("FK_OrderItem_Product");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblPharmEasyUserOrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderItem_Order");
            });

            modelBuilder.Entity<TblPharmEasyUserProduct>(entity =>
            {
                entity.HasKey(e => e.IProductId)
                    .HasName("PK__tbl_Phar__2A611C84BBA190F2");

                entity.ToTable("tbl_PharmEasy_User_Product");

                entity.Property(e => e.IProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("iProductId");

                entity.Property(e => e.BIsActive).HasColumnName("bIsActive");

                entity.Property(e => e.DExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("dExpiryDate");

                entity.Property(e => e.DeProductPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("deProductPrice");

                entity.Property(e => e.IId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("iId");

                entity.Property(e => e.IQuantity).HasColumnName("iQuantity");

                entity.Property(e => e.IStorePincode).HasColumnName("iStorePincode");

                entity.Property(e => e.VComposition)
                    .IsUnicode(false)
                    .HasColumnName("vComposition");

                entity.Property(e => e.VImageUrl)
                    .IsUnicode(false)
                    .HasColumnName("vImageUrl");

                entity.Property(e => e.VManufacturer)
                    .IsUnicode(false)
                    .HasColumnName("vManufacturer");

                entity.Property(e => e.VProductDescription)
                    .IsUnicode(false)
                    .HasColumnName("vProductDescription");

                entity.Property(e => e.VProductName)
                    .IsUnicode(false)
                    .HasColumnName("vProductName");

                entity.Property(e => e.VSideEffects)
                    .IsUnicode(false)
                    .HasColumnName("vSideEffects");

                entity.Property(e => e.VStoreLocation)
                    .IsUnicode(false)
                    .HasColumnName("vStoreLocation");

                entity.Property(e => e.VStoreName)
                    .IsUnicode(false)
                    .HasColumnName("vStoreName");

                entity.Property(e => e.VUses)
                    .IsUnicode(false)
                    .HasColumnName("vUses");

                entity.Property(e => e.VWarnings)
                    .IsUnicode(false)
                    .HasColumnName("vWarnings");
            });

            modelBuilder.Entity<TblPharmEasyUserlogin>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tbl_Phar__B9BE370F8218A9A4");

                entity.ToTable("tbl_PharmEasy_Userlogin");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.PasswordHash)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("password_hash");
            });

            modelBuilder.Entity<TblPharmEasyUsersignin>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tbl_Phar__B9BE370F673B9D83");

                entity.ToTable("tbl_PharmEasy_Usersignin");

                entity.HasIndex(e => e.Email, "UQ__tbl_Phar__AB6E61640B8AFAF2")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<TblPharmOtherDetail>(entity =>
            {
                entity.HasKey(e => e.IOtherDetailsId)
                    .HasName("PK__tbl_Phar__FED6866B4983E386");

                entity.ToTable("tbl_Pharm_OtherDetails");

                entity.Property(e => e.IOtherDetailsId)
                    .ValueGeneratedNever()
                    .HasColumnName("iOtherDetailsID");

                entity.Property(e => e.IProductId).HasColumnName("iProductId");

                entity.Property(e => e.VComposition)
                    .IsUnicode(false)
                    .HasColumnName("vComposition");

                entity.Property(e => e.VSideEffects)
                    .IsUnicode(false)
                    .HasColumnName("vSideEffects");

                entity.Property(e => e.VUses)
                    .IsUnicode(false)
                    .HasColumnName("vUses");

                entity.Property(e => e.VWarnings)
                    .IsUnicode(false)
                    .HasColumnName("vWarnings");

                entity.HasOne(d => d.IProduct)
                    .WithMany(p => p.TblPharmOtherDetails)
                    .HasForeignKey(d => d.IProductId)
                    .HasConstraintName("FK__tbl_Pharm__iProd__79C80F94");
            });

            modelBuilder.Entity<TblPharmProduct>(entity =>
            {
                entity.HasKey(e => e.IProductId)
                    .HasName("PK__tbl_Phar__2A611C644485B557");

                entity.ToTable("tbl_Pharm_Products");

                entity.Property(e => e.IProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("iProductID");

                entity.Property(e => e.BIsactive).HasColumnName("bIsactive");

                entity.Property(e => e.DExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("dExpiryDate");

                entity.Property(e => e.DeProductPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("deProductPrice");

                entity.Property(e => e.IId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("iId");

                entity.Property(e => e.IQuantity).HasColumnName("iQuantity");

                entity.Property(e => e.VImageUrl)
                    .IsUnicode(false)
                    .HasColumnName("vImageUrl");

                entity.Property(e => e.VManufacturer)
                    .IsUnicode(false)
                    .HasColumnName("vManufacturer");

                entity.Property(e => e.VProductDescription)
                    .IsUnicode(false)
                    .HasColumnName("vProductDescription");

                entity.Property(e => e.VProductName)
                    .IsUnicode(false)
                    .HasColumnName("vProductName");
            });

            modelBuilder.Entity<TblPharmStore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Pharm_Store");

                entity.Property(e => e.IProductId).HasColumnName("iProductId");

                entity.Property(e => e.IStoreId).HasColumnName("iStoreId");

                entity.Property(e => e.IStorePincode).HasColumnName("iStorePincode");

                entity.Property(e => e.VStoreLocation)
                    .IsUnicode(false)
                    .HasColumnName("vStoreLocation");

                entity.Property(e => e.VStoreName)
                    .IsUnicode(false)
                    .HasColumnName("vStoreName");

                entity.HasOne(d => d.IProduct)
                    .WithMany()
                    .HasForeignKey(d => d.IProductId)
                    .HasConstraintName("FK__tbl_Pharm__iProd__0169315C");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("tbl_Products");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblSnapdealCart>(entity =>
            {
                entity.HasKey(e => e.CartId)
                    .HasName("PK__tbl_Snap__D6AB4759437C6C17");

                entity.ToTable("tbl_Snapdeal_Cart");

                entity.Property(e => e.CartId)
                    .ValueGeneratedNever()
                    .HasColumnName("Cart_Id");

                entity.Property(e => e.CId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("C_Id");

                entity.Property(e => e.CartQuantity).HasColumnName("Cart_quantity");

                entity.Property(e => e.FlashSaleId).HasColumnName("Flash_Sale_Id");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductCategory)
                    .HasMaxLength(255)
                    .HasColumnName("Product_Category");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ProductNewPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Product_NewPrice");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Product_Price");

                entity.HasOne(d => d.FlashSale)
                    .WithMany(p => p.TblSnapdealCarts)
                    .HasForeignKey(d => d.FlashSaleId)
                    .HasConstraintName("FK__tbl_Snapd__Flash__5772F790");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblSnapdealCarts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__tbl_Snapd__Produ__567ED357");
            });

            modelBuilder.Entity<TblSnapdealCart1>(entity =>
            {
                entity.HasKey(e => e.CartId)
                    .HasName("PK__tbl_Snap__51BCD7B7F6E4649F");

                entity.ToTable("tbl_SnapdealCart");

                entity.Property(e => e.ProductCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDiscount).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblSnapdealCart1s)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__tbl_Snapd__Produ__6B24EA82");

                entity.HasOne(d => d.Usale)
                    .WithMany(p => p.TblSnapdealCart1s)
                    .HasForeignKey(d => d.UsaleId)
                    .HasConstraintName("FK_SnapdealCart_UpcomingSale_UsaleId");
            });

            modelBuilder.Entity<TblSnapdealMyOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__tbl_Snap__F1E4607BBBFABE78");

                entity.ToTable("tbl_Snapdeal_MyOrders");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("Order_Id");

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");

                entity.Property(e => e.OId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("O_Id");

                entity.Property(e => e.ProductCategory)
                    .HasMaxLength(255)
                    .HasColumnName("Product_Category");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.PurchasedDate)
                    .IsUnicode(false)
                    .HasColumnName("Purchased_Date");

                entity.Property(e => e.PurchasedTime)
                    .IsUnicode(false)
                    .HasColumnName("Purchased_Time");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblSnapdealMyOrders)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__tbl_Snapd__Produ__7A8729A3");
            });

            modelBuilder.Entity<TblSnapdealOngoingSale>(entity =>
            {
                entity.HasKey(e => e.FlashSaleId)
                    .HasName("PK__tbl_Snap__2292FD6C1203E1FD");

                entity.ToTable("tbl_Snapdeal_OngoingSale");

                entity.Property(e => e.FlashSaleId)
                    .ValueGeneratedNever()
                    .HasColumnName("Flash_Sale_Id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.FId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("F_Id");

                entity.Property(e => e.FlashSalePrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("FlashSale_Price");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductCategory)
                    .HasMaxLength(255)
                    .HasColumnName("Product_Category");

                entity.Property(e => e.ProductDescription).HasColumnName("Product_Description");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ProductNewPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Product_NewPrice");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Product_Price");

                entity.Property(e => e.SaleDate)
                    .IsUnicode(false)
                    .HasColumnName("Sale_Date");

                entity.Property(e => e.SaleEndTime)
                    .IsUnicode(false)
                    .HasColumnName("Sale_End_Time");

                entity.Property(e => e.SaleStartTime)
                    .IsUnicode(false)
                    .HasColumnName("Sale_Start_Time");

                entity.Property(e => e.StockQuantity).HasColumnName("Stock_Quantity");

                entity.Property(e => e.SubcategoryId).HasColumnName("subcategory_id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblSnapdealOngoingSales)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__tbl_Snapd__categ__0AF29B96");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblSnapdealOngoingSales)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__tbl_Snapd__Produ__50C5FA01");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.TblSnapdealOngoingSales)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK__tbl_Snapd__subca__0BE6BFCF");
            });

            modelBuilder.Entity<TblSnapdealProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__tbl_Snap__9834FBBA5B443619");

                entity.ToTable("tbl_Snapdeal_Products");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("Product_Id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(255)
                    .HasColumnName("Category_Name");

                entity.Property(e => e.CategorytypeId).HasColumnName("Categorytype_Id");

                entity.Property(e => e.CategorytypeName)
                    .HasMaxLength(255)
                    .HasColumnName("Categorytype_Name");

                entity.Property(e => e.PId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("P_Id");

                entity.Property(e => e.ProductDescription).HasColumnName("Product_Description");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ProductNewPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Product_NewPrice");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Product_Price");

                entity.Property(e => e.ProductQuantity).HasColumnName("Product_Quantity");

                entity.Property(e => e.ProductRating).HasColumnName("Product_Rating");

                entity.Property(e => e.ProductReviewCount).HasColumnName("Product_Review_Count");

                entity.Property(e => e.SubcategoryId).HasColumnName("subcategory_id");

                entity.Property(e => e.SubcategoryName)
                    .HasMaxLength(255)
                    .HasColumnName("Subcategory_Name");

                entity.Property(e => e.TopCategoryId).HasColumnName("TopCategory_Id");

                entity.Property(e => e.TopCategoryName)
                    .HasMaxLength(255)
                    .HasColumnName("TopCategory_Name");

                entity.HasOne(d => d.Categorytype)
                    .WithMany(p => p.TblSnapdealProducts)
                    .HasForeignKey(d => d.CategorytypeId)
                    .HasConstraintName("FK_CategoryType_Id_New");

                entity.HasOne(d => d.TopCategory)
                    .WithMany(p => p.TblSnapdealProducts)
                    .HasForeignKey(d => d.TopCategoryId)
                    .HasConstraintName("FK_ProductTopCategory_Id");
            });

            modelBuilder.Entity<TblSnapdealProduct1>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__tbl_Snap__B40CC6CDBBD0D36F");

                entity.ToTable("tbl_SnapdealProducts");

                entity.Property(e => e.NewPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProductCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDiscount).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<TblSnapdealRating>(entity =>
            {
                entity.HasKey(e => e.RatingId)
                    .HasName("PK__tbl_Snap__BE48C8457F33237E");

                entity.ToTable("tbl_Snapdeal_Ratings");

                entity.Property(e => e.RatingId)
                    .ValueGeneratedNever()
                    .HasColumnName("Rating_Id");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.RId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("R_Id");

                entity.Property(e => e.Review).IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblSnapdealRatings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__tbl_Snapd__Produ__4DE98D56");
            });

            modelBuilder.Entity<TblSnapdealSubcategory>(entity =>
            {
                entity.HasKey(e => e.SubcategoryId)
                    .HasName("PK__tbl_Snap__B599509CF989021E");

                entity.ToTable("tbl_Snapdeal_Subcategory");

                entity.Property(e => e.SubcategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("Subcategory_Id");

                entity.Property(e => e.CategoryId).HasColumnName("Category_Id");

                entity.Property(e => e.SId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("S_Id");

                entity.Property(e => e.SubcategoryName)
                    .HasMaxLength(255)
                    .HasColumnName("Subcategory_name");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblSnapdealSubcategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__tbl_Snapd__Categ__473C8FC7");
            });

            modelBuilder.Entity<TblSnapdealUpcomingSale>(entity =>
            {
                entity.HasKey(e => e.UpcomingSaleId)
                    .HasName("PK__tbl_Snap__2B4A1512E9953EAD");

                entity.ToTable("tbl_Snapdeal_UpcomingSale");

                entity.Property(e => e.UpcomingSaleId)
                    .ValueGeneratedNever()
                    .HasColumnName("Upcoming_Sale_Id");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Product_Price");

                entity.Property(e => e.SaleDate)
                    .IsUnicode(false)
                    .HasColumnName("Sale_Date");

                entity.Property(e => e.SaleEndTime)
                    .IsUnicode(false)
                    .HasColumnName("Sale_End_Time");

                entity.Property(e => e.SaleStartTime)
                    .IsUnicode(false)
                    .HasColumnName("Sale_Start_Time");

                entity.Property(e => e.UId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("U_Id");

                entity.Property(e => e.UpcomingPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Upcoming_Price");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblSnapdealUpcomingSales)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__tbl_Snapd__Produ__53A266AC");
            });

            modelBuilder.Entity<TblSnapdealUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tbl_Snap__206D9170DBF2BC59");

                entity.ToTable("tbl_Snapdeal_User");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("User_Id");

                entity.Property(e => e.EmailId)
                    .IsUnicode(false)
                    .HasColumnName("Email_Id");

                entity.Property(e => e.Passwords).IsUnicode(false);

                entity.Property(e => e.UId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("U_Id");

                entity.Property(e => e.UserName)
                    .IsUnicode(false)
                    .HasColumnName("User_Name");
            });

            modelBuilder.Entity<TblSnapdealWishList1>(entity =>
            {
                entity.HasKey(e => e.WishListId)
                    .HasName("PK__tbl_Snap__E41F87877B1E295E");

                entity.ToTable("tbl_SnapdealWishList");

                entity.Property(e => e.NewPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProductCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblSnapdealWishList1s)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__tbl_Snapd__Produ__70DDC3D8");
            });

            modelBuilder.Entity<TblSnapdealWishlist>(entity =>
            {
                entity.HasKey(e => e.WishlistId)
                    .HasName("PK__tbl_Snap__C65247E35822D307");

                entity.ToTable("tbl_Snapdeal_Wishlist");

                entity.Property(e => e.WishlistId).HasColumnName("Wishlist_Id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.FlashSaleId).HasColumnName("Flash_Sale_Id");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductCategory)
                    .IsUnicode(false)
                    .HasColumnName("Product_Category");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.ProductName)
                    .IsUnicode(false)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ProductNewPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Product_NewPrice");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Product_Price");

                entity.Property(e => e.ProductQuantity).HasColumnName("Product_Quantity");

                entity.Property(e => e.SubcategoryId).HasColumnName("subcategory_id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblSnapdealWishlists)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__tbl_Snapd__categ__07220AB2");

                entity.HasOne(d => d.FlashSale)
                    .WithMany(p => p.TblSnapdealWishlists)
                    .HasForeignKey(d => d.FlashSaleId)
                    .HasConstraintName("FK__tbl_Snapd__Flash__090A5324");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblSnapdealWishlists)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__tbl_Snapd__Produ__062DE679");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.TblSnapdealWishlists)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK__tbl_Snapd__subca__08162EEB");
            });

            modelBuilder.Entity<TblSnapdealWishlistNew>(entity =>
            {
                entity.HasKey(e => e.WishlistId)
                    .HasName("PK__tbl_Snap__C65247E361D9BB3F");

                entity.ToTable("tbl_Snapdeal_WishlistNew");

                entity.Property(e => e.WishlistId)
                    .ValueGeneratedNever()
                    .HasColumnName("Wishlist_Id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.FlashSaleId).HasColumnName("Flash_Sale_Id");

                entity.Property(e => e.ProductCategory).HasColumnName("Product_Category");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.ProductName).HasColumnName("Product_Name");

                entity.Property(e => e.ProductNewPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Product_NewPrice");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Product_Price");

                entity.Property(e => e.ProductQuantity).HasColumnName("Product_Quantity");

                entity.Property(e => e.SubcategoryId).HasColumnName("subcategory_id");

                entity.Property(e => e.WId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("W_Id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblSnapdealWishlistNews)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__tbl_Snapd__categ__1B29035F");

                entity.HasOne(d => d.FlashSale)
                    .WithMany(p => p.TblSnapdealWishlistNews)
                    .HasForeignKey(d => d.FlashSaleId)
                    .HasConstraintName("FK__tbl_Snapd__Flash__1D114BD1");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblSnapdealWishlistNews)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__tbl_Snapd__Produ__1A34DF26");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.TblSnapdealWishlistNews)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK__tbl_Snapd__subca__1C1D2798");
            });

            modelBuilder.Entity<TblSnapdelCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__tbl_Snap__6DB38D6E938D0356");

                entity.ToTable("tbl_Snapdel_Category");

                entity.Property(e => e.CategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("Category_Id");

                entity.Property(e => e.CId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("C_Id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(255)
                    .HasColumnName("Category_Name");

                entity.Property(e => e.CategorytypeId).HasColumnName("Categorytype_Id");

                entity.HasOne(d => d.Categorytype)
                    .WithMany(p => p.TblSnapdelCategories)
                    .HasForeignKey(d => d.CategorytypeId)
                    .HasConstraintName("FK_CategoryType_Id");
            });

            modelBuilder.Entity<TblSnapdelCategoryType>(entity =>
            {
                entity.HasKey(e => e.CategorytypeId)
                    .HasName("PK__tbl_Snap__794984855DB8E7D8");

                entity.ToTable("tbl_Snapdel_Category_Type");

                entity.Property(e => e.CategorytypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("Categorytype_Id");

                entity.Property(e => e.CategorytypeName)
                    .HasMaxLength(255)
                    .HasColumnName("Categorytype_Name");

                entity.Property(e => e.CtId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CT_Id");

                entity.Property(e => e.TopCategoryId).HasColumnName("TopCategory_Id");

                entity.HasOne(d => d.TopCategory)
                    .WithMany(p => p.TblSnapdelCategoryTypes)
                    .HasForeignKey(d => d.TopCategoryId)
                    .HasConstraintName("FK_TopCategory_Id");
            });

            modelBuilder.Entity<TblSnapdelTopCategory>(entity =>
            {
                entity.HasKey(e => e.TopCategoryId)
                    .HasName("PK__tbl_Snap__3B01B89021B60494");

                entity.ToTable("tbl_Snapdel_TopCategory");

                entity.Property(e => e.TopCategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("TopCategory_Id");

                entity.Property(e => e.TcId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TC_Id");

                entity.Property(e => e.TopCategoryName)
                    .HasMaxLength(255)
                    .HasColumnName("TopCategory_Name");
            });

            modelBuilder.Entity<TblTataCliqBrand>(entity =>
            {
                entity.HasKey(e => e.BrandId)
                    .HasName("PK__Tbl_Tata__DAD4F3BEB1188A97");

                entity.ToTable("Tbl_TataCliq_Brands");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblTataCliqCart>(entity =>
            {
                entity.HasKey(e => e.CartId)
                    .HasName("PK__Tbl_Tata__51BCD7976C61FE86");

                entity.ToTable("Tbl_TataCliq_Cart");

                entity.Property(e => e.CartId).HasColumnName("CartID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblTataCliqCarts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Tbl_TataC__Produ__2116E6DF");
            });

            modelBuilder.Entity<TblTataCliqCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__Tbl_Tata__19093A2B4E9B7F29");

                entity.ToTable("Tbl_TataCliq_Categories");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblTataCliqOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Tbl_Tata__C3905BAF3D4CCA8D");

                entity.ToTable("Tbl_TataCliq_Orders");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CartId).HasColumnName("CartID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModeOfPayment)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.TblTataCliqOrders)
                    .HasForeignKey(d => d.CartId)
                    .HasConstraintName("FK__Tbl_TataC__CartI__23F3538A");

                entity.HasOne(d => d.ShopAddress)
                    .WithMany(p => p.TblTataCliqOrders)
                    .HasForeignKey(d => d.ShopAddressId)
                    .HasConstraintName("FK_Tbl_TataCliq_Orders_ShopAddress");
            });

            modelBuilder.Entity<TblTataCliqProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Tbl_Tata__B40CC6ED28222CC4");

                entity.ToTable("Tbl_TataCliq_Products");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiscountPercentage).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PriceModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.TblTataCliqProducts)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK__Tbl_TataC__Brand__1A69E950");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblTataCliqProducts)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Tbl_TataC__Categ__1B5E0D89");
            });

            modelBuilder.Entity<TblTataCliqShopAddress>(entity =>
            {
                entity.HasKey(e => e.ShopAddressId)
                    .HasName("PK__Tbl_Tata__C55252BF5ADD7B4C");

                entity.ToTable("Tbl_TataCliq_ShopAddress");

                entity.Property(e => e.ShopAddress)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.ShopName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTataCliqUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Tbl_Tata__1788CC4C803E3CD5");

                entity.ToTable("Tbl_TataCliq_User");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.TblTataCliqUsers)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("FK__Tbl_TataC__UserT__22951AFD");
            });

            modelBuilder.Entity<TblTataCliqUserType>(entity =>
            {
                entity.HasKey(e => e.UserTypeId)
                    .HasName("PK__Tbl_Tata__40D2D816EE6803BC");

                entity.ToTable("Tbl_TataCliq_UserType");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.UserType)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTataCliqWishlist>(entity =>
            {
                entity.HasKey(e => e.WishListId)
                    .HasName("PK__Tbl_Tata__0FB381CFE60DA875");

                entity.ToTable("Tbl_TataCliq_Wishlist");

                entity.Property(e => e.WishListId).HasColumnName("WishListID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblTataCliqWishlists)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Tbl_TataC__Produ__1E3A7A34");
            });

            modelBuilder.Entity<TblUpcomingSale>(entity =>
            {
                entity.HasKey(e => e.UsaleId)
                    .HasName("PK__tbl_Upco__EC1455B676CA6C93");

                entity.ToTable("tbl_UpcomingSale");

                entity.Property(e => e.ProductCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDiscount).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(10, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
