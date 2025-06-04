using CarbonQuest.API.Models;
using CarbonQuest.Lib.Interfaces;
using CarbonQuest.Lib.Utils;
using System.Diagnostics;

namespace CarbonQuest.API.Repositories
{
    public class CarbonQuestionRepository : IRepository<CarbonQuestion>
    {
        private const string FilePath = "Datas/carbon_questions.json";
        private List<CarbonQuestion> _questions;

        public CarbonQuestionRepository()
        {
            _questions = JsonHelper.Instance.LoadFromFile<CarbonQuestion>(FilePath);
            Debug.Assert(_questions != null, "Questions tidak boleh null");
        }

        public List<CarbonQuestion> GetAll()
        {
            return _questions;
        }

        public CarbonQuestion? GetById(string id)
        {
            Validator.CheckStringNotEmpty(id, nameof(id));
            return _questions.FirstOrDefault(q => q.Id == id);
        }

        public void Add(CarbonQuestion item)
        {
            throw new NotImplementedException(); // Tidak perlu Add
        }

        public void SaveChanges()
        {
            throw new NotImplementedException(); // Tidak perlu Save
        }
    }
}