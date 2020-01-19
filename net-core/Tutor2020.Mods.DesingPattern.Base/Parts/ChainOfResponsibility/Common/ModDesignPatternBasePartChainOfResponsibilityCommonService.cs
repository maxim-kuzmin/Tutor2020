//Author Maxim Kuzmin//makc//

using System.Collections.Generic;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.ChainOfResponsibility.Common
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "ChainOfResponsibility". Общее. Сервис.
    /// </summary>
    public class ModDesignPatternBasePartChainOfResponsibilityCommonService
    {
        #region Properties

        private ModDesignPatternBasePartChainOfResponsibilityCommonService NextService { get; set; }

        #endregion Properties

        #region Public methods

        /// <summary>
        /// Обработать продукт.
        /// </summary>
        /// <param name="product">Продукт.</param>
        public virtual void HandleProduct(ModDesignPatternBasePartChainOfResponsibilityProduct product)
        {
            NextService?.HandleProduct(product);
        }

        /// <summary>
        /// Установить следующий сервис.
        /// </summary>
        /// <param name="service">Сервис.</param>
        /// <returns>Следующий сервис.</returns>
        public ModDesignPatternBasePartChainOfResponsibilityCommonService SetNextService(
            ModDesignPatternBasePartChainOfResponsibilityCommonService service
            )
        {
            return NextService = service;
        }

        #endregion Public methods
    }
}
