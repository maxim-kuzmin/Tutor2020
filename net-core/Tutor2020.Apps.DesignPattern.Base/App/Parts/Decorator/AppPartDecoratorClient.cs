﻿//Author Maxim Kuzmin//makc//

using System;
using Tutor2020.Mods.DesingPattern.Base.Parts.Decorator;
using Tutor2020.Mods.DesingPattern.Base.Parts.Decorator.Common;

namespace Tutor2020.Apps.DesignPattern.Base.App.Parts.Decorator
{
    /// <summary>
    /// Приложение. Часть "Decorator". Клиент.
    /// </summary>
    public class AppPartDecoratorClient : ModDesignPatternBasePartDecoratorClient
    {
        #region Protected methods

        /// <inheritdoc/>
        protected sealed override void UseProduct(IModDesignPatternBasePartDecoratorCommonProduct product)
        {
            Console.WriteLine(product.Name);
        }

        #endregion Protected methods
    }
}
