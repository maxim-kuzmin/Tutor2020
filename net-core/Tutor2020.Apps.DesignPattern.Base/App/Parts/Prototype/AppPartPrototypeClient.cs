//Author Maxim Kuzmin//makc//

using System;
using System.Collections.Generic;
using Tutor2020.Mods.DesingPattern.Base.Parts.Prototype;
using Tutor2020.Mods.DesingPattern.Base.Parts.Prototype.Common;

namespace Tutor2020.Apps.DesignPattern.Base.App.Parts.Prototype
{
    /// <summary>
    /// Приложение. Часть "Prototype". Клиент.
    /// </summary>
    public class AppPartPrototypeClient : ModDesignPatternBasePartPrototypeClient
    {
        #region Protected methods

        /// <inheritdoc/>
        protected sealed override void UseClones(IEnumerable<IModDesignPatternBasePartPrototypeCommonProduct> clones)
        {
            Console.WriteLine("Clones:");

            foreach (var clone in clones)
            {
                Console.WriteLine(clone.Name);
            }
        }

        /// <inheritdoc/>
        protected sealed override void UsePrototypes(IEnumerable<IModDesignPatternBasePartPrototypeCommonProduct> prototypes)
        {
            Console.WriteLine("Prototypes:");

            foreach (var prototype in prototypes)
            {
                Console.WriteLine(prototype.Name);
            }
        }

        #endregion Protected methods
    }
}
