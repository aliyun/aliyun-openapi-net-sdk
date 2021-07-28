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
    public class ListDeployOrdersRequest : RpcAcsRequest<ListDeployOrdersResponse>
    {
        public ListDeployOrdersRequest()
            : base("retailcloud", "2018-03-13", "ListDeployOrders", "retailcloud", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string startTimeGreaterThanOrEqualTo;

		private List<int?> statusLists = new List<int?>(){ };

		private long? envId;

		private string endTimeGreaterThan;

		private int? pageNumber;

		private string pauseType;

		private List<int?> resultLists = new List<int?>(){ };

		private string startTimeGreaterThan;

		private string startTimeLessThan;

		private string startTimeLessThanOrEqualTo;

		private long? appId;

		private string envType;

		private int? pageSize;

		private string endTimeGreaterThanOrEqualTo;

		private string endTimeLessThan;

		private string endTimeLessThanOrEqualTo;

		private string partitionType;

		private string deployCategory;

		private string deployType;

		private int? status;

		public string StartTimeGreaterThanOrEqualTo
		{
			get
			{
				return startTimeGreaterThanOrEqualTo;
			}
			set	
			{
				startTimeGreaterThanOrEqualTo = value;
				DictionaryUtil.Add(QueryParameters, "StartTimeGreaterThanOrEqualTo", value);
			}
		}

		public List<int?> StatusLists
		{
			get
			{
				return statusLists;
			}

			set
			{
				statusLists = value;
				for (int i = 0; i < statusLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"StatusList." + (i + 1) , statusLists[i]);
				}
			}
		}

		public long? EnvId
		{
			get
			{
				return envId;
			}
			set	
			{
				envId = value;
				DictionaryUtil.Add(QueryParameters, "EnvId", value.ToString());
			}
		}

		public string EndTimeGreaterThan
		{
			get
			{
				return endTimeGreaterThan;
			}
			set	
			{
				endTimeGreaterThan = value;
				DictionaryUtil.Add(QueryParameters, "EndTimeGreaterThan", value);
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

		public string PauseType
		{
			get
			{
				return pauseType;
			}
			set	
			{
				pauseType = value;
				DictionaryUtil.Add(QueryParameters, "PauseType", value);
			}
		}

		public List<int?> ResultLists
		{
			get
			{
				return resultLists;
			}

			set
			{
				resultLists = value;
				for (int i = 0; i < resultLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"ResultList." + (i + 1) , resultLists[i]);
				}
			}
		}

		public string StartTimeGreaterThan
		{
			get
			{
				return startTimeGreaterThan;
			}
			set	
			{
				startTimeGreaterThan = value;
				DictionaryUtil.Add(QueryParameters, "StartTimeGreaterThan", value);
			}
		}

		public string StartTimeLessThan
		{
			get
			{
				return startTimeLessThan;
			}
			set	
			{
				startTimeLessThan = value;
				DictionaryUtil.Add(QueryParameters, "StartTimeLessThan", value);
			}
		}

		public string StartTimeLessThanOrEqualTo
		{
			get
			{
				return startTimeLessThanOrEqualTo;
			}
			set	
			{
				startTimeLessThanOrEqualTo = value;
				DictionaryUtil.Add(QueryParameters, "StartTimeLessThanOrEqualTo", value);
			}
		}

		public long? AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "EnvType", value);
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

		public string EndTimeGreaterThanOrEqualTo
		{
			get
			{
				return endTimeGreaterThanOrEqualTo;
			}
			set	
			{
				endTimeGreaterThanOrEqualTo = value;
				DictionaryUtil.Add(QueryParameters, "EndTimeGreaterThanOrEqualTo", value);
			}
		}

		public string EndTimeLessThan
		{
			get
			{
				return endTimeLessThan;
			}
			set	
			{
				endTimeLessThan = value;
				DictionaryUtil.Add(QueryParameters, "EndTimeLessThan", value);
			}
		}

		public string EndTimeLessThanOrEqualTo
		{
			get
			{
				return endTimeLessThanOrEqualTo;
			}
			set	
			{
				endTimeLessThanOrEqualTo = value;
				DictionaryUtil.Add(QueryParameters, "EndTimeLessThanOrEqualTo", value);
			}
		}

		public string PartitionType
		{
			get
			{
				return partitionType;
			}
			set	
			{
				partitionType = value;
				DictionaryUtil.Add(QueryParameters, "PartitionType", value);
			}
		}

		public string DeployCategory
		{
			get
			{
				return deployCategory;
			}
			set	
			{
				deployCategory = value;
				DictionaryUtil.Add(QueryParameters, "DeployCategory", value);
			}
		}

		public string DeployType
		{
			get
			{
				return deployType;
			}
			set	
			{
				deployType = value;
				DictionaryUtil.Add(QueryParameters, "DeployType", value);
			}
		}

		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListDeployOrdersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListDeployOrdersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
