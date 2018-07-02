using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExecessao.Domain.Exeption
{
    class OperacaoException:Exception
    {
        public OperacaoException(String msg):base(msg){}

    }
}
