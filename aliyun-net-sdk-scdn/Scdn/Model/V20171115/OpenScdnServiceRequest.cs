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
using Aliyun.Acs.scdn;
using Aliyun.Acs.scdn.Transform;
using Aliyun.Acs.scdn.Transform.V20171115;

namespace Aliyun.Acs.scdn.Model.V20171115
{
    public class OpenScdnServiceRequest : RpcAcsRequest<OpenScdnServiceResponse>
    {
        public OpenScdnServiceRequest()
            : base("scdn", "2017-11-15", "OpenScdnService")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string startDate;

		private int? ccProtection;

		private string securityToken;

		private string protectType;

		private int? dDoSBasic;

		private int? bandwidth;

		private int? domainCount;

		private long? ownerId;

		private string endDate;

		private int? elasticProtection;

		public string StartDate
		{
			get
			{
				return startDate;
			}
			set	
			{
				startDate = value;
				DictionaryUtil.Add(QueryParameters, "StartDate", value);
			}
		}

		public int? CcProtection
		{
			get
			{
				return ccProtection;
			}
			set	
			{
				ccProtection = value;
				DictionaryUtil.Add(QueryParameters, "CcProtection", value.ToString());
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string ProtectType
		{
			get
			{
				return protectType;
			}
			set	
			{
				protectType = value;
				DictionaryUtil.Add(QueryParameters, "ProtectType", value);
			}
		}

		public int? DDoSBasic
		{
			get
			{
				return dDoSBasic;
			}
			set	
			{
				dDoSBasic = value;
				DictionaryUtil.Add(QueryParameters, "DDoSBasic", value.ToString());
			}
		}

		public int? Bandwidth
		{
			get
			{
				return bandwidth;
			}
			set	
			{
				bandwidth = value;
				DictionaryUtil.Add(QueryParameters, "Bandwidth", value.ToString());
			}
		}

		public int? DomainCount
		{
			get
			{
				return domainCount;
			}
			set	
			{
				domainCount = value;
				DictionaryUtil.Add(QueryParameters, "DomainCount", value.ToString());
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string EndDate
		{
			get
			{
				return endDate;
			}
			set	
			{
				endDate = value;
				DictionaryUtil.Add(QueryParameters, "EndDate", value);
			}
		}

		public int? ElasticProtection
		{
			get
			{
				return elasticProtection;
			}
			set	
			{
				elasticProtection = value;
				DictionaryUtil.Add(QueryParameters, "ElasticProtection", value.ToString());
			}
		}

        public override OpenScdnServiceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return OpenScdnServiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
