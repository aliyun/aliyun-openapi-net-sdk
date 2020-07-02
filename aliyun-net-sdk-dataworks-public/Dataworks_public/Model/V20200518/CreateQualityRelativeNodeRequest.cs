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
    public class CreateQualityRelativeNodeRequest : RpcAcsRequest<CreateQualityRelativeNodeResponse>
    {
        public CreateQualityRelativeNodeRequest()
            : base("dataworks-public", "2020-05-18", "CreateQualityRelativeNode", "dide", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string projectName;

		private long? targetNodeProjectId;

		private string matchExpression;

		private string envType;

		private string targetNodeProjectName;

		private string tableName;

		private long? nodeId;

		private long? projectId;

		public string ProjectName
		{
			get
			{
				return projectName;
			}
			set	
			{
				projectName = value;
				DictionaryUtil.Add(BodyParameters, "ProjectName", value);
			}
		}

		public long? TargetNodeProjectId
		{
			get
			{
				return targetNodeProjectId;
			}
			set	
			{
				targetNodeProjectId = value;
				DictionaryUtil.Add(BodyParameters, "TargetNodeProjectId", value.ToString());
			}
		}

		public string MatchExpression
		{
			get
			{
				return matchExpression;
			}
			set	
			{
				matchExpression = value;
				DictionaryUtil.Add(BodyParameters, "MatchExpression", value);
			}
		}

		public string EnvType
		{
			get
			{
				return envType;
			}
			set	
			{
				envType = value;
				DictionaryUtil.Add(BodyParameters, "EnvType", value);
			}
		}

		public string TargetNodeProjectName
		{
			get
			{
				return targetNodeProjectName;
			}
			set	
			{
				targetNodeProjectName = value;
				DictionaryUtil.Add(BodyParameters, "TargetNodeProjectName", value);
			}
		}

		public string TableName
		{
			get
			{
				return tableName;
			}
			set	
			{
				tableName = value;
				DictionaryUtil.Add(BodyParameters, "TableName", value);
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

        public override CreateQualityRelativeNodeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateQualityRelativeNodeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
