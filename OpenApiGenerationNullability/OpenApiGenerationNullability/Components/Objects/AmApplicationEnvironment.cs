using System.ComponentModel.DataAnnotations;

namespace OpenApiGenerationNullability.Components.Objects;

public class AmApplicationEnvironment
{
    [Required]
    public AmApplication? Application { get; set; }

    [Required]
    public AmEnvironment? Environment { get; set; }
}
