using System;
using System.Collections.Generic;
using System.Text;

namespace BET.Data.Interfaces
{
    public interface ITransaction: IDisposable
    {
        void Commit();
        void Rollback();
    }
}
