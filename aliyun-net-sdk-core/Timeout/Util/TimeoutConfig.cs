using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Core.Timeout.Util
{
    public static class TimeoutConfig
    {
        private static void initData()
        {
            Product productEcs = new Product();
            productEcs.ProductName = "ecs";
            Version version20140526 = new Version();
            version20140526.VersionDate = "2014-05-26";
            version20140526.Apis.Add("ActivateRouterInterface", 10);
            version20140526.Apis.Add("AddTags", 61);
            version20140526.Apis.Add("AllocateDedicatedHosts", 10);
            version20140526.Apis.Add("AllocateEipAddress", 17);
            version20140526.Apis.Add("AllocatePublicIpAddress", 36);
            version20140526.Apis.Add("ApplyAutoSnapshotPolicy", 10);
            version20140526.Apis.Add("AssignIpv6Addresses", 10);
            version20140526.Apis.Add("AssignPrivateIpAddresses", 10);
            version20140526.Apis.Add("AssociateEipAddress", 17);
            version20140526.Apis.Add("AttachClassicLinkVpc", 14);
            version20140526.Apis.Add("AttachDisk", 36);
            version20140526.Apis.Add("AttachInstanceRamRole", 11);
            version20140526.Apis.Add("AttachKeyPair", 16);
            version20140526.Apis.Add("AttachNetworkInterface", 16);
            version20140526.Apis.Add("AuthorizeSecurityGroupEgress", 16);
            version20140526.Apis.Add("AuthorizeSecurityGroup", 16);
            version20140526.Apis.Add("CancelAutoSnapshotPolicy", 10);
            version20140526.Apis.Add("CancelCopyImage", 10);
            version20140526.Apis.Add("CancelPhysicalConnection", 10);
            version20140526.Apis.Add("CancelSimulatedSystemEvents", 10);
            version20140526.Apis.Add("CancelTask", 10);
            version20140526.Apis.Add("ConnectRouterInterface", 10);
            version20140526.Apis.Add("ConvertNatPublicIpToEip", 12);
            version20140526.Apis.Add("CopyImage", 10);
            version20140526.Apis.Add("CreateAutoSnapshotPolicy", 10);
            version20140526.Apis.Add("CreateCommand", 16);
            version20140526.Apis.Add("CreateDeploymentSet", 16);
            version20140526.Apis.Add("CreateDisk", 36);
            version20140526.Apis.Add("CreateHpcCluster", 10);
            version20140526.Apis.Add("CreateImage", 36);
            version20140526.Apis.Add("CreateInstance", 86);
            version20140526.Apis.Add("CreateKeyPair", 10);
            version20140526.Apis.Add("CreateLaunchTemplate", 10);
            version20140526.Apis.Add("CreateLaunchTemplateVersion", 10);
            version20140526.Apis.Add("CreateNatGateway", 36);
            version20140526.Apis.Add("CreateNetworkInterfacePermission", 13);
            version20140526.Apis.Add("CreateNetworkInterface", 16);
            version20140526.Apis.Add("CreatePhysicalConnection", 10);
            version20140526.Apis.Add("CreateRouteEntry", 17);
            version20140526.Apis.Add("CreateRouterInterface", 10);
            version20140526.Apis.Add("CreateSecurityGroup", 86);
            version20140526.Apis.Add("CreateSimulatedSystemEvents", 10);
            version20140526.Apis.Add("CreateSnapshot", 86);
            version20140526.Apis.Add("CreateVirtualBorderRouter", 10);
            version20140526.Apis.Add("CreateVpc", 16);
            version20140526.Apis.Add("CreateVSwitch", 17);
            version20140526.Apis.Add("DeactivateRouterInterface", 10);
            version20140526.Apis.Add("DeleteAutoSnapshotPolicy", 10);
            version20140526.Apis.Add("DeleteBandwidthPackage", 10);
            version20140526.Apis.Add("DeleteCommand", 16);
            version20140526.Apis.Add("DeleteDeploymentSet", 12);
            version20140526.Apis.Add("DeleteDisk", 16);
            version20140526.Apis.Add("DeleteHpcCluster", 10);
            version20140526.Apis.Add("DeleteImage", 36);
            version20140526.Apis.Add("DeleteInstance", 66);
            version20140526.Apis.Add("DeleteKeyPairs", 10);
            version20140526.Apis.Add("DeleteLaunchTemplate", 10);
            version20140526.Apis.Add("DeleteLaunchTemplateVersion", 10);
            version20140526.Apis.Add("DeleteNatGateway", 10);
            version20140526.Apis.Add("DeleteNetworkInterfacePermission", 10);
            version20140526.Apis.Add("DeleteNetworkInterface", 16);
            version20140526.Apis.Add("DeletePhysicalConnection", 10);
            version20140526.Apis.Add("DeleteRouteEntry", 16);
            version20140526.Apis.Add("DeleteRouterInterface", 10);
            version20140526.Apis.Add("DeleteSecurityGroup", 87);
            version20140526.Apis.Add("DeleteSnapshot", 17);
            version20140526.Apis.Add("DeleteVirtualBorderRouter", 10);
            version20140526.Apis.Add("DeleteVpc", 17);
            version20140526.Apis.Add("DeleteVSwitch", 17);
            version20140526.Apis.Add("DescribeAccessPoints", 10);
            version20140526.Apis.Add("DescribeAccountAttributes", 10);
            version20140526.Apis.Add("DescribeAutoSnapshotPolicyEx", 16);
            version20140526.Apis.Add("DescribeAvailableResource", 10);
            version20140526.Apis.Add("DescribeBandwidthLimitation", 16);
            version20140526.Apis.Add("DescribeBandwidthPackages", 10);
            version20140526.Apis.Add("DescribeClassicLinkInstances", 15);
            version20140526.Apis.Add("DescribeCloudAssistantStatus", 16);
            version20140526.Apis.Add("DescribeClusters", 10);
            version20140526.Apis.Add("DescribeCommands", 16);
            version20140526.Apis.Add("DescribeDedicatedHosts", 10);
            version20140526.Apis.Add("DescribeDedicatedHostTypes", 10);
            version20140526.Apis.Add("DescribeDeploymentSets", 26);
            version20140526.Apis.Add("DescribeDiskMonitorData", 16);
            version20140526.Apis.Add("DescribeDisksFullStatus", 14);
            version20140526.Apis.Add("DescribeDisks", 19);
            version20140526.Apis.Add("DescribeEipAddresses", 16);
            version20140526.Apis.Add("DescribeEipMonitorData", 16);
            version20140526.Apis.Add("DescribeEniMonitorData", 10);
            version20140526.Apis.Add("DescribeHaVips", 10);
            version20140526.Apis.Add("DescribeHpcClusters", 16);
            version20140526.Apis.Add("DescribeImageSharePermission", 10);
            version20140526.Apis.Add("DescribeImages", 38);
            version20140526.Apis.Add("DescribeImageSupportInstanceTypes", 16);
            version20140526.Apis.Add("DescribeInstanceAttribute", 36);
            version20140526.Apis.Add("DescribeInstanceAutoRenewAttribute", 17);
            version20140526.Apis.Add("DescribeInstanceHistoryEvents", 19);
            version20140526.Apis.Add("DescribeInstanceMonitorData", 19);
            version20140526.Apis.Add("DescribeInstancePhysicalAttribute", 10);
            version20140526.Apis.Add("DescribeInstanceRamRole", 11);
            version20140526.Apis.Add("DescribeInstancesFullStatus", 14);
            version20140526.Apis.Add("DescribeInstances", 10);
            version20140526.Apis.Add("DescribeInstanceStatus", 26);
            version20140526.Apis.Add("DescribeInstanceTopology", 12);
            version20140526.Apis.Add("DescribeInstanceTypeFamilies", 17);
            version20140526.Apis.Add("DescribeInstanceTypes", 17);
            version20140526.Apis.Add("DescribeInstanceVncPasswd", 10);
            version20140526.Apis.Add("DescribeInstanceVncUrl", 36);
            version20140526.Apis.Add("DescribeInvocationResults", 16);
            version20140526.Apis.Add("DescribeInvocations", 16);
            version20140526.Apis.Add("DescribeKeyPairs", 12);
            version20140526.Apis.Add("DescribeLaunchTemplates", 16);
            version20140526.Apis.Add("DescribeLaunchTemplateVersions", 16);
            version20140526.Apis.Add("DescribeLimitation", 36);
            version20140526.Apis.Add("DescribeNatGateways", 10);
            version20140526.Apis.Add("DescribeNetworkInterfacePermissions", 13);
            version20140526.Apis.Add("DescribeNetworkInterfaces", 16);
            version20140526.Apis.Add("DescribeNewProjectEipMonitorData", 16);
            version20140526.Apis.Add("DescribePhysicalConnections", 10);
            version20140526.Apis.Add("DescribePrice", 16);
            version20140526.Apis.Add("DescribeRecommendInstanceType", 10);
            version20140526.Apis.Add("DescribeRegions", 19);
            version20140526.Apis.Add("DescribeRenewalPrice", 16);
            version20140526.Apis.Add("DescribeResourceByTags", 10);
            version20140526.Apis.Add("DescribeResourcesModification", 17);
            version20140526.Apis.Add("DescribeRouterInterfaces", 10);
            version20140526.Apis.Add("DescribeRouteTables", 17);
            version20140526.Apis.Add("DescribeSecurityGroupAttribute", 133);
            version20140526.Apis.Add("DescribeSecurityGroupReferences", 16);
            version20140526.Apis.Add("DescribeSecurityGroups", 25);
            version20140526.Apis.Add("DescribeSnapshotLinks", 17);
            version20140526.Apis.Add("DescribeSnapshotMonitorData", 12);
            version20140526.Apis.Add("DescribeSnapshotPackage", 10);
            version20140526.Apis.Add("DescribeSnapshots", 26);
            version20140526.Apis.Add("DescribeSnapshotsUsage", 26);
            version20140526.Apis.Add("DescribeSpotPriceHistory", 22);
            version20140526.Apis.Add("DescribeTags", 17);
            version20140526.Apis.Add("DescribeTaskAttribute", 10);
            version20140526.Apis.Add("DescribeTasks", 11);
            version20140526.Apis.Add("DescribeUserBusinessBehavior", 13);
            version20140526.Apis.Add("DescribeUserData", 10);
            version20140526.Apis.Add("DescribeVirtualBorderRoutersForPhysicalConnection", 10);
            version20140526.Apis.Add("DescribeVirtualBorderRouters", 10);
            version20140526.Apis.Add("DescribeVpcs", 41);
            version20140526.Apis.Add("DescribeVRouters", 17);
            version20140526.Apis.Add("DescribeVSwitches", 17);
            version20140526.Apis.Add("DescribeZones", 103);
            version20140526.Apis.Add("DetachClassicLinkVpc", 14);
            version20140526.Apis.Add("DetachDisk", 17);
            version20140526.Apis.Add("DetachInstanceRamRole", 10);
            version20140526.Apis.Add("DetachKeyPair", 10);
            version20140526.Apis.Add("DetachNetworkInterface", 16);
            version20140526.Apis.Add("EipFillParams", 19);
            version20140526.Apis.Add("EipFillProduct", 13);
            version20140526.Apis.Add("EipNotifyPaid", 10);
            version20140526.Apis.Add("EnablePhysicalConnection", 10);
            version20140526.Apis.Add("ExportImage", 10);
            version20140526.Apis.Add("GetInstanceConsoleOutput", 14);
            version20140526.Apis.Add("GetInstanceScreenshot", 14);
            version20140526.Apis.Add("ImportImage", 29);
            version20140526.Apis.Add("ImportKeyPair", 10);
            version20140526.Apis.Add("InstallCloudAssistant", 10);
            version20140526.Apis.Add("InvokeCommand", 16);
            version20140526.Apis.Add("JoinResourceGroup", 10);
            version20140526.Apis.Add("JoinSecurityGroup", 66);
            version20140526.Apis.Add("LeaveSecurityGroup", 66);
            version20140526.Apis.Add("ModifyAutoSnapshotPolicyEx", 10);
            version20140526.Apis.Add("ModifyBandwidthPackageSpec", 11);
            version20140526.Apis.Add("ModifyCommand", 10);
            version20140526.Apis.Add("ModifyDeploymentSetAttribute", 10);
            version20140526.Apis.Add("ModifyDiskAttribute", 16);
            version20140526.Apis.Add("ModifyDiskChargeType", 13);
            version20140526.Apis.Add("ModifyEipAddressAttribute", 14);
            version20140526.Apis.Add("ModifyImageAttribute", 10);
            version20140526.Apis.Add("ModifyImageSharePermission", 16);
            version20140526.Apis.Add("ModifyInstanceAttribute", 22);
            version20140526.Apis.Add("ModifyInstanceAutoReleaseTime", 15);
            version20140526.Apis.Add("ModifyInstanceAutoRenewAttribute", 16);
            version20140526.Apis.Add("ModifyInstanceChargeType", 22);
            version20140526.Apis.Add("ModifyInstanceDeployment", 10);
            version20140526.Apis.Add("ModifyInstanceNetworkSpec", 36);
            version20140526.Apis.Add("ModifyInstanceSpec", 62);
            version20140526.Apis.Add("ModifyInstanceVncPasswd", 35);
            version20140526.Apis.Add("ModifyInstanceVpcAttribute", 15);
            version20140526.Apis.Add("ModifyLaunchTemplateDefaultVersion", 10);
            version20140526.Apis.Add("ModifyNetworkInterfaceAttribute", 10);
            version20140526.Apis.Add("ModifyPhysicalConnectionAttribute", 10);
            version20140526.Apis.Add("ModifyPrepayInstanceSpec", 13);
            version20140526.Apis.Add("ModifyRouterInterfaceAttribute", 10);
            version20140526.Apis.Add("ModifySecurityGroupAttribute", 10);
            version20140526.Apis.Add("ModifySecurityGroupEgressRule", 10);
            version20140526.Apis.Add("ModifySecurityGroupPolicy", 10);
            version20140526.Apis.Add("ModifySecurityGroupRule", 16);
            version20140526.Apis.Add("ModifySnapshotAttribute", 10);
            version20140526.Apis.Add("ModifyUserBusinessBehavior", 10);
            version20140526.Apis.Add("ModifyVirtualBorderRouterAttribute", 10);
            version20140526.Apis.Add("ModifyVpcAttribute", 10);
            version20140526.Apis.Add("ModifyVRouterAttribute", 10);
            version20140526.Apis.Add("ModifyVSwitchAttribute", 10);
            version20140526.Apis.Add("ReActivateInstances", 10);
            version20140526.Apis.Add("RebootInstance", 27);
            version20140526.Apis.Add("RedeployInstance", 14);
            version20140526.Apis.Add("ReInitDisk", 16);
            version20140526.Apis.Add("ReleaseDedicatedHost", 10);
            version20140526.Apis.Add("ReleaseEipAddress", 16);
            version20140526.Apis.Add("ReleasePublicIpAddress", 10);
            version20140526.Apis.Add("RemoveTags", 10);
            version20140526.Apis.Add("RenewInstance", 19);
            version20140526.Apis.Add("ReplaceSystemDisk", 36);
            version20140526.Apis.Add("ResetDisk", 36);
            version20140526.Apis.Add("ResizeDisk", 11);
            version20140526.Apis.Add("RevokeSecurityGroupEgress", 13);
            version20140526.Apis.Add("RevokeSecurityGroup", 16);
            version20140526.Apis.Add("RunInstances", 86);
            version20140526.Apis.Add("StartInstance", 46);
            version20140526.Apis.Add("StopInstance", 27);
            version20140526.Apis.Add("StopInvocation", 10);
            version20140526.Apis.Add("TerminatePhysicalConnection", 10);
            version20140526.Apis.Add("TerminateVirtualBorderRouter", 10);
            version20140526.Apis.Add("UnassignIpv6Addresses", 10);
            version20140526.Apis.Add("UnassignPrivateIpAddresses", 10);
            version20140526.Apis.Add("UnassociateEipAddress", 16);
            productEcs.versions.Add("2014-05-26", version20140526);
            
            products.Add("ecs", productEcs);
        }

        private static Dictionary<string, Product> products { get; set; }

        public static int Get(string productName, string versionDate, string actionName)
        {
            if (null == products)
            {
                initData();
            }
            Dictionary<string, int> apis = new Dictionary<string, int>() { };
            if (products.ContainsKey(productName))
            {
                Product product = products[productName];
                if (product.versions.ContainsKey(versionDate))
                {
                    Version version = product.versions[versionDate];
                    if (version.Apis.ContainsKey(actionName))
                    {
                        return version.Apis[actionName];
                    }else{
                        return 0;
                    }
                }
            }
            return 0;
        }
    }

    public class Product
    {
        public string ProductName { get; set; }
        public Dictionary<string, Version> versions { get; set; }
    }

    public class Version
    {
        public String VersionDate { get; set; }

        public Dictionary<string, int> Apis { get; set; }
    }
}
