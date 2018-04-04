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
    public class SaveBatchTaskForCreatingOrderTransferRequest : RpcAcsRequest<SaveBatchTaskForCreatingOrderTransferResponse>
    {
        public SaveBatchTaskForCreatingOrderTransferRequest()
            : base("Domain_intl", "2017-12-18", "SaveBatchTaskForCreatingOrderTransfer", "domain", "openAPI")
        {
        }

		private List<OrderTransferParam> orderTransferParams;

		private string userClientIp;

		private string lang;

		public List<OrderTransferParam> OrderTransferParams
		{
			get
			{
				return orderTransferParams;
			}

			set
			{
				orderTransferParams = value;
				for (int i = 0; i < orderTransferParams.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"OrderTransferParam." + (i + 1) + ".DomainName", orderTransferParams[i].DomainName);
					DictionaryUtil.Add(QueryParameters,"OrderTransferParam." + (i + 1) + ".AuthorizationCode", orderTransferParams[i].AuthorizationCode);
					DictionaryUtil.Add(QueryParameters,"OrderTransferParam." + (i + 1) + ".RegistrantProfileId", orderTransferParams[i].RegistrantProfileId);
					DictionaryUtil.Add(QueryParameters,"OrderTransferParam." + (i + 1) + ".PermitPremiumTransfer", orderTransferParams[i].PermitPremiumTransfer);
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

		public class OrderTransferParam
		{

			private string domainName;

			private string authorizationCode;

			private long? registrantProfileId;

			private bool? permitPremiumTransfer;

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

			public string AuthorizationCode
			{
				get
				{
					return authorizationCode;
				}
				set	
				{
					authorizationCode = value;
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

			public bool? PermitPremiumTransfer
			{
				get
				{
					return permitPremiumTransfer;
				}
				set	
				{
					permitPremiumTransfer = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveBatchTaskForCreatingOrderTransferResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SaveBatchTaskForCreatingOrderTransferResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}