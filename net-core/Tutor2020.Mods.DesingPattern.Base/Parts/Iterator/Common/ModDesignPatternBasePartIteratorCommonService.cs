//Author Maxim Kuzmin//makc//

using System.Collections;
using System.Collections.Generic;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Iterator.Common
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Iterator". Общее. Сервис.
    /// </summary>
    public abstract class ModDesignPatternBasePartIteratorCommonService : IEnumerator<ModDesignPatternBasePartIteratorProduct>
    {
        #region Properties

        protected ModDesignPatternBasePartIteratorCollection Collection { get; private set; }

        /// <summary>
        /// Текущий индекс.
        /// </summary>
        protected int CurrentIndex { get; set; }

        /// <inheritdoc/>        
        public ModDesignPatternBasePartIteratorProduct Current => Collection.GetItemByIndex(CurrentIndex);

        /// <inheritdoc/>
        object IEnumerator.Current => Current;

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="collection">Коллекция.</param>
        public ModDesignPatternBasePartIteratorCommonService(ModDesignPatternBasePartIteratorCollection collection)
        {
            Collection = collection;

            Reset();
        }

        #endregion Constructors

        #region Public methods

        /// <inheritdoc/>
        public void Dispose()
        {
        }

        /// <inheritdoc/>
        public virtual bool MoveNext()
        {
            return CurrentIndex > -1 && CurrentIndex < Collection.Count;
        }

        /// <inheritdoc/>
        public abstract void Reset();

        #endregion Public methods
    }
}
