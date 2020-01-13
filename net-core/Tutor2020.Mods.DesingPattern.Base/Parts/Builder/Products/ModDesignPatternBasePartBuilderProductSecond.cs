//Author Maxim Kuzmin//makc//

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Builder.Products
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Builder". Продукт "Second".
    /// </summary>
    public class ModDesignPatternBasePartBuilderProductSecond
    {
        #region Properties

        /// <inheritdoc/>
        public string Name
        { 
            get
            {
                return $"Second: {SecondName}";
            }
        }

        /// <summary>
        /// Второе имя.
        /// </summary>
        public string SecondName { get; set; }

        #endregion Properties
    }
}
