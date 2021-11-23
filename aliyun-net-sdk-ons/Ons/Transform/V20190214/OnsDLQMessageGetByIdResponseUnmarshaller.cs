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
    public class OnsDLQMessageGetByIdResponseUnmarshaller
    {
        public static OnsDLQMessageGetByIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsDLQMessageGetByIdResponse onsDLQMessageGetByIdResponse = new OnsDLQMessageGetByIdResponse();

			onsDLQMessageGetByIdResponse.HttpResponse = _ctx.HttpResponse;
			onsDLQMessageGetByIdResponse.RequestId = _ctx.StringValue("OnsDLQMessageGetById.RequestId");
			onsDLQMessageGetByIdResponse.HelpUrl = _ctx.StringValue("OnsDLQMessageGetById.HelpUrl");

			OnsDLQMessageGetByIdResponse.OnsDLQMessageGetById_Data data = new OnsDLQMessageGetByIdResponse.OnsDLQMessageGetById_Data();
			data.OffsetId = _ctx.StringValue("OnsDLQMessageGetById.Data.OffsetId");
			data.StoreSize = _ctx.IntegerValue("OnsDLQMessageGetById.Data.StoreSize");
			data.ReconsumeTimes = _ctx.IntegerValue("OnsDLQMessageGetById.Data.ReconsumeTimes");
			data.StoreTimestamp = _ctx.LongValue("OnsDLQMessageGetById.Data.StoreTimestamp");
			data.Body = _ctx.StringValue("OnsDLQMessageGetById.Data.Body");
			data.InstanceId = _ctx.StringValue("OnsDLQMessageGetById.Data.InstanceId");
			data.MsgId = _ctx.StringValue("OnsDLQMessageGetById.Data.MsgId");
			data.Flag = _ctx.IntegerValue("OnsDLQMessageGetById.Data.Flag");
			data.StoreHost = _ctx.StringValue("OnsDLQMessageGetById.Data.StoreHost");
			data.Topic = _ctx.StringValue("OnsDLQMessageGetById.Data.Topic");
			data.BornTimestamp = _ctx.LongValue("OnsDLQMessageGetById.Data.BornTimestamp");
			data.BodyCRC = _ctx.IntegerValue("OnsDLQMessageGetById.Data.BodyCRC");
			data.BornHost = _ctx.StringValue("OnsDLQMessageGetById.Data.BornHost");

			List<OnsDLQMessageGetByIdResponse.OnsDLQMessageGetById_Data.OnsDLQMessageGetById_MessageProperty> data_propertyList = new List<OnsDLQMessageGetByIdResponse.OnsDLQMessageGetById_Data.OnsDLQMessageGetById_MessageProperty>();
			for (int i = 0; i < _ctx.Length("OnsDLQMessageGetById.Data.PropertyList.Length"); i++) {
				OnsDLQMessageGetByIdResponse.OnsDLQMessageGetById_Data.OnsDLQMessageGetById_MessageProperty messageProperty = new OnsDLQMessageGetByIdResponse.OnsDLQMessageGetById_Data.OnsDLQMessageGetById_MessageProperty();
				messageProperty._Value = _ctx.StringValue("OnsDLQMessageGetById.Data.PropertyList["+ i +"].Value");
				messageProperty.Name = _ctx.StringValue("OnsDLQMessageGetById.Data.PropertyList["+ i +"].Name");

				data_propertyList.Add(messageProperty);
			}
			data.PropertyList = data_propertyList;
			onsDLQMessageGetByIdResponse.Data = data;
        
			return onsDLQMessageGetByIdResponse;
        }
    }
}
