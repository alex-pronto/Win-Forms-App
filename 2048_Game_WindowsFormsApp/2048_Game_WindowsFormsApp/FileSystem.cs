using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace _2048_Game_WindowsFormsApp
{
    public class FileSystem
    {

        public static string fileDBName = "users_2048_game";
        public static string fileFolderPath = Path.GetTempPath();
        public static string dBFilePath = Path.Combine(fileFolderPath, fileDBName);
        

        public void SaveUsersToDB(List<User> users)
        {
        
            string serializedUsers = JsonConvert.SerializeObject(users);
            File.WriteAllText(dBFilePath, serializedUsers);

        }

        public static void SaveUserToDB(User user)
            {

            
            List<User> AllCurrentUsers = ReadAllUsersFromDB();
            
            for (int i = 0; i < AllCurrentUsers.Count; i++)
            {
                if (user.UserResult > AllCurrentUsers[i].UserResult)
                {
                    AllCurrentUsers.Insert(i, user);
                    break;
                }
            }    

           // AllCurrentUsers.Add(user);
            string serializedUsers = JsonConvert.SerializeObject(AllCurrentUsers);
            File.WriteAllText(dBFilePath, serializedUsers);


        }

        public static   List<User> ReadAllUsersFromDB()
        {
            
            FileSystem.CheckFileIsCreate();
            string json = File.ReadAllText(dBFilePath);
            List<User> currentUsers = JsonConvert.DeserializeObject<List<User>>(json);


            return currentUsers ?? new List<User>();

        }

        public static void CheckFileIsCreate()
        {
            
            if (File.Exists(dBFilePath) == false)
            {
                var file = File.Create(dBFilePath);
                file.Close();
            }
        }



    }
}
