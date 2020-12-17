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
using Aliyun.Acs.ROS.Transform;
using Aliyun.Acs.ROS.Transform.V20190910;

namespace Aliyun.Acs.ROS.Model.V20190910
{
    public class CreateChangeSetRequest : RpcAcsRequest<CreateChangeSetResponse>
    {
        public CreateChangeSetRequest()
            : base("ROS", "2019-09-10", "CreateChangeSet", "ros", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ROS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ROS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? timeoutInMinutes;

		private string stackPolicyDuringUpdateBody;

		private string templateVersion;

		private string stackName;

		private string changeSetType;

		private bool? disableRollback;

		private string templateId;

		private List<Parameters> parameterss = new List<Parameters>(){ };

		private string clientToken;

		private string templateBody;

		private string stackId;

		private string description;

		private string templateURL;

		private List<string> notificationURLss = new List<string>(){ };

		private List<ResourcesToImport> resourcesToImports = new List<ResourcesToImport>(){ };

		private string stackPolicyBody;

		private string stackPolicyDuringUpdateURL;

		private string ramRoleName;

		private bool? usePreviousParameters;

		private string replacementOption;

		private string stackPolicyURL;

		private string changeSetName;

		public long? TimeoutInMinutes
		{
			get
			{
				return timeoutInMinutes;
			}
			set	
			{
				timeoutInMinutes = value;
				DictionaryUtil.Add(QueryParameters, "TimeoutInMinutes", value.ToString());
			}
		}

		public string StackPolicyDuringUpdateBody
		{
			get
			{
				return stackPolicyDuringUpdateBody;
			}
			set	
			{
				stackPolicyDuringUpdateBody = value;
				DictionaryUtil.Add(QueryParameters, "StackPolicyDuringUpdateBody", value);
			}
		}

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

		public string StackName
		{
			get
			{
				return stackName;
			}
			set	
			{
				stackName = value;
				DictionaryUtil.Add(QueryParameters, "StackName", value);
			}
		}

		public string ChangeSetType
		{
			get
			{
				return changeSetType;
			}
			set	
			{
				changeSetType = value;
				DictionaryUtil.Add(QueryParameters, "ChangeSetType", value);
			}
		}

		public bool? DisableRollback
		{
			get
			{
				return disableRollback;
			}
			set	
			{
				disableRollback = value;
				DictionaryUtil.Add(QueryParameters, "DisableRollback", value.ToString());
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

		public string StackId
		{
			get
			{
				return stackId;
			}
			set	
			{
				stackId = value;
				DictionaryUtil.Add(QueryParameters, "StackId", value);
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

		public List<string> NotificationURLss
		{
			get
			{
				return notificationURLss;
			}

			set
			{
				notificationURLss = value;
				for (int i = 0; i < notificationURLss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"NotificationURLs." + (i + 1) , notificationURLss[i]);
				}
			}
		}

		public List<ResourcesToImport> ResourcesToImports
		{
			get
			{
				return resourcesToImports;
			}

			set
			{
				resourcesToImports = value;
				for (int i = 0; i < resourcesToImports.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ResourcesToImport." + (i + 1) + ".ResourceIdentifier", resourcesToImports[i].ResourceIdentifier);
					DictionaryUtil.Add(QueryParameters,"ResourcesToImport." + (i + 1) + ".LogicalResourceId", resourcesToImports[i].LogicalResourceId);
					DictionaryUtil.Add(QueryParameters,"ResourcesToImport." + (i + 1) + ".ResourceType", resourcesToImports[i].ResourceType);
				}
			}
		}

		public string StackPolicyBody
		{
			get
			{
				return stackPolicyBody;
			}
			set	
			{
				stackPolicyBody = value;
				DictionaryUtil.Add(QueryParameters, "StackPolicyBody", value);
			}
		}

		public string StackPolicyDuringUpdateURL
		{
			get
			{
				return stackPolicyDuringUpdateURL;
			}
			set	
			{
				stackPolicyDuringUpdateURL = value;
				DictionaryUtil.Add(QueryParameters, "StackPolicyDuringUpdateURL", value);
			}
		}

		public string RamRoleName
		{
			get
			{
				return ramRoleName;
			}
			set	
			{
				ramRoleName = value;
				DictionaryUtil.Add(QueryParameters, "RamRoleName", value);
			}
		}

		public bool? UsePreviousParameters
		{
			get
			{
				return usePreviousParameters;
			}
			set	
			{
				usePreviousParameters = value;
				DictionaryUtil.Add(QueryParameters, "UsePreviousParameters", value.ToString());
			}
		}

		public string ReplacementOption
		{
			get
			{
				return replacementOption;
			}
			set	
			{
				replacementOption = value;
				DictionaryUtil.Add(QueryParameters, "ReplacementOption", value);
			}
		}

		public string StackPolicyURL
		{
			get
			{
				return stackPolicyURL;
			}
			set	
			{
				stackPolicyURL = value;
				DictionaryUtil.Add(QueryParameters, "StackPolicyURL", value);
			}
		}

		public string ChangeSetName
		{
			get
			{
				return changeSetName;
			}
			set	
			{
				changeSetName = value;
				DictionaryUtil.Add(QueryParameters, "ChangeSetName", value);
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

		public class ResourcesToImport
		{

			private string resourceIdentifier;

			private string logicalResourceId;

			private string resourceType;

			public string ResourceIdentifier
			{
				get
				{
					return resourceIdentifier;
				}
				set	
				{
					resourceIdentifier = value;
				}
			}

			public string LogicalResourceId
			{
				get
				{
					return logicalResourceId;
				}
				set	
				{
					logicalResourceId = value;
				}
			}

			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateChangeSetResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateChangeSetResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
