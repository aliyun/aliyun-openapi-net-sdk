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
using Aliyun.Acs.ARMS.Transform.V20181219;

namespace Aliyun.Acs.ARMS.Model.V20181219
{
    public class SearchTracesRequest : RpcAcsRequest<SearchTracesResponse>
    {
        public SearchTracesRequest()
            : base("ARMS", "2018-12-19", "SearchTraces", "arms", "openAPI")
        {
        }

		private string tag1;

		private string appType;

		private long? endTime;

		private long? startTime;

		private long? minDuration;

		private string tag2;

		private string operationName;

		private string serviceName;

		public string Tag1
		{
			get
			{
				return tag1;
			}
			set	
			{
				tag1 = value;
				DictionaryUtil.Add(QueryParameters, "Tag1", value);
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

		public string Tag2
		{
			get
			{
				return tag2;
			}
			set	
			{
				tag2 = value;
				DictionaryUtil.Add(QueryParameters, "Tag2", value);
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

        public override SearchTracesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SearchTracesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
