using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WorldData;
using System;

namespace WorldData.Models
{
  public class City
  {
    private int _id;
    private string _name;
    private string _countryCode;
    private string _district;
    private int _population;

    public City (int Id = 0, string Name = "", string CountryCode = "", string District = "", int Population = 0)
    {
      _id = Id;
      _name = Name;
      _countryCode = CountryCode;
      _district = District;
      _population = Population;
    }

        // public string GetDescription()
        // {
        //   return _description;
        // }
        // public void SetDescription(string newDescription)
        // {
        //   _description = newDescription;
        // }
        //
        // public int GetID()
        // {
        //   return _id;
        // }

        public int GetID()
        {
          return _id;
        }

        public string GetName()
        {
          return _name;
        }

        public int GetPopulation()
        {
          return _population;
        }

        public string GetCountryCode()
        {
          return _countryCode;
        }

        public static List<City> GetAllByPopDown()
        {
            List<City> allCities = new List<City> {};
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
              cmd.CommandText = @"SELECT * FROM city ORDER BY population DESC;";

            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            while(rdr.Read())
            {
              int cityID = rdr.GetInt32(0);
              string cityName = rdr.GetString(1);
              string countryCode = rdr.GetString(2);
              string distrinctName = rdr.GetString(3);
              int population = rdr.GetInt32(4);
              City newCity = new City (cityID, cityName, countryCode, distrinctName, population);
              // Item newItem = new Item(itemDescription, itemId);
              allCities.Add(newCity);
              // int Id = 0, string Name, string CountryCode, string District, int Popultion
            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allCities;
        }

        public static List<City> GetAllByPopUp()
        {
            List<City> allCities = new List<City> {};
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
              cmd.CommandText = @"SELECT * FROM city ORDER BY population ASC;";

            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            while(rdr.Read())
            {
              int cityID = rdr.GetInt32(0);
              string cityName = rdr.GetString(1);
              string countryCode = rdr.GetString(2);
              string distrinctName = rdr.GetString(3);
              int population = rdr.GetInt32(4);
              City newCity = new City (cityID, cityName, countryCode, distrinctName, population);
              // Item newItem = new Item(itemDescription, itemId);
              allCities.Add(newCity);
              // int Id = 0, string Name, string CountryCode, string District, int Popultion
            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allCities;
        }

        public static List<City> GetAllDown()
        {
            List<City> allCities = new List<City> {};
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM city ORDER BY name DESC;";
            // cmd.CommandText = @"SELECT * FROM allCities ORDER BY allCities.GetPopulation() ASC;";
            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            while(rdr.Read())
            {
              int cityID = rdr.GetInt32(0);
              string cityName = rdr.GetString(1);
              string countryCode = rdr.GetString(2);
              string distrinctName = rdr.GetString(3);
              int population = rdr.GetInt32(4);
              City newCity = new City (cityID, cityName, countryCode, distrinctName, population);
              // Item newItem = new Item(itemDescription, itemId);
              allCities.Add(newCity);
              // int Id = 0, string Name, string CountryCode, string District, int Popultion
            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allCities;
        }

        public static List<City> GetAll()
        {
            List<City> allCities = new List<City> {};
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM city ORDER BY name ASC;";
            // cmd.CommandText = @"SELECT * FROM allCities ORDER BY allCities.GetPopulation() ASC;";
            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            while(rdr.Read())
            {
              int cityID = rdr.GetInt32(0);
              string cityName = rdr.GetString(1);
              string countryCode = rdr.GetString(2);
              string distrinctName = rdr.GetString(3);
              int population = rdr.GetInt32(4);
              City newCity = new City (cityID, cityName, countryCode, distrinctName, population);
              // Item newItem = new Item(itemDescription, itemId);
              allCities.Add(newCity);
              // int Id = 0, string Name, string CountryCode, string District, int Popultion
            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allCities;
        }

  }
}
