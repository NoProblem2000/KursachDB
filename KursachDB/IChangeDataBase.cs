using System.Collections.Generic;

namespace KursachDB
{
    interface IChangeDataBase
    {
        void Connect();
        void Select();
        void Insert(List<string> list);
        void Update();
        void Delete();
        void SelectFields();
    }
}