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
using Aliyun.Acs.Dypnsapi.Transform;
using Aliyun.Acs.Dypnsapi.Transform.V20170525;

namespace Aliyun.Acs.Dypnsapi.Model.V20170525
{
    public class QueryGateVerifyStatisticPublicRequest : RpcAcsRequest<QueryGateVerifyStatisticPublicResponse>
    {
        public QueryGateVerifyStatisticPublicRequest()
            : base("Dypnsapi", "2017-05-25", "QueryGateVerifyStatisticPublic", "dypnsapi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dypnsapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dypnsapi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? authenticationType;

		private string startDate;

		private string sceneCode;

		private string resourceOwnerAccount;

		private string osType;

		private long? ownerId;

		private string endDate;

		public int? AuthenticationType
		{
			get
			{
				return authenticationType;
			}
			set	
			{
				authenticationType = value;
				DictionaryUtil.Add(QueryParameters, "AuthenticationType", value.ToString());
			}
		}

		public string StartDate
		{
			get
			{
				return startDate;
			}
			set	
			{
				startDate = value;
				DictionaryUtil.Add(QueryParameters, "StartDate", value);
			}
		}

		public string SceneCode
		{
			get
			{
				return sceneCode;
			}
			set	
			{
				sceneCode = value;
				DictionaryUtil.Add(QueryParameters, "SceneCode", value);
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

		public string OsType
		{
			get
			{
				return osType;
			}
			set	
			{
				osType = value;
				DictionaryUtil.Add(QueryParameters, "OsType", value);
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

		public string EndDate
		{
			get
			{
				return endDate;
			}
			set	
			{
				endDate = value;
				DictionaryUtil.Add(QueryParameters, "EndDate", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryGateVerifyStatisticPublicResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryGateVerifyStatisticPublicResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
