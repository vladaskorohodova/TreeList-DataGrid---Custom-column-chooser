using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using TreeList_DataGrid___Custom_Column_Chooser.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace TreeList_DataGrid___Custom_Column_Chooser.Controllers {

    [Route("api/[controller]")]
    public class SampleDataController : Controller {

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions) {
            return DataSourceLoader.Load(SampleData.Orders, loadOptions);
        }

    }
}