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
using Aliyun.Acs.Cloudauth.Transform;
using Aliyun.Acs.Cloudauth.Transform.V20200618;

namespace Aliyun.Acs.Cloudauth.Model.V20200618
{
    public class VerifyBankElementRequest : RpcAcsRequest<VerifyBankElementResponse>
    {
        public VerifyBankElementRequest()
            : base("Cloudauth", "2020-06-18", "VerifyBankElement", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string idName;

		private string mobile;

		private string bankCardUrl;

		private string idNo;

		private string bankCardNo;

		private string mode;

		private string outerOrderNo;

		private string bankCardFile;

		private long? sceneId;

		public string IdName
		{
			get
			{
				return idName;
			}
			set	
			{
				idName = value;
				DictionaryUtil.Add(BodyParameters, "IdName", value);
			}
		}

		public string Mobile
		{
			get
			{
				return mobile;
			}
			set	
			{
				mobile = value;
				DictionaryUtil.Add(BodyParameters, "Mobile", value);
			}
		}

		public string BankCardUrl
		{
			get
			{
				return bankCardUrl;
			}
			set	
			{
				bankCardUrl = value;
				DictionaryUtil.Add(BodyParameters, "BankCardUrl", value);
			}
		}

		public string IdNo
		{
			get
			{
				return idNo;
			}
			set	
			{
				idNo = value;
				DictionaryUtil.Add(BodyParameters, "IdNo", value);
			}
		}

		public string BankCardNo
		{
			get
			{
				return bankCardNo;
			}
			set	
			{
				bankCardNo = value;
				DictionaryUtil.Add(BodyParameters, "BankCardNo", value);
			}
		}

		public string Mode
		{
			get
			{
				return mode;
			}
			set	
			{
				mode = value;
				DictionaryUtil.Add(BodyParameters, "Mode", value);
			}
		}

		public string OuterOrderNo
		{
			get
			{
				return outerOrderNo;
			}
			set	
			{
				outerOrderNo = value;
				DictionaryUtil.Add(BodyParameters, "OuterOrderNo", value);
			}
		}

		public string BankCardFile
		{
			get
			{
				return bankCardFile;
			}
			set	
			{
				bankCardFile = value;
				DictionaryUtil.Add(BodyParameters, "BankCardFile", value);
			}
		}

		public long? SceneId
		{
			get
			{
				return sceneId;
			}
			set	
			{
				sceneId = value;
				DictionaryUtil.Add(BodyParameters, "SceneId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override VerifyBankElementResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return VerifyBankElementResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
