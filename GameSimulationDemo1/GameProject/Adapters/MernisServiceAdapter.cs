using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;

namespace GameProject.Adapters
{
    class MernisServiceAdapter : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            MernisServiceReference.KPSPublicSoapClient client =
                new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(
                    Convert.ToInt64(gamer.IdentityNumber),
                    gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year))).Result.Body
                .TCKimlikNoDogrulaResult;
        }
    }
}
