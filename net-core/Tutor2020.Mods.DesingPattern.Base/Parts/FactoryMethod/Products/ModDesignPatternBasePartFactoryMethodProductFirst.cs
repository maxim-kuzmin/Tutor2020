//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod.Products
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "FactoryMethod". Продукт "First".
    /// </summary>
    public class ModDesignPatternBasePartFactoryMethodProductFirst : IModDesignPatternBasePartFactoryMethodCommonProduct
    {
        #region Properties

        /// <inheritdoc/>
        public string Name
        { 
            get
            {
                return "First";
            }
        }

        #endregion Properties
    }
}
