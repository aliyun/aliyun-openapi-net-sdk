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
using Aliyun.Acs.Green.Transform;
using Aliyun.Acs.Green.Transform.V20170823;

namespace Aliyun.Acs.Green.Model.V20170823
{
    public class UpdateOssCallbackSettingRequest : RpcAcsRequest<UpdateOssCallbackSettingResponse>
    {
        public UpdateOssCallbackSettingRequest()
            : base("Green", "2017-08-23", "UpdateOssCallbackSetting", "green", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string scanCallbackSuggestions;

		private string callbackSeed;

		private string serviceModules;

		private bool? auditCallback;

		private bool? scanCallback;

		private string callbackUrl;

		public string ScanCallbackSuggestions
		{
			get
			{
				return scanCallbackSuggestions;
			}
			set	
			{
				scanCallbackSuggestions = value;
				DictionaryUtil.Add(QueryParameters, "ScanCallbackSuggestions", value);
			}
		}

		public string CallbackSeed
		{
			get
			{
				return callbackSeed;
			}
			set	
			{
				callbackSeed = value;
				DictionaryUtil.Add(QueryParameters, "CallbackSeed", value);
			}
		}

		public string ServiceModules
		{
			get
			{
				return serviceModules;
			}
			set	
			{
				serviceModules = value;
				DictionaryUtil.Add(QueryParameters, "ServiceModules", value);
			}
		}

		public bool? AuditCallback
		{
			get
			{
				return auditCallback;
			}
			set	
			{
				auditCallback = value;
				DictionaryUtil.Add(QueryParameters, "AuditCallback", value.ToString());
			}
		}

		public bool? ScanCallback
		{
			get
			{
				return scanCallback;
			}
			set	
			{
				scanCallback = value;
				DictionaryUtil.Add(QueryParameters, "ScanCallback", value.ToString());
			}
		}

		public string CallbackUrl
		{
			get
			{
				return callbackUrl;
			}
			set	
			{
				callbackUrl = value;
				DictionaryUtil.Add(QueryParameters, "CallbackUrl", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateOssCallbackSettingResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateOssCallbackSettingResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
