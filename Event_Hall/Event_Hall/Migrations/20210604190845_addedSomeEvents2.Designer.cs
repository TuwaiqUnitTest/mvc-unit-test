﻿// <auto-generated />
using Event_Hall.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Event_Hall.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210604190845_addedSomeEvents2")]
    partial class addedSomeEvents2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Event_Hall.Models.AttendeeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("Field")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Attendees");

                    b.HasData(
                        new
                        {
                            Id = 13,
                            Email = "reema@gmail.com",
                            EventId = 1,
                            Field = "IT",
                            Name = "Reema Alyousef",
                            Phone = 547722199
                        },
                        new
                        {
                            Id = 7,
                            Email = "hala@gmail.com",
                            EventId = 2,
                            Field = "Business",
                            Name = "Hala Alyousef",
                            Phone = 554124771
                        },
                        new
                        {
                            Id = 4,
                            Email = "durrdurr@gmail.com",
                            EventId = 2,
                            Field = "Marketing",
                            Name = "Dorrah Alsaad",
                            Phone = 532121731
                        },
                        new
                        {
                            Id = 77,
                            Email = "toto@gmail.com",
                            EventId = 1,
                            Field = "IT",
                            Name = "Batool Alghamdi",
                            Phone = 554777892
                        },
                        new
                        {
                            Id = 12,
                            Email = "raneeeen@gmail.com",
                            EventId = 1,
                            Field = "IT",
                            Name = "Raneen Alzafrani",
                            Phone = 532120193
                        },
                        new
                        {
                            Id = 10,
                            Email = "spurofthemoment@gmail.com",
                            EventId = 1,
                            Field = "IT",
                            Name = "Sameera Alhussainy",
                            Phone = 556110112
                        },
                        new
                        {
                            Id = 407,
                            Email = "noura407@gmail.com",
                            EventId = 3,
                            Field = "Health",
                            Name = "Noura Aldossary",
                            Phone = 533172134
                        },
                        new
                        {
                            Id = 1,
                            Email = "njxx@gmail.com",
                            EventId = 3,
                            Field = "Health",
                            Name = "Nujood Alyousef",
                            Phone = 547712397
                        },
                        new
                        {
                            Id = 2,
                            Email = "lia@gmail.com",
                            EventId = 3,
                            Field = "Health",
                            Name = "Lama Alyousef",
                            Phone = 551212432
                        },
                        new
                        {
                            Id = 666,
                            Email = "waz@gmail.com",
                            EventId = 2,
                            Field = "Biology",
                            Name = "Wedad Alzamil",
                            Phone = 555612127
                        });
                });

            modelBuilder.Entity("Event_Hall.Models.EventModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Duration")
                        .HasColumnType("text");

                    b.Property<int>("HallId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PresentorId")
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HallId")
                        .IsUnique();

                    b.HasIndex("PresentorId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1000,
                            Description = "To lose our jobs to our future supreme AI overlords ... or to not? That's the question (and we have some surprising answers).",
                            Duration = "2 Hours",
                            HallId = 3,
                            Image = "https://pi.tedcdn.com/r/talkstar-assets.s3.amazonaws.com/production/playlists/playlist_642/2437dd5f-4efd-40e9-a417-8c9d879ac9ea/What-happens-after-robots-take-our-jobs_1200x627+(1).jpg?quality=89&w=1200",
                            Name = "What happens when the robots take our jobs?",
                            PresentorId = 10,
                            Time = "Friday, June 4, 2021 8:30:00 PM"
                        },
                        new
                        {
                            Id = 9999,
                            Description = "In 2014, the world avoided a global outbreak of Ebola, thanks to thousands of selfless health workers -- plus, frankly, some very good luck. In hindsight, we know what we should have done better. So, now's the time, MJ suggests, to put all our good ideas into practice, from scenario planning to vaccine research to health worker training. As he says, There's no need to panic ... but we need to get going.",
                            Duration = "3 Hours",
                            HallId = 2,
                            Image = "https://www.gard.no/Content/29112072/cache=20203101143212/Coronavirus_people.jpg",
                            Name = "The Next Outbreak? We're Not Ready",
                            PresentorId = 665,
                            Time = "Friday, August 1, 2021 7:30:00 PM"
                        },
                        new
                        {
                            Id = 111111,
                            Description = "Reema Alyousef knows that procrastination doesn't make sense, but she's never been able to shake her habit of waiting until the last minute to get things done. In this hilarious and insightful talk, Reema takes us on a journey through YouTube binges, Gaming rabbit holes and bouts of staring out the window -- and encourages us to think harder about what we're really procrastinating on, before we run out of time.",
                            Duration = "3 Hours",
                            HallId = 1,
                            Image = "https://cdn.substack.com/image/fetch/f_auto,q_auto:good,fl_progressive:steep/https%3A%2F%2Fbucketeer-e05bbc84-baa3-437e-9518-adb32be77984.s3.amazonaws.com%2Fpublic%2Fimages%2F3586ad3c-6847-457a-ba75-b3f5d4e6d46a_1920x1080.png",
                            Name = "Inside the Mind of a Master Procrastinator",
                            PresentorId = 13,
                            Time = "Friday, August 16, 2021 6:30:00 PM"
                        });
                });

            modelBuilder.Entity("Event_Hall.Models.HallModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Avaliability")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Halls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Avaliability = true,
                            Capacity = 50,
                            Name = "First Venue"
                        },
                        new
                        {
                            Id = 2,
                            Avaliability = false,
                            Capacity = 200,
                            Name = "Main Hall"
                        },
                        new
                        {
                            Id = 3,
                            Avaliability = true,
                            Capacity = 1000,
                            Name = "Conference Hall "
                        });
                });

            modelBuilder.Entity("Event_Hall.Models.PresentorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Field")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Presentors");

                    b.HasData(
                        new
                        {
                            Id = 10,
                            Email = "spurofthemoment@gmail.com",
                            Field = "IT",
                            Name = "Sameera Alhussainy",
                            Phone = 556110112
                        },
                        new
                        {
                            Id = 2,
                            Email = "ceo@tesla.com",
                            Field = "Business",
                            Name = "Elon Musk",
                            Phone = 556123123
                        },
                        new
                        {
                            Id = 665,
                            Email = "mj@gmail.com",
                            Field = "Health",
                            Name = "Michael Jackson",
                            Phone = 522666987
                        },
                        new
                        {
                            Id = 1,
                            Email = "hanan@gmail.com",
                            Field = "Gaming",
                            Name = "Hanan Alhakami",
                            Phone = 598644222
                        },
                        new
                        {
                            Id = 100,
                            Email = "hala@galaxybrain.com",
                            Field = "Bullshit",
                            Name = "Hala Alyousef",
                            Phone = 522441234
                        },
                        new
                        {
                            Id = 333,
                            Email = "reema@galaxybrain.com",
                            Field = "Divine Philosophy",
                            Name = "Reema Alyousef",
                            Phone = 547722199
                        });
                });

            modelBuilder.Entity("Event_Hall.Models.AttendeeModel", b =>
                {
                    b.HasOne("Event_Hall.Models.EventModel", "Event")
                        .WithMany("Attendees")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Event_Hall.Models.EventModel", b =>
                {
                    b.HasOne("Event_Hall.Models.HallModel", "Hall")
                        .WithOne("Event")
                        .HasForeignKey("Event_Hall.Models.EventModel", "HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Event_Hall.Models.PresentorModel", "Presentor")
                        .WithMany("Events")
                        .HasForeignKey("PresentorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
