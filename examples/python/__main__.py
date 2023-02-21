import pulumi_twingate as twingate
import pulumi

remote_network = twingate.TwingateRemoteNetwork("python_pulumi_test", name="Python Pulumi Test")

twingate_resource = twingate.TwingateResource("python_example",
    name="Python Pulumi Website",
    address="www.pulumi.com",
    remote_network_id=remote_network.id,
    access= {"group_ids": ["R3JvdXA6NTcyNDU="]}
)

service_account = twingate.TwingateServiceAccount("python_service", name="Python Service")

service_account_key = twingate.TwingateServiceAccountKey("ci_cd_key", name="CI_CD_Key", service_account_id=service_account.id)

pulumi.export("test", service_account_key.token)