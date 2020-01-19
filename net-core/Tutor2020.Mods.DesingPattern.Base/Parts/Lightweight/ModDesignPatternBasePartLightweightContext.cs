//Author Maxim Kuzmin//makc//

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Lightweight
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Lightweight". Контекст.
    /// </summary>
    public class ModDesignPatternBasePartLightweightContext
    {
        #region Properties

        private ModDesignPatternBasePartLightweightProduct Product { get; set; }

        private ModDesignPatternBasePartLightweightService Service { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="factory">Фабрика.</param>
        /// <param name="state">Состояние.</param>
        /// <param name="product">Продукт.</param>
        public ModDesignPatternBasePartLightweightContext(
            ModDesignPatternBasePartLightweightFactory factory,
            ModDesignPatternBasePartLightweightState state,
            ModDesignPatternBasePartLightweightProduct product
            )
        {
            Service = factory.GetService(state);
            Product = product;
        }

        #endregion Constructors

        #region Public methods

        /// <summary>
        /// Получить состояние продукта.
        /// </summary>
        /// <returns>Состояние продукта.</returns>
        public string GetProductState()
        {
            return Service.GetProductState(Product);
        }

        #endregion Public methods
    }
}
