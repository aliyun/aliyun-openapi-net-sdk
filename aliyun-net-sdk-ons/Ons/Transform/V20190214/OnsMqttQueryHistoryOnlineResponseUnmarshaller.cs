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
    public class OnsMqttQueryHistoryOnlineResponseUnmarshaller
    {
        public static OnsMqttQueryHistoryOnlineResponse Unmarshall(UnmarshallerContext context)
        {
			OnsMqttQueryHistoryOnlineResponse onsMqttQueryHistoryOnlineResponse = new OnsMqttQueryHistoryOnlineResponse();

			onsMqttQueryHistoryOnlineResponse.HttpResponse = context.HttpResponse;
			onsMqttQueryHistoryOnlineResponse.RequestId = context.StringValue("OnsMqttQueryHistoryOnline.RequestId");
			onsMqttQueryHistoryOnlineResponse.HelpUrl = context.StringValue("OnsMqttQueryHistoryOnline.HelpUrl");

			OnsMqttQueryHistoryOnlineResponse.OnsMqttQueryHistoryOnline_Data data = new OnsMqttQueryHistoryOnlineResponse.OnsMqttQueryHistoryOnline_Data();
			data.Title = context.StringValue("OnsMqttQueryHistoryOnline.Data.Title");
			data.XUnit = context.StringValue("OnsMqttQueryHistoryOnline.Data.XUnit");
			data.YUnit = context.StringValue("OnsMqttQueryHistoryOnline.Data.YUnit");

			List<OnsMqttQueryHistoryOnlineResponse.OnsMqttQueryHistoryOnline_Data.OnsMqttQueryHistoryOnline_StatsDataDo> data_records = new List<OnsMqttQueryHistoryOnlineResponse.OnsMqttQueryHistoryOnline_Data.OnsMqttQueryHistoryOnline_StatsDataDo>();
			for (int i = 0; i < context.Length("OnsMqttQueryHistoryOnline.Data.Records.Length"); i++) {
				OnsMqttQueryHistoryOnlineResponse.OnsMqttQueryHistoryOnline_Data.OnsMqttQueryHistoryOnline_StatsDataDo statsDataDo = new OnsMqttQueryHistoryOnlineResponse.OnsMqttQueryHistoryOnline_Data.OnsMqttQueryHistoryOnline_StatsDataDo();
				statsDataDo.X = context.LongValue("OnsMqttQueryHistoryOnline.Data.Records["+ i +"].X");
				statsDataDo.Y = context.FloatValue("OnsMqttQueryHistoryOnline.Data.Records["+ i +"].Y");

				data_records.Add(statsDataDo);
			}
			data.Records = data_records;
			onsMqttQueryHistoryOnlineResponse.Data = data;
        
			return onsMqttQueryHistoryOnlineResponse;
        }
    }
}
