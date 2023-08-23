
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Parts
{
    public class Part
    {
        // Properties of a Part
        public int PartId { get; set; }
        public double SalePrice { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        // Constructor to initialize Part properties
        public Part(int partId, double salePrice, string name, string description, int quantity)
        {
            PartId = partId;
            SalePrice = salePrice;
            Name = name;
            Description = description;
            Quantity = quantity;
        }

        // Method to calculate total price of the Part
        public double CalculateTotalPrice()
        {
            return SalePrice * Quantity;
        }

        // Override the ToString() method to provide a string representation of the Part
        public override string ToString()
        {
            return $"{PartId}|{SalePrice}|{Name}|{Description}|{Quantity}";
        }

        public static bool IsNumeric(string value)
        {
            return double.TryParse(value, out _);
        }
    }
}
