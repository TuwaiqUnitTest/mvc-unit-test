using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Paradise.Models;

namespace Paradise.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //Fluent Api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //seeding

            modelBuilder.Entity<Flower>()
                .HasData(new Flower
                { ID =1, Image= "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/pink-dahlias-royalty-free-image-513204805-1562778270.jpg?crop=0.445xw:1.00xh;0.450xw,0&resize=980:*",
                 Name="Dahlias", Tempreture= "20°–22°C"
                });

            modelBuilder.Entity<Flower>()
               .HasData(new Flower
               {
                   ID = 2,
                   Image = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/cornflowers-royalty-free-image-104696040-1562778695.jpg?crop=0.445xw:1.00xh;0.386xw,0&resize=980:*",
                   Name = "Cornflower",
                   Tempreture = "15°-26°C"
               });

            modelBuilder.Entity<Flower>()
             .HasData(new Flower
             {
                 ID = 3,
                 Image = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/cosmos-flowers-royalty-free-image-184971248-1562779148.jpg?crop=0.445xw:1.00xh;0.382xw,0&resize=980:*",
                 Name = "Cosmos",
                 Tempreture = "16°C"
             });

            modelBuilder.Entity<Flower>()
             .HasData(new Flower
             {
                 ID = 4,
                 Image = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/verbena-royalty-free-image-471346036-1562778134.jpg?crop=0.445xw:1.00xh;0.439xw,0&resize=980:*",
                 Name = "Verbena",
                 Tempreture = "15°C"
             });

            modelBuilder.Entity<Flower>()
             .HasData(new Flower
             {
                 ID = 5,
                 Image = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/colchicum-autumnale-autumn-crocus-1532630291.jpg?crop=0.4449685534591195xw:1xh;center,top&resize=980:*",
                 Name = "Colchicum",
                 Tempreture = "20°-25°C"
             });

            modelBuilder.Entity<Flower>()
             .HasData(new Flower
             {
                 ID = 6,
                 Image = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/purple-aster-daisies-1532630286.jpg?crop=0.447xw:1.00xh;0.366xw,0&resize=980:*",
                 Name = "Asters",
                 Tempreture = "16°–17°C"
             });

            //insert plants

           modelBuilder.Entity<Plant>()
         .HasData(new Plant
         {
             ID = 1 ,
             Image = "https://images.unsplash.com/photo-1598880940080-ff9a29891b85?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1yZWxhdGVkfDF8fHxlbnwwfHx8fA%3D%3D&auto=format&fit=crop&w=700&q=60",
             Name = "Pothos",
             Tempreture = "15°-29°C"
         });

          modelBuilder.Entity<Plant>()
         .HasData(new Plant
         {
             ID = 2,
             Image = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1603654887-1427228256-chinese-evergreen-plants-little-water.jpg?crop=0.970xw:0.974xh;0.0208xw,0.0161xh&resize=768:*",
             Name = "Aglaonema",
             Tempreture = "18°-24°C"
         });

          modelBuilder.Entity<Plant>()
         .HasData(new Plant
         {
             ID = 3,
             Image = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1603654852-jade-plant-1589561938.jpg?crop=0.6677678150070788xw:1xh;center,top&resize=768:*",
             Name = "Jade Plant",
             Tempreture = "18°-24°C"
         });

          modelBuilder.Entity<Plant>()
         .HasData(new Plant
         {
             ID = 4,
             Image = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1557177323-pilea-peperomioides-money-plant-in-the-pot-single-royalty-free-image-917778022-1557177295.jpg?crop=1.00xw:0.668xh;0,0.269xh&resize=768:*",
             Name = "Chinese Money Plant",
             Tempreture = "13°-30°C "
         });

          modelBuilder.Entity<Plant>()
         .HasData(new Plant
         {
             ID = 5,
             Image = "https://images.unsplash.com/photo-1484885192048-9696607347da?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1yZWxhdGVkfDF8fHxlbnwwfHx8fA%3D%3D&auto=format&fit=crop&w=700&q=60",
             Name = "Aloe",
             Tempreture = "13°-27°C"
         });

          modelBuilder.Entity<Plant>()
         .HasData(new Plant
         {
             ID = 6,
             Image = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1557255932-the-sill-potted-plant-calathea-medallion-prospect-black-7-1500x-progressive-1557255913.jpg?crop=1.00xw:0.774xh;0,0.174xh&resize=768:*",
             Name = "Calathea",
             Tempreture = "15°-23°C "
         });


            modelBuilder.Entity<CareFlower>()
     .HasData(new CareFlower
     {
         ID = 1,
         FlowerId = 1,
         LevelCare = "Easy",
         Place = "indoors",
         Size = "6 to 8 inches"

     });
            modelBuilder.Entity<CareFlower>()
        .HasData(new CareFlower
        {
            ID = 2,
            FlowerId = 2,
            LevelCare = "Easy",
            Place = "outdoors",
            Size = "6 to 9 inches"

        });

                        modelBuilder.Entity<CareFlower>()
          .HasData(new CareFlower
          {
              ID=3,
              FlowerId=3,
              LevelCare="Easy",
              Place="indoors",
              Size= "3 to 4 inches"

          });

                        modelBuilder.Entity<CareFlower>()
          .HasData(new CareFlower
          {
              ID=4,
              FlowerId=4,
              LevelCare="Hard",
              Place="outdoors",
              Size= "12 inches"

          });

                        modelBuilder.Entity<CareFlower>()
          .HasData(new CareFlower
          {
              ID=5,
              FlowerId=5,
              LevelCare="Medium",
              Place="outdoor",
              Size= "3 to 5 inches"

          });

                        modelBuilder.Entity<CareFlower>()
          .HasData(new CareFlower
          {
              ID=6,
              FlowerId=6,
              LevelCare="Medium",
              Place="outdoors",
              Size= "2 to 3 inches"

          });

                        modelBuilder.Entity<CarePlant>()
          .HasData(new CarePlant
          {
              ID=1,
              PlantId=1,
              LevelCare="Easy",
              Place="indoors",
              Size= "12 inches"

          });

                                 modelBuilder.Entity<CarePlant>()
          .HasData(new CarePlant
          {
              ID=2,
              PlantId=2,
              LevelCare="Easy",
              Place="indoors",
              Size= "14 inches"

          });

                                 modelBuilder.Entity<CarePlant>()
          .HasData(new CarePlant
          {
              ID=3,
              PlantId=3,
              LevelCare="Easy",
              Place="indoors",
              Size= "12 to 14 inches"

          });

                                 modelBuilder.Entity<CarePlant>()
          .HasData(new CarePlant
          {
              ID=4,
              PlantId=4,
              LevelCare="Easy",
              Place="indoors",
              Size= "8 to 12 inches"

          });

                                 modelBuilder.Entity<CarePlant>()
          .HasData(new CarePlant
          {
              ID=5,
              PlantId=5,
              LevelCare="Easy",
              Place= "indoors",
              Size= "12 to 24 inches"

          });

                                 modelBuilder.Entity<CarePlant>()
          .HasData(new CarePlant
          {
              ID=6,
              PlantId=6,
              LevelCare="Medium",
              Place="outdoors",
              Size= "20 inches"

          });

            modelBuilder.Entity<Comment>()
          .HasData(new Comment
          {
           ID=1,
           FlowerId=2,
           Message= "Cornflower: You'll love these bright-blue beauties as much as the birds and butterflies do."

          });


                  modelBuilder.Entity<Comment>()
          .HasData(new Comment
          {
              ID = 2,
              FlowerId = 4,
              Message = "Verbena: These tiny beauties flower profusely until first frost, brightening beds, borders, and hanging baskets even in part shade. They'll even tolerate the hot, dry summer days in the South leading up to a cooler fall."
          });

                 modelBuilder.Entity<Comment>()
          .HasData(new Comment
          {
              ID = 3,
              FlowerId = 5,
              Message = "Colchicum: You might know colchicum by its other name: autumn crocus. As you would expect, they do bloom between August and September, but without any foliage. The leaves only appear in the spring before dying back."

          });

               modelBuilder.Entity<Comment>()
          .HasData(new Comment
          {
              ID = 4,
              PlantId =2 ,
              Message = @"Aglaonema: If you're more of a waterer, an excellent plant is a Chinese evergreen,Fried says.Aglaonema can withstand excess H2O,
              and it comes in a spectrum of colors,
              including green,
              pink,
              white,
              and red."

          });
                    modelBuilder.Entity<Comment>()
          .HasData(new Comment
          {
              ID = 5,
              PlantId =4 ,
              Message = "Chinese Money Plant: Pilea peperomioides grows best in a shady spot (or winter windowsill) with weekly watering, according to The Little Book of House Plants and Other Greenery."

          });

                   modelBuilder.Entity<Comment>()
          .HasData(new Comment
          {
              ID = 6,
              PlantId =4 ,
              Message = "Chinese Money Plant: grows best in a shady spot (or winter windowsill)"

          });









        }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CareFlower> CareFlower { get; set; }
        public DbSet<CarePlant> CarePlant { get; set; }




    }

}



