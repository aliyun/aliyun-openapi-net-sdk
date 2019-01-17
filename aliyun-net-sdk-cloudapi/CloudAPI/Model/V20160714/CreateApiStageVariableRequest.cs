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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CloudAPI.Transform;
using Aliyun.Acs.CloudAPI.Transform.V20160714;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
    public class CreateApiStageVariableRequest : RpcAcsRequest<CreateApiStageVariableResponse>
    {
        public CreateApiStageVariableRequest()
            : base("CloudAPI", "2016-07-14", "CreateApiStageVariable", "apigateway", "openAPI")
        {
        }

		private bool? supportRoute;

		private string securityToken;

		private string variableName;

		private string variableValue;

		private string groupId;

		private string action;

		private string stageRouteModel;

		private string accessKeyId;

		private string stageId;

		public bool? SupportRoute
		{
			get
			{
				return supportRoute;
			}
			set	
			{
				supportRoute = value;
				DictionaryUtil.Add(QueryParameters, "SupportRoute", value.ToString());
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string VariableName
		{
			get
			{
				return variableName;
			}
			set	
			{
				variableName = value;
				DictionaryUtil.Add(QueryParameters, "VariableName", value);
			}
		}

		public string VariableValue
		{
			get
			{
				return variableValue;
			}
			set	
			{
				variableValue = value;
				DictionaryUtil.Add(QueryParameters, "VariableValue", value);
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

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string StageRouteModel
		{
			get
			{
				return stageRouteModel;
			}
			set	
			{
				stageRouteModel = value;
				DictionaryUtil.Add(QueryParameters, "StageRouteModel", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string StageId
		{
			get
			{
				return stageId;
			}
			set	
			{
				stageId = value;
				DictionaryUtil.Add(QueryParameters, "StageId", value);
			}
		}

        public override CreateApiStageVariableResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateApiStageVariableResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}