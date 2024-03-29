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

    public sealed class GetTwingateResourceProtocolInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("allowIcmp", required: true)]
        public Input<bool> AllowIcmp { get; set; } = null!;

        [Input("tcps")]
        private InputList<Inputs.GetTwingateResourceProtocolTcpInputArgs>? _tcps;
        public InputList<Inputs.GetTwingateResourceProtocolTcpInputArgs> Tcps
        {
            get => _tcps ?? (_tcps = new InputList<Inputs.GetTwingateResourceProtocolTcpInputArgs>());
            set => _tcps = value;
        }

        [Input("udps")]
        private InputList<Inputs.GetTwingateResourceProtocolUdpInputArgs>? _udps;
        public InputList<Inputs.GetTwingateResourceProtocolUdpInputArgs> Udps
        {
            get => _udps ?? (_udps = new InputList<Inputs.GetTwingateResourceProtocolUdpInputArgs>());
            set => _udps = value;
        }

        public GetTwingateResourceProtocolInputArgs()
        {
        }
        public static new GetTwingateResourceProtocolInputArgs Empty => new GetTwingateResourceProtocolInputArgs();
    }
}
