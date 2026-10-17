using System;
using Microsoft.AspNetCore.Mvc;
using addressBookServerPrecourse.Models;

namespace addressBookServerPrecourse.Controllers;

public class AddressesController : Controller
{

    Db _db;
    public AddressesController(Db db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        return View(_db.Addresses);
    }
}
