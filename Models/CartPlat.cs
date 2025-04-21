using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newRestaurant.Models
{
    public class CartPlat
    {
        // Composite Key defined in DbContext
        public int CartId { get; set; }
        public int PlatId { get; set; }

        public int Quantity { get; set; } = 1; // How many of this plat in the cart

        // Navigation Properties
        [ForeignKey("CartId")]
        public virtual Cart Cart { get; set; }

        [ForeignKey("PlatId")]
        public virtual Plat Plat { get; set; }

        [NotMapped] // Tell EF Core not to map this to the database
        public decimal TotalLinePrice => (Plat?.Price ?? 0) * Quantity;
    }
}
