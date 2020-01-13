//Author Maxim Kuzmin//makc//

namespace Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod.Products
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "FactoryMethod". Продукт "Second".
    /// </summary>
    public class ModDesignPatternBasePartFactoryMethodProductSecond : IModDesignPatternBasePartFactoryMethodProduct
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
