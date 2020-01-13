//Author Maxim Kuzmin//makc//

using System.Collections.Generic;
using Tutor2020.Mods.DesingPattern.Base.Parts.Prototype.Common;
using Tutor2020.Mods.DesingPattern.Base.Parts.Prototype.Products;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Prototype
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Prototype". Клиент.
    /// </summary>
    public abstract class ModDesignPatternBasePartPrototypeClient
    {
        #region Public methods

        /// <summary>
        /// Запустить.
        /// </summary>
        public void Run()
        {
            var prototypes = new IModDesignPatternBasePartPrototypeCommonProduct[]
            {
                new ModDesignPatternBasePartPrototypeProductFirst
                {
                    FirstName = "FirstName"
                },
                new ModDesignPatternBasePartPrototypeProductSecond
                {
                    SecondName = "SecondName"
                }
            };

            UsePrototypes(prototypes);

            var clones = new List<IModDesignPatternBasePartPrototypeCommonProduct>();

            foreach (var prototype in prototypes)
            {
                clones.Add(prototype.Clone());
            }

            UseClones(clones);

            foreach (var clone in clones)
            {
                if (clone is ModDesignPatternBasePartPrototypeProductFirst cloneFirst)
                {
                    cloneFirst.FirstName = "FirstName 1";
                }
                else if (clone is ModDesignPatternBasePartPrototypeProductSecond cloneSecond)
                {
                    cloneSecond.SecondName = "SecondName 1";
                }
            }

            UseClones(clones);

            UsePrototypes(prototypes);
        }

        #endregion Public methods

        #region Protected methods

        /// <summary>
        /// Использовать клоны.
        /// </summary>
        /// <param name="clones">Клоны.</param>
        protected abstract void UseClones(IEnumerable<IModDesignPatternBasePartPrototypeCommonProduct> clones);

        /// <summary>
        /// Использовать прототипы.
        /// </summary>
        /// <param name="prototypes">Прототипы.</param>
        protected abstract void UsePrototypes(IEnumerable<IModDesignPatternBasePartPrototypeCommonProduct> prototypes);

        #endregion Protected methods
    }
}
