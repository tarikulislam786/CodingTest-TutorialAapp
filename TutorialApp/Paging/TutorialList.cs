using TutorialApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorialApp.Models;

namespace TutorialApp.Paging
{
    public class TutorialList
    {
        public IEnumerable<Tutorial> tutorial { get; set; }
        public PagingInfo pagingInfo { get; set; }
    }
}