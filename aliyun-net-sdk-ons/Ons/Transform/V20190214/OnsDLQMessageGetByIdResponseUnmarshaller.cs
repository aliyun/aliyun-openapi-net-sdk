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
        public static OnsDLQMessageGetByIdResponse Unmarshall(UnmarshallerContext context)
        {
			OnsDLQMessageGetByIdResponse onsDLQMessageGetByIdResponse = new OnsDLQMessageGetByIdResponse();

			onsDLQMessageGetByIdResponse.HttpResponse = context.HttpResponse;
			onsDLQMessageGetByIdResponse.RequestId = context.StringValue("OnsDLQMessageGetById.RequestId");
			onsDLQMessageGetByIdResponse.HelpUrl = context.StringValue("OnsDLQMessageGetById.HelpUrl");

			OnsDLQMessageGetByIdResponse.OnsDLQMessageGetById_Data data = new OnsDLQMessageGetByIdResponse.OnsDLQMessageGetById_Data();
			data.Topic = context.StringValue("OnsDLQMessageGetById.Data.Topic");
			data.Flag = context.IntegerValue("OnsDLQMessageGetById.Data.Flag");
			data.Body = context.StringValue("OnsDLQMessageGetById.Data.Body");
			data.StoreSize = context.IntegerValue("OnsDLQMessageGetById.Data.StoreSize");
			data.BornTimestamp = context.LongValue("OnsDLQMessageGetById.Data.BornTimestamp");
			data.BornHost = context.StringValue("OnsDLQMessageGetById.Data.BornHost");
			data.StoreTimestamp = context.LongValue("OnsDLQMessageGetById.Data.StoreTimestamp");
			data.StoreHost = context.StringValue("OnsDLQMessageGetById.Data.StoreHost");
			data.MsgId = context.StringValue("OnsDLQMessageGetById.Data.MsgId");
			data.OffsetId = context.StringValue("OnsDLQMessageGetById.Data.OffsetId");
			data.BodyCRC = context.IntegerValue("OnsDLQMessageGetById.Data.BodyCRC");
			data.ReconsumeTimes = context.IntegerValue("OnsDLQMessageGetById.Data.ReconsumeTimes");
			data.InstanceId = context.StringValue("OnsDLQMessageGetById.Data.InstanceId");

			List<OnsDLQMessageGetByIdResponse.OnsDLQMessageGetById_Data.OnsDLQMessageGetById_MessageProperty> data_propertyList = new List<OnsDLQMessageGetByIdResponse.OnsDLQMessageGetById_Data.OnsDLQMessageGetById_MessageProperty>();
			for (int i = 0; i < context.Length("OnsDLQMessageGetById.Data.PropertyList.Length"); i++) {
				OnsDLQMessageGetByIdResponse.OnsDLQMessageGetById_Data.OnsDLQMessageGetById_MessageProperty messageProperty = new OnsDLQMessageGetByIdResponse.OnsDLQMessageGetById_Data.OnsDLQMessageGetById_MessageProperty();
				messageProperty.Name = context.StringValue("OnsDLQMessageGetById.Data.PropertyList["+ i +"].Name");
				messageProperty._Value = context.StringValue("OnsDLQMessageGetById.Data.PropertyList["+ i +"].Value");

				data_propertyList.Add(messageProperty);
			}
			data.PropertyList = data_propertyList;
			onsDLQMessageGetByIdResponse.Data = data;
        
			return onsDLQMessageGetByIdResponse;
        }
    }
}
