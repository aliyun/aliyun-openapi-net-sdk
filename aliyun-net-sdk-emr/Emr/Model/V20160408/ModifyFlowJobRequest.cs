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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class ModifyFlowJobRequest : RpcAcsRequest<ModifyFlowJobResponse>
    {
        public ModifyFlowJobRequest()
            : base("Emr", "2016-04-08", "ModifyFlowJob", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string retryPolicy;

		private string runConf;

		private string description;

		private string paramConf;

		private List<ResourceList> resourceLists = new List<ResourceList>(){ };

		private string failAct;

		private string mode;

		private string monitorConf;

		private string id;

		private int? maxRetry;

		private string alertConf;

		private string projectId;

		private string envConf;

		private long? maxRunningTimeSec;

		private string clusterId;

		private string _params;

		private string customVariables;

		private long? retryInterval;

		private string name;

		public string RetryPolicy
		{
			get
			{
				return retryPolicy;
			}
			set	
			{
				retryPolicy = value;
				DictionaryUtil.Add(QueryParameters, "RetryPolicy", value);
			}
		}

		public string RunConf
		{
			get
			{
				return runConf;
			}
			set	
			{
				runConf = value;
				DictionaryUtil.Add(QueryParameters, "RunConf", value);
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

		public string ParamConf
		{
			get
			{
				return paramConf;
			}
			set	
			{
				paramConf = value;
				DictionaryUtil.Add(QueryParameters, "ParamConf", value);
			}
		}

		public List<ResourceList> ResourceLists
		{
			get
			{
				return resourceLists;
			}

			set
			{
				resourceLists = value;
				for (int i = 0; i < resourceLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ResourceList." + (i + 1) + ".Path", resourceLists[i].Path);
					DictionaryUtil.Add(QueryParameters,"ResourceList." + (i + 1) + ".Alias", resourceLists[i].Alias);
				}
			}
		}

		public string FailAct
		{
			get
			{
				return failAct;
			}
			set	
			{
				failAct = value;
				DictionaryUtil.Add(QueryParameters, "FailAct", value);
			}
		}

		public string Mode
		{
			get
			{
				return mode;
			}
			set	
			{
				mode = value;
				DictionaryUtil.Add(QueryParameters, "Mode", value);
			}
		}

		public string MonitorConf
		{
			get
			{
				return monitorConf;
			}
			set	
			{
				monitorConf = value;
				DictionaryUtil.Add(QueryParameters, "MonitorConf", value);
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
				DictionaryUtil.Add(QueryParameters, "Id", value);
			}
		}

		public int? MaxRetry
		{
			get
			{
				return maxRetry;
			}
			set	
			{
				maxRetry = value;
				DictionaryUtil.Add(QueryParameters, "MaxRetry", value.ToString());
			}
		}

		public string AlertConf
		{
			get
			{
				return alertConf;
			}
			set	
			{
				alertConf = value;
				DictionaryUtil.Add(QueryParameters, "AlertConf", value);
			}
		}

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(QueryParameters, "ProjectId", value);
			}
		}

		public string EnvConf
		{
			get
			{
				return envConf;
			}
			set	
			{
				envConf = value;
				DictionaryUtil.Add(QueryParameters, "EnvConf", value);
			}
		}

		public long? MaxRunningTimeSec
		{
			get
			{
				return maxRunningTimeSec;
			}
			set	
			{
				maxRunningTimeSec = value;
				DictionaryUtil.Add(QueryParameters, "MaxRunningTimeSec", value.ToString());
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

		public string _Params
		{
			get
			{
				return _params;
			}
			set	
			{
				_params = value;
				DictionaryUtil.Add(QueryParameters, "Params", value);
			}
		}

		public string CustomVariables
		{
			get
			{
				return customVariables;
			}
			set	
			{
				customVariables = value;
				DictionaryUtil.Add(QueryParameters, "CustomVariables", value);
			}
		}

		public long? RetryInterval
		{
			get
			{
				return retryInterval;
			}
			set	
			{
				retryInterval = value;
				DictionaryUtil.Add(QueryParameters, "RetryInterval", value.ToString());
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

		public class ResourceList
		{

			private string path;

			private string alias;

			public string Path
			{
				get
				{
					return path;
				}
				set	
				{
					path = value;
				}
			}

			public string Alias
			{
				get
				{
					return alias;
				}
				set	
				{
					alias = value;
				}
			}
		}

        public override ModifyFlowJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyFlowJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
