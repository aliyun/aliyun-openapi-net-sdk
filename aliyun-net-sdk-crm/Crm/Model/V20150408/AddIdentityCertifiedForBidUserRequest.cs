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
using Aliyun.Acs.Crm.Transform;
using Aliyun.Acs.Crm.Transform.V20150408;

namespace Aliyun.Acs.Crm.Model.V20150408
{
    public class AddIdentityCertifiedForBidUserRequest : RpcAcsRequest<AddIdentityCertifiedForBidUserResponse>
    {
        public AddIdentityCertifiedForBidUserRequest()
            : base("Crm", "2015-04-08", "AddIdentityCertifiedForBidUser", "crm", "openAPI")
        {
        }

		private string bidType;

		private string licenseNumber;

		private string licenseType;

		private string phone;

		private string name;

		private string pK;

		private bool? isEnterprise;

		public string BidType
		{
			get
			{
				return bidType;
			}
			set	
			{
				bidType = value;
				DictionaryUtil.Add(QueryParameters, "BidType", value);
			}
		}

		public string LicenseNumber
		{
			get
			{
				return licenseNumber;
			}
			set	
			{
				licenseNumber = value;
				DictionaryUtil.Add(QueryParameters, "LicenseNumber", value);
			}
		}

		public string LicenseType
		{
			get
			{
				return licenseType;
			}
			set	
			{
				licenseType = value;
				DictionaryUtil.Add(QueryParameters, "LicenseType", value);
			}
		}

		public string Phone
		{
			get
			{
				return phone;
			}
			set	
			{
				phone = value;
				DictionaryUtil.Add(QueryParameters, "Phone", value);
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

		public string PK
		{
			get
			{
				return pK;
			}
			set	
			{
				pK = value;
				DictionaryUtil.Add(QueryParameters, "PK", value);
			}
		}

		public bool? IsEnterprise
		{
			get
			{
				return isEnterprise;
			}
			set	
			{
				isEnterprise = value;
				DictionaryUtil.Add(QueryParameters, "IsEnterprise", value.ToString());
			}
		}

        public override AddIdentityCertifiedForBidUserResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddIdentityCertifiedForBidUserResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
