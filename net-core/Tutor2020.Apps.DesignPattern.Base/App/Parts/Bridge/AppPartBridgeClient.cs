//Author Maxim Kuzmin//makc//

using System;
using Tutor2020.Mods.DesingPattern.Base.Parts.Bridge;
using Tutor2020.Mods.DesingPattern.Base.Parts.Bridge.Common;

namespace Tutor2020.Apps.DesignPattern.Base.App.Parts.Bridge
{
    /// <summary>
    /// Приложение. Часть "Bridge". Клиент.
    /// </summary>
    public class AppPartBridgeClient : ModDesignPatternBasePartBridgeClient
    {
        #region Protected methods

        /// <inheritdoc/>
        protected sealed override void UseService(ModDesignPatternBasePartBridgeCommonService service)
        {
            Console.WriteLine(service.GetProductName());
        }

        #endregion Protected methods
    }
}
