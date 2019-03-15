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
using Aliyun.Acs.Snsuapi.Transform;
using Aliyun.Acs.Snsuapi.Transform.V20180709;

namespace Aliyun.Acs.Snsuapi.Model.V20180709
{
    public class BandOfferOrderRequest : RpcAcsRequest<BandOfferOrderResponse>
    {
        public BandOfferOrderRequest()
            : base("Snsuapi", "2018-07-09", "BandOfferOrder", "snsuapi", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string bandId;

		private string offerId;

		private string action;

		private long? ownerId;

		private string accessKeyId;

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

		public string BandId
		{
			get
			{
				return bandId;
			}
			set	
			{
				bandId = value;
				DictionaryUtil.Add(QueryParameters, "BandId", value);
			}
		}

		public string OfferId
		{
			get
			{
				return offerId;
			}
			set	
			{
				offerId = value;
				DictionaryUtil.Add(QueryParameters, "OfferId", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
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

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override BandOfferOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BandOfferOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
