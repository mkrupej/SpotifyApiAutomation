using System.Collections.Generic;

namespace RestSharpSpot.Api.Objects
{
    public class Category
    {
        public string Href { get; set; }
        public List<Image> Icons { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class CategoriesObject
    {
        public Paging<Category> Categories { get; set; }
    }
}