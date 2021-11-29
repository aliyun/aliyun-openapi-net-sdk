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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class CreateDcdnSLSRealTimeLogDeliveryResponseUnmarshaller
    {
        public static CreateDcdnSLSRealTimeLogDeliveryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateDcdnSLSRealTimeLogDeliveryResponse createDcdnSLSRealTimeLogDeliveryResponse = new CreateDcdnSLSRealTimeLogDeliveryResponse();

			createDcdnSLSRealTimeLogDeliveryResponse.HttpResponse = _ctx.HttpResponse;
			createDcdnSLSRealTimeLogDeliveryResponse.RequestId = _ctx.StringValue("CreateDcdnSLSRealTimeLogDelivery.RequestId");

			List<CreateDcdnSLSRealTimeLogDeliveryResponse.CreateDcdnSLSRealTimeLogDelivery_Domains> createDcdnSLSRealTimeLogDeliveryResponse_content = new List<CreateDcdnSLSRealTimeLogDeliveryResponse.CreateDcdnSLSRealTimeLogDelivery_Domains>();
			for (int i = 0; i < _ctx.Length("CreateDcdnSLSRealTimeLogDelivery.Content.Length"); i++) {
				CreateDcdnSLSRealTimeLogDeliveryResponse.CreateDcdnSLSRealTimeLogDelivery_Domains domains = new CreateDcdnSLSRealTimeLogDeliveryResponse.CreateDcdnSLSRealTimeLogDelivery_Domains();
				domains.DomainName = _ctx.StringValue("CreateDcdnSLSRealTimeLogDelivery.Content["+ i +"].DomainName");
				domains.Region = _ctx.StringValue("CreateDcdnSLSRealTimeLogDelivery.Content["+ i +"].Region");
				domains.Status = _ctx.StringValue("CreateDcdnSLSRealTimeLogDelivery.Content["+ i +"].Status");
				domains.Desc = _ctx.StringValue("CreateDcdnSLSRealTimeLogDelivery.Content["+ i +"].Desc");

				createDcdnSLSRealTimeLogDeliveryResponse_content.Add(domains);
			}
			createDcdnSLSRealTimeLogDeliveryResponse.Content = createDcdnSLSRealTimeLogDeliveryResponse_content;
        
			return createDcdnSLSRealTimeLogDeliveryResponse;
        }
    }
}
