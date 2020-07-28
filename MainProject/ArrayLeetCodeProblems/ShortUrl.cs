using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    public class ShortUrl
    {
        //taking count as variable
        int count = 0;
        Dictionary<string, string> url = new Dictionary<string, string>();

        //for encoding we are using this method
        //passing the long url as parameter
        public string Encode(string longUrl)
        {
            //increment the count because the url should be unique so we are incrementing
            count++;
            //taking shorturl and concatinating count with that beacuse if we give short url the ciunt also should get added
            String shortUrl = "http://tinyurl.com/" + count;
            //adding the key and value to our dictionary
            url.Add(shortUrl, longUrl);
            //retuyrn short url
            return shortUrl;
        }

        //we are using this method for decoding
        public string Decode(string shortUrl)
        {
            //if that key contains in the dictionary
            if(url.ContainsKey(shortUrl))
            {
                //return shorturl
                return shortUrl;
            }
            else
            {
                //return url is not found
                return "Url is not found";
            }
        }


    }
}
