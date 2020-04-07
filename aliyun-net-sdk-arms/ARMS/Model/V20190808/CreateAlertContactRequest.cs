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
using Aliyun.Acs.ARMS.Transform;
using Aliyun.Acs.ARMS.Transform.V20190808;

namespace Aliyun.Acs.ARMS.Model.V20190808
{
    public class CreateAlertContactRequest : RpcAcsRequest<CreateAlertContactResponse>
    {
        public CreateAlertContactRequest()
            : base("ARMS", "2019-08-08", "CreateAlertContact", "arms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string phoneNum;

		private string proxyUserId;

		private string contactName;

		private string dingRobotWebhookUrl;

		private string email;

		private bool? systemNoc;

		public string PhoneNum
		{
			get
			{
				return phoneNum;
			}
			set	
			{
				phoneNum = value;
				DictionaryUtil.Add(QueryParameters, "PhoneNum", value);
			}
		}

		public string ProxyUserId
		{
			get
			{
				return proxyUserId;
			}
			set	
			{
				proxyUserId = value;
				DictionaryUtil.Add(QueryParameters, "ProxyUserId", value);
			}
		}

		public string ContactName
		{
			get
			{
				return contactName;
			}
			set	
			{
				contactName = value;
				DictionaryUtil.Add(QueryParameters, "ContactName", value);
			}
		}

		public string DingRobotWebhookUrl
		{
			get
			{
				return dingRobotWebhookUrl;
			}
			set	
			{
				dingRobotWebhookUrl = value;
				DictionaryUtil.Add(QueryParameters, "DingRobotWebhookUrl", value);
			}
		}

		public string Email
		{
			get
			{
				return email;
			}
			set	
			{
				email = value;
				DictionaryUtil.Add(QueryParameters, "Email", value);
			}
		}

		public bool? SystemNoc
		{
			get
			{
				return systemNoc;
			}
			set	
			{
				systemNoc = value;
				DictionaryUtil.Add(QueryParameters, "SystemNoc", value.ToString());
			}
		}

        public override CreateAlertContactResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateAlertContactResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
