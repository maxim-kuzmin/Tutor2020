//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Proxy.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Proxy
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Proxy". Продукт.
    /// </summary>
    public class ModDesignPatternBasePartProxyProduct : IModDesignPatternBasePartProxyCommonProduct
    {
        #region Properties

        /// <inheritdoc/>
        public string Name { get; set; }

        #endregion Properties
    }
}
