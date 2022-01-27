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
using Aliyun.Acs.Airec.Transform;
using Aliyun.Acs.Airec.Transform.V20201126;

namespace Aliyun.Acs.Airec.Model.V20201126
{
    public class QueryDataMessageStatisticsRequest : RoaAcsRequest<QueryDataMessageStatisticsResponse>
    {
        public QueryDataMessageStatisticsRequest()
            : base("Airec", "2020-11-26", "QueryDataMessageStatistics", "airec", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Airec.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Airec.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/v2/openapi/instances/[instanceId]/tables/[table]/data-message-statistics";
			Method = MethodType.GET;
        }

		private string traceId;

		private string messageSource;

		private long? endTime;

		private string userType;

		private long? startTime;

		private string userId;

		private string itemId;

		private string instanceId;

		private string itemType;

		private string cmdType;

		private string sceneId;

		private string bhvType;

		private string table;

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
				DictionaryUtil.Add(QueryParameters, "traceId", value);
			}
		}

		public string MessageSource
		{
			get
			{
				return messageSource;
			}
			set	
			{
				messageSource = value;
				DictionaryUtil.Add(QueryParameters, "messageSource", value);
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
				DictionaryUtil.Add(QueryParameters, "endTime", value.ToString());
			}
		}

		public string UserType
		{
			get
			{
				return userType;
			}
			set	
			{
				userType = value;
				DictionaryUtil.Add(QueryParameters, "userType", value);
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
				DictionaryUtil.Add(QueryParameters, "startTime", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "userId", value);
			}
		}

		public string ItemId
		{
			get
			{
				return itemId;
			}
			set	
			{
				itemId = value;
				DictionaryUtil.Add(QueryParameters, "itemId", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(PathParameters, "instanceId", value);
			}
		}

		public string ItemType
		{
			get
			{
				return itemType;
			}
			set	
			{
				itemType = value;
				DictionaryUtil.Add(QueryParameters, "itemType", value);
			}
		}

		public string CmdType
		{
			get
			{
				return cmdType;
			}
			set	
			{
				cmdType = value;
				DictionaryUtil.Add(QueryParameters, "cmdType", value);
			}
		}

		public string SceneId
		{
			get
			{
				return sceneId;
			}
			set	
			{
				sceneId = value;
				DictionaryUtil.Add(QueryParameters, "sceneId", value);
			}
		}

		public string BhvType
		{
			get
			{
				return bhvType;
			}
			set	
			{
				bhvType = value;
				DictionaryUtil.Add(QueryParameters, "bhvType", value);
			}
		}

		public string Table
		{
			get
			{
				return table;
			}
			set	
			{
				table = value;
				DictionaryUtil.Add(PathParameters, "table", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryDataMessageStatisticsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryDataMessageStatisticsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
