﻿using System;
using System.Collections.Generic;
using System.ServiceModel;
using DatabaseEntities;
using TransferObjects;


namespace IServices
{
    [ServiceContract]
    public interface IServiceSprava
    {
        risTabulky risContext { get; }
        /*
        [OperationContract]
        TJedlo jedlo(int id_jedla, String id_jazyka);

        [OperationContract]
        ICollection<TJedlo> vsetkyJedla(String startingWith, String id_jazyka);

        [OperationContract]
        IList<TTypJedla> typyJedal(String id_jazyka);

        [OperationContract]
        Boolean update_jedlo(String session,TJedlo jedlo);
        */
    }
}
