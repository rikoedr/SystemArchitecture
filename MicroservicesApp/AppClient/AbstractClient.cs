namespace MicroservicesApp.AppClient;

public abstract class AbstractClient
{
    public abstract void Menu();
    protected abstract void GetAll();
    protected abstract void Add();
    protected abstract void Edit();
    protected abstract void Delete();
}
