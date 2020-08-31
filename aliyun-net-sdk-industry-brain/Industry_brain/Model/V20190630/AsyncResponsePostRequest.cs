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
using Aliyun.Acs.industry_brain;
using Aliyun.Acs.industry_brain.Transform;
using Aliyun.Acs.industry_brain.Transform.V20190630;

namespace Aliyun.Acs.industry_brain.Model.V20190630
{
    public class AsyncResponsePostRequest : RpcAcsRequest<AsyncResponsePostResponse>
    {
        public AsyncResponsePostRequest()
            : base("industry-brain", "2019-06-30", "AsyncResponsePost")
        {
			Method = MethodType.POST;
        }

		private string data;

		private string context;

		private float? progress;

		private string message;

		private string taskId;

		private string status;

		public string Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
				DictionaryUtil.Add(QueryParameters, "Data", value);
			}
		}

		public string Context
		{
			get
			{
				return context;
			}
			set	
			{
				context = value;
				DictionaryUtil.Add(QueryParameters, "Context", value);
			}
		}

		public float? Progress
		{
			get
			{
				return progress;
			}
			set	
			{
				progress = value;
				DictionaryUtil.Add(QueryParameters, "Progress", value.ToString());
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
				DictionaryUtil.Add(QueryParameters, "Message", value);
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

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AsyncResponsePostResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AsyncResponsePostResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
