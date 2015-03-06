namespace Unit
{
    /// <summary>
    /// This class should be used instead of void for return types.
    /// </summary>
    public class Nothing
    {
        public static Nothing Instance = new Nothing();

        private Nothing() { }

        public override string ToString()
        {
            return "Nothing";
        }
    }
}
