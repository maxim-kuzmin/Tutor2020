//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Bridge.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Bridge.Products
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Bridge". Продукт "Second".
    /// </summary>
    public class ModDesignPatternBasePartBridgeProductSecond : IModDesignPatternBasePartBridgeCommonProduct
    {
        #region Properties

        /// <inheritdoc/>
        public string Name
        { 
            get
            {
                return "Second";
            }
        }

        #endregion Properties
    }
}
