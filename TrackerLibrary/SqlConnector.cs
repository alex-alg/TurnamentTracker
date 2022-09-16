using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        //TODO - Make the method actually save to the db
        /// <summary>
        /// Saves the new prize to the db
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>the prize info, including unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
