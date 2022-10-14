namespace LearningCenter.Infraestructure;

public interface ICategoryRepository
{
    List<string> getAll();

    string getCatgoryById(int id);

    bool create(string id);
}