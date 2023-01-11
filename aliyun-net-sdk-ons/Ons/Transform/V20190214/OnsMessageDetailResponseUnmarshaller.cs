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
using Aliyun.Acs.Ons.Model.V20190214;

namespace Aliyun.Acs.Ons.Transform.V20190214
{
    public class OnsMessageDetailResponseUnmarshaller
    {
        public static OnsMessageDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsMessageDetailResponse onsMessageDetailResponse = new OnsMessageDetailResponse();

			onsMessageDetailResponse.HttpResponse = _ctx.HttpResponse;
			onsMessageDetailResponse.RequestId = _ctx.StringValue("OnsMessageDetail.RequestId");
			onsMessageDetailResponse.HelpUrl = _ctx.StringValue("OnsMessageDetail.HelpUrl");

			OnsMessageDetailResponse.OnsMessageDetail_Data data = new OnsMessageDetailResponse.OnsMessageDetail_Data();
			data.OffsetId = _ctx.StringValue("OnsMessageDetail.Data.OffsetId");
			data.StoreSize = _ctx.IntegerValue("OnsMessageDetail.Data.StoreSize");
			data.ReconsumeTimes = _ctx.IntegerValue("OnsMessageDetail.Data.ReconsumeTimes");
			data.StoreTimestamp = _ctx.LongValue("OnsMessageDetail.Data.StoreTimestamp");
			data.Body = _ctx.StringValue("OnsMessageDetail.Data.Body");
			data.InstanceId = _ctx.StringValue("OnsMessageDetail.Data.InstanceId");
			data.MsgId = _ctx.StringValue("OnsMessageDetail.Data.MsgId");
			data.Flag = _ctx.IntegerValue("OnsMessageDetail.Data.Flag");
			data.StoreHost = _ctx.StringValue("OnsMessageDetail.Data.StoreHost");
			data.Topic = _ctx.StringValue("OnsMessageDetail.Data.Topic");
			data.BornTimestamp = _ctx.LongValue("OnsMessageDetail.Data.BornTimestamp");
			data.BodyCRC = _ctx.IntegerValue("OnsMessageDetail.Data.BodyCRC");
			data.BornHost = _ctx.StringValue("OnsMessageDetail.Data.BornHost");

			List<OnsMessageDetailResponse.OnsMessageDetail_Data.OnsMessageDetail_MessageProperty> data_propertyList = new List<OnsMessageDetailResponse.OnsMessageDetail_Data.OnsMessageDetail_MessageProperty>();
			for (int i = 0; i < _ctx.Length("OnsMessageDetail.Data.PropertyList.Length"); i++) {
				OnsMessageDetailResponse.OnsMessageDetail_Data.OnsMessageDetail_MessageProperty messageProperty = new OnsMessageDetailResponse.OnsMessageDetail_Data.OnsMessageDetail_MessageProperty();
				messageProperty._Value = _ctx.StringValue("OnsMessageDetail.Data.PropertyList["+ i +"].Value");
				messageProperty.Name = _ctx.StringValue("OnsMessageDetail.Data.PropertyList["+ i +"].Name");

				data_propertyList.Add(messageProperty);
			}
			data.PropertyList = data_propertyList;
			onsMessageDetailResponse.Data = data;
        
			return onsMessageDetailResponse;
        }
    }
}
