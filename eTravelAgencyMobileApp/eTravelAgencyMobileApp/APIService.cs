using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eTravelAgencyMobileApp
{
    public class APIService
    {
        private readonly string _route;

        public static string Username { get; set; } = "mobile";
        public static string Password { get; set; } = "test";

#if DEBUG

        string apiUrl = "http://localhost:5000/api";
#endif
#if RELEASE

        string apiUrl="https://mywebsite.com/api/";
#endif


        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object searchObject)
        {
            var url = $"{apiUrl}/{_route}";
            if (searchObject != null)
            {
                url += "?";
                url += await searchObject.ToQueryString();
            }
            try
            {
                var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
                return result;
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert("ERROR", e.Message, "OK");
                throw;
            }
           
        }
        public async Task<T> GetAll<T>()
        {
            var result = $"{apiUrl}/{_route}";
            return await result.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }
        public async Task<T> GetById<T>(object id)
        {
            try
            {
                var result = $"{apiUrl}/{_route}/{id}";
                return await result.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            }
            catch (Exception e)
            {
            }
            return default(T);
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{apiUrl}/{_route}/";
                return await url.WithBasicAuth(Username,Password).PostJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{apiUrl}/{_route}/{id}";
            return await url.AllowAnyHttpStatus().WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Delete<T>(object id)
        {
            var url = $"{apiUrl}/{_route}/{id}";
            return await url.AllowAnyHttpStatus().WithBasicAuth(Username, Password)
                .SendJsonAsync(HttpMethod.Delete, id).ReceiveJson<T>();
        }


    }
}
