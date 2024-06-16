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
    public class InteractiveScribbleSegmentationRequest : RpcAcsRequest<InteractiveScribbleSegmentationResponse>
    {
        public InteractiveScribbleSegmentationRequest()
            : base("aigen", "2024-01-11", "InteractiveScribbleSegmentation")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string posScribbleImageUrl;

		private string integratedMaskUrl;

		private string maskImageUrl;

		private string returnForm;

		private string negScribbleImageUrl;

		private string returnFormat;

		private string edgeFeathering;

		private string imageUrl;

		private string postprocessOption;

		public string PosScribbleImageUrl
		{
			get
			{
				return posScribbleImageUrl;
			}
			set	
			{
				posScribbleImageUrl = value;
				DictionaryUtil.Add(BodyParameters, "PosScribbleImageUrl", value);
			}
		}

		public string IntegratedMaskUrl
		{
			get
			{
				return integratedMaskUrl;
			}
			set	
			{
				integratedMaskUrl = value;
				DictionaryUtil.Add(BodyParameters, "IntegratedMaskUrl", value);
			}
		}

		public string MaskImageUrl
		{
			get
			{
				return maskImageUrl;
			}
			set	
			{
				maskImageUrl = value;
				DictionaryUtil.Add(BodyParameters, "MaskImageUrl", value);
			}
		}

		public string ReturnForm
		{
			get
			{
				return returnForm;
			}
			set	
			{
				returnForm = value;
				DictionaryUtil.Add(BodyParameters, "ReturnForm", value);
			}
		}

		public string NegScribbleImageUrl
		{
			get
			{
				return negScribbleImageUrl;
			}
			set	
			{
				negScribbleImageUrl = value;
				DictionaryUtil.Add(BodyParameters, "NegScribbleImageUrl", value);
			}
		}

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

		public string EdgeFeathering
		{
			get
			{
				return edgeFeathering;
			}
			set	
			{
				edgeFeathering = value;
				DictionaryUtil.Add(BodyParameters, "EdgeFeathering", value);
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

		public string PostprocessOption
		{
			get
			{
				return postprocessOption;
			}
			set	
			{
				postprocessOption = value;
				DictionaryUtil.Add(BodyParameters, "PostprocessOption", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override InteractiveScribbleSegmentationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InteractiveScribbleSegmentationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
