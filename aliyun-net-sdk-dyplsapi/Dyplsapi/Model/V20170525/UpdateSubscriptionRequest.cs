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
using Aliyun.Acs.Dyplsapi.Transform;
using Aliyun.Acs.Dyplsapi.Transform.V20170525;

namespace Aliyun.Acs.Dyplsapi.Model.V20170525
{
    public class UpdateSubscriptionRequest : RpcAcsRequest<UpdateSubscriptionResponse>
    {
        public UpdateSubscriptionRequest()
            : base("Dyplsapi", "2017-05-25", "UpdateSubscription", "dypls", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private int? callDisplayType;

		private string productType;

		private string subsId;

		private string phoneNoX;

		private string ringConfig;

		private bool? aSRStatus;

		private string phoneNoB;

		private string phoneNoA;

		private string resourceOwnerAccount;

		private string groupId;

		private long? ownerId;

		private string poolKey;

		private string expiration;

		private string outId;

		private bool? isRecordingEnabled;

		private string operateType;

		private string aSRModelId;

		private string callRestrict;

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

		public int? CallDisplayType
		{
			get
			{
				return callDisplayType;
			}
			set	
			{
				callDisplayType = value;
				DictionaryUtil.Add(QueryParameters, "CallDisplayType", value.ToString());
			}
		}

		public string ProductType
		{
			get
			{
				return productType;
			}
			set	
			{
				productType = value;
				DictionaryUtil.Add(QueryParameters, "ProductType", value);
			}
		}

		public string SubsId
		{
			get
			{
				return subsId;
			}
			set	
			{
				subsId = value;
				DictionaryUtil.Add(QueryParameters, "SubsId", value);
			}
		}

		public string PhoneNoX
		{
			get
			{
				return phoneNoX;
			}
			set	
			{
				phoneNoX = value;
				DictionaryUtil.Add(QueryParameters, "PhoneNoX", value);
			}
		}

		public string RingConfig
		{
			get
			{
				return ringConfig;
			}
			set	
			{
				ringConfig = value;
				DictionaryUtil.Add(QueryParameters, "RingConfig", value);
			}
		}

		public bool? ASRStatus
		{
			get
			{
				return aSRStatus;
			}
			set	
			{
				aSRStatus = value;
				DictionaryUtil.Add(QueryParameters, "ASRStatus", value.ToString());
			}
		}

		public string PhoneNoB
		{
			get
			{
				return phoneNoB;
			}
			set	
			{
				phoneNoB = value;
				DictionaryUtil.Add(QueryParameters, "PhoneNoB", value);
			}
		}

		public string PhoneNoA
		{
			get
			{
				return phoneNoA;
			}
			set	
			{
				phoneNoA = value;
				DictionaryUtil.Add(QueryParameters, "PhoneNoA", value);
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

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
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

		public string PoolKey
		{
			get
			{
				return poolKey;
			}
			set	
			{
				poolKey = value;
				DictionaryUtil.Add(QueryParameters, "PoolKey", value);
			}
		}

		public string Expiration
		{
			get
			{
				return expiration;
			}
			set	
			{
				expiration = value;
				DictionaryUtil.Add(QueryParameters, "Expiration", value);
			}
		}

		public string OutId
		{
			get
			{
				return outId;
			}
			set	
			{
				outId = value;
				DictionaryUtil.Add(QueryParameters, "OutId", value);
			}
		}

		public bool? IsRecordingEnabled
		{
			get
			{
				return isRecordingEnabled;
			}
			set	
			{
				isRecordingEnabled = value;
				DictionaryUtil.Add(QueryParameters, "IsRecordingEnabled", value.ToString());
			}
		}

		public string OperateType
		{
			get
			{
				return operateType;
			}
			set	
			{
				operateType = value;
				DictionaryUtil.Add(QueryParameters, "OperateType", value);
			}
		}

		public string ASRModelId
		{
			get
			{
				return aSRModelId;
			}
			set	
			{
				aSRModelId = value;
				DictionaryUtil.Add(QueryParameters, "ASRModelId", value);
			}
		}

		public string CallRestrict
		{
			get
			{
				return callRestrict;
			}
			set	
			{
				callRestrict = value;
				DictionaryUtil.Add(QueryParameters, "CallRestrict", value);
			}
		}

        public override UpdateSubscriptionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateSubscriptionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
