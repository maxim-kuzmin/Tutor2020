//Author Maxim Kuzmin//makc//

using System;
using Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod;

namespace Tutor2020.Apps.DesignPattern.Base.App.Parts.FactoryMethod
{
    /// <summary>
    /// Приложение. Часть "FactoryMethod". Клиент.
    /// </summary>
    public class AppPartFactoryMethodClient : ModDesignPatternBasePartFactoryMethodClient
    {
        #region Protected methods

        /// <inheritdoc/>
        protected sealed override void UseCreator(ModDesignPatternBasePartFactoryMethodCreator creator)
        {
            Console.WriteLine(creator.GetProductName());
        }

        #endregion Protected methods
    }
}
