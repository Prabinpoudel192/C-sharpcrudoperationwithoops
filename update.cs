using MySql.Data.MySqlClient;

namespace chatgpt{
    class Update:Student{   
    public void update(){
        int a;
        start:
        while(true){
        Console.WriteLine("Please enter the student Id:");
        if(int.TryParse(Console.ReadLine(),out a)){
            break;
        }else{
            Console.WriteLine("Invalid Student Id");
        }
        }
        using(MySqlConnection con=new MySqlConnection(dbcon())){
          con.Open();
          string query=$"Select *from s_details where StudentID={a}";
          using(MySqlCommand com=new MySqlCommand(query,con)){
            using(MySqlDataReader read=com.ExecuteReader()){
               if(read.HasRows){
                  goto xcontinue;
               }else{
                Console.WriteLine("No such record found");
                goto start;
               }

            }
          }
        }
        xcontinue:
        Console.WriteLine("Please provide the student new details:");
        Console.Write("Newname:");
        string newName=Console.ReadLine();
        Namegetset=newName;
        Console.Write("Age:");
        int.TryParse(Console.ReadLine(),out int newAge);
        Agegetset=newAge;
        Console.Write("Degree:");
        Degreegetset=Console.ReadLine();
        using(MySqlConnection con=new MySqlConnection(dbcon())){
            con.Open();
            string query=$@"start transaction;
            update s_details set Name='{Namegetset}',Age='{Agegetset}' where StudentID={a};
            update s_degree set Degree='{Degreegetset}' where StudentID={a};
            commit;
            ";
            MySqlCommand com=new MySqlCommand(query,con);
            com.ExecuteNonQuery();
                
            
        }

    }
    }
}