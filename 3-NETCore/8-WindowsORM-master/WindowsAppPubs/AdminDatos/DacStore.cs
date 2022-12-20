using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAppPubs.Models;
namespace WindowsAppPubs.AdminDatos
{
    public static class DacStore
    {
        static PubContext contextStore = new PubContext();
        public static List<Store> Listar(){

            List<Store> lista = contextStore.Stores.ToList();
            return lista ;
        }
        public static Store TraerUno(string id)
        {
            
            Store store = contextStore.Stores.Find(id);
            return store;

        }
        public static int NuevaStore (Store storeNueva)
        {
            contextStore.Stores.Add(storeNueva);
            int filasAfectadas = contextStore.SaveChanges();
            return filasAfectadas;
          
        }
        public static int Modificar(Store storeModificar)
        {
            Store storeDb = contextStore.Stores.Find(storeModificar.stor_id);
            if (storeDb != null){
                storeDb.stor_name = "Cachacha";
                storeDb.stor_address = "Costanera 125";
            }
            int filasAfectadas = contextStore.SaveChanges();
            return filasAfectadas;
        }
        public static int Eliminar(Store storeAEliminar)
        {
            Store storeDb = contextStore.Stores.Find(storeAEliminar.stor_id);
            if (storeDb != null)
            {
                contextStore.Stores.Remove(storeDb);
            }
                int filasAfectadas = contextStore.SaveChanges();
                return filasAfectadas;
           
           
        }
    }
}
