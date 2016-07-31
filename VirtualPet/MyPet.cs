using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class Pet
    {
        //declare variables--properties
        private string petName;
        private int boredom;
        private int tired;
        private int hungry;
        
        //constructor properties assigned to fields--blue print for object
        public Pet(string newPetName, int newboredom, int newTired, int newHungry)
        {
            petName = newPetName;
            boredom= newboredom;
            tired = newTired;
            hungry = newHungry;

        }
        public void setboredom(int newBoredom)
        //new method so play can change
        {
            boredom = newBoredom;
        }
        public int getBordom()
        {
            return boredom;
        }
        //new method so tired can change
        public void setTired(int newTired)
        {
            tired = newTired;
        }
        public int getTired()
        {
            return tired;
        }
        //new method
        public void setHungry(int newHungry)
        {
            hungry = newHungry;
        }
        public int getHungry()
        {
            return hungry;
        }
        //set method
        public void setpetName(string MAXX)
        {
            petName = MAXX;
        }
        public string getpetName()
        {
            return petName;
        }
        public void print()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(petName + "\n");
            sb.Append(boredom + "\nHUNGER" + ":");
            sb.Append(hungry + "\nBOREDOM" + ":");
            sb.Append(tired + "\nSLEEP" + ":");
            Console.WriteLine(sb.ToString());
        }


        public void action()
        {        

            hungry = hungry + 5;
            boredom = boredom + 5;
            tired = tired + 5;

            
            

        }


        
        public void PrintStats()
        {
        }
        public void Tick()
        {
            boredom = boredom + 50;
            tired = tired + 4;
            hungry = hungry + 4;

        }


















    }








}             
    

    

        
      
        
            

        
    

        











    

