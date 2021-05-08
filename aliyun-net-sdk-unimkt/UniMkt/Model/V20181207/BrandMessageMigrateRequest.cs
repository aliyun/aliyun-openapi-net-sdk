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
using Aliyun.Acs.UniMkt.Transform;
using Aliyun.Acs.UniMkt.Transform.V20181207;

namespace Aliyun.Acs.UniMkt.Model.V20181207
{
    public class BrandMessageMigrateRequest : RpcAcsRequest<BrandMessageMigrateResponse>
    {
        public BrandMessageMigrateRequest()
            : base("UniMkt", "2018-12-07", "BrandMessageMigrate", "uniMkt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string brandUserId;

		private string brandUserNick;

		private string industry;

		private string proxyUserId;

		private string userId;

		private string contactName;

		private string accountNo;

		private string company;

		private string proxyUserNick;

		private string contactPhone;

		public string BrandUserId
		{
			get
			{
				return brandUserId;
			}
			set	
			{
				brandUserId = value;
				DictionaryUtil.Add(BodyParameters, "BrandUserId", value);
			}
		}

		public string BrandUserNick
		{
			get
			{
				return brandUserNick;
			}
			set	
			{
				brandUserNick = value;
				DictionaryUtil.Add(BodyParameters, "BrandUserNick", value);
			}
		}

		public string Industry
		{
			get
			{
				return industry;
			}
			set	
			{
				industry = value;
				DictionaryUtil.Add(BodyParameters, "Industry", value);
			}
		}

		public string ProxyUserId
		{
			get
			{
				return proxyUserId;
			}
			set	
			{
				proxyUserId = value;
				DictionaryUtil.Add(BodyParameters, "ProxyUserId", value);
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(BodyParameters, "UserId", value);
			}
		}

		public string ContactName
		{
			get
			{
				return contactName;
			}
			set	
			{
				contactName = value;
				DictionaryUtil.Add(BodyParameters, "ContactName", value);
			}
		}

		public string AccountNo
		{
			get
			{
				return accountNo;
			}
			set	
			{
				accountNo = value;
				DictionaryUtil.Add(BodyParameters, "AccountNo", value);
			}
		}

		public string Company
		{
			get
			{
				return company;
			}
			set	
			{
				company = value;
				DictionaryUtil.Add(BodyParameters, "Company", value);
			}
		}

		public string ProxyUserNick
		{
			get
			{
				return proxyUserNick;
			}
			set	
			{
				proxyUserNick = value;
				DictionaryUtil.Add(BodyParameters, "ProxyUserNick", value);
			}
		}

		public string ContactPhone
		{
			get
			{
				return contactPhone;
			}
			set	
			{
				contactPhone = value;
				DictionaryUtil.Add(BodyParameters, "ContactPhone", value);
			}
		}

        public override BrandMessageMigrateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BrandMessageMigrateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
