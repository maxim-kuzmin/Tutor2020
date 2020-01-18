//Author Maxim Kuzmin//makc//

using System;
using Tutor2020.Mods.DesingPattern.Base.Parts.Adapter;
using Tutor2020.Mods.DesingPattern.Base.Parts.Adapter.Common;

namespace Tutor2020.Apps.DesignPattern.Base.App.Parts.Adapter
{
    /// <summary>
    /// Приложение. Часть "Adapter". Клиент.
    /// </summary>
    public class AppPartAdapterClient : ModDesignPatternBasePartAdapterClient
    {
        #region Protected methods

        /// <inheritdoc/>
        protected sealed override void UseService(IModDesignPatternBasePartAdapterCommonService service)
        {
            Console.WriteLine(service.Name);
        }

        #endregion Protected methods
    }
}
