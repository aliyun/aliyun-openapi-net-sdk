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
using Aliyun.Acs.ImageSearch.Transform;
using Aliyun.Acs.ImageSearch.Transform.V20190325;

namespace Aliyun.Acs.ImageSearch.Model.V20190325
{
    public class AddImageRequest : RoaAcsRequest<AddImageResponse>
    {
        public AddImageRequest()
            : base("ImageSearch", "2019-03-25", "AddImage", "imagesearch", "openAPI")
        {
			UriPattern = "/v2/image/add";
			Method = MethodType.POST;
        }

		private string picContent;

		private string strAttr;

		private string instanceName;

		private int? intAttr;

		private string productId;

		private string picName;

		private string customContent;

		private string region;

		private int? categoryId;

		private bool? crop;

		public string PicContent
		{
			get
			{
				return picContent;
			}
			set	
			{
				picContent = value;
				DictionaryUtil.Add(BodyParameters, "PicContent", value);
			}
		}

		public string StrAttr
		{
			get
			{
				return strAttr;
			}
			set	
			{
				strAttr = value;
				DictionaryUtil.Add(BodyParameters, "StrAttr", value);
			}
		}

		public string InstanceName
		{
			get
			{
				return instanceName;
			}
			set	
			{
				instanceName = value;
				DictionaryUtil.Add(BodyParameters, "InstanceName", value);
			}
		}

		public int? IntAttr
		{
			get
			{
				return intAttr;
			}
			set	
			{
				intAttr = value;
				DictionaryUtil.Add(BodyParameters, "IntAttr", value.ToString());
			}
		}

		public string ProductId
		{
			get
			{
				return productId;
			}
			set	
			{
				productId = value;
				DictionaryUtil.Add(BodyParameters, "ProductId", value);
			}
		}

		public string PicName
		{
			get
			{
				return picName;
			}
			set	
			{
				picName = value;
				DictionaryUtil.Add(BodyParameters, "PicName", value);
			}
		}

		public string CustomContent
		{
			get
			{
				return customContent;
			}
			set	
			{
				customContent = value;
				DictionaryUtil.Add(BodyParameters, "CustomContent", value);
			}
		}

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(BodyParameters, "Region", value);
			}
		}

		public int? CategoryId
		{
			get
			{
				return categoryId;
			}
			set	
			{
				categoryId = value;
				DictionaryUtil.Add(BodyParameters, "CategoryId", value.ToString());
			}
		}

		public bool? Crop
		{
			get
			{
				return crop;
			}
			set	
			{
				crop = value;
				DictionaryUtil.Add(BodyParameters, "Crop", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddImageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
