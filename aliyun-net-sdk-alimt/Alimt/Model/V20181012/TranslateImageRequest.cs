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
using Aliyun.Acs.alimt;
using Aliyun.Acs.alimt.Transform;
using Aliyun.Acs.alimt.Transform.V20181012;

namespace Aliyun.Acs.alimt.Model.V20181012
{
    public class TranslateImageRequest : RpcAcsRequest<TranslateImageResponse>
    {
        public TranslateImageRequest()
            : base("alimt", "2018-10-12", "TranslateImage")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.alimt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.alimt.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string ext;

		private string sourceLanguage;

		private string field;

		private string imageUrl;

		private string targetLanguage;

		private string imageBase64;

		public string Ext
		{
			get
			{
				return ext;
			}
			set	
			{
				ext = value;
				DictionaryUtil.Add(BodyParameters, "Ext", value);
			}
		}

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

		public string Field
		{
			get
			{
				return field;
			}
			set	
			{
				field = value;
				DictionaryUtil.Add(BodyParameters, "Field", value);
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

		public string ImageBase64
		{
			get
			{
				return imageBase64;
			}
			set	
			{
				imageBase64 = value;
				DictionaryUtil.Add(BodyParameters, "ImageBase64", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override TranslateImageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return TranslateImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
