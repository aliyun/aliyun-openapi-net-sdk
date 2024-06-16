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
    public class InitFaceVerifyRequest : RpcAcsRequest<InitFaceVerifyResponse>
    {
        public InitFaceVerifyRequest()
            : base("Cloudauth", "2019-03-07", "InitFaceVerify", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string birthday;

		private string productCode;

		private string faceContrastPicture;

		private string readImg;

		private string rarelyCharacters;

		private string voluntaryCustomizedContent;

		private string userId;

		private string certifyId;

		private string encryptType;

		private string mode;

		private string certNo;

		private string outerOrderNo;

		private string certType;

		private string faceContrastPictureUrl;

		private string model;

		private string suitableType;

		private string certifyUrlStyle;

		private string metaInfo;

		private string ossObjectName;

		private string validityDate;

		private string certName;

		private string ip;

		private string mobile;

		private string faceGuardOutput;

		private string authId;

		private string procedurePriority;

		private long? sceneId;

		private string ossBucketName;

		private string callbackToken;

		private string returnUrl;

		private string callbackUrl;

		private string crop;

		private string certifyUrlType;

		public string Birthday
		{
			get
			{
				return birthday;
			}
			set	
			{
				birthday = value;
				DictionaryUtil.Add(QueryParameters, "Birthday", value);
			}
		}

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

		public string FaceContrastPicture
		{
			get
			{
				return faceContrastPicture;
			}
			set	
			{
				faceContrastPicture = value;
				DictionaryUtil.Add(BodyParameters, "FaceContrastPicture", value);
			}
		}

		public string ReadImg
		{
			get
			{
				return readImg;
			}
			set	
			{
				readImg = value;
				DictionaryUtil.Add(QueryParameters, "ReadImg", value);
			}
		}

		public string RarelyCharacters
		{
			get
			{
				return rarelyCharacters;
			}
			set	
			{
				rarelyCharacters = value;
				DictionaryUtil.Add(QueryParameters, "RarelyCharacters", value);
			}
		}

		public string VoluntaryCustomizedContent
		{
			get
			{
				return voluntaryCustomizedContent;
			}
			set	
			{
				voluntaryCustomizedContent = value;
				DictionaryUtil.Add(QueryParameters, "VoluntaryCustomizedContent", value);
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

		public string EncryptType
		{
			get
			{
				return encryptType;
			}
			set	
			{
				encryptType = value;
				DictionaryUtil.Add(QueryParameters, "EncryptType", value);
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
				DictionaryUtil.Add(QueryParameters, "Mode", value);
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

		public string Model
		{
			get
			{
				return model;
			}
			set	
			{
				model = value;
				DictionaryUtil.Add(BodyParameters, "Model", value);
			}
		}

		public string SuitableType
		{
			get
			{
				return suitableType;
			}
			set	
			{
				suitableType = value;
				DictionaryUtil.Add(QueryParameters, "SuitableType", value);
			}
		}

		public string CertifyUrlStyle
		{
			get
			{
				return certifyUrlStyle;
			}
			set	
			{
				certifyUrlStyle = value;
				DictionaryUtil.Add(QueryParameters, "CertifyUrlStyle", value);
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
				DictionaryUtil.Add(QueryParameters, "MetaInfo", value);
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

		public string ValidityDate
		{
			get
			{
				return validityDate;
			}
			set	
			{
				validityDate = value;
				DictionaryUtil.Add(QueryParameters, "ValidityDate", value);
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

		public string FaceGuardOutput
		{
			get
			{
				return faceGuardOutput;
			}
			set	
			{
				faceGuardOutput = value;
				DictionaryUtil.Add(QueryParameters, "FaceGuardOutput", value);
			}
		}

		public string AuthId
		{
			get
			{
				return authId;
			}
			set	
			{
				authId = value;
				DictionaryUtil.Add(BodyParameters, "AuthId", value);
			}
		}

		public string ProcedurePriority
		{
			get
			{
				return procedurePriority;
			}
			set	
			{
				procedurePriority = value;
				DictionaryUtil.Add(QueryParameters, "ProcedurePriority", value);
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

		public string CallbackToken
		{
			get
			{
				return callbackToken;
			}
			set	
			{
				callbackToken = value;
				DictionaryUtil.Add(QueryParameters, "CallbackToken", value);
			}
		}

		public string ReturnUrl
		{
			get
			{
				return returnUrl;
			}
			set	
			{
				returnUrl = value;
				DictionaryUtil.Add(QueryParameters, "ReturnUrl", value);
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
				DictionaryUtil.Add(QueryParameters, "CallbackUrl", value);
			}
		}

		public string Crop
		{
			get
			{
				return crop;
			}
			set	
			{
				crop = value;
				DictionaryUtil.Add(BodyParameters, "Crop", value);
			}
		}

		public string CertifyUrlType
		{
			get
			{
				return certifyUrlType;
			}
			set	
			{
				certifyUrlType = value;
				DictionaryUtil.Add(QueryParameters, "CertifyUrlType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override InitFaceVerifyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InitFaceVerifyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
