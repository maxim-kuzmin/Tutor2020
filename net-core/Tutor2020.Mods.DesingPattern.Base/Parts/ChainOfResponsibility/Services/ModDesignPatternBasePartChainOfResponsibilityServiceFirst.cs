//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.ChainOfResponsibility.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.ChainOfResponsibility.Services
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "ChainOfResponsibility". Сервис "First".
    /// </summary>
    public class ModDesignPatternBasePartChainOfResponsibilityServiceFirst : ModDesignPatternBasePartChainOfResponsibilityCommonService
    {
        #region Public methods

        /// <inheritdoc/>
        public sealed override void HandleProduct(ModDesignPatternBasePartChainOfResponsibilityProduct product)
        {
            product.Name += ": First";

            base.HandleProduct(product);
        }

        #endregion Public methods
    }
}
