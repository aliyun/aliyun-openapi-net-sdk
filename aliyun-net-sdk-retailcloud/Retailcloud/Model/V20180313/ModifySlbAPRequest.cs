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
using Aliyun.Acs.retailcloud.Transform;
using Aliyun.Acs.retailcloud.Transform.V20180313;

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
    public class ModifySlbAPRequest : RpcAcsRequest<ModifySlbAPResponse>
    {
        public ModifySlbAPRequest()
            : base("retailcloud", "2018-03-13", "ModifySlbAP", "retailcloud", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sslCertId;

		private int? establishedTimeout;

		private int? realServerPort;

		private int? stickySession;

		private int? cookieTimeout;

		private string name;

		private long? slbAPId;

		public string SslCertId
		{
			get
			{
				return sslCertId;
			}
			set	
			{
				sslCertId = value;
				DictionaryUtil.Add(QueryParameters, "SslCertId", value);
			}
		}

		public int? EstablishedTimeout
		{
			get
			{
				return establishedTimeout;
			}
			set	
			{
				establishedTimeout = value;
				DictionaryUtil.Add(QueryParameters, "EstablishedTimeout", value.ToString());
			}
		}

		public int? RealServerPort
		{
			get
			{
				return realServerPort;
			}
			set	
			{
				realServerPort = value;
				DictionaryUtil.Add(QueryParameters, "RealServerPort", value.ToString());
			}
		}

		public int? StickySession
		{
			get
			{
				return stickySession;
			}
			set	
			{
				stickySession = value;
				DictionaryUtil.Add(QueryParameters, "StickySession", value.ToString());
			}
		}

		public int? CookieTimeout
		{
			get
			{
				return cookieTimeout;
			}
			set	
			{
				cookieTimeout = value;
				DictionaryUtil.Add(QueryParameters, "CookieTimeout", value.ToString());
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public long? SlbAPId
		{
			get
			{
				return slbAPId;
			}
			set	
			{
				slbAPId = value;
				DictionaryUtil.Add(QueryParameters, "SlbAPId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifySlbAPResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifySlbAPResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
