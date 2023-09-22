
using Amazon.CDK;
using Amazon.CDK.AWS.SSM;
using Constructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCdkApp.Constructs
{
    internal class SsmParameterConstruct : Construct
    {
        public SsmParameterConstruct(Construct scope, string id, SsmParameterConstructProps props) : base(scope, id)
        {
            var param1 = new StringParameter(this, "cityparameter", new SsmParameterConstructProps
            {
                ParameterName = "cityName",
                DataType = ParameterDataType.TEXT,
                StringValue = "Houston"
            });

            var param2 = new StringParameter(this, "stateparameter", new SsmParameterConstructProps
            {
                ParameterName = "cityName",
                DataType = ParameterDataType.TEXT,
                StringValue = "Houston"
            });


            var param3 = new StringParameter(this, "cityparameter", new SsmParameterConstructProps
            {
                ParameterName = "cityName",
                DataType = ParameterDataType.TEXT,
                StringValue = "Houston"
            });





        }
    }
}
