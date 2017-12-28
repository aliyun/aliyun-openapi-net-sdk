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
    public class SaveBatchTaskForCreatingOrderRenewRequest : RpcAcsRequest<SaveBatchTaskForCreatingOrderRenewResponse>
    {
        public SaveBatchTaskForCreatingOrderRenewRequest()
            : base("Domain_intl", "2017-12-18", "SaveBatchTaskForCreatingOrderRenew", "domain", "openAPI")
        {
        }

		private string userClientIp;

		private List<OrderRenewParam> orderRenewParams;

		private string lang;

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

		public List<OrderRenewParam> OrderRenewParams
		{
			get
			{
				return orderRenewParams;
			}

			set
			{
				orderRenewParams = value;
				for (int i = 0; i < orderRenewParams.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"OrderRenewParam." + (i + 1) + ".DomainName", orderRenewParams[i].DomainName);
					DictionaryUtil.Add(QueryParameters,"OrderRenewParam." + (i + 1) + ".CurrentExpirationDate", orderRenewParams[i].CurrentExpirationDate);
					DictionaryUtil.Add(QueryParameters,"OrderRenewParam." + (i + 1) + ".SubscriptionDuration", orderRenewParams[i].SubscriptionDuration);
				}
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

		public class OrderRenewParam
		{

			private string domainName;

			private long? currentExpirationDate;

			private int? subscriptionDuration;

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

			public int? SubscriptionDuration
			{
				get
				{
					return subscriptionDuration;
				}
				set	
				{
					subscriptionDuration = value;
				}
			}
		}

        public override SaveBatchTaskForCreatingOrderRenewResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SaveBatchTaskForCreatingOrderRenewResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}