//Author Maxim Kuzmin//makc//

using System;
using Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory;
using Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Common;

namespace Tutor2020.Apps.DesignPattern.Base.App.Parts.AbstractFactory
{
    /// <summary>
    /// Приложение. Часть "AbstractFactory". Клиент.
    /// </summary>
    public class AppPartAbstractFactoryClient : ModDesignPatternBasePartAbstractFactoryClient
    {
        #region Protected methods

        /// <inheritdoc/>
        protected sealed override void UseService(IModDesignPatternBasePartAbstractFactoryCommonService service)
        {            
            Console.WriteLine(service.CreateProductFirst().FirstName);
            Console.WriteLine(service.CreateProductSecond().SecondName);
        }

        #endregion Protected methods
    }
}
