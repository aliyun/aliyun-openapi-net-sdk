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
    public class CreateDataFlowRequest : RpcAcsRequest<CreateDataFlowResponse>
    {
        public CreateDataFlowRequest()
            : base("NAS", "2017-06-26", "CreateDataFlow", "nas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string autoRefreshPolicy;

		private string fsetId;

		private string clientToken;

		private string description;

		private List<string> autoRefreshss = new List<string>(){ };

		private string sourceSecurityType;

		private string sourceStorage;

		private long? throughput;

		private string fileSystemId;

		private bool? dryRun;

		private long? autoRefreshInterval;

		private string sourceStoragePath;

		private string fileSystemPath;

		public string AutoRefreshPolicy
		{
			get
			{
				return autoRefreshPolicy;
			}
			set	
			{
				autoRefreshPolicy = value;
				DictionaryUtil.Add(QueryParameters, "AutoRefreshPolicy", value);
			}
		}

		public string FsetId
		{
			get
			{
				return fsetId;
			}
			set	
			{
				fsetId = value;
				DictionaryUtil.Add(QueryParameters, "FsetId", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
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

		public List<string> AutoRefreshss
		{
			get
			{
				return autoRefreshss;
			}

			set
			{
				autoRefreshss = value;
				if(autoRefreshss != null)
				{
					for (int depth1 = 0; depth1 < autoRefreshss.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"AutoRefreshs." + (depth1 + 1), autoRefreshss[depth1]);
					}
				}
			}
		}

		public string SourceSecurityType
		{
			get
			{
				return sourceSecurityType;
			}
			set	
			{
				sourceSecurityType = value;
				DictionaryUtil.Add(QueryParameters, "SourceSecurityType", value);
			}
		}

		public string SourceStorage
		{
			get
			{
				return sourceStorage;
			}
			set	
			{
				sourceStorage = value;
				DictionaryUtil.Add(QueryParameters, "SourceStorage", value);
			}
		}

		public long? Throughput
		{
			get
			{
				return throughput;
			}
			set	
			{
				throughput = value;
				DictionaryUtil.Add(QueryParameters, "Throughput", value.ToString());
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

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
			}
		}

		public long? AutoRefreshInterval
		{
			get
			{
				return autoRefreshInterval;
			}
			set	
			{
				autoRefreshInterval = value;
				DictionaryUtil.Add(QueryParameters, "AutoRefreshInterval", value.ToString());
			}
		}

		public string SourceStoragePath
		{
			get
			{
				return sourceStoragePath;
			}
			set	
			{
				sourceStoragePath = value;
				DictionaryUtil.Add(QueryParameters, "SourceStoragePath", value);
			}
		}

		public string FileSystemPath
		{
			get
			{
				return fileSystemPath;
			}
			set	
			{
				fileSystemPath = value;
				DictionaryUtil.Add(QueryParameters, "FileSystemPath", value);
			}
		}

		public class AutoRefreshs
		{

			private string refreshPath;

			public string RefreshPath
			{
				get
				{
					return refreshPath;
				}
				set	
				{
					refreshPath = value;
				}
			}
		}

        public override CreateDataFlowResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDataFlowResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
