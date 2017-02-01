using AngularMVC.Models;
using System.Collections.Generic;

namespace AngularMVC.BBL
{
    public class CountryManager
    {
        Countries country = new Countries();

        public ResponseModel LoadCountries()
        {
            List<Countries> countriesList = new List<Countries>();

            Countries objCountry = new Countries();
            objCountry.Id = 1;
            objCountry.Name = "Bangladesh";
            objCountry.About = "Bangladesh, to the east of India on the Bay of Bengal, is a South Asian country marked by lush greenery and many waterways. Its Padma (Ganges), Meghna and Jamuna rivers create fertile plains, and travel by boat is common. On the southern coast, the Sundarbans, an enormous mangrove forest shared with Eastern India, is home to the royal Bengal tiger.";
            countriesList.Add(objCountry);

            objCountry = new Countries();
            objCountry.Id = 2;
            objCountry.Name = "India";
            objCountry.About = "India is a vast South Asian country with diverse terrain – from Himalayan peaks to Indian Ocean coastline – and history reaching back 5 millennia. In the north, Mughal Empire landmarks include Delhi’s Red Fort complex and massive Jama Masjid mosque, plus Agra’s iconic Taj Mahal mausoleum. Pilgrims bathe in the Ganges in Varanasi, and Rishikesh is a yoga centre and base for Himalayan trekking.";
            countriesList.Add(objCountry);

            objCountry = new Countries();
            objCountry.Id = 3;
            objCountry.Name = "Sri Lanka";
            objCountry.About = "Sri Lanka (formerly Ceylon) is an island nation south of India in the Indian Ocean. Its diverse landscapes range from rainforest and arid plains to highlands and sandy beaches. It’s famed for its ancient Buddhist ruins, including the 5th-century citadel Sigiriya, with its palace and frescoes. The city of Anuradhapura, Sri Lanka's ancient capital, has many ruins dating back more than 2,000 years.";
            countriesList.Add(objCountry);

            objCountry = new Countries();
            objCountry.Id = 4;
            objCountry.Name = "Nepal";
            objCountry.About = "Nepal, officially the Federal Democratic Republic of Nepal, is a landlocked country in South Asia with a population of 26.4 million. It is a multiethnic nation with Nepali as the official language. Kathmandu is the nation's capital and largest city.";
            countriesList.Add(objCountry);

            objCountry = new Countries();
            objCountry.Id = 5;
            objCountry.Name = "Bhutan";
            objCountry.About = "Bhutan, a Buddhist kingdom on the Himalayas’ eastern edge, is known for its monasteries, fortresses (or dzongs) and dramatic landscapes that range from subtropical plains to steep mountains and valleys. In the High Himalayas, peaks such as 7,326m Jomolhari are popular trekking destinations. Paro Taktsang monastery (also known as Tiger’s Nest) clings to cliffs above the forested Paro Valley.";
            countriesList.Add(objCountry);

            objCountry = new Countries();
            objCountry.Id = 6;
            objCountry.Name = "Pakistan";
            objCountry.About = "Pakistan, officially the Islamic Republic of Pakistan, is a federal parliamentary republic in South Asia. It is the sixth-most populous country with a population exceeding 200 million people";
            countriesList.Add(objCountry);

            objCountry = new Countries();
            objCountry.Id = 7;
            objCountry.Name = "Maldives";
            objCountry.About = "The Maldives is a tropical nation in the Indian Ocean composed of 26 ring-shaped atolls, which are made up of more than 1,000 coral islands. It’s known for its beaches, blue lagoons and extensive reefs. The capital, Malé, has a busy fish market, restaurants and shops on the main road, Majeedhee Magu, and 17th-century Hukuru Miskiy (also known as Friday Mosque) made of carved white coral.";
            countriesList.Add(objCountry);

            objCountry = new Countries();
            objCountry.Id = 8;
            objCountry.Name = "China";
            objCountry.About = "China is a populous nation in East Asia whose vast landscape encompasses grassland, desert, mountains, lakes, rivers and more than 14,000km of coastline. Capital Beijing mixes modern architecture with historic sites such as the Forbidden City palace complex and Tiananmen Square. Shanghai is a skyscraper-studded global financial center. The iconic Great Wall of China runs east-west across the country's north.";
            countriesList.Add(objCountry);

            //return countriesList;

            return new ResponseModel()
            {
                Data = countriesList
            };
        }
    }
}