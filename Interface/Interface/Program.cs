using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    //======================Abstract Class  saving start====================================

    abstract class AbstractClassMethodsandNonMethods
    {
        public void ABC()
        {
            throw new NotImplementedException();
        }
        public abstract void SavingEnglish();
        public abstract void SavingEduCationDetails();
    }

    class AbstractSavingInherit : AbstractClassMethodsandNonMethods
    {
        public override void SavingEduCationDetails()
        {
            throw new NotImplementedException();
        }

        public override void SavingEnglish()
        {
            throw new NotImplementedException();
        }
    }
    //======================Abstract Class  saving end====================================
    interface ISavingStudentDetails
    {
        void SavingEnglish();
        void SavingEduCationDetails();
    }

    
    interface ISavingStudentAptitudeTest
    {
        void SavingAptitude();
    }

    interface IWorkExperience
    {
        void work();
    }

   class SavingStudentDetails_USA : ISavingStudentDetails, ISavingStudentAptitudeTest, IWorkExperience
    {
        public void SavingAptitude()
        {
            throw new NotImplementedException();
        }

        public void SavingEduCationDetails()
        {
            throw new NotImplementedException();
        }

        public void SavingEnglish()
        {
            throw new NotImplementedException();
        }

        public void work()
        {
            throw new NotImplementedException();
        }

    }
    
   class duplicateSavingStudentDetails_USA: SavingStudentDetails_USA
    {
        public void SavingAptitude()
        {
            throw new NotImplementedException();
        }

        public void SavingEduCationDetails()
        {
            throw new NotImplementedException();
        }

        public void SavingEnglish()
        {
            throw new NotImplementedException();
        }

    }


    class SavingStudentDetails_OtherCOntries : ISavingStudentDetails
    {

        public void SavingEduCationDetails()
        {
            throw new NotImplementedException();
        }

        public void SavingEnglish()
        {
            throw new NotImplementedException();
        }

    }
   class program
    {
        public static void  Main(string[] args)
        {
            int flag = 0;
            if(flag==1)
            {
                SavingStudentDetails_USA usa = new SavingStudentDetails_USA();

                usa.SavingAptitude();
                usa.SavingEduCationDetails();
                usa.SavingEnglish();
            }
            else
            {
                SavingStudentDetails_OtherCOntries other = new SavingStudentDetails_OtherCOntries();
                other.SavingEduCationDetails();
                other.SavingEnglish();
            }
  

        }



    }
  

}
