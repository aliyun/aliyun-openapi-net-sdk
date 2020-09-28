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
using Aliyun.Acs.Kms.Transform;
using Aliyun.Acs.Kms.Transform.V20160120;

namespace Aliyun.Acs.Kms.Model.V20160120
{
    public class GetRandomPasswordRequest : RpcAcsRequest<GetRandomPasswordResponse>
    {
        public GetRandomPasswordRequest()
            : base("Kms", "2016-01-20", "GetRandomPassword", "kms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string excludeLowercase;

		private string excludeCharacters;

		private string passwordLength;

		private string excludePunctuation;

		private string excludeUppercase;

		private string requireEachIncludedType;

		private string excludeNumbers;

		public string ExcludeLowercase
		{
			get
			{
				return excludeLowercase;
			}
			set	
			{
				excludeLowercase = value;
				DictionaryUtil.Add(QueryParameters, "ExcludeLowercase", value);
			}
		}

		public string ExcludeCharacters
		{
			get
			{
				return excludeCharacters;
			}
			set	
			{
				excludeCharacters = value;
				DictionaryUtil.Add(QueryParameters, "ExcludeCharacters", value);
			}
		}

		public string PasswordLength
		{
			get
			{
				return passwordLength;
			}
			set	
			{
				passwordLength = value;
				DictionaryUtil.Add(QueryParameters, "PasswordLength", value);
			}
		}

		public string ExcludePunctuation
		{
			get
			{
				return excludePunctuation;
			}
			set	
			{
				excludePunctuation = value;
				DictionaryUtil.Add(QueryParameters, "ExcludePunctuation", value);
			}
		}

		public string ExcludeUppercase
		{
			get
			{
				return excludeUppercase;
			}
			set	
			{
				excludeUppercase = value;
				DictionaryUtil.Add(QueryParameters, "ExcludeUppercase", value);
			}
		}

		public string RequireEachIncludedType
		{
			get
			{
				return requireEachIncludedType;
			}
			set	
			{
				requireEachIncludedType = value;
				DictionaryUtil.Add(QueryParameters, "RequireEachIncludedType", value);
			}
		}

		public string ExcludeNumbers
		{
			get
			{
				return excludeNumbers;
			}
			set	
			{
				excludeNumbers = value;
				DictionaryUtil.Add(QueryParameters, "ExcludeNumbers", value);
			}
		}

        public override GetRandomPasswordResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetRandomPasswordResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
