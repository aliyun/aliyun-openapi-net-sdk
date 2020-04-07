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
using Aliyun.Acs.cusanalytic_sc_online.Model.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524
{
    public class GetBaseAgeDataResponseUnmarshaller
    {
        public static GetBaseAgeDataResponse Unmarshall(UnmarshallerContext context)
        {
			GetBaseAgeDataResponse getBaseAgeDataResponse = new GetBaseAgeDataResponse();

			getBaseAgeDataResponse.HttpResponse = context.HttpResponse;
			getBaseAgeDataResponse.Day = context.StringValue("GetBaseAgeData.Day");
			getBaseAgeDataResponse.StoreId = context.LongValue("GetBaseAgeData.StoreId");
			getBaseAgeDataResponse.ErrorMsg = context.StringValue("GetBaseAgeData.ErrorMsg");
			getBaseAgeDataResponse.Hour = context.StringValue("GetBaseAgeData.Hour");
			getBaseAgeDataResponse.LocationId = context.LongValue("GetBaseAgeData.LocationId");
			getBaseAgeDataResponse.SummaryType = context.StringValue("GetBaseAgeData.SummaryType");
			getBaseAgeDataResponse.Success = context.BooleanValue("GetBaseAgeData.Success");

			List<GetBaseAgeDataResponse.GetBaseAgeData_AgeItem> getBaseAgeDataResponse_ageItems = new List<GetBaseAgeDataResponse.GetBaseAgeData_AgeItem>();
			for (int i = 0; i < context.Length("GetBaseAgeData.AgeItems.Length"); i++) {
				GetBaseAgeDataResponse.GetBaseAgeData_AgeItem ageItem = new GetBaseAgeDataResponse.GetBaseAgeData_AgeItem();
				ageItem.Name = context.StringValue("GetBaseAgeData.AgeItems["+ i +"].Name");
				ageItem.Count = context.IntegerValue("GetBaseAgeData.AgeItems["+ i +"].Count");

				getBaseAgeDataResponse_ageItems.Add(ageItem);
			}
			getBaseAgeDataResponse.AgeItems = getBaseAgeDataResponse_ageItems;

			List<GetBaseAgeDataResponse.GetBaseAgeData_AgeItem> getBaseAgeDataResponse_femaleAgeItems = new List<GetBaseAgeDataResponse.GetBaseAgeData_AgeItem>();
			for (int i = 0; i < context.Length("GetBaseAgeData.FemaleAgeItems.Length"); i++) {
				GetBaseAgeDataResponse.GetBaseAgeData_AgeItem ageItem = new GetBaseAgeDataResponse.GetBaseAgeData_AgeItem();
				ageItem.Name = context.StringValue("GetBaseAgeData.FemaleAgeItems["+ i +"].Name");
				ageItem.Count = context.IntegerValue("GetBaseAgeData.FemaleAgeItems["+ i +"].Count");

				getBaseAgeDataResponse_femaleAgeItems.Add(ageItem);
			}
			getBaseAgeDataResponse.FemaleAgeItems = getBaseAgeDataResponse_femaleAgeItems;

			List<GetBaseAgeDataResponse.GetBaseAgeData_AgeItem> getBaseAgeDataResponse_maleAgeItems = new List<GetBaseAgeDataResponse.GetBaseAgeData_AgeItem>();
			for (int i = 0; i < context.Length("GetBaseAgeData.MaleAgeItems.Length"); i++) {
				GetBaseAgeDataResponse.GetBaseAgeData_AgeItem ageItem = new GetBaseAgeDataResponse.GetBaseAgeData_AgeItem();
				ageItem.Name = context.StringValue("GetBaseAgeData.MaleAgeItems["+ i +"].Name");
				ageItem.Count = context.IntegerValue("GetBaseAgeData.MaleAgeItems["+ i +"].Count");

				getBaseAgeDataResponse_maleAgeItems.Add(ageItem);
			}
			getBaseAgeDataResponse.MaleAgeItems = getBaseAgeDataResponse_maleAgeItems;
        
			return getBaseAgeDataResponse;
        }
    }
}
