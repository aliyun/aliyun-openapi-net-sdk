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
    public class SaveStatsRequest : RpcAcsRequest<SaveStatsResponse>
    {
        public SaveStatsRequest()
            : base("CCC", "2017-07-05", "SaveStats")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string callId;

		private long? recordTime;

		private long? callStartTime;

		private string uid;

		private string instanceId;

		private string stats;

		private string tenantId;

		private string calleeNumber;

		private string callerNumber;

		public string CallId
		{
			get
			{
				return callId;
			}
			set	
			{
				callId = value;
				DictionaryUtil.Add(QueryParameters, "CallId", value);
			}
		}

		public long? RecordTime
		{
			get
			{
				return recordTime;
			}
			set	
			{
				recordTime = value;
				DictionaryUtil.Add(QueryParameters, "RecordTime", value.ToString());
			}
		}

		public long? CallStartTime
		{
			get
			{
				return callStartTime;
			}
			set	
			{
				callStartTime = value;
				DictionaryUtil.Add(QueryParameters, "CallStartTime", value.ToString());
			}
		}

		public string Uid
		{
			get
			{
				return uid;
			}
			set	
			{
				uid = value;
				DictionaryUtil.Add(QueryParameters, "Uid", value);
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

		public string Stats
		{
			get
			{
				return stats;
			}
			set	
			{
				stats = value;
				DictionaryUtil.Add(QueryParameters, "Stats", value);
			}
		}

		public string TenantId
		{
			get
			{
				return tenantId;
			}
			set	
			{
				tenantId = value;
				DictionaryUtil.Add(QueryParameters, "TenantId", value);
			}
		}

		public string CalleeNumber
		{
			get
			{
				return calleeNumber;
			}
			set	
			{
				calleeNumber = value;
				DictionaryUtil.Add(QueryParameters, "CalleeNumber", value);
			}
		}

		public string CallerNumber
		{
			get
			{
				return callerNumber;
			}
			set	
			{
				callerNumber = value;
				DictionaryUtil.Add(QueryParameters, "CallerNumber", value);
			}
		}

        public override SaveStatsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveStatsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
