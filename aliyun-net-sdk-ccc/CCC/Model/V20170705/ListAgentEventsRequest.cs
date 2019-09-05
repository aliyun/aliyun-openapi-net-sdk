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
using Aliyun.Acs.CCC;
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20170705;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class ListAgentEventsRequest : RpcAcsRequest<ListAgentEventsResponse>
    {
        public ListAgentEventsRequest()
            : base("CCC", "2017-07-05", "ListAgentEvents")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? startTime;

		private long? stopTime;

		private List<string> ramIds = new List<string>(){ };

		private string instanceId;

		private List<string> _events = new List<string>(){ };

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

		public long? StopTime
		{
			get
			{
				return stopTime;
			}
			set	
			{
				stopTime = value;
				DictionaryUtil.Add(QueryParameters, "StopTime", value.ToString());
			}
		}

		public List<string> RamIds
		{
			get
			{
				return ramIds;
			}

			set
			{
				ramIds = value;
				for (int i = 0; i < ramIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RamId." + (i + 1) , ramIds[i]);
				}
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
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public List<string> _Events
		{
			get
			{
				return _events;
			}

			set
			{
				_events = value;
				for (int i = 0; i < _events.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) , _events[i]);
				}
			}
		}

        public override ListAgentEventsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListAgentEventsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
