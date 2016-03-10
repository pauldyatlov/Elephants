public static class Utils
{
    private static System.Random random;
    public static System.Random NewRandom
    {
        get
        {
            if (random == null)
            {
                random = new System.Random();
            }

            return random;
        }
    }
}
