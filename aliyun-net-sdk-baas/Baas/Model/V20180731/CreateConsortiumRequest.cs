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
using Aliyun.Acs.Baas.Transform;
using Aliyun.Acs.Baas.Transform.V20180731;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Model.V20180731
{
    public class CreateConsortiumRequest : RpcAcsRequest<CreateConsortiumResponse>
    {
        public CreateConsortiumRequest()
            : base("Baas", "2018-07-31", "CreateConsortium")
        {
        }

		private int? orderersCount;

		private string domain;

		private string specName;

		private List<Organization> organizations;

		private string name;

		private string ordererType;

		private string zoneId;

		private string description;

		private string location;

		private int? peersCount;

		private string channelPolicy;

		public int? OrderersCount
		{
			get
			{
				return orderersCount;
			}
			set	
			{
				orderersCount = value;
				DictionaryUtil.Add(BodyParameters, "OrderersCount", value.ToString());
			}
		}

		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
				DictionaryUtil.Add(BodyParameters, "Domain", value);
			}
		}

		public string SpecName
		{
			get
			{
				return specName;
			}
			set	
			{
				specName = value;
				DictionaryUtil.Add(BodyParameters, "SpecName", value);
			}
		}

		public List<Organization> Organizations
		{
			get
			{
				return organizations;
			}

			set
			{
				organizations = value;
				for (int i = 0; i < organizations.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Organization." + (i + 1) + ".Id", organizations[i].Id);
				}
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
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		public string OrdererType
		{
			get
			{
				return ordererType;
			}
			set	
			{
				ordererType = value;
				DictionaryUtil.Add(BodyParameters, "OrdererType", value);
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

		public string Location
		{
			get
			{
				return location;
			}
			set	
			{
				location = value;
				DictionaryUtil.Add(BodyParameters, "Location", value);
			}
		}

		public int? PeersCount
		{
			get
			{
				return peersCount;
			}
			set	
			{
				peersCount = value;
				DictionaryUtil.Add(BodyParameters, "PeersCount", value.ToString());
			}
		}

		public string ChannelPolicy
		{
			get
			{
				return channelPolicy;
			}
			set	
			{
				channelPolicy = value;
				DictionaryUtil.Add(BodyParameters, "ChannelPolicy", value);
			}
		}

		public class Organization
		{

			private string id;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateConsortiumResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateConsortiumResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}