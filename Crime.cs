namespace GobiernoCorrupto {
    public class Crime{
     // public string Name   {get; set;}
        public string Action {get; set;}

     // public int Severity  {get; set;}

        public Crime(/*string Name,*/ string Action/*, int Severity*/){
          //  this.Name = Name;
            this.Action = Action;
          //  this.Severity = Severity;
        }


        public override string ToString(){
        //return string.Concat(Name, ": ", Action);
            return Action;
        }
    }
}