using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AccountingRazor2021.Services
{
    public interface IEmailService
    {
        Task Send(string to, string subject, string html, string from = null, List<IFormFile> files = null);
    }
}
