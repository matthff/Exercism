using System;

static class Badge
{
    private const string DEFAULT_DEPARTMENT = "owner";

    public static string Print(int? id, string name, string? department)
    {
        department = (department ?? DEFAULT_DEPARTMENT).ToUpper();

        return id.HasValue switch
        {
            true => $"[{id}] - {name} - {department}",
            false => $"{name} - {department}",
        };
    }
}
