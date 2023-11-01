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
    public class DescribeWafScopeResponseUnmarshaller
    {
        public static DescribeWafScopeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWafScopeResponse describeWafScopeResponse = new DescribeWafScopeResponse();

			describeWafScopeResponse.HttpResponse = _ctx.HttpResponse;
			describeWafScopeResponse.Success = _ctx.BooleanValue("DescribeWafScope.Success");
			describeWafScopeResponse.Code = _ctx.IntegerValue("DescribeWafScope.Code");
			describeWafScopeResponse.Message = _ctx.StringValue("DescribeWafScope.Message");
			describeWafScopeResponse.RequestId = _ctx.StringValue("DescribeWafScope.RequestId");

			List<DescribeWafScopeResponse.DescribeWafScope_DataItem> describeWafScopeResponse_data = new List<DescribeWafScopeResponse.DescribeWafScope_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeWafScope.Data.Length"); i++) {
				DescribeWafScopeResponse.DescribeWafScope_DataItem dataItem = new DescribeWafScopeResponse.DescribeWafScope_DataItem();
				dataItem.InstanceId = _ctx.StringValue("DescribeWafScope.Data["+ i +"].InstanceId");
				dataItem.Aliuid = _ctx.LongValue("DescribeWafScope.Data["+ i +"].Aliuid");

				List<string> dataItem_domains = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeWafScope.Data["+ i +"].Domains.Length"); j++) {
					dataItem_domains.Add(_ctx.StringValue("DescribeWafScope.Data["+ i +"].Domains["+ j +"]"));
				}
				dataItem.Domains = dataItem_domains;

				describeWafScopeResponse_data.Add(dataItem);
			}
			describeWafScopeResponse.Data = describeWafScopeResponse_data;
        
			return describeWafScopeResponse;
        }
    }
}
