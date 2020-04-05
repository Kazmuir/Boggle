// Kazmuir Long Kenneth Griffin
// 3/30/20
// CIS 3309 Project 3 Boggle Game
//
// API Dictionary Class
//
// The purpose of this class is to retrieve word definitions from dictionary API to validate the existence of the words user has submitted.
// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Collections.Generic;
using Com.Wordsapi.Www.WordsAPI.Api;
using Com.Wordsapi.Www.WordsAPI.Model;
using RestSharp;
using RestSharp.Authenticators;
using System.Net.Http;
using System.Net;

namespace Boggle
{
    class APIDictionaryClass
    {

        RestClient client = new RestClient();
        string baseURL = "https://wordsapiv1.p.rapidapi.com/words/"; //This is the beginning of the url for any API calls made
        const string accessToken = "aa0747f6camsh842a530968cc8c2p1c0e3fjsnc6d2e5694206"; //My validation token for my account (please use sparaingly as I am on the freemium plan)
        const string endpoint = "/definitions"; //This is the end of the url for API calls

        public APIDictionaryClass() //empty constructor
        {

        }

        public int GetDefine(string word) //Make call to API to return response code. This is a way to check if the word is in the dictionary.
        { 
            client.BaseUrl = new Uri(baseURL + word + endpoint);
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "wordsapiv1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", accessToken);
            IRestResponse response = client.Execute(request); //Actual API call
            HttpStatusCode statusCode = response.StatusCode; //Store status code
            int numericStatusCode = (int)statusCode; 

            return numericStatusCode; 
        }
    }
}
