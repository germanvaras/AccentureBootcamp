using DemoNorthwind.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DemoNorthwind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly NorthwindContext context;
        public CustomerController(NorthwindContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            List<Customer> customers = (from c in context.Customers
                                        select c).ToList();
            return customers;
        }
        [HttpGet("{id}")]
        public Customer Get(string id)
        {
            Customer customer = (from c in context.Customers
                                 where c.CustomerId == id
                                 select c).SingleOrDefault();
            return customer;
        }
        [HttpGet("{companyName}/{contactName}")]
        public dynamic Get(string companyName, string contactName)
        {
            dynamic customers = (from c in context.Customers
                                 where c.CompanyName == companyName && c.ContactName == contactName
                                 select new { c.CompanyName, c.ContactName, c.ContactTitle, c.Phone });
            return customers;
        }
        [HttpPost]
        public ActionResult Post(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return Ok();
        }
        [HttpPost("{id}")]
        public ActionResult Put(string id, [FromBody] Customer customer)
        {
            if(id != null)
            {
                return BadRequest();
            }
            context.Entry(customer).State = EntityState.Modified;
            context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult<Customer> Delete(string id)
        {
            Customer customerToDelete= context.Customers.Find(id);
            if(customerToDelete != null)
            {
                return BadRequest();
            }
            context.Customers.Remove(customerToDelete);
            context.SaveChanges();
            return NoContent();
        }

    }
    
}
    



