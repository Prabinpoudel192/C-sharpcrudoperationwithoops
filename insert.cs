using MySql.Data.MySqlClient;

namespace chatgpt{
class Insert:Student{
    public void insert(){
       Console.WriteLine("Please enter the Student detail to be added in the database:");
       while(true){
        Console.Write("StudentID:");
       if(int.TryParse(Console.ReadLine(),out int sid)){
          StudentIdgetset=sid;
          break;
       }else{
        Console.WriteLine("Invalid Input");
       }
       }
       while(true){
        Console.Write("Name:");
        string name=Console.ReadLine();
        if(string.IsNullOrEmpty(name)){
            Console.WriteLine("Invalid input");
        }else{
            Namegetset=name;
            break;
        }
       }
       while(true){
        Console.Write("Age:");
       if(int.TryParse(Console.ReadLine(),out int age)){
          Agegetset=age;
          break;
       }else{
        Console.WriteLine("Invalid Input");
       }
       }
       Console.Write("Degree(optional leave blank if not completed):");
       Degreegetset=Console.ReadLine();
       using(MySqlConnection con=new MySqlConnection(dbcon())){
        con.Open();
        string query=$@"start transaction;
                     insert into s_details(StudentID,Name,Age)values({StudentIdgetset},'{Namegetset}',{Agegetset});
                     insert into s_degree(StudentId,Degree)values({StudentIdgetset},'{Degreegetset}');
                     commit;";
        MySqlCommand com=new MySqlCommand(query,con);
        com.ExecuteNonQuery();
        
       }
}






}}