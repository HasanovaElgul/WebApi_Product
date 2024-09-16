using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]  //автоматическая валидация модели и обработка ошибок
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;                  //private доступны только внутри класса 

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]  // HTTP POST запрос  создать
        public IActionResult Post(Product product)
        {
            _context.Products.Add(product);     //Добавляем продукт в контекст данных
            _context.SaveChanges();                 // Сохраняем изменения в базе данных
            return Ok();                     // Возвращаем статус 200 OK
        }

        [HttpGet]                       //получения данных с сервера
        public IActionResult GetAll()           // Обрабатывает HTTP GET запросы.
        {
            var data = _context.Products.ToList();            //Извлекает все продукты из базы данных с использованием контекста данных (_context).
            return Ok(data);                                  //Возвращает список продуктов в формате JSON с HTTP статусом 200 OK.

        }
        [HttpGet("GetById/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var data = _context.Products.FirstOrDefault(x => x.Id == id);
            return Ok(data);
        }

        [HttpPut]
        public IActionResult Put(Product product)
        {
            return Ok();
        }
    }
}
















//private: доступен только внутри класса ООП
//public: Доступен из любой части программы.
//protected: Доступен внутри текущего класса и в производных классах.
//internal: Доступен внутри текущей сборки (assembly).
//protected internal: Доступен внутри текущей сборки и в производных классах.