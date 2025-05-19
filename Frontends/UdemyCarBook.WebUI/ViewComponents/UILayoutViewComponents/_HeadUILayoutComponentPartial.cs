using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.ViewComponents.UILayoutViewComponents;

public class _HeadUILayoutComponentPartial : ViewComponent
{
    //Invoke : çağırmak,yakalamak
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
