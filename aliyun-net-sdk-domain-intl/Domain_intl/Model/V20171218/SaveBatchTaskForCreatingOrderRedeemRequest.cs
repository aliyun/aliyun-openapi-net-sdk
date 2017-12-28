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
using Aliyun.Acs.Domain_intl.Transform;
using Aliyun.Acs.Domain_intl.Transform.V20171218;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain_intl.Model.V20171218
{
    public class SaveBatchTaskForCreatingOrderRedeemRequest : RpcAcsRequest<SaveBatchTaskForCreatingOrderRedeemResponse>
    {
        public SaveBatchTaskForCreatingOrderRedeemRequest()
            : base("Domain_intl", "2017-12-18", "SaveBatchTaskForCreatingOrderRedeem", "domain", "openAPI")
        {
        }

		private List<OrderRedeemParam> orderRedeemParams;

		private string userClientIp;

		private string lang;

		public List<OrderRedeemParam> OrderRedeemParams
		{
			get
			{
				return orderRedeemParams;
			}

			set
			{
				orderRedeemParams = value;
				for (int i = 0; i < orderRedeemParams.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"OrderRedeemParam." + (i + 1) + ".DomainName", orderRedeemParams[i].DomainName);
					DictionaryUtil.Add(QueryParameters,"OrderRedeemParam." + (i + 1) + ".CurrentExpirationDate", orderRedeemParams[i].CurrentExpirationDate);
				}
			}
		}

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public class OrderRedeemParam
		{

			private string domainName;

			private long? currentExpirationDate;

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			public long? CurrentExpirationDate
			{
				get
				{
					return currentExpirationDate;
				}
				set	
				{
					currentExpirationDate = value;
				}
			}
		}

        public override SaveBatchTaskForCreatingOrderRedeemResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SaveBatchTaskForCreatingOrderRedeemResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}