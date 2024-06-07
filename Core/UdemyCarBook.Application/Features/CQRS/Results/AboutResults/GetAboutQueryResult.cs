using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.CQRS.Results.AboutResults
{
    public class GetAboutQueryResult
    {
        public int AboutID { get; set; }
        public int Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
