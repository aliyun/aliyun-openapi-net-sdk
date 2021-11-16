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
    public class ListDeploymentsRequest : RpcAcsRequest<ListDeploymentsResponse>
    {
        public ListDeploymentsRequest()
            : base("dataworks-public", "2020-05-18", "ListDeployments")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string creator;

		private long? endCreateTime;

		private string projectIdentifier;

		private int? pageNumber;

		private string executor;

		private int? pageSize;

		private long? endExecuteTime;

		private string keyword;

		private long? projectId;

		private int? status;

		public string Creator
		{
			get
			{
				return creator;
			}
			set	
			{
				creator = value;
				DictionaryUtil.Add(BodyParameters, "Creator", value);
			}
		}

		public long? EndCreateTime
		{
			get
			{
				return endCreateTime;
			}
			set	
			{
				endCreateTime = value;
				DictionaryUtil.Add(BodyParameters, "EndCreateTime", value.ToString());
			}
		}

		public string ProjectIdentifier
		{
			get
			{
				return projectIdentifier;
			}
			set	
			{
				projectIdentifier = value;
				DictionaryUtil.Add(BodyParameters, "ProjectIdentifier", value);
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

		public string Executor
		{
			get
			{
				return executor;
			}
			set	
			{
				executor = value;
				DictionaryUtil.Add(BodyParameters, "Executor", value);
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

		public long? EndExecuteTime
		{
			get
			{
				return endExecuteTime;
			}
			set	
			{
				endExecuteTime = value;
				DictionaryUtil.Add(BodyParameters, "EndExecuteTime", value.ToString());
			}
		}

		public string Keyword
		{
			get
			{
				return keyword;
			}
			set	
			{
				keyword = value;
				DictionaryUtil.Add(BodyParameters, "Keyword", value);
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

		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(BodyParameters, "Status", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListDeploymentsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListDeploymentsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
