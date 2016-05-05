using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using AppsPortal.Models;

namespace AppsPortal.Migrations
{
    [DbContext(typeof(AppsContext))]
    partial class AppsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppsPortal.Models.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("PromotionVideoUrl");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("AppsPortal.Models.Release", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ApplicationId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Details");

                    b.Property<int>("Order");

                    b.Property<string>("Version");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("AppsPortal.Models.Release", b =>
                {
                    b.HasOne("AppsPortal.Models.Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId");
                });
        }
    }
}
