//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Command.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Command.Services
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Command". Сервис "Second".
    /// </summary>
    public class ModDesignPatternBasePartCommandServiceSecond : IModDesignPatternBasePartCommandCommonService
    {
        #region Properties

        private ModDesignPatternBasePartCommandProduct Product { get; set; }

        private ModDesignPatternBasePartCommandReceiver Receiver { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Конструктор.
        /// </summary>        
        /// <param name="product">Продукт.</param>
        /// <param name="receiver">Получатель.</param>
        public ModDesignPatternBasePartCommandServiceSecond(            
            ModDesignPatternBasePartCommandProduct product,
            ModDesignPatternBasePartCommandReceiver receiver
            )
        {
            Receiver = receiver;
            Product = product;
        }

        #endregion Constructors

        #region Methods

        /// <inheritdoc/>
        public void Execute()
        {
            Product.Name += ": Second";

            Receiver.HandleProduct(Product);
        }

        #endregion Methods
    }
}
