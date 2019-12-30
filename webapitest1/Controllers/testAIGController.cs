
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapitest1.Models;

namespace webapitest1.Controllers
{
 
    public class testAIGController : ApiController
    {
        AIGContext context = new AIGContext();
        // GET api/<controller>
        [HttpGet]
        [Throttle(Name = "TestThrottle", Message = "你必需3秒後才能操作", Seconds = 3)]
        public IEnumerable<Sales> GetSales()
        {
            return context.Sales.ToList();
        }
        [HttpGet] 
        [Throttle(Name = "TestThrottle", Message = "你必需3秒後才能操作", Seconds = 3)]
        public IQueryable<Sales> GetSales2()
        {
            return context.Sales.AsQueryable();
        }

        // POST api/<controller>
        [HttpPost]
        [Throttle(Name = "TestThrottle", Message = "你必需3秒後才能操作", Seconds = 3)]
        public HttpResponseMessage AddSales([FromBody]Sales value)
        {
            if (!ModelState.IsValid)
            {
                string messages = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));
                return Request.CreateResponse(HttpStatusCode.NotAcceptable, new HttpError(messages));
            }
            context.Sales.Add(value);
            context.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, new Message<object>(new {id=value.SalesId,code="AA"}, statusEM.sucess));
        }

        // PUT api/<controller>/5
        [HttpPut]
        [Throttle(Name = "TestThrottle", Message = "你必需2秒後才能操作", Seconds = 2)]
        public HttpResponseMessage updateSales([FromBody]Sales value)
        {
            var data = context.Sales.FirstOrDefault(p => p.SalesId == value.SalesId);
            if (data==null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new HttpError("此筆資料不存在"));
            }
            if (!ModelState.IsValid)
            {
                return new HttpResponseMessage(HttpStatusCode.NotAcceptable);
            }            
            context.Entry(data).CurrentValues.SetValues(value);
            context.SaveChanges();  
        
            return  Request.CreateResponse(HttpStatusCode.OK,new HttpError("修改成功"));
        }

        // PUT api/<controller>/5
        [HttpPut]
        [Throttle(Name = "TestThrottle", Message = "你必需2秒後才能操作", Seconds = 2)]
        public HttpResponseMessage updateSalesOnlyBase([FromBody]SalseDTO value)
        {
            var data = context.Sales.FirstOrDefault(p => p.SalesId == value.SalesId);
            if (data == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new HttpError("此筆資料不存在"));
            }
            if (!ModelState.IsValid)
            {
                return new HttpResponseMessage(HttpStatusCode.NotAcceptable);
            }           
            context.Entry(data).CurrentValues.SetValues(value);
            context.SaveChanges();       
            return Request.CreateResponse(HttpStatusCode.OK, new HttpError("修改成功"));
        }


        // DELETE api/<controller>/5
        [HttpDelete]
        [Throttle(Name = "TestThrottle", Message = "你必需2秒後才能操作", Seconds = 2)]
        public HttpResponseMessage DeleteSales(int id)
        {
            var data = context.Sales.FirstOrDefault(p => p.SalesId == id);
            if (data == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new HttpError("此筆資料不存在"));
            }
            context.Sales.Remove(data);
            context.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, new HttpError("刪除成功"));
        }
    }
}