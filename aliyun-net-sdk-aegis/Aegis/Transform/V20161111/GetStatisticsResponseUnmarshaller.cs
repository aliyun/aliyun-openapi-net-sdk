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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class GetStatisticsResponseUnmarshaller
    {
        public static GetStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			GetStatisticsResponse getStatisticsResponse = new GetStatisticsResponse();

			getStatisticsResponse.HttpResponse = context.HttpResponse;
			getStatisticsResponse.RequestId = context.StringValue("GetStatistics.RequestId");
			getStatisticsResponse.Code = context.StringValue("GetStatistics.Code");
			getStatisticsResponse.Success = context.BooleanValue("GetStatistics.Success");
			getStatisticsResponse.Message = context.StringValue("GetStatistics.Message");

			GetStatisticsResponse.GetStatistics_Data data = new GetStatisticsResponse.GetStatistics_Data();
			data.Account = context.IntegerValue("GetStatistics.Data.Account");
			data.Health = context.IntegerValue("GetStatistics.Data.Health");
			data.Patch = context.IntegerValue("GetStatistics.Data.Patch");
			data.Trojan = context.IntegerValue("GetStatistics.Data.Trojan");
			getStatisticsResponse.Data = data;
        
			return getStatisticsResponse;
        }
    }
}
