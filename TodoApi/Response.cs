using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi
{
    public class Response
    {
        public TodoItem todoItem { get; private set; }
        public string message { get; private set; }

        public Response(TodoItem i, string m)
        {
            todoItem = i;
            message = m;
        }
    }
}
