//Author Maxim Kuzmin//makc//

namespace Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod.Common
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "FactoryMethod". Общее. Сервис.
    /// </summary>
    public abstract class ModDesignPatternBasePartFactoryMethodCommonService
    {
        #region Public methods

        /// <summary>
        /// Получить имя продукта.
        /// </summary>
        /// <returns>Имя продукта.</returns>
        public string GetProductName()
        {
            return CreateProduct().Name;
        }

        #endregion Public methods

        #region Protected methods

        /// <summary>
        /// Создать продукт.
        /// </summary>
        /// <returns>Продукт.</returns>
        protected abstract IModDesignPatternBasePartFactoryMethodCommonProduct CreateProduct();

        #endregion Protected methods
    }
}
