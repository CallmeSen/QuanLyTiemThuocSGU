using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVienSGU_Winform.DTO;

namespace QuanLyThuVienSGU_Winform.DAO
{
    public class ShipmentDAO
    {
        // Singleton instance
        private static ShipmentDAO instance;
        public static ShipmentDAO Instance
        {
            get
            {
                if (instance == null) instance = new ShipmentDAO();
                return instance;
            }
            private set => instance = value;
        }

        // Private constructor for singleton pattern
        private ShipmentDAO() { }

        // Method to add a new shipment
        public bool AddShipment(int supplierID, int productID, int quantity, DateTime shipmentDate, DateTime arrivalDate)
        {
            string query = "EXEC USP_AddShipment @SupplierID, @ProductID, @Quantity, @ShipmentDate, @ArrivalDate";
            object[] parameters = { supplierID, productID, quantity, shipmentDate, arrivalDate };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // Method to get all shipments
        public List<ShipmentDTO> GetAllShipments()
        {
            List<ShipmentDTO> shipments = new List<ShipmentDTO>();
            string query = "EXEC USP_GetAllShipments";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                shipments.Add(MapDataRowToShipment(row));
            }
            return shipments;
        }

        // Method to update a shipment
        public bool UpdateShipment(int shipmentID, int supplierID, int productID, int quantity, DateTime shipmentDate, DateTime arrivalDate)
        {
            string query = "EXEC USP_UpdateShipment @ShipmentID, @SupplierID, @ProductID, @Quantity, @ShipmentDate, @ArrivalDate";
            object[] parameters = { shipmentID, supplierID, productID, quantity, shipmentDate, arrivalDate };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // Method to delete a shipment by ID
        public bool DeleteShipment(int shipmentID)
        {
            string query = "EXEC USP_DeleteShipment @ShipmentID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { shipmentID });
            return result > 0;
        }

        // Private helper method to map DataRow to ShipmentDTO
        private ShipmentDTO MapDataRowToShipment(DataRow row)
        {
            return new ShipmentDTO
            {
                ShipmentID = Convert.ToInt32(row["ShipmentID"]),
                SupplierID = Convert.ToInt32(row["SupplierID"]),
                ProductID = Convert.ToInt32(row["ProductID"]),
                Quantity = Convert.ToInt32(row["Quantity"]),
                ShipmentDate = Convert.ToDateTime(row["ShipmentDate"]),
                ArrivalDate = Convert.ToDateTime(row["ArrivalDate"])
            };
        }
    }
}

