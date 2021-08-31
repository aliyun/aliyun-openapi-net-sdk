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
    public class ScaleoutApplicationWithNewInstancesRequest : RoaAcsRequest<ScaleoutApplicationWithNewInstancesResponse>
    {
        public ScaleoutApplicationWithNewInstancesRequest()
            : base("Edas", "2017-08-01", "ScaleoutApplicationWithNewInstances", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/scaling/scale_out";
			Method = MethodType.POST;
        }

		private int? autoRenewPeriod;

		private string templateInstanceId;

		private string groupId;

		private string instanceChargePeriodUnit;

		private string clusterId;

		private int? scalingNum;

		private string templateId;

		private string scalingPolicy;

		private string templateVersion;

		private bool? autoRenew;

		private string appId;

		private int? instanceChargePeriod;

		private string instanceChargeType;

		public int? AutoRenewPeriod
		{
			get
			{
				return autoRenewPeriod;
			}
			set	
			{
				autoRenewPeriod = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenewPeriod", value.ToString());
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

		public string InstanceChargePeriodUnit
		{
			get
			{
				return instanceChargePeriodUnit;
			}
			set	
			{
				instanceChargePeriodUnit = value;
				DictionaryUtil.Add(QueryParameters, "InstanceChargePeriodUnit", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public int? ScalingNum
		{
			get
			{
				return scalingNum;
			}
			set	
			{
				scalingNum = value;
				DictionaryUtil.Add(QueryParameters, "ScalingNum", value.ToString());
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

		public bool? AutoRenew
		{
			get
			{
				return autoRenew;
			}
			set	
			{
				autoRenew = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenew", value.ToString());
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

		public int? InstanceChargePeriod
		{
			get
			{
				return instanceChargePeriod;
			}
			set	
			{
				instanceChargePeriod = value;
				DictionaryUtil.Add(QueryParameters, "InstanceChargePeriod", value.ToString());
			}
		}

		public string InstanceChargeType
		{
			get
			{
				return instanceChargeType;
			}
			set	
			{
				instanceChargeType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceChargeType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ScaleoutApplicationWithNewInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ScaleoutApplicationWithNewInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
