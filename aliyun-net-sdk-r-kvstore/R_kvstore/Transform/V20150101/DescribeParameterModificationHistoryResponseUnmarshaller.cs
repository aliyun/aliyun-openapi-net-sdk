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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeParameterModificationHistoryResponseUnmarshaller
    {
        public static DescribeParameterModificationHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParameterModificationHistoryResponse describeParameterModificationHistoryResponse = new DescribeParameterModificationHistoryResponse();

			describeParameterModificationHistoryResponse.HttpResponse = _ctx.HttpResponse;
			describeParameterModificationHistoryResponse.RequestId = _ctx.StringValue("DescribeParameterModificationHistory.RequestId");

			List<DescribeParameterModificationHistoryResponse.DescribeParameterModificationHistory_HistoricalParameter> describeParameterModificationHistoryResponse_historicalParameters = new List<DescribeParameterModificationHistoryResponse.DescribeParameterModificationHistory_HistoricalParameter>();
			for (int i = 0; i < _ctx.Length("DescribeParameterModificationHistory.HistoricalParameters.Length"); i++) {
				DescribeParameterModificationHistoryResponse.DescribeParameterModificationHistory_HistoricalParameter historicalParameter = new DescribeParameterModificationHistoryResponse.DescribeParameterModificationHistory_HistoricalParameter();
				historicalParameter.OldParameterValue = _ctx.StringValue("DescribeParameterModificationHistory.HistoricalParameters["+ i +"].OldParameterValue");
				historicalParameter.ParameterName = _ctx.StringValue("DescribeParameterModificationHistory.HistoricalParameters["+ i +"].ParameterName");
				historicalParameter.NewParameterValue = _ctx.StringValue("DescribeParameterModificationHistory.HistoricalParameters["+ i +"].NewParameterValue");
				historicalParameter.ModifyTime = _ctx.StringValue("DescribeParameterModificationHistory.HistoricalParameters["+ i +"].ModifyTime");

				describeParameterModificationHistoryResponse_historicalParameters.Add(historicalParameter);
			}
			describeParameterModificationHistoryResponse.HistoricalParameters = describeParameterModificationHistoryResponse_historicalParameters;
        
			return describeParameterModificationHistoryResponse;
        }
    }
}
