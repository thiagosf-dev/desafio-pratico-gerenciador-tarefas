using TaskFolio.Communication.Requests;
using TaskFolio.Communication.Responses;

namespace TaskFolio.Application.UseCases.Task.Register;

public class RegisterTaskUseCase
{
    public ResponseRegisteredTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseRegisteredTaskJson
        {
            Id = 1,
            Name = "Name Test",
        };
    }
}
