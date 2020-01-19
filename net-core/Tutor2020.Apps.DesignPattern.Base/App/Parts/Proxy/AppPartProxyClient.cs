//Author Maxim Kuzmin//makc//

using System;
using Tutor2020.Mods.DesingPattern.Base.Parts.Proxy;
using Tutor2020.Mods.DesingPattern.Base.Parts.Proxy.Common;

namespace Tutor2020.Apps.DesignPattern.Base.App.Parts.Proxy
{
    /// <summary>
    /// Приложение. Часть "Proxy". Клиент.
    /// </summary>
    public class AppPartProxyClient : ModDesignPatternBasePartProxyClient
    {
        #region Protected methods

        /// <inheritdoc/>
        protected sealed override void UseProduct(IModDesignPatternBasePartProxyCommonProduct product)
        {
            Console.WriteLine(product.Name);
        }

        #endregion Protected methods
    }
}
