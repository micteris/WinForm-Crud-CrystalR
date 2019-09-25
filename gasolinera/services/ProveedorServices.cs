using gasolinera.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasolinera.services
{
    public class ProveedorServices
    {

        public ProveedorServices()
        {

        }

        public bool AddProveedor(string nombre, string centralAbastecimiento)
        {
            try
            {

                using (var context = new db_gasolineraEntities1())
                {
                    var proveedor = new tbl_proveedor
                    {
                        prv_nombre = nombre,
                        prv_CentralA = centralAbastecimiento
                    };

                    context.tbl_proveedor.Add(proveedor);
                    context.SaveChanges();
                    return true;

                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        
        public object GetProveedores()
        {
            try
            {
                using (var context = new db_gasolineraEntities1())
                {
                    var proveedoresList = context.tbl_proveedor.Select(s => new
                    {
                        prv_codigo = s.prv_codigo,
                        prv_nombre = s.prv_nombre,
                        prv_CentralA = s.prv_CentralA
                    }).ToList();
                    return proveedoresList;
                }
            }
            catch (Exception e)
            {
                return null;
                
            }
        }

        public tbl_proveedor GetDetail(int? id) 
        {
            try
            {
                using (var context = new db_gasolineraEntities1())
                {
                    var proveedor = context.tbl_proveedor.Find(id);
                    return proveedor;
                }
            }
            catch (Exception )
            {
                return null;
                //throw;
            } 

        }

        public bool DeleteProveedor(int? id)
        {
            try
            {
                using (var context = new db_gasolineraEntities1())
                {
                    var proveedor = context.tbl_proveedor.Find(id);
                    context.tbl_proveedor.Remove(proveedor);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
                //throw;
            }

        }
  

        public bool UpdateProveedor(int? id, string nombre, string centralAbastecimiento)
        {
            try
            {

                using (var context = new db_gasolineraEntities1())
                {
                    var proveedor = context.tbl_proveedor.Find(id);
                    if (proveedor == null) return false;
                    proveedor.prv_nombre = nombre;
                    proveedor.prv_CentralA = centralAbastecimiento;
                    context.SaveChanges();
                    return true;

                }

            }
            catch (Exception ex)
            {

                return false;
            }
        }

    }
}
