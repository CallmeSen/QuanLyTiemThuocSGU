using System; 
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienSGU_Winform.DTO
{
    public class ShipmentDTO
    {
        public int ShipmentID { get; set; }
        public int SupplierID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public DateTime? ArrivalDate { get; set; }

        // Optional: Constructor and ToString method for easier debugging
        public ShipmentDTO(DataRow row)
        {
            ShipmentID = Convert.ToInt32(row["ShipmentID"]);
            SupplierID = Convert.ToInt32(row["SupplierID"]);
            ProductID = Convert.ToInt32(row["ProductID"]);
            Quantity = Convert.ToInt32(row["Quantity"]);
            ShipmentDate = row["ShipmentDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["ShipmentDate"]);
            ArrivalDate = row["ArrivalDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["ArrivalDate"]);
        }


        public ShipmentDTO() { }

        public override string ToString()
        {
            return $"ShipmentID: {ShipmentID}, SupplierID: {SupplierID}, ProductID: {ProductID}, Quantity: {Quantity}, ShipmentDate: {ShipmentDate.Value.ToShortDateString()}, ArrivalDate: {ArrivalDate.Value.ToShortDateString()}";
        }
    }
}

