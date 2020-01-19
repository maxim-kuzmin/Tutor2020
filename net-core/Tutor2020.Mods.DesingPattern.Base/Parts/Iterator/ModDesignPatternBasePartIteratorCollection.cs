//Author Maxim Kuzmin//makc//

using System.Collections;
using System.Collections.Generic;
using Tutor2020.Mods.DesingPattern.Base.Parts.Iterator.Enums;
using Tutor2020.Mods.DesingPattern.Base.Parts.Iterator.Services;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Iterator
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Iterator". Коллекция.
    /// </summary>
    public class ModDesignPatternBasePartIteratorCollection : IEnumerable<ModDesignPatternBasePartIteratorProduct>
    {
        #region Properties

        private List<ModDesignPatternBasePartIteratorProduct> Items { get; } =
            new List<ModDesignPatternBasePartIteratorProduct>();

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count
        {
            get
            {
                return Items.Count;
            }
        }

        /// <summary>
        /// Тип.
        /// </summary>
        public ModDesignPatternBasePartIteratorEnumTypes Type { get; set; } =
            ModDesignPatternBasePartIteratorEnumTypes.First;

        #endregion Properties

        #region Public methods

        /// <summary>
        /// Добавить элемент.
        /// </summary>
        /// <param name="item">Элемент.</param>
        /// <returns>Коллекция.</returns>
        public ModDesignPatternBasePartIteratorCollection AddItem(ModDesignPatternBasePartIteratorProduct item)
        {
            Items.Add(item);

            return this;
        }

        /// <summary>
        /// Получить элемент по индексу.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <returns>Элемент.</returns>
        public ModDesignPatternBasePartIteratorProduct GetItemByIndex(int index)
        {
            return Items[index];
        }

        /// <inheritdoc/>
        public IEnumerator<ModDesignPatternBasePartIteratorProduct> GetEnumerator()
        {
            switch (Type)
            {
                case ModDesignPatternBasePartIteratorEnumTypes.Second:
                    return new ModDesignPatternBasePartIteratorServiceSecond(this);
                case ModDesignPatternBasePartIteratorEnumTypes.First:
                default:
                    return new ModDesignPatternBasePartIteratorServiceFirst(this);
            }
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion Public methods
    }
}
