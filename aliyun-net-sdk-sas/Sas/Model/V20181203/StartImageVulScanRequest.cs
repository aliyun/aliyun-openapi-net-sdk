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
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class StartImageVulScanRequest : RpcAcsRequest<StartImageVulScanResponse>
    {
        public StartImageVulScanRequest()
            : base("Sas", "2018-12-03", "StartImageVulScan", "sas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string repoId;

		private string repoNamespace;

		private string imageDigest;

		private string repName;

		private string lang;

		private string imageTag;

		private List<string> registryTypess = new List<string>(){ };

		private string repoInstanceId;

		private string imageLayer;

		private string repoRegionId;

		public string RepoId
		{
			get
			{
				return repoId;
			}
			set	
			{
				repoId = value;
				DictionaryUtil.Add(QueryParameters, "RepoId", value);
			}
		}

		public string RepoNamespace
		{
			get
			{
				return repoNamespace;
			}
			set	
			{
				repoNamespace = value;
				DictionaryUtil.Add(QueryParameters, "RepoNamespace", value);
			}
		}

		public string ImageDigest
		{
			get
			{
				return imageDigest;
			}
			set	
			{
				imageDigest = value;
				DictionaryUtil.Add(QueryParameters, "ImageDigest", value);
			}
		}

		public string RepName
		{
			get
			{
				return repName;
			}
			set	
			{
				repName = value;
				DictionaryUtil.Add(QueryParameters, "RepName", value);
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

		public string ImageTag
		{
			get
			{
				return imageTag;
			}
			set	
			{
				imageTag = value;
				DictionaryUtil.Add(QueryParameters, "ImageTag", value);
			}
		}

		public List<string> RegistryTypess
		{
			get
			{
				return registryTypess;
			}

			set
			{
				registryTypess = value;
				for (int i = 0; i < registryTypess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RegistryTypes." + (i + 1) , registryTypess[i]);
				}
			}
		}

		public string RepoInstanceId
		{
			get
			{
				return repoInstanceId;
			}
			set	
			{
				repoInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "RepoInstanceId", value);
			}
		}

		public string ImageLayer
		{
			get
			{
				return imageLayer;
			}
			set	
			{
				imageLayer = value;
				DictionaryUtil.Add(QueryParameters, "ImageLayer", value);
			}
		}

		public string RepoRegionId
		{
			get
			{
				return repoRegionId;
			}
			set	
			{
				repoRegionId = value;
				DictionaryUtil.Add(QueryParameters, "RepoRegionId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override StartImageVulScanResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StartImageVulScanResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
