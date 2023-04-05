# Connector AWS
This example demonstrates how to deploy Twingate connectors to AWS ECS Fargate.

## Pre-requisite
* Python and PIP
* Pulumi
* AWS CLI

## How to Use
* Clone the repository
* `cd /path/to/repo/examples/connector-aws-ecs`
* Configure Pulumi-Twingate Provider, see configuration section [here](../../readme.md)
* Setup AWS CLI, see [here](https://docs.aws.amazon.com/cli/latest/userguide/getting-started-quickstart.html)
* `cp pulumi.dev.yaml.example pulumi.dev.yaml` and modify `pulumi.dev.yaml` to desired values including number of connectors to deploy.
* `pulumi up`

**Note**: `pulumi up` should automatically download the required Python dependency and Pulumi Plugins.

**Note**: make sure `dev` part in the file name of `pulumi.dev.yaml` is changed to the Pulumi stack name.