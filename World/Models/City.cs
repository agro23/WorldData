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
      _population = Popultion;
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

        public static List<City> GetAll()
        {
            List<City> allCities = new List<City> {};
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            // cmd.CommandText = @"SELECT * FROM items;";
            cmd.CommandText = @"SELECT * FROM city;";
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

        // public static List<City> GetItem (int id)
        // {
        //     // List<Item> allItems = new List<Item> {};
        //     // allItems = Item.GetAll();
        //     // return allItems[id];
        //     //
        //     // MySqlConnection conn = DB.Connection();
        //     // conn.Open();
        //     //
        //     // var cmd = conn.CreateCommand() as MySqlCommand;
        //     // cmd.CommandText = @"SELECT id FROM items;";
        //     //
        //     // cmd.ExecuteNonQuery();
        //     //
        //     // conn.Close();
        //     // if (conn != null)
        //     // {
        //     //     conn.Dispose();
        //     // }
        // }

        // public static void AddItem (int id)
        // {
        //   // get info from form page
        //   // append info from form page (dynamically built from column info)
        //   // reindex? return some sort of token that it succeeded?
        // }
        //
        // public static void EditItem (int id){
        //   // get Item number from List
        //   // display contents to Edit.cshtml into inidividual text fields
        //   // Button to post back
        //   // UPDATE Item[id] in DB.
        // }
        //
        // public static void DeleteItem (int id)
        // {
        //   // Item myItem = Item.GetItem(id);
        //   // DROP item? DELETE Item(myItem)? How in SQL?
        //   // How do I issue the appropriate command?
        // }

      //   public static void DeleteAll()
      //  {
      //      MySqlConnection conn = DB.Connection();
      //      conn.Open();
      //
      //      var cmd = conn.CreateCommand() as MySqlCommand;
      //      cmd.CommandText = @"DELETE FROM items;";
      //
      //      cmd.ExecuteNonQuery();
      //
      //      conn.Close();
      //      if (conn != null)
      //      {
      //          conn.Dispose();
      //      }
      // }

        // public void Save()
        // {
        //   _instances.Add(this);
        // }
        // public static void ClearAll()
        // {
        //   _instances.Clear();
        // }

  }
}
