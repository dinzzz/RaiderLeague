﻿//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace RaiderLeague.Models
{
    public enum Klasa
    {
        RATNIK, CAROBNJAK, AGENT, PLACENIK
    };
    public class RegisteredUser
    {
        public enum AccessLevel
        {
            ADMIN, USER
        };
       

        public enum MedalType
        {
            VELIKA_ZLATO, VELIKA_SREBRO, VELIKA_BRONCA,
            MALA_ZLATO, MALA_SREBRO, MALA_BRONCA
        };

       
        public int ID { get; set; }

         public String Username { get; set; } 

        public String Email { get; set; }
        public String Password { get; set; }
        //String name;
        //String surname;
        //bool loggedOn { get; set; }
        //AccessLevel accessLevel { get; set; }
       // List<MedalType> medals { get; }
        //List<Result> results { get; }
        //Klasa klasa;
        //List<BattleLog> battleLogs;
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
