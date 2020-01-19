//Author Maxim Kuzmin//makc//

using System;
using Tutor2020.Mods.DesingPattern.Base.Parts.Command;

namespace Tutor2020.Apps.DesignPattern.Base.App.Parts.Command
{
    /// <summary>
    /// Приложение. Часть "Command". Клиент.
    /// </summary>
    public class AppPartCommandClient : ModDesignPatternBasePartCommandClient
    {
        #region Protected methods

        /// <inheritdoc/>
        protected sealed override void UseProduct(ModDesignPatternBasePartCommandProduct product)
        {
            Console.WriteLine(product.Name);
        }

        #endregion Protected methods
    }
}
