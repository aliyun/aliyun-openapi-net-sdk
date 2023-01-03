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
    public class CreateVpdRequest : RpcAcsRequest<CreateVpdResponse>
    {
        public CreateVpdRequest()
            : base("eflo", "2022-05-30", "CreateVpd", "eflo", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string name;

		private string cidr;

		private List<string> subnetss = new List<string>(){ };

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(BodyParameters, "Name", value);
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

		public List<string> Subnetss
		{
			get
			{
				return subnetss;
			}

			set
			{
				subnetss = value;
				if(subnetss != null)
				{
					for (int depth1 = 0; depth1 < subnetss.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"Subnets." + (depth1 + 1), subnetss[depth1]);
						DictionaryUtil.Add(BodyParameters,"Subnets." + (depth1 + 1), subnetss[depth1]);
						DictionaryUtil.Add(BodyParameters,"Subnets." + (depth1 + 1), subnetss[depth1]);
						DictionaryUtil.Add(BodyParameters,"Subnets." + (depth1 + 1), subnetss[depth1]);
						DictionaryUtil.Add(BodyParameters,"Subnets." + (depth1 + 1), subnetss[depth1]);
					}
				}
			}
		}

		public class Subnets
		{

			private string regionId;

			private string name;

			private string zoneId;

			private string cidr;

			private string type;

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
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
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateVpdResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateVpdResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
