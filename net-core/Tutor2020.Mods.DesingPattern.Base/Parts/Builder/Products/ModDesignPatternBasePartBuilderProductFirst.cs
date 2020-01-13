//Author Maxim Kuzmin//makc//

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Builder.Products
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Builder". Продукт "First".
    /// </summary>
    public class ModDesignPatternBasePartBuilderProductFirst
    {
        #region Properties

        /// <inheritdoc/>
        public string Name
        { 
            get
            {
                return $"First: {FirstName}";
            }
        }

        /// <summary>
        /// Первое имя.
        /// </summary>
        public string FirstName { get; set; }

        #endregion Properties
    }
}
