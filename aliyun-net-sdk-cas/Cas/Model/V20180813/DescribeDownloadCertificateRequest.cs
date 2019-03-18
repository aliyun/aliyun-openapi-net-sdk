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
    public class DescribeDownloadCertificateRequest : RpcAcsRequest<DescribeDownloadCertificateResponse>
    {
        public DescribeDownloadCertificateRequest()
            : base("cas", "2018-08-13", "DescribeDownloadCertificate", "cas_esign_fdd", "openAPI")
        {
        }

		private string sourceIp;

		private string serverType;

		private long? certificateId;

		private string lang;

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

		public string ServerType
		{
			get
			{
				return serverType;
			}
			set	
			{
				serverType = value;
				DictionaryUtil.Add(QueryParameters, "ServerType", value);
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

        public override DescribeDownloadCertificateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDownloadCertificateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
