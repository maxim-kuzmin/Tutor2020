//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Iterator.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Iterator.Services
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Iterator". Сервис "Second".
    /// </summary>
    public class ModDesignPatternBasePartIteratorServiceSecond : ModDesignPatternBasePartIteratorCommonService
    {
        #region Constructors

        /// <inheritdoc/>
        public ModDesignPatternBasePartIteratorServiceSecond(ModDesignPatternBasePartIteratorCollection collection)
            : base(collection)
        {
        }

        #endregion Constructors

        #region Public methods

        /// <inheritdoc/>
        public sealed override bool MoveNext()
        {
            CurrentIndex--;

            return base.MoveNext();
        }

        /// <inheritdoc/>
        public sealed override void Reset()
        {
            CurrentIndex = Collection.Count;
        }

        #endregion Public methods
    }
}
