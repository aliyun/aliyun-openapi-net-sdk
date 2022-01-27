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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CDRS;
using Aliyun.Acs.CDRS.Transform;
using Aliyun.Acs.CDRS.Transform.V20201101;

namespace Aliyun.Acs.CDRS.Model.V20201101
{
    public class RecognizeImageRequest : RpcAcsRequest<RecognizeImageResponse>
    {
        public RecognizeImageRequest()
            : base("CDRS", "2020-11-01", "RecognizeImage")
        {
			Method = MethodType.POST;
        }

		private bool? requireCropImage;

		private string corpId;

		private string recognizeType;

		private string vendor;

		private string imageUrl;

		private string imageContent;

		public bool? RequireCropImage
		{
			get
			{
				return requireCropImage;
			}
			set	
			{
				requireCropImage = value;
				DictionaryUtil.Add(BodyParameters, "RequireCropImage", value.ToString());
			}
		}

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
			}
		}

		public string RecognizeType
		{
			get
			{
				return recognizeType;
			}
			set	
			{
				recognizeType = value;
				DictionaryUtil.Add(BodyParameters, "RecognizeType", value);
			}
		}

		public string Vendor
		{
			get
			{
				return vendor;
			}
			set	
			{
				vendor = value;
				DictionaryUtil.Add(BodyParameters, "Vendor", value);
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

		public string ImageContent
		{
			get
			{
				return imageContent;
			}
			set	
			{
				imageContent = value;
				DictionaryUtil.Add(BodyParameters, "ImageContent", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RecognizeImageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RecognizeImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
