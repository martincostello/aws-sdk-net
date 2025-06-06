﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class ServiceInterfaceNetFramework : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("\r\n\r\nusing System;\r\nusing System.Threading;\r\nusing System.Threading.Tasks;\r\nusing " +
                    "System.Collections.Generic;\r\n\r\nusing Amazon.Runtime;\r\nusing ");
            
            #line 17 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model;\r\n\r\n#pragma warning disable CS1570\r\nnamespace ");
            
            #line 20 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 22 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
    this.FormatServiceInterfaceDocumentation(this.Config.ServiceModel.Documentation); 
            
            #line default
            #line hidden
            this.Write("\tpublic partial interface IAmazon");
            
            #line 23 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write(" : IAmazonService, IDisposable\r\n\t{\r\n\r\n");
            
            #line 26 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"

// Creates paginators for service if available
if (this.Config.ServiceModel.HasPaginators)
{

            
            #line default
            #line hidden
            this.Write("        /// <summary>\r\n        /// Paginators for the service\r\n        /// </summ" +
                    "ary>\r\n        I");
            
            #line 34 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceNameRoot));
            
            #line default
            #line hidden
            this.Write("PaginatorFactory Paginators { get; }\r\n");
            
            #line 35 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"

    }

            
            #line default
            #line hidden
            this.Write("\r\n\t\t");
            
            #line 39 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"

    // Generates definitions for each operation in the service model
		foreach(var operation in this.Config.ServiceModel.Operations)
		{
            if(operation.IsInternal || 
				(operation.IsEventStreamBidi ||
				(this.Config.ServiceModel.H2Support == H2SupportDegree.EventStream && operation.IsEventStreamOutput) || 
				this.Config.ServiceModel.H2Support == H2SupportDegree.Required)
			)
                continue;
		
            
            #line default
            #line hidden
            this.Write("\r\n\t\t#region  ");
            
            #line 51 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 53 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"

        // Creates a parameterless definition of the operation if specified in the customizations file
        if (this.Config.ServiceModel.Customizations.CreateNoArgOverload(operation.Name))
        {

            
            #line default
            #line hidden
            
            #line 58 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"

this.FormatOperationDocumentationSync(operation, false);
		if(operation.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 63 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 64 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
		
		}

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 67 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response ");
            
            #line 67 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("();\r\n\r\n");
            
            #line 69 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"

        }
        // Adds simple method forms defined in the customizations file
        AddSimpleClientMethodInterfaces(operation, true);

            
            #line default
            #line hidden
            
            #line 74 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"

this.FormatOperationDocumentationSync(operation, true);
		if(operation.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 79 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 80 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
		
		}

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 83 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response ");
            
            #line 83 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 83 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request request);\r\n\r\n");
            
            #line 85 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"

        // Creates a parameterless definition of the operation if specified in the customizations file
        if (this.Config.ServiceModel.Customizations.CreateNoArgOverload(operation.Name))
        {

            
            #line default
            #line hidden
            
            #line 90 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"

			this.FormatOperationDocumentationAsync(operation, false);
			if(operation.IsDeprecated)
			{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 95 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 96 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
		
			}

            
            #line default
            #line hidden
            this.Write("        Task<");
            
            #line 99 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response> ");
            
            #line 99 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Async(System.Threading.CancellationToken cancellationToken = default(Cancellation" +
                    "Token));\r\n\r\n");
            
            #line 101 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"

        }

			AddSimpleClientMethodInterfaces(operation, false);

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 107 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"

			this.FormatOperationDocumentationAsync(operation, true);
			if(operation.IsDeprecated)
			{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 112 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 113 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
		
			}

            
            #line default
            #line hidden
            this.Write("        Task<");
            
            #line 116 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response> ");
            
            #line 116 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Async(");
            
            #line 116 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request request, CancellationToken cancellationToken = default(CancellationToken)" +
                    ");\r\n\r\n\t\t#endregion\r\n\t\t");
            
            #line 119 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"

		}
		
            
            #line default
            #line hidden
            
            #line 122 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
 if (this.Config.EndpointsRuleSet != null) { 
            
            #line default
            #line hidden
            this.Write(@"        
		#region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name=""request"">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion
");
            
            #line 134 "C:\Dev\repos\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterfaceNetFramework.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t}\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
