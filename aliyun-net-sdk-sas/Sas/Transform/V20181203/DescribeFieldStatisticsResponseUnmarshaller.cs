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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeFieldStatisticsResponseUnmarshaller
    {
        public static DescribeFieldStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFieldStatisticsResponse describeFieldStatisticsResponse = new DescribeFieldStatisticsResponse();

			describeFieldStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			describeFieldStatisticsResponse.RequestId = _ctx.StringValue("DescribeFieldStatistics.RequestId");

			DescribeFieldStatisticsResponse.DescribeFieldStatistics_GroupedFields groupedFields = new DescribeFieldStatisticsResponse.DescribeFieldStatistics_GroupedFields();
			groupedFields.RiskInstanceCount = _ctx.IntegerValue("DescribeFieldStatistics.GroupedFields.RiskInstanceCount");
			groupedFields.InstanceCount = _ctx.IntegerValue("DescribeFieldStatistics.GroupedFields.InstanceCount");
			groupedFields.NewInstanceCount = _ctx.IntegerValue("DescribeFieldStatistics.GroupedFields.NewInstanceCount");
			groupedFields.RegionCount = _ctx.IntegerValue("DescribeFieldStatistics.GroupedFields.RegionCount");
			groupedFields.UnprotectedInstanceCount = _ctx.IntegerValue("DescribeFieldStatistics.GroupedFields.UnprotectedInstanceCount");
			groupedFields.VpcCount = _ctx.IntegerValue("DescribeFieldStatistics.GroupedFields.VpcCount");
			groupedFields.GroupCount = _ctx.IntegerValue("DescribeFieldStatistics.GroupedFields.GroupCount");
			groupedFields.NotRunningStatusCount = _ctx.IntegerValue("DescribeFieldStatistics.GroupedFields.NotRunningStatusCount");
			groupedFields.OfflineInstanceCount = _ctx.IntegerValue("DescribeFieldStatistics.GroupedFields.OfflineInstanceCount");
			groupedFields.ImportantAssetCount = _ctx.IntegerValue("DescribeFieldStatistics.GroupedFields.ImportantAssetCount");
			groupedFields.GeneralAssetCount = _ctx.IntegerValue("DescribeFieldStatistics.GroupedFields.GeneralAssetCount");
			groupedFields.TestAssetCount = _ctx.IntegerValue("DescribeFieldStatistics.GroupedFields.TestAssetCount");
			groupedFields.ExposedInstanceCount = _ctx.IntegerValue("DescribeFieldStatistics.GroupedFields.ExposedInstanceCount");
			groupedFields.AliYunInstanceCount = _ctx.IntegerValue("DescribeFieldStatistics.GroupedFields.AliYunInstanceCount");
			groupedFields.IdcInstanceCount = _ctx.IntegerValue("DescribeFieldStatistics.GroupedFields.IdcInstanceCount");
			groupedFields.TencentInstanceCount = _ctx.IntegerValue("DescribeFieldStatistics.GroupedFields.TencentInstanceCount");
			groupedFields.InstanceSyncTaskCount = _ctx.IntegerValue("DescribeFieldStatistics.GroupedFields.InstanceSyncTaskCount");
			describeFieldStatisticsResponse.GroupedFields = groupedFields;
        
			return describeFieldStatisticsResponse;
        }
    }
}
