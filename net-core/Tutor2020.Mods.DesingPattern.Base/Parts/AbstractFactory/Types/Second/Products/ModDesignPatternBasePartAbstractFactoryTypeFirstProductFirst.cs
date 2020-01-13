//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Common.Products;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Types.Second.Products
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "AbstractFactory". Тип "Second".  Продукт "First".
    /// </summary>
    public class ModDesignPatternBasePartAbstractFactoryTypeSecondProductFirst : IModDesignPatternBasePartAbstractFactoryCommonProductFirst
    {
        #region Properties

        /// <inheritdoc/>
        public string FirstName
        { 
            get
            {
                return "Type: Second. Product: First.";
            }
        }

        #endregion Properties
    }
}
