using HotelProject.WebUI.Dtos.RoomDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Default;

public class _OurRoomsPartial:ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _OurRoomsPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7116/api/Room");

        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultRoomDto>>(jsonData);

            // Verileri View'e gönderiyoruz
            return View(values);
        }

        // Eğer istek başarısız olursa, boş bir liste gönderiyoruz
        return View(new List<ResultRoomDto>());
    }
}
