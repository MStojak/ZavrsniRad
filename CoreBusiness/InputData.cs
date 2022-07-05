using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class InputData
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "NameOfAGood must have value.")]
        public string? NameOfAGood { get; set; }
        [Required(ErrorMessage = "Supplier must be assigned.")]
        public int SupplierId { get; set; }
        [Required(ErrorMessage = "TypeOfAGood of good must have value.")]
        public string? TypeOfAGood { get; set; }
        [Required(ErrorMessage = "Category must have value.")]
        public int CountOfPeices { get; set; }
        public float KunaPerPeice { get; set; } = 0f;
        public float EuroPerPeice { get; set; } = 0f;
        public float TotalExpenceInKunas { get; set; } = 0f;
        public float TotalExpenceInEuros { get; set; } = 0f;
        public DateTime DeliveryDeadline { get; set; } = DateTime.Now;
        public DateTime PayingDeadline { get; set; } = DateTime.Now;
        public bool IsPaid { get; set; }
        public bool IsDelivered { get; set; }

        public Supplier? Supplier { get; set; }


        private float EuroToKuna = 7.5f;
        private float KunaToEuro = 7.5f;
        private float DefaultValue = 0f;

        public bool calculate()
        {
            bool kunasIsCalculated = false;
            bool eurosIsCalculated = false;

            kunasIsCalculated = checkKunaPerCount();
            eurosIsCalculated = checkEuroPerCount();

            bool provjera = kunasIsCalculated && eurosIsCalculated;
            
            while (!provjera)
            {
                provjera = calculate();
            }

            return kunasIsCalculated && eurosIsCalculated;
        }

        private bool checkEuroPerCount()
        {
            bool eurosIsCalculated = false;

            if (EuroPerPeice == DefaultValue)
            {
                if (TotalExpenceInEuros != DefaultValue)
                {
                    EuroPerPeice = TotalExpenceInEuros / CountOfPeices;
                    eurosIsCalculated = true;
                }
                else if (KunaPerPeice != DefaultValue)
                {
                    calculateKunaToEuroPerPeice();
                    calculateTotalExpenceInEuro();
                    eurosIsCalculated = true;
                }
                else if (TotalExpenceInKunas != DefaultValue)
                {
                    KunaPerPeice = TotalExpenceInKunas / CountOfPeices;
                    calculateKunaToEuroPerPeice();
                    calculateTotalExpenceInEuro();
                    eurosIsCalculated = true;
                }
            }else if (TotalExpenceInEuros == DefaultValue)
            {
                calculateTotalExpenceInEuro();
                eurosIsCalculated = true;
            }
            else
            {
                eurosIsCalculated = true;
            }
            return eurosIsCalculated;
        }

        private void calculateKunaToEuroPerPeice()
        {
            EuroPerPeice = KunaPerPeice / KunaToEuro;
        }

        private void calculateEuroToKunaPerPeice()
        {
            KunaPerPeice = EuroPerPeice * EuroToKuna;
        }

        private void calculateTotalExpenceInEuro()
        {
            TotalExpenceInEuros = EuroPerPeice * CountOfPeices;
        }

        private bool checkKunaPerCount()
        {
            bool kunasIsCalculated = false;

            if (KunaPerPeice == DefaultValue)
            {
                if (TotalExpenceInKunas != DefaultValue)
                {
                    KunaPerPeice = TotalExpenceInKunas / CountOfPeices;
                    kunasIsCalculated = true;
                }
                else if (EuroPerPeice != DefaultValue)
                {
                    calculateEuroToKunaPerPeice();
                    calculateTotalExpenceInKuna();
                    kunasIsCalculated = true;
                }
                else if (TotalExpenceInEuros != DefaultValue)
                {
                    EuroPerPeice = TotalExpenceInEuros / CountOfPeices;
                    calculateEuroToKunaPerPeice();
                    calculateTotalExpenceInKuna();
                    kunasIsCalculated = true;
                }
            }
            else if (TotalExpenceInKunas == DefaultValue)
            {
                calculateTotalExpenceInKuna();
                kunasIsCalculated = true;
            }
            else
            {
                kunasIsCalculated = true;
            }
            return kunasIsCalculated;
        }

        private void calculateTotalExpenceInKuna()
        {
            TotalExpenceInKunas = KunaPerPeice * CountOfPeices;
        }
    }

    
}
