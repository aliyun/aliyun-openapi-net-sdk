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
    public class DescribeInstanceStatisticsResponseUnmarshaller
    {
        public static DescribeInstanceStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceStatisticsResponse describeInstanceStatisticsResponse = new DescribeInstanceStatisticsResponse();

			describeInstanceStatisticsResponse.HttpResponse = context.HttpResponse;
			describeInstanceStatisticsResponse.RequestId = context.StringValue("DescribeInstanceStatistics.RequestId");

			List<DescribeInstanceStatisticsResponse.DescribeInstanceStatistics_Entity> describeInstanceStatisticsResponse_data = new List<DescribeInstanceStatisticsResponse.DescribeInstanceStatistics_Entity>();
			for (int i = 0; i < context.Length("DescribeInstanceStatistics.Data.Length"); i++) {
				DescribeInstanceStatisticsResponse.DescribeInstanceStatistics_Entity entity = new DescribeInstanceStatisticsResponse.DescribeInstanceStatistics_Entity();
				entity.Uuid = context.StringValue("DescribeInstanceStatistics.Data["+ i +"].Uuid");
				entity.Account = context.IntegerValue("DescribeInstanceStatistics.Data["+ i +"].Account");
				entity.Health = context.IntegerValue("DescribeInstanceStatistics.Data["+ i +"].Health");
				entity.Trojan = context.IntegerValue("DescribeInstanceStatistics.Data["+ i +"].Trojan");
				entity.Suspicious = context.IntegerValue("DescribeInstanceStatistics.Data["+ i +"].Suspicious");
				entity.Vul = context.IntegerValue("DescribeInstanceStatistics.Data["+ i +"].Vul");

				describeInstanceStatisticsResponse_data.Add(entity);
			}
			describeInstanceStatisticsResponse.Data = describeInstanceStatisticsResponse_data;
        
			return describeInstanceStatisticsResponse;
        }
    }
}
