using TaskFolio.Communication.Responses;

namespace TaskFolio.Application.UseCases.Task.GetAll;

public class GetAllTaskUseCase
{
    public ResponseAllTaskJson Execute()
    {

        return new ResponseAllTaskJson
        {
            Tasks =
            [
                 new ResponseShortTaskJson {
                     Description = "Description Test",
                     Id = 1,
                     Name = "Test",
                 }
            ]
        };
    }
}
