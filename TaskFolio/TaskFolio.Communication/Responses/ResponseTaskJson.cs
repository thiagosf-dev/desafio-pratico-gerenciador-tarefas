using TaskFolio.Communication.Enums;

namespace TaskFolio.Communication.Responses;

public class ResponseTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Deadline { get; set; }
    public PriorityTypes Priority { get; set; }
    public TaskStatus Status { get; set; }
}
