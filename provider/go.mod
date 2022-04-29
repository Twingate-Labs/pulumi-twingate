module github.com/Twingate/pulumi-twingate/provider

go 1.16

replace github.com/hashicorp/terraform-plugin-sdk/v2 => github.com/pulumi/terraform-plugin-sdk/v2 v2.0.0-20211230170131-3a7c83bfab87

require (
	github.com/Twingate-Labs/terraform-provider-twingate v0.1.7-0.20220429123622-020282518e12
	github.com/pulumi/pulumi-terraform-bridge/v3 v3.21.0
)
