using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class BLL
    {
        public BLL()
        {
        }

        public int SignUpBLL(Donator objDonator)
        {
            int output;
            DAL objDal = new DAL();
            output = objDal.SignUpDAL(objDonator);
            return output;
        }

        public Donator SignInBLL(Donator objDonator)
        {
            Donator objUser = new Donator();
            DAL objDAL = new DAL();
            objUser = objDAL.SignInDAL(objDonator);
            return objUser;
        }

        public int DonateAnimalBLL(Animal objAnimal)
        {
            int output;
            DAL objDal = new DAL();
            output = objDal.DonateAnimalDAL(objAnimal);
            return output;

        }

        public int AdoptAnimalBLL(Adopter objAdopter)
        {
            DAL objDal = new DAL();
            int output;
            output = objDal.AdoptAnimalDAL(objAdopter);
            return output;
        }

        public DataSet GetAnimalsDataBLL()
        {
            DataSet dsAnimalsData = new DataSet();
            DAL objDal = new DAL();

            dsAnimalsData = objDal.GetAnimalsDataDAL();// call GetdsAnimalsDataDataDAL method of DAL

            return dsAnimalsData;
        }
        public DataSet GetUsersDataBLL()
        {
            DataSet dsUsersData = new DataSet();
            DAL objDal = new DAL();

            dsUsersData = objDal.GetUsersDataDAL();// call GetdsAnimalsDataDataDAL method of DAL

            return dsUsersData;
        }
        public int UpdateAnimalBLL(string[] strAnimalUpdate)
        {
            int output;
            DAL objDal = new DAL();

            output = objDal.UpdateAnimalDAL(strAnimalUpdate);
            return output;
        }
        public int UpdateUserBLL(string[] strUserUpdate)
        {
            int output;
            DAL objDal = new DAL();

            output = objDal.UpdateUserDAL(strUserUpdate);
            return output;
        }
        public int DeleteAnimalBLL(string AnimalId)
        {
            int output;
            DAL objDal = new DAL();

            output = objDal.DeleteAnimalDAL(AnimalId);// call DeleteDonationDAL method of DAL
            return output;
        }
        public int DeleteUserBLL(string DonatorId)
        {
            int output;
            DAL objDal = new DAL();

            output = objDal.DeleteUserDAL(DonatorId);// call DeleteDonationDAL method of DAL
            return output;
        }

        public List<ChartData> GetDataAnalyticsBLL()
        {
            List<ChartData> output;
            DAL objDal = new DAL();

            output = objDal.GetDataAnalyticsDAL();// call DeleteDonationDAL method of DAL
            return output;

        }



    }



}
