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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Drds.Transform;
using Aliyun.Acs.Drds.Transform.V20171016;
using System.Collections.Generic;

namespace Aliyun.Acs.Drds.Model.V20171016
{
    public class CreateDrdsInstanceRequest : RpcAcsRequest<CreateDrdsInstanceResponse>
    {
        public CreateDrdsInstanceRequest()
            : base("Drds", "2017-10-16", "CreateDrdsInstance")
        {
        }

		private int? quantity;

		private string description;

		private string specification;

		private string type;

		private string accessKeyId;

		private string vswitchId;

		private bool? isHa;

		private string regionId;

		private string instanceSeries;

		private string vpcId;

		private string action;

		private string zoneId;

		private string payType;

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

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
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

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
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
				DictionaryUtil.Add(QueryParameters, "instanceSeries", value);
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

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
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

        public override CreateDrdsInstanceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateDrdsInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}