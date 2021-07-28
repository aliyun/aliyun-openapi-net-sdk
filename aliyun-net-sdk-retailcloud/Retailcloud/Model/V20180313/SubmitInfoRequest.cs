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
using Aliyun.Acs.retailcloud.Transform;
using Aliyun.Acs.retailcloud.Transform.V20180313;

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
    public class SubmitInfoRequest : RpcAcsRequest<SubmitInfoResponse>
    {
        public SubmitInfoRequest()
            : base("retailcloud", "2018-03-13", "SubmitInfo", "retailcloud", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string requestId;

		private long? mainUserId;

		private List<EcsDescList> ecsDescLists = new List<EcsDescList>(){ };

		private long? callerUid;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
				DictionaryUtil.Add(QueryParameters, "RequestId", value);
			}
		}

		public long? MainUserId
		{
			get
			{
				return mainUserId;
			}
			set	
			{
				mainUserId = value;
				DictionaryUtil.Add(QueryParameters, "MainUserId", value.ToString());
			}
		}

		public List<EcsDescList> EcsDescLists
		{
			get
			{
				return ecsDescLists;
			}

			set
			{
				ecsDescLists = value;
				for (int i = 0; i < ecsDescLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"EcsDescList." + (i + 1) + ".ResourceId", ecsDescLists[i].ResourceId);
					DictionaryUtil.Add(BodyParameters,"EcsDescList." + (i + 1) + ".BussinessDesc", ecsDescLists[i].BussinessDesc);
					DictionaryUtil.Add(BodyParameters,"EcsDescList." + (i + 1) + ".MiddleWareDesc", ecsDescLists[i].MiddleWareDesc);
					DictionaryUtil.Add(BodyParameters,"EcsDescList." + (i + 1) + ".OtherMiddleWareDesc", ecsDescLists[i].OtherMiddleWareDesc);
					DictionaryUtil.Add(BodyParameters,"EcsDescList." + (i + 1) + ".BussinessType", ecsDescLists[i].BussinessType);
					DictionaryUtil.Add(BodyParameters,"EcsDescList." + (i + 1) + ".AppType", ecsDescLists[i].AppType);
					DictionaryUtil.Add(BodyParameters,"EcsDescList." + (i + 1) + ".EnvType", ecsDescLists[i].EnvType);
					DictionaryUtil.Add(BodyParameters,"EcsDescList." + (i + 1) + ".UserId", ecsDescLists[i].UserId);
				}
			}
		}

		public long? CallerUid
		{
			get
			{
				return callerUid;
			}
			set	
			{
				callerUid = value;
				DictionaryUtil.Add(QueryParameters, "CallerUid", value.ToString());
			}
		}

		public class EcsDescList
		{

			private string resourceId;

			private string bussinessDesc;

			private string middleWareDesc;

			private string otherMiddleWareDesc;

			private string bussinessType;

			private string appType;

			private string envType;

			private string userId;

			public string ResourceId
			{
				get
				{
					return resourceId;
				}
				set	
				{
					resourceId = value;
				}
			}

			public string BussinessDesc
			{
				get
				{
					return bussinessDesc;
				}
				set	
				{
					bussinessDesc = value;
				}
			}

			public string MiddleWareDesc
			{
				get
				{
					return middleWareDesc;
				}
				set	
				{
					middleWareDesc = value;
				}
			}

			public string OtherMiddleWareDesc
			{
				get
				{
					return otherMiddleWareDesc;
				}
				set	
				{
					otherMiddleWareDesc = value;
				}
			}

			public string BussinessType
			{
				get
				{
					return bussinessType;
				}
				set	
				{
					bussinessType = value;
				}
			}

			public string AppType
			{
				get
				{
					return appType;
				}
				set	
				{
					appType = value;
				}
			}

			public string EnvType
			{
				get
				{
					return envType;
				}
				set	
				{
					envType = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SubmitInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
