//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod.Products
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "FactoryMethod". Продукт "Second".
    /// </summary>
    public class ModDesignPatternBasePartFactoryMethodProductSecond : IModDesignPatternBasePartFactoryMethodCommonProduct
    {
        #region Properties

        /// <inheritdoc/>
        public string Name
        { 
            get
            {
                return "Second";
            }
        }

        #endregion Properties
    }
}
