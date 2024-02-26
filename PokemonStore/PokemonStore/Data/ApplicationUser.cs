using Microsoft.AspNetCore.Identity;
using PokemonStore.Models;

namespace PokemonStore.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    ICollection<Pokemon> Pokemons { get; set; } = new List<Pokemon>();
}
