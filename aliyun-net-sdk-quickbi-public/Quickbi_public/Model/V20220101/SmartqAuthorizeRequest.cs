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
using Aliyun.Acs.quickbi_public.Transform;
using Aliyun.Acs.quickbi_public.Transform.V20220101;

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
    public class SmartqAuthorizeRequest : RpcAcsRequest<SmartqAuthorizeResponse>
    {
        public SmartqAuthorizeRequest()
            : base("quickbi-public", "2022-01-01", "SmartqAuthorize", "2.2.0", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string llmCubeThemes;

		private string llmCubes;

		private string cubeIds;

		private int? operationType;

		private string expireDay;

		private string userIds;

		public string LlmCubeThemes
		{
			get
			{
				return llmCubeThemes;
			}
			set	
			{
				llmCubeThemes = value;
				DictionaryUtil.Add(QueryParameters, "LlmCubeThemes", value);
			}
		}

		public string LlmCubes
		{
			get
			{
				return llmCubes;
			}
			set	
			{
				llmCubes = value;
				DictionaryUtil.Add(QueryParameters, "LlmCubes", value);
			}
		}

		public string CubeIds
		{
			get
			{
				return cubeIds;
			}
			set	
			{
				cubeIds = value;
				DictionaryUtil.Add(QueryParameters, "CubeIds", value);
			}
		}

		public int? OperationType
		{
			get
			{
				return operationType;
			}
			set	
			{
				operationType = value;
				DictionaryUtil.Add(QueryParameters, "OperationType", value.ToString());
			}
		}

		public string ExpireDay
		{
			get
			{
				return expireDay;
			}
			set	
			{
				expireDay = value;
				DictionaryUtil.Add(QueryParameters, "ExpireDay", value);
			}
		}

		public string UserIds
		{
			get
			{
				return userIds;
			}
			set	
			{
				userIds = value;
				DictionaryUtil.Add(QueryParameters, "UserIds", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SmartqAuthorizeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SmartqAuthorizeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
