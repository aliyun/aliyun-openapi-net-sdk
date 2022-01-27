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
using Aliyun.Acs.dataworks_public;
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class ListInstancesRequest : RpcAcsRequest<ListInstancesResponse>
    {
        public ListInstancesRequest()
            : base("dataworks-public", "2020-05-18", "ListInstances")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string projectEnv;

		private string owner;

		private string bizName;

		private string beginBizdate;

		private string endBizdate;

		private long? dagId;

		private int? pageNumber;

		private string nodeName;

		private string programType;

		private string bizdate;

		private int? pageSize;

		private long? nodeId;

		private long? projectId;

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

		public string Owner
		{
			get
			{
				return owner;
			}
			set	
			{
				owner = value;
				DictionaryUtil.Add(BodyParameters, "Owner", value);
			}
		}

		public string BizName
		{
			get
			{
				return bizName;
			}
			set	
			{
				bizName = value;
				DictionaryUtil.Add(BodyParameters, "BizName", value);
			}
		}

		public string BeginBizdate
		{
			get
			{
				return beginBizdate;
			}
			set	
			{
				beginBizdate = value;
				DictionaryUtil.Add(BodyParameters, "BeginBizdate", value);
			}
		}

		public string EndBizdate
		{
			get
			{
				return endBizdate;
			}
			set	
			{
				endBizdate = value;
				DictionaryUtil.Add(BodyParameters, "EndBizdate", value);
			}
		}

		public long? DagId
		{
			get
			{
				return dagId;
			}
			set	
			{
				dagId = value;
				DictionaryUtil.Add(BodyParameters, "DagId", value.ToString());
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		public string NodeName
		{
			get
			{
				return nodeName;
			}
			set	
			{
				nodeName = value;
				DictionaryUtil.Add(BodyParameters, "NodeName", value);
			}
		}

		public string ProgramType
		{
			get
			{
				return programType;
			}
			set	
			{
				programType = value;
				DictionaryUtil.Add(BodyParameters, "ProgramType", value);
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

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
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

		public long? ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(BodyParameters, "ProjectId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
