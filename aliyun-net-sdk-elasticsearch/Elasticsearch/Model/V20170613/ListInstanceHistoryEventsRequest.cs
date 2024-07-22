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
using Aliyun.Acs.elasticsearch.Transform;
using Aliyun.Acs.elasticsearch.Transform.V20170613;

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
    public class ListInstanceHistoryEventsRequest : RoaAcsRequest<ListInstanceHistoryEventsResponse>
    {
        public ListInstanceHistoryEventsRequest()
            : base("elasticsearch", "2017-06-13", "ListInstanceHistoryEvents", "elasticsearch", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.elasticsearch.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.elasticsearch.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/openapi/events";
			Method = MethodType.POST;
        }

		private string eventFinashEndTime;

		private string instanceId;

		private int? size;

		private string eventExecuteStartTime;

		private string eventFinashStartTime;

		private string nodeIP;

		private int? page;

		private string eventCreateEndTime;

		private string body;

		private string eventCreateStartTime;

		private string eventExecuteEndTime;

		public string EventFinashEndTime
		{
			get
			{
				return eventFinashEndTime;
			}
			set	
			{
				eventFinashEndTime = value;
				DictionaryUtil.Add(QueryParameters, "eventFinashEndTime", value);
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
				DictionaryUtil.Add(QueryParameters, "instanceId", value);
			}
		}

		public int? Size
		{
			get
			{
				return size;
			}
			set	
			{
				size = value;
				DictionaryUtil.Add(QueryParameters, "size", value.ToString());
			}
		}

		public string EventExecuteStartTime
		{
			get
			{
				return eventExecuteStartTime;
			}
			set	
			{
				eventExecuteStartTime = value;
				DictionaryUtil.Add(QueryParameters, "eventExecuteStartTime", value);
			}
		}

		public string EventFinashStartTime
		{
			get
			{
				return eventFinashStartTime;
			}
			set	
			{
				eventFinashStartTime = value;
				DictionaryUtil.Add(QueryParameters, "eventFinashStartTime", value);
			}
		}

		public string NodeIP
		{
			get
			{
				return nodeIP;
			}
			set	
			{
				nodeIP = value;
				DictionaryUtil.Add(QueryParameters, "nodeIP", value);
			}
		}

		public int? Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
				DictionaryUtil.Add(QueryParameters, "page", value.ToString());
			}
		}

		public string EventCreateEndTime
		{
			get
			{
				return eventCreateEndTime;
			}
			set	
			{
				eventCreateEndTime = value;
				DictionaryUtil.Add(QueryParameters, "eventCreateEndTime", value);
			}
		}

		public string Body
		{
			get
			{
				return body;
			}
			set	
			{
				body = value;
				DictionaryUtil.Add(BodyParameters, "body", value);
			}
		}

		public string EventCreateStartTime
		{
			get
			{
				return eventCreateStartTime;
			}
			set	
			{
				eventCreateStartTime = value;
				DictionaryUtil.Add(QueryParameters, "eventCreateStartTime", value);
			}
		}

		public string EventExecuteEndTime
		{
			get
			{
				return eventExecuteEndTime;
			}
			set	
			{
				eventExecuteEndTime = value;
				DictionaryUtil.Add(QueryParameters, "eventExecuteEndTime", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListInstanceHistoryEventsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListInstanceHistoryEventsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
