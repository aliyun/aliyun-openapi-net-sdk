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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.DBFS;
using Aliyun.Acs.DBFS.Transform;
using Aliyun.Acs.DBFS.Transform.V20200418;

namespace Aliyun.Acs.DBFS.Model.V20200418
{
    public class CreateAutoSnapshotPolicyRequest : RpcAcsRequest<CreateAutoSnapshotPolicyResponse>
    {
        public CreateAutoSnapshotPolicyRequest()
            : base("DBFS", "2020-04-18", "CreateAutoSnapshotPolicy")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.DBFS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.DBFS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> timePoints = new List<string>(){ };

		private List<string> repeatWeekdays = new List<string>(){ };

		private string policyName;

		private int? retentionDays;

		[JsonProperty(PropertyName = "TimePoints")]
		public List<string> TimePoints
		{
			get
			{
				return timePoints;
			}

			set
			{
				timePoints = value;
				if(timePoints != null)
				{
					for (int depth1 = 0; depth1 < timePoints.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"TimePoints." + (depth1 + 1), timePoints[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "RepeatWeekdays")]
		public List<string> RepeatWeekdays
		{
			get
			{
				return repeatWeekdays;
			}

			set
			{
				repeatWeekdays = value;
				if(repeatWeekdays != null)
				{
					for (int depth1 = 0; depth1 < repeatWeekdays.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"RepeatWeekdays." + (depth1 + 1), repeatWeekdays[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "PolicyName")]
		public string PolicyName
		{
			get
			{
				return policyName;
			}
			set	
			{
				policyName = value;
				DictionaryUtil.Add(QueryParameters, "PolicyName", value);
			}
		}

		[JsonProperty(PropertyName = "RetentionDays")]
		public int? RetentionDays
		{
			get
			{
				return retentionDays;
			}
			set	
			{
				retentionDays = value;
				DictionaryUtil.Add(QueryParameters, "RetentionDays", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateAutoSnapshotPolicyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateAutoSnapshotPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
