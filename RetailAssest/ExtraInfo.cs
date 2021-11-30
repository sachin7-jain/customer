using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace RetailAssest
{
    public class ExtraInfoFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            swaggerDoc.Extensions["extraInfo"] = new {
                                                bizOwner = "Sachin Jain",
                                                bizOwnerMail = "Sachin7.jain@ril.com",
                                                endpointSecurityScheme = "nonsecured",
                                                endpointSecurityAuthType = "",
                                                endpointSecurityUsername = "",
                                                tags = "",
                                                endpointSecurityPassword = "",
                                                techOwner = "Sachin Jain",
                                                techOwnerMail = "sachin7.jain@ril.com",
                                                tiersCollection = "Unlimited",
                                                visibility = "public"

            };
        }

    }
}
