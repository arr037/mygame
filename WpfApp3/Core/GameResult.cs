namespace WpfApp3.Core
{
    public enum GameResult:byte
    {
        /// <summary>
        /// Выйграли крестики
        /// </summary>
        CrossWin,
       
        /// <summary>
        /// Выйграли нолики
        /// </summary>
        ZeroWin,
        
        /// <summary>
        /// Ничья
        /// </summary>
        Draw,
        
        /// <summary>
        /// Игра продолжается
        /// </summary>
        ContinueToPlay
    }
}