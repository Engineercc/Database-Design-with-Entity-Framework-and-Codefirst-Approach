namespace TourProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TourProject.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<TourProject.Model.TourDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TourProject.Model.TourDbContext context)
        {
            #region Country
            Country c = new Country() { CountryName = "Italy" };
            Country c1 = new Country() { CountryName = "Greece" };
            Country c2 = new Country() { CountryName = "England" };
            Country c3 = new Country() { CountryName = "Deutschland" };
            Country c4 = new Country() { CountryName = "Finland" };
            Country c5 = new Country() { CountryName = "Japan" };
            Country c6 = new Country() { CountryName = "Ukraine" };

            context.SaveChanges();

            context.Countries.Add(c);
            context.Countries.Add(c1);
            context.Countries.Add(c2);
            context.Countries.Add(c3);
            context.Countries.Add(c4);
            context.Countries.Add(c5);
            context.Countries.Add(c6);
            context.SaveChanges();
            #endregion

            #region Gender
            Gender ge = new Gender() { GenderDescription = "Man" };
            Gender ge1 = new Gender() { GenderDescription = "Woman" };

            context.Genders.Add(ge);
            context.Genders.Add(ge1);
            context.SaveChanges(); 
            #endregion

            #region Visited Places

            VisitedPlace v = new VisitedPlace() { PlaceName = "Ayasofya" };
            VisitedPlace v1 = new VisitedPlace() { PlaceName = "Yerebatan Sarnıcı" };
            VisitedPlace v2 = new VisitedPlace() { PlaceName = "Pierre Loti" };
            VisitedPlace v3 = new VisitedPlace() { PlaceName = "Kız Kulesi" };
            VisitedPlace v4 = new VisitedPlace() { PlaceName = "Adalar" };
            VisitedPlace v5 = new VisitedPlace() { PlaceName = "Dolmabahçe Sarayı" };
            VisitedPlace v6 = new VisitedPlace() { PlaceName = "Miniatürk" };
            VisitedPlace v7 = new VisitedPlace() { PlaceName = "Sultan Ahmet Camii" };
            VisitedPlace v8 = new VisitedPlace() { PlaceName = "Rumeli Hisarı" };
            VisitedPlace v9 = new VisitedPlace() { PlaceName = "Mısır Çarşısı" };
            VisitedPlace v10 = new VisitedPlace() { PlaceName = "Anadolu Hisarı" };
            VisitedPlace v11 = new VisitedPlace() { PlaceName = "Eyüp Sultan Camii" };
            VisitedPlace v12 = new VisitedPlace() { PlaceName = "Atatürk Arboretumu" };
            VisitedPlace v13 = new VisitedPlace() { PlaceName = "Kapalı Çarşı" };

            context.VisitedPlaces.Add(v);
            context.VisitedPlaces.Add(v1);
            context.VisitedPlaces.Add(v2);
            context.VisitedPlaces.Add(v3);
            context.VisitedPlaces.Add(v4);
            context.VisitedPlaces.Add(v5);
            context.VisitedPlaces.Add(v6);
            context.VisitedPlaces.Add(v7);
            context.VisitedPlaces.Add(v8);
            context.VisitedPlaces.Add(v9);
            context.VisitedPlaces.Add(v10);
            context.VisitedPlaces.Add(v11);
            context.VisitedPlaces.Add(v12);
            context.VisitedPlaces.Add(v13);
            context.SaveChanges(); 
            #endregion

            #region  Nationality
            Nationality n = new Nationality() { NationalityDescription = "Japanese" };
            Nationality n1 = new Nationality() { NationalityDescription = "Greek" };
            Nationality n2 = new Nationality() { NationalityDescription = "Finnish" };
            Nationality n3 = new Nationality() { NationalityDescription = "Deutsch" };
            Nationality n4 = new Nationality() { NationalityDescription = "English" };
            Nationality n5 = new Nationality() { NationalityDescription = "Ukrainian" };

            context.Nationalities.Add(n);
            context.Nationalities.Add(n1);
            context.Nationalities.Add(n2);
            context.Nationalities.Add(n3);
            context.Nationalities.Add(n4);
            context.Nationalities.Add(n5);
            context.SaveChanges(); 
            #endregion

            #region Guide
            Guide gu = new Guide() { FirstName = "Ozan", LastName = "Temiz", Phone = "5556544343" };
            Guide gu1 = new Guide() { FirstName = "Bahar", LastName = "Sevgin", Phone = "5556544344" };
            Guide gu2 = new Guide() { FirstName = "Ömer", LastName = "Uçar", Phone = "5556544345" };
            Guide gu3 = new Guide() { FirstName = "Sevgi", LastName = "Çakmak", Phone = "5556544346" };
            Guide gu4 = new Guide() { FirstName = "Linda", LastName = "Callahan", Phone = "5556544349" };

            context.Guides.Add(gu);
            context.Guides.Add(gu1);
            context.Guides.Add(gu2);
            context.Guides.Add(gu3);
            context.Guides.Add(gu4);
            context.SaveChanges();
            #endregion


            #region Turist

            Tourist t = new Tourist() { NationalityID = 1, GenderID = 2, FirstName = "Levi", LastName = "Acevedo", BirthDate = new DateTime(1991, 06, 11) };
            Tourist t1 = new Tourist() { NationalityID = 2, GenderID = 1, FirstName = "Basil", LastName = "Aguilar", BirthDate = new DateTime(1994, 04, 22) };
            Tourist t2 = new Tourist() { NationalityID = 3, GenderID = 1, FirstName = "Zenaida", LastName = "Holder", BirthDate = new DateTime(1990, 01, 09) };
            Tourist t3 = new Tourist() { NationalityID = 2, GenderID = 2, FirstName = "Illana", LastName = "Browning", BirthDate = new DateTime(1991, 01, 28) };
            Tourist t4 = new Tourist() { NationalityID = 4, GenderID = 1, FirstName = "Raja", LastName = "Duke", BirthDate = new DateTime(1983, 07, 27) };
            Tourist t5 = new Tourist() { NationalityID = 3, GenderID = 1, FirstName = "Isaiah", LastName = "Valdez", BirthDate = new DateTime(1998, 01, 16) };
            Tourist t6 = new Tourist() { NationalityID = 1, GenderID = 2, FirstName = "Gray", LastName = "Marshall", BirthDate = new DateTime(1980, 11, 21) };
            Tourist t7 = new Tourist() { NationalityID = 5, GenderID = 2, FirstName = "Ora", LastName = "Fletcher", BirthDate = new DateTime(1994, 01, 19) };
            Tourist t8 = new Tourist() { NationalityID = 5, GenderID = 2, FirstName = "Lavinia", LastName = "Lloyd", BirthDate = new DateTime(1986, 10, 26) };
            Tourist t9 = new Tourist() { NationalityID = 2, GenderID = 2, FirstName = "Jenna", LastName = "Williams", BirthDate = new DateTime(1982, 05, 01) };
            Tourist t10 = new Tourist() { NationalityID = 5, GenderID = 1, FirstName = "Christian", LastName = "Nash", BirthDate = new DateTime(1980, 08, 09) };
            Tourist t11 = new Tourist() { NationalityID = 1, GenderID = 1, FirstName = "Brianna", LastName = "Everett", BirthDate = new DateTime(1978, 09, 03) };
            Tourist t12 = new Tourist() { NationalityID = 6, GenderID = 1, FirstName = "Geoffrey", LastName = "Knowles", BirthDate = new DateTime(1985, 02, 17) };
            Tourist t13 = new Tourist() { NationalityID = 5, GenderID = 1, FirstName = "Quinn", LastName = "Hamilton", BirthDate = new DateTime(1990, 07, 10) };
            #endregion

            #region Turist Add
            foreach (Tourist item in context.Tourists)
            {
                context.Tourists.Add(item);
            }
            context.Tourists.Add(t);
            context.Tourists.Add(t1);
            context.Tourists.Add(t2);
            context.Tourists.Add(t3);
            context.Tourists.Add(t4);
            context.Tourists.Add(t5);
            context.Tourists.Add(t6);
            context.Tourists.Add(t7);
            context.Tourists.Add(t8);
            context.Tourists.Add(t9);
            context.Tourists.Add(t10);
            context.Tourists.Add(t11);
            context.Tourists.Add(t12);
            context.Tourists.Add(t13);
            context.SaveChanges();
            #endregion

            #region Ara Tabloya ekleme
            t.Countries.Add(c);
            t1.Countries.Add(c1);
            t2.Countries.Add(c1);
            t3.Countries.Add(c2);
            t4.Countries.Add(c3);
            t5.Countries.Add(c4);
            t6.Countries.Add(c5);
            t7.Countries.Add(c2);
            t8.Countries.Add(c2);
            t9.Countries.Add(c1);
            t10.Countries.Add(c2);
            t11.Countries.Add(c5);
            t12.Countries.Add(c6);
            t13.Countries.Add(c2);
            context.SaveChanges();
            #endregion
    

            #region Plan
            TouristGuidePlace tgp = new TouristGuidePlace() { TouristID = 1, PlaceID = 1, GuideID = 1, ArrivalDate = new DateTime(2012, 11, 01) };
            TouristGuidePlace tgp1 = new TouristGuidePlace() { TouristID = 1, PlaceID = 2, GuideID = 1, ArrivalDate = new DateTime(2012, 11, 01) };
            TouristGuidePlace tgp2 = new TouristGuidePlace() { TouristID = 2, PlaceID = 3, GuideID = 2, ArrivalDate = new DateTime(2014, 08, 11) };
            TouristGuidePlace tgp3 = new TouristGuidePlace() { TouristID = 2, PlaceID = 4, GuideID = 2, ArrivalDate = new DateTime(2014, 08, 11) };
            TouristGuidePlace tgp4 = new TouristGuidePlace() { TouristID = 3, PlaceID = 5, GuideID = 3, ArrivalDate = new DateTime(2014, 02, 04) };
            TouristGuidePlace tgp5 = new TouristGuidePlace() { TouristID = 3, PlaceID = 1, GuideID = 3, ArrivalDate = new DateTime(2014, 02, 04) };
            TouristGuidePlace tgp6 = new TouristGuidePlace() { TouristID = 3, PlaceID = 6, GuideID = 3, ArrivalDate = new DateTime(2014, 02, 04) };
            TouristGuidePlace tgp7 = new TouristGuidePlace() { TouristID = 4, PlaceID = 7, GuideID = 4, ArrivalDate = new DateTime(2014, 05, 01) };
            TouristGuidePlace tgp8 = new TouristGuidePlace() { TouristID = 4, PlaceID = 8, GuideID = 4, ArrivalDate = new DateTime(2014, 05, 01) };
            TouristGuidePlace tgp9 = new TouristGuidePlace() { TouristID = 5, PlaceID = 9, GuideID = 2, ArrivalDate = new DateTime(2014, 09, 08) };
            TouristGuidePlace tgp10 = new TouristGuidePlace() { TouristID = 6, PlaceID = 6, GuideID = 1, ArrivalDate = new DateTime(2012, 08, 28) };
            TouristGuidePlace tgp11 = new TouristGuidePlace() { TouristID = 6, PlaceID = 10, GuideID = 1, ArrivalDate = new DateTime(2012, 08, 28) };
            TouristGuidePlace tgp12 = new TouristGuidePlace() { TouristID = 7, PlaceID = 9, GuideID = 5, ArrivalDate = new DateTime(2013, 08, 27) };
            TouristGuidePlace tgp13 = new TouristGuidePlace() { TouristID = 7, PlaceID = 4, GuideID = 5, ArrivalDate = new DateTime(2013, 08, 27) };
            TouristGuidePlace tgp14 = new TouristGuidePlace() { TouristID = 8, PlaceID = 11, GuideID = 2, ArrivalDate = new DateTime(2014, 08, 23) };
            TouristGuidePlace tgp15 = new TouristGuidePlace() { TouristID = 8, PlaceID = 12, GuideID = 2, ArrivalDate = new DateTime(2014, 08, 23) };
            TouristGuidePlace tgp16 = new TouristGuidePlace() { TouristID = 9, PlaceID = 3, GuideID = 1, ArrivalDate = new DateTime(2012, 03, 26) };
            TouristGuidePlace tgp17 = new TouristGuidePlace() { TouristID = 9, PlaceID = 4, GuideID = 1, ArrivalDate = new DateTime(2012, 03, 26) };
            TouristGuidePlace tgp18 = new TouristGuidePlace() { TouristID = 10, PlaceID = 13, GuideID = 3, ArrivalDate = new DateTime(2014, 11, 26) };
            TouristGuidePlace tgp19 = new TouristGuidePlace() { TouristID = 10, PlaceID = 6, GuideID = 3, ArrivalDate = new DateTime(2014, 11, 26) };
            TouristGuidePlace tgp20 = new TouristGuidePlace() { TouristID = 11, PlaceID = 14, GuideID = 3, ArrivalDate = new DateTime(2013, 02, 15) };
            TouristGuidePlace tgp21 = new TouristGuidePlace() { TouristID = 11, PlaceID = 10, GuideID = 3, ArrivalDate = new DateTime(2013, 02, 15) };
            TouristGuidePlace tgp22 = new TouristGuidePlace() { TouristID = 2, PlaceID = 13, GuideID = 1, ArrivalDate = new DateTime(2014, 09, 09) };
            TouristGuidePlace tgp23 = new TouristGuidePlace() { TouristID = 12, PlaceID = 3, GuideID = 2, ArrivalDate = new DateTime(2013, 04, 19) };
            TouristGuidePlace tgp24 = new TouristGuidePlace() { TouristID = 12, PlaceID = 4, GuideID = 2, ArrivalDate = new DateTime(2013, 04, 19) };
            TouristGuidePlace tgp25 = new TouristGuidePlace() { TouristID = 13, PlaceID = 10, GuideID = 5, ArrivalDate = new DateTime(2014, 01, 26) };
            TouristGuidePlace tgp26 = new TouristGuidePlace() { TouristID = 13, PlaceID = 13, GuideID = 5, ArrivalDate = new DateTime(2014, 01, 26) };
            TouristGuidePlace tgp27 = new TouristGuidePlace() { TouristID = 14, PlaceID = 7, GuideID = 4, ArrivalDate = new DateTime(2013, 12, 04) };
            TouristGuidePlace tgp28 = new TouristGuidePlace() { TouristID = 14, PlaceID = 4, GuideID = 4, ArrivalDate = new DateTime(2013, 12, 04) };

            context.SaveChanges();

            #endregion


            #region Plan Add
            context.TouristGuidePlaces.Add(tgp);
            context.TouristGuidePlaces.Add(tgp1);
            context.TouristGuidePlaces.Add(tgp2);
            context.TouristGuidePlaces.Add(tgp3);
            context.TouristGuidePlaces.Add(tgp4);
            context.TouristGuidePlaces.Add(tgp5);
            context.TouristGuidePlaces.Add(tgp6);
            context.TouristGuidePlaces.Add(tgp7);
            context.TouristGuidePlaces.Add(tgp8);
            context.TouristGuidePlaces.Add(tgp9);
            context.TouristGuidePlaces.Add(tgp10);
            context.TouristGuidePlaces.Add(tgp11);
            context.TouristGuidePlaces.Add(tgp12);
            context.TouristGuidePlaces.Add(tgp13);
            context.TouristGuidePlaces.Add(tgp14);
            context.TouristGuidePlaces.Add(tgp15);
            context.TouristGuidePlaces.Add(tgp16);
            context.TouristGuidePlaces.Add(tgp17);
            context.TouristGuidePlaces.Add(tgp18);
            context.TouristGuidePlaces.Add(tgp19);
            context.TouristGuidePlaces.Add(tgp20);
            context.TouristGuidePlaces.Add(tgp21);
            context.TouristGuidePlaces.Add(tgp22);
            context.TouristGuidePlaces.Add(tgp23);
            context.TouristGuidePlaces.Add(tgp24);
            context.TouristGuidePlaces.Add(tgp25);
            context.TouristGuidePlaces.Add(tgp26);
            context.TouristGuidePlaces.Add(tgp27);
            context.TouristGuidePlaces.Add(tgp28);
            context.SaveChanges();
        }
        #endregion
    }
    }

