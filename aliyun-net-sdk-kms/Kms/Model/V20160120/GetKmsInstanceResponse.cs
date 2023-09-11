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

namespace Aliyun.Acs.Kms.Model.V20160120
{
	public class GetKmsInstanceResponse : AcsResponse
	{

		private string requestId;

		private GetKmsInstance_KmsInstance kmsInstance;

		[JsonProperty(PropertyName = "RequestId")]
		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		[JsonProperty(PropertyName = "KmsInstance")]
		public GetKmsInstance_KmsInstance KmsInstance
		{
			get
			{
				return kmsInstance;
			}
			set	
			{
				kmsInstance = value;
			}
		}

		public class GetKmsInstance_KmsInstance
		{

			private string instanceId;

			private string instanceName;

			private string status;

			private string createTime;

			private long? spec;

			private long? keyNum;

			private string secretNum;

			private long? vpcNum;

			private string vpcId;

			private string zoneIds;

			private string vswitchIds;

			private string endDate;

			private string startDate;

			private string caCertificateChainPem;

			private List<GetKmsInstance_BindVpc> bindVpcs;

			[JsonProperty(PropertyName = "InstanceId")]
			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
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
				}
			}

			[JsonProperty(PropertyName = "Status")]
			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			[JsonProperty(PropertyName = "CreateTime")]
			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			[JsonProperty(PropertyName = "Spec")]
			public long? Spec
			{
				get
				{
					return spec;
				}
				set	
				{
					spec = value;
				}
			}

			[JsonProperty(PropertyName = "KeyNum")]
			public long? KeyNum
			{
				get
				{
					return keyNum;
				}
				set	
				{
					keyNum = value;
				}
			}

			[JsonProperty(PropertyName = "SecretNum")]
			public string SecretNum
			{
				get
				{
					return secretNum;
				}
				set	
				{
					secretNum = value;
				}
			}

			[JsonProperty(PropertyName = "VpcNum")]
			public long? VpcNum
			{
				get
				{
					return vpcNum;
				}
				set	
				{
					vpcNum = value;
				}
			}

			[JsonProperty(PropertyName = "VpcId")]
			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			[JsonProperty(PropertyName = "ZoneIds")]
			public string ZoneIds
			{
				get
				{
					return zoneIds;
				}
				set	
				{
					zoneIds = value;
				}
			}

			[JsonProperty(PropertyName = "VswitchIds")]
			public string VswitchIds
			{
				get
				{
					return vswitchIds;
				}
				set	
				{
					vswitchIds = value;
				}
			}

			[JsonProperty(PropertyName = "EndDate")]
			public string EndDate
			{
				get
				{
					return endDate;
				}
				set	
				{
					endDate = value;
				}
			}

			[JsonProperty(PropertyName = "StartDate")]
			public string StartDate
			{
				get
				{
					return startDate;
				}
				set	
				{
					startDate = value;
				}
			}

			[JsonProperty(PropertyName = "CaCertificateChainPem")]
			public string CaCertificateChainPem
			{
				get
				{
					return caCertificateChainPem;
				}
				set	
				{
					caCertificateChainPem = value;
				}
			}

			[JsonProperty(PropertyName = "BindVpcs")]
			public List<GetKmsInstance_BindVpc> BindVpcs
			{
				get
				{
					return bindVpcs;
				}
				set	
				{
					bindVpcs = value;
				}
			}

			public class GetKmsInstance_BindVpc
			{

				private string regionId;

				private string vpcId;

				private string vpcOwnerId;

				private string vSwitchId;

				[JsonProperty(PropertyName = "RegionId")]
				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}

				[JsonProperty(PropertyName = "VpcId")]
				public string VpcId
				{
					get
					{
						return vpcId;
					}
					set	
					{
						vpcId = value;
					}
				}

				[JsonProperty(PropertyName = "VpcOwnerId")]
				public string VpcOwnerId
				{
					get
					{
						return vpcOwnerId;
					}
					set	
					{
						vpcOwnerId = value;
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
					}
				}
			}
		}
	}
}
