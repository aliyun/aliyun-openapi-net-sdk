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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.smc.Transform;
using Aliyun.Acs.smc.Transform.V20190601;

namespace Aliyun.Acs.smc.Model.V20190601
{
    public class CreateReplicationJobRequest : RpcAcsRequest<CreateReplicationJobResponse>
    {
        public CreateReplicationJobRequest()
            : base("smc", "2019-06-01", "CreateReplicationJob", "smc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.smc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.smc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? frequency;

		private string replicationParameters;

		private int? systemDiskSize;

		private List<Tag> tags = new List<Tag>(){ };

		private int? netMode;

		private string licenseType;

		private string containerNamespace;

		private string launchTemplateId;

		private string validTime;

		private long? ownerId;

		private string vSwitchId;

		private string scheduledStartTime;

		private string instanceId;

		private string instanceRamRole;

		private string name;

		private int? maxNumberOfImageToKeep;

		private string targetType;

		private string clientToken;

		private string description;

		private string imageName;

		private string instanceType;

		private string containerRepository;

		private string containerTag;

		private string sourceId;

		private bool? runOnce;

		private string resourceOwnerAccount;

		private List<SystemDiskPart> systemDiskParts = new List<SystemDiskPart>(){ };

		private List<DataDisk> dataDisks = new List<DataDisk>(){ };

		private string launchTemplateVersion;

		private string vpcId;

		public int? Frequency
		{
			get
			{
				return frequency;
			}
			set	
			{
				frequency = value;
				DictionaryUtil.Add(QueryParameters, "Frequency", value.ToString());
			}
		}

		public string ReplicationParameters
		{
			get
			{
				return replicationParameters;
			}
			set	
			{
				replicationParameters = value;
				DictionaryUtil.Add(QueryParameters, "ReplicationParameters", value);
			}
		}

		public int? SystemDiskSize
		{
			get
			{
				return systemDiskSize;
			}
			set	
			{
				systemDiskSize = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskSize", value.ToString());
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
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Value", tags[i].Value);
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Key", tags[i].Key);
				}
			}
		}

		public int? NetMode
		{
			get
			{
				return netMode;
			}
			set	
			{
				netMode = value;
				DictionaryUtil.Add(QueryParameters, "NetMode", value.ToString());
			}
		}

		public string LicenseType
		{
			get
			{
				return licenseType;
			}
			set	
			{
				licenseType = value;
				DictionaryUtil.Add(QueryParameters, "LicenseType", value);
			}
		}

		public string ContainerNamespace
		{
			get
			{
				return containerNamespace;
			}
			set	
			{
				containerNamespace = value;
				DictionaryUtil.Add(QueryParameters, "ContainerNamespace", value);
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

		public string ValidTime
		{
			get
			{
				return validTime;
			}
			set	
			{
				validTime = value;
				DictionaryUtil.Add(QueryParameters, "ValidTime", value);
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

		public string ScheduledStartTime
		{
			get
			{
				return scheduledStartTime;
			}
			set	
			{
				scheduledStartTime = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledStartTime", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string InstanceRamRole
		{
			get
			{
				return instanceRamRole;
			}
			set	
			{
				instanceRamRole = value;
				DictionaryUtil.Add(QueryParameters, "InstanceRamRole", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public int? MaxNumberOfImageToKeep
		{
			get
			{
				return maxNumberOfImageToKeep;
			}
			set	
			{
				maxNumberOfImageToKeep = value;
				DictionaryUtil.Add(QueryParameters, "MaxNumberOfImageToKeep", value.ToString());
			}
		}

		public string TargetType
		{
			get
			{
				return targetType;
			}
			set	
			{
				targetType = value;
				DictionaryUtil.Add(QueryParameters, "TargetType", value);
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

		public string ImageName
		{
			get
			{
				return imageName;
			}
			set	
			{
				imageName = value;
				DictionaryUtil.Add(QueryParameters, "ImageName", value);
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

		public string ContainerRepository
		{
			get
			{
				return containerRepository;
			}
			set	
			{
				containerRepository = value;
				DictionaryUtil.Add(QueryParameters, "ContainerRepository", value);
			}
		}

		public string ContainerTag
		{
			get
			{
				return containerTag;
			}
			set	
			{
				containerTag = value;
				DictionaryUtil.Add(QueryParameters, "ContainerTag", value);
			}
		}

		public string SourceId
		{
			get
			{
				return sourceId;
			}
			set	
			{
				sourceId = value;
				DictionaryUtil.Add(QueryParameters, "SourceId", value);
			}
		}

		public bool? RunOnce
		{
			get
			{
				return runOnce;
			}
			set	
			{
				runOnce = value;
				DictionaryUtil.Add(QueryParameters, "RunOnce", value.ToString());
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

		public List<SystemDiskPart> SystemDiskParts
		{
			get
			{
				return systemDiskParts;
			}

			set
			{
				systemDiskParts = value;
				for (int i = 0; i < systemDiskParts.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SystemDiskPart." + (i + 1) + ".SizeBytes", systemDiskParts[i].SizeBytes);
					DictionaryUtil.Add(QueryParameters,"SystemDiskPart." + (i + 1) + ".Block", systemDiskParts[i].Block);
					DictionaryUtil.Add(QueryParameters,"SystemDiskPart." + (i + 1) + ".Device", systemDiskParts[i].Device);
				}
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
					for (int j = 0; j < dataDisks[i].Parts.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Part." +(j + 1), dataDisks[i].Parts[j]);
					}
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Index", dataDisks[i].Index);
				}
			}
		}

		public string LaunchTemplateVersion
		{
			get
			{
				return launchTemplateVersion;
			}
			set	
			{
				launchTemplateVersion = value;
				DictionaryUtil.Add(QueryParameters, "LaunchTemplateVersion", value);
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
			}
		}

		public class Tag
		{

			private string value_;

			private string key;

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
		}

		public class SystemDiskPart
		{

			private long? sizeBytes;

			private bool? block;

			private string device;

			public long? SizeBytes
			{
				get
				{
					return sizeBytes;
				}
				set	
				{
					sizeBytes = value;
				}
			}

			public bool? Block
			{
				get
				{
					return block;
				}
				set	
				{
					block = value;
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
		}

		public class DataDisk
		{

			private int? size;

			private List<Part> parts = new List<Part>(){ };

			private int? index;

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

			public List<Part> Parts
			{
				get
				{
					return parts;
				}
				set	
				{
					parts = value;
				}
			}

			public int? Index
			{
				get
				{
					return index;
				}
				set	
				{
					index = value;
				}
			}

			public class Part
			{

				private long? sizeBytes;

				private bool? block;

				private string device;

				public long? SizeBytes
				{
					get
					{
						return sizeBytes;
					}
					set	
					{
						sizeBytes = value;
					}
				}

				public bool? Block
				{
					get
					{
						return block;
					}
					set	
					{
						block = value;
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
			}
		}

        public override CreateReplicationJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateReplicationJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
