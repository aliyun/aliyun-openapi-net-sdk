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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class ListApmApplicationRequest : RpcAcsRequest<ListApmApplicationResponse>
    {
        public ListApmApplicationRequest()
            : base("Emr", "2016-04-08", "ListApmApplication", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private int? pageNumber;

		private string finalStatus;

		private int? pageSize;

		private string state;

		private long? startTimeTo;

		private string diagnoseResult;

		private long? endTimeFrom;

		private string orderBy;

		private string clusterId;

		private string jobType;

		private long? startTimeFrom;

		private string appId;

		private string name;

		private string user;

		private long? endTimeTo;

		private string queue;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string FinalStatus
		{
			get
			{
				return finalStatus;
			}
			set	
			{
				finalStatus = value;
				DictionaryUtil.Add(QueryParameters, "FinalStatus", value);
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

		public string State
		{
			get
			{
				return state;
			}
			set	
			{
				state = value;
				DictionaryUtil.Add(QueryParameters, "State", value);
			}
		}

		public long? StartTimeTo
		{
			get
			{
				return startTimeTo;
			}
			set	
			{
				startTimeTo = value;
				DictionaryUtil.Add(QueryParameters, "StartTimeTo", value.ToString());
			}
		}

		public string DiagnoseResult
		{
			get
			{
				return diagnoseResult;
			}
			set	
			{
				diagnoseResult = value;
				DictionaryUtil.Add(QueryParameters, "DiagnoseResult", value);
			}
		}

		public long? EndTimeFrom
		{
			get
			{
				return endTimeFrom;
			}
			set	
			{
				endTimeFrom = value;
				DictionaryUtil.Add(QueryParameters, "EndTimeFrom", value.ToString());
			}
		}

		public string OrderBy
		{
			get
			{
				return orderBy;
			}
			set	
			{
				orderBy = value;
				DictionaryUtil.Add(QueryParameters, "OrderBy", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string JobType
		{
			get
			{
				return jobType;
			}
			set	
			{
				jobType = value;
				DictionaryUtil.Add(QueryParameters, "JobType", value);
			}
		}

		public long? StartTimeFrom
		{
			get
			{
				return startTimeFrom;
			}
			set	
			{
				startTimeFrom = value;
				DictionaryUtil.Add(QueryParameters, "StartTimeFrom", value.ToString());
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string User
		{
			get
			{
				return user;
			}
			set	
			{
				user = value;
				DictionaryUtil.Add(QueryParameters, "User", value);
			}
		}

		public long? EndTimeTo
		{
			get
			{
				return endTimeTo;
			}
			set	
			{
				endTimeTo = value;
				DictionaryUtil.Add(QueryParameters, "EndTimeTo", value.ToString());
			}
		}

		public string Queue
		{
			get
			{
				return queue;
			}
			set	
			{
				queue = value;
				DictionaryUtil.Add(QueryParameters, "Queue", value);
			}
		}

        public override ListApmApplicationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListApmApplicationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
