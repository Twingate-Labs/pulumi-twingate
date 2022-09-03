// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TwingateLabs.Twingate
{
    public static class GetTwingateResource
    {
        public static Task<GetTwingateResourceResult> InvokeAsync(GetTwingateResourceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetTwingateResourceResult>("twingate:index/getTwingateResource:getTwingateResource", args ?? new GetTwingateResourceArgs(), options.WithDefaults());

        public static Output<GetTwingateResourceResult> Invoke(GetTwingateResourceInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetTwingateResourceResult>("twingate:index/getTwingateResource:getTwingateResource", args ?? new GetTwingateResourceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTwingateResourceArgs : global::Pulumi.InvokeArgs
    {
        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        [Input("protocols")]
        private List<Inputs.GetTwingateResourceProtocolArgs>? _protocols;
        public List<Inputs.GetTwingateResourceProtocolArgs> Protocols
        {
            get => _protocols ?? (_protocols = new List<Inputs.GetTwingateResourceProtocolArgs>());
            set => _protocols = value;
        }

        public GetTwingateResourceArgs()
        {
        }
        public static new GetTwingateResourceArgs Empty => new GetTwingateResourceArgs();
    }

    public sealed class GetTwingateResourceInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("protocols")]
        private InputList<Inputs.GetTwingateResourceProtocolInputArgs>? _protocols;
        public InputList<Inputs.GetTwingateResourceProtocolInputArgs> Protocols
        {
            get => _protocols ?? (_protocols = new InputList<Inputs.GetTwingateResourceProtocolInputArgs>());
            set => _protocols = value;
        }

        public GetTwingateResourceInvokeArgs()
        {
        }
        public static new GetTwingateResourceInvokeArgs Empty => new GetTwingateResourceInvokeArgs();
    }


    [OutputType]
    public sealed class GetTwingateResourceResult
    {
        public readonly string Address;
        public readonly string Id;
        public readonly string Name;
        public readonly ImmutableArray<Outputs.GetTwingateResourceProtocolResult> Protocols;
        public readonly string RemoteNetworkId;

        [OutputConstructor]
        private GetTwingateResourceResult(
            string address,

            string id,

            string name,

            ImmutableArray<Outputs.GetTwingateResourceProtocolResult> protocols,

            string remoteNetworkId)
        {
            Address = address;
            Id = id;
            Name = name;
            Protocols = protocols;
            RemoteNetworkId = remoteNetworkId;
        }
    }
}