using System;

namespace RestSharpSpot.Api.Objects
{
    public class PrivateUser : PublicUser
    {
        public string Birthdate { get; set; }
        public string Country { get; set; }
        public String Email { get; set; }
        public string Product { get; set; }
    }
}