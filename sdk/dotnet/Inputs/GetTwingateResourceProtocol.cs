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

    public sealed class GetTwingateResourceProtocolArgs : global::Pulumi.InvokeArgs
    {
        [Input("allowIcmp", required: true)]
        public bool AllowIcmp { get; set; }

        [Input("tcps")]
        private List<Inputs.GetTwingateResourceProtocolTcpArgs>? _tcps;
        public List<Inputs.GetTwingateResourceProtocolTcpArgs> Tcps
        {
            get => _tcps ?? (_tcps = new List<Inputs.GetTwingateResourceProtocolTcpArgs>());
            set => _tcps = value;
        }

        [Input("udps")]
        private List<Inputs.GetTwingateResourceProtocolUdpArgs>? _udps;
        public List<Inputs.GetTwingateResourceProtocolUdpArgs> Udps
        {
            get => _udps ?? (_udps = new List<Inputs.GetTwingateResourceProtocolUdpArgs>());
            set => _udps = value;
        }

        public GetTwingateResourceProtocolArgs()
        {
        }
        public static new GetTwingateResourceProtocolArgs Empty => new GetTwingateResourceProtocolArgs();
    }
}
