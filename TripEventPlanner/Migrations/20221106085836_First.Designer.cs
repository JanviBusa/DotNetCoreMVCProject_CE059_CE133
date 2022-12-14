// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TripEventPlanner.Data;

namespace TripEventPlanner.Migrations
{
    [DbContext(typeof(ItravelPlannerDBContext))]
    [Migration("20221106085836_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TripEventPlanner.Models.Activity", b =>
                {
                    b.Property<short>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("activity_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short?>("ActivityTypeId")
                        .HasColumnType("smallint")
                        .HasColumnName("activityType_id");

                    b.Property<string>("Address")
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("address");

                    b.Property<string>("Description")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("description");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("end_date");

                    b.Property<string>("ImageUrl")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("image_url");

                    b.Property<short?>("LocationId")
                        .HasColumnType("smallint")
                        .HasColumnName("location_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("name");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(7,2)")
                        .HasColumnName("price");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("start_date");

                    b.HasKey("ActivityId");

                    b.HasIndex("ActivityTypeId");

                    b.HasIndex("LocationId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("TripEventPlanner.Models.ActivityType", b =>
                {
                    b.Property<short>("ActivityTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("activityType_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("name");

                    b.HasKey("ActivityTypeId");

                    b.ToTable("ActivityType");
                });

            modelBuilder.Entity("TripEventPlanner.Models.Country", b =>
                {
                    b.Property<short>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("country_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("name");

                    b.HasKey("CountryId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("TripEventPlanner.Models.Location", b =>
                {
                    b.Property<short>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("location_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("CountryId")
                        .HasColumnType("smallint")
                        .HasColumnName("country_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("name");

                    b.HasKey("LocationId");

                    b.HasIndex("CountryId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("TripEventPlanner.Models.Trip", b =>
                {
                    b.Property<short>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("trip_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short?>("CountryId")
                        .HasColumnType("smallint")
                        .HasColumnName("country_id");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("end_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("name");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("start_date");

                    b.Property<short?>("UserId")
                        .HasColumnType("smallint")
                        .HasColumnName("user_id");

                    b.HasKey("TripId");

                    b.HasIndex("CountryId");

                    b.HasIndex("UserId");

                    b.ToTable("Trip");
                });

            modelBuilder.Entity("TripEventPlanner.Models.TripActivity", b =>
                {
                    b.Property<short>("ActivityId")
                        .HasColumnType("smallint")
                        .HasColumnName("activity_id");

                    b.Property<short>("TripId")
                        .HasColumnType("smallint")
                        .HasColumnName("trip_id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("TripId");

                    b.ToTable("TripActivity");
                });

            modelBuilder.Entity("TripEventPlanner.Models.User", b =>
                {
                    b.Property<short>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("user_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .IsUnicode(false)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("password");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TripEventPlanner.Models.Activity", b =>
                {
                    b.HasOne("TripEventPlanner.Models.ActivityType", "ActivityType")
                        .WithMany("Activities")
                        .HasForeignKey("ActivityTypeId")
                        .HasConstraintName("FK_activity_activityType");

                    b.HasOne("TripEventPlanner.Models.Location", "Location")
                        .WithMany("Activities")
                        .HasForeignKey("LocationId")
                        .HasConstraintName("FK_Activity_Location");

                    b.Navigation("ActivityType");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("TripEventPlanner.Models.Location", b =>
                {
                    b.HasOne("TripEventPlanner.Models.Country", "Country")
                        .WithMany("Locations")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK_location_country")
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("TripEventPlanner.Models.Trip", b =>
                {
                    b.HasOne("TripEventPlanner.Models.Country", "Country")
                        .WithMany("Trips")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK_Trip_Country");

                    b.HasOne("TripEventPlanner.Models.User", "User")
                        .WithMany("Trips")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Trip_Users");

                    b.Navigation("Country");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TripEventPlanner.Models.TripActivity", b =>
                {
                    b.HasOne("TripEventPlanner.Models.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("FK_TripActivity_Activity")
                        .IsRequired();

                    b.HasOne("TripEventPlanner.Models.Trip", "Trip")
                        .WithMany()
                        .HasForeignKey("TripId")
                        .HasConstraintName("FK_TripActivity_Trip")
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("TripEventPlanner.Models.ActivityType", b =>
                {
                    b.Navigation("Activities");
                });

            modelBuilder.Entity("TripEventPlanner.Models.Country", b =>
                {
                    b.Navigation("Locations");

                    b.Navigation("Trips");
                });

            modelBuilder.Entity("TripEventPlanner.Models.Location", b =>
                {
                    b.Navigation("Activities");
                });

            modelBuilder.Entity("TripEventPlanner.Models.User", b =>
                {
                    b.Navigation("Trips");
                });
#pragma warning restore 612, 618
        }
    }
}
