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
using Aliyun.Acs.finmall.Transform;
using Aliyun.Acs.finmall.Transform.V20180723;

namespace Aliyun.Acs.finmall.Model.V20180723
{
    public class AddTrialRecordRequest : RpcAcsRequest<AddTrialRecordResponse>
    {
        public AddTrialRecordRequest()
            : base("finmall", "2018-07-23", "AddTrialRecord", "finmall", "openAPI")
        {
        }

		private string note;

		private string enterpriseEmail;

		private string contractPhoneNumber;

		private string contractName;

		private string channel;

		private string enterpriseName;

		private string userId;

		private string products;

		private string budget;

		public string Note
		{
			get
			{
				return note;
			}
			set	
			{
				note = value;
				DictionaryUtil.Add(QueryParameters, "Note", value);
			}
		}

		public string EnterpriseEmail
		{
			get
			{
				return enterpriseEmail;
			}
			set	
			{
				enterpriseEmail = value;
				DictionaryUtil.Add(QueryParameters, "EnterpriseEmail", value);
			}
		}

		public string ContractPhoneNumber
		{
			get
			{
				return contractPhoneNumber;
			}
			set	
			{
				contractPhoneNumber = value;
				DictionaryUtil.Add(QueryParameters, "ContractPhoneNumber", value);
			}
		}

		public string ContractName
		{
			get
			{
				return contractName;
			}
			set	
			{
				contractName = value;
				DictionaryUtil.Add(QueryParameters, "ContractName", value);
			}
		}

		public string Channel
		{
			get
			{
				return channel;
			}
			set	
			{
				channel = value;
				DictionaryUtil.Add(QueryParameters, "Channel", value);
			}
		}

		public string EnterpriseName
		{
			get
			{
				return enterpriseName;
			}
			set	
			{
				enterpriseName = value;
				DictionaryUtil.Add(QueryParameters, "EnterpriseName", value);
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value);
			}
		}

		public string Products
		{
			get
			{
				return products;
			}
			set	
			{
				products = value;
				DictionaryUtil.Add(QueryParameters, "Products", value);
			}
		}

		public string Budget
		{
			get
			{
				return budget;
			}
			set	
			{
				budget = value;
				DictionaryUtil.Add(QueryParameters, "Budget", value);
			}
		}

        public override AddTrialRecordResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddTrialRecordResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
