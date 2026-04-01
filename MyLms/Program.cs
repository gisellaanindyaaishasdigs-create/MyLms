Siswa siswaObj = new Siswa("Bias","bias@gmail.com","12345","siswa", "XPG3");)
Guru guruObj = new Guru("Danisa", "danisa@gmail.com", "54321", "guru", "Matematika");

siswaObj.TampilkanInfo();
siswaObj.SumbiTugas();
public class User
{
    public string nama;
    public string email;
    public string password;
    public string role;


    public User(string nama, string email, string password, string role)
    {
        this.nama = nama;
        this.email = email;
        this.password = password;
        this.role = role;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Nama: {nama} | Role {role}");
    }
}

class Siswa : User
{
    public string ClassName;

    public Siswa(string nama, string email, string password, string className) : base (nama, email, password, className)
    {
        ClassName = className;
    }
    public void SumbiTugas()
    {
        Console.WriteLine($"{nama}dari kelas {className} sudah ngumpulkan tugas");
    }
}
  

class Guru : User
{ 
    public string Mapel;

    public Guru(string nama, string email, string password, string mapel) : base (nama, email, password, mapel)
    {
        Mapel = mapel;
    }

    public void TampilkanInfo(string nama, string mapel)
    {
        Console.WriteLine($" Guru {nama} telah menilai semua tugas {mapel}");
    }
}







