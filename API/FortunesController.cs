namespace API
{
    using System;
    using System.Web.Http;

    public class FortunesController : ApiController
    {
        // Some fortunes...
        private static string[] fortunes = new string[]
        {
            "A fool must now and then be right by chance",
            "A great nation is any mob of people which produces at least one honest man a century.",
            "A language that doesn't affect the way you think about programming is not worth knowing.",
            "A radioactive cat has eighteen half-lives",
            "You will be surprised by a loud noise"
        };

        public string Get()
        {
            int i = new Random().Next(fortunes.Length);
            return fortunes[i];
        }
    }
}
