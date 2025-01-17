﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.Examples
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class ExampleMetadata : Generators.BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<docs>\r\n");
            
            #line 8 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"

	var servicename = this.Config.Namespace.Split('.').Last();
	foreach(var operation in this.Config.ServiceModel.Operations)
	{
		foreach(var example in operation.Examples)
		{

            
            #line default
            #line hidden
            this.Write("\t<doc>\r\n\t\t<members>\r\n\t\t\t<member name=\"M:");
            
            #line 17 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".IAmazon");
            
            #line 17 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 17 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 17 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.");
            
            #line 17 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request)\" />\r\n\t\t\t<member name=\"M:");
            
            #line 18 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Amazon");
            
            #line 18 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("Client.");
            
            #line 18 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 18 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.");
            
            #line 18 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request)\" />\r\n\t\t\t<member name=\"T:");
            
            #line 19 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.");
            
            #line 19 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request\" />\r\n\t\t\t<member name=\"T:");
            
            #line 20 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.");
            
            #line 20 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response\" />\r\n\t\t</members>\r\n\t\t<value>\r\n\t\t\t<example>\r\n\t\t\t\t<para>\r\n\t\t\t\t\t");
            
            #line 25 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(example.Description));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t</para>\r\n\t\t\t\t<code\r\n\t\t\t\t\ttitle=\"");
            
            #line 28 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(example.Title));
            
            #line default
            #line hidden
            this.Write("\"\r\n\t\t\t\t\tsource=\".\\AWSSDKDocSamples\\");
            
            #line 29 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(servicename));
            
            #line default
            #line hidden
            this.Write("\\");
            
            #line 29 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(servicename));
            
            #line default
            #line hidden
            this.Write(".GeneratedSamples.cs\"\r\n\t\t\t\t\tregion=\"");
            
            #line 30 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(example.Id));
            
            #line default
            #line hidden
            this.Write("\" />\r\n\t\t\t</example>\r\n\t\t</value>\r\n\t</doc>\r\n");
            
            #line 34 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Examples\ExampleMetadata.tt"

		}
	}

            
            #line default
            #line hidden
            this.Write("</docs>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
