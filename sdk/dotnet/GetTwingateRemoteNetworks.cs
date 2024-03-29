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
    public static class GetTwingateRemoteNetworks
    {
        public static Task<GetTwingateRemoteNetworksResult> InvokeAsync(GetTwingateRemoteNetworksArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetTwingateRemoteNetworksResult>("twingate:index/getTwingateRemoteNetworks:getTwingateRemoteNetworks", args ?? new GetTwingateRemoteNetworksArgs(), options.WithDefaults());

        public static Output<GetTwingateRemoteNetworksResult> Invoke(GetTwingateRemoteNetworksInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetTwingateRemoteNetworksResult>("twingate:index/getTwingateRemoteNetworks:getTwingateRemoteNetworks", args ?? new GetTwingateRemoteNetworksInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTwingateRemoteNetworksArgs : global::Pulumi.InvokeArgs
    {
        [Input("remoteNetworks")]
        private List<Inputs.GetTwingateRemoteNetworksRemoteNetworkArgs>? _remoteNetworks;
        public List<Inputs.GetTwingateRemoteNetworksRemoteNetworkArgs> RemoteNetworks
        {
            get => _remoteNetworks ?? (_remoteNetworks = new List<Inputs.GetTwingateRemoteNetworksRemoteNetworkArgs>());
            set => _remoteNetworks = value;
        }

        public GetTwingateRemoteNetworksArgs()
        {
        }
        public static new GetTwingateRemoteNetworksArgs Empty => new GetTwingateRemoteNetworksArgs();
    }

    public sealed class GetTwingateRemoteNetworksInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("remoteNetworks")]
        private InputList<Inputs.GetTwingateRemoteNetworksRemoteNetworkInputArgs>? _remoteNetworks;
        public InputList<Inputs.GetTwingateRemoteNetworksRemoteNetworkInputArgs> RemoteNetworks
        {
            get => _remoteNetworks ?? (_remoteNetworks = new InputList<Inputs.GetTwingateRemoteNetworksRemoteNetworkInputArgs>());
            set => _remoteNetworks = value;
        }

        public GetTwingateRemoteNetworksInvokeArgs()
        {
        }
        public static new GetTwingateRemoteNetworksInvokeArgs Empty => new GetTwingateRemoteNetworksInvokeArgs();
    }


    [OutputType]
    public sealed class GetTwingateRemoteNetworksResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetTwingateRemoteNetworksRemoteNetworkResult> RemoteNetworks;

        [OutputConstructor]
        private GetTwingateRemoteNetworksResult(
            string id,

            ImmutableArray<Outputs.GetTwingateRemoteNetworksRemoteNetworkResult> remoteNetworks)
        {
            Id = id;
            RemoteNetworks = remoteNetworks;
        }
    }
}
