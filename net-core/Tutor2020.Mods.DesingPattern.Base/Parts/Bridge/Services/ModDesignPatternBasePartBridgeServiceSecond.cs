//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Bridge.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Bridge.Services
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Bridge". Сервис "Second".
    /// </summary>
    public class ModDesignPatternBasePartBridgeServiceSecond : ModDesignPatternBasePartBridgeCommonService
    {
        #region Constructors

        /// <inheritdoc/>
        public ModDesignPatternBasePartBridgeServiceSecond(IModDesignPatternBasePartBridgeCommonProduct product)
            : base(product)
        {
        }

        #endregion Constructors

        #region Public methods

        /// <inheritdoc/>
        public sealed override string GetProductName()
        {
            return $"Second: {base.GetProductName()}";
        }

        #endregion Public methods        
    }
}
