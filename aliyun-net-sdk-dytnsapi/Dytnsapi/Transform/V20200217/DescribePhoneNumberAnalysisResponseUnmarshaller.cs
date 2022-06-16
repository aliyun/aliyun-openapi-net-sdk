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
using Aliyun.Acs.Dytnsapi.Model.V20200217;

namespace Aliyun.Acs.Dytnsapi.Transform.V20200217
{
    public class DescribePhoneNumberAnalysisResponseUnmarshaller
    {
        public static DescribePhoneNumberAnalysisResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePhoneNumberAnalysisResponse describePhoneNumberAnalysisResponse = new DescribePhoneNumberAnalysisResponse();

			describePhoneNumberAnalysisResponse.HttpResponse = _ctx.HttpResponse;
			describePhoneNumberAnalysisResponse.RequestId = _ctx.StringValue("DescribePhoneNumberAnalysis.RequestId");
			describePhoneNumberAnalysisResponse.Code = _ctx.StringValue("DescribePhoneNumberAnalysis.Code");
			describePhoneNumberAnalysisResponse.Message = _ctx.StringValue("DescribePhoneNumberAnalysis.Message");

			List<DescribePhoneNumberAnalysisResponse.DescribePhoneNumberAnalysis_DataList> describePhoneNumberAnalysisResponse_data = new List<DescribePhoneNumberAnalysisResponse.DescribePhoneNumberAnalysis_DataList>();
			for (int i = 0; i < _ctx.Length("DescribePhoneNumberAnalysis.Data.Length"); i++) {
				DescribePhoneNumberAnalysisResponse.DescribePhoneNumberAnalysis_DataList dataList = new DescribePhoneNumberAnalysisResponse.DescribePhoneNumberAnalysis_DataList();
				dataList.Code = _ctx.StringValue("DescribePhoneNumberAnalysis.Data["+ i +"].Code");
				dataList.Number = _ctx.StringValue("DescribePhoneNumberAnalysis.Data["+ i +"].Number");

				describePhoneNumberAnalysisResponse_data.Add(dataList);
			}
			describePhoneNumberAnalysisResponse.Data = describePhoneNumberAnalysisResponse_data;
        
			return describePhoneNumberAnalysisResponse;
        }
    }
}
