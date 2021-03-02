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
    public class UpdateGtmAddressPoolRequest : RpcAcsRequest<UpdateGtmAddressPoolResponse>
    {
        public UpdateGtmAddressPoolRequest()
            : base("Alidns", "2015-01-09", "UpdateGtmAddressPool", "alidns", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Alidns.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Alidns.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string type;

		private int? minAvailableAddrNum;

		private string addrPoolId;

		private string name;

		private string lang;

		private List<Addr> addrs = new List<Addr>(){ };

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public int? MinAvailableAddrNum
		{
			get
			{
				return minAvailableAddrNum;
			}
			set	
			{
				minAvailableAddrNum = value;
				DictionaryUtil.Add(QueryParameters, "MinAvailableAddrNum", value.ToString());
			}
		}

		public string AddrPoolId
		{
			get
			{
				return addrPoolId;
			}
			set	
			{
				addrPoolId = value;
				DictionaryUtil.Add(QueryParameters, "AddrPoolId", value);
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

		public List<Addr> Addrs
		{
			get
			{
				return addrs;
			}

			set
			{
				addrs = value;
				for (int i = 0; i < addrs.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Addr." + (i + 1) + ".Mode", addrs[i].Mode);
					DictionaryUtil.Add(QueryParameters,"Addr." + (i + 1) + ".LbaWeight", addrs[i].LbaWeight);
					DictionaryUtil.Add(QueryParameters,"Addr." + (i + 1) + ".Value", addrs[i].Value);
				}
			}
		}

		public class Addr
		{

			private string mode;

			private int? lbaWeight;

			private string value_;

			public string Mode
			{
				get
				{
					return mode;
				}
				set	
				{
					mode = value;
				}
			}

			public int? LbaWeight
			{
				get
				{
					return lbaWeight;
				}
				set	
				{
					lbaWeight = value;
				}
			}

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}
		}

        public override UpdateGtmAddressPoolResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateGtmAddressPoolResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
