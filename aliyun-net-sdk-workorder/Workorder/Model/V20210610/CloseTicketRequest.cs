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
using Aliyun.Acs.Workorder;
using Aliyun.Acs.Workorder.Transform;
using Aliyun.Acs.Workorder.Transform.V20210610;

namespace Aliyun.Acs.Workorder.Model.V20210610
{
    public class CloseTicketRequest : RpcAcsRequest<CloseTicketResponse>
    {
        public CloseTicketRequest()
            : base("Workorder", "2021-06-10", "CloseTicket")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Workorder.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Workorder.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string ticketId;

		public string TicketId
		{
			get
			{
				return ticketId;
			}
			set	
			{
				ticketId = value;
				DictionaryUtil.Add(BodyParameters, "TicketId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CloseTicketResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CloseTicketResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
