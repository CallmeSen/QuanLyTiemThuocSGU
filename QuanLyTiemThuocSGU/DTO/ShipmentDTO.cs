using System;
using System.Collections.Generic;
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
        public DateTime ShipmentDate { get; set; }
        public DateTime ArrivalDate { get; set; }

        // Optional: Constructor and ToString method for easier debugging
        public ShipmentDTO(int shipmentID, int supplierID, int productID, int quantity, DateTime shipmentDate, DateTime arrivalDate)
        {
            ShipmentID = shipmentID;
            SupplierID = supplierID;
            ProductID = productID;
            Quantity = quantity;
            ShipmentDate = shipmentDate;
            ArrivalDate = arrivalDate;
        }

        public ShipmentDTO() { }

        public override string ToString()
        {
            return $"ShipmentID: {ShipmentID}, SupplierID: {SupplierID}, ProductID: {ProductID}, Quantity: {Quantity}, ShipmentDate: {ShipmentDate.ToShortDateString()}, ArrivalDate: {ArrivalDate.ToShortDateString()}";
        }
    }
}

