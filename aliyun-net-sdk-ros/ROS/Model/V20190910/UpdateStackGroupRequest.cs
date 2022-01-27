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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.ROS.Transform;
using Aliyun.Acs.ROS.Transform.V20190910;

namespace Aliyun.Acs.ROS.Model.V20190910
{
    public class UpdateStackGroupRequest : RpcAcsRequest<UpdateStackGroupResponse>
    {
        public UpdateStackGroupRequest()
            : base("ROS", "2019-09-10", "UpdateStackGroup", "ros", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ROS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ROS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string templateVersion;

		private string stackGroupName;

		private List<object> regionIds;

		private string templateId;

		private List<Parameters> parameterss = new List<Parameters>(){ };

		private string clientToken;

		private string templateBody;

		private string description;

		private string executionRoleName;

		private string templateURL;

		private string operationDescription;

		private Dictionary<object,object> operationPreferences;

		private List<object> accountIds;

		private string administrationRoleName;

		public string TemplateVersion
		{
			get
			{
				return templateVersion;
			}
			set	
			{
				templateVersion = value;
				DictionaryUtil.Add(QueryParameters, "TemplateVersion", value);
			}
		}

		public string StackGroupName
		{
			get
			{
				return stackGroupName;
			}
			set	
			{
				stackGroupName = value;
				DictionaryUtil.Add(QueryParameters, "StackGroupName", value);
			}
		}

		public List<object> RegionIds
		{
			get
			{
				return regionIds;
			}
			set	
			{
				regionIds = value;
				DictionaryUtil.Add(QueryParameters, "RegionIds", JsonConvert.SerializeObject(value));
			}
		}

		public string TemplateId
		{
			get
			{
				return templateId;
			}
			set	
			{
				templateId = value;
				DictionaryUtil.Add(QueryParameters, "TemplateId", value);
			}
		}

		public List<Parameters> Parameterss
		{
			get
			{
				return parameterss;
			}

			set
			{
				parameterss = value;
				for (int i = 0; i < parameterss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Parameters." + (i + 1) + ".ParameterValue", parameterss[i].ParameterValue);
					DictionaryUtil.Add(QueryParameters,"Parameters." + (i + 1) + ".ParameterKey", parameterss[i].ParameterKey);
				}
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

		public string TemplateBody
		{
			get
			{
				return templateBody;
			}
			set	
			{
				templateBody = value;
				DictionaryUtil.Add(QueryParameters, "TemplateBody", value);
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

		public string ExecutionRoleName
		{
			get
			{
				return executionRoleName;
			}
			set	
			{
				executionRoleName = value;
				DictionaryUtil.Add(QueryParameters, "ExecutionRoleName", value);
			}
		}

		public string TemplateURL
		{
			get
			{
				return templateURL;
			}
			set	
			{
				templateURL = value;
				DictionaryUtil.Add(QueryParameters, "TemplateURL", value);
			}
		}

		public string OperationDescription
		{
			get
			{
				return operationDescription;
			}
			set	
			{
				operationDescription = value;
				DictionaryUtil.Add(QueryParameters, "OperationDescription", value);
			}
		}

		public Dictionary<object,object> OperationPreferences
		{
			get
			{
				return operationPreferences;
			}
			set	
			{
				operationPreferences = value;
				DictionaryUtil.Add(QueryParameters, "OperationPreferences", JsonConvert.SerializeObject(value));
			}
		}

		public List<object> AccountIds
		{
			get
			{
				return accountIds;
			}
			set	
			{
				accountIds = value;
				DictionaryUtil.Add(QueryParameters, "AccountIds", JsonConvert.SerializeObject(value));
			}
		}

		public string AdministrationRoleName
		{
			get
			{
				return administrationRoleName;
			}
			set	
			{
				administrationRoleName = value;
				DictionaryUtil.Add(QueryParameters, "AdministrationRoleName", value);
			}
		}

		public class Parameters
		{

			private string parameterValue;

			private string parameterKey;

			public string ParameterValue
			{
				get
				{
					return parameterValue;
				}
				set	
				{
					parameterValue = value;
				}
			}

			public string ParameterKey
			{
				get
				{
					return parameterKey;
				}
				set	
				{
					parameterKey = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateStackGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateStackGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
