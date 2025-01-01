using UnityEngine;

namespace Assignment29
{

public class CustomObject
{

     public int ID { get; set; }
      public string Name { get; set; }
        public CustomObject(string name, int id)
        {
            this.Name = name;
            this.ID = id;
        }

        public override string ToString()
        {
          return $"Object [ID: {ID}, Name: {Name}]";
        }


       

      /* public override bool Equals(object obj)
          {
            CustomObject customObject = obj as CustomObject; 
            if (customObject == null){
               return false;
             }

        if (this.Name == customObject.Name && this.ID==customObject.ID)
            {
                   return true;
            }
                return false;
        }*/

       

        


         public static bool operator ==(CustomObject co1, CustomObject co2)
            {
                if (!co1.Equals(null) && !co2.Equals(null))
                {
                    if (co1.Name.Equals(co2.Name) && co1.ID==co2.ID) return true;
                }
                return false;
            }

            public static bool operator !=(CustomObject co1, CustomObject co2)
            {
                if (!co1.Equals(null) && !co2.Equals(null))
                {
                    if  ( (!co1.Name.Equals(co2.Name)) || !(co1.ID==co2.ID) ) return true;
                }
                return false;
            }

            



     

}

}
