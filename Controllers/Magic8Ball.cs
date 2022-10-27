// Jacob Dekok
// 10/27/2020
// Magic 8 Ball API
// This program will output an 8 ball answer no matter what they type
// Peer Reviewed By: Elizar Garcia, code runs great. Randomizes the return
// statement on the postman side with no problem. On the CS side the code is
// short and to the point, looks clean and easy to read. great job!!!


using Microsoft.AspNetCore.Mvc;

namespace dekokJMagic8BallEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class Magic8BallController : ControllerBase
{
    [HttpGet]
    [Route("Magic/{userQuestion}")]

    public string Magic8(string userQuestion)
    {
        Random random = new Random();
        string[] answer = {"Yes", "No", "Maybe", "It is certain", "Ask again later",
    "Definately", "Most likely", "Definately Not", "Better not tell you now", "Outlook not so good"};

        int index = random.Next(answer.Length);
        return answer[index];
    }
}
