using CoreBusiness;
using UseCases.DataPluginInterfaces;

namespace Plugins.Data.InMemory
{
    public class InputDataRepository : IInputDataRepository
    {
        private List<InputData> inputDatas;

        public InputDataRepository()
        {
            inputDatas = new List<InputData>()
            {
                new InputData() { Id = 0, NameOfAGood = "Velpapir Papir", SupplierId = 0, TypeOfAGood = "Papir",  CountOfPeices = 2 , KunaPerPeice = 300.0f},
                new InputData() { Id = 1, NameOfAGood = "", SupplierId = 1, TypeOfAGood = "Toner",  CountOfPeices = 5 , EuroPerPeice = 30.0f},
                new InputData() { Id = 2, NameOfAGood = "Papir", SupplierId = 2, TypeOfAGood = "Paleta Papir",  CountOfPeices = 1 , TotalExpenceInKunas = 3055.0f}
            };
            foreach (var job in inputDatas)
            {
                job.calculate();
            }
        }
        public void Add(InputData inputData)
        {
            var id = -1;
            if (inputDatas.Count != 0)
                id = inputDatas.Max(x => x.Id);
            inputData.Id = id + 1;
            inputDatas.Add(inputData);
        }

        public void Delete(int inputDataId)
        {
            inputDatas?.Remove(GetById(inputDataId));
        }

        public IEnumerable<InputData> GetAll()
        {
            return inputDatas;
        }

        public InputData GetById(int inputDataId)
        {
            return inputDatas?.FirstOrDefault(x => x.Id == inputDataId);
        }

        public void Update(InputData inputData)
        {
            var inputDataToUpdate = GetById(inputData.Id);

            if (inputDataToUpdate != null)
            {
                inputDataToUpdate.NameOfAGood = inputData.NameOfAGood;
                inputDataToUpdate.SupplierId = inputData.SupplierId;
                inputDataToUpdate.TypeOfAGood = inputData.TypeOfAGood;
                inputDataToUpdate.CountOfPeices = inputData.CountOfPeices;
                inputDataToUpdate.KunaPerPeice = inputData.KunaPerPeice;
                inputDataToUpdate.EuroPerPeice = inputData.EuroPerPeice;
                inputDataToUpdate.TotalExpenceInKunas = inputData.TotalExpenceInKunas;
                inputDataToUpdate.TotalExpenceInEuros = inputData.TotalExpenceInEuros;
                inputDataToUpdate.IsPaid = inputData.IsPaid;
                inputDataToUpdate.IsDelivered = inputData.IsDelivered;
            }
        }
    }
}
