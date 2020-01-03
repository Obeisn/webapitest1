using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using webapitest1.Models;

namespace webapitest1.Controllers
{
    public class NewsController : ApiController
    {
        protected NewsEntities context = new NewsEntities();
        // GET api/<controller>
        [HttpGet]
        public IEnumerable<News> GetNews()
        {
            return context.News.ToList();
        }

        // GET api/<controller>/5
        [HttpGet]
        public News GetNew(int id)
        {
            return context.News.FirstOrDefault(p => p.id == id);
        }

        // POST api/<controller>      
        public HttpResponseMessage AddNew()
        {

            string path = System.Web.Hosting.HostingEnvironment.MapPath("~/Upload");
            var value = new News();
            try
            {
                var httpPostedFile = HttpContext.Current.Request.Files;
                value.title = HttpContext.Current.Request.Form["title"];
                value.content = HttpContext.Current.Request.Form["content"];
                string FileName = "";
                if (httpPostedFile != null && httpPostedFile.Count > 0)
                {
                    var file = httpPostedFile[0];
                    string imgType = Path.GetExtension(file.FileName);
                    //限制文件上傳類型
                    if (imgType.ToLower().Contains(".jpg") || imgType.ToLower().Contains(".png") || imgType.ToLower().Contains(".bmp"))
                    {
                        FileName = Guid.NewGuid().ToString() + imgType;
                        path = $"{path}/{FileName}";
                        file.SaveAs(path);
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound, new HttpError("檔案類型不正確"));
                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new HttpError("請上傳檔案!"));
                }
                value.image = FileName;
                context.News.Add(value);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new HttpError(ex.Message));
            }
            return Request.CreateResponse(HttpStatusCode.OK, new Message<object>(new { id = value.id, message = "成功!" }, statusEM.sucess));
        }

        // PUT api/<controller>/5
        [HttpPost]
        public HttpResponseMessage UpdateNew()
        {
            var value = new News();

            value.id = HttpContext.Current.Request.Form["id"] != null ? Convert.ToInt32(HttpContext.Current.Request.Form["id"]) : 0;
            var data = context.News.FirstOrDefault(p => p.id == value.id);
            value.title = HttpContext.Current.Request.Form["title"];
            value.content = HttpContext.Current.Request.Form["content"];
            if (data == null || value.title == null || value.content == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new HttpError("此筆資料不存在"));
            }

            var httpPostedFile = HttpContext.Current.Request.Files;
            if (httpPostedFile != null && httpPostedFile.Count > 0)
            {
                string path = System.Web.Hosting.HostingEnvironment.MapPath("~/Upload");
                var file = httpPostedFile[0];
                string imgType = Path.GetExtension(file.FileName);
                //限制文件上傳類型
                if (imgType.ToLower().Contains(".jpg") || imgType.ToLower().Contains(".png") || imgType.ToLower().Contains(".bmp"))
                {
                    string FileName = Guid.NewGuid().ToString() + imgType;
                    path = $"{path}/{FileName}";
                    file.SaveAs(path);
                    value.image = FileName;
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new HttpError("檔案類型不正確"));
                }
            }
            context.Entry(data).CurrentValues.SetValues(value);
            context.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, new HttpError("修改成功"));
        }
        // DELETE api/<controller>/5
        [HttpGet]
        public HttpResponseMessage DeleteNew(int id)
        {
            var data = context.News.FirstOrDefault(p => p.id == id);
            if (data == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new HttpError("此筆資料不存在"));
            }
            context.News.Remove(data);
            context.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, new HttpError("刪除成功"));
        }

        [HttpPost]
        public HttpResponseMessage MemberCheck(member member)
        {
            var data = context.member.Where(p => p.accont == member.accont && p.password == member.password);
            if (data.Count() > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { member = data.FirstOrDefault(), message = "成功!", status = true });
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new HttpError("登入失敗!"));
            }
        }

        [HttpGet]
        public IEnumerable<SubpartDTO> getSubpart(member member)
        {
            return (from q in context.Sidebar
                    where q.parentid == null
                    select new SubpartDTO
                    {
                        icon = q.icon,
                        id = q.id,
                        link = q.link,
                        submenu = context.Sidebar.Where(p=>p.parentid==q.id).Select(p=> new { id=p.id, icon=p.icon, link=p.link, title=p.title }),
                        title = q.title
                    }
                    );
        }
    }
}