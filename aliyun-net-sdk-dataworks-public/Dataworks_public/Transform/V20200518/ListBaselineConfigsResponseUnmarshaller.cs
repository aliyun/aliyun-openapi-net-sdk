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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListBaselineConfigsResponseUnmarshaller
    {
        public static ListBaselineConfigsResponse Unmarshall(UnmarshallerContext context)
        {
			ListBaselineConfigsResponse listBaselineConfigsResponse = new ListBaselineConfigsResponse();

			listBaselineConfigsResponse.HttpResponse = context.HttpResponse;
			listBaselineConfigsResponse.Success = context.BooleanValue("ListBaselineConfigs.Success");
			listBaselineConfigsResponse.ErrorCode = context.StringValue("ListBaselineConfigs.ErrorCode");
			listBaselineConfigsResponse.ErrorMessage = context.StringValue("ListBaselineConfigs.ErrorMessage");
			listBaselineConfigsResponse.HttpStatusCode = context.IntegerValue("ListBaselineConfigs.HttpStatusCode");
			listBaselineConfigsResponse.RequestId = context.StringValue("ListBaselineConfigs.RequestId");

			ListBaselineConfigsResponse.ListBaselineConfigs_Data data = new ListBaselineConfigsResponse.ListBaselineConfigs_Data();
			data.PageNumber = context.IntegerValue("ListBaselineConfigs.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListBaselineConfigs.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListBaselineConfigs.Data.TotalCount");

			List<ListBaselineConfigsResponse.ListBaselineConfigs_Data.ListBaselineConfigs_BaselinesItem> data_baselines = new List<ListBaselineConfigsResponse.ListBaselineConfigs_Data.ListBaselineConfigs_BaselinesItem>();
			for (int i = 0; i < context.Length("ListBaselineConfigs.Data.Baselines.Length"); i++) {
				ListBaselineConfigsResponse.ListBaselineConfigs_Data.ListBaselineConfigs_BaselinesItem baselinesItem = new ListBaselineConfigsResponse.ListBaselineConfigs_Data.ListBaselineConfigs_BaselinesItem();
				baselinesItem.BaselineId = context.LongValue("ListBaselineConfigs.Data.Baselines["+ i +"].BaselineId");
				baselinesItem.Priority = context.IntegerValue("ListBaselineConfigs.Data.Baselines["+ i +"].Priority");
				baselinesItem.BaselineName = context.StringValue("ListBaselineConfigs.Data.Baselines["+ i +"].BaselineName");
				baselinesItem.Owner = context.StringValue("ListBaselineConfigs.Data.Baselines["+ i +"].Owner");
				baselinesItem.ProjectId = context.LongValue("ListBaselineConfigs.Data.Baselines["+ i +"].ProjectId");
				baselinesItem.UseFlag = context.BooleanValue("ListBaselineConfigs.Data.Baselines["+ i +"].UseFlag");
				baselinesItem.BaselineType = context.StringValue("ListBaselineConfigs.Data.Baselines["+ i +"].BaselineType");
				baselinesItem.ExpHour = context.IntegerValue("ListBaselineConfigs.Data.Baselines["+ i +"].ExpHour");
				baselinesItem.ExpMinu = context.IntegerValue("ListBaselineConfigs.Data.Baselines["+ i +"].ExpMinu");
				baselinesItem.SlaHour = context.IntegerValue("ListBaselineConfigs.Data.Baselines["+ i +"].SlaHour");
				baselinesItem.SlaMinu = context.IntegerValue("ListBaselineConfigs.Data.Baselines["+ i +"].SlaMinu");
				baselinesItem.HourExpDetail = context.StringValue("ListBaselineConfigs.Data.Baselines["+ i +"].HourExpDetail");
				baselinesItem.HourSlaDetail = context.StringValue("ListBaselineConfigs.Data.Baselines["+ i +"].HourSlaDetail");
				baselinesItem.IsDefault = context.BooleanValue("ListBaselineConfigs.Data.Baselines["+ i +"].IsDefault");

				data_baselines.Add(baselinesItem);
			}
			data.Baselines = data_baselines;
			listBaselineConfigsResponse.Data = data;
        
			return listBaselineConfigsResponse;
        }
    }
}
