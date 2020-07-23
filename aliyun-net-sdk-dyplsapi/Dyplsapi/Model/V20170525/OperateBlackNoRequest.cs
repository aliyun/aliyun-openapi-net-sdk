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
    public class OperateBlackNoRequest : RpcAcsRequest<OperateBlackNoResponse>
    {
        public OperateBlackNoRequest()
            : base("Dyplsapi", "2017-05-25", "OperateBlackNo", "dypls", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string tips;

		private string resourceOwnerAccount;

		private long? ownerId;

		private string poolKey;

		private string blackNo;

		private string operateType;

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

		public string Tips
		{
			get
			{
				return tips;
			}
			set	
			{
				tips = value;
				DictionaryUtil.Add(QueryParameters, "Tips", value);
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

		public string BlackNo
		{
			get
			{
				return blackNo;
			}
			set	
			{
				blackNo = value;
				DictionaryUtil.Add(QueryParameters, "BlackNo", value);
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

        public override OperateBlackNoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return OperateBlackNoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
