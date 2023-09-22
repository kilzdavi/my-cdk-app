using Amazon.CDK;
using Constructs;
using Constructs;
using MyCdkApp.Constructs;

namespace MyCdkApp
{
    public class MyCdkAppStack : Stack
    {
        internal MyCdkAppStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            // The code that defines your stack goes here
            var secrets = new SecretsManagerConstruct(this, "secrets", new SecretsManagerConstructProps
            {

            });

            var parameters = new SsmParameterConstruct(this, "ssmParameters", new SsmParameterConstructProps
            {

            });
        }
    }
}
