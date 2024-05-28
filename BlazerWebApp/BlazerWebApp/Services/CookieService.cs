using BlazerWebApp.Migrations;
using Newtonsoft.Json;
using static BlazerWebApp.Components.Account.Pages.Login;
using static System.Net.WebRequestMethods;
using System.Text;
namespace BlazerWebApp.Services;

public class CookieService(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
{
    private readonly HttpClient _httpClient = httpClient;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public async Task GetToken(string userId, string email)
    {
        var parameters = new Dictionary<string, string>() { { "userId", userId }, { "email", email } };
        var content = new StringContent(JsonConvert.SerializeObject(parameters), Encoding.UTF8, "application/json");
        var responseToken = await _httpClient.PostAsync("https://tokenprovider-silicon-hl.azurewebsites.net/api/token/refresh?code=bStj0OsTHBc5wOeqQfn2Terwa5jEfQcR7hYu-oIN88ChAzFuxqARig%3D%3D", content);

        if (responseToken.IsSuccessStatusCode)
        {
            var token = await responseToken.Content.ReadAsStringAsync();
            var tokenModel = JsonConvert.DeserializeObject<TokenResponse>(token);

            var cookieOptionsAccess = new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                Expires = DateTime.Now.AddMinutes(25)
            };

            var cookieOptionsRefresh = new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                Expires = DateTime.Now.AddDays(7)
            };

            _httpContextAccessor.HttpContext!.Response.Cookies.Append("AccessToken", tokenModel.AccessToken, cookieOptionsAccess);
            _httpContextAccessor.HttpContext.Response.Cookies.Append("RefreshToken", tokenModel.RefreshToken, cookieOptionsRefresh);
        }
    }
}
