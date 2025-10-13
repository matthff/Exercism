using System;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new Exception("And error ocurred!");
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        try
        {
            return int.Parse(input);
        }
        catch (Exception)
        {
            return null;
        }
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        try
        {
            return int.TryParse(input, out result);
        }
        catch (Exception)
        {
            throw new ArgumentException();
        }
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        using (disposableObject)
        {
            throw new Exception("And error ocurred!");
        }
    }
}
