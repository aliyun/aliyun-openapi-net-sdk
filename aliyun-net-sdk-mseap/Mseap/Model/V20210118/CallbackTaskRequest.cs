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
using Aliyun.Acs.mseap;
using Aliyun.Acs.mseap.Transform;
using Aliyun.Acs.mseap.Transform.V20210118;

namespace Aliyun.Acs.mseap.Model.V20210118
{
    public class CallbackTaskRequest : RpcAcsRequest<CallbackTaskResponse>
    {
        public CallbackTaskRequest()
            : base("mseap", "2021-01-18", "CallbackTask")
        {
			Method = MethodType.POST;
        }

		private long? userCallerParentId;

		private string outTaskId;

		private string apiType;

		private bool? userMfaPresent;

		private string userKp;

		private string lang;

		private string taskId;

		private string userCallerType;

		private string taskType;

		private string userSecurityToken;

		private string userAccessKeyId;

		private string orderId;

		private string aliyunKp;

		private string userBid;

		private string originalRequest;

		private string principalKey;

		private bool? userCallerSecurityTransport;

		private string bizCode;

		private string userClientIp;

		private string taskData;

		private string bid;

		public long? UserCallerParentId
		{
			get
			{
				return userCallerParentId;
			}
			set	
			{
				userCallerParentId = value;
				DictionaryUtil.Add(QueryParameters, "UserCallerParentId", value.ToString());
			}
		}

		public string OutTaskId
		{
			get
			{
				return outTaskId;
			}
			set	
			{
				outTaskId = value;
				DictionaryUtil.Add(QueryParameters, "OutTaskId", value);
			}
		}

		public string ApiType
		{
			get
			{
				return apiType;
			}
			set	
			{
				apiType = value;
				DictionaryUtil.Add(QueryParameters, "ApiType", value);
			}
		}

		public bool? UserMfaPresent
		{
			get
			{
				return userMfaPresent;
			}
			set	
			{
				userMfaPresent = value;
				DictionaryUtil.Add(QueryParameters, "UserMfaPresent", value.ToString());
			}
		}

		public string UserKp
		{
			get
			{
				return userKp;
			}
			set	
			{
				userKp = value;
				DictionaryUtil.Add(QueryParameters, "UserKp", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
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

		public string UserCallerType
		{
			get
			{
				return userCallerType;
			}
			set	
			{
				userCallerType = value;
				DictionaryUtil.Add(QueryParameters, "UserCallerType", value);
			}
		}

		public string TaskType
		{
			get
			{
				return taskType;
			}
			set	
			{
				taskType = value;
				DictionaryUtil.Add(QueryParameters, "TaskType", value);
			}
		}

		public string UserSecurityToken
		{
			get
			{
				return userSecurityToken;
			}
			set	
			{
				userSecurityToken = value;
				DictionaryUtil.Add(QueryParameters, "UserSecurityToken", value);
			}
		}

		public string UserAccessKeyId
		{
			get
			{
				return userAccessKeyId;
			}
			set	
			{
				userAccessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "UserAccessKeyId", value);
			}
		}

		public string OrderId
		{
			get
			{
				return orderId;
			}
			set	
			{
				orderId = value;
				DictionaryUtil.Add(QueryParameters, "OrderId", value);
			}
		}

		public string AliyunKp
		{
			get
			{
				return aliyunKp;
			}
			set	
			{
				aliyunKp = value;
				DictionaryUtil.Add(QueryParameters, "AliyunKp", value);
			}
		}

		public string UserBid
		{
			get
			{
				return userBid;
			}
			set	
			{
				userBid = value;
				DictionaryUtil.Add(QueryParameters, "UserBid", value);
			}
		}

		public string OriginalRequest
		{
			get
			{
				return originalRequest;
			}
			set	
			{
				originalRequest = value;
				DictionaryUtil.Add(QueryParameters, "OriginalRequest", value);
			}
		}

		public string PrincipalKey
		{
			get
			{
				return principalKey;
			}
			set	
			{
				principalKey = value;
				DictionaryUtil.Add(QueryParameters, "PrincipalKey", value);
			}
		}

		public bool? UserCallerSecurityTransport
		{
			get
			{
				return userCallerSecurityTransport;
			}
			set	
			{
				userCallerSecurityTransport = value;
				DictionaryUtil.Add(QueryParameters, "UserCallerSecurityTransport", value.ToString());
			}
		}

		public string BizCode
		{
			get
			{
				return bizCode;
			}
			set	
			{
				bizCode = value;
				DictionaryUtil.Add(QueryParameters, "BizCode", value);
			}
		}

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string TaskData
		{
			get
			{
				return taskData;
			}
			set	
			{
				taskData = value;
				DictionaryUtil.Add(QueryParameters, "TaskData", value);
			}
		}

		public string Bid
		{
			get
			{
				return bid;
			}
			set	
			{
				bid = value;
				DictionaryUtil.Add(QueryParameters, "Bid", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CallbackTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CallbackTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
