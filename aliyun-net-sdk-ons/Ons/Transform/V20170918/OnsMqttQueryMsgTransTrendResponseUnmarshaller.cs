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
    public class OnsMqttQueryMsgTransTrendResponseUnmarshaller
    {
        public static OnsMqttQueryMsgTransTrendResponse Unmarshall(UnmarshallerContext context)
        {
			OnsMqttQueryMsgTransTrendResponse onsMqttQueryMsgTransTrendResponse = new OnsMqttQueryMsgTransTrendResponse();

			onsMqttQueryMsgTransTrendResponse.HttpResponse = context.HttpResponse;
			onsMqttQueryMsgTransTrendResponse.RequestId = context.StringValue("OnsMqttQueryMsgTransTrend.RequestId");
			onsMqttQueryMsgTransTrendResponse.HelpUrl = context.StringValue("OnsMqttQueryMsgTransTrend.HelpUrl");

			OnsMqttQueryMsgTransTrendResponse.OnsMqttQueryMsgTransTrend_Data data = new OnsMqttQueryMsgTransTrendResponse.OnsMqttQueryMsgTransTrend_Data();
			data.Title = context.StringValue("OnsMqttQueryMsgTransTrend.Data.Title");
			data.XUnit = context.StringValue("OnsMqttQueryMsgTransTrend.Data.XUnit");
			data.YUnit = context.StringValue("OnsMqttQueryMsgTransTrend.Data.YUnit");

			List<OnsMqttQueryMsgTransTrendResponse.OnsMqttQueryMsgTransTrend_Data.OnsMqttQueryMsgTransTrend_StatsDataDo> data_records = new List<OnsMqttQueryMsgTransTrendResponse.OnsMqttQueryMsgTransTrend_Data.OnsMqttQueryMsgTransTrend_StatsDataDo>();
			for (int i = 0; i < context.Length("OnsMqttQueryMsgTransTrend.Data.Records.Length"); i++) {
				OnsMqttQueryMsgTransTrendResponse.OnsMqttQueryMsgTransTrend_Data.OnsMqttQueryMsgTransTrend_StatsDataDo statsDataDo = new OnsMqttQueryMsgTransTrendResponse.OnsMqttQueryMsgTransTrend_Data.OnsMqttQueryMsgTransTrend_StatsDataDo();
				statsDataDo.X = context.LongValue("OnsMqttQueryMsgTransTrend.Data.Records["+ i +"].X");
				statsDataDo.Y = context.FloatValue("OnsMqttQueryMsgTransTrend.Data.Records["+ i +"].Y");

				data_records.Add(statsDataDo);
			}
			data.Records = data_records;
			onsMqttQueryMsgTransTrendResponse.Data = data;
        
			return onsMqttQueryMsgTransTrendResponse;
        }
    }
}