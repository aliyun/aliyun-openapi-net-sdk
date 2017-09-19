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
    public class OnsConsumerAccumulateResponseUnmarshaller
    {
        public static OnsConsumerAccumulateResponse Unmarshall(UnmarshallerContext context)
        {
			OnsConsumerAccumulateResponse onsConsumerAccumulateResponse = new OnsConsumerAccumulateResponse();

			onsConsumerAccumulateResponse.HttpResponse = context.HttpResponse;
			onsConsumerAccumulateResponse.RequestId = context.StringValue("OnsConsumerAccumulate.RequestId");
			onsConsumerAccumulateResponse.HelpUrl = context.StringValue("OnsConsumerAccumulate.HelpUrl");

			OnsConsumerAccumulateResponse.OnsConsumerAccumulate_Data data = new OnsConsumerAccumulateResponse.OnsConsumerAccumulate_Data();
			data.Online = context.BooleanValue("OnsConsumerAccumulate.Data.Online");
			data.TotalDiff = context.LongValue("OnsConsumerAccumulate.Data.TotalDiff");
			data.ConsumeTps = context.FloatValue("OnsConsumerAccumulate.Data.ConsumeTps");
			data.LastTimestamp = context.LongValue("OnsConsumerAccumulate.Data.LastTimestamp");
			data.DelayTime = context.LongValue("OnsConsumerAccumulate.Data.DelayTime");

			List<OnsConsumerAccumulateResponse.OnsConsumerAccumulate_Data.OnsConsumerAccumulate_DetailInTopicDo> data_detailInTopicList = new List<OnsConsumerAccumulateResponse.OnsConsumerAccumulate_Data.OnsConsumerAccumulate_DetailInTopicDo>();
			for (int i = 0; i < context.Length("OnsConsumerAccumulate.Data.DetailInTopicList.Length"); i++) {
				OnsConsumerAccumulateResponse.OnsConsumerAccumulate_Data.OnsConsumerAccumulate_DetailInTopicDo detailInTopicDo = new OnsConsumerAccumulateResponse.OnsConsumerAccumulate_Data.OnsConsumerAccumulate_DetailInTopicDo();
				detailInTopicDo.Topic = context.StringValue("OnsConsumerAccumulate.Data.DetailInTopicList["+ i +"].Topic");
				detailInTopicDo.TotalDiff = context.LongValue("OnsConsumerAccumulate.Data.DetailInTopicList["+ i +"].TotalDiff");
				detailInTopicDo.LastTimestamp = context.LongValue("OnsConsumerAccumulate.Data.DetailInTopicList["+ i +"].LastTimestamp");
				detailInTopicDo.DelayTime = context.LongValue("OnsConsumerAccumulate.Data.DetailInTopicList["+ i +"].DelayTime");

				data_detailInTopicList.Add(detailInTopicDo);
			}
			data.DetailInTopicList = data_detailInTopicList;
			onsConsumerAccumulateResponse.Data = data;
        
			return onsConsumerAccumulateResponse;
        }
    }
}