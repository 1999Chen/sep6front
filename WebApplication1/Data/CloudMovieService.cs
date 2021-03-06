using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Data
{
    public class CloudMovieService : IMovieService
    {
        private string url = "https://sep6-v2.ey.r.appspot.com";
        private readonly HttpClient client;

        public CloudMovieService()
        {
            client = new HttpClient();
        }
        public async Task<Movie> getMovieById(int Id)
        {
            HttpResponseMessage response = await client.GetAsync($"{url}/movie/getMovieById?id={Id}");
        
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error");
            }
            
            string message = await response.Content.ReadAsStringAsync();
            Movie movie = JsonSerializer.Deserialize<Movie>(message);
            Console.WriteLine(movie.title);
            Console.WriteLine(response);
            return movie;
        }

      
        public async Task<IList<Movie>> getMoviesByYear(int minYear, int maxYear)
        {
            HttpResponseMessage response = await client.GetAsync($"{url}/movie/getMoviesByYear?minYear={minYear}&&maxYear={maxYear}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error");
            }
            string message = await response.Content.ReadAsStringAsync();
            List<Movie> result = JsonSerializer.Deserialize<List<Movie>>(message);
            for(int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i].title);
            }
            
            return result;
        }


        public async Task<IList<Movie>> getMoviesByTitle(string title)
        {
            Console.WriteLine("this is start from task" );
            HttpResponseMessage response=await client.GetAsync($"{url}/movie/getMoviesByTitle?title={title}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error"+response);
            }
            string message = await response.Content.ReadAsStringAsync();
            List<Movie> result = JsonSerializer.Deserialize<List<Movie>>(message);
            Console.WriteLine("this is"+result);
            return result;

        }

        public IList<Movie> test(string title)
        {
            Console.WriteLine("this is start" );
            IList<Movie> result = new List<Movie>();
            result =  this.getMoviesByTitle(title).Result;
            Console.WriteLine("this is" + result);
            return result;

        }






        public async Task<IList<People>> getStasById(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{url}/people/getStarsByMovie?id={id}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error");
            }
            string message = await response.Content.ReadAsStringAsync();
            List<People> result = JsonSerializer.Deserialize<List<People>>(message);
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i].name);
            }
            return result;
        }

        public async Task<IList<People>> getDirectorsById(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{url}/people/getDirectorsByMovie?id={id}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error");
            }
            string message = await response.Content.ReadAsStringAsync();
           List<People> result = JsonSerializer.Deserialize<List<People>>(message);
            for (int i = 0; i < result.Count; i++) {
                Console.WriteLine(result[i].name); }
            return result;
        }
    }
}
