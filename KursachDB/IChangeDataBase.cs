using System.Collections.Generic;

namespace KursachDB
{
    interface IChangeDataBase
    {
        void Connect();
        void Select();
        void Insert(List<string> list);
        void Update(List<string> list);
        void Delete(string delId);
        void SelectFields();
    }
}