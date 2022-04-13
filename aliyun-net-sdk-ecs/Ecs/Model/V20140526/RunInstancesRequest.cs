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
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
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

		private SystemDisk systemDisk_;

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

		private bool? hibernationOptionsConfigured;

		private string systemDiskPerformanceLevel;

		private bool? passwordInherit;

		private string instanceType;

		private List<string> arns = new List<string>(){ };

		private string resourceOwnerAccount;

		private string schedulerOptionsDedicatedHostClusterId;

		private string systemDiskDiskName;

		private string dedicatedHostId;

		private int? spotDuration;

		private List<string> securityGroupIdss = new List<string>(){ };

		private string systemDiskSize;

		private string imageFamily;

		private string launchTemplateName;

		private long? resourceOwnerId;

		private string hpcClusterId;

		private int? httpPutResponseHopLimit;

		private string isp;

		private string keyPairName;

		private float? spotPriceLimit;

		private int? storageSetPartitionNumber;

		private List<string> tags = new List<string>(){ };

		private string privatePoolOptionsId;

		private int? autoRenewPeriod;

		private string launchTemplateId;

		private int? ipv6AddressCount;

		private List<string> hostNamess = new List<string>(){ };

		private string vSwitchId;

		private string instanceName;

		private string zoneId;

		private List<string> ipv6Addresss = new List<string>(){ };

		private string securityOptionsConfidentialComputingMode;

		private string clientToken;

		private int? internetMaxBandwidthOut;

		private string description;

		private int? cpuOptionsThreadsPerCore;

		private string systemDiskCategory;

		private string securityOptionsTrustedSystemMode;

		private string userData;

		private string httpEndpoint;

		private string instanceChargeType;

		private string deploymentSetId;

		private List<string> networkInterfaces = new List<string>(){ };

		private int? amount;

		private string ownerAccount;

		private string tenancy;

		private string ramRoleName;

		private string autoReleaseTime;

		private string creditSpecification;

		private long? launchTemplateVersion;

		private List<string> dataDisks = new List<string>(){ };

		private string storageSetId;

		private string httpTokens;

		private string systemDiskDescription;

		[JsonProperty(PropertyName = "UniqueSuffix")]
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

		[JsonProperty(PropertyName = "SecurityEnhancementStrategy")]
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

		[JsonProperty(PropertyName = "MinAmount")]
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

		[JsonProperty(PropertyName = "DeletionProtection")]
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

		[JsonProperty(PropertyName = "ResourceGroupId")]
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

		[JsonProperty(PropertyName = "PrivatePoolOptions.MatchCriteria")]
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

		[JsonProperty(PropertyName = "HostName")]
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

		[JsonProperty(PropertyName = "Password")]
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

		[JsonProperty(PropertyName = "SystemDisk")]
		public SystemDisk SystemDisk_
		{
			get
			{
				return systemDisk_;
			}

			set
			{
				systemDisk_ = value;
				if(SystemDisk_ != null)
				{

					DictionaryUtil.Add(QueryParameters,"SystemDisk.StorageClusterId", SystemDisk_.StorageClusterId);
					DictionaryUtil.Add(QueryParameters,"SystemDisk.ProvisionedIops", SystemDisk_.ProvisionedIops);
					DictionaryUtil.Add(QueryParameters,"SystemDisk.BurstingEnabled", SystemDisk_.BurstingEnabled);
					DictionaryUtil.Add(QueryParameters,"SystemDisk.Encrypted", SystemDisk_.Encrypted);
					DictionaryUtil.Add(QueryParameters,"SystemDisk.KMSKeyId", SystemDisk_.KMSKeyId);
					DictionaryUtil.Add(QueryParameters,"SystemDisk.EncryptAlgorithm", SystemDisk_.EncryptAlgorithm);
				}
			}
		}

		[JsonProperty(PropertyName = "DeploymentSetGroupNo")]
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

		[JsonProperty(PropertyName = "SystemDisk.AutoSnapshotPolicyId")]
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

		[JsonProperty(PropertyName = "CpuOptions.Core")]
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

		[JsonProperty(PropertyName = "Period")]
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

		[JsonProperty(PropertyName = "DryRun")]
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

		[JsonProperty(PropertyName = "CpuOptions.Numa")]
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

		[JsonProperty(PropertyName = "OwnerId")]
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

		[JsonProperty(PropertyName = "SpotStrategy")]
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

		[JsonProperty(PropertyName = "PrivateIpAddress")]
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

		[JsonProperty(PropertyName = "PeriodUnit")]
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

		[JsonProperty(PropertyName = "AutoRenew")]
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

		[JsonProperty(PropertyName = "InternetChargeType")]
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

		[JsonProperty(PropertyName = "InternetMaxBandwidthIn")]
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

		[JsonProperty(PropertyName = "Affinity")]
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

		[JsonProperty(PropertyName = "ImageId")]
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

		[JsonProperty(PropertyName = "SpotInterruptionBehavior")]
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

		[JsonProperty(PropertyName = "NetworkInterfaceQueueNumber")]
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

		[JsonProperty(PropertyName = "IoOptimized")]
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

		[JsonProperty(PropertyName = "SecurityGroupId")]
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

		[JsonProperty(PropertyName = "HibernationOptions.Configured")]
		public bool? HibernationOptionsConfigured
		{
			get
			{
				return hibernationOptionsConfigured;
			}
			set	
			{
				hibernationOptionsConfigured = value;
				DictionaryUtil.Add(QueryParameters, "HibernationOptions.Configured", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "SystemDisk.PerformanceLevel")]
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

		[JsonProperty(PropertyName = "PasswordInherit")]
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

		[JsonProperty(PropertyName = "InstanceType")]
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

		[JsonProperty(PropertyName = "Arn")]
		public List<string> Arns
		{
			get
			{
				return arns;
			}

			set
			{
				arns = value;
				if(arns != null)
				{
					for (int depth1 = 0; depth1 < arns.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Arn." + (depth1 + 1), arns[depth1]);
						DictionaryUtil.Add(QueryParameters,"Arn." + (depth1 + 1), arns[depth1]);
						DictionaryUtil.Add(QueryParameters,"Arn." + (depth1 + 1), arns[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerAccount")]
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

		[JsonProperty(PropertyName = "SchedulerOptions.DedicatedHostClusterId")]
		public string SchedulerOptionsDedicatedHostClusterId
		{
			get
			{
				return schedulerOptionsDedicatedHostClusterId;
			}
			set	
			{
				schedulerOptionsDedicatedHostClusterId = value;
				DictionaryUtil.Add(QueryParameters, "SchedulerOptions.DedicatedHostClusterId", value);
			}
		}

		[JsonProperty(PropertyName = "SystemDisk.DiskName")]
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

		[JsonProperty(PropertyName = "DedicatedHostId")]
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

		[JsonProperty(PropertyName = "SpotDuration")]
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

		[JsonProperty(PropertyName = "SecurityGroupIds")]
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

		[JsonProperty(PropertyName = "SystemDisk.Size")]
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

		[JsonProperty(PropertyName = "ImageFamily")]
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

		[JsonProperty(PropertyName = "LaunchTemplateName")]
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

		[JsonProperty(PropertyName = "ResourceOwnerId")]
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

		[JsonProperty(PropertyName = "HpcClusterId")]
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

		[JsonProperty(PropertyName = "HttpPutResponseHopLimit")]
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

		[JsonProperty(PropertyName = "Isp")]
		public string Isp
		{
			get
			{
				return isp;
			}
			set	
			{
				isp = value;
				DictionaryUtil.Add(QueryParameters, "Isp", value);
			}
		}

		[JsonProperty(PropertyName = "KeyPairName")]
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

		[JsonProperty(PropertyName = "SpotPriceLimit")]
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

		[JsonProperty(PropertyName = "StorageSetPartitionNumber")]
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

		[JsonProperty(PropertyName = "Tag")]
		public List<string> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				if(tags != null)
				{
					for (int depth1 = 0; depth1 < tags.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "PrivatePoolOptions.Id")]
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

		[JsonProperty(PropertyName = "AutoRenewPeriod")]
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

		[JsonProperty(PropertyName = "LaunchTemplateId")]
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

		[JsonProperty(PropertyName = "Ipv6AddressCount")]
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

		[JsonProperty(PropertyName = "HostNames")]
		public List<string> HostNamess
		{
			get
			{
				return hostNamess;
			}

			set
			{
				hostNamess = value;
			}
		}

		[JsonProperty(PropertyName = "VSwitchId")]
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

		[JsonProperty(PropertyName = "InstanceName")]
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

		[JsonProperty(PropertyName = "ZoneId")]
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

		[JsonProperty(PropertyName = "Ipv6Address")]
		public List<string> Ipv6Addresss
		{
			get
			{
				return ipv6Addresss;
			}

			set
			{
				ipv6Addresss = value;
			}
		}

		[JsonProperty(PropertyName = "SecurityOptions.ConfidentialComputingMode")]
		public string SecurityOptionsConfidentialComputingMode
		{
			get
			{
				return securityOptionsConfidentialComputingMode;
			}
			set	
			{
				securityOptionsConfidentialComputingMode = value;
				DictionaryUtil.Add(QueryParameters, "SecurityOptions.ConfidentialComputingMode", value);
			}
		}

		[JsonProperty(PropertyName = "ClientToken")]
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

		[JsonProperty(PropertyName = "InternetMaxBandwidthOut")]
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

		[JsonProperty(PropertyName = "Description")]
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

		[JsonProperty(PropertyName = "CpuOptions.ThreadsPerCore")]
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

		[JsonProperty(PropertyName = "SystemDisk.Category")]
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

		[JsonProperty(PropertyName = "SecurityOptions.TrustedSystemMode")]
		public string SecurityOptionsTrustedSystemMode
		{
			get
			{
				return securityOptionsTrustedSystemMode;
			}
			set	
			{
				securityOptionsTrustedSystemMode = value;
				DictionaryUtil.Add(QueryParameters, "SecurityOptions.TrustedSystemMode", value);
			}
		}

		[JsonProperty(PropertyName = "UserData")]
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

		[JsonProperty(PropertyName = "HttpEndpoint")]
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

		[JsonProperty(PropertyName = "InstanceChargeType")]
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

		[JsonProperty(PropertyName = "DeploymentSetId")]
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

		[JsonProperty(PropertyName = "NetworkInterface")]
		public List<string> NetworkInterfaces
		{
			get
			{
				return networkInterfaces;
			}

			set
			{
				networkInterfaces = value;
				if(networkInterfaces != null)
				{
					for (int depth1 = 0; depth1 < networkInterfaces.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (depth1 + 1), networkInterfaces[depth1]);
						DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (depth1 + 1), networkInterfaces[depth1]);
						DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (depth1 + 1), networkInterfaces[depth1]);
						DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (depth1 + 1), networkInterfaces[depth1]);
						DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (depth1 + 1), networkInterfaces[depth1]);
						DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (depth1 + 1), networkInterfaces[depth1]);
						DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (depth1 + 1), networkInterfaces[depth1]);
						DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (depth1 + 1), networkInterfaces[depth1]);
						DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (depth1 + 1), networkInterfaces[depth1]);
						DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (depth1 + 1), networkInterfaces[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "Amount")]
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

		[JsonProperty(PropertyName = "OwnerAccount")]
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

		[JsonProperty(PropertyName = "Tenancy")]
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

		[JsonProperty(PropertyName = "RamRoleName")]
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

		[JsonProperty(PropertyName = "AutoReleaseTime")]
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

		[JsonProperty(PropertyName = "CreditSpecification")]
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

		[JsonProperty(PropertyName = "LaunchTemplateVersion")]
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

		[JsonProperty(PropertyName = "DataDisk")]
		public List<string> DataDisks
		{
			get
			{
				return dataDisks;
			}

			set
			{
				dataDisks = value;
				if(dataDisks != null)
				{
					for (int depth1 = 0; depth1 < dataDisks.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "StorageSetId")]
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

		[JsonProperty(PropertyName = "HttpTokens")]
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

		[JsonProperty(PropertyName = "SystemDisk.Description")]
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

		public class SystemDisk
		{

			private string storageClusterId;

			private long? provisionedIops;

			private bool? burstingEnabled;

			private string encrypted;

			private string kMSKeyId;

			private string encryptAlgorithm;

			[JsonProperty(PropertyName = "StorageClusterId")]
			public string StorageClusterId
			{
				get
				{
					return storageClusterId;
				}
				set	
				{
					storageClusterId = value;
				}
			}

			[JsonProperty(PropertyName = "ProvisionedIops")]
			public long? ProvisionedIops
			{
				get
				{
					return provisionedIops;
				}
				set	
				{
					provisionedIops = value;
				}
			}

			[JsonProperty(PropertyName = "BurstingEnabled")]
			public bool? BurstingEnabled
			{
				get
				{
					return burstingEnabled;
				}
				set	
				{
					burstingEnabled = value;
				}
			}

			[JsonProperty(PropertyName = "Encrypted")]
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

			[JsonProperty(PropertyName = "KMSKeyId")]
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

			[JsonProperty(PropertyName = "EncryptAlgorithm")]
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

		public class Arn
		{

			private string roleType;

			private string rolearn;

			private long? assumeRoleFor;

			[JsonProperty(PropertyName = "RoleType")]
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

			[JsonProperty(PropertyName = "Rolearn")]
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

			[JsonProperty(PropertyName = "AssumeRoleFor")]
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
		}

		public class Tag
		{

			private string key;

			private string value_;

			[JsonProperty(PropertyName = "Key")]
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

			[JsonProperty(PropertyName = "Value")]
			public string Value_
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

			private string vSwitchId;

			private string networkInterfaceName;

			private string description;

			private string securityGroupId;

			private string primaryIpAddress;

			private int? queueNumber;

			private List<string> securityGroupIdss = new List<string>(){ };

			private string networkInterfaceTrafficMode;

			private long? queuePairNumber;

			private string instanceType;

			private long? ipv6AddressCount;

			private List<string> ipv6Addresss = new List<string>(){ };

			[JsonProperty(PropertyName = "VSwitchId")]
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

			[JsonProperty(PropertyName = "NetworkInterfaceName")]
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

			[JsonProperty(PropertyName = "Description")]
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

			[JsonProperty(PropertyName = "SecurityGroupId")]
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

			[JsonProperty(PropertyName = "PrimaryIpAddress")]
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

			[JsonProperty(PropertyName = "QueueNumber")]
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

			[JsonProperty(PropertyName = "SecurityGroupIds")]
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

			[JsonProperty(PropertyName = "NetworkInterfaceTrafficMode")]
			public string NetworkInterfaceTrafficMode
			{
				get
				{
					return networkInterfaceTrafficMode;
				}
				set	
				{
					networkInterfaceTrafficMode = value;
				}
			}

			[JsonProperty(PropertyName = "QueuePairNumber")]
			public long? QueuePairNumber
			{
				get
				{
					return queuePairNumber;
				}
				set	
				{
					queuePairNumber = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceType")]
			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			[JsonProperty(PropertyName = "Ipv6AddressCount")]
			public long? Ipv6AddressCount
			{
				get
				{
					return ipv6AddressCount;
				}
				set	
				{
					ipv6AddressCount = value;
				}
			}

			[JsonProperty(PropertyName = "Ipv6Address")]
			public List<string> Ipv6Addresss
			{
				get
				{
					return ipv6Addresss;
				}
				set	
				{
					ipv6Addresss = value;
				}
			}
		}

		public class DataDisk
		{

			private string performanceLevel;

			private string autoSnapshotPolicyId;

			private string encrypted;

			private string description;

			private string snapshotId;

			private string device;

			private int? size;

			private string diskName;

			private string category;

			private string encryptAlgorithm;

			private bool? deleteWithInstance;

			private string kMSKeyId;

			private string storageClusterId;

			private long? provisionedIops;

			private bool? burstingEnabled;

			[JsonProperty(PropertyName = "PerformanceLevel")]
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

			[JsonProperty(PropertyName = "AutoSnapshotPolicyId")]
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

			[JsonProperty(PropertyName = "Encrypted")]
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

			[JsonProperty(PropertyName = "Description")]
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

			[JsonProperty(PropertyName = "SnapshotId")]
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

			[JsonProperty(PropertyName = "Device")]
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

			[JsonProperty(PropertyName = "Size")]
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

			[JsonProperty(PropertyName = "DiskName")]
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

			[JsonProperty(PropertyName = "Category")]
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

			[JsonProperty(PropertyName = "EncryptAlgorithm")]
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

			[JsonProperty(PropertyName = "DeleteWithInstance")]
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

			[JsonProperty(PropertyName = "KMSKeyId")]
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

			[JsonProperty(PropertyName = "StorageClusterId")]
			public string StorageClusterId
			{
				get
				{
					return storageClusterId;
				}
				set	
				{
					storageClusterId = value;
				}
			}

			[JsonProperty(PropertyName = "ProvisionedIops")]
			public long? ProvisionedIops
			{
				get
				{
					return provisionedIops;
				}
				set	
				{
					provisionedIops = value;
				}
			}

			[JsonProperty(PropertyName = "BurstingEnabled")]
			public bool? BurstingEnabled
			{
				get
				{
					return burstingEnabled;
				}
				set	
				{
					burstingEnabled = value;
				}
			}
		}

        public override RunInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RunInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
