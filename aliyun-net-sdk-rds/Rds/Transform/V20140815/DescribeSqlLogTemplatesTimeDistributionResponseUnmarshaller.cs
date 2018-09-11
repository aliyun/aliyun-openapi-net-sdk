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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSqlLogTemplatesTimeDistributionResponseUnmarshaller
    {
        public static DescribeSqlLogTemplatesTimeDistributionResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSqlLogTemplatesTimeDistributionResponse describeSqlLogTemplatesTimeDistributionResponse = new DescribeSqlLogTemplatesTimeDistributionResponse();

			describeSqlLogTemplatesTimeDistributionResponse.HttpResponse = context.HttpResponse;
			describeSqlLogTemplatesTimeDistributionResponse.RequestId = context.StringValue("DescribeSqlLogTemplatesTimeDistribution.RequestId");
			describeSqlLogTemplatesTimeDistributionResponse.DBInstanceID = context.IntegerValue("DescribeSqlLogTemplatesTimeDistribution.DBInstanceID");
			describeSqlLogTemplatesTimeDistributionResponse.DBInstanceName = context.StringValue("DescribeSqlLogTemplatesTimeDistribution.DBInstanceName");
			describeSqlLogTemplatesTimeDistributionResponse.StartTime = context.StringValue("DescribeSqlLogTemplatesTimeDistribution.StartTime");
			describeSqlLogTemplatesTimeDistributionResponse.EndTime = context.StringValue("DescribeSqlLogTemplatesTimeDistribution.EndTime");
			describeSqlLogTemplatesTimeDistributionResponse.TemplateHash = context.LongValue("DescribeSqlLogTemplatesTimeDistribution.TemplateHash");
			describeSqlLogTemplatesTimeDistributionResponse.ItemsNumbers = context.IntegerValue("DescribeSqlLogTemplatesTimeDistribution.ItemsNumbers");

			List<DescribeSqlLogTemplatesTimeDistributionResponse.DescribeSqlLogTemplatesTimeDistribution_Distribution> describeSqlLogTemplatesTimeDistributionResponse_items = new List<DescribeSqlLogTemplatesTimeDistributionResponse.DescribeSqlLogTemplatesTimeDistribution_Distribution>();
			for (int i = 0; i < context.Length("DescribeSqlLogTemplatesTimeDistribution.Items.Length"); i++) {
				DescribeSqlLogTemplatesTimeDistributionResponse.DescribeSqlLogTemplatesTimeDistribution_Distribution distribution = new DescribeSqlLogTemplatesTimeDistributionResponse.DescribeSqlLogTemplatesTimeDistribution_Distribution();
				distribution.QueryStartTime = context.StringValue("DescribeSqlLogTemplatesTimeDistribution.Items["+ i +"].QueryStartTime");
				distribution.TotalConsume = context.LongValue("DescribeSqlLogTemplatesTimeDistribution.Items["+ i +"].TotalConsume");
				distribution.TotalCounts = context.LongValue("DescribeSqlLogTemplatesTimeDistribution.Items["+ i +"].TotalCounts");
				distribution.TotalScanRows = context.LongValue("DescribeSqlLogTemplatesTimeDistribution.Items["+ i +"].TotalScanRows");
				distribution.TotalUpdateRows = context.LongValue("DescribeSqlLogTemplatesTimeDistribution.Items["+ i +"].TotalUpdateRows");

				describeSqlLogTemplatesTimeDistributionResponse_items.Add(distribution);
			}
			describeSqlLogTemplatesTimeDistributionResponse.Items = describeSqlLogTemplatesTimeDistributionResponse_items;
        
			return describeSqlLogTemplatesTimeDistributionResponse;
        }
    }
}