namespace KursachDB
{
    interface IChangeDataBase
    {
        void Connect();
        void Select();
        void Insert();
        void Update();
        void Delete();
        void SelectFields();
    }
}