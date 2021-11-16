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
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170321;

namespace Aliyun.Acs.vod.Model.V20170321
{
    public class ListLetterSendJobRequest : RpcAcsRequest<ListLetterSendJobResponse>
    {
        public ListLetterSendJobRequest()
            : base("vod", "2017-03-21", "ListLetterSendJob", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.vod.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.vod.Endpoint.endpointRegionalType, null);
            }
        }

		private string toAddress;

		private string templateId;

		private string detectionId;

		public string ToAddress
		{
			get
			{
				return toAddress;
			}
			set	
			{
				toAddress = value;
				DictionaryUtil.Add(QueryParameters, "ToAddress", value);
			}
		}

		public string TemplateId
		{
			get
			{
				return templateId;
			}
			set	
			{
				templateId = value;
				DictionaryUtil.Add(QueryParameters, "TemplateId", value);
			}
		}

		public string DetectionId
		{
			get
			{
				return detectionId;
			}
			set	
			{
				detectionId = value;
				DictionaryUtil.Add(QueryParameters, "DetectionId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListLetterSendJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListLetterSendJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
