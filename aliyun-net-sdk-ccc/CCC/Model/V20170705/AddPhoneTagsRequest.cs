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
using Aliyun.Acs.CCC;
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20170705;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class AddPhoneTagsRequest : RpcAcsRequest<AddPhoneTagsResponse>
    {
        public AddPhoneTagsRequest()
            : base("CCC", "2017-07-05", "AddPhoneTags")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string regionNameProvince;

		private int? type;

		private int? concurrency;

		private string instanceId;

		private string provider;

		private List<string> phoneNumberLists = new List<string>(){ };

		private string serviceTag;

		private string regionNameCity;

		public string RegionNameProvince
		{
			get
			{
				return regionNameProvince;
			}
			set	
			{
				regionNameProvince = value;
				DictionaryUtil.Add(QueryParameters, "RegionNameProvince", value);
			}
		}

		public int? Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value.ToString());
			}
		}

		public int? Concurrency
		{
			get
			{
				return concurrency;
			}
			set	
			{
				concurrency = value;
				DictionaryUtil.Add(QueryParameters, "Concurrency", value.ToString());
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

		public string Provider
		{
			get
			{
				return provider;
			}
			set	
			{
				provider = value;
				DictionaryUtil.Add(QueryParameters, "Provider", value);
			}
		}

		public List<string> PhoneNumberLists
		{
			get
			{
				return phoneNumberLists;
			}

			set
			{
				phoneNumberLists = value;
				for (int i = 0; i < phoneNumberLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"PhoneNumberList." + (i + 1) , phoneNumberLists[i]);
				}
			}
		}

		public string ServiceTag
		{
			get
			{
				return serviceTag;
			}
			set	
			{
				serviceTag = value;
				DictionaryUtil.Add(QueryParameters, "ServiceTag", value);
			}
		}

		public string RegionNameCity
		{
			get
			{
				return regionNameCity;
			}
			set	
			{
				regionNameCity = value;
				DictionaryUtil.Add(QueryParameters, "RegionNameCity", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddPhoneTagsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddPhoneTagsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
