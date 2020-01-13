//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Common.Products;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Types.Second.Products
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "AbstractFactory".  Тип "Second".  Продукт "Second".
    /// </summary>
    public class ModDesignPatternBasePartAbstractFactoryTypeSecondProductSecond : IModDesignPatternBasePartAbstractFactoryCommonProductSecond
    {
        #region Properties

        /// <inheritdoc/>
        public string SecondName
        { 
            get
            {
                return "Type: Second. Product: Second.";
            }
        }

        #endregion Properties
    }
}
