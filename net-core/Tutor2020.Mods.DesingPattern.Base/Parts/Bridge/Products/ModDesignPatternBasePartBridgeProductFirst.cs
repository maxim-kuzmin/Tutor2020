//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Bridge.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Bridge.Products
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Bridge". Продукт "First".
    /// </summary>
    public class ModDesignPatternBasePartBridgeProductFirst : IModDesignPatternBasePartBridgeCommonProduct
    {
        #region Properties

        /// <inheritdoc/>
        public string Name
        { 
            get
            {
                return "First";
            }
        }

        #endregion Properties
    }
}
