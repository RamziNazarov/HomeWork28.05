using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HomeWork28._05
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuotesController : ControllerBase
    {
        DataContext context {get;}
        public QuotesController(DataContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Quote>>> GetAll()
        {
            return await context.Quotes.ToListAsync();
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<Quote>> Get(int Id)
        {
            return await context.Quotes.FindAsync(Id);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Quote quote)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            context.Quotes.Add(quote);
            if(await context.SaveChangesAsync() > 0)
                return Ok();
            return BadRequest();
        }
        [HttpPut("{Id}")]
        public async Task<ActionResult> Edit(Quote quote,int Id)
        {
            try
            {
                var model = await context.Quotes.FindAsync(Id);
                model.Author = quote.Author;
                model.Text = (string.IsNullOrEmpty(quote.Text))?model.Text:quote.Text;
                model.InsertDate = (string.IsNullOrEmpty(quote.InsertDate.ToString()))?model.InsertDate:quote.InsertDate;
                if(await context.SaveChangesAsync() > 0)
                    return Ok();
                return BadRequest();
            }
            catch 
            {
                return BadRequest();
            }
        }
        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(int Id)
        {
            try
            {
                var model = await context.Quotes.FindAsync(Id);
                context.Quotes.Remove(model);
                if(await context.SaveChangesAsync() > 0)
                    return Ok();
                return BadRequest();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}