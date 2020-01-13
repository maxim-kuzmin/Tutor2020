//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Common.Products;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Types.First.Products
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "AbstractFactory". Тип "First".  Продукт "First".
    /// </summary>
    public class ModDesignPatternBasePartAbstractFactoryTypeFirstProductFirst : IModDesignPatternBasePartAbstractFactoryCommonProductFirst
    {
        #region Properties

        /// <inheritdoc/>
        public string FirstName
        { 
            get
            {
                return "Type: First. Product: First.";
            }
        }

        #endregion Properties
    }
}
