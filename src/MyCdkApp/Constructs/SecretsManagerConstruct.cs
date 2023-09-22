using Amazon.CDK.AWS.SecretsManager;
using Amazon.CDK;
using Constructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.CDK.AWS.SSM;
using System.Collections;
using Amazon.CDK.AWS.S3;
using System.Buffers;
using Amazon.CDK.AWS.RDS;
using Amazon.CDK.AWS.IAM;

namespace MyCdkApp.Constructs
{
    internal class SecretsManagerConstruct: Construct
    {
        public SecretsManagerConstruct(Construct scope, string id, SecretsManagerConstructProps props ) : base(scope, id) 
        {
            var secret1 = new Secret(this, "database-string", new SecretProps
            {
                SecretName = "database-connection-dev",
                SecretStringValue = SecretValue.UnsafePlainText("Server=dev-db.chn5dcgvgrzk.us-east-1.rds.amazonaws.com;Database=BookStoreCore;User Id=admin;Password=Password123!;TrustServerCertificate=true")

            });
            
        }
    }
}
