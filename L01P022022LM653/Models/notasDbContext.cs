using Microsoft.EntityFrameworkCore;

namespace L01P022022LM653.Models
{
    public class notasDbContext:DbContext
    {
        public notasDbContext(DbContextOptions options ) : base(options) 
        {
            
        }
    }
}
