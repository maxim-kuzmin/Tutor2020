//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Common;
using Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Common.Products;
using Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Types.Second.Products;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Types.Second
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "AbstractFactory". Тип "Second". Сервис.
    /// </summary>
    public class ModDesignPatternBasePartAbstractFactoryTypeSecondCreator : IModDesignPatternBasePartAbstractFactoryCommonService
    {
        #region Public methods

        /// <inheritdoc/>
        public IModDesignPatternBasePartAbstractFactoryCommonProductFirst CreateProductFirst()
        {
            return new ModDesignPatternBasePartAbstractFactoryTypeSecondProductFirst();
        }

        /// <inheritdoc/>
        public IModDesignPatternBasePartAbstractFactoryCommonProductSecond CreateProductSecond()
        {
            return new ModDesignPatternBasePartAbstractFactoryTypeSecondProductSecond();
        }

        #endregion Public methods
    }
}
