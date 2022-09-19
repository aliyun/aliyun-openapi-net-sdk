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
using Aliyun.Acs.threedvision;
using Aliyun.Acs.threedvision.Transform;
using Aliyun.Acs.threedvision.Transform.V20210131;

namespace Aliyun.Acs.threedvision.Model.V20210131
{
    public class EstimateStereoImageDepthRequest : RpcAcsRequest<EstimateStereoImageDepthResponse>
    {
        public EstimateStereoImageDepthRequest()
            : base("threedvision", "2021-01-31", "EstimateStereoImageDepth")
        {
			Method = MethodType.POST;
        }

		private string rightImageURL;

		private string leftImageURL;

		public string RightImageURL
		{
			get
			{
				return rightImageURL;
			}
			set	
			{
				rightImageURL = value;
				DictionaryUtil.Add(BodyParameters, "RightImageURL", value);
			}
		}

		public string LeftImageURL
		{
			get
			{
				return leftImageURL;
			}
			set	
			{
				leftImageURL = value;
				DictionaryUtil.Add(BodyParameters, "LeftImageURL", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override EstimateStereoImageDepthResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return EstimateStereoImageDepthResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
