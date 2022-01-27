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
    public class ElementSmartVerifyRequest : RpcAcsRequest<ElementSmartVerifyResponse>
    {
        public ElementSmartVerifyRequest()
            : base("Cloudauth", "2020-06-18", "ElementSmartVerify", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string certFile;

		private string certNationalEmblemUrl;

		private string certName;

		private string mode;

		private string certNo;

		private string outerOrderNo;

		private string certUrl;

		private string certType;

		private long? sceneId;

		public string CertFile
		{
			get
			{
				return certFile;
			}
			set	
			{
				certFile = value;
				DictionaryUtil.Add(BodyParameters, "CertFile", value);
			}
		}

		public string CertNationalEmblemUrl
		{
			get
			{
				return certNationalEmblemUrl;
			}
			set	
			{
				certNationalEmblemUrl = value;
				DictionaryUtil.Add(BodyParameters, "CertNationalEmblemUrl", value);
			}
		}

		public string CertName
		{
			get
			{
				return certName;
			}
			set	
			{
				certName = value;
				DictionaryUtil.Add(BodyParameters, "CertName", value);
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

		public string CertNo
		{
			get
			{
				return certNo;
			}
			set	
			{
				certNo = value;
				DictionaryUtil.Add(BodyParameters, "CertNo", value);
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

		public string CertUrl
		{
			get
			{
				return certUrl;
			}
			set	
			{
				certUrl = value;
				DictionaryUtil.Add(BodyParameters, "CertUrl", value);
			}
		}

		public string CertType
		{
			get
			{
				return certType;
			}
			set	
			{
				certType = value;
				DictionaryUtil.Add(BodyParameters, "CertType", value);
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

        public override ElementSmartVerifyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ElementSmartVerifyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
