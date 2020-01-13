//Author Maxim Kuzmin//makc//

namespace Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "FactoryMethod". Создатель.
    /// </summary>
    public abstract class ModDesignPatternBasePartFactoryMethodCreator
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
        protected abstract IModDesignPatternBasePartFactoryMethodProduct CreateProduct();

        #endregion Protected methods
    }
}
