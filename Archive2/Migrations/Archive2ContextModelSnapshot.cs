﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using modelfor_archive.Models;

namespace Archive2.Migrations
{
    [DbContext(typeof(Archive2Context))]
    partial class Archive2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Archive2.Models.RemoveUser", b =>
                {
                    b.Property<int>("RemoveUserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcadMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RemoveUserID");

                    b.ToTable("RemoveUsers");
                });

            modelBuilder.Entity("modeforview2.Models.ListUserMes", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("MessageId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "MessageId");

                    b.HasIndex("MessageId");

                    b.ToTable("ListUserMes");
                });

            modelBuilder.Entity("modelfor_archive.Models.Attachment", b =>
                {
                    b.Property<int>("AttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AttDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AttFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MessageId")
                        .HasColumnType("int");

                    b.HasKey("AttachmentId");

                    b.HasIndex("MessageId");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("modelfor_archive.Models.Messages", b =>
                {
                    b.Property<int>("MessagesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MessageAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageDestination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Rcv")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("RcvTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Seen")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("SendDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("MessagesId");

                    b.HasIndex("UserId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("modelfor_archive.Models.UserAcc", b =>
                {
                    b.Property<int>("UserAccID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcadMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userGender")
                        .HasColumnType("int");

                    b.HasKey("UserAccID");

                    b.ToTable("UserAccs");
                });

            modelBuilder.Entity("modeforview2.Models.ListUserMes", b =>
                {
                    b.HasOne("modelfor_archive.Models.Messages", "Message")
                        .WithMany("ListUserMes")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("modelfor_archive.Models.UserAcc", "User")
                        .WithMany("ListUserMes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");

                    b.Navigation("User");
                });

            modelBuilder.Entity("modelfor_archive.Models.Attachment", b =>
                {
                    b.HasOne("modelfor_archive.Models.Messages", "Message")
                        .WithMany("Attachments")
                        .HasForeignKey("MessageId");

                    b.Navigation("Message");
                });

            modelBuilder.Entity("modelfor_archive.Models.Messages", b =>
                {
                    b.HasOne("modelfor_archive.Models.UserAcc", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("modelfor_archive.Models.Messages", b =>
                {
                    b.Navigation("Attachments");

                    b.Navigation("ListUserMes");
                });

            modelBuilder.Entity("modelfor_archive.Models.UserAcc", b =>
                {
                    b.Navigation("ListUserMes");

                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
