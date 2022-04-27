namespace GameStates
{
    /// <summary>
    /// Pre-created game states.
    /// </summary>
    static class Match3GameStates
    {
        public static readonly StateWait Wait = new StateWait();
        public static readonly StateSwap Swap = new StateSwap();
        public static readonly StateShowMatch ShowMatch = new StateShowMatch();
        public static readonly StateBurn Burn = new StateBurn();
        public static readonly StateFall Fall = new StateFall();
        public static readonly StateFill Fill = new StateFill();
    }
}
