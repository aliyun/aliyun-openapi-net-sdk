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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeParametersHistoryResponseUnmarshaller
    {
        public static DescribeParametersHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParametersHistoryResponse describeParametersHistoryResponse = new DescribeParametersHistoryResponse();

			describeParametersHistoryResponse.HttpResponse = _ctx.HttpResponse;
			describeParametersHistoryResponse.RequestId = _ctx.StringValue("DescribeParametersHistory.RequestId");

			List<DescribeParametersHistoryResponse.DescribeParametersHistory_Data> describeParametersHistoryResponse_respond = new List<DescribeParametersHistoryResponse.DescribeParametersHistory_Data>();
			for (int i = 0; i < _ctx.Length("DescribeParametersHistory.Respond.Length"); i++) {
				DescribeParametersHistoryResponse.DescribeParametersHistory_Data data = new DescribeParametersHistoryResponse.DescribeParametersHistory_Data();
				data.TotalCount = _ctx.IntegerValue("DescribeParametersHistory.Respond["+ i +"].TotalCount");
				data.PageNumber = _ctx.IntegerValue("DescribeParametersHistory.Respond["+ i +"].PageNumber");

				List<DescribeParametersHistoryResponse.DescribeParametersHistory_Data.DescribeParametersHistory_ParametersItem> data_parameters = new List<DescribeParametersHistoryResponse.DescribeParametersHistory_Data.DescribeParametersHistory_ParametersItem>();
				for (int j = 0; j < _ctx.Length("DescribeParametersHistory.Respond["+ i +"].Parameters.Length"); j++) {
					DescribeParametersHistoryResponse.DescribeParametersHistory_Data.DescribeParametersHistory_ParametersItem parametersItem = new DescribeParametersHistoryResponse.DescribeParametersHistory_Data.DescribeParametersHistory_ParametersItem();
					parametersItem.Status = _ctx.StringValue("DescribeParametersHistory.Respond["+ i +"].Parameters["+ j +"].Status");
					parametersItem.OldValue = _ctx.StringValue("DescribeParametersHistory.Respond["+ i +"].Parameters["+ j +"].OldValue");
					parametersItem.UpdateTime = _ctx.StringValue("DescribeParametersHistory.Respond["+ i +"].Parameters["+ j +"].UpdateTime");
					parametersItem.CreateTime = _ctx.StringValue("DescribeParametersHistory.Respond["+ i +"].Parameters["+ j +"].CreateTime");
					parametersItem.DimensionValue = _ctx.StringValue("DescribeParametersHistory.Respond["+ i +"].Parameters["+ j +"].DimensionValue");
					parametersItem.Name = _ctx.StringValue("DescribeParametersHistory.Respond["+ i +"].Parameters["+ j +"].Name");
					parametersItem.NewValue = _ctx.StringValue("DescribeParametersHistory.Respond["+ i +"].Parameters["+ j +"].NewValue");

					data_parameters.Add(parametersItem);
				}
				data.Parameters = data_parameters;

				describeParametersHistoryResponse_respond.Add(data);
			}
			describeParametersHistoryResponse.Respond = describeParametersHistoryResponse_respond;
        
			return describeParametersHistoryResponse;
        }
    }
}
