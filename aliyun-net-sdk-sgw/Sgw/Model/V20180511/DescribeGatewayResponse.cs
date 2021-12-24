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

namespace Aliyun.Acs.sgw.Model.V20180511
{
	public class DescribeGatewayResponse : AcsResponse
	{

		private string description;

		private long? createdTime;

		private int? publicNetworkBandwidth;

		private string dataLoadType;

		private string category;

		private string taskId;

		private string message;

		private int? expireStatus;

		private string ip;

		private string gatewayType;

		private string storageBundleId;

		private string gatewayClass;

		private bool? success;

		private string name;

		private bool? isPostPaid;

		private int? capacity;

		private long? expiredTime;

		private string gatewayVersion;

		private bool? isReleaseAfterExpiration;

		private string status;

		private string buyURL;

		private int? maxThroughput;

		private int? dataLoadInterval;

		private string innerIp;

		private string requestId;

		private string vSwitchId;

		private string gatewayId;

		private string code;

		private string ecsInstanceId;

		private string type;

		private string renewURL;

		private string vpcId;

		private string serialNumber;

		private long? activatedTime;

		private bool? elasticGateway;

		private string commonBuyInstanceId;

		private string innerIpv6Ip;

		private string model;

		private string lastErrorKey;

		private string location;

		private List<string> elasticNodes;

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

		[JsonProperty(PropertyName = "CreatedTime")]
		public long? CreatedTime
		{
			get
			{
				return createdTime;
			}
			set	
			{
				createdTime = value;
			}
		}

		[JsonProperty(PropertyName = "PublicNetworkBandwidth")]
		public int? PublicNetworkBandwidth
		{
			get
			{
				return publicNetworkBandwidth;
			}
			set	
			{
				publicNetworkBandwidth = value;
			}
		}

		[JsonProperty(PropertyName = "DataLoadType")]
		public string DataLoadType
		{
			get
			{
				return dataLoadType;
			}
			set	
			{
				dataLoadType = value;
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

		[JsonProperty(PropertyName = "TaskId")]
		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
			}
		}

		[JsonProperty(PropertyName = "Message")]
		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		[JsonProperty(PropertyName = "ExpireStatus")]
		public int? ExpireStatus
		{
			get
			{
				return expireStatus;
			}
			set	
			{
				expireStatus = value;
			}
		}

		[JsonProperty(PropertyName = "Ip")]
		public string Ip
		{
			get
			{
				return ip;
			}
			set	
			{
				ip = value;
			}
		}

		[JsonProperty(PropertyName = "GatewayType")]
		public string GatewayType
		{
			get
			{
				return gatewayType;
			}
			set	
			{
				gatewayType = value;
			}
		}

		[JsonProperty(PropertyName = "StorageBundleId")]
		public string StorageBundleId
		{
			get
			{
				return storageBundleId;
			}
			set	
			{
				storageBundleId = value;
			}
		}

		[JsonProperty(PropertyName = "GatewayClass")]
		public string GatewayClass
		{
			get
			{
				return gatewayClass;
			}
			set	
			{
				gatewayClass = value;
			}
		}

		[JsonProperty(PropertyName = "Success")]
		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		[JsonProperty(PropertyName = "Name")]
		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
			}
		}

		[JsonProperty(PropertyName = "IsPostPaid")]
		public bool? IsPostPaid
		{
			get
			{
				return isPostPaid;
			}
			set	
			{
				isPostPaid = value;
			}
		}

		[JsonProperty(PropertyName = "Capacity")]
		public int? Capacity
		{
			get
			{
				return capacity;
			}
			set	
			{
				capacity = value;
			}
		}

		[JsonProperty(PropertyName = "ExpiredTime")]
		public long? ExpiredTime
		{
			get
			{
				return expiredTime;
			}
			set	
			{
				expiredTime = value;
			}
		}

		[JsonProperty(PropertyName = "GatewayVersion")]
		public string GatewayVersion
		{
			get
			{
				return gatewayVersion;
			}
			set	
			{
				gatewayVersion = value;
			}
		}

		[JsonProperty(PropertyName = "IsReleaseAfterExpiration")]
		public bool? IsReleaseAfterExpiration
		{
			get
			{
				return isReleaseAfterExpiration;
			}
			set	
			{
				isReleaseAfterExpiration = value;
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

		[JsonProperty(PropertyName = "BuyURL")]
		public string BuyURL
		{
			get
			{
				return buyURL;
			}
			set	
			{
				buyURL = value;
			}
		}

		[JsonProperty(PropertyName = "MaxThroughput")]
		public int? MaxThroughput
		{
			get
			{
				return maxThroughput;
			}
			set	
			{
				maxThroughput = value;
			}
		}

		[JsonProperty(PropertyName = "DataLoadInterval")]
		public int? DataLoadInterval
		{
			get
			{
				return dataLoadInterval;
			}
			set	
			{
				dataLoadInterval = value;
			}
		}

		[JsonProperty(PropertyName = "InnerIp")]
		public string InnerIp
		{
			get
			{
				return innerIp;
			}
			set	
			{
				innerIp = value;
			}
		}

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

		[JsonProperty(PropertyName = "GatewayId")]
		public string GatewayId
		{
			get
			{
				return gatewayId;
			}
			set	
			{
				gatewayId = value;
			}
		}

		[JsonProperty(PropertyName = "Code")]
		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		[JsonProperty(PropertyName = "EcsInstanceId")]
		public string EcsInstanceId
		{
			get
			{
				return ecsInstanceId;
			}
			set	
			{
				ecsInstanceId = value;
			}
		}

		[JsonProperty(PropertyName = "Type")]
		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
			}
		}

		[JsonProperty(PropertyName = "RenewURL")]
		public string RenewURL
		{
			get
			{
				return renewURL;
			}
			set	
			{
				renewURL = value;
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

		[JsonProperty(PropertyName = "SerialNumber")]
		public string SerialNumber
		{
			get
			{
				return serialNumber;
			}
			set	
			{
				serialNumber = value;
			}
		}

		[JsonProperty(PropertyName = "ActivatedTime")]
		public long? ActivatedTime
		{
			get
			{
				return activatedTime;
			}
			set	
			{
				activatedTime = value;
			}
		}

		[JsonProperty(PropertyName = "ElasticGateway")]
		public bool? ElasticGateway
		{
			get
			{
				return elasticGateway;
			}
			set	
			{
				elasticGateway = value;
			}
		}

		[JsonProperty(PropertyName = "CommonBuyInstanceId")]
		public string CommonBuyInstanceId
		{
			get
			{
				return commonBuyInstanceId;
			}
			set	
			{
				commonBuyInstanceId = value;
			}
		}

		[JsonProperty(PropertyName = "InnerIpv6Ip")]
		public string InnerIpv6Ip
		{
			get
			{
				return innerIpv6Ip;
			}
			set	
			{
				innerIpv6Ip = value;
			}
		}

		[JsonProperty(PropertyName = "Model")]
		public string Model
		{
			get
			{
				return model;
			}
			set	
			{
				model = value;
			}
		}

		[JsonProperty(PropertyName = "LastErrorKey")]
		public string LastErrorKey
		{
			get
			{
				return lastErrorKey;
			}
			set	
			{
				lastErrorKey = value;
			}
		}

		[JsonProperty(PropertyName = "Location")]
		public string Location
		{
			get
			{
				return location;
			}
			set	
			{
				location = value;
			}
		}

		[JsonProperty(PropertyName = "ElasticNodes")]
		public List<string> ElasticNodes
		{
			get
			{
				return elasticNodes;
			}
			set	
			{
				elasticNodes = value;
			}
		}
	}
}
