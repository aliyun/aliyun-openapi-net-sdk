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
using Aliyun.Acs.sae.Transform;
using Aliyun.Acs.sae.Transform.V20190506;

namespace Aliyun.Acs.sae.Model.V20190506
{
    public class CreateApplicationScalingRuleRequest : RoaAcsRequest<CreateApplicationScalingRuleResponse>
    {
        public CreateApplicationScalingRuleRequest()
            : base("sae", "2019-05-06", "CreateApplicationScalingRule", "serverless", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v1/sam/scale/applicationScalingRule";
			Method = MethodType.POST;
        }

		private string scalingRuleName;

		private int? minReadyInstances;

		private bool? scalingRuleEnable;

		private string scalingRuleTimer;

		private string scalingRuleMetric;

		private string appId;

		private int? minReadyInstanceRatio;

		private string scalingRuleType;

		public string ScalingRuleName
		{
			get
			{
				return scalingRuleName;
			}
			set	
			{
				scalingRuleName = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleName", value);
			}
		}

		public int? MinReadyInstances
		{
			get
			{
				return minReadyInstances;
			}
			set	
			{
				minReadyInstances = value;
				DictionaryUtil.Add(QueryParameters, "MinReadyInstances", value.ToString());
			}
		}

		public bool? ScalingRuleEnable
		{
			get
			{
				return scalingRuleEnable;
			}
			set	
			{
				scalingRuleEnable = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleEnable", value.ToString());
			}
		}

		public string ScalingRuleTimer
		{
			get
			{
				return scalingRuleTimer;
			}
			set	
			{
				scalingRuleTimer = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleTimer", value);
			}
		}

		public string ScalingRuleMetric
		{
			get
			{
				return scalingRuleMetric;
			}
			set	
			{
				scalingRuleMetric = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleMetric", value);
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

		public int? MinReadyInstanceRatio
		{
			get
			{
				return minReadyInstanceRatio;
			}
			set	
			{
				minReadyInstanceRatio = value;
				DictionaryUtil.Add(QueryParameters, "MinReadyInstanceRatio", value.ToString());
			}
		}

		public string ScalingRuleType
		{
			get
			{
				return scalingRuleType;
			}
			set	
			{
				scalingRuleType = value;
				DictionaryUtil.Add(QueryParameters, "ScalingRuleType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateApplicationScalingRuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateApplicationScalingRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
