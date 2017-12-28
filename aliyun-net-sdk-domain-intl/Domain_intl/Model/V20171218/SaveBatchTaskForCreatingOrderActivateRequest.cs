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
    public class SaveBatchTaskForCreatingOrderActivateRequest : RpcAcsRequest<SaveBatchTaskForCreatingOrderActivateResponse>
    {
        public SaveBatchTaskForCreatingOrderActivateRequest()
            : base("Domain_intl", "2017-12-18", "SaveBatchTaskForCreatingOrderActivate", "domain", "openAPI")
        {
        }

		private List<OrderActivateParam> orderActivateParams;

		private string userClientIp;

		private string lang;

		public List<OrderActivateParam> OrderActivateParams
		{
			get
			{
				return orderActivateParams;
			}

			set
			{
				orderActivateParams = value;
				for (int i = 0; i < orderActivateParams.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".DomainName", orderActivateParams[i].DomainName);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".SubscriptionDuration", orderActivateParams[i].SubscriptionDuration);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".RegistrantProfileId", orderActivateParams[i].RegistrantProfileId);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".EnableDomainProxy", orderActivateParams[i].EnableDomainProxy);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".PermitPremiumActivation", orderActivateParams[i].PermitPremiumActivation);
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

		public class OrderActivateParam
		{

			private string domainName;

			private int? subscriptionDuration;

			private long? registrantProfileId;

			private bool? enableDomainProxy;

			private bool? permitPremiumActivation;

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

			public long? RegistrantProfileId
			{
				get
				{
					return registrantProfileId;
				}
				set	
				{
					registrantProfileId = value;
				}
			}

			public bool? EnableDomainProxy
			{
				get
				{
					return enableDomainProxy;
				}
				set	
				{
					enableDomainProxy = value;
				}
			}

			public bool? PermitPremiumActivation
			{
				get
				{
					return permitPremiumActivation;
				}
				set	
				{
					permitPremiumActivation = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveBatchTaskForCreatingOrderActivateResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SaveBatchTaskForCreatingOrderActivateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}