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
    public class DescribeInstanceStatisticsResponseUnmarshaller
    {
        public static DescribeInstanceStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceStatisticsResponse describeInstanceStatisticsResponse = new DescribeInstanceStatisticsResponse();

			describeInstanceStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceStatisticsResponse.RequestId = _ctx.StringValue("DescribeInstanceStatistics.RequestId");

			List<DescribeInstanceStatisticsResponse.DescribeInstanceStatistics_DataItem> describeInstanceStatisticsResponse_data = new List<DescribeInstanceStatisticsResponse.DescribeInstanceStatistics_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceStatistics.Data.Length"); i++) {
				DescribeInstanceStatisticsResponse.DescribeInstanceStatistics_DataItem dataItem = new DescribeInstanceStatisticsResponse.DescribeInstanceStatistics_DataItem();
				dataItem.Uuid = _ctx.StringValue("DescribeInstanceStatistics.Data["+ i +"].Uuid");
				dataItem.Account = _ctx.IntegerValue("DescribeInstanceStatistics.Data["+ i +"].Account");
				dataItem.Health = _ctx.IntegerValue("DescribeInstanceStatistics.Data["+ i +"].Health");
				dataItem.Trojan = _ctx.IntegerValue("DescribeInstanceStatistics.Data["+ i +"].Trojan");
				dataItem.Suspicious = _ctx.IntegerValue("DescribeInstanceStatistics.Data["+ i +"].Suspicious");
				dataItem.Vul = _ctx.IntegerValue("DescribeInstanceStatistics.Data["+ i +"].Vul");
				dataItem.CveNum = _ctx.IntegerValue("DescribeInstanceStatistics.Data["+ i +"].CveNum");
				dataItem.EmgNum = _ctx.IntegerValue("DescribeInstanceStatistics.Data["+ i +"].EmgNum");
				dataItem.SysNum = _ctx.IntegerValue("DescribeInstanceStatistics.Data["+ i +"].SysNum");
				dataItem.CmsNum = _ctx.IntegerValue("DescribeInstanceStatistics.Data["+ i +"].CmsNum");
				dataItem.AppNum = _ctx.IntegerValue("DescribeInstanceStatistics.Data["+ i +"].AppNum");
				dataItem.ScaNum = _ctx.IntegerValue("DescribeInstanceStatistics.Data["+ i +"].ScaNum");

				describeInstanceStatisticsResponse_data.Add(dataItem);
			}
			describeInstanceStatisticsResponse.Data = describeInstanceStatisticsResponse_data;
        
			return describeInstanceStatisticsResponse;
        }
    }
}
