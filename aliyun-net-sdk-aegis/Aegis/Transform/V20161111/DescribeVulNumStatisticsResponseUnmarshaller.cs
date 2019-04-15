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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeVulNumStatisticsResponseUnmarshaller
    {
        public static DescribeVulNumStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVulNumStatisticsResponse describeVulNumStatisticsResponse = new DescribeVulNumStatisticsResponse();

			describeVulNumStatisticsResponse.HttpResponse = context.HttpResponse;
			describeVulNumStatisticsResponse.RequestId = context.StringValue("DescribeVulNumStatistics.RequestId");
			describeVulNumStatisticsResponse.CveNum = context.IntegerValue("DescribeVulNumStatistics.CveNum");
			describeVulNumStatisticsResponse.EmgNum = context.IntegerValue("DescribeVulNumStatistics.EmgNum");
			describeVulNumStatisticsResponse.SysNum = context.IntegerValue("DescribeVulNumStatistics.SysNum");
			describeVulNumStatisticsResponse.CmsNum = context.IntegerValue("DescribeVulNumStatistics.CmsNum");
			describeVulNumStatisticsResponse.CmsDealedTotalNum = context.IntegerValue("DescribeVulNumStatistics.CmsDealedTotalNum");
			describeVulNumStatisticsResponse.VulDealedTotalNum = context.IntegerValue("DescribeVulNumStatistics.VulDealedTotalNum");
			describeVulNumStatisticsResponse.VulAsapSum = context.IntegerValue("DescribeVulNumStatistics.VulAsapSum");
			describeVulNumStatisticsResponse.VulLaterSum = context.IntegerValue("DescribeVulNumStatistics.VulLaterSum");
			describeVulNumStatisticsResponse.VulNntfSum = context.IntegerValue("DescribeVulNumStatistics.VulNntfSum");
        
			return describeVulNumStatisticsResponse;
        }
    }
}
