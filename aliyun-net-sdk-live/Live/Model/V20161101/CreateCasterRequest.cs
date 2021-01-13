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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class CreateCasterRequest : RpcAcsRequest<CreateCasterResponse>
    {
        public CreateCasterRequest()
            : base("live", "2016-11-01", "CreateCaster", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string casterName;

		private string casterTemplate;

		private string expireTime;

		private int? normType;

		private long? ownerId;

		private string purchaseTime;

		private string chargeType;

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

		public string CasterName
		{
			get
			{
				return casterName;
			}
			set	
			{
				casterName = value;
				DictionaryUtil.Add(QueryParameters, "CasterName", value);
			}
		}

		public string CasterTemplate
		{
			get
			{
				return casterTemplate;
			}
			set	
			{
				casterTemplate = value;
				DictionaryUtil.Add(QueryParameters, "CasterTemplate", value);
			}
		}

		public string ExpireTime
		{
			get
			{
				return expireTime;
			}
			set	
			{
				expireTime = value;
				DictionaryUtil.Add(QueryParameters, "ExpireTime", value);
			}
		}

		public int? NormType
		{
			get
			{
				return normType;
			}
			set	
			{
				normType = value;
				DictionaryUtil.Add(QueryParameters, "NormType", value.ToString());
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

		public string PurchaseTime
		{
			get
			{
				return purchaseTime;
			}
			set	
			{
				purchaseTime = value;
				DictionaryUtil.Add(QueryParameters, "PurchaseTime", value);
			}
		}

		public string ChargeType
		{
			get
			{
				return chargeType;
			}
			set	
			{
				chargeType = value;
				DictionaryUtil.Add(QueryParameters, "ChargeType", value);
			}
		}

        public override CreateCasterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateCasterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
