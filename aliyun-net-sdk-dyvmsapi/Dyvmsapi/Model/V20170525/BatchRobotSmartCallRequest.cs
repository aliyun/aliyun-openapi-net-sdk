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
using Aliyun.Acs.Dyvmsapi.Transform;
using Aliyun.Acs.Dyvmsapi.Transform.V20170525;

namespace Aliyun.Acs.Dyvmsapi.Model.V20170525
{
    public class BatchRobotSmartCallRequest : RpcAcsRequest<BatchRobotSmartCallResponse>
    {
        public BatchRobotSmartCallRequest()
            : base("Dyvmsapi", "2017-05-25", "BatchRobotSmartCall", "dyvms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private bool? earlyMediaAsr;

		private string ttsParamHead;

		private string taskName;

		private string ttsParam;

		private string calledNumber;

		private string calledShowNumber;

		private bool? isSelfLine;

		private string resourceOwnerAccount;

		private long? ownerId;

		private string dialogId;

		private long? scheduleTime;

		private string corpName;

		private bool? scheduleCall;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public bool? EarlyMediaAsr
		{
			get
			{
				return earlyMediaAsr;
			}
			set	
			{
				earlyMediaAsr = value;
				DictionaryUtil.Add(QueryParameters, "EarlyMediaAsr", value.ToString());
			}
		}

		public string TtsParamHead
		{
			get
			{
				return ttsParamHead;
			}
			set	
			{
				ttsParamHead = value;
				DictionaryUtil.Add(QueryParameters, "TtsParamHead", value);
			}
		}

		public string TaskName
		{
			get
			{
				return taskName;
			}
			set	
			{
				taskName = value;
				DictionaryUtil.Add(QueryParameters, "TaskName", value);
			}
		}

		public string TtsParam
		{
			get
			{
				return ttsParam;
			}
			set	
			{
				ttsParam = value;
				DictionaryUtil.Add(QueryParameters, "TtsParam", value);
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

		public string CalledShowNumber
		{
			get
			{
				return calledShowNumber;
			}
			set	
			{
				calledShowNumber = value;
				DictionaryUtil.Add(QueryParameters, "CalledShowNumber", value);
			}
		}

		public bool? IsSelfLine
		{
			get
			{
				return isSelfLine;
			}
			set	
			{
				isSelfLine = value;
				DictionaryUtil.Add(QueryParameters, "IsSelfLine", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string DialogId
		{
			get
			{
				return dialogId;
			}
			set	
			{
				dialogId = value;
				DictionaryUtil.Add(QueryParameters, "DialogId", value);
			}
		}

		public long? ScheduleTime
		{
			get
			{
				return scheduleTime;
			}
			set	
			{
				scheduleTime = value;
				DictionaryUtil.Add(QueryParameters, "ScheduleTime", value.ToString());
			}
		}

		public string CorpName
		{
			get
			{
				return corpName;
			}
			set	
			{
				corpName = value;
				DictionaryUtil.Add(QueryParameters, "CorpName", value);
			}
		}

		public bool? ScheduleCall
		{
			get
			{
				return scheduleCall;
			}
			set	
			{
				scheduleCall = value;
				DictionaryUtil.Add(QueryParameters, "ScheduleCall", value.ToString());
			}
		}

        public override BatchRobotSmartCallResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BatchRobotSmartCallResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
