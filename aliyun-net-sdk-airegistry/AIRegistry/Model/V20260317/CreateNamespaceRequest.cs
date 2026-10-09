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
using Aliyun.Acs.AIRegistry.Transform;
using Aliyun.Acs.AIRegistry.Transform.V20260317;

namespace Aliyun.Acs.AIRegistry.Model.V20260317
{
    public class CreateNamespaceRequest : RpcAcsRequest<CreateNamespaceResponse>
    {
        public CreateNamespaceRequest()
            : base("AIRegistry", "2026-03-17", "CreateNamespace", "AIRegistry", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string tags;

		private string name;

		private string description;

		private string scanPolicy;

		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string ScanPolicy
		{
			get
			{
				return scanPolicy;
			}
			set	
			{
				scanPolicy = value;
				DictionaryUtil.Add(QueryParameters, "ScanPolicy", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateNamespaceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateNamespaceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
