import * as twingate from "@twingate-labs/pulumi-twingate"

const remoteNetwork = new twingate.TwingateRemoteNetwork("test-network", {
    name: "Test Network"
})

new twingate.TwingateResource("test-resource", {
    name: "Pulumi Website",
    address: "www.pulumi.com",
    remoteNetworkId: remoteNetwork.id,
    access: {
        groupIds: ["R3JvdXA6NTcyNDU="]
    }
})

const serviceAccount = new twingate.TwingateServiceAccount("test-service", {
    name: "Test Service"
})


