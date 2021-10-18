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
    public class ModifyCapacityReservationRequest : RpcAcsRequest<ModifyCapacityReservationResponse>
    {
        public ModifyCapacityReservationRequest()
            : base("Ecs", "2014-05-26", "ModifyCapacityReservation", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string description;

		private string startTime;

		private string platform;

		private string privatePoolOptionsId;

		private string endTimeType;

		private string resourceOwnerAccount;

		private string privatePoolOptionsName;

		private string ownerAccount;

		private string endTime;

		private long? ownerId;

		private int? instanceAmount;

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

		[JsonProperty(PropertyName = "StartTime")]
		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		[JsonProperty(PropertyName = "Platform")]
		public string Platform
		{
			get
			{
				return platform;
			}
			set	
			{
				platform = value;
				DictionaryUtil.Add(QueryParameters, "Platform", value);
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

		[JsonProperty(PropertyName = "EndTimeType")]
		public string EndTimeType
		{
			get
			{
				return endTimeType;
			}
			set	
			{
				endTimeType = value;
				DictionaryUtil.Add(QueryParameters, "EndTimeType", value);
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

		[JsonProperty(PropertyName = "PrivatePoolOptions.Name")]
		public string PrivatePoolOptionsName
		{
			get
			{
				return privatePoolOptionsName;
			}
			set	
			{
				privatePoolOptionsName = value;
				DictionaryUtil.Add(QueryParameters, "PrivatePoolOptions.Name", value);
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

		[JsonProperty(PropertyName = "EndTime")]
		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
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

		[JsonProperty(PropertyName = "InstanceAmount")]
		public int? InstanceAmount
		{
			get
			{
				return instanceAmount;
			}
			set	
			{
				instanceAmount = value;
				DictionaryUtil.Add(QueryParameters, "InstanceAmount", value.ToString());
			}
		}

        public override ModifyCapacityReservationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyCapacityReservationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
