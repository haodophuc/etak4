using System;
using System.Collections.Generic;
using System.Text;

namespace QLKS.VO
{
    public class ServiceVO
    {
       #region Constructors
        public ServiceVO(String id, String name, Double price, bool state )
        {
            ID = id;
            Name = name;
            Price = price;
            State = state;
        }// end constructor
       #endregion // end region Constructors

       #region Attributes
        public String ID
        {
            get { return this.serviceID; }
            set { this.serviceID = value; }
        }// end attribute ServiceID

        public String Name
        {
            get { return this.serviceName; }
            set { this.serviceName = value; }
        }// end attribute ServiceName

        public Double Price
        {
            get { return this.servicePrice; }
            set { this.servicePrice = value; }
        }// end attribute ServicePrice

        public bool State
        {
            get { return this.serviceState; }
            set { this.serviceState = value; }
        }//end attribute State
       #endregion // end region Attributes

       #region Instance Fields
        private String serviceID;
        private String serviceName;
        private Double servicePrice;
        private bool serviceState;
       #endregion // end region Instance Fields
    }// end class ServiceVO
}// end namespace QLKS.VO
