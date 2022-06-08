module github.com/Twingate/pulumi-twingate/provider

go 1.16

replace github.com/hashicorp/terraform-plugin-sdk/v2 => github.com/pulumi/terraform-plugin-sdk/v2 v2.0.0-20220505215311-795430389fa7

require (
	github.com/Twingate/terraform-provider-twingate v0.1.7
	github.com/pulumi/pulumi-terraform-bridge/v3 v3.25.0
)
