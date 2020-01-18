//Author Maxim Kuzmin//makc//

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Bridge.Common
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Bridge". Общее. Сервис.
    /// </summary>
    public abstract class ModDesignPatternBasePartBridgeCommonService
    {
        #region Properties

        private IModDesignPatternBasePartBridgeCommonProduct Product { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="product">Продукт.</param>
        public ModDesignPatternBasePartBridgeCommonService(IModDesignPatternBasePartBridgeCommonProduct product)
        {
            Product = product;
        }

        #endregion Constructors

        #region Public methods

        /// <summary>
        /// Получить имя продукта.
        /// </summary>
        /// <returns>Имя продукта.</returns>
        public virtual string GetProductName()
        {
            return Product.Name;
        }

        #endregion Public methods
    }
}
