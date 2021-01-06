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
using Aliyun.Acs.CDRS;
using Aliyun.Acs.CDRS.Transform;
using Aliyun.Acs.CDRS.Transform.V20201101;

namespace Aliyun.Acs.CDRS.Model.V20201101
{
    public class GetCdrsMonitorResultRequest : RpcAcsRequest<GetCdrsMonitorResultResponse>
    {
        public GetCdrsMonitorResultRequest()
            : base("CDRS", "2020-11-01", "GetCdrsMonitorResult")
        {
			Method = MethodType.POST;
        }

		private string corpId;

		private long? endTime;

		private long? startTime;

		private string algorithmVendor;

		private string minRecordId;

		private string taskId;

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
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
				DictionaryUtil.Add(BodyParameters, "EndTime", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "StartTime", value.ToString());
			}
		}

		public string AlgorithmVendor
		{
			get
			{
				return algorithmVendor;
			}
			set	
			{
				algorithmVendor = value;
				DictionaryUtil.Add(BodyParameters, "AlgorithmVendor", value);
			}
		}

		public string MinRecordId
		{
			get
			{
				return minRecordId;
			}
			set	
			{
				minRecordId = value;
				DictionaryUtil.Add(BodyParameters, "MinRecordId", value);
			}
		}

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(BodyParameters, "TaskId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetCdrsMonitorResultResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetCdrsMonitorResultResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
