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
using Aliyun.Acs.reid.Model.V20190928;

namespace Aliyun.Acs.reid.Transform.V20190928
{
    public class DescribeBaseStatisticsResponseUnmarshaller
    {
        public static DescribeBaseStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBaseStatisticsResponse describeBaseStatisticsResponse = new DescribeBaseStatisticsResponse();

			describeBaseStatisticsResponse.HttpResponse = context.HttpResponse;
			describeBaseStatisticsResponse.ErrorCode = context.StringValue("DescribeBaseStatistics.ErrorCode");
			describeBaseStatisticsResponse.CursorTime = context.StringValue("DescribeBaseStatistics.CursorTime");
			describeBaseStatisticsResponse.ErrorMessage = context.StringValue("DescribeBaseStatistics.ErrorMessage");
			describeBaseStatisticsResponse.RequestId = context.StringValue("DescribeBaseStatistics.RequestId");
			describeBaseStatisticsResponse.Success = context.BooleanValue("DescribeBaseStatistics.Success");

			List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem> describeBaseStatisticsResponse_baseStatistics = new List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem>();
			for (int i = 0; i < context.Length("DescribeBaseStatistics.BaseStatistics.Length"); i++) {
				DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem baseStatisticsItem = new DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem();
				baseStatisticsItem.StoreId = context.LongValue("DescribeBaseStatistics.BaseStatistics["+ i +"].StoreId");
				baseStatisticsItem.FemaleUvCount = context.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].FemaleUvCount");
				baseStatisticsItem.OldCount = context.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].OldCount");
				baseStatisticsItem.NewCount = context.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].NewCount");
				baseStatisticsItem.SummaryType = context.StringValue("DescribeBaseStatistics.BaseStatistics["+ i +"].SummaryType");
				baseStatisticsItem.MaleUvCount = context.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].MaleUvCount");
				baseStatisticsItem.Time = context.StringValue("DescribeBaseStatistics.BaseStatistics["+ i +"].Time");
				baseStatisticsItem.LocationId = context.LongValue("DescribeBaseStatistics.BaseStatistics["+ i +"].LocationId");
				baseStatisticsItem.StayPeriod = context.LongValue("DescribeBaseStatistics.BaseStatistics["+ i +"].StayPeriod");
				baseStatisticsItem.UvCount = context.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].UvCount");
				baseStatisticsItem.OnlyBodyUvCount = context.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].OnlyBodyUvCount");

				List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem> baseStatisticsItem_ageItems = new List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem>();
				for (int j = 0; j < context.Length("DescribeBaseStatistics.BaseStatistics["+ i +"].AgeItems.Length"); j++) {
					DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem ageItem = new DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem();
					ageItem.Name = context.StringValue("DescribeBaseStatistics.BaseStatistics["+ i +"].AgeItems["+ j +"].Name");
					ageItem.Count = context.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].AgeItems["+ j +"].Count");

					baseStatisticsItem_ageItems.Add(ageItem);
				}
				baseStatisticsItem.AgeItems = baseStatisticsItem_ageItems;

				List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_StayDistributionItem> baseStatisticsItem_stayDistributionItems = new List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_StayDistributionItem>();
				for (int j = 0; j < context.Length("DescribeBaseStatistics.BaseStatistics["+ i +"].StayDistributionItems.Length"); j++) {
					DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_StayDistributionItem stayDistributionItem = new DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_StayDistributionItem();
					stayDistributionItem.StartTs = context.LongValue("DescribeBaseStatistics.BaseStatistics["+ i +"].StayDistributionItems["+ j +"].StartTs");
					stayDistributionItem.EndTs = context.LongValue("DescribeBaseStatistics.BaseStatistics["+ i +"].StayDistributionItems["+ j +"].EndTs");
					stayDistributionItem.Count = context.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].StayDistributionItems["+ j +"].Count");

					baseStatisticsItem_stayDistributionItems.Add(stayDistributionItem);
				}
				baseStatisticsItem.StayDistributionItems = baseStatisticsItem_stayDistributionItems;

				List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem> baseStatisticsItem_maleAgeItems = new List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem>();
				for (int j = 0; j < context.Length("DescribeBaseStatistics.BaseStatistics["+ i +"].MaleAgeItems.Length"); j++) {
					DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem ageItem = new DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem();
					ageItem.Name = context.StringValue("DescribeBaseStatistics.BaseStatistics["+ i +"].MaleAgeItems["+ j +"].Name");
					ageItem.Count = context.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].MaleAgeItems["+ j +"].Count");

					baseStatisticsItem_maleAgeItems.Add(ageItem);
				}
				baseStatisticsItem.MaleAgeItems = baseStatisticsItem_maleAgeItems;

				List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem> baseStatisticsItem_femaleAgeItems = new List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem>();
				for (int j = 0; j < context.Length("DescribeBaseStatistics.BaseStatistics["+ i +"].FemaleAgeItems.Length"); j++) {
					DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem ageItem = new DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem();
					ageItem.Name = context.StringValue("DescribeBaseStatistics.BaseStatistics["+ i +"].FemaleAgeItems["+ j +"].Name");
					ageItem.Count = context.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].FemaleAgeItems["+ j +"].Count");

					baseStatisticsItem_femaleAgeItems.Add(ageItem);
				}
				baseStatisticsItem.FemaleAgeItems = baseStatisticsItem_femaleAgeItems;

				describeBaseStatisticsResponse_baseStatistics.Add(baseStatisticsItem);
			}
			describeBaseStatisticsResponse.BaseStatistics = describeBaseStatisticsResponse_baseStatistics;
        
			return describeBaseStatisticsResponse;
        }
    }
}
