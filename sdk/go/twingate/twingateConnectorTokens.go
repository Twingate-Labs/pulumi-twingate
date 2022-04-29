// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package twingate

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This resource type will generate tokens for a Connector, which are needed to successfully provision one on your network. The Connector itself has its own resource type and must be created before you can provision tokens.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/Twingate-Labs/pulumi-twingate/sdk/go/twingate"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		awsNetwork, err := twingate.NewTwingateRemoteNetwork(ctx, "awsNetwork", nil)
// 		if err != nil {
// 			return err
// 		}
// 		awsConnector, err := twingate.NewTwingateConnector(ctx, "awsConnector", &twingate.TwingateConnectorArgs{
// 			RemoteNetworkId: awsNetwork.ID(),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = twingate.NewTwingateConnectorTokens(ctx, "awsConnectorTokens", &twingate.TwingateConnectorTokensArgs{
// 			ConnectorId: awsConnector.ID(),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type TwingateConnectorTokens struct {
	pulumi.CustomResourceState

	// The Access Token of the parent Connector
	AccessToken pulumi.StringOutput `pulumi:"accessToken"`
	// The ID of the parent Connector
	ConnectorId pulumi.StringOutput `pulumi:"connectorId"`
	// Arbitrary map of values that, when changed, will trigger recreation of resource. Use this to automatically rotate
	// Connector tokens on a schedule.
	Keepers pulumi.MapOutput `pulumi:"keepers"`
	// The Refresh Token of the parent Connector
	RefreshToken pulumi.StringOutput `pulumi:"refreshToken"`
}

// NewTwingateConnectorTokens registers a new resource with the given unique name, arguments, and options.
func NewTwingateConnectorTokens(ctx *pulumi.Context,
	name string, args *TwingateConnectorTokensArgs, opts ...pulumi.ResourceOption) (*TwingateConnectorTokens, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ConnectorId == nil {
		return nil, errors.New("invalid value for required argument 'ConnectorId'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource TwingateConnectorTokens
	err := ctx.RegisterResource("twingate:index/twingateConnectorTokens:TwingateConnectorTokens", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTwingateConnectorTokens gets an existing TwingateConnectorTokens resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTwingateConnectorTokens(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TwingateConnectorTokensState, opts ...pulumi.ResourceOption) (*TwingateConnectorTokens, error) {
	var resource TwingateConnectorTokens
	err := ctx.ReadResource("twingate:index/twingateConnectorTokens:TwingateConnectorTokens", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TwingateConnectorTokens resources.
type twingateConnectorTokensState struct {
	// The Access Token of the parent Connector
	AccessToken *string `pulumi:"accessToken"`
	// The ID of the parent Connector
	ConnectorId *string `pulumi:"connectorId"`
	// Arbitrary map of values that, when changed, will trigger recreation of resource. Use this to automatically rotate
	// Connector tokens on a schedule.
	Keepers map[string]interface{} `pulumi:"keepers"`
	// The Refresh Token of the parent Connector
	RefreshToken *string `pulumi:"refreshToken"`
}

type TwingateConnectorTokensState struct {
	// The Access Token of the parent Connector
	AccessToken pulumi.StringPtrInput
	// The ID of the parent Connector
	ConnectorId pulumi.StringPtrInput
	// Arbitrary map of values that, when changed, will trigger recreation of resource. Use this to automatically rotate
	// Connector tokens on a schedule.
	Keepers pulumi.MapInput
	// The Refresh Token of the parent Connector
	RefreshToken pulumi.StringPtrInput
}

func (TwingateConnectorTokensState) ElementType() reflect.Type {
	return reflect.TypeOf((*twingateConnectorTokensState)(nil)).Elem()
}

type twingateConnectorTokensArgs struct {
	// The ID of the parent Connector
	ConnectorId string `pulumi:"connectorId"`
	// Arbitrary map of values that, when changed, will trigger recreation of resource. Use this to automatically rotate
	// Connector tokens on a schedule.
	Keepers map[string]interface{} `pulumi:"keepers"`
}

// The set of arguments for constructing a TwingateConnectorTokens resource.
type TwingateConnectorTokensArgs struct {
	// The ID of the parent Connector
	ConnectorId pulumi.StringInput
	// Arbitrary map of values that, when changed, will trigger recreation of resource. Use this to automatically rotate
	// Connector tokens on a schedule.
	Keepers pulumi.MapInput
}

func (TwingateConnectorTokensArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*twingateConnectorTokensArgs)(nil)).Elem()
}

type TwingateConnectorTokensInput interface {
	pulumi.Input

	ToTwingateConnectorTokensOutput() TwingateConnectorTokensOutput
	ToTwingateConnectorTokensOutputWithContext(ctx context.Context) TwingateConnectorTokensOutput
}

func (*TwingateConnectorTokens) ElementType() reflect.Type {
	return reflect.TypeOf((**TwingateConnectorTokens)(nil)).Elem()
}

func (i *TwingateConnectorTokens) ToTwingateConnectorTokensOutput() TwingateConnectorTokensOutput {
	return i.ToTwingateConnectorTokensOutputWithContext(context.Background())
}

func (i *TwingateConnectorTokens) ToTwingateConnectorTokensOutputWithContext(ctx context.Context) TwingateConnectorTokensOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TwingateConnectorTokensOutput)
}

// TwingateConnectorTokensArrayInput is an input type that accepts TwingateConnectorTokensArray and TwingateConnectorTokensArrayOutput values.
// You can construct a concrete instance of `TwingateConnectorTokensArrayInput` via:
//
//          TwingateConnectorTokensArray{ TwingateConnectorTokensArgs{...} }
type TwingateConnectorTokensArrayInput interface {
	pulumi.Input

	ToTwingateConnectorTokensArrayOutput() TwingateConnectorTokensArrayOutput
	ToTwingateConnectorTokensArrayOutputWithContext(context.Context) TwingateConnectorTokensArrayOutput
}

type TwingateConnectorTokensArray []TwingateConnectorTokensInput

func (TwingateConnectorTokensArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*TwingateConnectorTokens)(nil)).Elem()
}

func (i TwingateConnectorTokensArray) ToTwingateConnectorTokensArrayOutput() TwingateConnectorTokensArrayOutput {
	return i.ToTwingateConnectorTokensArrayOutputWithContext(context.Background())
}

func (i TwingateConnectorTokensArray) ToTwingateConnectorTokensArrayOutputWithContext(ctx context.Context) TwingateConnectorTokensArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TwingateConnectorTokensArrayOutput)
}

// TwingateConnectorTokensMapInput is an input type that accepts TwingateConnectorTokensMap and TwingateConnectorTokensMapOutput values.
// You can construct a concrete instance of `TwingateConnectorTokensMapInput` via:
//
//          TwingateConnectorTokensMap{ "key": TwingateConnectorTokensArgs{...} }
type TwingateConnectorTokensMapInput interface {
	pulumi.Input

	ToTwingateConnectorTokensMapOutput() TwingateConnectorTokensMapOutput
	ToTwingateConnectorTokensMapOutputWithContext(context.Context) TwingateConnectorTokensMapOutput
}

type TwingateConnectorTokensMap map[string]TwingateConnectorTokensInput

func (TwingateConnectorTokensMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*TwingateConnectorTokens)(nil)).Elem()
}

func (i TwingateConnectorTokensMap) ToTwingateConnectorTokensMapOutput() TwingateConnectorTokensMapOutput {
	return i.ToTwingateConnectorTokensMapOutputWithContext(context.Background())
}

func (i TwingateConnectorTokensMap) ToTwingateConnectorTokensMapOutputWithContext(ctx context.Context) TwingateConnectorTokensMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TwingateConnectorTokensMapOutput)
}

type TwingateConnectorTokensOutput struct{ *pulumi.OutputState }

func (TwingateConnectorTokensOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**TwingateConnectorTokens)(nil)).Elem()
}

func (o TwingateConnectorTokensOutput) ToTwingateConnectorTokensOutput() TwingateConnectorTokensOutput {
	return o
}

func (o TwingateConnectorTokensOutput) ToTwingateConnectorTokensOutputWithContext(ctx context.Context) TwingateConnectorTokensOutput {
	return o
}

type TwingateConnectorTokensArrayOutput struct{ *pulumi.OutputState }

func (TwingateConnectorTokensArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*TwingateConnectorTokens)(nil)).Elem()
}

func (o TwingateConnectorTokensArrayOutput) ToTwingateConnectorTokensArrayOutput() TwingateConnectorTokensArrayOutput {
	return o
}

func (o TwingateConnectorTokensArrayOutput) ToTwingateConnectorTokensArrayOutputWithContext(ctx context.Context) TwingateConnectorTokensArrayOutput {
	return o
}

func (o TwingateConnectorTokensArrayOutput) Index(i pulumi.IntInput) TwingateConnectorTokensOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *TwingateConnectorTokens {
		return vs[0].([]*TwingateConnectorTokens)[vs[1].(int)]
	}).(TwingateConnectorTokensOutput)
}

type TwingateConnectorTokensMapOutput struct{ *pulumi.OutputState }

func (TwingateConnectorTokensMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*TwingateConnectorTokens)(nil)).Elem()
}

func (o TwingateConnectorTokensMapOutput) ToTwingateConnectorTokensMapOutput() TwingateConnectorTokensMapOutput {
	return o
}

func (o TwingateConnectorTokensMapOutput) ToTwingateConnectorTokensMapOutputWithContext(ctx context.Context) TwingateConnectorTokensMapOutput {
	return o
}

func (o TwingateConnectorTokensMapOutput) MapIndex(k pulumi.StringInput) TwingateConnectorTokensOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *TwingateConnectorTokens {
		return vs[0].(map[string]*TwingateConnectorTokens)[vs[1].(string)]
	}).(TwingateConnectorTokensOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*TwingateConnectorTokensInput)(nil)).Elem(), &TwingateConnectorTokens{})
	pulumi.RegisterInputType(reflect.TypeOf((*TwingateConnectorTokensArrayInput)(nil)).Elem(), TwingateConnectorTokensArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*TwingateConnectorTokensMapInput)(nil)).Elem(), TwingateConnectorTokensMap{})
	pulumi.RegisterOutputType(TwingateConnectorTokensOutput{})
	pulumi.RegisterOutputType(TwingateConnectorTokensArrayOutput{})
	pulumi.RegisterOutputType(TwingateConnectorTokensMapOutput{})
}
