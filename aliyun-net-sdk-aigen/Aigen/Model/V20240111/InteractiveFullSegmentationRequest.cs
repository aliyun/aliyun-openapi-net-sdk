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
using Aliyun.Acs.aigen;
using Aliyun.Acs.aigen.Transform;
using Aliyun.Acs.aigen.Transform.V20240111;

namespace Aliyun.Acs.aigen.Model.V20240111
{
    public class InteractiveFullSegmentationRequest : RpcAcsRequest<InteractiveFullSegmentationResponse>
    {
        public InteractiveFullSegmentationRequest()
            : base("aigen", "2024-01-11", "InteractiveFullSegmentation")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string returnFormat;

		private string imageUrl;

		public string ReturnFormat
		{
			get
			{
				return returnFormat;
			}
			set	
			{
				returnFormat = value;
				DictionaryUtil.Add(BodyParameters, "ReturnFormat", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override InteractiveFullSegmentationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InteractiveFullSegmentationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
