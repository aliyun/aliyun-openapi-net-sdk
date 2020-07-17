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
using Aliyun.Acs.devops_rdc;
using Aliyun.Acs.devops_rdc.Transform;
using Aliyun.Acs.devops_rdc.Transform.V20200303;

namespace Aliyun.Acs.devops_rdc.Model.V20200303
{
    public class ListPipelinesRequest : RpcAcsRequest<ListPipelinesResponse>
    {
        public ListPipelinesRequest()
            : base("devops-rdc", "2020-03-03", "ListPipelines")
        {
			Method = MethodType.POST;
        }

		private string pipelineName;

		private string resultStatusList;

		private string creators;

		private string executeEndTime;

		private string userPk;

		private string orgId;

		private string createStartTime;

		private string operators;

		private int? pageSize;

		private string executeStartTime;

		private int? pageStart;

		private string createEndTime;

		public string PipelineName
		{
			get
			{
				return pipelineName;
			}
			set	
			{
				pipelineName = value;
				DictionaryUtil.Add(BodyParameters, "PipelineName", value);
			}
		}

		public string ResultStatusList
		{
			get
			{
				return resultStatusList;
			}
			set	
			{
				resultStatusList = value;
				DictionaryUtil.Add(BodyParameters, "ResultStatusList", value);
			}
		}

		public string Creators
		{
			get
			{
				return creators;
			}
			set	
			{
				creators = value;
				DictionaryUtil.Add(BodyParameters, "Creators", value);
			}
		}

		public string ExecuteEndTime
		{
			get
			{
				return executeEndTime;
			}
			set	
			{
				executeEndTime = value;
				DictionaryUtil.Add(BodyParameters, "ExecuteEndTime", value);
			}
		}

		public string UserPk
		{
			get
			{
				return userPk;
			}
			set	
			{
				userPk = value;
				DictionaryUtil.Add(BodyParameters, "UserPk", value);
			}
		}

		public string OrgId
		{
			get
			{
				return orgId;
			}
			set	
			{
				orgId = value;
				DictionaryUtil.Add(QueryParameters, "OrgId", value);
			}
		}

		public string CreateStartTime
		{
			get
			{
				return createStartTime;
			}
			set	
			{
				createStartTime = value;
				DictionaryUtil.Add(BodyParameters, "CreateStartTime", value);
			}
		}

		public string Operators
		{
			get
			{
				return operators;
			}
			set	
			{
				operators = value;
				DictionaryUtil.Add(BodyParameters, "Operators", value);
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

		public string ExecuteStartTime
		{
			get
			{
				return executeStartTime;
			}
			set	
			{
				executeStartTime = value;
				DictionaryUtil.Add(BodyParameters, "ExecuteStartTime", value);
			}
		}

		public int? PageStart
		{
			get
			{
				return pageStart;
			}
			set	
			{
				pageStart = value;
				DictionaryUtil.Add(BodyParameters, "PageStart", value.ToString());
			}
		}

		public string CreateEndTime
		{
			get
			{
				return createEndTime;
			}
			set	
			{
				createEndTime = value;
				DictionaryUtil.Add(BodyParameters, "CreateEndTime", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListPipelinesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListPipelinesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
