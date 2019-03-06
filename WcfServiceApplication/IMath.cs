using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceApplication
{
    [ServiceContract]
    public interface IMath
    {
        [OperationContract]
        int Topla(int s1, int s2);

        [OperationContract]
        int Carp(int s1, int s2);

        [OperationContract]
        int Bolme(int s1, int s2);
    }
}
