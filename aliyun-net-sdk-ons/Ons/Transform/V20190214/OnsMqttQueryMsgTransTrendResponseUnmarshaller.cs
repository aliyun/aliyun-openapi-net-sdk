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
    public class OnsMqttQueryMsgTransTrendResponseUnmarshaller
    {
        public static OnsMqttQueryMsgTransTrendResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsMqttQueryMsgTransTrendResponse onsMqttQueryMsgTransTrendResponse = new OnsMqttQueryMsgTransTrendResponse();

			onsMqttQueryMsgTransTrendResponse.HttpResponse = _ctx.HttpResponse;
			onsMqttQueryMsgTransTrendResponse.RequestId = _ctx.StringValue("OnsMqttQueryMsgTransTrend.RequestId");
			onsMqttQueryMsgTransTrendResponse.HelpUrl = _ctx.StringValue("OnsMqttQueryMsgTransTrend.HelpUrl");

			OnsMqttQueryMsgTransTrendResponse.OnsMqttQueryMsgTransTrend_Data data = new OnsMqttQueryMsgTransTrendResponse.OnsMqttQueryMsgTransTrend_Data();
			data.Title = _ctx.StringValue("OnsMqttQueryMsgTransTrend.Data.Title");
			data.XUnit = _ctx.StringValue("OnsMqttQueryMsgTransTrend.Data.XUnit");
			data.YUnit = _ctx.StringValue("OnsMqttQueryMsgTransTrend.Data.YUnit");

			List<OnsMqttQueryMsgTransTrendResponse.OnsMqttQueryMsgTransTrend_Data.OnsMqttQueryMsgTransTrend_StatsDataDo> data_records = new List<OnsMqttQueryMsgTransTrendResponse.OnsMqttQueryMsgTransTrend_Data.OnsMqttQueryMsgTransTrend_StatsDataDo>();
			for (int i = 0; i < _ctx.Length("OnsMqttQueryMsgTransTrend.Data.Records.Length"); i++) {
				OnsMqttQueryMsgTransTrendResponse.OnsMqttQueryMsgTransTrend_Data.OnsMqttQueryMsgTransTrend_StatsDataDo statsDataDo = new OnsMqttQueryMsgTransTrendResponse.OnsMqttQueryMsgTransTrend_Data.OnsMqttQueryMsgTransTrend_StatsDataDo();
				statsDataDo.X = _ctx.LongValue("OnsMqttQueryMsgTransTrend.Data.Records["+ i +"].X");
				statsDataDo.Y = _ctx.FloatValue("OnsMqttQueryMsgTransTrend.Data.Records["+ i +"].Y");

				data_records.Add(statsDataDo);
			}
			data.Records = data_records;
			onsMqttQueryMsgTransTrendResponse.Data = data;
        
			return onsMqttQueryMsgTransTrendResponse;
        }
    }
}
