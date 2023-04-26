using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupAPIFinal.Models;

public class UserFoods
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string FavMeal { get; set; }

    public string FavFruit { get; set; }

    public string FavMeat { get; set; }

    public string FavCuisine { get; set; }

}
