using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Context;
using Microsoft.AspNetCore.Http;

namespace Reponsitory
{
    public abstract class Repository<T>
    {
        public readonly OTContext _context;
        public Repository(OTContext context)
        {
            _context = context;
        }

        protected int Code500
        {
            get
            {
                return StatusCodes.Status500InternalServerError;
            }
        }
        protected int Code200
        {
            get
            {
                return StatusCodes.Status200OK;
            }
        }
        protected int Code404
        {
            get
            {
                return StatusCodes.Status404NotFound;
            }
        }
    }
}
