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
using Aliyun.Acs.Dbs.Model.V20190306;

namespace Aliyun.Acs.Dbs.Transform.V20190306
{
    public class DescribePreCheckProgressListResponseUnmarshaller
    {
        public static DescribePreCheckProgressListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePreCheckProgressListResponse describePreCheckProgressListResponse = new DescribePreCheckProgressListResponse();

			describePreCheckProgressListResponse.HttpResponse = context.HttpResponse;
			describePreCheckProgressListResponse.Status = context.StringValue("DescribePreCheckProgressList.Status");
			describePreCheckProgressListResponse.Progress = context.IntegerValue("DescribePreCheckProgressList.Progress");
			describePreCheckProgressListResponse.Success = context.BooleanValue("DescribePreCheckProgressList.Success");
			describePreCheckProgressListResponse.ErrCode = context.StringValue("DescribePreCheckProgressList.ErrCode");
			describePreCheckProgressListResponse.ErrMessage = context.StringValue("DescribePreCheckProgressList.ErrMessage");
			describePreCheckProgressListResponse.HttpStatusCode = context.IntegerValue("DescribePreCheckProgressList.HttpStatusCode");
			describePreCheckProgressListResponse.RequestId = context.StringValue("DescribePreCheckProgressList.RequestId");

			List<DescribePreCheckProgressListResponse.DescribePreCheckProgressList_PreCheckProgressDetail> describePreCheckProgressListResponse_items = new List<DescribePreCheckProgressListResponse.DescribePreCheckProgressList_PreCheckProgressDetail>();
			for (int i = 0; i < context.Length("DescribePreCheckProgressList.Items.Length"); i++) {
				DescribePreCheckProgressListResponse.DescribePreCheckProgressList_PreCheckProgressDetail preCheckProgressDetail = new DescribePreCheckProgressListResponse.DescribePreCheckProgressList_PreCheckProgressDetail();
				preCheckProgressDetail.JobId = context.StringValue("DescribePreCheckProgressList.Items["+ i +"].JobId");
				preCheckProgressDetail.State = context.StringValue("DescribePreCheckProgressList.Items["+ i +"].State");
				preCheckProgressDetail.OrderNum = context.StringValue("DescribePreCheckProgressList.Items["+ i +"].OrderNum");
				preCheckProgressDetail.ErrMsg = context.StringValue("DescribePreCheckProgressList.Items["+ i +"].ErrMsg");
				preCheckProgressDetail.Names = context.StringValue("DescribePreCheckProgressList.Items["+ i +"].Names");
				preCheckProgressDetail.Item = context.StringValue("DescribePreCheckProgressList.Items["+ i +"].Item");
				preCheckProgressDetail.BootTime = context.LongValue("DescribePreCheckProgressList.Items["+ i +"].BootTime");
				preCheckProgressDetail.FinishTime = context.LongValue("DescribePreCheckProgressList.Items["+ i +"].FinishTime");

				describePreCheckProgressListResponse_items.Add(preCheckProgressDetail);
			}
			describePreCheckProgressListResponse.Items = describePreCheckProgressListResponse_items;
        
			return describePreCheckProgressListResponse;
        }
    }
}
