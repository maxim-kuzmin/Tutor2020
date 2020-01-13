//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Common.Products;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Types.First.Products
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "AbstractFactory".  Тип "First".  Продукт "Second".
    /// </summary>
    public class ModDesignPatternBasePartAbstractFactoryTypeFirstProductSecond : IModDesignPatternBasePartAbstractFactoryCommonProductSecond
    {
        #region Properties

        /// <inheritdoc/>
        public string SecondName
        { 
            get
            {
                return "Type: First. Product: Second.";
            }
        }

        #endregion Properties
    }
}
