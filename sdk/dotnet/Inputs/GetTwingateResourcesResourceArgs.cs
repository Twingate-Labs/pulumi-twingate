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

    public sealed class GetTwingateResourcesResourceInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("address", required: true)]
        public Input<string> Address { get; set; } = null!;

        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("protocols")]
        private InputList<Inputs.GetTwingateResourcesResourceProtocolInputArgs>? _protocols;
        public InputList<Inputs.GetTwingateResourcesResourceProtocolInputArgs> Protocols
        {
            get => _protocols ?? (_protocols = new InputList<Inputs.GetTwingateResourcesResourceProtocolInputArgs>());
            set => _protocols = value;
        }

        [Input("remoteNetworkId", required: true)]
        public Input<string> RemoteNetworkId { get; set; } = null!;

        public GetTwingateResourcesResourceInputArgs()
        {
        }
        public static new GetTwingateResourcesResourceInputArgs Empty => new GetTwingateResourcesResourceInputArgs();
    }
}
