//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Fasade.Products;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Fasade
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Fasade". Сервис.
    /// </summary>
    public class ModDesignPatternBasePartFasadeService
    {
        #region Properties

        private ModDesignPatternBasePartFasadeProductFirst ProductFirst { get; set; }

        private ModDesignPatternBasePartFasadeProductSecond ProductSecond { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="productFirst">Продукт "First".</param>
        /// <param name="productSecond">Продукт "Second".</param>
        public ModDesignPatternBasePartFasadeService(
            ModDesignPatternBasePartFasadeProductFirst productFirst,
            ModDesignPatternBasePartFasadeProductSecond productSecond
            )
        {
            ProductFirst = productFirst;
            ProductSecond = productSecond;
        }

        #endregion Constructors

        #region Public methods

        /// <summary>
        /// Получить имя продукта.
        /// </summary>
        /// <returns>Имя продукта.</returns>
        public string GetProductName()
        {
            return $"{ProductFirst.FirstName}, {ProductSecond.SecondName}";
        }

        #endregion Public methods
    }
}
