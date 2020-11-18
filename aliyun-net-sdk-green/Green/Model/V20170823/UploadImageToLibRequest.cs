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
using Aliyun.Acs.Green.Transform;
using Aliyun.Acs.Green.Transform.V20170823;

namespace Aliyun.Acs.Green.Model.V20170823
{
    public class UploadImageToLibRequest : RpcAcsRequest<UploadImageToLibResponse>
    {
        public UploadImageToLibRequest()
            : base("Green", "2017-08-23", "UploadImageToLib", "green", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string images;

		private string urls;

		private string sourceIp;

		private int? imageLibId;

		public string Images
		{
			get
			{
				return images;
			}
			set	
			{
				images = value;
				DictionaryUtil.Add(QueryParameters, "Images", value);
			}
		}

		public string Urls
		{
			get
			{
				return urls;
			}
			set	
			{
				urls = value;
				DictionaryUtil.Add(QueryParameters, "Urls", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public int? ImageLibId
		{
			get
			{
				return imageLibId;
			}
			set	
			{
				imageLibId = value;
				DictionaryUtil.Add(QueryParameters, "ImageLibId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UploadImageToLibResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UploadImageToLibResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
