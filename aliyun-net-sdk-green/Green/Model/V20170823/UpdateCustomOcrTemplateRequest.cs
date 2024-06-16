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
    public class UpdateCustomOcrTemplateRequest : RpcAcsRequest<UpdateCustomOcrTemplateResponse>
    {
        public UpdateCustomOcrTemplateRequest()
            : base("Green", "2017-08-23", "UpdateCustomOcrTemplate", "green", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string recognizeArea;

		private string referArea;

		private string name;

		private long? id;

		public string RecognizeArea
		{
			get
			{
				return recognizeArea;
			}
			set	
			{
				recognizeArea = value;
				DictionaryUtil.Add(QueryParameters, "RecognizeArea", value);
			}
		}

		public string ReferArea
		{
			get
			{
				return referArea;
			}
			set	
			{
				referArea = value;
				DictionaryUtil.Add(QueryParameters, "ReferArea", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateCustomOcrTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateCustomOcrTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
