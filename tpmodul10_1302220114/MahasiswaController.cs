using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302220114.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa("Alif Adani Rahmat","1302220114"),
            new Mahasiswa("Nizar Arifin","1302220035"),
            new Mahasiswa("Muhammad Yudha Pratama", "1302223117"),
            new Mahasiswa("Muhammad Rizqi Haqqi", "1302220016"),
            new Mahasiswa("Keenawa Wira Tutu", "1302223111")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaList[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            mahasiswaList.Add(mahasiswa);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            mahasiswaList.RemoveAt(id);
        }

    }
}
