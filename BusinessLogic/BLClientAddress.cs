using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLClientAddress
    {
        public BLClientAddress()
        {

        }

        public BindingList<ClientAddressModel> GetClientAddressBi(int clientId, int? clientAddressId)
        {
            DAClientAddress dac = new DAClientAddress();
            DataTable dt = new DataTable();
            dt = dac.GetClientAddress(clientId, clientAddressId);
        

            BindingList<ClientAddressModel> list = new BindingList<ClientAddressModel>();          
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ClientAddressModel address = new ClientAddressModel();
                address.ClientAddressId = Convert.ToInt32(dt.Rows[i]["ClientAddressId"].ToString());
                address.ClientId = Convert.ToInt32(dt.Rows[i]["ClientId"].ToString());
                address.City = new CityModel
                {
                    CityId = Convert.ToInt32(dt.Rows[i]["CityId"]),
                    CityName = dt.Rows[i]["CityName"].ToString()
                };
                address.County = new CountyModel{
                    CountyId = Convert.ToInt32(dt.Rows[i]["CountyId"]),
                    CountyName = dt.Rows[i]["CountyName"].ToString()
                };                  
                address.StreetName = dt.Rows[i]["StreetName"].ToString();
                address.StreetNo = dt.Rows[i]["StreetNo"].ToString();
                address.unique = address.RandomString(8);
                    

                list.Add(address);                

            }            

            return list;
        }

        public BindingList<CityModel> GetCityBi()
        {
            DAClientAddress dac = new DAClientAddress();
            DataTable dt = new DataTable();
            dt = dac.GetCity();

            BindingList<CityModel> list = new BindingList<CityModel>();
            for (int i = 0; i<dt.Rows.Count; i++ )
            {
                CityModel city = new CityModel();
                city.CityId = Convert.ToInt32(dt.Rows[i]["CityId"].ToString());
                city.CityName = dt.Rows[i]["CityName"].ToString();

                list.Add(city);
            }

            return list;
        }

        public BindingList<CountyModel> GetCountyBi()
        {
            DAClientAddress dac = new DAClientAddress();
            DataTable dt = new DataTable();
            dt = dac.GetCounty();

            BindingList<CountyModel> list = new BindingList<CountyModel>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CountyModel county = new CountyModel();
                county.CountyId = Convert.ToInt32(dt.Rows[i]["CountyId"].ToString());
                county.CountyName = dt.Rows[i]["CountyName"].ToString();

                list.Add(county);
            }

            return list;
        }

        public void BIPrepareClientAddress(BindingList<ClientAddressModel> listAddress)
        {
            DAClientAddress da = new DAClientAddress();
            da.PrepareClientAddress(listAddress);
        }
    }
}
