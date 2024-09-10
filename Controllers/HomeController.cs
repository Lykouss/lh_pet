using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Carlos Mendes da Silva", "027.012.243-15", "carlos1895@gmail.com", "Zeus");
        Cliente cliente2 = new Cliente(02, "Patrícia Pereira Martins", "028.014.244-16", "paty_stellar@gmail.com", "Rosa");
        Cliente cliente3 = new Cliente(03, "Daniel Marques de Oliveira", "029.015.245-17", "danielMO@gmail.com", "Tor");
        Cliente cliente4 = new Cliente(04, "Miguel Miquelangelo Vasconcelos", "030.016.246-18", "miguel19@gmail.com", "Hércolis");
        Cliente cliente5 = new Cliente(05, "Lívia Patter Moreira", "031.017.247-19", "lili_petter@gmail.com", "Pandora");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "Rações Company", "01.234.567/0001-89", "racoes_company@patter.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Major Pett", "02.345.678/0001-90", "major_pett@major.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "LaInclible", "03.456.789/0001-01", "la_inclibe@inclibe.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "invest_dog", "04.567.890/0001-12", "invest_dog@dog.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Patter Company", "05.678.901/0001-23", "patter_company@patter.com");

        List<Fornecedor> listaFornecedor = new List<Fornecedor>();
        listaFornecedor.Add(fornecedor1);
        listaFornecedor.Add(fornecedor2);
        listaFornecedor.Add(fornecedor3);
        listaFornecedor.Add(fornecedor4);
        listaFornecedor.Add(fornecedor5);

        ViewBag.listaFornecedor = listaFornecedor;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
