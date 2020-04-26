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
    public class ReplyTicketRequest : RpcAcsRequest<ReplyTicketResponse>
    {
        public ReplyTicketRequest()
            : base("Workorder", "2020-03-26", "ReplyTicket", "workorder", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string language;

		private string ticketId;

		private string content;

		private string secretContent;

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

		public string TicketId
		{
			get
			{
				return ticketId;
			}
			set	
			{
				ticketId = value;
				DictionaryUtil.Add(QueryParameters, "TicketId", value);
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

        public override ReplyTicketResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ReplyTicketResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
