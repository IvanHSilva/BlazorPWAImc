namespace BlazorPWAImc.Models; 

using System.ComponentModel.DataAnnotations;

public class ImcModels {
    [Required(ErrorMessage = "Altura obrigatória!")]
    public double? Height { get; set; }

    [Required(ErrorMessage = "Peso obrigatório!")]
    public double? Weight { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public double Imc => (Weight ?? 1) / ((Height ?? 1) * (Height ?? 1));
}
