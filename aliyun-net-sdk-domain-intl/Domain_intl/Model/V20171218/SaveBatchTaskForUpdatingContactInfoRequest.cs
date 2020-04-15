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
using Aliyun.Acs.Domain_intl.Transform;
using Aliyun.Acs.Domain_intl.Transform.V20171218;

namespace Aliyun.Acs.Domain_intl.Model.V20171218
{
    public class SaveBatchTaskForUpdatingContactInfoRequest : RpcAcsRequest<SaveBatchTaskForUpdatingContactInfoResponse>
    {
        public SaveBatchTaskForUpdatingContactInfoRequest()
            : base("Domain-intl", "2017-12-18", "SaveBatchTaskForUpdatingContactInfo", "domain", "openAPI")
        {
        }

		private string contactType;

		private long? registrantProfileId;

		private List<string> domainNames = new List<string>(){ };

		private bool? addTransferLock;

		private string userClientIp;

		private string lang;

		public string ContactType
		{
			get
			{
				return contactType;
			}
			set	
			{
				contactType = value;
				DictionaryUtil.Add(QueryParameters, "ContactType", value);
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
				DictionaryUtil.Add(QueryParameters, "RegistrantProfileId", value.ToString());
			}
		}

		public List<string> DomainNames
		{
			get
			{
				return domainNames;
			}

			set
			{
				domainNames = value;
				for (int i = 0; i < domainNames.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DomainName." + (i + 1) , domainNames[i]);
				}
			}
		}

		public bool? AddTransferLock
		{
			get
			{
				return addTransferLock;
			}
			set	
			{
				addTransferLock = value;
				DictionaryUtil.Add(QueryParameters, "AddTransferLock", value.ToString());
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveBatchTaskForUpdatingContactInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveBatchTaskForUpdatingContactInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
