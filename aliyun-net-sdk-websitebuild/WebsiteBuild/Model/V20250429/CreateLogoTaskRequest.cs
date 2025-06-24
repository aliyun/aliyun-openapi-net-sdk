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
using Aliyun.Acs.WebsiteBuild;
using Aliyun.Acs.WebsiteBuild.Transform;
using Aliyun.Acs.WebsiteBuild.Transform.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Model.V20250429
{
    public class CreateLogoTaskRequest : RpcAcsRequest<CreateLogoTaskResponse>
    {
        public CreateLogoTaskRequest()
            : base("WebsiteBuild", "2025-04-29", "CreateLogoTask")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string negativePrompt;

		private string version;

		private string prompt;

		private string parameters;

		public string NegativePrompt
		{
			get
			{
				return negativePrompt;
			}
			set	
			{
				negativePrompt = value;
				DictionaryUtil.Add(QueryParameters, "NegativePrompt", value);
			}
		}

		public string Version
		{
			get
			{
				return version;
			}
			set	
			{
				version = value;
				DictionaryUtil.Add(QueryParameters, "Version", value);
			}
		}

		public string Prompt
		{
			get
			{
				return prompt;
			}
			set	
			{
				prompt = value;
				DictionaryUtil.Add(QueryParameters, "Prompt", value);
			}
		}

		public string Parameters
		{
			get
			{
				return parameters;
			}
			set	
			{
				parameters = value;
				DictionaryUtil.Add(QueryParameters, "Parameters", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateLogoTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateLogoTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
