namespace LearningCenter.Infraestructure;

public class CategoryRepository: ICategoryRepository
{
    public List<string> getAll()
    {
        List<string> categories = new List<string>
        {
            "category 1",
            "category 2",
            "category 3"

        };
        return categories;
    }

    public string getCatgoryById(int id)
    {
        throw new NotImplementedException();
    }

    public bool create(string id)
    {
        throw new NotImplementedException();
    }

   
}