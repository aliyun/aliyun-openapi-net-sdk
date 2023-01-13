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
using Aliyun.Acs.OutboundBot;
using Aliyun.Acs.OutboundBot.Transform;
using Aliyun.Acs.OutboundBot.Transform.V20191226;

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
    public class RecordFailureRequest : RpcAcsRequest<RecordFailureResponse>
    {
        public RecordFailureRequest()
            : base("OutboundBot", "2019-12-26", "RecordFailure")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string callId;

		private long? actualTime;

		private string callingNumber;

		private string instanceId;

		private string dispositionCode;

		private string calledNumber;

		private string taskId;

		private string exceptionCodes;

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

		public long? ActualTime
		{
			get
			{
				return actualTime;
			}
			set	
			{
				actualTime = value;
				DictionaryUtil.Add(QueryParameters, "ActualTime", value.ToString());
			}
		}

		public string CallingNumber
		{
			get
			{
				return callingNumber;
			}
			set	
			{
				callingNumber = value;
				DictionaryUtil.Add(QueryParameters, "CallingNumber", value);
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

		public string DispositionCode
		{
			get
			{
				return dispositionCode;
			}
			set	
			{
				dispositionCode = value;
				DictionaryUtil.Add(QueryParameters, "DispositionCode", value);
			}
		}

		public string CalledNumber
		{
			get
			{
				return calledNumber;
			}
			set	
			{
				calledNumber = value;
				DictionaryUtil.Add(QueryParameters, "CalledNumber", value);
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
				DictionaryUtil.Add(QueryParameters, "TaskId", value);
			}
		}

		public string ExceptionCodes
		{
			get
			{
				return exceptionCodes;
			}
			set	
			{
				exceptionCodes = value;
				DictionaryUtil.Add(QueryParameters, "ExceptionCodes", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RecordFailureResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RecordFailureResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
