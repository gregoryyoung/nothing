namespace Unit
{
    /// <summary>
    /// This should be used instead of void for return types.
    /// </summary>
    public struct Nothing
    {
        public static readonly Nothing Value = new Nothing();

        public override string ToString()
        {
            return "Nothing";
        }
    }
}
