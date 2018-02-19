using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WorldData;
using System;

namespace WorldData.Models
{
  public class Country
  {
    private int _id;
    private string _code;
    private string _name;
    private int _continent; // this is an enumeration which is a sort of shortcut to the string name, it should be 1-7
    private string _region;
    private float _surfaceArea;
    private int _indepYear;
    private int _population;
    private float _lifeExpectancy;
    private float _gnp;
    private float _gNPOld;
    private string LocalName;
    private string _governmentForm;
    private string HeadOfState;
    private int _capital;
    private string _code2;

    public Country (int ID = 0, string Code = "", string Name = "", int Continent = 0, string Region = "", float SurfaceArea = 0.0, int IndepYear = 0, int Population = 0, float LifeExpectancy = 0.0, float GNP = 0.0, float GNPOld = 0.0, string LocalName = "", string GovernmentForm = "", string HeadOfState = "", int Capital = 0, string Code2 = "")
    {
    _id = ID;
    _code = Code;
    _name = Name;
    _continent = Continent;
    _region = Region;
    _surfaceArea = SurfaceArea;
    _indepYear = IndepYear;
    _population = Population;
    _lifeExpectancy = LifeExpectancy;
    _gnp = GNP;
    _gNPOld = GNPOld;
    _localName = LocalName;
    _governmentForm = GovernmentForm;
    _headOfState = HeadOfState;
    _capital = Capital;
    _code2 = Code2;
    }

        public int GetID()
        {
          return _id;
        }

        public string GetName()
        {
          return _name;
        }

        public static List<Country> GetAll()
        {
            List<Country> allCountries = new List<Country> {};
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            // cmd.CommandText = @"SELECT * FROM items;";
            cmd.CommandText = @"SELECT * FROM country;";
            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            while(rdr.Read())
            {
              // not sure if we need these parameters after each rdr.GetBLAH() call but I think they are the columns
              int cityID = rdr.GetInt32(0);
              string cityName = rdr.GetString(1);
              string countryCode = rdr.GetString(2);
              string distrinctName = rdr.GetString(3);
              int population = rdr.GetInt32(4);
              // ^-- copy the format of these guys ********************************************************************
              // add 'country' to the front of all these guys --v
              int countryID = 0;
              string countryCode = ;
              *******string Name = "", int Continent = 0, string Region = "", float SurfaceArea = 0.0, int IndepYear = 0, int Population = 0, float LifeExpectancy = 0.0, float GNP = 0.0, float GNPOld = 0.0, string LocalName = "", string GovernmentForm = "", string HeadOfState = "", int Capital = 0, string Code2 = ""

              // then copy all the new country var names into the Country declaration below using these --v to save time.

              int ID = 0, Code = "", string Name = "", int Continent = 0, string Region = "", float SurfaceArea = 0.0, int IndepYear = 0, int Population = 0, float LifeExpectancy = 0.0, float GNP = 0.0, float GNPOld = 0.0, string LocalName = "", string GovernmentForm = "", string HeadOfState = "", int Capital = 0, string Code2 = ""
              Country newCountry = new Country (cityID, cityName, countryCode, distrinctName, population); // ignore the parameters in there now
              // City newCity = new City (cityID, cityName, countryCode, distrinctName, population);
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
