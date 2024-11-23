using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_Panier.Services
{
    public interface IInscriptionServices
    {
        public Task<string> Inscription(string email, string password);
    }
}
