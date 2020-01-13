﻿//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Common.Products;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Common
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "AbstractFactory". Общее. Создатель. Интерфейс.
    /// </summary>
    public interface IModDesignPatternBasePartAbstractFactoryCommonCreator
    {
        #region Methods

        /// <summary>
        /// Создать продукт "First".
        /// </summary>
        /// <returns>Продукт "First".</returns>
        IModDesignPatternBasePartAbstractFactoryCommonProductFirst CreateProductFirst();

        /// <summary>
        /// Создать продукт "Second".
        /// </summary>
        /// <returns>Продукт "Second".</returns>
        IModDesignPatternBasePartAbstractFactoryCommonProductSecond CreateProductSecond();

        #endregion Methods
    }
}
