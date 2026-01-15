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
using Aliyun.Acs.WebsiteBuild;
using Aliyun.Acs.WebsiteBuild.Transform;
using Aliyun.Acs.WebsiteBuild.Transform.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Model.V20250429
{
    public class ModifyAppInstanceSpecRequest : RpcAcsRequest<ModifyAppInstanceSpecResponse>
    {
        public ModifyAppInstanceSpecRequest()
            : base("WebsiteBuild", "2025-04-29", "ModifyAppInstanceSpec")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string deployArea;

		private string clientToken;

		private string extend;

		private string bizId;

		private string siteVersion;

		private string applicationType;

		private string paymentType;

		[JsonProperty(PropertyName = "DeployArea")]
		public string DeployArea
		{
			get
			{
				return deployArea;
			}
			set	
			{
				deployArea = value;
				DictionaryUtil.Add(QueryParameters, "DeployArea", value);
			}
		}

		[JsonProperty(PropertyName = "ClientToken")]
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

		[JsonProperty(PropertyName = "Extend")]
		public string Extend
		{
			get
			{
				return extend;
			}
			set	
			{
				extend = value;
				DictionaryUtil.Add(QueryParameters, "Extend", value);
			}
		}

		[JsonProperty(PropertyName = "BizId")]
		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(QueryParameters, "BizId", value);
			}
		}

		[JsonProperty(PropertyName = "SiteVersion")]
		public string SiteVersion
		{
			get
			{
				return siteVersion;
			}
			set	
			{
				siteVersion = value;
				DictionaryUtil.Add(QueryParameters, "SiteVersion", value);
			}
		}

		[JsonProperty(PropertyName = "ApplicationType")]
		public string ApplicationType
		{
			get
			{
				return applicationType;
			}
			set	
			{
				applicationType = value;
				DictionaryUtil.Add(QueryParameters, "ApplicationType", value);
			}
		}

		[JsonProperty(PropertyName = "PaymentType")]
		public string PaymentType
		{
			get
			{
				return paymentType;
			}
			set	
			{
				paymentType = value;
				DictionaryUtil.Add(QueryParameters, "PaymentType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyAppInstanceSpecResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyAppInstanceSpecResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
