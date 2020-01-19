//Author Maxim Kuzmin//makc//

using System;
using System.Linq;
using Tutor2020.Mods.DesingPattern.Base.Parts.Iterator;

namespace Tutor2020.Apps.DesignPattern.Base.App.Parts.Iterator
{
    /// <summary>
    /// Приложение. Часть "Iterator". Клиент.
    /// </summary>
    public class AppPartIteratorClient : ModDesignPatternBasePartIteratorClient
    {
        #region Protected methods

        /// <inheritdoc/>
        protected sealed override void UseCollection(ModDesignPatternBasePartIteratorCollection collection)
        {
            Console.WriteLine(string.Join(", ", collection.Select(x => x.Name)));
        }

        #endregion Protected methods
    }
}
