
namespace Texitor.Control.Extensions.Helpers;

/// <summary>
/// Extension Methods for Helpers
/// </summary>
public static class TagHelperExtensions
{
    /// <summary>
    /// Adds the Texitor to the form context
    /// </summary>
    public static void AddCustomEditor(this TagHelperContext context, string editorId)
    {
        if (!context.Items.ContainsKey("Texitor"))
        {
            context.Items["Texitor"] = new HashSet<string>();
        }

        var editors = (HashSet<string>)context.Items["Texitor"];
        editors.Add(editorId);
    }

    /// <summary>
    /// Gets all Texitor IDs from context
    /// </summary>
    public static IEnumerable<string> GetCustomEditorIds(this TagHelperContext context)
    {
        if (context.Items.TryGetValue("Texitor", out var editors))
        {
            return (HashSet<string>)editors;
        }
        return Enumerable.Empty<string>();
    }
}