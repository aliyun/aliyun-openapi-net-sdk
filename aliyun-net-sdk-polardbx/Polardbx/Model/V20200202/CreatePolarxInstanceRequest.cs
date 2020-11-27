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
using Aliyun.Acs.polardbx.Transform;
using Aliyun.Acs.polardbx.Transform.V20200202;

namespace Aliyun.Acs.polardbx.Model.V20200202
{
    public class CreatePolarxInstanceRequest : RpcAcsRequest<CreatePolarxInstanceResponse>
    {
        public CreatePolarxInstanceRequest()
            : base("polardbx", "2020-02-02", "CreatePolarxInstance", "polardbx", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? isAutoRenew;

		private string clientToken;

		private string description;

		private string type;

		private int? duration;

		private bool? isHa;

		private int? mySQLVersion;

		private string instanceSeries;

		private string masterInstId;

		private int? quantity;

		private string specification;

		private string vswitchId;

		private string vpcId;

		private string zoneId;

		private string payType;

		private string pricingCycle;

		public bool? IsAutoRenew
		{
			get
			{
				return isAutoRenew;
			}
			set	
			{
				isAutoRenew = value;
				DictionaryUtil.Add(QueryParameters, "IsAutoRenew", value.ToString());
			}
		}

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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

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

		public bool? IsHa
		{
			get
			{
				return isHa;
			}
			set	
			{
				isHa = value;
				DictionaryUtil.Add(QueryParameters, "isHa", value.ToString());
			}
		}

		public int? MySQLVersion
		{
			get
			{
				return mySQLVersion;
			}
			set	
			{
				mySQLVersion = value;
				DictionaryUtil.Add(QueryParameters, "MySQLVersion", value.ToString());
			}
		}

		public string InstanceSeries
		{
			get
			{
				return instanceSeries;
			}
			set	
			{
				instanceSeries = value;
				DictionaryUtil.Add(QueryParameters, "InstanceSeries", value);
			}
		}

		public string MasterInstId
		{
			get
			{
				return masterInstId;
			}
			set	
			{
				masterInstId = value;
				DictionaryUtil.Add(QueryParameters, "MasterInstId", value);
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

		public string Specification
		{
			get
			{
				return specification;
			}
			set	
			{
				specification = value;
				DictionaryUtil.Add(QueryParameters, "Specification", value);
			}
		}

		public string VswitchId
		{
			get
			{
				return vswitchId;
			}
			set	
			{
				vswitchId = value;
				DictionaryUtil.Add(QueryParameters, "VswitchId", value);
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
			}
		}

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public string PayType
		{
			get
			{
				return payType;
			}
			set	
			{
				payType = value;
				DictionaryUtil.Add(QueryParameters, "PayType", value);
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

        public override CreatePolarxInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreatePolarxInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
