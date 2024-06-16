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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DescribeCustomizeRuleTestHistogramResponseUnmarshaller
    {
        public static DescribeCustomizeRuleTestHistogramResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCustomizeRuleTestHistogramResponse describeCustomizeRuleTestHistogramResponse = new DescribeCustomizeRuleTestHistogramResponse();

			describeCustomizeRuleTestHistogramResponse.HttpResponse = _ctx.HttpResponse;
			describeCustomizeRuleTestHistogramResponse.Success = _ctx.BooleanValue("DescribeCustomizeRuleTestHistogram.Success");
			describeCustomizeRuleTestHistogramResponse.Code = _ctx.IntegerValue("DescribeCustomizeRuleTestHistogram.Code");
			describeCustomizeRuleTestHistogramResponse.Message = _ctx.StringValue("DescribeCustomizeRuleTestHistogram.Message");
			describeCustomizeRuleTestHistogramResponse.RequestId = _ctx.StringValue("DescribeCustomizeRuleTestHistogram.RequestId");

			List<DescribeCustomizeRuleTestHistogramResponse.DescribeCustomizeRuleTestHistogram_DataItem> describeCustomizeRuleTestHistogramResponse_data = new List<DescribeCustomizeRuleTestHistogramResponse.DescribeCustomizeRuleTestHistogram_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeCustomizeRuleTestHistogram.Data.Length"); i++) {
				DescribeCustomizeRuleTestHistogramResponse.DescribeCustomizeRuleTestHistogram_DataItem dataItem = new DescribeCustomizeRuleTestHistogramResponse.DescribeCustomizeRuleTestHistogram_DataItem();
				dataItem.From = _ctx.LongValue("DescribeCustomizeRuleTestHistogram.Data["+ i +"].From");
				dataItem.To = _ctx.LongValue("DescribeCustomizeRuleTestHistogram.Data["+ i +"].To");
				dataItem.Count = _ctx.LongValue("DescribeCustomizeRuleTestHistogram.Data["+ i +"].Count");

				describeCustomizeRuleTestHistogramResponse_data.Add(dataItem);
			}
			describeCustomizeRuleTestHistogramResponse.Data = describeCustomizeRuleTestHistogramResponse_data;
        
			return describeCustomizeRuleTestHistogramResponse;
        }
    }
}
