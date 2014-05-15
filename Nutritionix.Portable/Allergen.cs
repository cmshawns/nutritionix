
// ReSharper disable CSharpWarnings::CS1591

using System.ComponentModel.DataAnnotations;

namespace Nutritionix
{
    /// <summary>
    /// Types of food allergens
    /// </summary>
    public enum Allergen
    {
        /// <summary>
        /// Contains milk
        /// </summary>
        [Display(Description="allergen_contains_milk")]
        Milk,

        /// <summary>
        /// Contains eggs
        /// </summary>
        [Display(Description="allergen_contains_eggs")]
        Eggs,
        
        /// <summary>
        /// Contains fish
        /// </summary>
        [Display(Description="allergen_contains_fish")]
        Fish,
        
        /// <summary>
        /// Contains shellfish
        /// </summary>
        [Display(Description="allergen_contains_shellfish")]
        Shellfish,
        
        /// <summary>
        /// Contains tree nuts
        /// </summary>
        [Display(Description="allergen_contains_tree_nuts")]
        TreeNuts,
        
        /// <summary>
        /// Contains peanuts
        /// </summary>
        [Display(Description="allergen_contains_peanuts")]
        Peanuts,
        
        /// <summary>
        /// Contains wheat
        /// </summary>
        [Display(Description="allergen_contains_wheat")]
        Wheat,
        
        /// <summary>
        /// Contains soy
        /// </summary>
        [Display(Description="allergen_contains_soybeans")]
        Soybeans,
        
        /// <summary>
        /// Contains gluten
        /// </summary>
        [Display(Description="allergen_contains_gluten")]
        Gluten
    }
}