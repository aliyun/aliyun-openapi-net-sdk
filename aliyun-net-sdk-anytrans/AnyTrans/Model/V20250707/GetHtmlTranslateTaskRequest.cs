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
using Aliyun.Acs.AnyTrans;
using Aliyun.Acs.AnyTrans.Transform;
using Aliyun.Acs.AnyTrans.Transform.V20250707;

namespace Aliyun.Acs.AnyTrans.Model.V20250707
{
    public class GetHtmlTranslateTaskRequest : RoaAcsRequest<GetHtmlTranslateTaskResponse>
    {
        public GetHtmlTranslateTaskRequest()
            : base("AnyTrans", "2025-07-07", "GetHtmlTranslateTask")
        {
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/anytrans/translate/html/get";
			Method = MethodType.POST;
        }

		private string taskId;

		private string workspaceId;

		[JsonProperty(PropertyName = "taskId")]
		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(BodyParameters, "taskId", value);
			}
		}

		[JsonProperty(PropertyName = "workspaceId")]
		public string WorkspaceId
		{
			get
			{
				return workspaceId;
			}
			set	
			{
				workspaceId = value;
				DictionaryUtil.Add(BodyParameters, "workspaceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetHtmlTranslateTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetHtmlTranslateTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
