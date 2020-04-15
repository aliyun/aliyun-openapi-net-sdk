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
using Aliyun.Acs.Trademark.Transform;
using Aliyun.Acs.Trademark.Transform.V20180724;

namespace Aliyun.Acs.Trademark.Model.V20180724
{
    public class ApplyNotaryPostRequest : RpcAcsRequest<ApplyNotaryPostResponse>
    {
        public ApplyNotaryPostRequest()
            : base("Trademark", "2018-07-24", "ApplyNotaryPost", "trademark", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string receiverName;

		private string receiverPhone;

		private long? notaryOrderId;

		private string receiverAddress;

		public string ReceiverName
		{
			get
			{
				return receiverName;
			}
			set	
			{
				receiverName = value;
				DictionaryUtil.Add(QueryParameters, "ReceiverName", value);
			}
		}

		public string ReceiverPhone
		{
			get
			{
				return receiverPhone;
			}
			set	
			{
				receiverPhone = value;
				DictionaryUtil.Add(QueryParameters, "ReceiverPhone", value);
			}
		}

		public long? NotaryOrderId
		{
			get
			{
				return notaryOrderId;
			}
			set	
			{
				notaryOrderId = value;
				DictionaryUtil.Add(QueryParameters, "NotaryOrderId", value.ToString());
			}
		}

		public string ReceiverAddress
		{
			get
			{
				return receiverAddress;
			}
			set	
			{
				receiverAddress = value;
				DictionaryUtil.Add(QueryParameters, "ReceiverAddress", value);
			}
		}

        public override ApplyNotaryPostResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ApplyNotaryPostResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
