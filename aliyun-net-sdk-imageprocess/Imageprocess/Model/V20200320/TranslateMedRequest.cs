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
using Aliyun.Acs.imageprocess.Transform;
using Aliyun.Acs.imageprocess.Transform.V20200320;

namespace Aliyun.Acs.imageprocess.Model.V20200320
{
    public class TranslateMedRequest : RpcAcsRequest<TranslateMedResponse>
    {
        public TranslateMedRequest()
            : base("imageprocess", "2020-03-20", "TranslateMed", "imageprocess", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imageprocess.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imageprocess.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string fromLanguage;

		private string toLanguage;

		private string text;

		public string FromLanguage
		{
			get
			{
				return fromLanguage;
			}
			set	
			{
				fromLanguage = value;
				DictionaryUtil.Add(BodyParameters, "FromLanguage", value);
			}
		}

		public string ToLanguage
		{
			get
			{
				return toLanguage;
			}
			set	
			{
				toLanguage = value;
				DictionaryUtil.Add(BodyParameters, "ToLanguage", value);
			}
		}

		public string Text
		{
			get
			{
				return text;
			}
			set	
			{
				text = value;
				DictionaryUtil.Add(BodyParameters, "Text", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override TranslateMedResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return TranslateMedResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
