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
    public class InsertApplicationRequest : RoaAcsRequest<InsertApplicationResponse>
    {
        public InsertApplicationRequest()
            : base("Edas", "2017-08-01", "InsertApplication", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/changeorder/co_create_app";
			Method = MethodType.POST;
        }

		private string webContainer;

		private string ecuInfo;

		private int? minHeapSize;

		private int? buildPackId;

		private string componentIds;

		private string healthCheckUrl;

		private string reservedPortStr;

		private string jvmOptions;

		private string description;

		private int? cpu;

		private int? maxPermSize;

		private string clusterId;

		private int? maxHeapSize;

		private bool? enablePortCheck;

		private string applicationName;

		private string jdk;

		private int? mem;

		private string logicalRegionId;

		private bool? enableUrlCheck;

		private string packageType;

		private string hooks;

		public string WebContainer
		{
			get
			{
				return webContainer;
			}
			set	
			{
				webContainer = value;
				DictionaryUtil.Add(QueryParameters, "WebContainer", value);
			}
		}

		public string EcuInfo
		{
			get
			{
				return ecuInfo;
			}
			set	
			{
				ecuInfo = value;
				DictionaryUtil.Add(QueryParameters, "EcuInfo", value);
			}
		}

		public int? MinHeapSize
		{
			get
			{
				return minHeapSize;
			}
			set	
			{
				minHeapSize = value;
				DictionaryUtil.Add(QueryParameters, "MinHeapSize", value.ToString());
			}
		}

		public int? BuildPackId
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

		public string HealthCheckUrl
		{
			get
			{
				return healthCheckUrl;
			}
			set	
			{
				healthCheckUrl = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckUrl", value);
			}
		}

		public string ReservedPortStr
		{
			get
			{
				return reservedPortStr;
			}
			set	
			{
				reservedPortStr = value;
				DictionaryUtil.Add(QueryParameters, "ReservedPortStr", value);
			}
		}

		public string JvmOptions
		{
			get
			{
				return jvmOptions;
			}
			set	
			{
				jvmOptions = value;
				DictionaryUtil.Add(QueryParameters, "JvmOptions", value);
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

		public int? Cpu
		{
			get
			{
				return cpu;
			}
			set	
			{
				cpu = value;
				DictionaryUtil.Add(QueryParameters, "Cpu", value.ToString());
			}
		}

		public int? MaxPermSize
		{
			get
			{
				return maxPermSize;
			}
			set	
			{
				maxPermSize = value;
				DictionaryUtil.Add(QueryParameters, "MaxPermSize", value.ToString());
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public int? MaxHeapSize
		{
			get
			{
				return maxHeapSize;
			}
			set	
			{
				maxHeapSize = value;
				DictionaryUtil.Add(QueryParameters, "MaxHeapSize", value.ToString());
			}
		}

		public bool? EnablePortCheck
		{
			get
			{
				return enablePortCheck;
			}
			set	
			{
				enablePortCheck = value;
				DictionaryUtil.Add(QueryParameters, "EnablePortCheck", value.ToString());
			}
		}

		public string ApplicationName
		{
			get
			{
				return applicationName;
			}
			set	
			{
				applicationName = value;
				DictionaryUtil.Add(QueryParameters, "ApplicationName", value);
			}
		}

		public string Jdk
		{
			get
			{
				return jdk;
			}
			set	
			{
				jdk = value;
				DictionaryUtil.Add(QueryParameters, "Jdk", value);
			}
		}

		public int? Mem
		{
			get
			{
				return mem;
			}
			set	
			{
				mem = value;
				DictionaryUtil.Add(QueryParameters, "Mem", value.ToString());
			}
		}

		public string LogicalRegionId
		{
			get
			{
				return logicalRegionId;
			}
			set	
			{
				logicalRegionId = value;
				DictionaryUtil.Add(QueryParameters, "LogicalRegionId", value);
			}
		}

		public bool? EnableUrlCheck
		{
			get
			{
				return enableUrlCheck;
			}
			set	
			{
				enableUrlCheck = value;
				DictionaryUtil.Add(QueryParameters, "EnableUrlCheck", value.ToString());
			}
		}

		public string PackageType
		{
			get
			{
				return packageType;
			}
			set	
			{
				packageType = value;
				DictionaryUtil.Add(QueryParameters, "PackageType", value);
			}
		}

		public string Hooks
		{
			get
			{
				return hooks;
			}
			set	
			{
				hooks = value;
				DictionaryUtil.Add(QueryParameters, "Hooks", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override InsertApplicationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InsertApplicationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
