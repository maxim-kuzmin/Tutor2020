//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Common;
using Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Common.Products;
using Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Types.First.Products;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Types.First
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "AbstractFactory". Тип "First". Создатель.
    /// </summary>
    public class ModDesignPatternBasePartAbstractFactoryTypeFirstCreator : IModDesignPatternBasePartAbstractFactoryCommonCreator
    {
        #region Public methods

        /// <inheritdoc/>
        public IModDesignPatternBasePartAbstractFactoryCommonProductFirst CreateProductFirst()
        {
            return new ModDesignPatternBasePartAbstractFactoryTypeFirstProductFirst();
        }

        /// <inheritdoc/>
        public IModDesignPatternBasePartAbstractFactoryCommonProductSecond CreateProductSecond()
        {
            return new ModDesignPatternBasePartAbstractFactoryTypeFirstProductSecond();
        }

        #endregion Public methods
    }
}
