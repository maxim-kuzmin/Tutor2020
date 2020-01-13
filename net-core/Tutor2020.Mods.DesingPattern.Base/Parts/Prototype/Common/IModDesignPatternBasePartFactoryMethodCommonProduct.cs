//Author Maxim Kuzmin//makc//

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Prototype.Common
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Prototype". Общее. Продукт. Интерфейс.
    /// </summary>
    public interface IModDesignPatternBasePartPrototypeCommonProduct
    {
        #region Properties

        /// <summary>
        /// Имя.
        /// </summary>
        string Name { get; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Клонировать.
        /// </summary>
        /// <returns>Продукт.</returns>
        IModDesignPatternBasePartPrototypeCommonProduct Clone();

        #endregion Methods
    }
}
