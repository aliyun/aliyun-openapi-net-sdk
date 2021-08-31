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
using Aliyun.Acs.Edas.Transform;
using Aliyun.Acs.Edas.Transform.V20170801;

namespace Aliyun.Acs.Edas.Model.V20170801
{
    public class ModifyScalingRuleRequest : RoaAcsRequest<ModifyScalingRuleResponse>
    {
        public ModifyScalingRuleRequest()
            : base("Edas", "2017-08-01", "ModifyScalingRule", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/app/scaling_rules";
			Method = MethodType.POST;
        }

		private int? inStep;

		private int? outInstanceNum;

		private int? outRT;

		private int? inInstanceNum;

		private string vSwitchIds;

		private string templateInstanceId;

		private bool? acceptEULA;

		private int? outStep;

		private int? outCPU;

		private string keyPairName;

		private string password;

		private int? templateVersion;

		private string inCondition;

		private int? inRT;

		private int? inCpu;

		private int? outDuration;

		private string multiAzPolicy;

		private int? outLoad;

		private int? inLoad;

		private string groupId;

		private string resourceFrom;

		private bool? outEnable;

		private string templateId;

		private string scalingPolicy;

		private string outCondition;

		private int? inDuration;

		private bool? inEnable;

		private string appId;

		private string vpcId;

		private string templateInstanceName;

		public int? InStep
		{
			get
			{
				return inStep;
			}
			set	
			{
				inStep = value;
				DictionaryUtil.Add(QueryParameters, "InStep", value.ToString());
			}
		}

		public int? OutInstanceNum
		{
			get
			{
				return outInstanceNum;
			}
			set	
			{
				outInstanceNum = value;
				DictionaryUtil.Add(QueryParameters, "OutInstanceNum", value.ToString());
			}
		}

		public int? OutRT
		{
			get
			{
				return outRT;
			}
			set	
			{
				outRT = value;
				DictionaryUtil.Add(QueryParameters, "OutRT", value.ToString());
			}
		}

		public int? InInstanceNum
		{
			get
			{
				return inInstanceNum;
			}
			set	
			{
				inInstanceNum = value;
				DictionaryUtil.Add(QueryParameters, "InInstanceNum", value.ToString());
			}
		}

		public string VSwitchIds
		{
			get
			{
				return vSwitchIds;
			}
			set	
			{
				vSwitchIds = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchIds", value);
			}
		}

		public string TemplateInstanceId
		{
			get
			{
				return templateInstanceId;
			}
			set	
			{
				templateInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "TemplateInstanceId", value);
			}
		}

		public bool? AcceptEULA
		{
			get
			{
				return acceptEULA;
			}
			set	
			{
				acceptEULA = value;
				DictionaryUtil.Add(QueryParameters, "AcceptEULA", value.ToString());
			}
		}

		public int? OutStep
		{
			get
			{
				return outStep;
			}
			set	
			{
				outStep = value;
				DictionaryUtil.Add(QueryParameters, "OutStep", value.ToString());
			}
		}

		public int? OutCPU
		{
			get
			{
				return outCPU;
			}
			set	
			{
				outCPU = value;
				DictionaryUtil.Add(QueryParameters, "OutCPU", value.ToString());
			}
		}

		public string KeyPairName
		{
			get
			{
				return keyPairName;
			}
			set	
			{
				keyPairName = value;
				DictionaryUtil.Add(QueryParameters, "KeyPairName", value);
			}
		}

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(QueryParameters, "Password", value);
			}
		}

		public int? TemplateVersion
		{
			get
			{
				return templateVersion;
			}
			set	
			{
				templateVersion = value;
				DictionaryUtil.Add(QueryParameters, "TemplateVersion", value.ToString());
			}
		}

		public string InCondition
		{
			get
			{
				return inCondition;
			}
			set	
			{
				inCondition = value;
				DictionaryUtil.Add(QueryParameters, "InCondition", value);
			}
		}

		public int? InRT
		{
			get
			{
				return inRT;
			}
			set	
			{
				inRT = value;
				DictionaryUtil.Add(QueryParameters, "InRT", value.ToString());
			}
		}

		public int? InCpu
		{
			get
			{
				return inCpu;
			}
			set	
			{
				inCpu = value;
				DictionaryUtil.Add(QueryParameters, "InCpu", value.ToString());
			}
		}

		public int? OutDuration
		{
			get
			{
				return outDuration;
			}
			set	
			{
				outDuration = value;
				DictionaryUtil.Add(QueryParameters, "OutDuration", value.ToString());
			}
		}

		public string MultiAzPolicy
		{
			get
			{
				return multiAzPolicy;
			}
			set	
			{
				multiAzPolicy = value;
				DictionaryUtil.Add(QueryParameters, "MultiAzPolicy", value);
			}
		}

		public int? OutLoad
		{
			get
			{
				return outLoad;
			}
			set	
			{
				outLoad = value;
				DictionaryUtil.Add(QueryParameters, "OutLoad", value.ToString());
			}
		}

		public int? InLoad
		{
			get
			{
				return inLoad;
			}
			set	
			{
				inLoad = value;
				DictionaryUtil.Add(QueryParameters, "InLoad", value.ToString());
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

		public string ResourceFrom
		{
			get
			{
				return resourceFrom;
			}
			set	
			{
				resourceFrom = value;
				DictionaryUtil.Add(QueryParameters, "ResourceFrom", value);
			}
		}

		public bool? OutEnable
		{
			get
			{
				return outEnable;
			}
			set	
			{
				outEnable = value;
				DictionaryUtil.Add(QueryParameters, "OutEnable", value.ToString());
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

		public string ScalingPolicy
		{
			get
			{
				return scalingPolicy;
			}
			set	
			{
				scalingPolicy = value;
				DictionaryUtil.Add(QueryParameters, "ScalingPolicy", value);
			}
		}

		public string OutCondition
		{
			get
			{
				return outCondition;
			}
			set	
			{
				outCondition = value;
				DictionaryUtil.Add(QueryParameters, "OutCondition", value);
			}
		}

		public int? InDuration
		{
			get
			{
				return inDuration;
			}
			set	
			{
				inDuration = value;
				DictionaryUtil.Add(QueryParameters, "InDuration", value.ToString());
			}
		}

		public bool? InEnable
		{
			get
			{
				return inEnable;
			}
			set	
			{
				inEnable = value;
				DictionaryUtil.Add(QueryParameters, "InEnable", value.ToString());
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
			}
		}

		public string TemplateInstanceName
		{
			get
			{
				return templateInstanceName;
			}
			set	
			{
				templateInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "TemplateInstanceName", value);
			}
		}

        public override ModifyScalingRuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyScalingRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
