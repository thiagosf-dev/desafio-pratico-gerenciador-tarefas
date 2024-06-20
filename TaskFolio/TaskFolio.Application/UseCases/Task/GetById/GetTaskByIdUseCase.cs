using TaskFolio.Communication.Responses;

namespace TaskFolio.Application.UseCases.Task.GetById;

public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            Name = "Name Test",
            Description = "Description Test",
            Deadline = DateTime.Now,
            Priority = 0,
            Status = 0,
        };
    }
}
