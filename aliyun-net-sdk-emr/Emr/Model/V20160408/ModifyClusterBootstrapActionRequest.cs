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
    public class ModifyClusterBootstrapActionRequest : RpcAcsRequest<ModifyClusterBootstrapActionResponse>
    {
        public ModifyClusterBootstrapActionRequest()
            : base("Emr", "2016-04-08", "ModifyClusterBootstrapAction", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clusterId;

		private List<BootstrapAction> bootstrapActions = new List<BootstrapAction>(){ };

		private string id;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
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

		public List<BootstrapAction> BootstrapActions
		{
			get
			{
				return bootstrapActions;
			}

			set
			{
				bootstrapActions = value;
				for (int i = 0; i < bootstrapActions.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"BootstrapAction." + (i + 1) + ".Path", bootstrapActions[i].Path);
					DictionaryUtil.Add(QueryParameters,"BootstrapAction." + (i + 1) + ".ExecutionTarget", bootstrapActions[i].ExecutionTarget);
					DictionaryUtil.Add(QueryParameters,"BootstrapAction." + (i + 1) + ".ExecutionMoment", bootstrapActions[i].ExecutionMoment);
					DictionaryUtil.Add(QueryParameters,"BootstrapAction." + (i + 1) + ".Arg", bootstrapActions[i].Arg);
					DictionaryUtil.Add(QueryParameters,"BootstrapAction." + (i + 1) + ".Name", bootstrapActions[i].Name);
					DictionaryUtil.Add(QueryParameters,"BootstrapAction." + (i + 1) + ".ExecutionFailStrategy", bootstrapActions[i].ExecutionFailStrategy);
				}
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

		public class BootstrapAction
		{

			private string path;

			private string executionTarget;

			private string executionMoment;

			private string arg;

			private string name;

			private string executionFailStrategy;

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

			public string ExecutionTarget
			{
				get
				{
					return executionTarget;
				}
				set	
				{
					executionTarget = value;
				}
			}

			public string ExecutionMoment
			{
				get
				{
					return executionMoment;
				}
				set	
				{
					executionMoment = value;
				}
			}

			public string Arg
			{
				get
				{
					return arg;
				}
				set	
				{
					arg = value;
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
				}
			}

			public string ExecutionFailStrategy
			{
				get
				{
					return executionFailStrategy;
				}
				set	
				{
					executionFailStrategy = value;
				}
			}
		}

        public override ModifyClusterBootstrapActionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyClusterBootstrapActionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
