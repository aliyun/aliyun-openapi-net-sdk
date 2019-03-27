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
using Aliyun.Acs.Drds.Transform;
using Aliyun.Acs.Drds.Transform.V20171016;

namespace Aliyun.Acs.Drds.Model.V20171016
{
    public class DescribeDrdsInstanceMonitorRequest : RpcAcsRequest<DescribeDrdsInstanceMonitorResponse>
    {
        public DescribeDrdsInstanceMonitorRequest()
            : base("Drds", "2017-10-16", "DescribeDrdsInstanceMonitor")
        {
        }

		private string action;

		private long? endTime;

		private long? startTime;

		private string drdsInstanceId;

		private string key;

		private string accessKeyId;

		private int? periodMultiple;

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
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

		public string DrdsInstanceId
		{
			get
			{
				return drdsInstanceId;
			}
			set	
			{
				drdsInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DrdsInstanceId", value);
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
				DictionaryUtil.Add(QueryParameters, "Key", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public int? PeriodMultiple
		{
			get
			{
				return periodMultiple;
			}
			set	
			{
				periodMultiple = value;
				DictionaryUtil.Add(QueryParameters, "PeriodMultiple", value.ToString());
			}
		}

        public override DescribeDrdsInstanceMonitorResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDrdsInstanceMonitorResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
