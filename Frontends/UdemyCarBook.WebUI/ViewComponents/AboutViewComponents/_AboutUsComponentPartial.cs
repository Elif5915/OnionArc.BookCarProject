using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.AboutDtos;

namespace UdemyCarBook.WebUI.ViewComponents.AboutViewComponents;

public class _AboutUsComponentPartial : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _AboutUsComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    } 
    
    //Mapleme işlemi haritalama/eşleştirme. mapping işlemi apiden gelen değerleri
    //view tarafındaki alanlarım ile eşleştirmem gerekir. mapleme de burada devreye girmekte.
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient(); //CreateClient metodu ile istek oluşturabilmek için bir istemci oluşturduk
        var responseMessage = await client.GetAsync("https://localhost:7177/api/Abouts");
        if (responseMessage.IsSuccessStatusCode) //IsSuccessStatusCode 200 durum kodlarını ifade eder.
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync(); //servisden gelen responseMessage içerisinde verileri string formatta okuyoruz burada.
            var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData); // api türünde gelen/aldığımız veriyi text şeklinde okumak/göstermek istersek DeserializeObject kullandık. 
            // inputlardan girdiğimiz verileri güncelleme/create için apiye göndermek istersek de SerializeObject kullanmalıyız.
            return View(values);
        }
        return View();
    }
}
