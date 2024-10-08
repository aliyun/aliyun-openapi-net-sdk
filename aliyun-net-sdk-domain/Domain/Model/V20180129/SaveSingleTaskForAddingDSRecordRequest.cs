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
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class SaveSingleTaskForAddingDSRecordRequest : RpcAcsRequest<SaveSingleTaskForAddingDSRecordResponse>
    {
        public SaveSingleTaskForAddingDSRecordRequest()
            : base("Domain", "2018-01-29", "SaveSingleTaskForAddingDSRecord", "domain", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? keyTag;

		private string domainName;

		private string userClientIp;

		private int? digestType;

		private string digest;

		private string lang;

		private int? algorithm;

		[JsonProperty(PropertyName = "KeyTag")]
		public int? KeyTag
		{
			get
			{
				return keyTag;
			}
			set	
			{
				keyTag = value;
				DictionaryUtil.Add(QueryParameters, "KeyTag", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "DomainName")]
		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		[JsonProperty(PropertyName = "UserClientIp")]
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

		[JsonProperty(PropertyName = "DigestType")]
		public int? DigestType
		{
			get
			{
				return digestType;
			}
			set	
			{
				digestType = value;
				DictionaryUtil.Add(QueryParameters, "DigestType", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Digest")]
		public string Digest
		{
			get
			{
				return digest;
			}
			set	
			{
				digest = value;
				DictionaryUtil.Add(QueryParameters, "Digest", value);
			}
		}

		[JsonProperty(PropertyName = "Lang")]
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

		[JsonProperty(PropertyName = "Algorithm")]
		public int? Algorithm
		{
			get
			{
				return algorithm;
			}
			set	
			{
				algorithm = value;
				DictionaryUtil.Add(QueryParameters, "Algorithm", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveSingleTaskForAddingDSRecordResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveSingleTaskForAddingDSRecordResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
