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
using Aliyun.Acs.Cloudauth.Transform.V20190307;

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
    public class ContrastFaceVerifyRequest : RpcAcsRequest<ContrastFaceVerifyResponse>
    {
        public ContrastFaceVerifyRequest()
            : base("Cloudauth", "2019-03-07", "ContrastFaceVerify", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string productCode;

		private string ossObjectName;

		private string faceContrastPicture;

		private string certName;

		private string ip;

		private string mobile;

		private string deviceToken;

		private string userId;

		private string certifyId;

		private string certNo;

		private string outerOrderNo;

		private string certType;

		private string faceContrastPictureUrl;

		private long? sceneId;

		private string ossBucketName;

		public string ProductCode
		{
			get
			{
				return productCode;
			}
			set	
			{
				productCode = value;
				DictionaryUtil.Add(QueryParameters, "ProductCode", value);
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
				DictionaryUtil.Add(QueryParameters, "OssObjectName", value);
			}
		}

		public string FaceContrastPicture
		{
			get
			{
				return faceContrastPicture;
			}
			set	
			{
				faceContrastPicture = value;
				DictionaryUtil.Add(QueryParameters, "FaceContrastPicture", value);
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
				DictionaryUtil.Add(QueryParameters, "CertName", value);
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
				DictionaryUtil.Add(QueryParameters, "Ip", value);
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
				DictionaryUtil.Add(QueryParameters, "Mobile", value);
			}
		}

		public string DeviceToken
		{
			get
			{
				return deviceToken;
			}
			set	
			{
				deviceToken = value;
				DictionaryUtil.Add(QueryParameters, "DeviceToken", value);
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value);
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
				DictionaryUtil.Add(QueryParameters, "CertifyId", value);
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
				DictionaryUtil.Add(QueryParameters, "CertNo", value);
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
				DictionaryUtil.Add(QueryParameters, "OuterOrderNo", value);
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
				DictionaryUtil.Add(QueryParameters, "CertType", value);
			}
		}

		public string FaceContrastPictureUrl
		{
			get
			{
				return faceContrastPictureUrl;
			}
			set	
			{
				faceContrastPictureUrl = value;
				DictionaryUtil.Add(QueryParameters, "FaceContrastPictureUrl", value);
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
				DictionaryUtil.Add(QueryParameters, "SceneId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "OssBucketName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ContrastFaceVerifyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ContrastFaceVerifyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
