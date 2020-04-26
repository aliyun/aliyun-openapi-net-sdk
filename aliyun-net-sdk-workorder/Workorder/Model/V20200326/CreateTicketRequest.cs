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
using Aliyun.Acs.Workorder.Transform;
using Aliyun.Acs.Workorder.Transform.V20200326;

namespace Aliyun.Acs.Workorder.Model.V20200326
{
    public class CreateTicketRequest : RpcAcsRequest<CreateTicketResponse>
    {
        public CreateTicketRequest()
            : base("Workorder", "2020-03-26", "CreateTicket", "workorder", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string productCode;

		private string language;

		private string title;

		private string content;

		private string notifyTimeRange;

		private string phone;

		private string category;

		private string email;

		private string secretContent;

		public string ProductCode
		{
			get
			{
				return productCode;
			}
			set	
			{
				productCode = value;
				DictionaryUtil.Add(QueryParameters, "ProductCode", value);
			}
		}

		public string Language
		{
			get
			{
				return language;
			}
			set	
			{
				language = value;
				DictionaryUtil.Add(QueryParameters, "Language", value);
			}
		}

		public string Title
		{
			get
			{
				return title;
			}
			set	
			{
				title = value;
				DictionaryUtil.Add(QueryParameters, "Title", value);
			}
		}

		public string Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
				DictionaryUtil.Add(QueryParameters, "Content", value);
			}
		}

		public string NotifyTimeRange
		{
			get
			{
				return notifyTimeRange;
			}
			set	
			{
				notifyTimeRange = value;
				DictionaryUtil.Add(QueryParameters, "NotifyTimeRange", value);
			}
		}

		public string Phone
		{
			get
			{
				return phone;
			}
			set	
			{
				phone = value;
				DictionaryUtil.Add(QueryParameters, "Phone", value);
			}
		}

		public string Category
		{
			get
			{
				return category;
			}
			set	
			{
				category = value;
				DictionaryUtil.Add(QueryParameters, "Category", value);
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

		public string SecretContent
		{
			get
			{
				return secretContent;
			}
			set	
			{
				secretContent = value;
				DictionaryUtil.Add(QueryParameters, "SecretContent", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateTicketResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTicketResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
