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
using Aliyun.Acs.Dyvmsapi.Transform;
using Aliyun.Acs.Dyvmsapi.Transform.V20170525;

namespace Aliyun.Acs.Dyvmsapi.Model.V20170525
{
    public class SetTransferCalleePoolConfigRequest : RpcAcsRequest<SetTransferCalleePoolConfigResponse>
    {
        public SetTransferCalleePoolConfigRequest()
            : base("Dyvmsapi", "2017-05-25", "SetTransferCalleePoolConfig", "dyvms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dyvmsapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dyvmsapi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string phoneNumber;

		private List<Details> detailss = new List<Details>(){ };

		private string calledRouteMode;

		private string qualificationId;

		private string resourceOwnerAccount;

		private long? ownerId;

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

		public string PhoneNumber
		{
			get
			{
				return phoneNumber;
			}
			set	
			{
				phoneNumber = value;
				DictionaryUtil.Add(QueryParameters, "PhoneNumber", value);
			}
		}

		public List<Details> Detailss
		{
			get
			{
				return detailss;
			}

			set
			{
				detailss = value;
				for (int i = 0; i < detailss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Details." + (i + 1) + ".Caller", detailss[i].Caller);
					DictionaryUtil.Add(QueryParameters,"Details." + (i + 1) + ".Called", detailss[i].Called);
				}
			}
		}

		public string CalledRouteMode
		{
			get
			{
				return calledRouteMode;
			}
			set	
			{
				calledRouteMode = value;
				DictionaryUtil.Add(QueryParameters, "CalledRouteMode", value);
			}
		}

		public string QualificationId
		{
			get
			{
				return qualificationId;
			}
			set	
			{
				qualificationId = value;
				DictionaryUtil.Add(QueryParameters, "QualificationId", value);
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

		public class Details
		{

			private string caller;

			private string called;

			public string Caller
			{
				get
				{
					return caller;
				}
				set	
				{
					caller = value;
				}
			}

			public string Called
			{
				get
				{
					return called;
				}
				set	
				{
					called = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SetTransferCalleePoolConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetTransferCalleePoolConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
