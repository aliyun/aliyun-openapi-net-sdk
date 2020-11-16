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
using Aliyun.Acs.alimt.Transform;
using Aliyun.Acs.alimt.Transform.V20181012;

namespace Aliyun.Acs.alimt.Model.V20181012
{
    public class TranslateCertificateRequest : RpcAcsRequest<TranslateCertificateResponse>
    {
        public TranslateCertificateRequest()
            : base("alimt", "2018-10-12", "TranslateCertificate", "alimt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.alimt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.alimt.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sourceLanguage;

		private string certificateType;

		private string resultType;

		private string imageUrl;

		private string targetLanguage;

		public string SourceLanguage
		{
			get
			{
				return sourceLanguage;
			}
			set	
			{
				sourceLanguage = value;
				DictionaryUtil.Add(BodyParameters, "SourceLanguage", value);
			}
		}

		public string CertificateType
		{
			get
			{
				return certificateType;
			}
			set	
			{
				certificateType = value;
				DictionaryUtil.Add(BodyParameters, "CertificateType", value);
			}
		}

		public string ResultType
		{
			get
			{
				return resultType;
			}
			set	
			{
				resultType = value;
				DictionaryUtil.Add(BodyParameters, "ResultType", value);
			}
		}

		public string ImageUrl
		{
			get
			{
				return imageUrl;
			}
			set	
			{
				imageUrl = value;
				DictionaryUtil.Add(BodyParameters, "ImageUrl", value);
			}
		}

		public string TargetLanguage
		{
			get
			{
				return targetLanguage;
			}
			set	
			{
				targetLanguage = value;
				DictionaryUtil.Add(BodyParameters, "TargetLanguage", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override TranslateCertificateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return TranslateCertificateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
