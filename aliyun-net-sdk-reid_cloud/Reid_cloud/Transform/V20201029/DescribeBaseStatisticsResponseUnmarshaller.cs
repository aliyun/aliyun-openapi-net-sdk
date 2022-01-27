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
using Aliyun.Acs.reid_cloud.Model.V20201029;

namespace Aliyun.Acs.reid_cloud.Transform.V20201029
{
    public class DescribeBaseStatisticsResponseUnmarshaller
    {
        public static DescribeBaseStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBaseStatisticsResponse describeBaseStatisticsResponse = new DescribeBaseStatisticsResponse();

			describeBaseStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			describeBaseStatisticsResponse.ErrorCode = _ctx.StringValue("DescribeBaseStatistics.ErrorCode");
			describeBaseStatisticsResponse.CursorTime = _ctx.StringValue("DescribeBaseStatistics.CursorTime");
			describeBaseStatisticsResponse.ErrorMessage = _ctx.StringValue("DescribeBaseStatistics.ErrorMessage");
			describeBaseStatisticsResponse.Message = _ctx.StringValue("DescribeBaseStatistics.Message");
			describeBaseStatisticsResponse.Code = _ctx.StringValue("DescribeBaseStatistics.Code");
			describeBaseStatisticsResponse.DynamicCode = _ctx.StringValue("DescribeBaseStatistics.DynamicCode");
			describeBaseStatisticsResponse.RequestId = _ctx.StringValue("DescribeBaseStatistics.RequestId");
			describeBaseStatisticsResponse.Success = _ctx.BooleanValue("DescribeBaseStatistics.Success");
			describeBaseStatisticsResponse.DynamicMessage = _ctx.StringValue("DescribeBaseStatistics.DynamicMessage");

			List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem> describeBaseStatisticsResponse_baseStatistics = new List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem>();
			for (int i = 0; i < _ctx.Length("DescribeBaseStatistics.BaseStatistics.Length"); i++) {
				DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem baseStatisticsItem = new DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem();
				baseStatisticsItem.StoreId = _ctx.LongValue("DescribeBaseStatistics.BaseStatistics["+ i +"].StoreId");
				baseStatisticsItem.FemaleUvCount = _ctx.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].FemaleUvCount");
				baseStatisticsItem.OldCount = _ctx.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].OldCount");
				baseStatisticsItem.NewCount = _ctx.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].NewCount");
				baseStatisticsItem.SummaryType = _ctx.StringValue("DescribeBaseStatistics.BaseStatistics["+ i +"].SummaryType");
				baseStatisticsItem.MaleUvCount = _ctx.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].MaleUvCount");
				baseStatisticsItem.Time = _ctx.StringValue("DescribeBaseStatistics.BaseStatistics["+ i +"].Time");
				baseStatisticsItem.LocationId = _ctx.LongValue("DescribeBaseStatistics.BaseStatistics["+ i +"].LocationId");
				baseStatisticsItem.StayPeriod = _ctx.LongValue("DescribeBaseStatistics.BaseStatistics["+ i +"].StayPeriod");
				baseStatisticsItem.UvCount = _ctx.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].UvCount");
				baseStatisticsItem.OnlyBodyUvCount = _ctx.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].OnlyBodyUvCount");

				List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem> baseStatisticsItem_ageItems = new List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem>();
				for (int j = 0; j < _ctx.Length("DescribeBaseStatistics.BaseStatistics["+ i +"].AgeItems.Length"); j++) {
					DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem ageItem = new DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem();
					ageItem.Name = _ctx.StringValue("DescribeBaseStatistics.BaseStatistics["+ i +"].AgeItems["+ j +"].Name");
					ageItem.Count = _ctx.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].AgeItems["+ j +"].Count");

					baseStatisticsItem_ageItems.Add(ageItem);
				}
				baseStatisticsItem.AgeItems = baseStatisticsItem_ageItems;

				List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_StayDistributionItem> baseStatisticsItem_stayDistributionItems = new List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_StayDistributionItem>();
				for (int j = 0; j < _ctx.Length("DescribeBaseStatistics.BaseStatistics["+ i +"].StayDistributionItems.Length"); j++) {
					DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_StayDistributionItem stayDistributionItem = new DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_StayDistributionItem();
					stayDistributionItem.StartTs = _ctx.LongValue("DescribeBaseStatistics.BaseStatistics["+ i +"].StayDistributionItems["+ j +"].StartTs");
					stayDistributionItem.EndTs = _ctx.LongValue("DescribeBaseStatistics.BaseStatistics["+ i +"].StayDistributionItems["+ j +"].EndTs");
					stayDistributionItem.Count = _ctx.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].StayDistributionItems["+ j +"].Count");

					baseStatisticsItem_stayDistributionItems.Add(stayDistributionItem);
				}
				baseStatisticsItem.StayDistributionItems = baseStatisticsItem_stayDistributionItems;

				List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem> baseStatisticsItem_maleAgeItems = new List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem>();
				for (int j = 0; j < _ctx.Length("DescribeBaseStatistics.BaseStatistics["+ i +"].MaleAgeItems.Length"); j++) {
					DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem ageItem = new DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem();
					ageItem.Name = _ctx.StringValue("DescribeBaseStatistics.BaseStatistics["+ i +"].MaleAgeItems["+ j +"].Name");
					ageItem.Count = _ctx.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].MaleAgeItems["+ j +"].Count");

					baseStatisticsItem_maleAgeItems.Add(ageItem);
				}
				baseStatisticsItem.MaleAgeItems = baseStatisticsItem_maleAgeItems;

				List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem> baseStatisticsItem_femaleAgeItems = new List<DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem>();
				for (int j = 0; j < _ctx.Length("DescribeBaseStatistics.BaseStatistics["+ i +"].FemaleAgeItems.Length"); j++) {
					DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem ageItem = new DescribeBaseStatisticsResponse.DescribeBaseStatistics_BaseStatisticsItem.DescribeBaseStatistics_AgeItem();
					ageItem.Name = _ctx.StringValue("DescribeBaseStatistics.BaseStatistics["+ i +"].FemaleAgeItems["+ j +"].Name");
					ageItem.Count = _ctx.IntegerValue("DescribeBaseStatistics.BaseStatistics["+ i +"].FemaleAgeItems["+ j +"].Count");

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
