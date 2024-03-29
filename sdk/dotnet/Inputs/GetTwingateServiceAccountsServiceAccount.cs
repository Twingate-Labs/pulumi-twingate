// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TwingateLabs.Twingate.Inputs
{

    public sealed class GetTwingateServiceAccountsServiceAccountArgs : global::Pulumi.InvokeArgs
    {
        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        [Input("keyIds", required: true)]
        private List<string>? _keyIds;
        public List<string> KeyIds
        {
            get => _keyIds ?? (_keyIds = new List<string>());
            set => _keyIds = value;
        }

        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("resourceIds", required: true)]
        private List<string>? _resourceIds;
        public List<string> ResourceIds
        {
            get => _resourceIds ?? (_resourceIds = new List<string>());
            set => _resourceIds = value;
        }

        public GetTwingateServiceAccountsServiceAccountArgs()
        {
        }
        public static new GetTwingateServiceAccountsServiceAccountArgs Empty => new GetTwingateServiceAccountsServiceAccountArgs();
    }
}
