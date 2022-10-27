//Manuel L.
//10-26-22
//Mad Libs
//The user will input his answers and with the answers it will make a funny story
//Peer Review: Jessie Lamzon
//Code ran well without any errors.  It was also done with all the assignment requirements as well.  Very nice clean code. Good job!


using Microsoft.AspNetCore.Mvc;

namespace LeyvaM.MadLibsEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibsController : ControllerBase
{
    [HttpGet]
    [Route("MiniCh5/{Holiday}/{Noun1}/{Place}/{Person}/{Adjective}/{BodyPart}/{Verb}/{Adjective1}/{Noun2}/{Food}")]

    public string Libs(string Holiday, string Noun1, string Place, string Person, string Adjective, string BodyPart, string Verb, string Food, string Adjective1, string Noun2)
    {
        return $" I cant believe it's already {Holiday}! I cant wait to put on my {Noun1} and visit every {Place} in my neighborhood. This year, I am going to dress up as a {Person} with {Adjective} {BodyPart}. Before I {Verb}, I make sure to grab my {Adjective1} {Noun2} to hold all of my {Food} ";
    }
}
