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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Copyright;
using Aliyun.Acs.Copyright.Transform;
using Aliyun.Acs.Copyright.Transform.V20190123;

namespace Aliyun.Acs.Copyright.Model.V20190123
{
    public class VerifyOwnerInfoRequest : RpcAcsRequest<VerifyOwnerInfoResponse>
    {
        public VerifyOwnerInfoRequest()
            : base("Copyright", "2019-01-23", "VerifyOwnerInfo")
        {
			Method = MethodType.POST;
        }

		private string city;

		private string cardNum;

		private string province;

		private string ownerType;

		private string name;

		private string cardType;

		public string City
		{
			get
			{
				return city;
			}
			set	
			{
				city = value;
				DictionaryUtil.Add(QueryParameters, "City", value);
			}
		}

		public string CardNum
		{
			get
			{
				return cardNum;
			}
			set	
			{
				cardNum = value;
				DictionaryUtil.Add(QueryParameters, "CardNum", value);
			}
		}

		public string Province
		{
			get
			{
				return province;
			}
			set	
			{
				province = value;
				DictionaryUtil.Add(QueryParameters, "Province", value);
			}
		}

		public string OwnerType
		{
			get
			{
				return ownerType;
			}
			set	
			{
				ownerType = value;
				DictionaryUtil.Add(QueryParameters, "OwnerType", value);
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

		public string CardType
		{
			get
			{
				return cardType;
			}
			set	
			{
				cardType = value;
				DictionaryUtil.Add(QueryParameters, "CardType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override VerifyOwnerInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return VerifyOwnerInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
