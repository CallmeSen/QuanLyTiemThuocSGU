using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienSGU_Winform.DAO;
using QuanLyThuVienSGU_Winform.DTO;

namespace QuanLyThuVienSGU_Winform.BLL
{
    public class ShipmentBLL
    {
        // Singleton instance
        private static ShipmentBLL instance;
        public static ShipmentBLL Instance
        {
            get
            {
                if (instance == null) instance = new ShipmentBLL();
                return instance;
            }
            private set => instance = value;
        }

        // Private constructor for singleton pattern
        private ShipmentBLL() { }

        // Method to add a new shipment
        public bool AddShipment(int supplierID, int productID, int quantity, DateTime shipmentDate, DateTime arrivalDate)
        {
            try
            {
                return ShipmentDAO.Instance.AddShipment(supplierID, productID, quantity, shipmentDate, arrivalDate);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding shipment: {ex.Message}");
                return false;
            }
        }

        // Method to get all shipments
        public List<ShipmentDTO> GetAllShipments()
        {
            try
            {
                return ShipmentDAO.Instance.GetAllShipments();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving shipments: {ex.Message}");
                return new List<ShipmentDTO>();
            }
        }

        // Method to update a shipment
        public bool UpdateShipment(int shipmentID, int supplierID, int productID, int quantity, DateTime shipmentDate, DateTime arrivalDate)
        {
            try
            {
                return ShipmentDAO.Instance.UpdateShipment(shipmentID, supplierID, productID, quantity, shipmentDate, arrivalDate);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating shipment: {ex.Message}");
                return false;
            }
        }

        // Method to delete a shipment by ID
        public bool DeleteShipment(int shipmentID)
        {
            try
            {
                return ShipmentDAO.Instance.DeleteShipment(shipmentID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting shipment: {ex.Message}");
                return false;
            }
        }
    }
}

