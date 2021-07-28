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
    public class CreateSlbAPRequest : RpcAcsRequest<CreateSlbAPResponse>
    {
        public CreateSlbAPRequest()
            : base("retailcloud", "2018-03-13", "CreateSlbAP", "retailcloud", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sslCertId;

		private int? listenerPort;

		private string protocol;

		private int? establishedTimeout;

		private string slbId;

		private int? realServerPort;

		private int? stickySession;

		private int? cookieTimeout;

		private string name;

		private long? envId;

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

		public int? ListenerPort
		{
			get
			{
				return listenerPort;
			}
			set	
			{
				listenerPort = value;
				DictionaryUtil.Add(QueryParameters, "ListenerPort", value.ToString());
			}
		}

		public string Protocol
		{
			get
			{
				return protocol;
			}
			set	
			{
				protocol = value;
				DictionaryUtil.Add(QueryParameters, "Protocol", value);
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

		public string SlbId
		{
			get
			{
				return slbId;
			}
			set	
			{
				slbId = value;
				DictionaryUtil.Add(QueryParameters, "SlbId", value);
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

		public long? EnvId
		{
			get
			{
				return envId;
			}
			set	
			{
				envId = value;
				DictionaryUtil.Add(QueryParameters, "EnvId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateSlbAPResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateSlbAPResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
