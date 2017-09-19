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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ons.Model.V20170918;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ons.Transform.V20170918
{
    public class OnsMessageGetByMsgIdResponseUnmarshaller
    {
        public static OnsMessageGetByMsgIdResponse Unmarshall(UnmarshallerContext context)
        {
			OnsMessageGetByMsgIdResponse onsMessageGetByMsgIdResponse = new OnsMessageGetByMsgIdResponse();

			onsMessageGetByMsgIdResponse.HttpResponse = context.HttpResponse;
			onsMessageGetByMsgIdResponse.RequestId = context.StringValue("OnsMessageGetByMsgId.RequestId");
			onsMessageGetByMsgIdResponse.HelpUrl = context.StringValue("OnsMessageGetByMsgId.HelpUrl");

			OnsMessageGetByMsgIdResponse.OnsMessageGetByMsgId_Data data = new OnsMessageGetByMsgIdResponse.OnsMessageGetByMsgId_Data();
			data.Topic = context.StringValue("OnsMessageGetByMsgId.Data.Topic");
			data.Flag = context.IntegerValue("OnsMessageGetByMsgId.Data.Flag");
			data.Body = context.StringValue("OnsMessageGetByMsgId.Data.Body");
			data.StoreSize = context.IntegerValue("OnsMessageGetByMsgId.Data.StoreSize");
			data.BornTimestamp = context.LongValue("OnsMessageGetByMsgId.Data.BornTimestamp");
			data.BornHost = context.StringValue("OnsMessageGetByMsgId.Data.BornHost");
			data.StoreTimestamp = context.LongValue("OnsMessageGetByMsgId.Data.StoreTimestamp");
			data.StoreHost = context.StringValue("OnsMessageGetByMsgId.Data.StoreHost");
			data.MsgId = context.StringValue("OnsMessageGetByMsgId.Data.MsgId");
			data.OffsetId = context.StringValue("OnsMessageGetByMsgId.Data.OffsetId");
			data.BodyCRC = context.IntegerValue("OnsMessageGetByMsgId.Data.BodyCRC");
			data.ReconsumeTimes = context.IntegerValue("OnsMessageGetByMsgId.Data.ReconsumeTimes");

			List<OnsMessageGetByMsgIdResponse.OnsMessageGetByMsgId_Data.OnsMessageGetByMsgId_MessageProperty> data_propertyList = new List<OnsMessageGetByMsgIdResponse.OnsMessageGetByMsgId_Data.OnsMessageGetByMsgId_MessageProperty>();
			for (int i = 0; i < context.Length("OnsMessageGetByMsgId.Data.PropertyList.Length"); i++) {
				OnsMessageGetByMsgIdResponse.OnsMessageGetByMsgId_Data.OnsMessageGetByMsgId_MessageProperty messageProperty = new OnsMessageGetByMsgIdResponse.OnsMessageGetByMsgId_Data.OnsMessageGetByMsgId_MessageProperty();
				messageProperty.Name = context.StringValue("OnsMessageGetByMsgId.Data.PropertyList["+ i +"].Name");
				messageProperty._Value = context.StringValue("OnsMessageGetByMsgId.Data.PropertyList["+ i +"].Value");

				data_propertyList.Add(messageProperty);
			}
			data.PropertyList = data_propertyList;
			onsMessageGetByMsgIdResponse.Data = data;
        
			return onsMessageGetByMsgIdResponse;
        }
    }
}