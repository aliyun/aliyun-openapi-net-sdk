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
using Aliyun.Acs.Cloudauth.Transform;
using Aliyun.Acs.Cloudauth.Transform.V20190307;

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
    public class InitDeviceRequest : RpcAcsRequest<InitDeviceResponse>
    {
        public InitDeviceRequest()
            : base("Cloudauth", "2019-03-07", "InitDevice", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string channel;

		private string bizData;

		private string merchant;

		private string appVersion;

		private string deviceToken;

		private string certifyId;

		private string webUmidToken;

		private string outerOrderNo;

		private string produceNode;

		private string uaToken;

		private string productName;

		private string certifyPrincipal;

		private string metaInfo;

		public string Channel
		{
			get
			{
				return channel;
			}
			set	
			{
				channel = value;
				DictionaryUtil.Add(QueryParameters, "Channel", value);
			}
		}

		public string BizData
		{
			get
			{
				return bizData;
			}
			set	
			{
				bizData = value;
				DictionaryUtil.Add(QueryParameters, "BizData", value);
			}
		}

		public string Merchant
		{
			get
			{
				return merchant;
			}
			set	
			{
				merchant = value;
				DictionaryUtil.Add(QueryParameters, "Merchant", value);
			}
		}

		public string AppVersion
		{
			get
			{
				return appVersion;
			}
			set	
			{
				appVersion = value;
				DictionaryUtil.Add(QueryParameters, "AppVersion", value);
			}
		}

		public string DeviceToken
		{
			get
			{
				return deviceToken;
			}
			set	
			{
				deviceToken = value;
				DictionaryUtil.Add(QueryParameters, "DeviceToken", value);
			}
		}

		public string CertifyId
		{
			get
			{
				return certifyId;
			}
			set	
			{
				certifyId = value;
				DictionaryUtil.Add(QueryParameters, "CertifyId", value);
			}
		}

		public string WebUmidToken
		{
			get
			{
				return webUmidToken;
			}
			set	
			{
				webUmidToken = value;
				DictionaryUtil.Add(BodyParameters, "WebUmidToken", value);
			}
		}

		public string OuterOrderNo
		{
			get
			{
				return outerOrderNo;
			}
			set	
			{
				outerOrderNo = value;
				DictionaryUtil.Add(QueryParameters, "OuterOrderNo", value);
			}
		}

		public string ProduceNode
		{
			get
			{
				return produceNode;
			}
			set	
			{
				produceNode = value;
				DictionaryUtil.Add(QueryParameters, "ProduceNode", value);
			}
		}

		public string UaToken
		{
			get
			{
				return uaToken;
			}
			set	
			{
				uaToken = value;
				DictionaryUtil.Add(BodyParameters, "UaToken", value);
			}
		}

		public string ProductName
		{
			get
			{
				return productName;
			}
			set	
			{
				productName = value;
				DictionaryUtil.Add(QueryParameters, "ProductName", value);
			}
		}

		public string CertifyPrincipal
		{
			get
			{
				return certifyPrincipal;
			}
			set	
			{
				certifyPrincipal = value;
				DictionaryUtil.Add(QueryParameters, "CertifyPrincipal", value);
			}
		}

		public string MetaInfo
		{
			get
			{
				return metaInfo;
			}
			set	
			{
				metaInfo = value;
				DictionaryUtil.Add(QueryParameters, "MetaInfo", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override InitDeviceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InitDeviceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
