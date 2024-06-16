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
    public class GenerateCosplayImageRequest : RpcAcsRequest<GenerateCosplayImageResponse>
    {
        public GenerateCosplayImageRequest()
            : base("aigen", "2024-01-11", "GenerateCosplayImage")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string templateImageUrl;

		private string faceImageUrl;

		private long? style;

		public string TemplateImageUrl
		{
			get
			{
				return templateImageUrl;
			}
			set	
			{
				templateImageUrl = value;
				DictionaryUtil.Add(BodyParameters, "TemplateImageUrl", value);
			}
		}

		public string FaceImageUrl
		{
			get
			{
				return faceImageUrl;
			}
			set	
			{
				faceImageUrl = value;
				DictionaryUtil.Add(BodyParameters, "FaceImageUrl", value);
			}
		}

		public long? Style
		{
			get
			{
				return style;
			}
			set	
			{
				style = value;
				DictionaryUtil.Add(BodyParameters, "Style", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GenerateCosplayImageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GenerateCosplayImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
