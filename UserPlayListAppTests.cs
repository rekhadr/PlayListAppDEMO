using NUnit.Framework;
using System;
using TestVagrantAssignment;

namespace TestVagrantAssignmentTests
{
    public class UserPlayListAppTests
    {
        private UserSongMap userSongMap { get; set; } = null;
        private PlayList playList = new PlayList(2);

        [SetUp]
        public void Setup()
        {
            userSongMap = new UserSongMap();
             playList = new PlayList(2);

        }

        [Test]
        public void GetUserPlaylists_NullPlayList_ThrowsNullException()
        {
           
            Assert.Throws<NullReferenceException>(() => userSongMap.GetUserPlayList("testuser"));

        }

        [Test]
        public void AddUser_AddingExistingUser_ThrowsException()
        {
            userSongMap.AddUser("testuser", 2);
           
            Assert.Throws<Exception>(() => userSongMap.AddUser("testuser", 2));

        }

        [Test]
        public void AddUser_AddingNewUser_UserCreatedSuccess()
        {
            try
            {
                userSongMap.AddUser("testuser", 2);
                return;
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }

        }

        [Test]
        public void ShowPlayList_RetrieveSongs_PlayListforGivenUserDisplayed()
        {
            try
            {
                userSongMap.AddUser("testUser", 2);
                playList.AddSongToPlayList("tu hi mera");
                playList.ShowPlayList();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }

        }

        [Test]
        public void AddSongToPlayList_SongName_SongAddedToPlayList()
        {
            try
            {
                playList.AddSongToPlayList("tu hi mera");
                return;
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [Test]
		public void AddSongToPlayList_NullSongName_ThrowsException()
        {

            Assert.Throws<NullReferenceException>(() => playList.AddSongToPlayList(null));
        }
       


    }
}