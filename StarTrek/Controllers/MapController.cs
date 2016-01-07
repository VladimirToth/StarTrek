using StarTrek.DrawModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarTrek.Controllers
{
    //http://www.html5canvastutorials.com/tutorials/html5-canvas-custom-shapes/

    //http://literallycanvas.com/

    //http://weblogs.asp.net/dwahlin/getting-started-with-the-html-5-canvas

    //http://stackoverflow.com/questions/9880279/how-do-i-add-a-simple-onclick-event-handler-to-a-canvas-element

    //http://stackoverflow.com/questions/2296097/making-an-svg-image-object-clickable-with-onclick-avoiding-absolute-positioning

    //http://www.techrepublic.com/blog/web-designer/html5-working-with-the-canvas-element/?tag=content%3Bblog-list-river

    //https://www.youtube.com/watch?v=gLTw9vqrPIw

    public class MapController : Controller
    {
        // GET: Map
        [HttpGet]
        public ActionResult Index()
        {

            return View(new RectangleDraw { X = 80, Y = 80 });
        }
    }
}