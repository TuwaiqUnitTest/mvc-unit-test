using System;
using animeik.Controllers;
using animeik.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace TestProject1.Controllers
{
    public class Tests
    {
        private AnimeController ac;
        private UsersController uc;

        [SetUp]
        public void Setup()
        {
            ac = new AnimeController();
            uc = new UsersController();
        }

        [Test]
        public void Test_getting_index_view()
        {
            ViewResult viewResultObj = ac.Index(0) as ViewResult;
            Assert.AreEqual("Index", viewResultObj.ViewName);
        }

        [Test]
        public void Test_finding_User_By_ID()
        {
            string name = ac.FindUser(1).username;
            Assert.AreEqual("hassan", name);
        }

        [Test]
        public void Test_finding_User_By_ID_Exception()
        {
            //doesnt exist
            Assert.Throws<NullReferenceException>(() => ac.FindUser(999));
        }

        [Test]
        public void Test_Adding_Anime_To_User_By_Id()
        {
            //user = hassan
            int user_id = 1;
            //anime one piece
            int anime_id = 1;
            //adding one piece to hassan's favorite animes
            uc.addFav(user_id,anime_id);
            //getting the user
            User u = Utilities.users.Find((user => user.id == user_id));
            Assert.AreEqual("one piece", u.Fav[0].title);
        }

        [Test]
        public void Test_Adding_Anime_To_User_By_Id_No_User()
        {
            //user = null
            int user_id = 31;
            //anime one piece
            int anime_id = 1;
            Assert.Throws<NullReferenceException>(() => uc.addFav(user_id,anime_id));
        }
        [Test]
        public void Test_Adding_Anime_To_User_By_Id_No_Anime()
        {
            //user = hassan
            int user_id = 1;
            //anime null
            int anime_id = 91;
            Assert.Throws<NullReferenceException>(() => uc.addFav(user_id,anime_id));
        }
    }
}