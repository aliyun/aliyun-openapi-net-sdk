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
using Aliyun.Acs.amqp_open.Transform;
using Aliyun.Acs.amqp_open.Transform.V20191212;

namespace Aliyun.Acs.amqp_open.Model.V20191212
{
    public class DeleteAccountRequest : RpcAcsRequest<DeleteAccountResponse>
    {
        public DeleteAccountRequest()
            : base("amqp-open", "2019-12-12", "DeleteAccount", "onsproxy", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.amqp_open.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.amqp_open.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? createTimestamp;

		private string userName;

		public long? CreateTimestamp
		{
			get
			{
				return createTimestamp;
			}
			set	
			{
				createTimestamp = value;
				DictionaryUtil.Add(QueryParameters, "CreateTimestamp", value.ToString());
			}
		}

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
				DictionaryUtil.Add(QueryParameters, "UserName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteAccountResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteAccountResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
