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
using Aliyun.Acs.Edas.Transform;
using Aliyun.Acs.Edas.Transform.V20170801;

namespace Aliyun.Acs.Edas.Model.V20170801
{
    public class DeployApplicationRequest : RoaAcsRequest<DeployApplicationResponse>
    {
        public DeployApplicationRequest()
            : base("Edas", "2017-08-01", "DeployApplication", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/changeorder/co_deploy";
			Method = MethodType.POST;
        }

		private long? buildPackId;

		private string componentIds;

		private string groupId;

		private int? batchWaitTime;

		private long? releaseType;

		private int? batch;

		private string appEnv;

		private string packageVersion;

		private bool? gray;

		private string appId;

		private string imageUrl;

		private string warUrl;

		private string trafficControlStrategy;

		private string desc;

		private string deployType;

		public long? BuildPackId
		{
			get
			{
				return buildPackId;
			}
			set	
			{
				buildPackId = value;
				DictionaryUtil.Add(QueryParameters, "BuildPackId", value.ToString());
			}
		}

		public string ComponentIds
		{
			get
			{
				return componentIds;
			}
			set	
			{
				componentIds = value;
				DictionaryUtil.Add(QueryParameters, "ComponentIds", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public int? BatchWaitTime
		{
			get
			{
				return batchWaitTime;
			}
			set	
			{
				batchWaitTime = value;
				DictionaryUtil.Add(QueryParameters, "BatchWaitTime", value.ToString());
			}
		}

		public long? ReleaseType
		{
			get
			{
				return releaseType;
			}
			set	
			{
				releaseType = value;
				DictionaryUtil.Add(QueryParameters, "ReleaseType", value.ToString());
			}
		}

		public int? Batch
		{
			get
			{
				return batch;
			}
			set	
			{
				batch = value;
				DictionaryUtil.Add(QueryParameters, "Batch", value.ToString());
			}
		}

		public string AppEnv
		{
			get
			{
				return appEnv;
			}
			set	
			{
				appEnv = value;
				DictionaryUtil.Add(QueryParameters, "AppEnv", value);
			}
		}

		public string PackageVersion
		{
			get
			{
				return packageVersion;
			}
			set	
			{
				packageVersion = value;
				DictionaryUtil.Add(QueryParameters, "PackageVersion", value);
			}
		}

		public bool? Gray
		{
			get
			{
				return gray;
			}
			set	
			{
				gray = value;
				DictionaryUtil.Add(QueryParameters, "Gray", value.ToString());
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public string ImageUrl
		{
			get
			{
				return imageUrl;
			}
			set	
			{
				imageUrl = value;
				DictionaryUtil.Add(QueryParameters, "ImageUrl", value);
			}
		}

		public string WarUrl
		{
			get
			{
				return warUrl;
			}
			set	
			{
				warUrl = value;
				DictionaryUtil.Add(QueryParameters, "WarUrl", value);
			}
		}

		public string TrafficControlStrategy
		{
			get
			{
				return trafficControlStrategy;
			}
			set	
			{
				trafficControlStrategy = value;
				DictionaryUtil.Add(QueryParameters, "TrafficControlStrategy", value);
			}
		}

		public string Desc
		{
			get
			{
				return desc;
			}
			set	
			{
				desc = value;
				DictionaryUtil.Add(QueryParameters, "Desc", value);
			}
		}

		public string DeployType
		{
			get
			{
				return deployType;
			}
			set	
			{
				deployType = value;
				DictionaryUtil.Add(QueryParameters, "DeployType", value);
			}
		}

        public override DeployApplicationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeployApplicationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
