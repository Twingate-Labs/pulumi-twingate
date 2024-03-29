// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export function getTwingateResource(args: GetTwingateResourceArgs, opts?: pulumi.InvokeOptions): Promise<GetTwingateResourceResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("twingate:index/getTwingateResource:getTwingateResource", {
        "id": args.id,
        "protocols": args.protocols,
    }, opts);
}

/**
 * A collection of arguments for invoking getTwingateResource.
 */
export interface GetTwingateResourceArgs {
    id: string;
    protocols?: inputs.GetTwingateResourceProtocol[];
}

/**
 * A collection of values returned by getTwingateResource.
 */
export interface GetTwingateResourceResult {
    readonly address: string;
    readonly id: string;
    readonly name: string;
    readonly protocols?: outputs.GetTwingateResourceProtocol[];
    readonly remoteNetworkId: string;
}
export function getTwingateResourceOutput(args: GetTwingateResourceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetTwingateResourceResult> {
    return pulumi.output(args).apply((a: any) => getTwingateResource(a, opts))
}

/**
 * A collection of arguments for invoking getTwingateResource.
 */
export interface GetTwingateResourceOutputArgs {
    id: pulumi.Input<string>;
    protocols?: pulumi.Input<pulumi.Input<inputs.GetTwingateResourceProtocolArgs>[]>;
}
