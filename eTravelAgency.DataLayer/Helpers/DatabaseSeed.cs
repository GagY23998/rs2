using eTravelAgency.Core.Models;
using eTravelAgency.DataLayer.Data;
using eTravelAgency.DataLayer.Services;
using eTravelAgency.Model.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace eTravelAgency.DataLayer.Helpers
{
    public static class DatabaseSeed
    {
        public static bool dataSeeded = false;
        public static void SeedDatabase(eTravelContext context)
        {

            context.Database.EnsureCreated();
            if (!context.Users.Any())
            {
                string path = @"C:\Users\User\Desktop\Pics\";
                var extensions = new string[] { ".png", ".jpg" };
                var images = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                    .Where(file => extensions.Contains(Path.GetExtension(file.ToLower()))).Select(result =>
                        File.ReadAllBytes(result)
                        ).ToList();

                List<byte[]> thumbnails = new List<byte[]>();
                for (int i = 0; i < images.Count; i++)
                {
                    Bitmap myImage = null;
                    using (var ms = new MemoryStream(images[i]))
                    {
                        var img = Image.FromStream(ms);
                        myImage =new Bitmap(img,400,400);
                    }
                    using (var newStream = new MemoryStream())
                    {
                        myImage.Save(newStream,ImageFormat.Png);
                        thumbnails.Add(newStream.ToArray());
                    }
                }


                var salt =UserService.GenerateSalt();
                var hash = UserService.GenerateHash(salt, "test");

                context.Users.Add(new User
                {
                    FirstName = "Admin",
                    LastName = "Admin",
                    UserName = "mobile",
                    Phone = "123-456-789",
                    Email = "admin@admin.com",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                });
                context.SaveChanges();
                context.Roles.AddRange(new Role { Name = "Admin" }, new Role {Name ="User" });
                context.UserRoles.Add(new UserRoles
                {
                    RoleId =1,
                    UserId=1
                });
                context.SaveChanges();
                context.Users.Add(new User
                {
                    FirstName = "Admin",
                    LastName = "Admin",
                    UserName = "desktop",
                    Phone = "123-456-789",
                    Email = "admin@admin.com",
                    PasswordSalt = salt,
                    PasswordHash = hash,
                });
                context.SaveChanges();
                context.UserRoles.Add(new UserRoles { RoleId = 1, UserId = 2 });
                context.SaveChanges();
                for (int i = 0; i < 4; i++)
                {
                    string tempsalt = UserService.GenerateSalt();
                    context.Users.Add(new User
                    {
                        FirstName = "Test" + i.ToString(),
                        LastName = "Test" + i.ToString(),
                        UserName = "Test" + i.ToString(),
                        Picture = images[i],
                        Phone = "123-456-789",
                        Email = "test@test.com",
                        PasswordSalt = tempsalt,
                        PasswordHash = UserService.GenerateHash(tempsalt,UserService.GenerateHash(tempsalt,"testtest"))
                    });
                    context.SaveChanges();
                }


                context.Countries.AddRange(
                    new Country { Picture=images[39],CountryName = "Brazil", CountryDetails="Beautiful Country, really beautiful"},
                    new Country { Picture=images[40],CountryName = "Italy", CountryDetails="La Costa Nostra, Arrivederci, Ciao"},
                    new Country { Picture=images[41],CountryName = "China", CountryDetails="Country of buddhism, Chin chung chin"},
                    new Country { Picture=images[42],CountryName = "Japan",CountryDetails= "Omoshiro, orekerashiana , konichiiwa"}
                );
                context.SaveChanges();
                context.Cities.AddRange(
                    new City { CountryId=1,Picture=thumbnails[15],CityName="Rio De Janerio",ZipCode ="0001"},
                    new City { CountryId=1,Picture=thumbnails[16],CityName="Sao Paolo",ZipCode="0002"},
                    new City { CountryId=2,Picture=thumbnails[17],CityName="Rome",ZipCode="1001"},
                    new City { CountryId=2,Picture=thumbnails[18],CityName="Venezia",ZipCode="1002"},
                    new City { CountryId=3,Picture=thumbnails[19],CityName="Shangai",ZipCode="2001"},
                    new City { CountryId=3,Picture=thumbnails[20],CityName="Bejing",ZipCode="2002"},
                    new City { CountryId=4,Picture=thumbnails[21],CityName="Tokyo",ZipCode="3001"},
                    new City { CountryId=4,Picture=thumbnails[22],CityName="Osaka",ZipCode="3002"}
                    );
                context.SaveChanges();
                context.Attractions.AddRange(
                    new Attraction { CityId=1 ,AttractionName="Attraction1",Picture=images[30],ThumbnailImage=thumbnails[30],AttractionDetails="Attraction Details 1 lorem ipsum doloret colocit"},
                    new Attraction { CityId=1 ,AttractionName="Attraction2",Picture=images[31],ThumbnailImage=thumbnails[31],AttractionDetails="Attraction Details 2 lorem ipsum doloret colocit"},
                    new Attraction { CityId=2 ,AttractionName="Attraction3",Picture=images[32],ThumbnailImage=thumbnails[32],AttractionDetails="Attraction Details 3 lorem ipsum doloret colocit"},
                    new Attraction { CityId=2 ,AttractionName="Attraction4",Picture=images[33],ThumbnailImage=thumbnails[33],AttractionDetails="Attraction Details 4 lorem ipsum doloret colocit"},
                    new Attraction { CityId=3 ,AttractionName="Attraction5",Picture=images[34],ThumbnailImage=thumbnails[34],AttractionDetails="Attraction Details 5 lorem ipsum doloret colocit"},
                    new Attraction { CityId=3 ,AttractionName="Attraction6",Picture=images[35],ThumbnailImage=thumbnails[35],AttractionDetails="Attraction Details 6 lorem ipsum doloret colocit"},
                    new Attraction { CityId=4 ,AttractionName="Attraction7",Picture=images[36],ThumbnailImage=thumbnails[36],AttractionDetails="Attraction Details 7 lorem ipsum doloret colocit"},
                    new Attraction { CityId=5 ,AttractionName="Attraction8",Picture=images[37],ThumbnailImage=thumbnails[37],AttractionDetails="Attraction Details 8 lorem ipsum doloret colocit"},
                    new Attraction { CityId=6 ,AttractionName="Attraction9",Picture=images[38],ThumbnailImage=thumbnails[38],AttractionDetails="Attraction Details 9 lorem ipsum doloret colocit"}
                    );
                context.SaveChanges();
                //context.RoomTypes.AddRange(
                //    new RoomType { NumberOfPeople=1,RoomTypeName="Single"},
                //    new RoomType { NumberOfPeople=2,RoomTypeName="Double"},
                //    new RoomType { NumberOfPeople=3,RoomTypeName="Triple"},
                //    new RoomType { NumberOfPeople=4,RoomTypeName="Quad"}
                //    );
                //context.SaveChanges();
                //context.HotelRooms.AddRange(
                //    new HotelRooms { HotelId = 1,Price=50.53f,Active = true, Available=10,NumberOfRooms=10,RoomTypeId=1},
                //    new HotelRooms { HotelId = 1,Price=85.50f,Active = true, Available=15,NumberOfRooms=15,RoomTypeId=2},
                //    new HotelRooms { HotelId = 1,Price=21.90f,Active = true, Available=10,NumberOfRooms=10,RoomTypeId=3},
                //    new HotelRooms { HotelId = 2,Price=143.90f,Active = true, Available=8,NumberOfRooms = 8, RoomTypeId = 1 },
                //    new HotelRooms { HotelId = 2,Price=100.20f,Active = true, Available=12,NumberOfRooms = 12, RoomTypeId = 2 },
                //    new HotelRooms { HotelId = 2,Price=28.9f,Active = true, Available=15,NumberOfRooms = 15, RoomTypeId = 3 },
                //    new HotelRooms { HotelId = 2,Price=39.32f,Active = true, Available=5, NumberOfRooms = 5, RoomTypeId = 4 }
                //    );
                //context.SaveChanges();
                context.Hotels.AddRange(
                    new Hotel { CityId=6,Picture=images[10],HotelName="Tokyo Hotel",HotelAddress="Tokyo 1st Street"},
                    new Hotel { CityId=2,Picture=images[11],HotelName="Sao Paolo Residences",HotelAddress="Rio De 1streetero"},//check
                    new Hotel { CityId=3,Picture=images[13],HotelName="Shangai Stars Hotel",HotelAddress="Shangai 430 28street"},
                    new Hotel { CityId=4,Picture=images[14],HotelName="Hotel 2",HotelAddress="Beach Resort 430 28",Rating=3.1f},
                    new Hotel { CityId=5,Picture=images[15],HotelName="Hotel 3",HotelAddress="Dream 430 19th street",Rating=3.9f},
                    new Hotel { CityId=5,Picture=images[15],HotelName="Hotel 4",HotelAddress="Dream 430 19th street",Rating=4.5f},
                    new Hotel { CityId=7,Picture=images[16],HotelName="Hotel 5",HotelAddress="Residence 430 ",Rating=4.1f},
                    new Hotel { CityId=7,Picture=images[16],HotelName="Hotel Tokyo 1",HotelAddress="Residence 431 ",Rating=4},
                    new Hotel { CityId=7,Picture=images[19],HotelName="Hotel Tokyo 2",HotelAddress="Residence 432 ",Rating=4.5f},
                    new Hotel { CityId=7,Picture=images[21],HotelName="Hotel Tokyo 3",HotelAddress="Residence 433 ",Rating=4.9f},
                    new Hotel { CityId=6,Picture=images[17],HotelName="Hotel 6",HotelAddress="Hotel 4 stars",Rating=2.3f},
                    new Hotel { CityId=1,Picture=images[17],HotelName="Hotel 1",HotelAddress="Hotel 1 stars",Rating=3.8f}

                    );
                context.SaveChanges();
                context.HotelOffers.AddRange(
                    new HotelOffer { HotelId = 1,PricePerPerson=15.50f,ThumbnailImage=thumbnails[10],IsActive = true, Discount = 10, StartDate = DateTime.Now, EndDate = new DateTime(2019, 12, 29)},
                    new HotelOffer { HotelId = 2,PricePerPerson=35,ThumbnailImage=thumbnails[11],IsActive = true, Discount = 20, StartDate = DateTime.Now, EndDate = new DateTime(2019, 12, 29)},//check
                    new HotelOffer { HotelId = 3,PricePerPerson=31.3f, ThumbnailImage=thumbnails[12],IsActive = true, Discount = 8, StartDate = DateTime.Now, EndDate = new DateTime(2019, 12, 29)},
                    new HotelOffer { HotelId = 5,PricePerPerson=82.16f, ThumbnailImage=thumbnails[13],IsActive = true, Discount = 15, StartDate = DateTime.Now, EndDate = new DateTime(2019, 12, 29)},
                    new HotelOffer { HotelId = 6,PricePerPerson=61.21f, ThumbnailImage=thumbnails[14],IsActive = true, Discount = 10, StartDate = DateTime.Now, EndDate = new DateTime(2019, 12, 31)},
                    new HotelOffer { HotelId = 7,PricePerPerson=38.99f, ThumbnailImage=thumbnails[15],IsActive = true, Discount = 20, StartDate = DateTime.Now, EndDate = new DateTime(2019, 12, 29)},
                    new HotelOffer { HotelId = 8,PricePerPerson=49.21f, ThumbnailImage=thumbnails[16],IsActive = true, Discount = 10, StartDate = DateTime.Now, EndDate = new DateTime(2019, 12, 29)},
                    new HotelOffer { HotelId = 9,PricePerPerson=89.24f, ThumbnailImage=thumbnails[17],IsActive = true, Discount = 30, StartDate = DateTime.Now, EndDate = new DateTime(2019, 12, 29)},
                    new HotelOffer { HotelId = 10,PricePerPerson=29.31f, ThumbnailImage=thumbnails[17],IsActive = true, Discount = 30, StartDate = DateTime.Now, EndDate = new DateTime(2019, 12, 29)},
                    new HotelOffer { HotelId = 11,PricePerPerson=12.21f, ThumbnailImage=thumbnails[17],IsActive = true, Discount = 30, StartDate = DateTime.Now, EndDate = new DateTime(2019, 12, 29)},
                    new HotelOffer { HotelId = 4,PricePerPerson=12.21f, ThumbnailImage=thumbnails[17],IsActive = true, Discount = 30, StartDate = DateTime.Now, EndDate = new DateTime(2019, 12, 29)},
                    new HotelOffer { HotelId = 12,PricePerPerson=12.21f, ThumbnailImage=thumbnails[17],IsActive = true, Discount = 30, StartDate = DateTime.Now, EndDate = new DateTime(2019, 12, 29)}

                );
                context.SaveChanges();
                context.TransportTypes.AddRange(
                    new TransportType { TransportTypeName="Airplane"},
                    new TransportType { TransportTypeName="Bus"},
                    new TransportType { TransportTypeName="Boat"}
                    );
                context.SaveChanges();
                context.TransportCompanies.AddRange(
                    new TransportCompany { IsActive = true, Picture=images[0],TransportCompanyName = "BIH Airlines", TransportTypeId = 1 },
                    new TransportCompany { IsActive = true, Picture=images[1],TransportCompanyName = "Turkish Airlines", TransportTypeId = 1 },
                    new TransportCompany { IsActive = true, Picture=images[2],TransportCompanyName = "EuropeTours", TransportTypeId = 2 },
                    new TransportCompany { IsActive = true, Picture=images[3],TransportCompanyName = "CityTours", TransportTypeId = 2 },
                    new TransportCompany { IsActive = true, Picture=images[4],TransportCompanyName = "EuroCruiser", TransportTypeId = 3 },
                    new TransportCompany { IsActive = true, Picture=images[5],TransportCompanyName = "CruiseAsia", TransportTypeId = 3 }
                    );
                context.SaveChanges();

                context.TransportOffers.AddRange(
                    new TransportOffer { TransportCompanyId =1,CityId= 1,ThumbnailImage=thumbnails[0],IsActive=true,StartDate= new DateTime(2019,2,12),EndDate=DateTime.Now.AddDays(10),Discount=10,Price=4000},
                    new TransportOffer { TransportCompanyId =2,CityId= 2,ThumbnailImage=thumbnails[1],IsActive=true,StartDate= new DateTime(2019,3,12),EndDate=DateTime.Now.AddDays(12),Discount=20,Price=3500.50f},//check
                    new TransportOffer { TransportCompanyId =3,CityId= 3,ThumbnailImage=thumbnails[2],IsActive=true,StartDate= new DateTime(2019,3,12),EndDate=DateTime.Now.AddDays(13),Discount=20,Price=1200},
                    new TransportOffer { TransportCompanyId =2,CityId= 2,ThumbnailImage=thumbnails[3],IsActive=true,StartDate= new DateTime(2019,3,12),EndDate=DateTime.Now.AddDays(15),Discount=20,Price=1150.50f},
                    new TransportOffer { TransportCompanyId =1,CityId= 6,ThumbnailImage=thumbnails[4],IsActive=true,StartDate= new DateTime(2019,3,12),EndDate=DateTime.Now.AddDays(-2),Discount=20,Price=450.50f},
                    new TransportOffer { TransportCompanyId =4,CityId= 6,ThumbnailImage=thumbnails[5],IsActive=true,StartDate= new DateTime(2019,3,12),EndDate=DateTime.Now.AddDays(21),Discount=20,Price=1050.50f},
                    new TransportOffer { TransportCompanyId =1,CityId= 7,ThumbnailImage=thumbnails[6],IsActive=true,StartDate= new DateTime(2019,3,12),EndDate=DateTime.Now.AddDays(2),Discount=20,Price=770.50f},
                    new TransportOffer { TransportCompanyId =4,CityId= 4,ThumbnailImage=thumbnails[6],IsActive=true,StartDate= new DateTime(2019,3,12),EndDate=DateTime.Now.AddDays(9),Discount=20,Price=420.50f},
                    new TransportOffer { TransportCompanyId =2,CityId= 5,ThumbnailImage=thumbnails[6],IsActive=true,StartDate= new DateTime(2019,3,12),EndDate=DateTime.Now.AddDays(18),Discount=20,Price=320.50f},
                    new TransportOffer { TransportCompanyId =1,CityId= 4,ThumbnailImage=thumbnails[6],IsActive=true,StartDate= new DateTime(2019,3,12),EndDate=DateTime.Now.AddDays(7),Discount=20,Price=210.50f},
                    new TransportOffer { TransportCompanyId =2,CityId= 7,ThumbnailImage=thumbnails[6],IsActive=true,StartDate= new DateTime(2019,3,12),EndDate=DateTime.Now.AddDays(14),Discount=20,Price=919.50f},
                    new TransportOffer { TransportCompanyId =3,CityId= 5,ThumbnailImage=thumbnails[6],IsActive=true,StartDate= new DateTime(2019,3,12),EndDate=DateTime.Now.AddDays(3),Discount=20,Price=850.50f},
                    new TransportOffer { TransportCompanyId =1,CityId= 5,ThumbnailImage=thumbnails[6],IsActive=true,StartDate= new DateTime(2019,3,12),EndDate=DateTime.Now.AddDays(9),Discount=20,Price=620.50f},
                    new TransportOffer { TransportCompanyId =4,CityId= 1,ThumbnailImage=thumbnails[6],IsActive=true,StartDate= new DateTime(2019,3,12),EndDate=DateTime.Now.AddDays(3),Discount=20,Price=18.50f}
                    );
                context.SaveChanges();

                context.Reservations.AddRange(
                    new Reservation { UserId=2,HotelOfferId =2,TransportOfferId = 2,TotalPrice=4000.32f,DateReserved=DateTime.Now.AddDays(-45),NumberOfDays=3,NumberOfPersons=3 },
                    new Reservation { UserId=3,HotelOfferId =3,TransportOfferId = 3,TotalPrice=210.32f,DateReserved=DateTime.Now.AddDays(-45),NumberOfDays=5,NumberOfPersons=4 },
                    new Reservation { UserId=2,HotelOfferId =1,TransportOfferId = 6,TotalPrice=220.32f,DateReserved=DateTime.Now.AddDays(-45),NumberOfDays=2,NumberOfPersons=9 },
                    new Reservation { UserId=3,HotelOfferId =2,TransportOfferId = 2,TotalPrice=1420.32f,DateReserved=DateTime.Now.AddDays(-45),NumberOfDays=3,NumberOfPersons=8 },
                    new Reservation { UserId=4,HotelOfferId =5,TransportOfferId = 5,TotalPrice=2100.32f,DateReserved=DateTime.Now.AddDays(-45),NumberOfDays=3,NumberOfPersons=4 },
                    new Reservation { UserId=5,HotelOfferId =1,TransportOfferId = 5,TotalPrice=3200.32f,DateReserved=DateTime.Now.AddDays(-45),NumberOfDays=3,NumberOfPersons=12 },
                    new Reservation { UserId=1,HotelOfferId =6,TransportOfferId = 7,TotalPrice=6530.32f,StartTripDate=new DateTime(20,1,2020),DateReserved=DateTime.Now.AddDays(-45),NumberOfDays=3,NumberOfPersons=2 },
                    new Reservation { UserId=4,HotelOfferId =8,TransportOfferId = 8,TotalPrice=1282.32f,DateReserved=DateTime.Now.AddDays(-45),NumberOfDays=3,NumberOfPersons=5 },
                    new Reservation { UserId=3,HotelOfferId =6,TransportOfferId = 7,TotalPrice=1282.32f,DateReserved=DateTime.Now.AddDays(-45),NumberOfDays=3,NumberOfPersons=5 },
                    new Reservation { UserId=2,HotelOfferId =6,TransportOfferId = 7,TotalPrice=1282.32f,DateReserved=DateTime.Now.AddDays(-45),NumberOfDays=3,NumberOfPersons=5 }
                    );
                context.SaveChanges();
                context.Ratings.AddRange(
                    new Rating { UserId=4,HotelId=2,TransportCompanyId=2,RatingDate=DateTime.Now.AddDays(-5),HotelRating=5,TransportRating=4},
                    new Rating { UserId=1,HotelId=2,TransportCompanyId=2,RatingDate=DateTime.Now.AddDays(-5),HotelRating=5,TransportRating=4},
                    new Rating { UserId=3,HotelId=1,TransportCompanyId=3,RatingDate=DateTime.Now.AddDays(-5),HotelRating=2,TransportRating=2},
                    new Rating { UserId=4,HotelId=6,TransportCompanyId=6,RatingDate=DateTime.Now.AddDays(-5),HotelRating=5,TransportRating=1},
                    new Rating { UserId=1,HotelId=5,TransportCompanyId=4,RatingDate=DateTime.Now.AddDays(-5),HotelRating=4,TransportRating=3},
                    new Rating { UserId=2,HotelId=3,TransportCompanyId=3,RatingDate=DateTime.Now.AddDays(-5),HotelRating=1,TransportRating=4},
                    new Rating { UserId=5,HotelId=5,TransportCompanyId=6,RatingDate=DateTime.Now.AddDays(-5),HotelRating=2,TransportRating=3},
                    new Rating { UserId=3,HotelId=7,TransportCompanyId=5,RatingDate=DateTime.Now.AddDays(-5),HotelRating=3,TransportRating=2},
                    new Rating { UserId=2,HotelId=7,TransportCompanyId=5,RatingDate=DateTime.Now.AddDays(-5),HotelRating=4,TransportRating=5},
                    new Rating { UserId=2,HotelId=6,TransportCompanyId=6,RatingDate=DateTime.Now.AddDays(-5),HotelRating=5,TransportRating=4},
                    new Rating { UserId=3,HotelId=10,TransportCompanyId=5,RatingDate=DateTime.Now.AddDays(4),HotelRating=4,TransportRating=3},
                    new Rating { UserId=4,HotelId=10,TransportCompanyId=5,RatingDate=DateTime.Now.AddDays(4),HotelRating=3,TransportRating=2},
                    new Rating { UserId=2,HotelId=10,TransportCompanyId=5,RatingDate=DateTime.Now.AddDays(4),HotelRating=5,TransportRating=1},
                    new Rating { UserId=3,HotelId=8,TransportCompanyId=5,RatingDate=DateTime.Now.AddDays(4),HotelRating=5,TransportRating=3},
                    new Rating { UserId=4,HotelId=8,TransportCompanyId=5,RatingDate=DateTime.Now.AddDays(4),HotelRating=3,TransportRating=4},
                    new Rating { UserId=2,HotelId=8,TransportCompanyId=5,RatingDate=DateTime.Now.AddDays(4),HotelRating=2,TransportRating=5},
                    new Rating { UserId=3,HotelId=9,TransportCompanyId=5,RatingDate=DateTime.Now.AddDays(4),HotelRating=4,TransportRating=3},
                    new Rating { UserId=4,HotelId=9,TransportCompanyId=5,RatingDate=DateTime.Now.AddDays(4),HotelRating=1,TransportRating=2},
                    new Rating { UserId=2,HotelId=9,TransportCompanyId=5,RatingDate=DateTime.Now.AddDays(4),HotelRating=5,TransportRating=4}

                    );
                context.SaveChanges();
                }
            }
        }
    }
