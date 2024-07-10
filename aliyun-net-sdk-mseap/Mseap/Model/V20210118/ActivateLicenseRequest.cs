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
using Aliyun.Acs.mseap;
using Aliyun.Acs.mseap.Transform;
using Aliyun.Acs.mseap.Transform.V20210118;

namespace Aliyun.Acs.mseap.Model.V20210118
{
    public class ActivateLicenseRequest : RpcAcsRequest<ActivateLicenseResponse>
    {
        public ActivateLicenseRequest()
            : base("mseap", "2021-01-18", "ActivateLicense")
        {
			Method = MethodType.POST;
        }

		private string licenseNo;

		private string bizType;

		private string licensePublisher;

		private string bizId;

		private string licenseCode;

		public string LicenseNo
		{
			get
			{
				return licenseNo;
			}
			set	
			{
				licenseNo = value;
				DictionaryUtil.Add(QueryParameters, "LicenseNo", value);
			}
		}

		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
				DictionaryUtil.Add(QueryParameters, "BizType", value);
			}
		}

		public string LicensePublisher
		{
			get
			{
				return licensePublisher;
			}
			set	
			{
				licensePublisher = value;
				DictionaryUtil.Add(QueryParameters, "LicensePublisher", value);
			}
		}

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(QueryParameters, "BizId", value);
			}
		}

		public string LicenseCode
		{
			get
			{
				return licenseCode;
			}
			set	
			{
				licenseCode = value;
				DictionaryUtil.Add(QueryParameters, "LicenseCode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ActivateLicenseResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ActivateLicenseResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
