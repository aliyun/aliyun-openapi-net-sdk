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
    public class CreateSubnetRequest : RpcAcsRequest<CreateSubnetResponse>
    {
        public CreateSubnetRequest()
            : base("eflo", "2022-05-30", "CreateSubnet", "eflo", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string type;

		private string cidr;

		private List<string> tags = new List<string>(){ };

		private string vpdId;

		private string zoneId;

		private string subnetName;

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(BodyParameters, "Type", value);
			}
		}

		public string Cidr
		{
			get
			{
				return cidr;
			}
			set	
			{
				cidr = value;
				DictionaryUtil.Add(BodyParameters, "Cidr", value);
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

		public string SubnetName
		{
			get
			{
				return subnetName;
			}
			set	
			{
				subnetName = value;
				DictionaryUtil.Add(BodyParameters, "SubnetName", value);
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

        public override CreateSubnetResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateSubnetResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
