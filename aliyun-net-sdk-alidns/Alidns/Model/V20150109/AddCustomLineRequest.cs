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
    public class AddCustomLineRequest : RpcAcsRequest<AddCustomLineResponse>
    {
        public AddCustomLineRequest()
            : base("Alidns", "2015-01-09", "AddCustomLine", "alidns", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Alidns.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Alidns.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string domainName;

		private List<IpSegment> ipSegments = new List<IpSegment>(){ };

		private string lineName;

		private string lang;

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public List<IpSegment> IpSegments
		{
			get
			{
				return ipSegments;
			}

			set
			{
				ipSegments = value;
				for (int i = 0; i < ipSegments.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"IpSegment." + (i + 1) + ".EndIp", ipSegments[i].EndIp);
					DictionaryUtil.Add(QueryParameters,"IpSegment." + (i + 1) + ".StartIp", ipSegments[i].StartIp);
				}
			}
		}

		public string LineName
		{
			get
			{
				return lineName;
			}
			set	
			{
				lineName = value;
				DictionaryUtil.Add(QueryParameters, "LineName", value);
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

		public class IpSegment
		{

			private string endIp;

			private string startIp;

			public string EndIp
			{
				get
				{
					return endIp;
				}
				set	
				{
					endIp = value;
				}
			}

			public string StartIp
			{
				get
				{
					return startIp;
				}
				set	
				{
					startIp = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddCustomLineResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddCustomLineResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
