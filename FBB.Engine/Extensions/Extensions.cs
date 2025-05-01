using FBB.Engine.Classes;
using FBB.Engine.Extensions;

namespace FBB.Engine.Extensions
{
    public static class Extensions
    {
        public static bool IsInputValidNumber(this string input)
        {
            return int.TryParse(input, out int number);
        }

        public static bool IsOptionValid(this string input)
        {
            return ConsoleDialogOptions.MenuOptions.ContainsKey(input);
        }

    /* ORIGINAL METHOD AS I WROTE IT
    foreach (var option in MenuOptions)
    {
        if (MenuOptions.ContainsKey(input))
        {
            return true;
        }
    }
    return false;
*/

    //Kept this as its own function for experimentation
    public static bool DoesContainDigit(this string numberFromUser, string digitToCheck)//Accept key
    {
        return numberFromUser.Contains(digitToCheck);
    }
}
}


