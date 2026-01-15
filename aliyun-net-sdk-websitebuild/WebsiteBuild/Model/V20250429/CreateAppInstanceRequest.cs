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
using Aliyun.Acs.WebsiteBuild;
using Aliyun.Acs.WebsiteBuild.Transform;
using Aliyun.Acs.WebsiteBuild.Transform.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Model.V20250429
{
    public class CreateAppInstanceRequest : RpcAcsRequest<CreateAppInstanceResponse>
    {
        public CreateAppInstanceRequest()
            : base("WebsiteBuild", "2025-04-29", "CreateAppInstance")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string clientToken;

		private int? duration;

		private string siteVersion;

		private string deployArea;

		private int? quantity;

		private string extend;

		private bool? autoRenew;

		private string applicationType;

		private string pricingCycle;

		private string paymentType;

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

		public int? Quantity
		{
			get
			{
				return quantity;
			}
			set	
			{
				quantity = value;
				DictionaryUtil.Add(QueryParameters, "Quantity", value.ToString());
			}
		}

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

		public string PricingCycle
		{
			get
			{
				return pricingCycle;
			}
			set	
			{
				pricingCycle = value;
				DictionaryUtil.Add(QueryParameters, "PricingCycle", value);
			}
		}

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

        public override CreateAppInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateAppInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
