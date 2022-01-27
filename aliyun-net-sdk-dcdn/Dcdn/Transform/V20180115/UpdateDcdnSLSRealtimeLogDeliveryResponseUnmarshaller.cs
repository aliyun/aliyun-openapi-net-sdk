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
    public class UpdateDcdnSLSRealtimeLogDeliveryResponseUnmarshaller
    {
        public static UpdateDcdnSLSRealtimeLogDeliveryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateDcdnSLSRealtimeLogDeliveryResponse updateDcdnSLSRealtimeLogDeliveryResponse = new UpdateDcdnSLSRealtimeLogDeliveryResponse();

			updateDcdnSLSRealtimeLogDeliveryResponse.HttpResponse = _ctx.HttpResponse;
			updateDcdnSLSRealtimeLogDeliveryResponse.RequestId = _ctx.StringValue("UpdateDcdnSLSRealtimeLogDelivery.RequestId");

			List<UpdateDcdnSLSRealtimeLogDeliveryResponse.UpdateDcdnSLSRealtimeLogDelivery_Domains> updateDcdnSLSRealtimeLogDeliveryResponse_content = new List<UpdateDcdnSLSRealtimeLogDeliveryResponse.UpdateDcdnSLSRealtimeLogDelivery_Domains>();
			for (int i = 0; i < _ctx.Length("UpdateDcdnSLSRealtimeLogDelivery.Content.Length"); i++) {
				UpdateDcdnSLSRealtimeLogDeliveryResponse.UpdateDcdnSLSRealtimeLogDelivery_Domains domains = new UpdateDcdnSLSRealtimeLogDeliveryResponse.UpdateDcdnSLSRealtimeLogDelivery_Domains();
				domains.DomainName = _ctx.StringValue("UpdateDcdnSLSRealtimeLogDelivery.Content["+ i +"].DomainName");
				domains.Region = _ctx.StringValue("UpdateDcdnSLSRealtimeLogDelivery.Content["+ i +"].Region");
				domains.Status = _ctx.StringValue("UpdateDcdnSLSRealtimeLogDelivery.Content["+ i +"].Status");
				domains.Desc = _ctx.StringValue("UpdateDcdnSLSRealtimeLogDelivery.Content["+ i +"].Desc");

				updateDcdnSLSRealtimeLogDeliveryResponse_content.Add(domains);
			}
			updateDcdnSLSRealtimeLogDeliveryResponse.Content = updateDcdnSLSRealtimeLogDeliveryResponse_content;
        
			return updateDcdnSLSRealtimeLogDeliveryResponse;
        }
    }
}
