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
    public class UpdateDegradeControlRequest : RoaAcsRequest<UpdateDegradeControlResponse>
    {
        public UpdateDegradeControlRequest()
            : base("Edas", "2017-08-01", "UpdateDegradeControl", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/degradeControl";
			Method = MethodType.PUT;
        }

		private int? duration;

		private string ruleType;

		private string appId;

		private string urlVar;

		private int? rtThreshold;

		private string serviceName;

		private string ruleId;

		private string methodName;

		public int? Duration
		{
			get
			{
				return duration;
			}
			set	
			{
				duration = value;
				DictionaryUtil.Add(QueryParameters, "Duration", value.ToString());
			}
		}

		public string RuleType
		{
			get
			{
				return ruleType;
			}
			set	
			{
				ruleType = value;
				DictionaryUtil.Add(QueryParameters, "RuleType", value);
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

		public string UrlVar
		{
			get
			{
				return urlVar;
			}
			set	
			{
				urlVar = value;
				DictionaryUtil.Add(QueryParameters, "UrlVar", value);
			}
		}

		public int? RtThreshold
		{
			get
			{
				return rtThreshold;
			}
			set	
			{
				rtThreshold = value;
				DictionaryUtil.Add(QueryParameters, "RtThreshold", value.ToString());
			}
		}

		public string ServiceName
		{
			get
			{
				return serviceName;
			}
			set	
			{
				serviceName = value;
				DictionaryUtil.Add(QueryParameters, "ServiceName", value);
			}
		}

		public string RuleId
		{
			get
			{
				return ruleId;
			}
			set	
			{
				ruleId = value;
				DictionaryUtil.Add(QueryParameters, "RuleId", value);
			}
		}

		public string MethodName
		{
			get
			{
				return methodName;
			}
			set	
			{
				methodName = value;
				DictionaryUtil.Add(QueryParameters, "MethodName", value);
			}
		}

        public override UpdateDegradeControlResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateDegradeControlResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
