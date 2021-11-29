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
    public class DescribeDcdnSLSRealtimeLogDeliveryResponseUnmarshaller
    {
        public static DescribeDcdnSLSRealtimeLogDeliveryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnSLSRealtimeLogDeliveryResponse describeDcdnSLSRealtimeLogDeliveryResponse = new DescribeDcdnSLSRealtimeLogDeliveryResponse();

			describeDcdnSLSRealtimeLogDeliveryResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnSLSRealtimeLogDeliveryResponse.RequestId = _ctx.StringValue("DescribeDcdnSLSRealtimeLogDelivery.RequestId");

			DescribeDcdnSLSRealtimeLogDeliveryResponse.DescribeDcdnSLSRealtimeLogDelivery_Content content = new DescribeDcdnSLSRealtimeLogDeliveryResponse.DescribeDcdnSLSRealtimeLogDelivery_Content();
			content.ProjectName = _ctx.StringValue("DescribeDcdnSLSRealtimeLogDelivery.Content.ProjectName");
			content.DomainName = _ctx.StringValue("DescribeDcdnSLSRealtimeLogDelivery.Content.DomainName");
			content.FieldName = _ctx.StringValue("DescribeDcdnSLSRealtimeLogDelivery.Content.FieldName");
			content.SamplingRate = _ctx.StringValue("DescribeDcdnSLSRealtimeLogDelivery.Content.SamplingRate");
			content.DataCenter = _ctx.StringValue("DescribeDcdnSLSRealtimeLogDelivery.Content.DataCenter");
			content.SLSRegion = _ctx.StringValue("DescribeDcdnSLSRealtimeLogDelivery.Content.SLSRegion");
			content.SLSProject = _ctx.StringValue("DescribeDcdnSLSRealtimeLogDelivery.Content.SLSProject");
			content.SLSLogStore = _ctx.StringValue("DescribeDcdnSLSRealtimeLogDelivery.Content.SLSLogStore");
			content.BusinessType = _ctx.StringValue("DescribeDcdnSLSRealtimeLogDelivery.Content.BusinessType");
			content.Type = _ctx.StringValue("DescribeDcdnSLSRealtimeLogDelivery.Content.Type");
			describeDcdnSLSRealtimeLogDeliveryResponse.Content = content;
        
			return describeDcdnSLSRealtimeLogDeliveryResponse;
        }
    }
}
