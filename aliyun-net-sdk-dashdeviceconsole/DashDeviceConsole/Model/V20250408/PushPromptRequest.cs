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
using Aliyun.Acs.DashDeviceConsole;
using Aliyun.Acs.DashDeviceConsole.Transform;
using Aliyun.Acs.DashDeviceConsole.Transform.V20250408;

namespace Aliyun.Acs.DashDeviceConsole.Model.V20250408
{
    public class PushPromptRequest : RoaAcsRequest<PushPromptResponse>
    {
        public PushPromptRequest()
            : base("DashDeviceConsole", "2025-04-08", "PushPrompt")
        {
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/prompt/push";
			Method = MethodType.POST;
        }

		private string groupId;

		private string promptContent;

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "groupId", value);
			}
		}

		public string PromptContent
		{
			get
			{
				return promptContent;
			}
			set	
			{
				promptContent = value;
				DictionaryUtil.Add(BodyParameters, "promptContent", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override PushPromptResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PushPromptResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
