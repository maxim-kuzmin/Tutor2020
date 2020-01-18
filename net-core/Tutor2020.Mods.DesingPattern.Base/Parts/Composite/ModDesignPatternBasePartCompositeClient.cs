//Author Maxim Kuzmin//makc//

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Composite
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Composite". Клиент.
    /// </summary>
    public abstract class ModDesignPatternBasePartCompositeClient
    {
        #region Public methods

        /// <summary>
        /// Запустить.
        /// </summary>
        public void Run()
        {
            var service1 = new ModDesignPatternBasePartCompositeService(
                new ModDesignPatternBasePartCompositeProduct
                {
                    Name = "1"
                });

            var service11 = new ModDesignPatternBasePartCompositeService(
                new ModDesignPatternBasePartCompositeProduct
                {
                    Name = "11"
                });

            var service12 = new ModDesignPatternBasePartCompositeService(
                new ModDesignPatternBasePartCompositeProduct
                {
                    Name = "12"
                });

            var service111 = new ModDesignPatternBasePartCompositeService(
                new ModDesignPatternBasePartCompositeProduct
                {
                    Name = "111"
                });

            var service112 = new ModDesignPatternBasePartCompositeService(
                new ModDesignPatternBasePartCompositeProduct
                {
                    Name = "112"
                });

            service1.Add(service11);
            service1.Add(service12);

            service11.Add(service111);
            service11.Add(service112);

            UseService(service1);
        }

        #endregion Public methods

        #region Protected methods

        /// <summary>
        /// Использовать сервис.
        /// </summary>
        /// <param name="service">Сервис.</param>
        protected abstract void UseService(ModDesignPatternBasePartCompositeService service);

        #endregion Protected methods
    }
}
