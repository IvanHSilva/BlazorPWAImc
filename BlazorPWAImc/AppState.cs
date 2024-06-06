using BlazorPWAImc.Models;

namespace BlazorPWAImc; 

public static class AppState {
    public static List<ImcModels> History { get; set; } = [];

    public static event EventHandler<EventArgs> OnChanged = null!;

    public static void NotifyChanges(object? sender, EventArgs args) {
        OnChanged.Invoke(sender, args);
    }
}
