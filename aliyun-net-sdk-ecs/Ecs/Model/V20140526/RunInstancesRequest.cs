/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class RunInstancesRequest : RpcAcsRequest<RunInstancesResponse>
    {
        public RunInstancesRequest()
            : base("Ecs", "2014-05-26", "RunInstances", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? uniqueSuffix;

		private string securityEnhancementStrategy;

		private int? minAmount;

		private bool? deletionProtection;

		private string resourceGroupId;

		private string privatePoolOptionsMatchCriteria;

		private string hostName;

		private string password;

		private int? deploymentSetGroupNo;

		private string systemDiskAutoSnapshotPolicyId;

		private int? cpuOptionsCore;

		private int? period;

		private bool? dryRun;

		private string cpuOptionsNuma;

		private long? ownerId;

		private string spotStrategy;

		private string privateIpAddress;

		private string periodUnit;

		private bool? autoRenew;

		private string internetChargeType;

		private int? internetMaxBandwidthIn;

		private string affinity;

		private string imageId;

		private string spotInterruptionBehavior;

		private int? networkInterfaceQueueNumber;

		private string ioOptimized;

		private string securityGroupId;

		private string systemDiskPerformanceLevel;

		private bool? passwordInherit;

		private string instanceType;

		private List<Arn> arns = new List<Arn>(){ };

		private string resourceOwnerAccount;

		private string systemDiskDiskName;

		private string dedicatedHostId;

		private List<string> securityGroupIdss = new List<string>(){ };

		private int? spotDuration;

		private string systemDiskSize;

		private string imageFamily;

		private string launchTemplateName;

		private long? resourceOwnerId;

		private string hpcClusterId;

		private int? httpPutResponseHopLimit;

		private string keyPairName;

		private float? spotPriceLimit;

		private int? storageSetPartitionNumber;

		private List<Tag> tags = new List<Tag>(){ };

		private string privatePoolOptionsId;

		private int? autoRenewPeriod;

		private string launchTemplateId;

		private int? ipv6AddressCount;

		private string vSwitchId;

		private string instanceName;

		private string zoneId;

		private List<string> ipv6Addresss = new List<string>(){ };

		private string clientToken;

		private int? internetMaxBandwidthOut;

		private string description;

		private int? cpuOptionsThreadsPerCore;

		private string systemDiskCategory;

		private string userData;

		private string httpEndpoint;

		private string instanceChargeType;

		private List<NetworkInterface> networkInterfaces = new List<NetworkInterface>(){ };

		private string deploymentSetId;

		private int? amount;

		private string ownerAccount;

		private string tenancy;

		private string ramRoleName;

		private string autoReleaseTime;

		private string creditSpecification;

		private List<DataDisk> dataDisks = new List<DataDisk>(){ };

		private long? launchTemplateVersion;

		private string storageSetId;

		private string httpTokens;

		private string systemDiskDescription;

		public bool? UniqueSuffix
		{
			get
			{
				return uniqueSuffix;
			}
			set	
			{
				uniqueSuffix = value;
				DictionaryUtil.Add(QueryParameters, "UniqueSuffix", value.ToString());
			}
		}

		public string SecurityEnhancementStrategy
		{
			get
			{
				return securityEnhancementStrategy;
			}
			set	
			{
				securityEnhancementStrategy = value;
				DictionaryUtil.Add(QueryParameters, "SecurityEnhancementStrategy", value);
			}
		}

		public int? MinAmount
		{
			get
			{
				return minAmount;
			}
			set	
			{
				minAmount = value;
				DictionaryUtil.Add(QueryParameters, "MinAmount", value.ToString());
			}
		}

		public bool? DeletionProtection
		{
			get
			{
				return deletionProtection;
			}
			set	
			{
				deletionProtection = value;
				DictionaryUtil.Add(QueryParameters, "DeletionProtection", value.ToString());
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public string PrivatePoolOptionsMatchCriteria
		{
			get
			{
				return privatePoolOptionsMatchCriteria;
			}
			set	
			{
				privatePoolOptionsMatchCriteria = value;
				DictionaryUtil.Add(QueryParameters, "PrivatePoolOptions.MatchCriteria", value);
			}
		}

		public string HostName
		{
			get
			{
				return hostName;
			}
			set	
			{
				hostName = value;
				DictionaryUtil.Add(QueryParameters, "HostName", value);
			}
		}

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(QueryParameters, "Password", value);
			}
		}

		public int? DeploymentSetGroupNo
		{
			get
			{
				return deploymentSetGroupNo;
			}
			set	
			{
				deploymentSetGroupNo = value;
				DictionaryUtil.Add(QueryParameters, "DeploymentSetGroupNo", value.ToString());
			}
		}

		public string SystemDiskAutoSnapshotPolicyId
		{
			get
			{
				return systemDiskAutoSnapshotPolicyId;
			}
			set	
			{
				systemDiskAutoSnapshotPolicyId = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.AutoSnapshotPolicyId", value);
			}
		}

		public int? CpuOptionsCore
		{
			get
			{
				return cpuOptionsCore;
			}
			set	
			{
				cpuOptionsCore = value;
				DictionaryUtil.Add(QueryParameters, "CpuOptions.Core", value.ToString());
			}
		}

		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
			}
		}

		public string CpuOptionsNuma
		{
			get
			{
				return cpuOptionsNuma;
			}
			set	
			{
				cpuOptionsNuma = value;
				DictionaryUtil.Add(QueryParameters, "CpuOptions.Numa", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string SpotStrategy
		{
			get
			{
				return spotStrategy;
			}
			set	
			{
				spotStrategy = value;
				DictionaryUtil.Add(QueryParameters, "SpotStrategy", value);
			}
		}

		public string PrivateIpAddress
		{
			get
			{
				return privateIpAddress;
			}
			set	
			{
				privateIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "PrivateIpAddress", value);
			}
		}

		public string PeriodUnit
		{
			get
			{
				return periodUnit;
			}
			set	
			{
				periodUnit = value;
				DictionaryUtil.Add(QueryParameters, "PeriodUnit", value);
			}
		}

		public bool? AutoRenew
		{
			get
			{
				return autoRenew;
			}
			set	
			{
				autoRenew = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenew", value.ToString());
			}
		}

		public string InternetChargeType
		{
			get
			{
				return internetChargeType;
			}
			set	
			{
				internetChargeType = value;
				DictionaryUtil.Add(QueryParameters, "InternetChargeType", value);
			}
		}

		public int? InternetMaxBandwidthIn
		{
			get
			{
				return internetMaxBandwidthIn;
			}
			set	
			{
				internetMaxBandwidthIn = value;
				DictionaryUtil.Add(QueryParameters, "InternetMaxBandwidthIn", value.ToString());
			}
		}

		public string Affinity
		{
			get
			{
				return affinity;
			}
			set	
			{
				affinity = value;
				DictionaryUtil.Add(QueryParameters, "Affinity", value);
			}
		}

		public string ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
				DictionaryUtil.Add(QueryParameters, "ImageId", value);
			}
		}

		public string SpotInterruptionBehavior
		{
			get
			{
				return spotInterruptionBehavior;
			}
			set	
			{
				spotInterruptionBehavior = value;
				DictionaryUtil.Add(QueryParameters, "SpotInterruptionBehavior", value);
			}
		}

		public int? NetworkInterfaceQueueNumber
		{
			get
			{
				return networkInterfaceQueueNumber;
			}
			set	
			{
				networkInterfaceQueueNumber = value;
				DictionaryUtil.Add(QueryParameters, "NetworkInterfaceQueueNumber", value.ToString());
			}
		}

		public string IoOptimized
		{
			get
			{
				return ioOptimized;
			}
			set	
			{
				ioOptimized = value;
				DictionaryUtil.Add(QueryParameters, "IoOptimized", value);
			}
		}

		public string SecurityGroupId
		{
			get
			{
				return securityGroupId;
			}
			set	
			{
				securityGroupId = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupId", value);
			}
		}

		public string SystemDiskPerformanceLevel
		{
			get
			{
				return systemDiskPerformanceLevel;
			}
			set	
			{
				systemDiskPerformanceLevel = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.PerformanceLevel", value);
			}
		}

		public bool? PasswordInherit
		{
			get
			{
				return passwordInherit;
			}
			set	
			{
				passwordInherit = value;
				DictionaryUtil.Add(QueryParameters, "PasswordInherit", value.ToString());
			}
		}

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public List<Arn> Arns
		{
			get
			{
				return arns;
			}

			set
			{
				arns = value;
				for (int i = 0; i < arns.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Arn." + (i + 1) + ".AssumeRoleFor", arns[i].AssumeRoleFor);
					DictionaryUtil.Add(QueryParameters,"Arn." + (i + 1) + ".Rolearn", arns[i].Rolearn);
					DictionaryUtil.Add(QueryParameters,"Arn." + (i + 1) + ".RoleType", arns[i].RoleType);
				}
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string SystemDiskDiskName
		{
			get
			{
				return systemDiskDiskName;
			}
			set	
			{
				systemDiskDiskName = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.DiskName", value);
			}
		}

		public string DedicatedHostId
		{
			get
			{
				return dedicatedHostId;
			}
			set	
			{
				dedicatedHostId = value;
				DictionaryUtil.Add(QueryParameters, "DedicatedHostId", value);
			}
		}

		public List<string> SecurityGroupIdss
		{
			get
			{
				return securityGroupIdss;
			}

			set
			{
				securityGroupIdss = value;
				for (int i = 0; i < securityGroupIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SecurityGroupIds." + (i + 1) , securityGroupIdss[i]);
				}
			}
		}

		public int? SpotDuration
		{
			get
			{
				return spotDuration;
			}
			set	
			{
				spotDuration = value;
				DictionaryUtil.Add(QueryParameters, "SpotDuration", value.ToString());
			}
		}

		public string SystemDiskSize
		{
			get
			{
				return systemDiskSize;
			}
			set	
			{
				systemDiskSize = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Size", value);
			}
		}

		public string ImageFamily
		{
			get
			{
				return imageFamily;
			}
			set	
			{
				imageFamily = value;
				DictionaryUtil.Add(QueryParameters, "ImageFamily", value);
			}
		}

		public string LaunchTemplateName
		{
			get
			{
				return launchTemplateName;
			}
			set	
			{
				launchTemplateName = value;
				DictionaryUtil.Add(QueryParameters, "LaunchTemplateName", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string HpcClusterId
		{
			get
			{
				return hpcClusterId;
			}
			set	
			{
				hpcClusterId = value;
				DictionaryUtil.Add(QueryParameters, "HpcClusterId", value);
			}
		}

		public int? HttpPutResponseHopLimit
		{
			get
			{
				return httpPutResponseHopLimit;
			}
			set	
			{
				httpPutResponseHopLimit = value;
				DictionaryUtil.Add(QueryParameters, "HttpPutResponseHopLimit", value.ToString());
			}
		}

		public string KeyPairName
		{
			get
			{
				return keyPairName;
			}
			set	
			{
				keyPairName = value;
				DictionaryUtil.Add(QueryParameters, "KeyPairName", value);
			}
		}

		public float? SpotPriceLimit
		{
			get
			{
				return spotPriceLimit;
			}
			set	
			{
				spotPriceLimit = value;
				DictionaryUtil.Add(QueryParameters, "SpotPriceLimit", value.ToString());
			}
		}

		public int? StorageSetPartitionNumber
		{
			get
			{
				return storageSetPartitionNumber;
			}
			set	
			{
				storageSetPartitionNumber = value;
				DictionaryUtil.Add(QueryParameters, "StorageSetPartitionNumber", value.ToString());
			}
		}

		public List<Tag> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				for (int i = 0; i < tags.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Key", tags[i].Key);
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Value", tags[i].Value);
				}
			}
		}

		public string PrivatePoolOptionsId
		{
			get
			{
				return privatePoolOptionsId;
			}
			set	
			{
				privatePoolOptionsId = value;
				DictionaryUtil.Add(QueryParameters, "PrivatePoolOptions.Id", value);
			}
		}

		public int? AutoRenewPeriod
		{
			get
			{
				return autoRenewPeriod;
			}
			set	
			{
				autoRenewPeriod = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenewPeriod", value.ToString());
			}
		}

		public string LaunchTemplateId
		{
			get
			{
				return launchTemplateId;
			}
			set	
			{
				launchTemplateId = value;
				DictionaryUtil.Add(QueryParameters, "LaunchTemplateId", value);
			}
		}

		public int? Ipv6AddressCount
		{
			get
			{
				return ipv6AddressCount;
			}
			set	
			{
				ipv6AddressCount = value;
				DictionaryUtil.Add(QueryParameters, "Ipv6AddressCount", value.ToString());
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
			}
		}

		public string InstanceName
		{
			get
			{
				return instanceName;
			}
			set	
			{
				instanceName = value;
				DictionaryUtil.Add(QueryParameters, "InstanceName", value);
			}
		}

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public List<string> Ipv6Addresss
		{
			get
			{
				return ipv6Addresss;
			}

			set
			{
				ipv6Addresss = value;
				for (int i = 0; i < ipv6Addresss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Ipv6Address." + (i + 1) , ipv6Addresss[i]);
				}
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public int? InternetMaxBandwidthOut
		{
			get
			{
				return internetMaxBandwidthOut;
			}
			set	
			{
				internetMaxBandwidthOut = value;
				DictionaryUtil.Add(QueryParameters, "InternetMaxBandwidthOut", value.ToString());
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public int? CpuOptionsThreadsPerCore
		{
			get
			{
				return cpuOptionsThreadsPerCore;
			}
			set	
			{
				cpuOptionsThreadsPerCore = value;
				DictionaryUtil.Add(QueryParameters, "CpuOptions.ThreadsPerCore", value.ToString());
			}
		}

		public string SystemDiskCategory
		{
			get
			{
				return systemDiskCategory;
			}
			set	
			{
				systemDiskCategory = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Category", value);
			}
		}

		public string UserData
		{
			get
			{
				return userData;
			}
			set	
			{
				userData = value;
				DictionaryUtil.Add(QueryParameters, "UserData", value);
			}
		}

		public string HttpEndpoint
		{
			get
			{
				return httpEndpoint;
			}
			set	
			{
				httpEndpoint = value;
				DictionaryUtil.Add(QueryParameters, "HttpEndpoint", value);
			}
		}

		public string InstanceChargeType
		{
			get
			{
				return instanceChargeType;
			}
			set	
			{
				instanceChargeType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceChargeType", value);
			}
		}

		public List<NetworkInterface> NetworkInterfaces
		{
			get
			{
				return networkInterfaces;
			}

			set
			{
				networkInterfaces = value;
				for (int i = 0; i < networkInterfaces.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (i + 1) + ".PrimaryIpAddress", networkInterfaces[i].PrimaryIpAddress);
					DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (i + 1) + ".VSwitchId", networkInterfaces[i].VSwitchId);
					DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (i + 1) + ".SecurityGroupId", networkInterfaces[i].SecurityGroupId);
					for (int j = 0; j < networkInterfaces[i].SecurityGroupIdss.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (i + 1) + ".SecurityGroupIds." +(j + 1), networkInterfaces[i].SecurityGroupIdss[j]);
					}
					DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (i + 1) + ".NetworkInterfaceName", networkInterfaces[i].NetworkInterfaceName);
					DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (i + 1) + ".Description", networkInterfaces[i].Description);
					DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (i + 1) + ".QueueNumber", networkInterfaces[i].QueueNumber);
				}
			}
		}

		public string DeploymentSetId
		{
			get
			{
				return deploymentSetId;
			}
			set	
			{
				deploymentSetId = value;
				DictionaryUtil.Add(QueryParameters, "DeploymentSetId", value);
			}
		}

		public int? Amount
		{
			get
			{
				return amount;
			}
			set	
			{
				amount = value;
				DictionaryUtil.Add(QueryParameters, "Amount", value.ToString());
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string Tenancy
		{
			get
			{
				return tenancy;
			}
			set	
			{
				tenancy = value;
				DictionaryUtil.Add(QueryParameters, "Tenancy", value);
			}
		}

		public string RamRoleName
		{
			get
			{
				return ramRoleName;
			}
			set	
			{
				ramRoleName = value;
				DictionaryUtil.Add(QueryParameters, "RamRoleName", value);
			}
		}

		public string AutoReleaseTime
		{
			get
			{
				return autoReleaseTime;
			}
			set	
			{
				autoReleaseTime = value;
				DictionaryUtil.Add(QueryParameters, "AutoReleaseTime", value);
			}
		}

		public string CreditSpecification
		{
			get
			{
				return creditSpecification;
			}
			set	
			{
				creditSpecification = value;
				DictionaryUtil.Add(QueryParameters, "CreditSpecification", value);
			}
		}

		public List<DataDisk> DataDisks
		{
			get
			{
				return dataDisks;
			}

			set
			{
				dataDisks = value;
				for (int i = 0; i < dataDisks.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Size", dataDisks[i].Size);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".SnapshotId", dataDisks[i].SnapshotId);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Category", dataDisks[i].Category);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Encrypted", dataDisks[i].Encrypted);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".KMSKeyId", dataDisks[i].KMSKeyId);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".DiskName", dataDisks[i].DiskName);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Description", dataDisks[i].Description);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Device", dataDisks[i].Device);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".DeleteWithInstance", dataDisks[i].DeleteWithInstance);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".PerformanceLevel", dataDisks[i].PerformanceLevel);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".AutoSnapshotPolicyId", dataDisks[i].AutoSnapshotPolicyId);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".EncryptAlgorithm", dataDisks[i].EncryptAlgorithm);
				}
			}
		}

		public long? LaunchTemplateVersion
		{
			get
			{
				return launchTemplateVersion;
			}
			set	
			{
				launchTemplateVersion = value;
				DictionaryUtil.Add(QueryParameters, "LaunchTemplateVersion", value.ToString());
			}
		}

		public string StorageSetId
		{
			get
			{
				return storageSetId;
			}
			set	
			{
				storageSetId = value;
				DictionaryUtil.Add(QueryParameters, "StorageSetId", value);
			}
		}

		public string HttpTokens
		{
			get
			{
				return httpTokens;
			}
			set	
			{
				httpTokens = value;
				DictionaryUtil.Add(QueryParameters, "HttpTokens", value);
			}
		}

		public string SystemDiskDescription
		{
			get
			{
				return systemDiskDescription;
			}
			set	
			{
				systemDiskDescription = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Description", value);
			}
		}

		public class Arn
		{

			private long? assumeRoleFor;

			private string rolearn;

			private string roleType;

			public long? AssumeRoleFor
			{
				get
				{
					return assumeRoleFor;
				}
				set	
				{
					assumeRoleFor = value;
				}
			}

			public string Rolearn
			{
				get
				{
					return rolearn;
				}
				set	
				{
					rolearn = value;
				}
			}

			public string RoleType
			{
				get
				{
					return roleType;
				}
				set	
				{
					roleType = value;
				}
			}
		}

		public class Tag
		{

			private string key;

			private string value_;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}
		}

		public class NetworkInterface
		{

			private string primaryIpAddress;

			private string vSwitchId;

			private string securityGroupId;

			private List<string> securityGroupIdss = new List<string>(){ };

			private string networkInterfaceName;

			private string description;

			private int? queueNumber;

			public string PrimaryIpAddress
			{
				get
				{
					return primaryIpAddress;
				}
				set	
				{
					primaryIpAddress = value;
				}
			}

			public string VSwitchId
			{
				get
				{
					return vSwitchId;
				}
				set	
				{
					vSwitchId = value;
				}
			}

			public string SecurityGroupId
			{
				get
				{
					return securityGroupId;
				}
				set	
				{
					securityGroupId = value;
				}
			}

			public List<string> SecurityGroupIdss
			{
				get
				{
					return securityGroupIdss;
				}
				set	
				{
					securityGroupIdss = value;
				}
			}

			public string NetworkInterfaceName
			{
				get
				{
					return networkInterfaceName;
				}
				set	
				{
					networkInterfaceName = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public int? QueueNumber
			{
				get
				{
					return queueNumber;
				}
				set	
				{
					queueNumber = value;
				}
			}
		}

		public class DataDisk
		{

			private int? size;

			private string snapshotId;

			private string category;

			private string encrypted;

			private string kMSKeyId;

			private string diskName;

			private string description;

			private string device;

			private bool? deleteWithInstance;

			private string performanceLevel;

			private string autoSnapshotPolicyId;

			private string encryptAlgorithm;

			public int? Size
			{
				get
				{
					return size;
				}
				set	
				{
					size = value;
				}
			}

			public string SnapshotId
			{
				get
				{
					return snapshotId;
				}
				set	
				{
					snapshotId = value;
				}
			}

			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			public string Encrypted
			{
				get
				{
					return encrypted;
				}
				set	
				{
					encrypted = value;
				}
			}

			public string KMSKeyId
			{
				get
				{
					return kMSKeyId;
				}
				set	
				{
					kMSKeyId = value;
				}
			}

			public string DiskName
			{
				get
				{
					return diskName;
				}
				set	
				{
					diskName = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string Device
			{
				get
				{
					return device;
				}
				set	
				{
					device = value;
				}
			}

			public bool? DeleteWithInstance
			{
				get
				{
					return deleteWithInstance;
				}
				set	
				{
					deleteWithInstance = value;
				}
			}

			public string PerformanceLevel
			{
				get
				{
					return performanceLevel;
				}
				set	
				{
					performanceLevel = value;
				}
			}

			public string AutoSnapshotPolicyId
			{
				get
				{
					return autoSnapshotPolicyId;
				}
				set	
				{
					autoSnapshotPolicyId = value;
				}
			}

			public string EncryptAlgorithm
			{
				get
				{
					return encryptAlgorithm;
				}
				set	
				{
					encryptAlgorithm = value;
				}
			}
		}

        public override RunInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RunInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
