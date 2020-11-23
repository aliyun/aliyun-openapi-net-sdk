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
    public class CompareFaceVerifyRequest : RpcAcsRequest<CompareFaceVerifyResponse>
    {
        public CompareFaceVerifyRequest()
            : base("Cloudauth", "2019-03-07", "CompareFaceVerify", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string targetFaceContrastPictureUrl;

		private string productCode;

		private string targetCertifyId;

		private string sourceOssObjectName;

		private string targetFaceContrastPicture;

		private string targetOssBucketName;

		private string sourceOssBucketName;

		private string outerOrderNo;

		private string targetOssObjectName;

		private string sourceFaceContrastPicture;

		private long? sceneId;

		private string sourceFaceContrastPictureUrl;

		private string sourceCertifyId;

		public string TargetFaceContrastPictureUrl
		{
			get
			{
				return targetFaceContrastPictureUrl;
			}
			set	
			{
				targetFaceContrastPictureUrl = value;
				DictionaryUtil.Add(BodyParameters, "TargetFaceContrastPictureUrl", value);
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
				DictionaryUtil.Add(BodyParameters, "ProductCode", value);
			}
		}

		public string TargetCertifyId
		{
			get
			{
				return targetCertifyId;
			}
			set	
			{
				targetCertifyId = value;
				DictionaryUtil.Add(BodyParameters, "TargetCertifyId", value);
			}
		}

		public string SourceOssObjectName
		{
			get
			{
				return sourceOssObjectName;
			}
			set	
			{
				sourceOssObjectName = value;
				DictionaryUtil.Add(BodyParameters, "SourceOssObjectName", value);
			}
		}

		public string TargetFaceContrastPicture
		{
			get
			{
				return targetFaceContrastPicture;
			}
			set	
			{
				targetFaceContrastPicture = value;
				DictionaryUtil.Add(BodyParameters, "TargetFaceContrastPicture", value);
			}
		}

		public string TargetOssBucketName
		{
			get
			{
				return targetOssBucketName;
			}
			set	
			{
				targetOssBucketName = value;
				DictionaryUtil.Add(BodyParameters, "TargetOssBucketName", value);
			}
		}

		public string SourceOssBucketName
		{
			get
			{
				return sourceOssBucketName;
			}
			set	
			{
				sourceOssBucketName = value;
				DictionaryUtil.Add(BodyParameters, "SourceOssBucketName", value);
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

		public string TargetOssObjectName
		{
			get
			{
				return targetOssObjectName;
			}
			set	
			{
				targetOssObjectName = value;
				DictionaryUtil.Add(BodyParameters, "TargetOssObjectName", value);
			}
		}

		public string SourceFaceContrastPicture
		{
			get
			{
				return sourceFaceContrastPicture;
			}
			set	
			{
				sourceFaceContrastPicture = value;
				DictionaryUtil.Add(BodyParameters, "SourceFaceContrastPicture", value);
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

		public string SourceFaceContrastPictureUrl
		{
			get
			{
				return sourceFaceContrastPictureUrl;
			}
			set	
			{
				sourceFaceContrastPictureUrl = value;
				DictionaryUtil.Add(BodyParameters, "SourceFaceContrastPictureUrl", value);
			}
		}

		public string SourceCertifyId
		{
			get
			{
				return sourceCertifyId;
			}
			set	
			{
				sourceCertifyId = value;
				DictionaryUtil.Add(BodyParameters, "SourceCertifyId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CompareFaceVerifyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CompareFaceVerifyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
