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
    public class ModifyInstanceSpecRequest : RpcAcsRequest<ModifyInstanceSpecResponse>
    {
        public ModifyInstanceSpecRequest()
            : base("Ecs", "2014-05-26", "ModifyInstanceSpec", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clientToken;

		private bool? allowMigrateAcrossZone;

		private int? internetMaxBandwidthOut;

		private string systemDiskCategory;

		private string instanceType;

		private string temporaryEndTime;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private int? temporaryInternetMaxBandwidthOut;

		private string temporaryStartTime;

		private bool? async;

		private string instanceId;

		private int? internetMaxBandwidthIn;

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

		[JsonProperty(PropertyName = "AllowMigrateAcrossZone")]
		public bool? AllowMigrateAcrossZone
		{
			get
			{
				return allowMigrateAcrossZone;
			}
			set	
			{
				allowMigrateAcrossZone = value;
				DictionaryUtil.Add(QueryParameters, "AllowMigrateAcrossZone", value.ToString());
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

		[JsonProperty(PropertyName = "Temporary.EndTime")]
		public string TemporaryEndTime
		{
			get
			{
				return temporaryEndTime;
			}
			set	
			{
				temporaryEndTime = value;
				DictionaryUtil.Add(QueryParameters, "Temporary.EndTime", value);
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

		[JsonProperty(PropertyName = "Temporary.InternetMaxBandwidthOut")]
		public int? TemporaryInternetMaxBandwidthOut
		{
			get
			{
				return temporaryInternetMaxBandwidthOut;
			}
			set	
			{
				temporaryInternetMaxBandwidthOut = value;
				DictionaryUtil.Add(QueryParameters, "Temporary.InternetMaxBandwidthOut", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Temporary.StartTime")]
		public string TemporaryStartTime
		{
			get
			{
				return temporaryStartTime;
			}
			set	
			{
				temporaryStartTime = value;
				DictionaryUtil.Add(QueryParameters, "Temporary.StartTime", value);
			}
		}

		[JsonProperty(PropertyName = "Async")]
		public bool? Async
		{
			get
			{
				return async;
			}
			set	
			{
				async = value;
				DictionaryUtil.Add(QueryParameters, "Async", value.ToString());
			}
		}

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
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
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

        public override ModifyInstanceSpecResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyInstanceSpecResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
