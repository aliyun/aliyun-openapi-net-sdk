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
    public class OnsMessageGetByMsgIdResponseUnmarshaller
    {
        public static OnsMessageGetByMsgIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsMessageGetByMsgIdResponse onsMessageGetByMsgIdResponse = new OnsMessageGetByMsgIdResponse();

			onsMessageGetByMsgIdResponse.HttpResponse = _ctx.HttpResponse;
			onsMessageGetByMsgIdResponse.RequestId = _ctx.StringValue("OnsMessageGetByMsgId.RequestId");
			onsMessageGetByMsgIdResponse.HelpUrl = _ctx.StringValue("OnsMessageGetByMsgId.HelpUrl");

			OnsMessageGetByMsgIdResponse.OnsMessageGetByMsgId_Data data = new OnsMessageGetByMsgIdResponse.OnsMessageGetByMsgId_Data();
			data.Topic = _ctx.StringValue("OnsMessageGetByMsgId.Data.Topic");
			data.Flag = _ctx.IntegerValue("OnsMessageGetByMsgId.Data.Flag");
			data.Body = _ctx.StringValue("OnsMessageGetByMsgId.Data.Body");
			data.StoreSize = _ctx.IntegerValue("OnsMessageGetByMsgId.Data.StoreSize");
			data.BornTimestamp = _ctx.LongValue("OnsMessageGetByMsgId.Data.BornTimestamp");
			data.BornHost = _ctx.StringValue("OnsMessageGetByMsgId.Data.BornHost");
			data.StoreTimestamp = _ctx.LongValue("OnsMessageGetByMsgId.Data.StoreTimestamp");
			data.StoreHost = _ctx.StringValue("OnsMessageGetByMsgId.Data.StoreHost");
			data.MsgId = _ctx.StringValue("OnsMessageGetByMsgId.Data.MsgId");
			data.OffsetId = _ctx.StringValue("OnsMessageGetByMsgId.Data.OffsetId");
			data.BodyCRC = _ctx.IntegerValue("OnsMessageGetByMsgId.Data.BodyCRC");
			data.ReconsumeTimes = _ctx.IntegerValue("OnsMessageGetByMsgId.Data.ReconsumeTimes");
			data.InstanceId = _ctx.StringValue("OnsMessageGetByMsgId.Data.InstanceId");

			List<OnsMessageGetByMsgIdResponse.OnsMessageGetByMsgId_Data.OnsMessageGetByMsgId_MessageProperty> data_propertyList = new List<OnsMessageGetByMsgIdResponse.OnsMessageGetByMsgId_Data.OnsMessageGetByMsgId_MessageProperty>();
			for (int i = 0; i < _ctx.Length("OnsMessageGetByMsgId.Data.PropertyList.Length"); i++) {
				OnsMessageGetByMsgIdResponse.OnsMessageGetByMsgId_Data.OnsMessageGetByMsgId_MessageProperty messageProperty = new OnsMessageGetByMsgIdResponse.OnsMessageGetByMsgId_Data.OnsMessageGetByMsgId_MessageProperty();
				messageProperty.Name = _ctx.StringValue("OnsMessageGetByMsgId.Data.PropertyList["+ i +"].Name");
				messageProperty._Value = _ctx.StringValue("OnsMessageGetByMsgId.Data.PropertyList["+ i +"].Value");

				data_propertyList.Add(messageProperty);
			}
			data.PropertyList = data_propertyList;
			onsMessageGetByMsgIdResponse.Data = data;
        
			return onsMessageGetByMsgIdResponse;
        }
    }
}
