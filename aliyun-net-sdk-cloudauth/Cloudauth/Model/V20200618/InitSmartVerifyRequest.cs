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
    public class InitSmartVerifyRequest : RpcAcsRequest<InitSmartVerifyResponse>
    {
        public InitSmartVerifyRequest()
            : base("Cloudauth", "2020-06-18", "InitSmartVerify", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string userId;

		private string certifyId;

		private string facePictureBase64;

		private string mode;

		private string certNo;

		private string outerOrderNo;

		private string certType;

		private string metaInfo;

		private string ocr;

		private string ossObjectName;

		private string facePictureUrl;

		private string ip;

		private string certName;

		private string mobile;

		private long? sceneId;

		private string callbackToken;

		private string ossBucketName;

		private string callbackUrl;

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(BodyParameters, "UserId", value);
			}
		}

		public string CertifyId
		{
			get
			{
				return certifyId;
			}
			set	
			{
				certifyId = value;
				DictionaryUtil.Add(BodyParameters, "CertifyId", value);
			}
		}

		public string FacePictureBase64
		{
			get
			{
				return facePictureBase64;
			}
			set	
			{
				facePictureBase64 = value;
				DictionaryUtil.Add(BodyParameters, "FacePictureBase64", value);
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

		public string MetaInfo
		{
			get
			{
				return metaInfo;
			}
			set	
			{
				metaInfo = value;
				DictionaryUtil.Add(BodyParameters, "MetaInfo", value);
			}
		}

		public string Ocr
		{
			get
			{
				return ocr;
			}
			set	
			{
				ocr = value;
				DictionaryUtil.Add(BodyParameters, "Ocr", value);
			}
		}

		public string OssObjectName
		{
			get
			{
				return ossObjectName;
			}
			set	
			{
				ossObjectName = value;
				DictionaryUtil.Add(BodyParameters, "OssObjectName", value);
			}
		}

		public string FacePictureUrl
		{
			get
			{
				return facePictureUrl;
			}
			set	
			{
				facePictureUrl = value;
				DictionaryUtil.Add(BodyParameters, "FacePictureUrl", value);
			}
		}

		public string Ip
		{
			get
			{
				return ip;
			}
			set	
			{
				ip = value;
				DictionaryUtil.Add(BodyParameters, "Ip", value);
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

		public string CallbackToken
		{
			get
			{
				return callbackToken;
			}
			set	
			{
				callbackToken = value;
				DictionaryUtil.Add(BodyParameters, "CallbackToken", value);
			}
		}

		public string OssBucketName
		{
			get
			{
				return ossBucketName;
			}
			set	
			{
				ossBucketName = value;
				DictionaryUtil.Add(BodyParameters, "OssBucketName", value);
			}
		}

		public string CallbackUrl
		{
			get
			{
				return callbackUrl;
			}
			set	
			{
				callbackUrl = value;
				DictionaryUtil.Add(BodyParameters, "CallbackUrl", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override InitSmartVerifyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InitSmartVerifyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
