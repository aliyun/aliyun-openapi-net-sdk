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
using Aliyun.Acs.wss.Model.V20211221;

namespace Aliyun.Acs.wss.Transform.V20211221
{
    public class DescribePackageDeductionsResponseUnmarshaller
    {
        public static DescribePackageDeductionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePackageDeductionsResponse describePackageDeductionsResponse = new DescribePackageDeductionsResponse();

			describePackageDeductionsResponse.HttpResponse = _ctx.HttpResponse;
			describePackageDeductionsResponse.PageNum = _ctx.IntegerValue("DescribePackageDeductions.PageNum");
			describePackageDeductionsResponse.RequestId = _ctx.StringValue("DescribePackageDeductions.RequestId");
			describePackageDeductionsResponse.PageSize = _ctx.IntegerValue("DescribePackageDeductions.PageSize");
			describePackageDeductionsResponse.TotalCount = _ctx.LongValue("DescribePackageDeductions.TotalCount");

			List<DescribePackageDeductionsResponse.DescribePackageDeductions_Deduction> describePackageDeductionsResponse_deductions = new List<DescribePackageDeductionsResponse.DescribePackageDeductions_Deduction>();
			for (int i = 0; i < _ctx.Length("DescribePackageDeductions.Deductions.Length"); i++) {
				DescribePackageDeductionsResponse.DescribePackageDeductions_Deduction deduction = new DescribePackageDeductionsResponse.DescribePackageDeductions_Deduction();
				deduction.DesktopName = _ctx.StringValue("DescribePackageDeductions.Deductions["+ i +"].DesktopName");
				deduction.DesktopId = _ctx.StringValue("DescribePackageDeductions.Deductions["+ i +"].DesktopId");
				deduction.RegionId = _ctx.StringValue("DescribePackageDeductions.Deductions["+ i +"].RegionId");
				deduction.DesktopType = _ctx.StringValue("DescribePackageDeductions.Deductions["+ i +"].DesktopType");
				deduction.OsType = _ctx.StringValue("DescribePackageDeductions.Deductions["+ i +"].OsType");
				deduction.StaTime = _ctx.StringValue("DescribePackageDeductions.Deductions["+ i +"].StaTime");
				deduction.EndTime = _ctx.StringValue("DescribePackageDeductions.Deductions["+ i +"].EndTime");
				deduction.ResourceType = _ctx.StringValue("DescribePackageDeductions.Deductions["+ i +"].ResourceType");
				deduction.UsedTime = _ctx.LongValue("DescribePackageDeductions.Deductions["+ i +"].UsedTime");
				deduction.UsedCoreTime = _ctx.FloatValue("DescribePackageDeductions.Deductions["+ i +"].UsedCoreTime");
				deduction.InstanceState = _ctx.StringValue("DescribePackageDeductions.Deductions["+ i +"].InstanceState");
				deduction.Memory = _ctx.LongValue("DescribePackageDeductions.Deductions["+ i +"].Memory");
				deduction.Cpu = _ctx.IntegerValue("DescribePackageDeductions.Deductions["+ i +"].Cpu");
				deduction.Gpu = _ctx.StringValue("DescribePackageDeductions.Deductions["+ i +"].Gpu");

				describePackageDeductionsResponse_deductions.Add(deduction);
			}
			describePackageDeductionsResponse.Deductions = describePackageDeductionsResponse_deductions;
        
			return describePackageDeductionsResponse;
        }
    }
}
