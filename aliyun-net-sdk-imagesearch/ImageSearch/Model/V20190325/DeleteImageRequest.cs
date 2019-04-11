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
    public class DeleteImageRequest : RoaAcsRequest<DeleteImageResponse>
    {
        public DeleteImageRequest()
            : base("ImageSearch", "2019-03-25", "DeleteImage", "imagesearch", "openAPI")
        {
			UriPattern = "/v2/image/delete";
			Method = MethodType.POST;
        }

		private string instanceName;

		private string productId;

		private string picName;

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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteImageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
