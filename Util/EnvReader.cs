//while searching for solution for everyone having seperate connection strings we found the .env convention and used this implementation https://dusted.codes/dotenv-in-dotnet
using System;
using System.IO;

namespace Movie_Booking_System.Util
{
    public static class EnvReader
    {
        public static void Load(string filePath)
        {
            if (!File.Exists(filePath))
                throw new ArgumentException(".env file doesnt exist");

            foreach (var line in File.ReadAllLines(filePath))
            {
                char[] Separators = { '\t' };
                var parts = line.Split(separator: Separators, options: StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 2)
                    continue;

                Environment.SetEnvironmentVariable(parts[0], parts[1]);
            }
        }
    }
}
