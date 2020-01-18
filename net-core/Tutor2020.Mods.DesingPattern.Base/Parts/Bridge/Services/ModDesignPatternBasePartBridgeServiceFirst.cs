//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Bridge.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Bridge.Services
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Bridge". Сервис "First".
    /// </summary>
    public class ModDesignPatternBasePartBridgeServiceFirst : ModDesignPatternBasePartBridgeCommonService
    {
        #region Constructors

        /// <inheritdoc/>
        public ModDesignPatternBasePartBridgeServiceFirst(IModDesignPatternBasePartBridgeCommonProduct product)
            : base(product)
        {
        }

        #endregion Constructors

        #region Public methods

        /// <inheritdoc/>
        public sealed override string GetProductName()
        {
            return "First: " + base.GetProductName();
        }

        #endregion Public methods        
    }
}
