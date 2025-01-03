using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcOnline.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {
        PortfolioManager manage = new PortfolioManager(new EfPortfolioDal());

     
        public IViewComponentResult Invoke()
        {
            var values = manage.TGetList();
            return View(values);
        }
    }
}
