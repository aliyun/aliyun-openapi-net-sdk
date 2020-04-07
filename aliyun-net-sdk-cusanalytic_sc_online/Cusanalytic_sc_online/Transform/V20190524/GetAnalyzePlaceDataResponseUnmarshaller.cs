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
    public class GetAnalyzePlaceDataResponseUnmarshaller
    {
        public static GetAnalyzePlaceDataResponse Unmarshall(UnmarshallerContext context)
        {
			GetAnalyzePlaceDataResponse getAnalyzePlaceDataResponse = new GetAnalyzePlaceDataResponse();

			getAnalyzePlaceDataResponse.HttpResponse = context.HttpResponse;
			getAnalyzePlaceDataResponse.Count = context.LongValue("GetAnalyzePlaceData.Count");
			getAnalyzePlaceDataResponse.StoreId = context.LongValue("GetAnalyzePlaceData.StoreId");
			getAnalyzePlaceDataResponse.Percent = context.FloatValue("GetAnalyzePlaceData.Percent");
			getAnalyzePlaceDataResponse.LocationName = context.StringValue("GetAnalyzePlaceData.LocationName");
			getAnalyzePlaceDataResponse.ParentLocationIds = context.StringValue("GetAnalyzePlaceData.ParentLocationIds");
			getAnalyzePlaceDataResponse.LocationId = context.LongValue("GetAnalyzePlaceData.LocationId");

			List<GetAnalyzePlaceDataResponse.GetAnalyzePlaceData_AnalyzePlaceItem> getAnalyzePlaceDataResponse_analyzePlaceItems = new List<GetAnalyzePlaceDataResponse.GetAnalyzePlaceData_AnalyzePlaceItem>();
			for (int i = 0; i < context.Length("GetAnalyzePlaceData.AnalyzePlaceItems.Length"); i++) {
				GetAnalyzePlaceDataResponse.GetAnalyzePlaceData_AnalyzePlaceItem analyzePlaceItem = new GetAnalyzePlaceDataResponse.GetAnalyzePlaceData_AnalyzePlaceItem();
				analyzePlaceItem.LocationName = context.StringValue("GetAnalyzePlaceData.AnalyzePlaceItems["+ i +"].LocationName");
				analyzePlaceItem.LocationId = context.LongValue("GetAnalyzePlaceData.AnalyzePlaceItems["+ i +"].LocationId");
				analyzePlaceItem.ParentLocationIds = context.StringValue("GetAnalyzePlaceData.AnalyzePlaceItems["+ i +"].ParentLocationIds");
				analyzePlaceItem.Count = context.LongValue("GetAnalyzePlaceData.AnalyzePlaceItems["+ i +"].Count");
				analyzePlaceItem.StoreId = context.LongValue("GetAnalyzePlaceData.AnalyzePlaceItems["+ i +"].StoreId");
				analyzePlaceItem.Percent = context.FloatValue("GetAnalyzePlaceData.AnalyzePlaceItems["+ i +"].Percent");
				analyzePlaceItem.MaleCount = context.IntegerValue("GetAnalyzePlaceData.AnalyzePlaceItems["+ i +"].MaleCount");
				analyzePlaceItem.FemaleCount = context.IntegerValue("GetAnalyzePlaceData.AnalyzePlaceItems["+ i +"].FemaleCount");

				List<GetAnalyzePlaceDataResponse.GetAnalyzePlaceData_AnalyzePlaceItem.GetAnalyzePlaceData_AgeItem> analyzePlaceItem_ageItems = new List<GetAnalyzePlaceDataResponse.GetAnalyzePlaceData_AnalyzePlaceItem.GetAnalyzePlaceData_AgeItem>();
				for (int j = 0; j < context.Length("GetAnalyzePlaceData.AnalyzePlaceItems["+ i +"].AgeItems.Length"); j++) {
					GetAnalyzePlaceDataResponse.GetAnalyzePlaceData_AnalyzePlaceItem.GetAnalyzePlaceData_AgeItem ageItem = new GetAnalyzePlaceDataResponse.GetAnalyzePlaceData_AnalyzePlaceItem.GetAnalyzePlaceData_AgeItem();
					ageItem.Count = context.IntegerValue("GetAnalyzePlaceData.AnalyzePlaceItems["+ i +"].AgeItems["+ j +"].Count");
					ageItem.Age = context.IntegerValue("GetAnalyzePlaceData.AnalyzePlaceItems["+ i +"].AgeItems["+ j +"].Age");

					analyzePlaceItem_ageItems.Add(ageItem);
				}
				analyzePlaceItem.AgeItems = analyzePlaceItem_ageItems;

				getAnalyzePlaceDataResponse_analyzePlaceItems.Add(analyzePlaceItem);
			}
			getAnalyzePlaceDataResponse.AnalyzePlaceItems = getAnalyzePlaceDataResponse_analyzePlaceItems;
        
			return getAnalyzePlaceDataResponse;
        }
    }
}
