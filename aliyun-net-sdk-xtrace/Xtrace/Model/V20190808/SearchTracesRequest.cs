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
using Aliyun.Acs.xtrace;
using Aliyun.Acs.xtrace.Transform;
using Aliyun.Acs.xtrace.Transform.V20190808;

namespace Aliyun.Acs.xtrace.Model.V20190808
{
    public class SearchTracesRequest : RpcAcsRequest<SearchTracesResponse>
    {
        public SearchTracesRequest()
            : base("xtrace", "2019-08-08", "SearchTraces")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.xtrace.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.xtrace.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string appType;

		private long? endTime;

		private long? startTime;

		private bool? reverse;

		private long? minDuration;

		private int? pageNumber;

		private string serviceIp;

		private string operationName;

		private int? pageSize;

		private string serviceName;

		private List<Tag> tags = new List<Tag>(){ };

		public string AppType
		{
			get
			{
				return appType;
			}
			set	
			{
				appType = value;
				DictionaryUtil.Add(QueryParameters, "AppType", value);
			}
		}

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value.ToString());
			}
		}

		public long? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value.ToString());
			}
		}

		public bool? Reverse
		{
			get
			{
				return reverse;
			}
			set	
			{
				reverse = value;
				DictionaryUtil.Add(QueryParameters, "Reverse", value.ToString());
			}
		}

		public long? MinDuration
		{
			get
			{
				return minDuration;
			}
			set	
			{
				minDuration = value;
				DictionaryUtil.Add(QueryParameters, "MinDuration", value.ToString());
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

		public string ServiceIp
		{
			get
			{
				return serviceIp;
			}
			set	
			{
				serviceIp = value;
				DictionaryUtil.Add(QueryParameters, "ServiceIp", value);
			}
		}

		public string OperationName
		{
			get
			{
				return operationName;
			}
			set	
			{
				operationName = value;
				DictionaryUtil.Add(QueryParameters, "OperationName", value);
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

		public string ServiceName
		{
			get
			{
				return serviceName;
			}
			set	
			{
				serviceName = value;
				DictionaryUtil.Add(QueryParameters, "ServiceName", value);
			}
		}

		public List<Tag> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				for (int i = 0; i < tags.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Value", tags[i].Value);
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Key", tags[i].Key);
				}
			}
		}

		public class Tag
		{

			private string value_;

			private string key;

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

        public override SearchTracesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SearchTracesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
