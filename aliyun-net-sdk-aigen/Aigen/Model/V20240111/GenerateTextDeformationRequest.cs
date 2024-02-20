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
    public class GenerateTextDeformationRequest : RpcAcsRequest<GenerateTextDeformationResponse>
    {
        public GenerateTextDeformationRequest()
            : base("aigen", "2024-01-11", "GenerateTextDeformation")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string textContent;

		private string fontName;

		private string ttfUrl;

		private long? n;

		private bool? async;

		private string prompt;

		private string outputImageRatio;

		public string TextContent
		{
			get
			{
				return textContent;
			}
			set	
			{
				textContent = value;
				DictionaryUtil.Add(BodyParameters, "TextContent", value);
			}
		}

		public string FontName
		{
			get
			{
				return fontName;
			}
			set	
			{
				fontName = value;
				DictionaryUtil.Add(BodyParameters, "FontName", value);
			}
		}

		public string TtfUrl
		{
			get
			{
				return ttfUrl;
			}
			set	
			{
				ttfUrl = value;
				DictionaryUtil.Add(BodyParameters, "TtfUrl", value);
			}
		}

		public long? N
		{
			get
			{
				return n;
			}
			set	
			{
				n = value;
				DictionaryUtil.Add(BodyParameters, "N", value.ToString());
			}
		}

		public bool? Async
		{
			get
			{
				return async;
			}
			set	
			{
				async = value;
				DictionaryUtil.Add(BodyParameters, "Async", value.ToString());
			}
		}

		public string Prompt
		{
			get
			{
				return prompt;
			}
			set	
			{
				prompt = value;
				DictionaryUtil.Add(BodyParameters, "Prompt", value);
			}
		}

		public string OutputImageRatio
		{
			get
			{
				return outputImageRatio;
			}
			set	
			{
				outputImageRatio = value;
				DictionaryUtil.Add(BodyParameters, "OutputImageRatio", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GenerateTextDeformationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GenerateTextDeformationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
