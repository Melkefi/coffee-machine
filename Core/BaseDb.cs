using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class BaseDb
    {
        public int Id { get; set; }
        public DateTime _CreatedAt { get; set; }
        public DateTime _LastModifiedAt { get; set; }
    }
}
