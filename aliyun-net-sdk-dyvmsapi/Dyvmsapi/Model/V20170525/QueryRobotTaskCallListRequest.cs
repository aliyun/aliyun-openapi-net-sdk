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
    public class QueryRobotTaskCallListRequest : RpcAcsRequest<QueryRobotTaskCallListResponse>
    {
        public QueryRobotTaskCallListRequest()
            : base("Dyvmsapi", "2017-05-25", "QueryRobotTaskCallList", "dyvms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string called;

		private string dialogCountTo;

		private string durationFrom;

		private int? pageSize;

		private string taskId;

		private string resourceOwnerAccount;

		private string dialogCountFrom;

		private string durationTo;

		private string hangupDirection;

		private long? ownerId;

		private int? pageNo;

		private string callResult;

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

		public string Called
		{
			get
			{
				return called;
			}
			set	
			{
				called = value;
				DictionaryUtil.Add(QueryParameters, "Called", value);
			}
		}

		public string DialogCountTo
		{
			get
			{
				return dialogCountTo;
			}
			set	
			{
				dialogCountTo = value;
				DictionaryUtil.Add(QueryParameters, "DialogCountTo", value);
			}
		}

		public string DurationFrom
		{
			get
			{
				return durationFrom;
			}
			set	
			{
				durationFrom = value;
				DictionaryUtil.Add(QueryParameters, "DurationFrom", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(QueryParameters, "TaskId", value);
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

		public string DialogCountFrom
		{
			get
			{
				return dialogCountFrom;
			}
			set	
			{
				dialogCountFrom = value;
				DictionaryUtil.Add(QueryParameters, "DialogCountFrom", value);
			}
		}

		public string DurationTo
		{
			get
			{
				return durationTo;
			}
			set	
			{
				durationTo = value;
				DictionaryUtil.Add(QueryParameters, "DurationTo", value);
			}
		}

		public string HangupDirection
		{
			get
			{
				return hangupDirection;
			}
			set	
			{
				hangupDirection = value;
				DictionaryUtil.Add(QueryParameters, "HangupDirection", value);
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

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
				DictionaryUtil.Add(QueryParameters, "PageNo", value.ToString());
			}
		}

		public string CallResult
		{
			get
			{
				return callResult;
			}
			set	
			{
				callResult = value;
				DictionaryUtil.Add(QueryParameters, "CallResult", value);
			}
		}

        public override QueryRobotTaskCallListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryRobotTaskCallListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
