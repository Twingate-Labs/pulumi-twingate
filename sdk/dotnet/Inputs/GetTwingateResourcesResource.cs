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

    public sealed class GetTwingateResourcesResourceArgs : global::Pulumi.InvokeArgs
    {
        [Input("address", required: true)]
        public string Address { get; set; } = null!;

        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("protocols")]
        private List<Inputs.GetTwingateResourcesResourceProtocolArgs>? _protocols;
        public List<Inputs.GetTwingateResourcesResourceProtocolArgs> Protocols
        {
            get => _protocols ?? (_protocols = new List<Inputs.GetTwingateResourcesResourceProtocolArgs>());
            set => _protocols = value;
        }

        [Input("remoteNetworkId", required: true)]
        public string RemoteNetworkId { get; set; } = null!;

        public GetTwingateResourcesResourceArgs()
        {
        }
        public static new GetTwingateResourcesResourceArgs Empty => new GetTwingateResourcesResourceArgs();
    }
}
