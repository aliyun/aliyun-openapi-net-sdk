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
using Aliyun.Acs.Dm.Model.V20170622;

namespace Aliyun.Acs.Dm.Transform.V20170622
{
    public class SenderStatisticsByTagNameAndBatchIDResponseUnmarshaller
    {
        public static SenderStatisticsByTagNameAndBatchIDResponse Unmarshall(UnmarshallerContext context)
        {
			SenderStatisticsByTagNameAndBatchIDResponse senderStatisticsByTagNameAndBatchIDResponse = new SenderStatisticsByTagNameAndBatchIDResponse();

			senderStatisticsByTagNameAndBatchIDResponse.HttpResponse = context.HttpResponse;
			senderStatisticsByTagNameAndBatchIDResponse.RequestId = context.StringValue("SenderStatisticsByTagNameAndBatchID.RequestId");
			senderStatisticsByTagNameAndBatchIDResponse.TotalCount = context.IntegerValue("SenderStatisticsByTagNameAndBatchID.TotalCount");

			List<SenderStatisticsByTagNameAndBatchIDResponse.SenderStatisticsByTagNameAndBatchID_Stat> senderStatisticsByTagNameAndBatchIDResponse_data = new List<SenderStatisticsByTagNameAndBatchIDResponse.SenderStatisticsByTagNameAndBatchID_Stat>();
			for (int i = 0; i < context.Length("SenderStatisticsByTagNameAndBatchID.Data.Length"); i++) {
				SenderStatisticsByTagNameAndBatchIDResponse.SenderStatisticsByTagNameAndBatchID_Stat stat = new SenderStatisticsByTagNameAndBatchIDResponse.SenderStatisticsByTagNameAndBatchID_Stat();
				stat.CreateTime = context.StringValue("SenderStatisticsByTagNameAndBatchID.Data["+ i +"].CreateTime");
				stat.RequestCount = context.StringValue("SenderStatisticsByTagNameAndBatchID.Data["+ i +"].RequestCount");
				stat.SuccessCount = context.StringValue("SenderStatisticsByTagNameAndBatchID.Data["+ i +"].SuccessCount");
				stat.FaildCount = context.StringValue("SenderStatisticsByTagNameAndBatchID.Data["+ i +"].FaildCount");
				stat.UnavailableCount = context.StringValue("SenderStatisticsByTagNameAndBatchID.Data["+ i +"].UnavailableCount");
				stat.SucceededPercent = context.StringValue("SenderStatisticsByTagNameAndBatchID.Data["+ i +"].SucceededPercent");
				stat.UnavailablePercent = context.StringValue("SenderStatisticsByTagNameAndBatchID.Data["+ i +"].UnavailablePercent");

				senderStatisticsByTagNameAndBatchIDResponse_data.Add(stat);
			}
			senderStatisticsByTagNameAndBatchIDResponse.Data = senderStatisticsByTagNameAndBatchIDResponse_data;
        
			return senderStatisticsByTagNameAndBatchIDResponse;
        }
    }
}
