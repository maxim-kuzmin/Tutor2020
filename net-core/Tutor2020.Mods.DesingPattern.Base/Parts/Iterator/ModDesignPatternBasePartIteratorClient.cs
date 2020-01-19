//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Iterator.Enums;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Iterator
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Iterator". Клиент.
    /// </summary>
    public abstract class ModDesignPatternBasePartIteratorClient
    {
        #region Public methods

        /// <summary>
        /// Запустить.
        /// </summary>
        public void Run()
        {
            var collection = new ModDesignPatternBasePartIteratorCollection();

            collection.AddItem(
                new ModDesignPatternBasePartIteratorProduct
                {
                    Name = "Name1"
                }).AddItem(
                new ModDesignPatternBasePartIteratorProduct
                {
                    Name = "Name2"
                }).AddItem(
                new ModDesignPatternBasePartIteratorProduct
                {
                    Name = "Name3"
                });

            collection.Type = ModDesignPatternBasePartIteratorEnumTypes.First;

            UseCollection(collection);

            collection.Type = ModDesignPatternBasePartIteratorEnumTypes.Second;

            UseCollection(collection);
        }

        #endregion Public methods

        #region Protected methods

        /// <summary>
        /// Использовать коллекцию.
        /// </summary>
        /// <param name="collection">Коллекция.</param>
        protected abstract void UseCollection(ModDesignPatternBasePartIteratorCollection collection);

        #endregion Protected methods
    }
}
