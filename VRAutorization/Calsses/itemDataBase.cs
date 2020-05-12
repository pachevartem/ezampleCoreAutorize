using System.Collections.Generic;

namespace VRAutorization.Calsses
{
    public class itemDataBase
    {
       public string created;
       public string email;
       public string password;
       public string formid;
       public string formname;
       public string referer;

       public static bool Validate(List<itemDataBase> db, string email, string pass)
       {
           foreach (var item in db)
           {
               if (email == item.email && pass == item.password)
               {
                   return true;
               }
           }
           
           return false;
       }
    };
}