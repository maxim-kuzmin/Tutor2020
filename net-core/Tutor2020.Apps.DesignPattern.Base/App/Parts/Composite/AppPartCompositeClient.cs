//Author Maxim Kuzmin//makc//

using System;
using Tutor2020.Mods.DesingPattern.Base.Parts.Composite;

namespace Tutor2020.Apps.DesignPattern.Base.App.Parts.Composite
{
    /// <summary>
    /// Приложение. Часть "Composite". Клиент.
    /// </summary>
    public class AppPartCompositeClient : ModDesignPatternBasePartCompositeClient
    {
        #region Protected methods

        /// <inheritdoc/>
        protected sealed override void UseService(ModDesignPatternBasePartCompositeService service)
        {
            Console.WriteLine(service.GetProductName());
        }

        #endregion Protected methods
    }
}
