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
    public class ListVpdsRequest : RpcAcsRequest<ListVpdsResponse>
    {
        public ListVpdsRequest()
            : base("eflo", "2022-05-30", "ListVpds", "eflo", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string vpdName;

		private int? pageNumber;

		private bool? withDependence;

		private string resourceGroupId;

		private bool? withoutVcc;

		private int? pageSize;

		private List<string> tags = new List<string>(){ };

		private bool? forSelect;

		private string filterErId;

		private string vpdId;

		private bool? enablePage;

		private string status;

		public string VpdName
		{
			get
			{
				return vpdName;
			}
			set	
			{
				vpdName = value;
				DictionaryUtil.Add(BodyParameters, "VpdName", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		public bool? WithDependence
		{
			get
			{
				return withDependence;
			}
			set	
			{
				withDependence = value;
				DictionaryUtil.Add(BodyParameters, "WithDependence", value.ToString());
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

		public bool? WithoutVcc
		{
			get
			{
				return withoutVcc;
			}
			set	
			{
				withoutVcc = value;
				DictionaryUtil.Add(BodyParameters, "WithoutVcc", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
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

		public bool? ForSelect
		{
			get
			{
				return forSelect;
			}
			set	
			{
				forSelect = value;
				DictionaryUtil.Add(BodyParameters, "ForSelect", value.ToString());
			}
		}

		public string FilterErId
		{
			get
			{
				return filterErId;
			}
			set	
			{
				filterErId = value;
				DictionaryUtil.Add(BodyParameters, "FilterErId", value);
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

		public bool? EnablePage
		{
			get
			{
				return enablePage;
			}
			set	
			{
				enablePage = value;
				DictionaryUtil.Add(BodyParameters, "EnablePage", value.ToString());
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(BodyParameters, "Status", value);
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

        public override ListVpdsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListVpdsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
