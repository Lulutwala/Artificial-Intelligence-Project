using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IOperatorHandler<T1>
    {
        bool IsOperator(T1 t1);
        bool ApplyOperator(T1 t1);
    }

    public interface IOperatorHandler<T1, T2>
    {
        bool IsOperator(T1 t1, T2 t2);
        bool ApplyOperator(T1 t1, T2 t2);
    }

    public interface IOperatorHandler<T1, T2, T3>
    {
        bool IsOperator(T1 t1, T2 t2, T3 t3);
        bool ApplyOperator(T1 t1, T2 t2, T3 t3);
    }

    public interface IOperatorHandler<T1, T2, T3, T4>
    {
        bool IsOperator(T1 t1, T2 t2, T3 t3, T4 t4);
        bool ApplyOperator(T1 t1, T2 t2, T3 t3, T4 t4);
    }
}
