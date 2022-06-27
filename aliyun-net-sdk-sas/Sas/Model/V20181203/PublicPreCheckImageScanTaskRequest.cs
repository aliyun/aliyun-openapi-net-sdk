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
using Aliyun.Acs.Sas;
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class PublicPreCheckImageScanTaskRequest : RpcAcsRequest<PublicPreCheckImageScanTaskResponse>
    {
        public PublicPreCheckImageScanTaskRequest()
            : base("Sas", "2018-12-03", "PublicPreCheckImageScanTask")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sourceIp;

		private string digests;

		private string registryTypes;

		private string regionIds;

		private string tags;

		private string repoNamespaces;

		private string instanceIds;

		private string repoIds;

		private string repoNames;

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string Digests
		{
			get
			{
				return digests;
			}
			set	
			{
				digests = value;
				DictionaryUtil.Add(QueryParameters, "Digests", value);
			}
		}

		public string RegistryTypes
		{
			get
			{
				return registryTypes;
			}
			set	
			{
				registryTypes = value;
				DictionaryUtil.Add(QueryParameters, "RegistryTypes", value);
			}
		}

		public string RegionIds
		{
			get
			{
				return regionIds;
			}
			set	
			{
				regionIds = value;
				DictionaryUtil.Add(QueryParameters, "RegionIds", value);
			}
		}

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

		public string RepoNamespaces
		{
			get
			{
				return repoNamespaces;
			}
			set	
			{
				repoNamespaces = value;
				DictionaryUtil.Add(QueryParameters, "RepoNamespaces", value);
			}
		}

		public string InstanceIds
		{
			get
			{
				return instanceIds;
			}
			set	
			{
				instanceIds = value;
				DictionaryUtil.Add(QueryParameters, "InstanceIds", value);
			}
		}

		public string RepoIds
		{
			get
			{
				return repoIds;
			}
			set	
			{
				repoIds = value;
				DictionaryUtil.Add(QueryParameters, "RepoIds", value);
			}
		}

		public string RepoNames
		{
			get
			{
				return repoNames;
			}
			set	
			{
				repoNames = value;
				DictionaryUtil.Add(QueryParameters, "RepoNames", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override PublicPreCheckImageScanTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PublicPreCheckImageScanTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
