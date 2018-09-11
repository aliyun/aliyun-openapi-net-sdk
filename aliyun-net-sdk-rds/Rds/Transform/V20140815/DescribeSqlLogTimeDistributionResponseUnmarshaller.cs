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
    public class DescribeSqlLogTimeDistributionResponseUnmarshaller
    {
        public static DescribeSqlLogTimeDistributionResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSqlLogTimeDistributionResponse describeSqlLogTimeDistributionResponse = new DescribeSqlLogTimeDistributionResponse();

			describeSqlLogTimeDistributionResponse.HttpResponse = context.HttpResponse;
			describeSqlLogTimeDistributionResponse.RequestId = context.StringValue("DescribeSqlLogTimeDistribution.RequestId");
			describeSqlLogTimeDistributionResponse.DBInstanceID = context.IntegerValue("DescribeSqlLogTimeDistribution.DBInstanceID");
			describeSqlLogTimeDistributionResponse.DBInstanceName = context.StringValue("DescribeSqlLogTimeDistribution.DBInstanceName");
			describeSqlLogTimeDistributionResponse.StartTime = context.StringValue("DescribeSqlLogTimeDistribution.StartTime");
			describeSqlLogTimeDistributionResponse.EndTime = context.StringValue("DescribeSqlLogTimeDistribution.EndTime");
			describeSqlLogTimeDistributionResponse.TemplateHash = context.LongValue("DescribeSqlLogTimeDistribution.TemplateHash");
			describeSqlLogTimeDistributionResponse.ItemsNumbers = context.IntegerValue("DescribeSqlLogTimeDistribution.ItemsNumbers");

			List<DescribeSqlLogTimeDistributionResponse.DescribeSqlLogTimeDistribution_Distribution> describeSqlLogTimeDistributionResponse_items = new List<DescribeSqlLogTimeDistributionResponse.DescribeSqlLogTimeDistribution_Distribution>();
			for (int i = 0; i < context.Length("DescribeSqlLogTimeDistribution.Items.Length"); i++) {
				DescribeSqlLogTimeDistributionResponse.DescribeSqlLogTimeDistribution_Distribution distribution = new DescribeSqlLogTimeDistributionResponse.DescribeSqlLogTimeDistribution_Distribution();
				distribution.QueryStartTime = context.StringValue("DescribeSqlLogTimeDistribution.Items["+ i +"].QueryStartTime");
				distribution.TotalConsume = context.LongValue("DescribeSqlLogTimeDistribution.Items["+ i +"].TotalConsume");
				distribution.TotalCounts = context.LongValue("DescribeSqlLogTimeDistribution.Items["+ i +"].TotalCounts");
				distribution.TotalScanRows = context.LongValue("DescribeSqlLogTimeDistribution.Items["+ i +"].TotalScanRows");
				distribution.TotalUpdateRows = context.LongValue("DescribeSqlLogTimeDistribution.Items["+ i +"].TotalUpdateRows");
				distribution.SelectCounts = context.LongValue("DescribeSqlLogTimeDistribution.Items["+ i +"].SelectCounts");
				distribution.UpdateCounts = context.LongValue("DescribeSqlLogTimeDistribution.Items["+ i +"].UpdateCounts");
				distribution.InsertCounts = context.LongValue("DescribeSqlLogTimeDistribution.Items["+ i +"].InsertCounts");
				distribution.DeleteCounts = context.LongValue("DescribeSqlLogTimeDistribution.Items["+ i +"].DeleteCounts");
				distribution.LoginCounts = context.LongValue("DescribeSqlLogTimeDistribution.Items["+ i +"].LoginCounts");

				describeSqlLogTimeDistributionResponse_items.Add(distribution);
			}
			describeSqlLogTimeDistributionResponse.Items = describeSqlLogTimeDistributionResponse_items;
        
			return describeSqlLogTimeDistributionResponse;
        }
    }
}