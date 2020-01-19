//Author Maxim Kuzmin//makc//

using System;
using Tutor2020.Mods.DesingPattern.Base.Parts.Lightweight;

namespace Tutor2020.Apps.DesignPattern.Base.App.Parts.Lightweight
{
    /// <summary>
    /// Приложение. Часть "Lightweight". Клиент.
    /// </summary>
    public class AppPartLightweightClient : ModDesignPatternBasePartLightweightClient
    {
        #region Protected methods

        /// <inheritdoc/>
        protected sealed override void UseContext(ModDesignPatternBasePartLightweightContext context)
        {
            Console.WriteLine(context.GetProductState());
        }

        #endregion Protected methods
    }
}
