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
using Aliyun.Acs.eflo.Transform;
using Aliyun.Acs.eflo.Transform.V20220530;

namespace Aliyun.Acs.eflo.Model.V20220530
{
    public class CreateVccRequest : RpcAcsRequest<CreateVccResponse>
    {
        public CreateVccRequest()
            : base("eflo", "2022-05-30", "CreateVcc", "eflo", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string bgpCidr;

		private string cenId;

		private string description;

		private string cenOwnerId;

		private long? bgpAsn;

		private bool? accessCouldService;

		private string resourceGroupId;

		private string vccName;

		private List<string> tags = new List<string>(){ };

		private string vccId;

		private string connectionType;

		private int? bandwidth;

		private string vSwitchId;

		private string vpdId;

		private string vpcId;

		private string zoneId;

		public string BgpCidr
		{
			get
			{
				return bgpCidr;
			}
			set	
			{
				bgpCidr = value;
				DictionaryUtil.Add(BodyParameters, "BgpCidr", value);
			}
		}

		public string CenId
		{
			get
			{
				return cenId;
			}
			set	
			{
				cenId = value;
				DictionaryUtil.Add(BodyParameters, "CenId", value);
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
				DictionaryUtil.Add(BodyParameters, "Description", value);
			}
		}

		public string CenOwnerId
		{
			get
			{
				return cenOwnerId;
			}
			set	
			{
				cenOwnerId = value;
				DictionaryUtil.Add(BodyParameters, "CenOwnerId", value);
			}
		}

		public long? BgpAsn
		{
			get
			{
				return bgpAsn;
			}
			set	
			{
				bgpAsn = value;
				DictionaryUtil.Add(BodyParameters, "BgpAsn", value.ToString());
			}
		}

		public bool? AccessCouldService
		{
			get
			{
				return accessCouldService;
			}
			set	
			{
				accessCouldService = value;
				DictionaryUtil.Add(BodyParameters, "AccessCouldService", value.ToString());
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(BodyParameters, "ResourceGroupId", value);
			}
		}

		public string VccName
		{
			get
			{
				return vccName;
			}
			set	
			{
				vccName = value;
				DictionaryUtil.Add(BodyParameters, "VccName", value);
			}
		}

		public List<string> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				if(tags != null)
				{
					for (int depth1 = 0; depth1 < tags.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"Tag." + (depth1 + 1), tags[depth1]);
						DictionaryUtil.Add(BodyParameters,"Tag." + (depth1 + 1), tags[depth1]);
					}
				}
			}
		}

		public string VccId
		{
			get
			{
				return vccId;
			}
			set	
			{
				vccId = value;
				DictionaryUtil.Add(BodyParameters, "VccId", value);
			}
		}

		public string ConnectionType
		{
			get
			{
				return connectionType;
			}
			set	
			{
				connectionType = value;
				DictionaryUtil.Add(BodyParameters, "ConnectionType", value);
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
				DictionaryUtil.Add(BodyParameters, "Bandwidth", value.ToString());
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(BodyParameters, "VSwitchId", value);
			}
		}

		public string VpdId
		{
			get
			{
				return vpdId;
			}
			set	
			{
				vpdId = value;
				DictionaryUtil.Add(BodyParameters, "VpdId", value);
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
				DictionaryUtil.Add(BodyParameters, "VpcId", value);
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
				DictionaryUtil.Add(BodyParameters, "ZoneId", value);
			}
		}

		public class Tag
		{

			private string value_;

			private string key;

			public string Value_
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

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateVccResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateVccResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
