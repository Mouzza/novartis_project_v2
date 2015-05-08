﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPP.BL.Domain.Gebruikers.Beheerder;
using JPP.BL.Domain.Gebruikers;
using JPP.BL.Domain.Antwoorden;

namespace JPP.DAL.Interface
{
    public interface BeheerderHC
    {
        
        Medebeheerder createMedeBeheerder(Medebeheerder medebeheerder);
        void DeleteMedeBeheerder(int ID);
        void WijzigMedeBeheerder(Medebeheerder medebeheerder);

        PersoonlijkeTag maakPersoonlijkeTag(PersoonlijkeTag persoonlijkeTag);
        void deletePersoonlijkeTag(int ID);





    }
}
