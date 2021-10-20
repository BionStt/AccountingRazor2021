using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingRazor2021.Dto;
using AccountingRazor2021.Mapping;
using AccountingRazor2021.ServiceApplication.DataAccount.Queries.ListDataAccount;
using AccountingRazor2021.ServiceApplication.DataAccount.Queries.ListDataAccountForParent;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.Net.Mime;
using AccountingRazor2021.ServiceApplication.DataAccount.Queries.ListDataAccountForParent2;

namespace AccountingRazor2021.Pages.DataAccount
{
    public class CreateDataAccountModel : PageModel
    {
        private readonly IMediator _mediator;


        public CreateDataAccountModel(IMediator mediator)
        {
            _mediator = mediator;
        }
        [BindProperty]
        public CreateDataAccountCommandRequest DataAccount { get; set; }

        public async Task OnGetAsync()
        {
            var DataAccounting = await _mediator.Send(new ListDataAccountForParentQuery());
            ViewData["insert1"] = new SelectList(DataAccounting, "NoUrutId", "NamaAkun");

        }

        //[Consumes(MediaTypeNames.Application.Json)]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> OnPostAsync(string Kelompok1,string NormalPos1,string Parent1)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            DataAccount.Kelompok = Kelompok1;
            DataAccount.Parent = Parent1;
            DataAccount.NormalPos = int.Parse(NormalPos1);

            var xx = DataAccount.ToCommandDapper();
            await _mediator.Send(xx);



            return RedirectToPage();
          //  return RedirectToPage("./Index");


        }


        public async Task<JsonResult> OnGetFilter(string data1a)
        {
            if (data1a == "0")
            {
                var aa = await _mediator.Send(new ListDataAccountForParentQuery());

                var bb = aa.Select(x => new { Value = x.NoUrutId, Text = x.NamaAkun  }).ToList();

                return new JsonResult(Newtonsoft.Json.JsonConvert.SerializeObject(bb));


            }
            else
            {

                var aa = await _mediator.Send(new ListDataAccountForParent2Query { Data1 = int.Parse(data1a) });

                var bb = aa.Select(x => new { Value = x.NoUrutId, Text = x.NamaAkun }).ToList();

                return new JsonResult(Newtonsoft.Json.JsonConvert.SerializeObject(bb));
            }
        }
        public async Task<JsonResult> OnPostFilter(string data1a)
        {
            if (data1a == "0")
            {
                var aa = await _mediator.Send(new ListDataAccountForParentQuery());

                //var aa = (from a in _context.DataAccounts
                //          orderby a.KodeAccount
                //          where (a.Parent == null)
                //          let nm = "[" + a.KodeAccount + "] - " + a.Account + " - " + Analyze(a.Kelompok) + " - " + NormalPos(a.NormalPos)
                //          select new
                //          {
                //              a.Id,
                //              nm
                //          });

                var bb = aa.Select(x => new { Value = x.NoUrutId, Text = x.NamaAkun }).ToList();
                //return Json(JsonSerializer.Serialize(bb));

                return new JsonResult(Newtonsoft.Json.JsonConvert.SerializeObject(bb));
            }
            else
            {
                var aa = await _mediator.Send(new ListDataAccountForParent2Query { Data1 = int.Parse(data1a) });

                //var aa = (from parent in _context.DataAccounts
                //          from child in _context.DataAccounts
                //          where child.Lft > parent.Lft && child.Lft < parent.Rgt && parent.Id == Int32.Parse(data1a)
                //          orderby child.KodeAccount
                //          let nm = "[" + child.KodeAccount + "] - " + child.Account + " - " + Analyze(child.Kelompok) + " - " + NormalPos(child.NormalPos)
                //          select new
                //          {
                //              child.Id,
                //              nm
                //          }
                //          );

                var bb = aa.Select(x => new { Value = x.NoUrutId, Text = x.NamaAkun }).ToList();
                //return Json(JsonSerializer.Serialize(bb));
                return new JsonResult(Newtonsoft.Json.JsonConvert.SerializeObject(bb));
            }

        }
        public async Task<JsonResult> GetAccount(string data1a)//ajax calls this function which will return json object

        {
            if (data1a == "0")
            {
                var aa = await  _mediator.Send(new ListDataAccountForParentQuery());

                //var aa = (from a in _context.DataAccounts
                //          orderby a.KodeAccount
                //          where (a.Parent == null)
                //          let nm = "[" + a.KodeAccount + "] - " + a.Account + " - " + Analyze(a.Kelompok) + " - " + NormalPos(a.NormalPos)
                //          select new
                //          {
                //              a.Id,
                //              nm
                //          });

                var bb = aa.Select(x => new { Value = x.NoUrutId, Text = x.NamaAkun }).ToList();
                //return Json(JsonSerializer.Serialize(bb));

                return new JsonResult(Newtonsoft.Json.JsonConvert.SerializeObject(bb));
            }
            else
            {
                var aa = await  _mediator.Send(new ListDataAccountForParent2Query { Data1 = int.Parse(data1a) });

                //var aa = (from parent in _context.DataAccounts
                //          from child in _context.DataAccounts
                //          where child.Lft > parent.Lft && child.Lft < parent.Rgt && parent.Id == Int32.Parse(data1a)
                //          orderby child.KodeAccount
                //          let nm = "[" + child.KodeAccount + "] - " + child.Account + " - " + Analyze(child.Kelompok) + " - " + NormalPos(child.NormalPos)
                //          select new
                //          {
                //              child.Id,
                //              nm
                //          }
                //          );

                var bb = aa.Select(x => new { Value = x.NoUrutId, Text = x.NamaAkun }).ToList();
                //return Json(JsonSerializer.Serialize(bb));
                return new JsonResult(Newtonsoft.Json.JsonConvert.SerializeObject(bb));
            }


        }



    }
}
