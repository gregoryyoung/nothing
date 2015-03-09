namespace Unit
{
    /// <summary>
    /// This class should be used instead of void for return types.
    /// </summary>
    public sealed class Nothing
    {
        public static readonly Nothing Instance = new Nothing();

        private Nothing() { }

        public override string ToString()
        {
            return "Nothing";
        }
    }
}
