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
using Aliyun.Acs.Actiontrail.Transform;
using Aliyun.Acs.Actiontrail.Transform.V20171204;

namespace Aliyun.Acs.Actiontrail.Model.V20171204
{
    public class LookupEventsRequest : RpcAcsRequest<LookupEventsResponse>
    {
        public LookupEventsRequest()
            : base("Actiontrail", "2017-12-04", "LookupEvents", "actiontrail", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Actiontrail.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Actiontrail.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string request;

		private string startTime;

		private string eventName;

		private string nextToken;

		private string serviceName;

		private string _event;

		private string eventAccessKeyId;

		private string endTime;

		private string eventRW;

		private string resourceType;

		private string maxResults;

		private string eventType;

		private string resourceName;

		private string user;

		public string Request
		{
			get
			{
				return request;
			}
			set	
			{
				request = value;
				DictionaryUtil.Add(QueryParameters, "Request", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public string EventName
		{
			get
			{
				return eventName;
			}
			set	
			{
				eventName = value;
				DictionaryUtil.Add(QueryParameters, "EventName", value);
			}
		}

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
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

		public string _Event
		{
			get
			{
				return _event;
			}
			set	
			{
				_event = value;
				DictionaryUtil.Add(QueryParameters, "Event", value);
			}
		}

		public string EventAccessKeyId
		{
			get
			{
				return eventAccessKeyId;
			}
			set	
			{
				eventAccessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "EventAccessKeyId", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public string EventRW
		{
			get
			{
				return eventRW;
			}
			set	
			{
				eventRW = value;
				DictionaryUtil.Add(QueryParameters, "EventRW", value);
			}
		}

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value);
			}
		}

		public string MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(QueryParameters, "MaxResults", value);
			}
		}

		public string EventType
		{
			get
			{
				return eventType;
			}
			set	
			{
				eventType = value;
				DictionaryUtil.Add(QueryParameters, "EventType", value);
			}
		}

		public string ResourceName
		{
			get
			{
				return resourceName;
			}
			set	
			{
				resourceName = value;
				DictionaryUtil.Add(QueryParameters, "ResourceName", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override LookupEventsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return LookupEventsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
