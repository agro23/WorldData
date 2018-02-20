using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WorldData;
using System;

namespace WorldData.Models
{
  public class Country
  {
    // private int _id;
    private string _code;
    private string _name;
    // private Dictionary<int, string> _continent; // this is an enumeration which is a sort of shortcut to the string name, it should be 1-7
    private string _continent;
    private string _region;
    private float _surfaceArea;
    private int _indepYear;
    private int _population;
    private float _lifeExpectancy;
    private float _gnp;
    private float _gNPOld;
    private string _localName;
    private string _governmentForm;
    private string _headOfState;
    private int _capital;
    private string _code2;

    // public Country (int ID = 0, string Code = "", string Name = "", int Continent = 0, string Region = "", float SurfaceArea = 0, int IndepYear = 0, int Population = 0, float LifeExpectancy = 0, float GNP = 0, float GNPOld = 0, string LocalName = "", string GovernmentForm = "", string HeadOfState = "", int Capital = 0, string Code2 = "")
    // public Country (string Code = "", string Name = "", Dictionary<int, string> Continent = new Dictionary<int, string>{0,""}, string Region = "", float SurfaceArea = 0, int IndepYear = 0, int Population = 0, float LifeExpectancy = 0, float GNP = 0, float GNPOld = 0, string LocalName = "", string GovernmentForm = "", string HeadOfState = "", int Capital = 0, string Code2 = "")

    // public Country (string Code = "", string Name = "", string Continent = "", string Region = "", float SurfaceArea = 0, int IndepYear = 0, int Population = 0, float LifeExpectancy = 0, float GNP = 0, float GNPOld = 0, string LocalName = "", string GovernmentForm = "", string HeadOfState = "", int Capital = 0, string Code2 = "")
      public Country (string Code, string Name, string Continent, string Region, float SurfaceArea, int IndepYear, int Population, float LifeExpectancy, float GNP, float GNPOld, string LocalName, string GovernmentForm, string HeadOfState, int Capital, string Code2)
    {
    // _id = ID;
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

        // public int GetID()
        // {
        //   return _id;
        // }

        public string GetCode()
        {
          return _code;
        }

        public string GetName()
        {
          return _name;
        }

        public int GetPopulation()
        {
          return _population;
        }

        public string GetHeadOfState()
        {
          return _headOfState;
        }

        public float GetGNP()
        {
          return _gnp;
        }

        public static List<Country> GetAll()
        {

          string countryCode = "";
          string countryName = "";
          string countryContinent = "";
          string countryRegion = "";
          float countrySurfaceArea = 0;
          int countryIndepYear = 0;
          int countryPopulation = 0;
          float countryLifeExpectancy = 0;
          float countryGNP = 0;
          float countryGNPOld = 0;
          string countryLocalName = "";
          string countryGovernmentForm = "";
          string countryHeadOfState = "";
          int countryCapital = 0;
          string countryCode2 = "";



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

              // int countryID = rdr.GetInt32(0);
              countryCode = rdr.GetString(0);
              countryName = rdr.GetString(1);
              // Console.WriteLine(countryName); // enumerated type

              // dictionary<int, string> countryContinent = rdr.GetEnumerator(2);
              // int countryContinent = rdr.GetEnumerator(2);
              countryContinent = rdr.GetString(2);
              // Console.WriteLine(countryContinent); // enumerated type
              countryRegion = rdr.GetString(3);
              // Console.WriteLine(countryRegion); // enumerated type

              countrySurfaceArea = rdr.GetFloat(4);

              // countryIndepYear = rdr.GetInt32(5);

                 if (!rdr.IsDBNull(5)) {
                   countryIndepYear = rdr.GetInt32(5);
                 } else {
                   countryIndepYear = 0;
                 }

              countryPopulation = rdr.GetInt32(6);

              // countryLifeExpectancy = rdr.GetFloat(7);
              if (!rdr.IsDBNull(7)) {
                countryLifeExpectancy = rdr.GetFloat(7);
              } else {
                countryLifeExpectancy = 0;
              }

              countryGNP = rdr.GetFloat(8);

              // countryGNPOld = rdr.GetFloat(9);

              if (!rdr.IsDBNull(9)) {
                countryGNPOld = rdr.GetFloat(9);
              } else {
                countryGNPOld = 0;
              }

              countryLocalName = rdr.GetString(10);
              countryGovernmentForm = rdr.GetString(11);

              if (!rdr.IsDBNull(12)) {
                countryHeadOfState = rdr.GetString(12);
              } else {
                countryHeadOfState =  "";
              }

              // countryHeadOfState = rdr.GetString(12);

              // countryCapital = rdr.GetInt32(13);

              if (!rdr.IsDBNull(13)) {
                countryCapital = rdr.GetInt32(13);
              } else {
                countryCapital = 0;
              }



              countryCode2 = rdr.GetString(14);
              // float x = 3;
              // Country newCountry = new Country (countryID, countryCode, countryName, countryContinent, countryRegion, countrySurfaceArea, countryIndepYear, countryPopulation, countryLifeExpectancy, countryGNP, countryGNPOld, countryLocalName, countryGovernmentForm, countryHeadOfState, countryCapital, countryCode2);
              Country newCountry = new Country (countryCode, countryName, countryContinent, countryRegion, countrySurfaceArea, countryIndepYear, countryPopulation, countryLifeExpectancy, countryGNP, countryGNPOld, countryLocalName, countryGovernmentForm, countryHeadOfState, countryCapital, countryCode2);

              allCountries.Add(newCountry);
              // int Id = 0, string Name, string CountryCode, string District, int Popultion
            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allCountries;
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
