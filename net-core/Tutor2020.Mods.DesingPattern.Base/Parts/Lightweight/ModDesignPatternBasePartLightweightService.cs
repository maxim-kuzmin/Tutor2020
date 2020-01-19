//Author Maxim Kuzmin//makc//

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Lightweight
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Lightweight". Сервис.
    /// </summary>
    public class ModDesignPatternBasePartLightweightService
    {
        #region Properties

        private ModDesignPatternBasePartLightweightState State { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="state">Состояние.</param>
        public ModDesignPatternBasePartLightweightService(ModDesignPatternBasePartLightweightState state)
        {
            State = state;
        }

        #endregion Constructors

        #region Public methods

        /// <summary>
        /// Получить состояние продукта.
        /// </summary>
        /// <returns>Продукт.</returns>
        public string GetProductState(ModDesignPatternBasePartLightweightProduct product)
        {
            return $"{product.Name}: {State.Name}";
        }

        #endregion Public methods
    }
}
