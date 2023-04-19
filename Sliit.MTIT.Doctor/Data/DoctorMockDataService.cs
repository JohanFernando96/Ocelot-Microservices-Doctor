namespace Sliit.MTIT.Doctor.Data
{
    public class DoctorMockDataService
    {
        public static List<Models.Doctor> Doctors = new List<Models.Doctor>()
        {
            new Models.Doctor { Id = 1, DocName = "Anuradha Perera", Address = "123 Malwatta Road", Age = 35 },
            new Models.Doctor { Id = 2, DocName = "Mark Cooray", Address = "456 Jaya Mahal Mawatha", Age = 60 },
            new Models.Doctor { Id = 3, DocName = "Minidu Weerakody", Address = "789 Gampaha Road", Age = 38 },
            new Models.Doctor { Id = 4, DocName = "Namal Perera", Address = "321 Saama Mawatha", Age = 48 }
        };
    }
}
