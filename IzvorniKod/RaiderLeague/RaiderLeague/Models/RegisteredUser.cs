﻿//using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RaiderLeague.Models
{
    public enum Klasa
    {
        RATNIK, CAROBNJAK, AGENT, PLACENIK
    };
    public enum AccessLevel
    {
        ADMIN, USER
    };

    public class RegisteredUser
    {



        public enum MedalType
        {
            VELIKA_ZLATO, VELIKA_SREBRO, VELIKA_BRONCA,
            MALA_ZLATO, MALA_SREBRO, MALA_BRONCA
        };


        public int ID { get; set; }
        [Required]
        [Remote("IsUserExists", "Register", ErrorMessage = "User Name already in use")]
        public String Username { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String Password { get; set; }
        public AccessLevel AccessLevel { get; set; }
        //CHANGE BY DINZ -- LOGIN

        //String name;
        //String surname;
        //bool loggedOn { get; set; }
        // List<MedalType> medals { get; }
        //List<Result> results { get; }
        public Klasa Klasa { get; set; }
        //List<BattleLog> battleLogs;
        public static List<SelectListItem> GetKlasaValues()
        {
            return new List<SelectListItem>
           {
            new SelectListItem { Text = "CAROBNJAK", Value = "CAROBNJAK" },
            new SelectListItem { Text = "AGENT", Value = "AGENT" },
            new SelectListItem { Text="RATNIK" ,Value ="RATNIK"},
            new SelectListItem { Text ="PLACENIK", Value ="PLACENIK" }
            };
        }
        //CHANGE DINZ
        
        public bool IsValid(string _username, string _password)
        {
            
            using (var cn = new SqlConnection(@"Server = (localdb)\\mssqllocaldb; Database = RaiderLeagueContext - cd918cb8 - 59ce - 4194 - bb29 - 4885d611eda4; Trusted_Connection = True; MultipleActiveResultSets = true"))
            {
                string _sql = @"SELECT [Username] FROM [dbo].[System_Users] " +
                       @"WHERE [Username] = @u AND [Password] = @p";
                var cmd = new SqlCommand(_sql, cn);
                cmd.Parameters
                    .Add(new SqlParameter("@u", SqlDbType.NVarChar))
                    .Value = _username;
                cmd.Parameters
                    .Add(new SqlParameter("@p", SqlDbType.NVarChar))
                    .Value = _password;

                
                //cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Dispose();
                    cmd.Dispose();
                    return true;
                }
                else
                {
                    reader.Dispose();
                    cmd.Dispose();
                    return false;
                }
            }
        }
        

        /*

        public RegisteredUser(String username, String email, String password)
        {
            this.username = username;
            this.email = email;
            this.password = password;
        }*/

        // u narednim redovima -- checkirati da li su potrebni ovi usernameovi
        // i passwordi u metodama add/remove i login i provjeriti kaj je s delete i ID-em
        // također i izmjeniti dijagram klasa u dokumentaciji sukladno s onim kak treba bit
        /*
        public void setAccessLevel( AccessLevel a)
        {
            this.accessLevel = a; 
        }
        public void addMedal(MedalType medal, String username)
        {
            medals.Add(medal);
        }

        public void removeMedal(MedalType medal, String username)
        {
            medals.Remove(medal);
        }

        public void addResult(Result result)
        {
            results.Add(result);
        }

        public void removeResult(Result result)
        {
            results.Remove(result);
        }

        public void login(String username, String password)
        {
            loggedOn = true;
        }

        public void logout()
        {
            loggedOn = false;
        }

        public void deleteUser()
        {
        }*/









    }
}
