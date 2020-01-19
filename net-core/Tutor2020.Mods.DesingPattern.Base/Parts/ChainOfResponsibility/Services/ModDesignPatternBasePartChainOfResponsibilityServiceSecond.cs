//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.ChainOfResponsibility.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.ChainOfResponsibility.Services
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "ChainOfResponsibility". Сервис "Second".
    /// </summary>
    public class ModDesignPatternBasePartChainOfResponsibilityServiceSecond : ModDesignPatternBasePartChainOfResponsibilityCommonService
    {
        #region Public methods

        /// <inheritdoc/>
        public sealed override void HandleProduct(ModDesignPatternBasePartChainOfResponsibilityProduct product)
        {
            product.Name += ": Second";

            base.HandleProduct(product);
        }

        #endregion Public methods
    }
}
