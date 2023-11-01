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
    public class DescribeOperatorsResponseUnmarshaller
    {
        public static DescribeOperatorsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOperatorsResponse describeOperatorsResponse = new DescribeOperatorsResponse();

			describeOperatorsResponse.HttpResponse = _ctx.HttpResponse;
			describeOperatorsResponse.Success = _ctx.BooleanValue("DescribeOperators.Success");
			describeOperatorsResponse.Code = _ctx.IntegerValue("DescribeOperators.Code");
			describeOperatorsResponse.Message = _ctx.StringValue("DescribeOperators.Message");
			describeOperatorsResponse.RequestId = _ctx.StringValue("DescribeOperators.RequestId");

			List<DescribeOperatorsResponse.DescribeOperators_DataItem> describeOperatorsResponse_data = new List<DescribeOperatorsResponse.DescribeOperators_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeOperators.Data.Length"); i++) {
				DescribeOperatorsResponse.DescribeOperators_DataItem dataItem = new DescribeOperatorsResponse.DescribeOperators_DataItem();
				dataItem._Operator = _ctx.StringValue("DescribeOperators.Data["+ i +"].Operator");
				dataItem.OperatorName = _ctx.StringValue("DescribeOperators.Data["+ i +"].OperatorName");
				dataItem.OperatorDescCn = _ctx.StringValue("DescribeOperators.Data["+ i +"].OperatorDescCn");
				dataItem.OperatorDescEn = _ctx.StringValue("DescribeOperators.Data["+ i +"].OperatorDescEn");
				dataItem.SupportDataType = _ctx.StringValue("DescribeOperators.Data["+ i +"].SupportDataType");
				dataItem.Index = _ctx.IntegerValue("DescribeOperators.Data["+ i +"].Index");

				List<string> dataItem_supportTag = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeOperators.Data["+ i +"].SupportTag.Length"); j++) {
					dataItem_supportTag.Add(_ctx.StringValue("DescribeOperators.Data["+ i +"].SupportTag["+ j +"]"));
				}
				dataItem.SupportTag = dataItem_supportTag;

				describeOperatorsResponse_data.Add(dataItem);
			}
			describeOperatorsResponse.Data = describeOperatorsResponse_data;
        
			return describeOperatorsResponse;
        }
    }
}
