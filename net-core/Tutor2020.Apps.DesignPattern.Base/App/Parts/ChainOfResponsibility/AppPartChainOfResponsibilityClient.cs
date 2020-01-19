//Author Maxim Kuzmin//makc//

using System;
using Tutor2020.Mods.DesingPattern.Base.Parts.ChainOfResponsibility;

namespace Tutor2020.Apps.DesignPattern.Base.App.Parts.ChainOfResponsibility
{
    /// <summary>
    /// Приложение. Часть "ChainOfResponsibility". Клиент.
    /// </summary>
    public class AppPartChainOfResponsibilityClient : ModDesignPatternBasePartChainOfResponsibilityClient
    {
        #region Protected methods

        /// <inheritdoc/>
        protected sealed override void UseProduct(ModDesignPatternBasePartChainOfResponsibilityProduct product)
        {
            Console.WriteLine(product.Name);
        }

        #endregion Protected methods
    }
}
