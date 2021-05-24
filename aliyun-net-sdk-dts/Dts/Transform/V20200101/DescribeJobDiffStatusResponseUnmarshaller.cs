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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class DescribeJobDiffStatusResponseUnmarshaller
    {
        public static DescribeJobDiffStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeJobDiffStatusResponse describeJobDiffStatusResponse = new DescribeJobDiffStatusResponse();

			describeJobDiffStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeJobDiffStatusResponse.DynamicCode = _ctx.StringValue("DescribeJobDiffStatus.DynamicCode");
			describeJobDiffStatusResponse.DynamicMessage = _ctx.StringValue("DescribeJobDiffStatus.DynamicMessage");
			describeJobDiffStatusResponse.ErrCode = _ctx.StringValue("DescribeJobDiffStatus.ErrCode");
			describeJobDiffStatusResponse.ErrMessage = _ctx.StringValue("DescribeJobDiffStatus.ErrMessage");
			describeJobDiffStatusResponse.HttpStatusCode = _ctx.IntegerValue("DescribeJobDiffStatus.HttpStatusCode");
			describeJobDiffStatusResponse.RequestId = _ctx.StringValue("DescribeJobDiffStatus.RequestId");
			describeJobDiffStatusResponse.Success = _ctx.BooleanValue("DescribeJobDiffStatus.Success");
			describeJobDiffStatusResponse.Total = _ctx.LongValue("DescribeJobDiffStatus.Total");

			List<DescribeJobDiffStatusResponse.DescribeJobDiffStatus_DiffInfosItem> describeJobDiffStatusResponse_diffInfos = new List<DescribeJobDiffStatusResponse.DescribeJobDiffStatus_DiffInfosItem>();
			for (int i = 0; i < _ctx.Length("DescribeJobDiffStatus.DiffInfos.Length"); i++) {
				DescribeJobDiffStatusResponse.DescribeJobDiffStatus_DiffInfosItem diffInfosItem = new DescribeJobDiffStatusResponse.DescribeJobDiffStatus_DiffInfosItem();
				diffInfosItem.ScheduleJobId = _ctx.StringValue("DescribeJobDiffStatus.DiffInfos["+ i +"].ScheduleJobId");
				diffInfosItem.DbName = _ctx.StringValue("DescribeJobDiffStatus.DiffInfos["+ i +"].DbName");
				diffInfosItem.TableName = _ctx.StringValue("DescribeJobDiffStatus.DiffInfos["+ i +"].TableName");
				diffInfosItem.PkName = _ctx.StringValue("DescribeJobDiffStatus.DiffInfos["+ i +"].PkName");
				diffInfosItem.PkValue = _ctx.StringValue("DescribeJobDiffStatus.DiffInfos["+ i +"].PkValue");
				diffInfosItem.Diff = _ctx.StringValue("DescribeJobDiffStatus.DiffInfos["+ i +"].Diff");

				describeJobDiffStatusResponse_diffInfos.Add(diffInfosItem);
			}
			describeJobDiffStatusResponse.DiffInfos = describeJobDiffStatusResponse_diffInfos;
        
			return describeJobDiffStatusResponse;
        }
    }
}
