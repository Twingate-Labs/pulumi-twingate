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
    public static class GetTwingateServiceAccounts
    {
        public static Task<GetTwingateServiceAccountsResult> InvokeAsync(GetTwingateServiceAccountsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetTwingateServiceAccountsResult>("twingate:index/getTwingateServiceAccounts:getTwingateServiceAccounts", args ?? new GetTwingateServiceAccountsArgs(), options.WithDefaults());

        public static Output<GetTwingateServiceAccountsResult> Invoke(GetTwingateServiceAccountsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetTwingateServiceAccountsResult>("twingate:index/getTwingateServiceAccounts:getTwingateServiceAccounts", args ?? new GetTwingateServiceAccountsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTwingateServiceAccountsArgs : global::Pulumi.InvokeArgs
    {
        [Input("name")]
        public string? Name { get; set; }

        [Input("serviceAccounts")]
        private List<Inputs.GetTwingateServiceAccountsServiceAccountArgs>? _serviceAccounts;
        public List<Inputs.GetTwingateServiceAccountsServiceAccountArgs> ServiceAccounts
        {
            get => _serviceAccounts ?? (_serviceAccounts = new List<Inputs.GetTwingateServiceAccountsServiceAccountArgs>());
            set => _serviceAccounts = value;
        }

        public GetTwingateServiceAccountsArgs()
        {
        }
        public static new GetTwingateServiceAccountsArgs Empty => new GetTwingateServiceAccountsArgs();
    }

    public sealed class GetTwingateServiceAccountsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("serviceAccounts")]
        private InputList<Inputs.GetTwingateServiceAccountsServiceAccountInputArgs>? _serviceAccounts;
        public InputList<Inputs.GetTwingateServiceAccountsServiceAccountInputArgs> ServiceAccounts
        {
            get => _serviceAccounts ?? (_serviceAccounts = new InputList<Inputs.GetTwingateServiceAccountsServiceAccountInputArgs>());
            set => _serviceAccounts = value;
        }

        public GetTwingateServiceAccountsInvokeArgs()
        {
        }
        public static new GetTwingateServiceAccountsInvokeArgs Empty => new GetTwingateServiceAccountsInvokeArgs();
    }


    [OutputType]
    public sealed class GetTwingateServiceAccountsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? Name;
        public readonly ImmutableArray<Outputs.GetTwingateServiceAccountsServiceAccountResult> ServiceAccounts;

        [OutputConstructor]
        private GetTwingateServiceAccountsResult(
            string id,

            string? name,

            ImmutableArray<Outputs.GetTwingateServiceAccountsServiceAccountResult> serviceAccounts)
        {
            Id = id;
            Name = name;
            ServiceAccounts = serviceAccounts;
        }
    }
}
