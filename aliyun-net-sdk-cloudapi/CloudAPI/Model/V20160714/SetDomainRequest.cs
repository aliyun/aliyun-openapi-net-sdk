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
using Aliyun.Acs.CloudAPI.Transform;
using Aliyun.Acs.CloudAPI.Transform.V20160714;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
    public class SetDomainRequest : RpcAcsRequest<SetDomainResponse>
    {
        public SetDomainRequest()
            : base("CloudAPI", "2016-07-14", "SetDomain")
        {
        }

		private string groupId;

		private string domainName;

		private string certificateName;

		private string certificateBody;

		private string certificatePrivateKey;

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

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

		public string CertificateName
		{
			get
			{
				return certificateName;
			}
			set	
			{
				certificateName = value;
				DictionaryUtil.Add(QueryParameters, "CertificateName", value);
			}
		}

		public string CertificateBody
		{
			get
			{
				return certificateBody;
			}
			set	
			{
				certificateBody = value;
				DictionaryUtil.Add(QueryParameters, "CertificateBody", value);
			}
		}

		public string CertificatePrivateKey
		{
			get
			{
				return certificatePrivateKey;
			}
			set	
			{
				certificatePrivateKey = value;
				DictionaryUtil.Add(QueryParameters, "CertificatePrivateKey", value);
			}
		}

        public override SetDomainResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetDomainResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}