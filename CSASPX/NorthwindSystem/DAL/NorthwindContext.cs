using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region Additional Namespaces
using System.Data.Entity;
#endregion
namespace NorthwindSystem.DAL
{
  //To add a little security to the database access we will set the access priviledge of this class to the internal 
  //This access restricts calls ti this class from within this project only
  //this class will be created by any BLL controller class method
  //this class will interact with the EntityFramework software to access the databse
  //to set up this interaction, this class will inherit fron EntityFramework its DbContext class
    internal class NorthwindContext:DbContext
    {
        //We need to pass the databse connection to the EntityFramework DbContext class
        //this is done via the NorthwindContext constructor
        public NorthwindContext() : base("NWDB")
        {

        }
    }
}
