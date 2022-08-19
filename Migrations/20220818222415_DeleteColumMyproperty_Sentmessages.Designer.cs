﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TwilioWeb.Data;

namespace TwilioWeb.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220818222415_DeleteColumMyproperty_Sentmessages")]
    partial class DeleteColumMyproperty_Sentmessages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TwilioWeb.Models.TwilioCredentials", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TSID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TTOKEN")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("twilioCredentials");
                });

            modelBuilder.Entity("TwilioWeb.Models.messages", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("datecreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("to_field")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("messagess");
                });

            modelBuilder.Entity("TwilioWeb.Models.sentmessages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("cofirmationcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("messagesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("sentdate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("messagesId");

                    b.ToTable("sentmessagess");
                });

            modelBuilder.Entity("TwilioWeb.Models.sentmessages", b =>
                {
                    b.HasOne("TwilioWeb.Models.messages", "messages")
                        .WithMany()
                        .HasForeignKey("messagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("messages");
                });
#pragma warning restore 612, 618
        }
    }
}