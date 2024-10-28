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
using Aliyun.Acs.NAS.Transform;
using Aliyun.Acs.NAS.Transform.V20170626;

namespace Aliyun.Acs.NAS.Model.V20170626
{
    public class CreateLifecyclePolicyRequest : RpcAcsRequest<CreateLifecyclePolicyResponse>
    {
        public CreateLifecyclePolicyRequest()
            : base("NAS", "2017-06-26", "CreateLifecyclePolicy", "nas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
			Method = MethodType.PUT;
        }

		private string storageType;

		private string path;

		private string lifecyclePolicyName;

		private string fileSystemId;

		private string lifecycleRuleName;

		private List<string> pathss = new List<string>(){ };

		public string StorageType
		{
			get
			{
				return storageType;
			}
			set	
			{
				storageType = value;
				DictionaryUtil.Add(QueryParameters, "StorageType", value);
			}
		}

		public string Path
		{
			get
			{
				return path;
			}
			set	
			{
				path = value;
				DictionaryUtil.Add(QueryParameters, "Path", value);
			}
		}

		public string LifecyclePolicyName
		{
			get
			{
				return lifecyclePolicyName;
			}
			set	
			{
				lifecyclePolicyName = value;
				DictionaryUtil.Add(QueryParameters, "LifecyclePolicyName", value);
			}
		}

		public string FileSystemId
		{
			get
			{
				return fileSystemId;
			}
			set	
			{
				fileSystemId = value;
				DictionaryUtil.Add(QueryParameters, "FileSystemId", value);
			}
		}

		public string LifecycleRuleName
		{
			get
			{
				return lifecycleRuleName;
			}
			set	
			{
				lifecycleRuleName = value;
				DictionaryUtil.Add(QueryParameters, "LifecycleRuleName", value);
			}
		}

		public List<string> Pathss
		{
			get
			{
				return pathss;
			}

			set
			{
				pathss = value;
			}
		}

        public override CreateLifecyclePolicyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateLifecyclePolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
