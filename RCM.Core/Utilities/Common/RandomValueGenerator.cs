using System;

namespace Core.Utilities.Common
{
    public static class RandomValueGenerator
    {
        public static string GenerateRandomGuid(int count)
        {
            return Guid.NewGuid()
                .ToString()
                .Replace("-", "")
                .Substring(0, count);
        }
    }
}
