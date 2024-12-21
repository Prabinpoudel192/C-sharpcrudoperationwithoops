using MySql.Data.MySqlClient;
namespace chatgpt{
     class Delete:Student{
        public void delete(){
            int a;
            while(true){
            Console.WriteLine("Please enter the student id to delete the details:");
             if(int.TryParse(Console.ReadLine(),out a)){
                break;
             }else{
                Console.WriteLine("Invalid Input");
             }
            }
            using(MySqlConnection con=new MySqlConnection(dbcon())){
                con.Open();
                string query=$@"start transaction;
                delete from s_degree where StudentID={a};
                delete from s_details where StudentID={a};
                commit;
                
                ";
                MySqlCommand com=new MySqlCommand(query,con);
                com.ExecuteNonQuery();
                Console.WriteLine("Done");

            }
            
        }

    }
}