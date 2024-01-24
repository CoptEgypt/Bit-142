public class Mystery4 {
    public static void main(String[] args) {
            graduation1(3.87,178,16);
            graduation1(1.5,199,30);
            graduation1(2.7,380,50);
            graduation1(3.62,200,20);
            graduation1(3.93,185,0);
            graduation1(3.85,190,15);
        }
        public static void graduation1(double GPA,int Credit,int honorCredit){
            if( GPA >= 2.0 && Credit >= 180){
                if (GPA >= 2.0&& GPA <=3.6 && Credit >= 180)
                {System.out.println("graduating"); 
            }else if ( GPA >= 3.6 && GPA <=3.8 && honorCredit >=15){
                    System.out.println("magna cum laude"); 
                }else if (GPA>= 3.8){
                    System.out.println("summa cum laude"); 
                } 
            }else {
                System.out.println("not graduating");
            }
            
           
        }
    }
     /* right graduation1(3.87,178,16);
        right graduation1(1.5,199,30);
        right graduation1(2.7,380,50);
        right graduation1(3.62,200,20);
        the teacher got this wrong graduation1(3.93,185,0);
        right graduation1(3.85,190,15);
        */