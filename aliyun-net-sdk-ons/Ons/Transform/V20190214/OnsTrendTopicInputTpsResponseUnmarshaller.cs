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
    public class OnsTrendTopicInputTpsResponseUnmarshaller
    {
        public static OnsTrendTopicInputTpsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsTrendTopicInputTpsResponse onsTrendTopicInputTpsResponse = new OnsTrendTopicInputTpsResponse();

			onsTrendTopicInputTpsResponse.HttpResponse = _ctx.HttpResponse;
			onsTrendTopicInputTpsResponse.RequestId = _ctx.StringValue("OnsTrendTopicInputTps.RequestId");
			onsTrendTopicInputTpsResponse.HelpUrl = _ctx.StringValue("OnsTrendTopicInputTps.HelpUrl");

			OnsTrendTopicInputTpsResponse.OnsTrendTopicInputTps_Data data = new OnsTrendTopicInputTpsResponse.OnsTrendTopicInputTps_Data();
			data.Title = _ctx.StringValue("OnsTrendTopicInputTps.Data.Title");
			data.XUnit = _ctx.StringValue("OnsTrendTopicInputTps.Data.XUnit");
			data.YUnit = _ctx.StringValue("OnsTrendTopicInputTps.Data.YUnit");

			List<OnsTrendTopicInputTpsResponse.OnsTrendTopicInputTps_Data.OnsTrendTopicInputTps_StatsDataDo> data_records = new List<OnsTrendTopicInputTpsResponse.OnsTrendTopicInputTps_Data.OnsTrendTopicInputTps_StatsDataDo>();
			for (int i = 0; i < _ctx.Length("OnsTrendTopicInputTps.Data.Records.Length"); i++) {
				OnsTrendTopicInputTpsResponse.OnsTrendTopicInputTps_Data.OnsTrendTopicInputTps_StatsDataDo statsDataDo = new OnsTrendTopicInputTpsResponse.OnsTrendTopicInputTps_Data.OnsTrendTopicInputTps_StatsDataDo();
				statsDataDo.X = _ctx.LongValue("OnsTrendTopicInputTps.Data.Records["+ i +"].X");
				statsDataDo.Y = _ctx.FloatValue("OnsTrendTopicInputTps.Data.Records["+ i +"].Y");

				data_records.Add(statsDataDo);
			}
			data.Records = data_records;
			onsTrendTopicInputTpsResponse.Data = data;
        
			return onsTrendTopicInputTpsResponse;
        }
    }
}
