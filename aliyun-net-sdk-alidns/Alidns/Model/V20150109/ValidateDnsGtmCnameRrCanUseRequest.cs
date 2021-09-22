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
using Aliyun.Acs.Alidns.Transform;
using Aliyun.Acs.Alidns.Transform.V20150109;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
    public class ValidateDnsGtmCnameRrCanUseRequest : RpcAcsRequest<ValidateDnsGtmCnameRrCanUseResponse>
    {
        public ValidateDnsGtmCnameRrCanUseRequest()
            : base("Alidns", "2015-01-09", "ValidateDnsGtmCnameRrCanUse", "alidns", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Alidns.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Alidns.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string cnameMode;

		private string cnameZone;

		private string cnameRr;

		private string cnameType;

		private string instanceId;

		private string lang;

		public string CnameMode
		{
			get
			{
				return cnameMode;
			}
			set	
			{
				cnameMode = value;
				DictionaryUtil.Add(QueryParameters, "CnameMode", value);
			}
		}

		public string CnameZone
		{
			get
			{
				return cnameZone;
			}
			set	
			{
				cnameZone = value;
				DictionaryUtil.Add(QueryParameters, "CnameZone", value);
			}
		}

		public string CnameRr
		{
			get
			{
				return cnameRr;
			}
			set	
			{
				cnameRr = value;
				DictionaryUtil.Add(QueryParameters, "CnameRr", value);
			}
		}

		public string CnameType
		{
			get
			{
				return cnameType;
			}
			set	
			{
				cnameType = value;
				DictionaryUtil.Add(QueryParameters, "CnameType", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ValidateDnsGtmCnameRrCanUseResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ValidateDnsGtmCnameRrCanUseResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
