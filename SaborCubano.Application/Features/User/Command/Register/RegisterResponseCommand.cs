namespace SaborCubano.Application.Features.User.Command.Register;

public class RegisterResponseCommand{
    public string Id {get; set;} = null!;
    public string User_name{get; set;} = null!;
     public string Email{get; set;} = null!;
     public string Token{get; set;} = null!;
};
