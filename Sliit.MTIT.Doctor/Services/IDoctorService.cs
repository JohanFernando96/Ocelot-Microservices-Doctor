namespace Sliit.MTIT.Doctor.Services
{

    public interface IDoctorService
    {
        List<Models.Doctor> GetDoctors();
        Models.Doctor? GetDoctor(int id);
        Models.Doctor? AddDoctor(Models.Doctor doctor);
        Models.Doctor? UpdateDoctor(Models.Doctor doctor);
        bool? DeleteDoctor(int id);

    }
}
