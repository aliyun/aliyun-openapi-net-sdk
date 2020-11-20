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
using Aliyun.Acs.imageseg.Transform;
using Aliyun.Acs.imageseg.Transform.V20191230;

namespace Aliyun.Acs.imageseg.Model.V20191230
{
    public class SegmentHeadRequest : RpcAcsRequest<SegmentHeadResponse>
    {
        public SegmentHeadRequest()
            : base("imageseg", "2019-12-30", "SegmentHead", "imageseg", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imageseg.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imageseg.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string imageURL;

		public string ImageURL
		{
			get
			{
				return imageURL;
			}
			set	
			{
				imageURL = value;
				DictionaryUtil.Add(QueryParameters, "ImageURL", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SegmentHeadResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SegmentHeadResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
