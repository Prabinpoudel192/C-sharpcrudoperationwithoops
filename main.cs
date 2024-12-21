
using System;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
namespace chatgpt{
    class Menu{
        public static void Main(){
            Insert obj1=new Insert();
            Display obj=new Display();
            Delete obj2=new Delete();
            Update obj3=new Update();
            SpecificDetail obj4=new SpecificDetail();
            while(true){
            Console.WriteLine("1-for insert,2-display,3-for update,4-for delete,5-for display specific student detail and 0-exit");
            int.TryParse(Console.ReadLine(),out int a);
            if(a==0){
                break;
            }
            else if(a==1){
            obj1.insert();
            obj.display();
            }else if(a==2){
            obj.display();
            }else if(a==3){
             obj3.update();
             obj.display();
            }else if(a==4){
            obj2.delete();
            obj.display();
            }else if(a==5){
             obj4.specificDetail();
            }
            else{
                Console.WriteLine("Invalid Input");
            }
            }

        }
    }
}
