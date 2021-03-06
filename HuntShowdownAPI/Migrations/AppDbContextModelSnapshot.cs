// <auto-generated />
using HuntShowdownAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HuntShowdownAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HuntShowdownAPI.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Ammunition")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ammunition");

                    b.Property<string>("Capacity")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("capacity");

                    b.Property<string>("Cost")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("cost");

                    b.Property<int>("Damage")
                        .HasColumnType("integer")
                        .HasColumnName("damage");

                    b.Property<string>("EffectiveRange")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("effective_range");

                    b.Property<string>("Handling")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("handling");

                    b.Property<int>("HeavyMeleeDamage")
                        .HasColumnType("integer")
                        .HasColumnName("heavy_melee_damage");

                    b.Property<int>("MeleeDamage")
                        .HasColumnType("integer")
                        .HasColumnName("melee_damage");

                    b.Property<string>("MuzzleVelocity")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("muzzle_velocity");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("RateOfFire")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("rate_of_fire");

                    b.Property<string>("ReloadSpeed")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("reload_speed");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("slug");

                    b.Property<string>("UnlockCondition")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("unlock_condition");

                    b.HasKey("Id")
                        .HasName("pk_weapons");

                    b.ToTable("weapons", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
