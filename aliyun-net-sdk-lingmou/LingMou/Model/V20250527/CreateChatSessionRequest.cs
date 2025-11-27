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
using Aliyun.Acs.LingMou;
using Aliyun.Acs.LingMou.Transform;
using Aliyun.Acs.LingMou.Transform.V20250527;

namespace Aliyun.Acs.LingMou.Model.V20250527
{
    public class CreateChatSessionRequest : RoaAcsRequest<CreateChatSessionResponse>
    {
        public CreateChatSessionRequest()
            : base("LingMou", "2025-05-27", "CreateChatSession")
        {
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/openapi/chat/init/[id]";
			Method = MethodType.POST;
        }

		private string license;

		private string instanceId;

		private string id;

		private string platform;

		public string License
		{
			get
			{
				return license;
			}
			set	
			{
				license = value;
				DictionaryUtil.Add(QueryParameters, "license", value);
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
				DictionaryUtil.Add(QueryParameters, "instanceId", value);
			}
		}

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(PathParameters, "id", value);
			}
		}

		public string Platform
		{
			get
			{
				return platform;
			}
			set	
			{
				platform = value;
				DictionaryUtil.Add(QueryParameters, "platform", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateChatSessionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateChatSessionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
