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
    public class OnsTrendTopicInputTpsResponseUnmarshaller
    {
        public static OnsTrendTopicInputTpsResponse Unmarshall(UnmarshallerContext context)
        {
			OnsTrendTopicInputTpsResponse onsTrendTopicInputTpsResponse = new OnsTrendTopicInputTpsResponse();

			onsTrendTopicInputTpsResponse.HttpResponse = context.HttpResponse;
			onsTrendTopicInputTpsResponse.RequestId = context.StringValue("OnsTrendTopicInputTps.RequestId");
			onsTrendTopicInputTpsResponse.HelpUrl = context.StringValue("OnsTrendTopicInputTps.HelpUrl");

			OnsTrendTopicInputTpsResponse.OnsTrendTopicInputTps_Data data = new OnsTrendTopicInputTpsResponse.OnsTrendTopicInputTps_Data();
			data.Title = context.StringValue("OnsTrendTopicInputTps.Data.Title");
			data.XUnit = context.StringValue("OnsTrendTopicInputTps.Data.XUnit");
			data.YUnit = context.StringValue("OnsTrendTopicInputTps.Data.YUnit");

			List<OnsTrendTopicInputTpsResponse.OnsTrendTopicInputTps_Data.OnsTrendTopicInputTps_StatsDataDo> data_records = new List<OnsTrendTopicInputTpsResponse.OnsTrendTopicInputTps_Data.OnsTrendTopicInputTps_StatsDataDo>();
			for (int i = 0; i < context.Length("OnsTrendTopicInputTps.Data.Records.Length"); i++) {
				OnsTrendTopicInputTpsResponse.OnsTrendTopicInputTps_Data.OnsTrendTopicInputTps_StatsDataDo statsDataDo = new OnsTrendTopicInputTpsResponse.OnsTrendTopicInputTps_Data.OnsTrendTopicInputTps_StatsDataDo();
				statsDataDo.X = context.LongValue("OnsTrendTopicInputTps.Data.Records["+ i +"].X");
				statsDataDo.Y = context.FloatValue("OnsTrendTopicInputTps.Data.Records["+ i +"].Y");

				data_records.Add(statsDataDo);
			}
			data.Records = data_records;
			onsTrendTopicInputTpsResponse.Data = data;
        
			return onsTrendTopicInputTpsResponse;
        }
    }
}