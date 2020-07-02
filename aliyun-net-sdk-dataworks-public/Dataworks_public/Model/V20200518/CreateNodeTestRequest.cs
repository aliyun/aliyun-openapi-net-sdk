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
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class CreateNodeTestRequest : RpcAcsRequest<CreateNodeTestResponse>
    {
        public CreateNodeTestRequest()
            : base("dataworks-public", "2020-05-18", "CreateNodeTest", "dide", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string projectEnv;

		private bool? parallelism;

		private string bizBeginTime;

		private string includeNodeIds;

		private string bizdate;

		private string bizEndTime;

		private string name;

		private string excludeNodeIds;

		private long? nodeId;

		private long? nodeProjectId;

		public string ProjectEnv
		{
			get
			{
				return projectEnv;
			}
			set	
			{
				projectEnv = value;
				DictionaryUtil.Add(BodyParameters, "ProjectEnv", value);
			}
		}

		public bool? Parallelism
		{
			get
			{
				return parallelism;
			}
			set	
			{
				parallelism = value;
				DictionaryUtil.Add(BodyParameters, "Parallelism", value.ToString());
			}
		}

		public string BizBeginTime
		{
			get
			{
				return bizBeginTime;
			}
			set	
			{
				bizBeginTime = value;
				DictionaryUtil.Add(BodyParameters, "BizBeginTime", value);
			}
		}

		public string IncludeNodeIds
		{
			get
			{
				return includeNodeIds;
			}
			set	
			{
				includeNodeIds = value;
				DictionaryUtil.Add(BodyParameters, "IncludeNodeIds", value);
			}
		}

		public string Bizdate
		{
			get
			{
				return bizdate;
			}
			set	
			{
				bizdate = value;
				DictionaryUtil.Add(BodyParameters, "Bizdate", value);
			}
		}

		public string BizEndTime
		{
			get
			{
				return bizEndTime;
			}
			set	
			{
				bizEndTime = value;
				DictionaryUtil.Add(BodyParameters, "BizEndTime", value);
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
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		public string ExcludeNodeIds
		{
			get
			{
				return excludeNodeIds;
			}
			set	
			{
				excludeNodeIds = value;
				DictionaryUtil.Add(BodyParameters, "ExcludeNodeIds", value);
			}
		}

		public long? NodeId
		{
			get
			{
				return nodeId;
			}
			set	
			{
				nodeId = value;
				DictionaryUtil.Add(BodyParameters, "NodeId", value.ToString());
			}
		}

		public long? NodeProjectId
		{
			get
			{
				return nodeProjectId;
			}
			set	
			{
				nodeProjectId = value;
				DictionaryUtil.Add(BodyParameters, "NodeProjectId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateNodeTestResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateNodeTestResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
