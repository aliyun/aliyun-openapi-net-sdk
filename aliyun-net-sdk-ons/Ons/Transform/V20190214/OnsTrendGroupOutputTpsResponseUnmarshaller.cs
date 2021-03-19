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
    public class OnsTrendGroupOutputTpsResponseUnmarshaller
    {
        public static OnsTrendGroupOutputTpsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsTrendGroupOutputTpsResponse onsTrendGroupOutputTpsResponse = new OnsTrendGroupOutputTpsResponse();

			onsTrendGroupOutputTpsResponse.HttpResponse = _ctx.HttpResponse;
			onsTrendGroupOutputTpsResponse.RequestId = _ctx.StringValue("OnsTrendGroupOutputTps.RequestId");
			onsTrendGroupOutputTpsResponse.HelpUrl = _ctx.StringValue("OnsTrendGroupOutputTps.HelpUrl");

			OnsTrendGroupOutputTpsResponse.OnsTrendGroupOutputTps_Data data = new OnsTrendGroupOutputTpsResponse.OnsTrendGroupOutputTps_Data();
			data.Title = _ctx.StringValue("OnsTrendGroupOutputTps.Data.Title");
			data.XUnit = _ctx.StringValue("OnsTrendGroupOutputTps.Data.XUnit");
			data.YUnit = _ctx.StringValue("OnsTrendGroupOutputTps.Data.YUnit");

			List<OnsTrendGroupOutputTpsResponse.OnsTrendGroupOutputTps_Data.OnsTrendGroupOutputTps_StatsDataDo> data_records = new List<OnsTrendGroupOutputTpsResponse.OnsTrendGroupOutputTps_Data.OnsTrendGroupOutputTps_StatsDataDo>();
			for (int i = 0; i < _ctx.Length("OnsTrendGroupOutputTps.Data.Records.Length"); i++) {
				OnsTrendGroupOutputTpsResponse.OnsTrendGroupOutputTps_Data.OnsTrendGroupOutputTps_StatsDataDo statsDataDo = new OnsTrendGroupOutputTpsResponse.OnsTrendGroupOutputTps_Data.OnsTrendGroupOutputTps_StatsDataDo();
				statsDataDo.X = _ctx.LongValue("OnsTrendGroupOutputTps.Data.Records["+ i +"].X");
				statsDataDo.Y = _ctx.FloatValue("OnsTrendGroupOutputTps.Data.Records["+ i +"].Y");

				data_records.Add(statsDataDo);
			}
			data.Records = data_records;
			onsTrendGroupOutputTpsResponse.Data = data;
        
			return onsTrendGroupOutputTpsResponse;
        }
    }
}
