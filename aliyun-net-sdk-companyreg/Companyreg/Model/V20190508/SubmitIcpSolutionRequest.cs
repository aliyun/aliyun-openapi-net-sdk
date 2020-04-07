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
using Aliyun.Acs.companyreg.Transform;
using Aliyun.Acs.companyreg.Transform.V20190508;

namespace Aliyun.Acs.companyreg.Model.V20190508
{
    public class SubmitIcpSolutionRequest : RpcAcsRequest<SubmitIcpSolutionResponse>
    {
        public SubmitIcpSolutionRequest()
            : base("companyreg", "2019-05-08", "SubmitIcpSolution", "companyreg", "openAPI")
        {
        }

		private string area;

		private string intentionBizId;

		private int? icpType;

		private string companyAddress;

		private string companyName;

		private string bizId;

		public string Area
		{
			get
			{
				return area;
			}
			set	
			{
				area = value;
				DictionaryUtil.Add(BodyParameters, "Area", value);
			}
		}

		public string IntentionBizId
		{
			get
			{
				return intentionBizId;
			}
			set	
			{
				intentionBizId = value;
				DictionaryUtil.Add(BodyParameters, "IntentionBizId", value);
			}
		}

		public int? IcpType
		{
			get
			{
				return icpType;
			}
			set	
			{
				icpType = value;
				DictionaryUtil.Add(BodyParameters, "IcpType", value.ToString());
			}
		}

		public string CompanyAddress
		{
			get
			{
				return companyAddress;
			}
			set	
			{
				companyAddress = value;
				DictionaryUtil.Add(BodyParameters, "CompanyAddress", value);
			}
		}

		public string CompanyName
		{
			get
			{
				return companyName;
			}
			set	
			{
				companyName = value;
				DictionaryUtil.Add(BodyParameters, "CompanyName", value);
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
				DictionaryUtil.Add(BodyParameters, "BizId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SubmitIcpSolutionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitIcpSolutionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
