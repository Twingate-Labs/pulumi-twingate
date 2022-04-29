import {twingate} from "@pulumi/twingate"

const remoteNetwork = new twingate.TwingateRemoteNetwork("test-network", {
    name: "Test Network"
})

new twingate.TwingateResource("test-resource", {
    name: "Pulumi Website",
    address: "www.pulumi.com",
    remoteNetworkId: remoteNetwork.id,
    groupIds: ["R3JvdXA6MjE2MzE="]
})
