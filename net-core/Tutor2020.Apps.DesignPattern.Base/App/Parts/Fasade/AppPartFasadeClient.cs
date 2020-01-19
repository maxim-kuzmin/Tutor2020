//Author Maxim Kuzmin//makc//

using System;
using Tutor2020.Mods.DesingPattern.Base.Parts.Fasade;

namespace Tutor2020.Apps.DesignPattern.Base.App.Parts.Fasade
{
    /// <summary>
    /// Приложение. Часть "Fasade". Клиент.
    /// </summary>
    public class AppPartFasadeClient : ModDesignPatternBasePartFasadeClient
    {
        #region Protected methods

        /// <inheritdoc/>
        protected sealed override void UseService(ModDesignPatternBasePartFasadeService service)
        {
            Console.WriteLine(service.GetProductName());
        }

        #endregion Protected methods
    }
}
