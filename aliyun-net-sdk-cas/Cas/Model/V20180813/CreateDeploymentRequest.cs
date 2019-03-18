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
using Aliyun.Acs.cas.Transform;
using Aliyun.Acs.cas.Transform.V20180813;

namespace Aliyun.Acs.cas.Model.V20180813
{
    public class CreateDeploymentRequest : RpcAcsRequest<CreateDeploymentResponse>
    {
        public CreateDeploymentRequest()
            : base("cas", "2018-08-13", "CreateDeployment", "cas_esign_fdd", "openAPI")
        {
        }

		private string sourceIp;

		private long? certificateId;

		private string domain;

		private string cloudProduct;

		private string lang;

		private string region;

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public long? CertificateId
		{
			get
			{
				return certificateId;
			}
			set	
			{
				certificateId = value;
				DictionaryUtil.Add(QueryParameters, "CertificateId", value.ToString());
			}
		}

		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
				DictionaryUtil.Add(QueryParameters, "Domain", value);
			}
		}

		public string CloudProduct
		{
			get
			{
				return cloudProduct;
			}
			set	
			{
				cloudProduct = value;
				DictionaryUtil.Add(QueryParameters, "CloudProduct", value);
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

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateDeploymentResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDeploymentResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
