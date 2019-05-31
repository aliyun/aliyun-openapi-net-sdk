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
using Aliyun.Acs.ARMS.Transform;
using Aliyun.Acs.ARMS.Transform.V20190219;

namespace Aliyun.Acs.ARMS.Model.V20190219
{
    public class SearchTraceCountRequest : RpcAcsRequest<SearchTraceCountResponse>
    {
        public SearchTraceCountRequest()
            : base("ARMS", "2019-02-19", "SearchTraceCount")
        {
        }

		private string instanceId;

		private string operationName;

		private string appType;

		private long? endTime;

		private string serviceName;

		private long? startTime;

		private List<Tag> tags;

		private long? minDuration;

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
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

        public override SearchTraceCountResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SearchTraceCountResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
