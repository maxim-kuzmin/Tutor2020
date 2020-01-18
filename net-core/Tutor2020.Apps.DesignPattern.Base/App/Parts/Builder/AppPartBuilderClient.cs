//Author Maxim Kuzmin//makc//

using System;
using Tutor2020.Mods.DesingPattern.Base.Parts.Builder;
using Tutor2020.Mods.DesingPattern.Base.Parts.Builder.Services;

namespace Tutor2020.Apps.DesignPattern.Base.App.Parts.Builder
{
    /// <summary>
    /// Приложение. Часть "Builder". Клиент.
    /// </summary>
    public class AppPartBuilderClient : ModDesignPatternBasePartBuilderClient
    {
        #region Protected methods

        /// <inheritdoc/>
        protected sealed override void UseServiceFirst(ModDesignPatternBasePartBuilderServiceFirst service)
        {
            Console.WriteLine(service.Result.FirstName);
        }

        /// <inheritdoc/>
        protected sealed override void UseServiceSecond(ModDesignPatternBasePartBuilderServiceSecond service)
        {
            Console.WriteLine(service.Result.SecondName);
        }

        #endregion Protected methods
    }
}
